using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class new_class_price_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public new_class_price_form()
        {
            InitializeComponent();

            combo_type_class.SelectedIndex = 0;
            combo_zavod.SelectedIndex = 0;
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

        private void btn_add_class_Click(object sender, EventArgs e)
        {
            try
            {
                int zav;
                int type = 0;

                zav = combo_zavod.SelectedIndex == 0 ? 1 : 2;

                type = combo_type_class.SelectedIndex == 0 ? 20 : 19;

                string name = text_name_class.Text;
                name = name.Replace("'", "`");

                SqlCommand new_clas_price = new SqlCommand(q.New_priselist_clas(name, type, zav), connection);
                new_clas_price.ExecuteNonQuery();

                MessageBox.Show("Класс прайс-листа добавлен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
