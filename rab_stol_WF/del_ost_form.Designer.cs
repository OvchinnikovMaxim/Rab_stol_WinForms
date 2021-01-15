
namespace rab_stol_WF
{
    partial class del_ost_form
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTime_ost = new System.Windows.Forms.DateTimePicker();
            this.label_date_ost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_distrID = new System.Windows.Forms.TextBox();
            this.label_distrID = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_del_ost = new System.Windows.Forms.Button();
            this.text_server = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.10561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.89439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_del_ost, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.63441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.36559F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 93);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTime_ost);
            this.panel2.Controls.Add(this.label_date_ost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(172, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 52);
            this.panel2.TabIndex = 5;
            // 
            // dateTime_ost
            // 
            this.dateTime_ost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTime_ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime_ost.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_ost.Location = new System.Drawing.Point(0, 26);
            this.dateTime_ost.Name = "dateTime_ost";
            this.dateTime_ost.Size = new System.Drawing.Size(127, 26);
            this.dateTime_ost.TabIndex = 1;
            // 
            // label_date_ost
            // 
            this.label_date_ost.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_date_ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_ost.Location = new System.Drawing.Point(0, 0);
            this.label_date_ost.Name = "label_date_ost";
            this.label_date_ost.Size = new System.Drawing.Size(127, 20);
            this.label_date_ost.TabIndex = 0;
            this.label_date_ost.Text = "Дата остатков";
            this.label_date_ost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_distrID);
            this.panel1.Controls.Add(this.label_distrID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 52);
            this.panel1.TabIndex = 4;
            // 
            // text_distrID
            // 
            this.text_distrID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_distrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_distrID.Location = new System.Drawing.Point(0, 26);
            this.text_distrID.Name = "text_distrID";
            this.text_distrID.Size = new System.Drawing.Size(163, 26);
            this.text_distrID.TabIndex = 1;
            this.text_distrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_distrID_KeyPress);
            // 
            // label_distrID
            // 
            this.label_distrID.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_distrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_distrID.Location = new System.Drawing.Point(0, 0);
            this.label_distrID.Name = "label_distrID";
            this.label_distrID.Size = new System.Drawing.Size(163, 20);
            this.label_distrID.TabIndex = 0;
            this.label_distrID.Text = "Код дистрибьютора";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(305, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(160, 35);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(172, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(127, 29);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_del_ost
            // 
            this.btn_del_ost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del_ost.Location = new System.Drawing.Point(305, 38);
            this.btn_del_ost.Name = "btn_del_ost";
            this.btn_del_ost.Size = new System.Drawing.Size(160, 52);
            this.btn_del_ost.TabIndex = 2;
            this.btn_del_ost.Text = "Удалить остатки";
            this.btn_del_ost.UseVisualStyleBackColor = true;
            this.btn_del_ost.Click += new System.EventHandler(this.btn_del_ost_Click);
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(163, 26);
            this.text_server.TabIndex = 0;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // del_ost_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 117);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "del_ost_form";
            this.Text = "Удаление остатков за указанную дату";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_del_ost;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_date_ost;
        private System.Windows.Forms.TextBox text_distrID;
        private System.Windows.Forms.Label label_distrID;
        private System.Windows.Forms.DateTimePicker dateTime_ost;
    }
}