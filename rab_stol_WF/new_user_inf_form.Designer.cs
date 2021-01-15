
namespace rab_stol_WF
{
    partial class new_user_inf_form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_new_user_inf = new System.Windows.Forms.Button();
            this.text_server = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_search_login = new System.Windows.Forms.TextBox();
            this.label_search_login = new System.Windows.Forms.Label();
            this.btn_search_user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_fio = new System.Windows.Forms.TextBox();
            this.label_fio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.text_login_user = new System.Windows.Forms.TextBox();
            this.label_login_user = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_pass_user = new System.Windows.Forms.TextBox();
            this.label_pass_user = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.combo_zavod = new System.Windows.Forms.ComboBox();
            this.label_zavod = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_new_user_inf, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_search_user, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.46816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.46067F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.28994F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_new_user_inf
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_new_user_inf, 3);
            this.btn_new_user_inf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_new_user_inf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_user_inf.Location = new System.Drawing.Point(3, 190);
            this.btn_new_user_inf.Name = "btn_new_user_inf";
            this.btn_new_user_inf.Size = new System.Drawing.Size(474, 74);
            this.btn_new_user_inf.TabIndex = 0;
            this.btn_new_user_inf.Text = "Создать учетные данные";
            this.btn_new_user_inf.UseVisualStyleBackColor = true;
            this.btn_new_user_inf.Click += new System.EventHandler(this.btn_new_user_inf_Click);
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(154, 26);
            this.text_server.TabIndex = 1;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(323, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(154, 35);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(163, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(154, 29);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_search_login);
            this.panel1.Controls.Add(this.label_search_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(643, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 78);
            this.panel1.TabIndex = 4;
            // 
            // text_search_login
            // 
            this.text_search_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_search_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_search_login.Location = new System.Drawing.Point(0, 52);
            this.text_search_login.Name = "text_search_login";
            this.text_search_login.Size = new System.Drawing.Size(154, 26);
            this.text_search_login.TabIndex = 1;
            // 
            // label_search_login
            // 
            this.label_search_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_search_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search_login.Location = new System.Drawing.Point(0, 0);
            this.label_search_login.Name = "label_search_login";
            this.label_search_login.Size = new System.Drawing.Size(154, 35);
            this.label_search_login.TabIndex = 0;
            this.label_search_login.Text = "Поиск по логину";
            this.label_search_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search_user
            // 
            this.btn_search_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_search_user.Location = new System.Drawing.Point(643, 190);
            this.btn_search_user.Name = "btn_search_user";
            this.btn_search_user.Size = new System.Drawing.Size(154, 74);
            this.btn_search_user.TabIndex = 5;
            this.btn_search_user.Text = "Поиск";
            this.btn_search_user.UseVisualStyleBackColor = true;
            this.btn_search_user.Click += new System.EventHandler(this.btn_search_user_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.text_fio);
            this.panel2.Controls.Add(this.label_fio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 78);
            this.panel2.TabIndex = 6;
            // 
            // text_fio
            // 
            this.text_fio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_fio.Location = new System.Drawing.Point(0, 49);
            this.text_fio.Name = "text_fio";
            this.text_fio.Size = new System.Drawing.Size(474, 29);
            this.text_fio.TabIndex = 1;
            // 
            // label_fio
            // 
            this.label_fio.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fio.Location = new System.Drawing.Point(0, 0);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(474, 35);
            this.label_fio.TabIndex = 0;
            this.label_fio.Text = "Фамилия Имя Отчество";
            this.label_fio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.text_login_user);
            this.panel3.Controls.Add(this.label_login_user);
            this.panel3.Location = new System.Drawing.Point(3, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 62);
            this.panel3.TabIndex = 7;
            // 
            // text_login_user
            // 
            this.text_login_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_login_user.Location = new System.Drawing.Point(0, 36);
            this.text_login_user.Name = "text_login_user";
            this.text_login_user.Size = new System.Drawing.Size(154, 26);
            this.text_login_user.TabIndex = 1;
            // 
            // label_login_user
            // 
            this.label_login_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login_user.Location = new System.Drawing.Point(0, 0);
            this.label_login_user.Name = "label_login_user";
            this.label_login_user.Size = new System.Drawing.Size(154, 23);
            this.label_login_user.TabIndex = 0;
            this.label_login_user.Text = "Логин";
            this.label_login_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.text_pass_user);
            this.panel4.Controls.Add(this.label_pass_user);
            this.panel4.Location = new System.Drawing.Point(163, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 62);
            this.panel4.TabIndex = 8;
            // 
            // text_pass_user
            // 
            this.text_pass_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_pass_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_pass_user.Location = new System.Drawing.Point(0, 36);
            this.text_pass_user.Name = "text_pass_user";
            this.text_pass_user.Size = new System.Drawing.Size(154, 26);
            this.text_pass_user.TabIndex = 1;
            // 
            // label_pass_user
            // 
            this.label_pass_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_pass_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass_user.Location = new System.Drawing.Point(0, 0);
            this.label_pass_user.Name = "label_pass_user";
            this.label_pass_user.Size = new System.Drawing.Size(154, 23);
            this.label_pass_user.TabIndex = 0;
            this.label_pass_user.Text = "Пароль";
            this.label_pass_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.combo_zavod);
            this.panel5.Controls.Add(this.label_zavod);
            this.panel5.Location = new System.Drawing.Point(323, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 62);
            this.panel5.TabIndex = 9;
            // 
            // combo_zavod
            // 
            this.combo_zavod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combo_zavod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_zavod.FormattingEnabled = true;
            this.combo_zavod.Items.AddRange(new object[] {
            "НК",
            "КЖК, НБП"});
            this.combo_zavod.Location = new System.Drawing.Point(0, 34);
            this.combo_zavod.Name = "combo_zavod";
            this.combo_zavod.Size = new System.Drawing.Size(154, 28);
            this.combo_zavod.TabIndex = 1;
            // 
            // label_zavod
            // 
            this.label_zavod.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_zavod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_zavod.Location = new System.Drawing.Point(0, 0);
            this.label_zavod.Name = "label_zavod";
            this.label_zavod.Size = new System.Drawing.Size(154, 23);
            this.label_zavod.TabIndex = 0;
            this.label_zavod.Text = "Завод";
            this.label_zavod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // new_user_inf_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "new_user_inf_form";
            this.Text = "Новый пользователь программ маркет";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_new_user_inf;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search_user;
        private System.Windows.Forms.Label label_search_login;
        private System.Windows.Forms.TextBox text_search_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_fio;
        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_login_user;
        private System.Windows.Forms.Label label_login_user;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox text_pass_user;
        private System.Windows.Forms.Label label_pass_user;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox combo_zavod;
        private System.Windows.Forms.Label label_zavod;
    }
}