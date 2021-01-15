using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class copyTT_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public copyTT_form()
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

        private void text_to_contr_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_from_contr_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_to_sector_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_from_sector_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void btn_coping_Click(object sender, EventArgs e)
        {
            try
            {
                int sectorFrom = Convert.ToInt32(text_from_sector.Text);
                int sectorTo = Convert.ToInt32(text_to_sector.Text);
                int contractorFrom = Convert.ToInt32(text_from_contr.Text);
                int contractorTo = Convert.ToInt32(text_to_contr.Text);

                SqlCommand copyTT = new SqlCommand(q.copyTT_distr_sector(sectorFrom, sectorTo, contractorFrom, contractorTo), connection);
                copyTT.ExecuteNonQuery();

                MessageBox.Show("Копирование завершено", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
