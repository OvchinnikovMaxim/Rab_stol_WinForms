
namespace rab_stol_WF
{
    partial class workSQL_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workSQL_form));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_new_distr = new System.Windows.Forms.Button();
            this.btn_new_tek = new System.Windows.Forms.Button();
            this.btn_new_user_inf = new System.Windows.Forms.Button();
            this.btn_copyTT = new System.Windows.Forms.Button();
            this.btn_delZAKAZ_in_ZAKAZHAT = new System.Windows.Forms.Button();
            this.btn_new_attr = new System.Windows.Forms.Button();
            this.btn_del_ost = new System.Windows.Forms.Button();
            this.btn_class_price = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_new_distr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_new_tek, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_new_user_inf, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_copyTT, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_delZAKAZ_in_ZAKAZHAT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_new_attr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_del_ost, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_class_price, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_new_distr
            // 
            this.btn_new_distr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_distr.Location = new System.Drawing.Point(3, 3);
            this.btn_new_distr.Name = "btn_new_distr";
            this.btn_new_distr.Size = new System.Drawing.Size(115, 119);
            this.btn_new_distr.TabIndex = 0;
            this.btn_new_distr.Text = "Учетные данные для нового дистра";
            this.btn_new_distr.UseVisualStyleBackColor = true;
            this.btn_new_distr.Click += new System.EventHandler(this.btn_new_distr_Click);
            // 
            // btn_new_tek
            // 
            this.btn_new_tek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_tek.Location = new System.Drawing.Point(124, 3);
            this.btn_new_tek.Name = "btn_new_tek";
            this.btn_new_tek.Size = new System.Drawing.Size(115, 119);
            this.btn_new_tek.TabIndex = 1;
            this.btn_new_tek.Text = "Новая транспортная компания";
            this.btn_new_tek.UseVisualStyleBackColor = true;
            this.btn_new_tek.Click += new System.EventHandler(this.btn_new_tek_Click);
            // 
            // btn_new_user_inf
            // 
            this.btn_new_user_inf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_user_inf.Location = new System.Drawing.Point(245, 3);
            this.btn_new_user_inf.Name = "btn_new_user_inf";
            this.btn_new_user_inf.Size = new System.Drawing.Size(115, 119);
            this.btn_new_user_inf.TabIndex = 2;
            this.btn_new_user_inf.Text = "Новый сотрудник для программ на делфи";
            this.btn_new_user_inf.UseVisualStyleBackColor = true;
            this.btn_new_user_inf.Click += new System.EventHandler(this.btn_new_user_inf_Click);
            // 
            // btn_copyTT
            // 
            this.btn_copyTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_copyTT.Location = new System.Drawing.Point(366, 3);
            this.btn_copyTT.Name = "btn_copyTT";
            this.btn_copyTT.Size = new System.Drawing.Size(117, 119);
            this.btn_copyTT.TabIndex = 3;
            this.btn_copyTT.Text = "Копирование ТТ с сектора на сектор";
            this.btn_copyTT.UseVisualStyleBackColor = true;
            this.btn_copyTT.Click += new System.EventHandler(this.btn_copyTT_Click);
            // 
            // btn_delZAKAZ_in_ZAKAZHAT
            // 
            this.btn_delZAKAZ_in_ZAKAZHAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delZAKAZ_in_ZAKAZHAT.Location = new System.Drawing.Point(3, 128);
            this.btn_delZAKAZ_in_ZAKAZHAT.Name = "btn_delZAKAZ_in_ZAKAZHAT";
            this.btn_delZAKAZ_in_ZAKAZHAT.Size = new System.Drawing.Size(115, 119);
            this.btn_delZAKAZ_in_ZAKAZHAT.TabIndex = 4;
            this.btn_delZAKAZ_in_ZAKAZHAT.Text = "Удаление заказа в ZAKAZ_HAT";
            this.btn_delZAKAZ_in_ZAKAZHAT.UseVisualStyleBackColor = true;
            this.btn_delZAKAZ_in_ZAKAZHAT.Click += new System.EventHandler(this.btn_delZAKAZ_in_ZAKAZHAT_Click);
            // 
            // btn_new_attr
            // 
            this.btn_new_attr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_attr.Location = new System.Drawing.Point(124, 128);
            this.btn_new_attr.Name = "btn_new_attr";
            this.btn_new_attr.Size = new System.Drawing.Size(115, 119);
            this.btn_new_attr.TabIndex = 5;
            this.btn_new_attr.Text = "Новый атрибут для материалов";
            this.btn_new_attr.UseVisualStyleBackColor = true;
            this.btn_new_attr.Click += new System.EventHandler(this.btn_new_attr_Click);
            // 
            // btn_del_ost
            // 
            this.btn_del_ost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del_ost.Location = new System.Drawing.Point(245, 128);
            this.btn_del_ost.Name = "btn_del_ost";
            this.btn_del_ost.Size = new System.Drawing.Size(115, 119);
            this.btn_del_ost.TabIndex = 6;
            this.btn_del_ost.Text = "Удаление остатков";
            this.btn_del_ost.UseVisualStyleBackColor = true;
            this.btn_del_ost.Click += new System.EventHandler(this.btn_del_ost_Click);
            // 
            // btn_class_price
            // 
            this.btn_class_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_class_price.Location = new System.Drawing.Point(366, 128);
            this.btn_class_price.Name = "btn_class_price";
            this.btn_class_price.Size = new System.Drawing.Size(117, 119);
            this.btn_class_price.TabIndex = 7;
            this.btn_class_price.Text = "Новый класс прайс-листа";
            this.btn_class_price.UseVisualStyleBackColor = true;
            this.btn_class_price.Click += new System.EventHandler(this.btn_class_price_Click);
            // 
            // workSQL_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "workSQL_form";
            this.Text = "Работа с базой";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_new_distr;
        private System.Windows.Forms.Button btn_new_tek;
        private System.Windows.Forms.Button btn_new_user_inf;
        private System.Windows.Forms.Button btn_copyTT;
        private System.Windows.Forms.Button btn_delZAKAZ_in_ZAKAZHAT;
        private System.Windows.Forms.Button btn_new_attr;
        private System.Windows.Forms.Button btn_del_ost;
        private System.Windows.Forms.Button btn_class_price;
    }
}