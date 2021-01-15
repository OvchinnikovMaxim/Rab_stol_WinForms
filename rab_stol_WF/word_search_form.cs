using System;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class word_search_form : Form
    {
        public word_search_form()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SQL_searching_form sql_form = this.Owner as SQL_searching_form;
            sql_form.list_SD_search_words.Items.Add(text.Text);

            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
