using SQLquerys;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class update_sales_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        Serv_conn sc = new Serv_conn();

        DateTime date1 = new DateTime(0, 0);

        public update_sales_form()
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

        private void text_contractor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 127)
            {
                e.Handled = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataSet ds;
            SqlDataAdapter adapter;

            dataGrid_nefco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid_nefco.AllowUserToAddRows = false;
            dataGrid_nefco.AutoGenerateColumns = true;

            try
            {
                string query = @"DECLARE @distr VARCHAR(50) = '%" + text_name_distr.Text +
                        "%' ;" +
                        "SELECT d.contractor_id, d.*, ccd.fio, ccd.password, ccd.login, ccd.isMT, ccd.is_mt_sales, ccd.is_mt_ost " +
                        "FROM nefco.dbo.distr d LEFT JOIN nefco.dbo.client_card_distrpass ccd on d.distr_id=ccd.distr_id " +
                        "WHERE d.distr LIKE @distr";

                adapter = new SqlDataAdapter(query, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGrid_nefco.DataSource = ds.Tables[0];
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

        private void check_docs_UNITY_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_del_docs_UNITY.Enabled == false)
            {
                btn_del_docs_UNITY.Enabled = true;
            }
            else
            {
                btn_del_docs_UNITY.Enabled = false;
            }
        }

        private void btn_del_docs_UNITY_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand updDET_unity = new SqlCommand(q.updateDETAILS_unity(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value), connection);
                updDET_unity.CommandTimeout = 3600;
                updDET_unity.ExecuteNonQuery();

                SqlCommand updDOC_unity = new SqlCommand(q.updateDOCS_unity(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value), connection);
                updDOC_unity.CommandTimeout = 3600;
                updDOC_unity.ExecuteNonQuery();

                MessageBox.Show("Накладные в базе unity помечены на удаление", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Не был указан код дистрибьютора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        
        private void btn_docs_chek_Click(object sender, EventArgs e)
        {
            DataSet ds_nefco, ds_unity;
            SqlDataAdapter adapter_nefco, adapter_unity;
            try
            {
                dataGrid_nefco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGrid_nefco.AllowUserToAddRows = false;
                dataGrid_nefco.AutoGenerateColumns = true;

                adapter_nefco = new SqlDataAdapter(q.select_sales_Rub_NEFCO(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value), connection);
                adapter_nefco.SelectCommand.CommandTimeout = 3600;
                ds_nefco = new DataSet();
                adapter_nefco.Fill(ds_nefco);
                dataGrid_nefco.DataSource = ds_nefco.Tables[0];

                dataGrid_unity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGrid_unity.AllowUserToAddRows = false;
                dataGrid_unity.AutoGenerateColumns = true;

                adapter_unity = new SqlDataAdapter(q.select_sales_Rub_UNITY(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value), connection);
                adapter_unity.SelectCommand.CommandTimeout = 3600;
                ds_unity = new DataSet();
                adapter_unity.Fill(ds_unity);
                dataGrid_unity.DataSource = ds_unity.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_docs_obrab_Click(object sender, EventArgs e)
        {
            try
            {
                date1 = new DateTime(0, 0);
                label_check_blocking.Visible = false;
                label_time.Text = "00:00";
                timer1.Enabled = true;

                backgroundWorker2.RunWorkerAsync();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// метод, для объединения вызываемых функций для преобработки продаж
        /// </summary>
        /// <param name="contractor">Код дистрибьютора</param>
        /// <param name="begin">Дата начала периода</param>
        /// <param name="end">Дата конца периода</param>
        /// <param name="connection">подключение к серверу</param>
        void reload(int contractor, DateTime begin, DateTime end, SqlConnection connection)
        {
            SqlCommand actual = new SqlCommand(q.actualDOCS_unity(contractor, begin, end), connection);
            actual.CommandTimeout = 3600;
            actual.ExecuteNonQuery();

            SqlCommand updDET_nefco = new SqlCommand(q.updateDETAILS_nefco(contractor, begin, end), connection);
            updDET_nefco.CommandTimeout = 3600;
            updDET_nefco.ExecuteNonQuery();

            SqlCommand updDOC_nefco = new SqlCommand(q.updateDOCS_nefco(contractor, begin, end), connection);
            updDOC_nefco.CommandTimeout = 3600;
            updDOC_nefco.ExecuteNonQuery();

            SqlCommand exec_transfer_docs = new SqlCommand(q.TRANSFER_MT_DOCS_UNITY(contractor, begin, end), connection);
            exec_transfer_docs.CommandTimeout = 3600;
            exec_transfer_docs.ExecuteNonQuery();
        }
        
        private void btn_docs_pereobr_Click(object sender, EventArgs e)
        {
            DialogResult res=MessageBox.Show("1) Накладные в базе UNITY, пометятся как перепроведенные." + '\n' +
                                             "2) Детали и шапки накладных в базе NEFCO, пометятся на удаление." + '\n' +
                                             "3) Запуск обработки накладных из UNITY в NEFCO", "Вы уверены?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (res == DialogResult.OK)
            {
                try
                {
                    date1 = new DateTime(0, 0);
                    label_check_blocking.Visible = false;
                    label_time.Text = "00:00";
                    timer1.Enabled = true;
                    
                    backgroundWorker1.RunWorkerAsync();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка запроса", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Не был указан код дистрибьютора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void update_sales_form_Load(object sender, EventArgs e)
        {
            toolTip_obr.SetToolTip(btn_docs_obrab, "Обработка продаж!"+'\n'+"Отправка данных из UNITY в NEFCO");
            toolTip_reload.SetToolTip(btn_docs_pereobr, "Пометка данных на удаление в NEFCO!" + '\n' + "Обработка продаж!");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            reload(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value, connection);

            timer1.Enabled = false;

            MessageBox.Show("Переобработка продаж завершена, проверьте продажи", "Результат", MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            label_time.Text = date1.ToString("mm:ss");

            if (date1.Minute >= 1)
            {
                label_check_blocking.Visible = true;
            }
            else
            {
                label_check_blocking.Visible = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SqlCommand exec_transfer_docs = new SqlCommand(q.TRANSFER_MT_DOCS_UNITY(Convert.ToInt32(text_contractor.Text), TimePicker_date_begin.Value, TimePicker_date_end.Value), connection);
            exec_transfer_docs.CommandTimeout = 3600;
            exec_transfer_docs.ExecuteNonQuery();

            timer1.Enabled = false;

            MessageBox.Show("Обработка продаж завершена, проверьте продажи", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
