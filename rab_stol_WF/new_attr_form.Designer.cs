﻿
namespace rab_stol_WF
{
    partial class new_attr_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_name_attr = new System.Windows.Forms.TextBox();
            this.label_name_attr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combo_type_attr = new System.Windows.Forms.ComboBox();
            this.label_type_attr = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combo_zavod = new System.Windows.Forms.ComboBox();
            this.label_zavod = new System.Windows.Forms.Label();
            this.btn_add_attr = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.text_server = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.57803F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.42197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_attr, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.03604F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.96396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_name_attr);
            this.panel1.Controls.Add(this.label_name_attr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 53);
            this.panel1.TabIndex = 0;
            // 
            // text_name_attr
            // 
            this.text_name_attr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_name_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name_attr.Location = new System.Drawing.Point(0, 27);
            this.text_name_attr.Name = "text_name_attr";
            this.text_name_attr.Size = new System.Drawing.Size(173, 26);
            this.text_name_attr.TabIndex = 1;
            // 
            // label_name_attr
            // 
            this.label_name_attr.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_attr.Location = new System.Drawing.Point(0, 0);
            this.label_name_attr.Name = "label_name_attr";
            this.label_name_attr.Size = new System.Drawing.Size(173, 20);
            this.label_name_attr.TabIndex = 0;
            this.label_name_attr.Text = "Название атрибута";
            this.label_name_attr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.combo_type_attr);
            this.panel2.Controls.Add(this.label_type_attr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(182, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 53);
            this.panel2.TabIndex = 1;
            // 
            // combo_type_attr
            // 
            this.combo_type_attr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combo_type_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_type_attr.FormattingEnabled = true;
            this.combo_type_attr.Items.AddRange(new object[] {
            "Категория",
            "Бренд",
            "Серия",
            "Назначение",
            "Аромат/направление",
            "Бренд конкурента",
            "Тип упаковки",
            "Серия конкурента"});
            this.combo_type_attr.Location = new System.Drawing.Point(0, 25);
            this.combo_type_attr.Name = "combo_type_attr";
            this.combo_type_attr.Size = new System.Drawing.Size(169, 28);
            this.combo_type_attr.TabIndex = 1;
            // 
            // label_type_attr
            // 
            this.label_type_attr.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_type_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_type_attr.Location = new System.Drawing.Point(0, 0);
            this.label_type_attr.Name = "label_type_attr";
            this.label_type_attr.Size = new System.Drawing.Size(169, 20);
            this.label_type_attr.TabIndex = 0;
            this.label_type_attr.Text = "Тип атрибута";
            this.label_type_attr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.combo_zavod);
            this.panel3.Controls.Add(this.label_zavod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(357, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 53);
            this.panel3.TabIndex = 2;
            // 
            // combo_zavod
            // 
            this.combo_zavod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combo_zavod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_zavod.FormattingEnabled = true;
            this.combo_zavod.Items.AddRange(new object[] {
            "НК",
            "КЖК, НБП"});
            this.combo_zavod.Location = new System.Drawing.Point(0, 25);
            this.combo_zavod.Name = "combo_zavod";
            this.combo_zavod.Size = new System.Drawing.Size(127, 28);
            this.combo_zavod.TabIndex = 2;
            // 
            // label_zavod
            // 
            this.label_zavod.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_zavod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_zavod.Location = new System.Drawing.Point(0, 0);
            this.label_zavod.Name = "label_zavod";
            this.label_zavod.Size = new System.Drawing.Size(127, 20);
            this.label_zavod.TabIndex = 0;
            this.label_zavod.Text = "Завод";
            this.label_zavod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add_attr
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_add_attr, 3);
            this.btn_add_attr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_attr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_attr.Location = new System.Drawing.Point(3, 95);
            this.btn_add_attr.Name = "btn_add_attr";
            this.btn_add_attr.Size = new System.Drawing.Size(481, 69);
            this.btn_add_attr.TabIndex = 3;
            this.btn_add_attr.Text = "Добавить атрибут";
            this.btn_add_attr.UseVisualStyleBackColor = true;
            this.btn_add_attr.Click += new System.EventHandler(this.btn_add_attr_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(182, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(169, 27);
            this.btn_connect.TabIndex = 2;
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
            this.label_status.Location = new System.Drawing.Point(357, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(127, 33);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(173, 26);
            this.text_server.TabIndex = 6;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // new_attr_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "new_attr_form";
            this.Text = "Новый атрибут для материалов";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add_attr;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.TextBox text_name_attr;
        private System.Windows.Forms.Label label_name_attr;
        private System.Windows.Forms.ComboBox combo_type_attr;
        private System.Windows.Forms.Label label_type_attr;
        private System.Windows.Forms.ComboBox combo_zavod;
        private System.Windows.Forms.Label label_zavod;
    }
}