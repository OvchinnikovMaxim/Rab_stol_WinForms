using System;
using System.Data;
using System.Data.SqlClient;
using SQLquerys;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace rab_stol_WF
{
    public partial class new_tek_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();

        DataSet data;

        SqlDataAdapter adapter;
        public new_tek_form()
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

        private void btn_new_tek_Click(object sender, EventArgs e)
        {
            if (text_name_tek.Text == String.Empty || text_empID.Text == String.Empty)
            {
                label_name_tek.ForeColor = Color.Red;
                label_empID.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    int zav;
                    zav = combo_zavod.SelectedIndex == 0 ? 1 : 2;

                    string name = text_name_tek.Text;
                    string dogovor = text_Ndog_tek.Text;
                    string address = text_yur_adress_tek.Text;
                    string r_s = text_bank_r_s.Text;
                    string bank = text_bank_name.Text;
                    string k_s = text_bank_k_s.Text;
                    string bik = text_bank_bik.Text;
                    string inn = text_inn_tek.Text;
                    string kpp = text_kpp_tek.Text;
                    var date_n = date_dog_tek.Value;
                    string pass = text_pass.Text;
                    string login = text_login.Text;
                    int userID = Convert.ToInt32(text_empID.Text);

                    SqlCommand search_userID = new SqlCommand("select id from nefco.dbo.user_inf where id=" + userID, connection);

                    if (userID == Convert.ToInt32(search_userID.ExecuteScalar()))
                    {
                        SqlCommand new_TEK = new SqlCommand(q.new_TEK(name, zav, dogovor, address, r_s, bank, k_s, bik, inn, kpp, date_n, pass, login, userID), connection);
                        new_TEK.ExecuteNonQuery();

                        MessageBox.Show("Транспортная компания добавлена", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        label_empID.ForeColor = Color.Red;
                        MessageBox.Show("Такого сотрудника нет в базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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

        private void text_empID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_empID_TextChanged(object sender, EventArgs e)
        {
            label_empID.ForeColor = Color.Green;
        }

        private void btn_search_tek_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoGenerateColumns = true;

                adapter = new SqlDataAdapter(q.search_TEK(text_search_tek.Text), connection);
                data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
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

        private void btn_seacrh_user_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoGenerateColumns = true;

                adapter = new SqlDataAdapter(q.User_inf(text_search_user.Text), connection);
                data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
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

        private void text_name_tek_TextChanged(object sender, EventArgs e)
        {
            label_name_tek.ForeColor = Color.Green;
        }

        private void link_act_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://192.168.2.71/NefcoReports/Pages/Report.aspx?ItemPath=%2fauction_login_act");
        }

        private void new_tek_form_Load(object sender, EventArgs e)
        {
            tool_act.SetToolTip(link_act, "Имя пользователя: ssrs\\administrator" + '\n' +
                                          "Пароль: Byrke5l8byu" + '\n' +
                                          "tk contractor - код новой ТЭК" + '\n' +
                                          "ReportParameter3 = 1");
        }

        private void btn_instruction_Click(object sender, EventArgs e)
        {
            new_tek_info tek_Info = new new_tek_info();
            tek_Info.Show();
        }

        private void btn_edit_pass_Click(object sender, EventArgs e)
        {
            Edit_pass_tek edit_Pass = new Edit_pass_tek();
            edit_Pass.Show();
        }
    }
}
