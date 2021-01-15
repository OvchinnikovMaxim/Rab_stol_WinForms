using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLquerys;

namespace rab_stol_WF
{
    public partial class SQL_searching_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();

        DataSet data;

        SqlDataAdapter adapter;

        public string conSTR(string server)
        {
            SqlConnectionStringBuilder conSTR_base = new SqlConnectionStringBuilder();
            conSTR_base.DataSource = server;
            conSTR_base.IntegratedSecurity = true;

            return conSTR_base.ToString();
        }

        public SQL_searching_form()
        {
            InitializeComponent();

            combo_zavod.SelectedIndex = 0;
        }

        #region KeyPress - только числа
        private void text_user_profile_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void radio_user_inf_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_ID_distr_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_last_price_distrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_distr_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void text_prod_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }
        #endregion

        #region слова для поиска в сервис деске
        private void btn_SD_search_CreateW_Click(object sender, EventArgs e)
        {
            word_search_form word_Search = new word_search_form();
            word_Search.Owner = this;//При создании формы устанавливаем владельца
            word_Search.ShowDialog();
        }

        private void btn_SD_search_DeleteW_Click(object sender, EventArgs e)
        {
            list_SD_search_words.Items.Remove(list_SD_search_words.SelectedItem);
        }

        private void btn_SD_search_ClearW_Click(object sender, EventArgs e)
        {
            list_SD_search_words.Items.Clear();
        }
        #endregion

        private void btn_SQL_searching_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conSTR(text_server.Text));
            connection.Open();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = true;

            try
            {
                if (radio_user_inf.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.User_inf(text_user_inf.Text), connection);
                }

                if (radio_user_profile.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.user_inf_profile(Convert.ToInt32(text_user_profile.Text)), connection);
                }

                if (radio_user_NCSD.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.NCSD(text_login_user_NCSD.Text, text_name_user_NCSD.Text, text_surname_user_NCSD.Text, Convert.ToInt32(text_ID_user_NCSD.Text)), connection);
                }

                if (radio_distr.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.Distr(text_name_distr.Text, Convert.ToInt32(text_ID_distr.Text)), connection);
                }

                if (radio_login_distr.Checked == true)
                {
                    switch (combo_zavod.SelectedIndex)
                    {
                        case 0:
                            adapter = new SqlDataAdapter(q.login_distr(1), connection);
                            break;
                        case 1:
                            adapter = new SqlDataAdapter(q.login_distr(2), connection);
                            break;
                    }
                }

                if (radio_last_price_distrID.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.prod_in_last_price(Convert.ToInt32(text_last_price_distrID.Text)), connection);
                }

                if (radio_distr_price.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.distr_prices(Convert.ToInt32(text_distr_price.Text)), connection);
                }

                if (radio_prod_price.Checked == true)
                {
                    adapter = new SqlDataAdapter(q.prod_in_price(Convert.ToInt32(text_prod_price.Text)), connection);
                }

                if (radio_SD_search.Checked == true)
                {
                    int count_words = list_SD_search_words.Items.Count - 1;

                    string query = String.Empty;

                    try
                    {
                        query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; select * from sd.dbo.sd_history ";
                        query += "WHERE value LIKE '%" + list_SD_search_words.Items[0] + "%' ";

                        for (int i = 1; i < count_words; i++)
                        {
                            query += "AND value LIKE '%" + list_SD_search_words.Items[i] + "%' ";
                        }

                        if (list_SD_search_words.Items[count_words] != list_SD_search_words.Items[0])
                        {
                            query += "AND value LIKE '%" + list_SD_search_words.Items[count_words] + "%' ";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("не добавлено содержимое для поиска");
                    }
                    query += "ORDER BY 1 DESC";

                    adapter = new SqlDataAdapter(query, connection);
                }

                data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(),"Ошибка запроса",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        #region выбор для поиска
        private void radio_user_inf_Click(object sender, EventArgs e)
        {
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_user_profile_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_user_NCSD_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_distr_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_login_distr_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_last_price_distrID_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_distr_price_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_prod_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_prod_price_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_SD_search.Checked = false;

            group_SD_search.Enabled = false;
        }

        private void radio_SD_search_Click(object sender, EventArgs e)
        {
            radio_user_inf.Checked = false;
            radio_user_profile.Checked = false;
            radio_user_NCSD.Checked = false;
            radio_distr.Checked = false;
            radio_login_distr.Checked = false;
            radio_last_price_distrID.Checked = false;
            radio_distr_price.Checked = false;
            radio_prod_price.Checked = false;

            group_SD_search.Enabled = true;
        } 
        #endregion

    }
}
