using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rab_stol_WF
{
    class Serv_conn
    {
        public SqlConnection Connection(TextBox server, Label status)
        {
            SqlConnectionStringBuilder conSTR = new SqlConnectionStringBuilder();
            conSTR.DataSource = server.Text;
            conSTR.IntegratedSecurity = true;

            SqlConnection conn = new SqlConnection(conSTR.ToString());
            try
            {
                conn.Open();
                status.Text = "Подключено";
                status.ForeColor = Color.Green;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }

        public void TextChanged(SqlConnection conn, TextBox server, Label status)
        {
            SqlConnectionStringBuilder conSTR = new SqlConnectionStringBuilder();
            conSTR.DataSource = server.Text;
            conSTR.IntegratedSecurity = true;

            conn = new SqlConnection(conSTR.ToString());

            try
            {
                conn.Close();
                status.Text = "Отключено";
                status.ForeColor = Color.Red;

            }
            catch (Exception)
            {

            }
        }

        public void TextServer(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127 && number != 46)
            {
                e.Handled = true;
            }
        }

        public void TextChisla(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
            }
        }
    }
}
