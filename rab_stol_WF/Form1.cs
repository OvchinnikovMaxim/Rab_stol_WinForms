using System;
using System.Drawing;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();

            label_hello.Text += '\n' + Environment.UserName;
        }

        #region Поиск по базе
        private void SQL_searching_MouseEnter(object sender, EventArgs e)
        {
            SQL_searching.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            SQL_searching.Text = "*" + "Пользователь программ на делфи";
            SQL_searching.Text += '\n' + "*" + "Какие программы на делфи у данного пользователя";
            SQL_searching.Text += '\n' + "*" + "Пользователь NCSD";
            SQL_searching.Text += '\n' + "*" + "Информация у дистрибьюторе";
            SQL_searching.Text += '\n' + "*" + "Логины для дистрибьюторов";
            SQL_searching.Text += '\n' + "*" + "Продукция в последнем прайсе дистра";
            SQL_searching.Text += '\n' + "*" + "Список прайсов дистрибьютора";
            SQL_searching.Text += '\n' + "*" + "Продукция в прайс-листе";
            SQL_searching.Text += '\n' + "*" + "Поиск по базе сервис деска";
            SQL_searching.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void SQL_searching_MouseLeave(object sender, EventArgs e)
        {
            SQL_searching.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            SQL_searching.Text = "Поиск по базе";
            SQL_searching.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void SQL_searching_Click(object sender, EventArgs e)
        {
            SQL_searching_form Searching_Form = new SQL_searching_form();
            Searching_Form.Show();
        }

        #endregion

        #region Обработка продаж
        private void update_sales_MouseLeave(object sender, EventArgs e)
        {
            update_sales.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            update_sales.Text = "Обработка продаж";
            update_sales.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void update_sales_MouseEnter(object sender, EventArgs e)
        {
            update_sales.TextAlign = ContentAlignment.MiddleLeft;
            update_sales.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            update_sales.Text = "*" + "Проверка продаж";
            update_sales.Text += '\n' + "*" + "Обработка продаж";
            update_sales.Text += '\n' + "*" + "Переобработка продаж";
            update_sales.Text += '\n' + "*" + "Пометка продаж на удаление в базе UNITY";
            update_sales.Text += '\n' + "*" + "Поиск дистрибьютора по наименованию";
        }

        private void update_sales_Click(object sender, EventArgs e)
        {
            update_sales_form update_Sales_Form = new update_sales_form();
            update_Sales_Form.Show();
        }

        #endregion

        #region Заведение клиентских карточек
        private void create_TT_MouseEnter(object sender, EventArgs e)
        {
            create_TT.TextAlign = ContentAlignment.MiddleLeft;
            create_TT.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            create_TT.Text = "Загрузка заполненного по шаблону файла, для создания клиентских карточек";
        }

        private void create_TT_MouseLeave(object sender, EventArgs e)
        {
            create_TT.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            create_TT.Text = "Заведение клиентских карточек";
            create_TT.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void create_TT_Click(object sender, EventArgs e)
        {
            create_TT_form TT_Form = new create_TT_form();
            TT_Form.Show();
        }

        #endregion

        #region Работа с базой SQL
        private void workSQL_MouseEnter(object sender, EventArgs e)
        {
            workSQL.TextAlign = ContentAlignment.MiddleLeft;
            workSQL.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            workSQL.Text = "*" + "Новый дистрибьютор";
            workSQL.Text += '\n' + "*" + "Новая транспортная";
            workSQL.Text += '\n' + "*" + "Новый пользователь программ на делфи";
            workSQL.Text += '\n' + "*" + "Копирование ТТ с сектора на сектор";
            workSQL.Text += '\n' + "*" + "Удаление заказа в ZAKAZ_HAT";
            workSQL.Text += '\n' + "*" + "Новый атрибут для материалов";
            workSQL.Text += '\n' + "*" + "Удаление остатков";
            workSQL.Text += '\n' + "*" + "Новый класс прайс-листа";
        }

        private void workSQL_MouseLeave(object sender, EventArgs e)
        {
            workSQL.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            workSQL.Text = "Работа с базой";
            workSQL.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void workSQL_Click(object sender, EventArgs e)
        {
            workSQL_form workSQLF = new workSQL_form();
            workSQLF.Show();
        } 
        #endregion

    }
}
