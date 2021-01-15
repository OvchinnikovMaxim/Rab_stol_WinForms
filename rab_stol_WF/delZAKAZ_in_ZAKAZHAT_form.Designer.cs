
namespace rab_stol_WF
{
    partial class delZAKAZ_in_ZAKAZHAT_form
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
            this.text_server = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_zakazID = new System.Windows.Forms.TextBox();
            this.label_zakazID = new System.Windows.Forms.Label();
            this.btn_del_zakaz = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_comment = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_del_zakaz, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.7757F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.2243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 227);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(158, 26);
            this.text_server.TabIndex = 0;
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
            this.label_status.Location = new System.Drawing.Point(331, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(153, 32);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(167, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(158, 26);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_zakazID);
            this.panel1.Controls.Add(this.label_zakazID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 64);
            this.panel1.TabIndex = 3;
            // 
            // text_zakazID
            // 
            this.text_zakazID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_zakazID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_zakazID.Location = new System.Drawing.Point(0, 38);
            this.text_zakazID.Name = "text_zakazID";
            this.text_zakazID.Size = new System.Drawing.Size(158, 26);
            this.text_zakazID.TabIndex = 1;
            this.text_zakazID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_zakazID_KeyPress);
            // 
            // label_zakazID
            // 
            this.label_zakazID.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_zakazID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_zakazID.Location = new System.Drawing.Point(0, 0);
            this.label_zakazID.Name = "label_zakazID";
            this.label_zakazID.Size = new System.Drawing.Size(158, 32);
            this.label_zakazID.TabIndex = 0;
            this.label_zakazID.Text = "Номер заказа";
            this.label_zakazID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_del_zakaz
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_del_zakaz, 2);
            this.btn_del_zakaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_del_zakaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del_zakaz.Location = new System.Drawing.Point(167, 35);
            this.btn_del_zakaz.Name = "btn_del_zakaz";
            this.btn_del_zakaz.Size = new System.Drawing.Size(317, 64);
            this.btn_del_zakaz.TabIndex = 4;
            this.btn_del_zakaz.Text = "Удалить заказ";
            this.btn_del_zakaz.UseVisualStyleBackColor = true;
            this.btn_del_zakaz.Click += new System.EventHandler(this.btn_del_zakaz_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 3);
            this.panel2.Controls.Add(this.text_comment);
            this.panel2.Controls.Add(this.label_comment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 119);
            this.panel2.TabIndex = 5;
            // 
            // text_comment
            // 
            this.text_comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_comment.Location = new System.Drawing.Point(0, 20);
            this.text_comment.Multiline = true;
            this.text_comment.Name = "text_comment";
            this.text_comment.Size = new System.Drawing.Size(481, 99);
            this.text_comment.TabIndex = 1;
            this.text_comment.Text = "Заказ вручную удален из базы данных. Пользователь: Овчинников М. По обращению: Со" +
    "колов Д. Причина: Задублировалась при выгрузке из 1С.";
            // 
            // label_comment
            // 
            this.label_comment.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_comment.Location = new System.Drawing.Point(0, 0);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(481, 20);
            this.label_comment.TabIndex = 0;
            this.label_comment.Text = "Комментарий";
            this.label_comment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delZAKAZ_in_ZAKAZHAT_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "delZAKAZ_in_ZAKAZHAT_form";
            this.Text = "Удаление заказа в ZAKAZ_HAT";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_zakazID;
        private System.Windows.Forms.Label label_zakazID;
        private System.Windows.Forms.Button btn_del_zakaz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_comment;
        private System.Windows.Forms.Label label_comment;
    }
}