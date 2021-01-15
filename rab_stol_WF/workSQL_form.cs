using System;
using System.Windows.Forms;

namespace rab_stol_WF
{
    public partial class workSQL_form : Form
    {
        public workSQL_form()
        {
            InitializeComponent();
        }

        #region вызов соответствующей формы
        private void btn_new_distr_Click(object sender, EventArgs e)
        {
            new_distr_form new_Distr = new new_distr_form();
            new_Distr.Show();
        }

        private void btn_new_tek_Click(object sender, EventArgs e)
        {
            new_tek_form new_Tek = new new_tek_form();
            new_Tek.Show();
        }

        private void btn_new_user_inf_Click(object sender, EventArgs e)
        {
            new_user_inf_form new_User_Inf = new new_user_inf_form();
            new_User_Inf.Show();
        }

        private void btn_copyTT_Click(object sender, EventArgs e)
        {
            copyTT_form copyTT = new copyTT_form();
            copyTT.Show();
        }

        private void btn_delZAKAZ_in_ZAKAZHAT_Click(object sender, EventArgs e)
        {
            delZAKAZ_in_ZAKAZHAT_form delZAKAZ = new delZAKAZ_in_ZAKAZHAT_form();
            delZAKAZ.Show();
        }

        private void btn_new_attr_Click(object sender, EventArgs e)
        {
            new_attr_form new_Attr = new new_attr_form();
            new_Attr.Show();
        }

        private void btn_del_ost_Click(object sender, EventArgs e)
        {
            del_ost_form del_Ost = new del_ost_form();
            del_Ost.Show();
        }
        
        private void btn_class_price_Click(object sender, EventArgs e)
        {
            new_class_price_form new_Class_Price = new new_class_price_form();
            new_Class_Price.Show();
        }
        #endregion
    }
}
