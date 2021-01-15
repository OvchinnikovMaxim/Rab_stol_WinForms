using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SQLquerys;
using Excel = Microsoft.Office.Interop.Excel;


namespace rab_stol_WF
{
    public partial class create_TT_form : Form
    {
        SqlConnection connection;

        Query q = new Query();

        DataTable dt_excel;

        Serv_conn sc = new Serv_conn();

        public create_TT_form()
        {
            InitializeComponent();

            combo_zav.SelectedIndex = 0;
        }

        private void text_server_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextServer(e);
        }

        private void text_server_TextChanged(object sender, EventArgs e)
        {
            sc.TextChanged(connection, text_server, label_status_connect);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            connection = sc.Connection(text_server, label_status_connect);
        }

        /// <summary>
        /// выбор файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_file_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openFileDialog1.FileName;

            label_file.Text = filename.Substring(filename.LastIndexOf('\\') + 1);

            
            dt_excel = get_exceldata(filename);

            #region удаление пустых строк
            for (int i = dt_excel.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = dt_excel.Rows[i];
                if (dr[1].ToString() == "")
                {
                    dr.Delete();
                }
            }
            dt_excel.AcceptChanges(); 
            #endregion

        }

        /// <summary>
        /// запись значений из excel в таблицу даных
        /// </summary>
        /// <param name="filename">файл</param>
        /// <returns>таблица с данными</returns>
        public DataTable get_exceldata(string filename)
        {
            DataTable dt = new DataTable();
            dt.Clear();

            Excel.Application app = new Excel.Application();//открыть эксель
            Excel.Workbook workbook = app.Workbooks.Open(filename);//открыть файл
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];//получить 1 лист
            Excel.Range range = worksheet.UsedRange; // набор ячеек

            object[,] data = (object[,])range.Value2; // массив значений с листа равен по размеру листу

            const int cCnt = 7; // количество колонок
            int rCnt = range.Rows.Count; // количество строк

            int row, col;

            for (col = 1; col <= cCnt; col++) //по всем колонкам
            {
                dt.Columns.Add(col.ToString(), typeof(string));

                for (row = 1; row <= rCnt; row++) // по всем строкам
                {
                    dt.Rows.Add();
                    dt.Rows[row - 1][col - 1] = data[row, col];
                }
            }

            workbook.Close(false);//закрыть не сохраняя
            app.Quit();// выйти из экселя
            GC.Collect();// сборка мусора

            return dt;
        }

        private void text_distrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            sc.TextChisla(e);
        }

        private void btn_createTT_Click(object sender, EventArgs e)
        {
            try
            {

                int zav, typeTT, kanal, sector;
                zav = combo_zav.SelectedIndex == 0 ? 1 : 2;

                int contractorID = Convert.ToInt32(text_distrID.Text);

                string inn, name, address;

                for (int i = 1; i < dt_excel.Rows.Count; i++)
                {
                    inn = dt_excel.Rows[i][3].ToString();
                    name = dt_excel.Rows[i][1].ToString();
                    name = name.Replace("'", "`");

                    address = dt_excel.Rows[i][2].ToString();

                    typeTT = Convert.ToInt32(dt_excel.Rows[i][6]);
                    kanal = Convert.ToInt32(dt_excel.Rows[i][4]);
                    sector = Convert.ToInt32(dt_excel.Rows[i][5]);

                    SqlCommand cr_TT = new SqlCommand(q.create_newTT(zav, inn, name, address, typeTT, kanal, sector, contractorID), connection);
                    cr_TT.ExecuteNonQuery();
                }

                int countTT = dt_excel.Rows.Count - 1;
                MessageBox.Show("Количество созданных карточек = " + countTT, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void create_TT_form_FormClosing(object sender, FormClosingEventArgs e)
        {
           try
           {
                connection.Close();
           }
           catch (Exception)
           {

           }
            
        }
    }
}
