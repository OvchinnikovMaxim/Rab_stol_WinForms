using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class new_distr_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public new_distr_form()
        {
            InitializeComponent();

            combo_zavod.SelectedIndex = 0;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            connection = sc.Connection(text_server, label_status);
        }

        private void text_server_TextChanged(object sender, EventArgs e)
        {
            sc.TextChanged(connection, text_server, label_status);
        }

        private void text_server_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextServer(e);
        }

        private void text_distrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void btn_create_distr_Click(object sender, EventArgs e)
        {
            try
            {
                int zav, mobile, modul;

                zav = combo_zavod.SelectedIndex == 0 ? 1 : 2;

                mobile = check_mobile_trade.Checked == true ? 1 : 0;

                modul = check_integr_modul.Checked == true ? 1 : 0;

                SqlCommand new_distr = new SqlCommand(q.new_distr(Convert.ToInt32(text_distrID.Text), zav, text_pass.Text, text_login.Text, mobile, modul), connection);

                new_distr.ExecuteNonQuery();

                MessageBox.Show("Учетные данные добавлены в базу данных", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Отправьте письмо с учетными данными на указанную почту дистрибьютора и в копию поставьте ответственного сотрудника Нэфиса. "+'\n'+ "Шаблон письма: data\\новый дистр\\учетные данные для установки MAPDS WEB.eml ", "Не забудьте", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void check_mobile_trade_Click(object sender, EventArgs e)
        {
            if (check_mobile_trade.Checked == false)
            {
                check_mobile_trade.Checked = true;
                if (check_integr_modul.Checked == false)
                {
                    check_integr_modul.Checked = true;
                }
            }
            else
            {
                check_mobile_trade.Checked = false;
            }
        }

        private void combo_zavod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_zavod.SelectedIndex == 0)
            {
                text_login.Text = "distr";
            }
            else
            {
                text_login.Text = "kdistr";
            }
        }

        private void check_integr_modul_Click(object sender, EventArgs e)
        {
            if (check_integr_modul.Checked == false)
            {
                check_mobile_trade.Checked = false;
            }
        }
    }
}
