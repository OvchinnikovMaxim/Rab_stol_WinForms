using System;
using System.Data.SqlClient;
using SQLquerys;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class new_attr_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();
        public new_attr_form()
        {
            InitializeComponent();

            combo_type_attr.SelectedIndex = 0;
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

        private void btn_add_attr_Click(object sender, EventArgs e)
        {
            try
            {
                int zav;
                int attr = 0;

                zav = combo_zavod.SelectedIndex == 0 ? 1 : 2;

                switch (combo_type_attr.SelectedIndex)
                {
                    case 0:
                        attr = 21; //Категория
                        break;
                    case 1:
                        attr = 22; //Бренд
                        break;
                    case 2:
                        attr = 23; //Серия
                        break;
                    case 3:
                        attr = 24; //Назначение
                        break;
                    case 4:
                        attr = 25; //Аромат/направление
                        break;
                    case 5:
                        attr = 26; //Бренд конкурента
                        break;
                    case 6:
                        attr = 27; //Тип упаковки
                        break;
                    case 7:
                        attr = 28; //Серия конкурента
                        break;
                    default:
                        MessageBox.Show("Не выбран атрибут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                string name = text_name_attr.Text;
                name = name.Replace("'", "`");

                SqlCommand new_atr_mat = new SqlCommand(q.new_material_attr(name, attr, zav), connection);
                new_atr_mat.ExecuteNonQuery();

                MessageBox.Show("Атрибут добавлен", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
