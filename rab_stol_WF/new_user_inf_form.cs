using System;
using System.Data;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class new_user_inf_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();

        DataSet data;

        SqlDataAdapter adapter;
        public new_user_inf_form()
        {
            InitializeComponent();

            combo_zavod.SelectedIndex = 0;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            connection = sc.Connection(text_server, label_status);
        }

        private void text_server_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextServer(e);
        }

        private void text_server_TextChanged(object sender, EventArgs e)
        {
            sc.TextChanged(connection, text_server, label_status);
        }

        private void btn_search_user_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoGenerateColumns = true;

                adapter = new SqlDataAdapter("select * from nefco.dbo.user_inf where user_id like '%" + text_search_login.Text + "%'", connection);

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

        private void btn_new_user_inf_Click(object sender, EventArgs e)
        {
            try
            {
                int zav = 0;
                zav = combo_zavod.SelectedIndex == 0 ? 1 : 2;

                SqlCommand new_user_inf = new SqlCommand(q.user_inf_new(text_login_user.Text, text_fio.Text, text_pass_user.Text, zav), connection);
                new_user_inf.ExecuteNonQuery();

                MessageBox.Show("Новый сотрудник добавлен в базу данных", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
