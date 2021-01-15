
namespace rab_stol_WF
{
    partial class create_TT_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_TT_form));
            this.tableLayoutPanel_createTT = new System.Windows.Forms.TableLayoutPanel();
            this.text_server = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_status_connect = new System.Windows.Forms.Label();
            this.btn_createTT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_file = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_distrID = new System.Windows.Forms.TextBox();
            this.label_distrID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.combo_zav = new System.Windows.Forms.ComboBox();
            this.label_zavod = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel_createTT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_createTT
            // 
            this.tableLayoutPanel_createTT.ColumnCount = 3;
            this.tableLayoutPanel_createTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.74468F));
            this.tableLayoutPanel_createTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.25532F));
            this.tableLayoutPanel_createTT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271F));
            this.tableLayoutPanel_createTT.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel_createTT.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel_createTT.Controls.Add(this.label_status_connect, 2, 0);
            this.tableLayoutPanel_createTT.Controls.Add(this.btn_createTT, 2, 3);
            this.tableLayoutPanel_createTT.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel_createTT.Controls.Add(this.label_info, 0, 1);
            this.tableLayoutPanel_createTT.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel_createTT.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel_createTT.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel_createTT.Name = "tableLayoutPanel_createTT";
            this.tableLayoutPanel_createTT.RowCount = 4;
            this.tableLayoutPanel_createTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.31579F));
            this.tableLayoutPanel_createTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.68421F));
            this.tableLayoutPanel_createTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel_createTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel_createTT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_createTT.Size = new System.Drawing.Size(504, 327);
            this.tableLayoutPanel_createTT.TabIndex = 0;
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(123, 26);
            this.text_server.TabIndex = 0;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Location = new System.Drawing.Point(132, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(97, 29);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_status_connect
            // 
            this.label_status_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status_connect.ForeColor = System.Drawing.Color.Red;
            this.label_status_connect.Location = new System.Drawing.Point(235, 0);
            this.label_status_connect.Name = "label_status_connect";
            this.label_status_connect.Size = new System.Drawing.Size(266, 35);
            this.label_status_connect.TabIndex = 2;
            this.label_status_connect.Text = "Отключено";
            this.label_status_connect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_createTT
            // 
            this.btn_createTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_createTT.Location = new System.Drawing.Point(235, 268);
            this.btn_createTT.Name = "btn_createTT";
            this.btn_createTT.Size = new System.Drawing.Size(266, 56);
            this.btn_createTT.TabIndex = 5;
            this.btn_createTT.Text = "Создать";
            this.btn_createTT.UseVisualStyleBackColor = true;
            this.btn_createTT.Click += new System.EventHandler(this.btn_createTT_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel_createTT.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.btn_file);
            this.panel1.Controls.Add(this.label_file);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 45);
            this.panel1.TabIndex = 6;
            // 
            // btn_file
            // 
            this.btn_file.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_file.Location = new System.Drawing.Point(0, 22);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(498, 23);
            this.btn_file.TabIndex = 1;
            this.btn_file.Text = "Файл";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // label_file
            // 
            this.label_file.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_file.Location = new System.Drawing.Point(0, 0);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(498, 19);
            this.label_file.TabIndex = 0;
            this.label_file.Text = "Выбор файла";
            this.label_file.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_info
            // 
            this.tableLayoutPanel_createTT.SetColumnSpan(this.label_info, 3);
            this.label_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Location = new System.Drawing.Point(3, 35);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(498, 179);
            this.label_info.TabIndex = 7;
            this.label_info.Text = resources.GetString("label_info.Text");
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_distrID);
            this.panel2.Controls.Add(this.label_distrID);
            this.panel2.Location = new System.Drawing.Point(3, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 56);
            this.panel2.TabIndex = 8;
            // 
            // text_distrID
            // 
            this.text_distrID.Location = new System.Drawing.Point(9, 30);
            this.text_distrID.Name = "text_distrID";
            this.text_distrID.Size = new System.Drawing.Size(100, 20);
            this.text_distrID.TabIndex = 4;
            this.text_distrID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_distrID_KeyPress);
            // 
            // label_distrID
            // 
            this.label_distrID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_distrID.Location = new System.Drawing.Point(6, 5);
            this.label_distrID.Name = "label_distrID";
            this.label_distrID.Size = new System.Drawing.Size(112, 23);
            this.label_distrID.TabIndex = 3;
            this.label_distrID.Text = "Код дистрибьютора";
            this.label_distrID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.combo_zav);
            this.panel3.Controls.Add(this.label_zavod);
            this.panel3.Location = new System.Drawing.Point(132, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(97, 56);
            this.panel3.TabIndex = 9;
            // 
            // combo_zav
            // 
            this.combo_zav.FormattingEnabled = true;
            this.combo_zav.Items.AddRange(new object[] {
            "НК",
            "КЖК, НБП"});
            this.combo_zav.Location = new System.Drawing.Point(0, 29);
            this.combo_zav.Name = "combo_zav";
            this.combo_zav.Size = new System.Drawing.Size(97, 21);
            this.combo_zav.TabIndex = 5;
            // 
            // label_zavod
            // 
            this.label_zavod.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_zavod.Location = new System.Drawing.Point(2, 5);
            this.label_zavod.Name = "label_zavod";
            this.label_zavod.Size = new System.Drawing.Size(97, 21);
            this.label_zavod.TabIndex = 4;
            this.label_zavod.Text = "Завод";
            this.label_zavod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // create_TT_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 349);
            this.Controls.Add(this.tableLayoutPanel_createTT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "create_TT_form";
            this.Text = "Заведение клиентских карточек";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.create_TT_form_FormClosing);
            this.tableLayoutPanel_createTT.ResumeLayout(false);
            this.tableLayoutPanel_createTT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_createTT;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_status_connect;
        private System.Windows.Forms.Label label_distrID;
        private System.Windows.Forms.Label label_zavod;
        private System.Windows.Forms.Button btn_createTT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox text_distrID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox combo_zav;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}