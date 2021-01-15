using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;


namespace rab_stol_WF
{
    public partial class del_ost_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public del_ost_form()
        {
            InitializeComponent();
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

        private void btn_del_ost_Click(object sender, EventArgs e)
        {
            try
            {
                int contr_delOst = Convert.ToInt32(text_distrID.Text);
                DateTime date_delOst = dateTime_ost.Value;

                string query = String.Empty;

                query = "DELETE FROM nefco.dbo.ost_db WHERE  contractor_id = " + contr_delOst + " AND cast (date as date) ='" + date_delOst.ToShortDateString() + "'";

                SqlCommand del_ost = new SqlCommand(query, connection);
                del_ost.ExecuteNonQuery();

                MessageBox.Show("Остатки удалены", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Не указан код дистрибьютора" + '\n' + ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не указан код дистрибьютора" + '\n' + ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
