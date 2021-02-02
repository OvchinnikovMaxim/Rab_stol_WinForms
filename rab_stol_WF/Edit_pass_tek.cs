using SQLquerys;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class Edit_pass_tek : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();

        public Edit_pass_tek()
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

        private void text_tekID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void btn_edit_pass_Click(object sender, EventArgs e)
        {
            int tekID = Convert.ToInt32(text_tekID.Text);

            string new_pas = text_new_pass.Text;

            string new_passHash = BCrypt.Net.BCrypt.HashPassword(new_pas);

            string pass_ccac = "UPDATE nefco.dbo.co_contractor_attr_transp SET password = '" + new_pas + "' WHERE contractor_id =" + tekID;

            string pass_aucHash = "UPDATE auction.dbo.users SET password='" + new_passHash + "' WHERE username = (SELECT login FROM nefco.dbo.co_contractor_attr_transp WHERE contractor_id=" + tekID + ")";

            try
            {
                SqlCommand new_pass_ccac = new SqlCommand(pass_ccac, connection);
                new_pass_ccac.ExecuteNonQuery();

                SqlCommand new_pass_Hash = new SqlCommand(pass_aucHash, connection);
                new_pass_Hash.ExecuteNonQuery();

                MessageBox.Show("Пароль изменен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
