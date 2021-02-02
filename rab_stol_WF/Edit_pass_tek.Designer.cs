
namespace rab_stol_WF
{
    partial class Edit_pass_tek
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
            this.label_status = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.text_server = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit_pass = new System.Windows.Forms.Button();
            this.label_tekID = new System.Windows.Forms.Label();
            this.text_tekID = new System.Windows.Forms.TextBox();
            this.label_new_pass = new System.Windows.Forms.Label();
            this.text_new_pass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.65663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.34337F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_edit_pass, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 98);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(342, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(237, 40);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Отключено";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(178, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(158, 34);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Подключение";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // text_server
            // 
            this.text_server.Dock = System.Windows.Forms.DockStyle.Top;
            this.text_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_server.Location = new System.Drawing.Point(3, 3);
            this.text_server.Name = "text_server";
            this.text_server.Size = new System.Drawing.Size(169, 29);
            this.text_server.TabIndex = 0;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_tekID);
            this.panel1.Controls.Add(this.label_tekID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 52);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.text_new_pass);
            this.panel2.Controls.Add(this.label_new_pass);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(178, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 52);
            this.panel2.TabIndex = 4;
            // 
            // btn_edit_pass
            // 
            this.btn_edit_pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_edit_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_pass.Location = new System.Drawing.Point(342, 43);
            this.btn_edit_pass.Name = "btn_edit_pass";
            this.btn_edit_pass.Size = new System.Drawing.Size(237, 52);
            this.btn_edit_pass.TabIndex = 5;
            this.btn_edit_pass.Text = "Сменить пароль";
            this.btn_edit_pass.UseVisualStyleBackColor = true;
            this.btn_edit_pass.Click += new System.EventHandler(this.btn_edit_pass_Click);
            // 
            // label_tekID
            // 
            this.label_tekID.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_tekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tekID.Location = new System.Drawing.Point(0, 0);
            this.label_tekID.Name = "label_tekID";
            this.label_tekID.Size = new System.Drawing.Size(169, 23);
            this.label_tekID.TabIndex = 0;
            this.label_tekID.Text = "Код транспортной";
            this.label_tekID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_tekID
            // 
            this.text_tekID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_tekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_tekID.Location = new System.Drawing.Point(0, 26);
            this.text_tekID.Name = "text_tekID";
            this.text_tekID.Size = new System.Drawing.Size(169, 26);
            this.text_tekID.TabIndex = 1;
            this.text_tekID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_tekID_KeyPress);
            // 
            // label_new_pass
            // 
            this.label_new_pass.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_new_pass.Location = new System.Drawing.Point(0, 0);
            this.label_new_pass.Name = "label_new_pass";
            this.label_new_pass.Size = new System.Drawing.Size(158, 23);
            this.label_new_pass.TabIndex = 0;
            this.label_new_pass.Text = "Новый пароль";
            this.label_new_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_new_pass
            // 
            this.text_new_pass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_new_pass.Location = new System.Drawing.Point(0, 26);
            this.text_new_pass.Name = "text_new_pass";
            this.text_new_pass.Size = new System.Drawing.Size(158, 26);
            this.text_new_pass.TabIndex = 1;
            // 
            // Edit_pass_tek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 98);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Edit_pass_tek";
            this.Text = "Изменение пароля ТЭК";
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
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_edit_pass;
        private System.Windows.Forms.TextBox text_tekID;
        private System.Windows.Forms.Label label_tekID;
        private System.Windows.Forms.TextBox text_new_pass;
        private System.Windows.Forms.Label label_new_pass;
    }
}