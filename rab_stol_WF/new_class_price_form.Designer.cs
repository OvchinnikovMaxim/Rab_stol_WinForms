
namespace rab_stol_WF
{
    partial class new_class_price_form
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.text_server = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_name_class = new System.Windows.Forms.TextBox();
            this.label_name_class = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_type_class = new System.Windows.Forms.Label();
            this.combo_type_class = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combo_zavod = new System.Windows.Forms.ComboBox();
            this.label_zavod = new System.Windows.Forms.Label();
            this.btn_add_class = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_class, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.03604F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.96396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(179, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(166, 27);
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
            this.label_status.Location = new System.Drawing.Point(351, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(133, 33);
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
            this.text_server.Size = new System.Drawing.Size(170, 26);
            this.text_server.TabIndex = 6;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_name_class);
            this.panel1.Controls.Add(this.label_name_class);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 53);
            this.panel1.TabIndex = 0;
            // 
            // text_name_class
            // 
            this.text_name_class.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_name_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name_class.Location = new System.Drawing.Point(0, 27);
            this.text_name_class.Name = "text_name_class";
            this.text_name_class.Size = new System.Drawing.Size(170, 26);
            this.text_name_class.TabIndex = 1;
            // 
            // label_name_class
            // 
            this.label_name_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_class.Location = new System.Drawing.Point(0, 0);
            this.label_name_class.Name = "label_name_class";
            this.label_name_class.Size = new System.Drawing.Size(170, 20);
            this.label_name_class.TabIndex = 0;
            this.label_name_class.Text = "Название класса";
            this.label_name_class.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_type_class);
            this.panel2.Controls.Add(this.combo_type_class);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(179, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 53);
            this.panel2.TabIndex = 1;
            // 
            // label_type_class
            // 
            this.label_type_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_type_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_type_class.Location = new System.Drawing.Point(0, 0);
            this.label_type_class.Name = "label_type_class";
            this.label_type_class.Size = new System.Drawing.Size(166, 20);
            this.label_type_class.TabIndex = 0;
            this.label_type_class.Text = "Тип класса";
            this.label_type_class.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_type_class
            // 
            this.combo_type_class.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.combo_type_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_type_class.FormattingEnabled = true;
            this.combo_type_class.Items.AddRange(new object[] {
            "Покупательский",
            "Клиентский"});
            this.combo_type_class.Location = new System.Drawing.Point(0, 25);
            this.combo_type_class.Name = "combo_type_class";
            this.combo_type_class.Size = new System.Drawing.Size(166, 28);
            this.combo_type_class.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.combo_zavod);
            this.panel3.Controls.Add(this.label_zavod);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(351, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 53);
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
            this.combo_zavod.Size = new System.Drawing.Size(133, 28);
            this.combo_zavod.TabIndex = 2;
            // 
            // label_zavod
            // 
            this.label_zavod.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_zavod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_zavod.Location = new System.Drawing.Point(0, 0);
            this.label_zavod.Name = "label_zavod";
            this.label_zavod.Size = new System.Drawing.Size(133, 20);
            this.label_zavod.TabIndex = 0;
            this.label_zavod.Text = "Завод";
            this.label_zavod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add_class
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_add_class, 3);
            this.btn_add_class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_class.Location = new System.Drawing.Point(3, 95);
            this.btn_add_class.Name = "btn_add_class";
            this.btn_add_class.Size = new System.Drawing.Size(481, 69);
            this.btn_add_class.TabIndex = 3;
            this.btn_add_class.Text = "Добавить класс прайс-листа";
            this.btn_add_class.UseVisualStyleBackColor = true;
            this.btn_add_class.Click += new System.EventHandler(this.btn_add_class_Click);
            // 
            // new_class_price_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "new_class_price_form";
            this.Text = "Новый класс прайс-листа";
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
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combo_zavod;
        private System.Windows.Forms.Label label_zavod;
        private System.Windows.Forms.Label label_type_class;
        private System.Windows.Forms.ComboBox combo_type_class;
        private System.Windows.Forms.TextBox text_name_class;
        private System.Windows.Forms.Label label_name_class;
        private System.Windows.Forms.Button btn_add_class;
    }
}