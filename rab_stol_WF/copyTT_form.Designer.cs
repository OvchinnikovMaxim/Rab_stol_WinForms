
namespace rab_stol_WF
{
    partial class copyTT_form
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
            this.panel_all = new System.Windows.Forms.Panel();
            this.panel_contr = new System.Windows.Forms.Panel();
            this.text_to_contr = new System.Windows.Forms.TextBox();
            this.text_from_contr = new System.Windows.Forms.TextBox();
            this.label_to_contr = new System.Windows.Forms.Label();
            this.label_from_contr = new System.Windows.Forms.Label();
            this.panel_sector = new System.Windows.Forms.Panel();
            this.text_to_sector = new System.Windows.Forms.TextBox();
            this.text_from_sector = new System.Windows.Forms.TextBox();
            this.label_to_sector = new System.Windows.Forms.Label();
            this.label_from_sector = new System.Windows.Forms.Label();
            this.btn_coping = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.text_server = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_all.SuspendLayout();
            this.panel_contr.SuspendLayout();
            this.panel_sector.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.panel_all, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_coping, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.47169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_all
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel_all, 3);
            this.panel_all.Controls.Add(this.panel_contr);
            this.panel_all.Controls.Add(this.panel_sector);
            this.panel_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_all.Location = new System.Drawing.Point(3, 39);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(687, 106);
            this.panel_all.TabIndex = 2;
            // 
            // panel_contr
            // 
            this.panel_contr.Controls.Add(this.text_to_contr);
            this.panel_contr.Controls.Add(this.text_from_contr);
            this.panel_contr.Controls.Add(this.label_to_contr);
            this.panel_contr.Controls.Add(this.label_from_contr);
            this.panel_contr.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_contr.Location = new System.Drawing.Point(0, 0);
            this.panel_contr.Name = "panel_contr";
            this.panel_contr.Size = new System.Drawing.Size(349, 106);
            this.panel_contr.TabIndex = 0;
            // 
            // text_to_contr
            // 
            this.text_to_contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_to_contr.Location = new System.Drawing.Point(177, 75);
            this.text_to_contr.Name = "text_to_contr";
            this.text_to_contr.Size = new System.Drawing.Size(169, 26);
            this.text_to_contr.TabIndex = 3;
            this.text_to_contr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_to_contr_KeyPress);
            // 
            // text_from_contr
            // 
            this.text_from_contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_from_contr.Location = new System.Drawing.Point(7, 75);
            this.text_from_contr.Name = "text_from_contr";
            this.text_from_contr.Size = new System.Drawing.Size(160, 26);
            this.text_from_contr.TabIndex = 2;
            this.text_from_contr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_from_contr_KeyPress);
            // 
            // label_to_contr
            // 
            this.label_to_contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_to_contr.Location = new System.Drawing.Point(173, 11);
            this.label_to_contr.Name = "label_to_contr";
            this.label_to_contr.Size = new System.Drawing.Size(173, 53);
            this.label_to_contr.TabIndex = 1;
            this.label_to_contr.Text = "Код дистрибьютора куда копировать";
            this.label_to_contr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_from_contr
            // 
            this.label_from_contr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_from_contr.Location = new System.Drawing.Point(3, 11);
            this.label_from_contr.Name = "label_from_contr";
            this.label_from_contr.Size = new System.Drawing.Size(164, 53);
            this.label_from_contr.TabIndex = 0;
            this.label_from_contr.Text = "Код дистрибьютора откуда копировать";
            this.label_from_contr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_sector
            // 
            this.panel_sector.Controls.Add(this.text_to_sector);
            this.panel_sector.Controls.Add(this.text_from_sector);
            this.panel_sector.Controls.Add(this.label_to_sector);
            this.panel_sector.Controls.Add(this.label_from_sector);
            this.panel_sector.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sector.Location = new System.Drawing.Point(355, 0);
            this.panel_sector.Name = "panel_sector";
            this.panel_sector.Size = new System.Drawing.Size(332, 106);
            this.panel_sector.TabIndex = 1;
            // 
            // text_to_sector
            // 
            this.text_to_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_to_sector.Location = new System.Drawing.Point(173, 75);
            this.text_to_sector.Name = "text_to_sector";
            this.text_to_sector.Size = new System.Drawing.Size(148, 26);
            this.text_to_sector.TabIndex = 3;
            this.text_to_sector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_to_sector_KeyPress);
            // 
            // text_from_sector
            // 
            this.text_from_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_from_sector.Location = new System.Drawing.Point(7, 75);
            this.text_from_sector.Name = "text_from_sector";
            this.text_from_sector.Size = new System.Drawing.Size(156, 26);
            this.text_from_sector.TabIndex = 2;
            this.text_from_sector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_from_sector_KeyPress);
            // 
            // label_to_sector
            // 
            this.label_to_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_to_sector.Location = new System.Drawing.Point(169, 9);
            this.label_to_sector.Name = "label_to_sector";
            this.label_to_sector.Size = new System.Drawing.Size(152, 57);
            this.label_to_sector.TabIndex = 1;
            this.label_to_sector.Text = "Номер сектора куда копировать";
            this.label_to_sector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_from_sector
            // 
            this.label_from_sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_from_sector.Location = new System.Drawing.Point(3, 5);
            this.label_from_sector.Name = "label_from_sector";
            this.label_from_sector.Size = new System.Drawing.Size(160, 64);
            this.label_from_sector.TabIndex = 0;
            this.label_from_sector.Text = "Номер сектора откуда копировать";
            this.label_from_sector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_coping
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_coping, 3);
            this.btn_coping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_coping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_coping.Location = new System.Drawing.Point(3, 151);
            this.btn_coping.Name = "btn_coping";
            this.btn_coping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_coping.Size = new System.Drawing.Size(687, 80);
            this.btn_coping.TabIndex = 3;
            this.btn_coping.Text = "Копировать";
            this.btn_coping.UseVisualStyleBackColor = true;
            this.btn_coping.Click += new System.EventHandler(this.btn_coping_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(281, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(272, 30);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(559, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(131, 36);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(272, 26);
            this.text_server.TabIndex = 6;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // copyTT_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 257);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "copyTT_form";
            this.Text = "Копирование ТТ с сектора одного дистрибьютора на сектор другого дистрибьютора";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_all.ResumeLayout(false);
            this.panel_contr.ResumeLayout(false);
            this.panel_contr.PerformLayout();
            this.panel_sector.ResumeLayout(false);
            this.panel_sector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.Panel panel_contr;
        private System.Windows.Forms.TextBox text_to_contr;
        private System.Windows.Forms.TextBox text_from_contr;
        private System.Windows.Forms.Label label_to_contr;
        private System.Windows.Forms.Label label_from_contr;
        private System.Windows.Forms.Panel panel_sector;
        private System.Windows.Forms.Label label_to_sector;
        private System.Windows.Forms.Label label_from_sector;
        private System.Windows.Forms.Button btn_coping;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.TextBox text_from_sector;
        private System.Windows.Forms.TextBox text_to_sector;
    }
}