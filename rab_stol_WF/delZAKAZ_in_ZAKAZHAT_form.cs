using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class delZAKAZ_in_ZAKAZHAT_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public delZAKAZ_in_ZAKAZHAT_form()
        {
            InitializeComponent();
        }

        private void text_server_TextChanged(object sender, EventArgs e)
        {
            sc.TextChanged(connection, text_server, label_status);
        }

        private void text_server_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextServer(e);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            connection = sc.Connection(text_server, label_status);
        }

        private void text_zakazID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void btn_del_zakaz_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand del_zakaz = new SqlCommand(q.del_zakaz_hat(Convert.ToInt32(text_zakazID.Text), text_comment.Text), connection);
                del_zakaz.ExecuteNonQuery();

                MessageBox.Show("Заказ удален", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

    }
}
