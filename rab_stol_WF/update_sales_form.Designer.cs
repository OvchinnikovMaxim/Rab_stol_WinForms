
namespace rab_stol_WF
{
    partial class update_sales_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_sales_form));
            this.splitCont_obsh = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.text_server = new System.Windows.Forms.TextBox();
            this.label_distr_name = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.text_name_distr = new System.Windows.Forms.TextBox();
            this.panel_distr = new System.Windows.Forms.Panel();
            this.text_contractor = new System.Windows.Forms.TextBox();
            this.label_contractor = new System.Windows.Forms.Label();
            this.panel_date_begin = new System.Windows.Forms.Panel();
            this.TimePicker_date_begin = new System.Windows.Forms.DateTimePicker();
            this.label_date_begin = new System.Windows.Forms.Label();
            this.panel_date_end = new System.Windows.Forms.Panel();
            this.TimePicker_date_end = new System.Windows.Forms.DateTimePicker();
            this.label_date_end = new System.Windows.Forms.Label();
            this.panel_UNITY = new System.Windows.Forms.Panel();
            this.btn_del_docs_UNITY = new System.Windows.Forms.Button();
            this.check_docs_UNITY = new System.Windows.Forms.CheckBox();
            this.btn_docs_chek = new System.Windows.Forms.Button();
            this.btn_docs_obrab = new System.Windows.Forms.Button();
            this.btn_docs_pereobr = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.label_check_blocking = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGrid_unity = new System.Windows.Forms.DataGridView();
            this.dataGrid_nefco = new System.Windows.Forms.DataGridView();
            this.toolTip_obr = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_reload = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont_obsh)).BeginInit();
            this.splitCont_obsh.Panel1.SuspendLayout();
            this.splitCont_obsh.Panel2.SuspendLayout();
            this.splitCont_obsh.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_distr.SuspendLayout();
            this.panel_date_begin.SuspendLayout();
            this.panel_date_end.SuspendLayout();
            this.panel_UNITY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_unity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nefco)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCont_obsh
            // 
            this.splitCont_obsh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCont_obsh.Location = new System.Drawing.Point(0, 0);
            this.splitCont_obsh.Name = "splitCont_obsh";
            // 
            // splitCont_obsh.Panel1
            // 
            this.splitCont_obsh.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitCont_obsh.Panel2
            // 
            this.splitCont_obsh.Panel2.Controls.Add(this.splitContainer1);
            this.splitCont_obsh.Size = new System.Drawing.Size(800, 382);
            this.splitCont_obsh.SplitterDistance = 400;
            this.splitCont_obsh.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.89655F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.10345F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Controls.Add(this.btn_connect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.text_server, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_distr_name, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_search, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.text_name_distr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_distr, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_date_begin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_date_end, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel_UNITY, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_docs_chek, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_docs_obrab, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_docs_pereobr, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_time, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_check_blocking, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_connect.Location = new System.Drawing.Point(125, 3);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(132, 31);
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
            this.label_status.Location = new System.Drawing.Point(263, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(134, 37);
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
            this.text_server.Size = new System.Drawing.Size(116, 26);
            this.text_server.TabIndex = 2;
            this.text_server.Text = "192.168.2.7";
            this.text_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_server.TextChanged += new System.EventHandler(this.text_server_TextChanged);
            this.text_server.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_server_KeyPress);
            // 
            // label_distr_name
            // 
            this.label_distr_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_distr_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_distr_name.Location = new System.Drawing.Point(3, 37);
            this.label_distr_name.Name = "label_distr_name";
            this.label_distr_name.Size = new System.Drawing.Size(116, 38);
            this.label_distr_name.TabIndex = 5;
            this.label_distr_name.Text = "Название дистрибьютора";
            this.label_distr_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_search.Location = new System.Drawing.Point(263, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 32);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Поиск";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // text_name_distr
            // 
            this.text_name_distr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.text_name_distr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name_distr.Location = new System.Drawing.Point(125, 43);
            this.text_name_distr.Name = "text_name_distr";
            this.text_name_distr.Size = new System.Drawing.Size(132, 26);
            this.text_name_distr.TabIndex = 7;
            // 
            // panel_distr
            // 
            this.panel_distr.Controls.Add(this.text_contractor);
            this.panel_distr.Controls.Add(this.label_contractor);
            this.panel_distr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_distr.Location = new System.Drawing.Point(3, 78);
            this.panel_distr.Name = "panel_distr";
            this.panel_distr.Size = new System.Drawing.Size(116, 84);
            this.panel_distr.TabIndex = 8;
            // 
            // text_contractor
            // 
            this.text_contractor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_contractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_contractor.Location = new System.Drawing.Point(0, 58);
            this.text_contractor.Name = "text_contractor";
            this.text_contractor.Size = new System.Drawing.Size(116, 26);
            this.text_contractor.TabIndex = 1;
            this.text_contractor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_contractor_KeyPress);
            // 
            // label_contractor
            // 
            this.label_contractor.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_contractor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_contractor.Location = new System.Drawing.Point(0, 0);
            this.label_contractor.Name = "label_contractor";
            this.label_contractor.Size = new System.Drawing.Size(116, 36);
            this.label_contractor.TabIndex = 0;
            this.label_contractor.Text = "Код дистрибьютора";
            this.label_contractor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_date_begin
            // 
            this.panel_date_begin.Controls.Add(this.TimePicker_date_begin);
            this.panel_date_begin.Controls.Add(this.label_date_begin);
            this.panel_date_begin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_date_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_date_begin.Location = new System.Drawing.Point(125, 78);
            this.panel_date_begin.Name = "panel_date_begin";
            this.panel_date_begin.Size = new System.Drawing.Size(132, 84);
            this.panel_date_begin.TabIndex = 9;
            // 
            // TimePicker_date_begin
            // 
            this.TimePicker_date_begin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimePicker_date_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePicker_date_begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker_date_begin.Location = new System.Drawing.Point(0, 58);
            this.TimePicker_date_begin.Name = "TimePicker_date_begin";
            this.TimePicker_date_begin.Size = new System.Drawing.Size(132, 26);
            this.TimePicker_date_begin.TabIndex = 1;
            // 
            // label_date_begin
            // 
            this.label_date_begin.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_date_begin.Location = new System.Drawing.Point(0, 0);
            this.label_date_begin.Name = "label_date_begin";
            this.label_date_begin.Size = new System.Drawing.Size(132, 36);
            this.label_date_begin.TabIndex = 0;
            this.label_date_begin.Text = "Дата начала периода";
            this.label_date_begin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_date_end
            // 
            this.panel_date_end.Controls.Add(this.TimePicker_date_end);
            this.panel_date_end.Controls.Add(this.label_date_end);
            this.panel_date_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_date_end.Location = new System.Drawing.Point(263, 78);
            this.panel_date_end.Name = "panel_date_end";
            this.panel_date_end.Size = new System.Drawing.Size(134, 84);
            this.panel_date_end.TabIndex = 10;
            // 
            // TimePicker_date_end
            // 
            this.TimePicker_date_end.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimePicker_date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePicker_date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimePicker_date_end.Location = new System.Drawing.Point(0, 58);
            this.TimePicker_date_end.Name = "TimePicker_date_end";
            this.TimePicker_date_end.Size = new System.Drawing.Size(134, 26);
            this.TimePicker_date_end.TabIndex = 1;
            // 
            // label_date_end
            // 
            this.label_date_end.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date_end.Location = new System.Drawing.Point(0, 0);
            this.label_date_end.Name = "label_date_end";
            this.label_date_end.Size = new System.Drawing.Size(134, 36);
            this.label_date_end.TabIndex = 0;
            this.label_date_end.Text = "Дата конца периода";
            this.label_date_end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_UNITY
            // 
            this.panel_UNITY.Controls.Add(this.btn_del_docs_UNITY);
            this.panel_UNITY.Controls.Add(this.check_docs_UNITY);
            this.panel_UNITY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_UNITY.Location = new System.Drawing.Point(3, 280);
            this.panel_UNITY.Name = "panel_UNITY";
            this.panel_UNITY.Size = new System.Drawing.Size(116, 96);
            this.panel_UNITY.TabIndex = 11;
            // 
            // btn_del_docs_UNITY
            // 
            this.btn_del_docs_UNITY.Enabled = false;
            this.btn_del_docs_UNITY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del_docs_UNITY.Location = new System.Drawing.Point(9, 23);
            this.btn_del_docs_UNITY.Name = "btn_del_docs_UNITY";
            this.btn_del_docs_UNITY.Size = new System.Drawing.Size(108, 64);
            this.btn_del_docs_UNITY.TabIndex = 1;
            this.btn_del_docs_UNITY.Text = "на удаление в UNITY";
            this.btn_del_docs_UNITY.UseVisualStyleBackColor = true;
            this.btn_del_docs_UNITY.Click += new System.EventHandler(this.btn_del_docs_UNITY_Click);
            // 
            // check_docs_UNITY
            // 
            this.check_docs_UNITY.AutoSize = true;
            this.check_docs_UNITY.Location = new System.Drawing.Point(3, 3);
            this.check_docs_UNITY.Name = "check_docs_UNITY";
            this.check_docs_UNITY.Size = new System.Drawing.Size(15, 14);
            this.check_docs_UNITY.TabIndex = 0;
            this.check_docs_UNITY.UseVisualStyleBackColor = true;
            this.check_docs_UNITY.CheckedChanged += new System.EventHandler(this.check_docs_UNITY_CheckedChanged);
            // 
            // btn_docs_chek
            // 
            this.btn_docs_chek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_docs_chek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_docs_chek.Location = new System.Drawing.Point(3, 168);
            this.btn_docs_chek.Name = "btn_docs_chek";
            this.btn_docs_chek.Size = new System.Drawing.Size(116, 106);
            this.btn_docs_chek.TabIndex = 12;
            this.btn_docs_chek.Text = "Проверка продаж";
            this.btn_docs_chek.UseVisualStyleBackColor = true;
            this.btn_docs_chek.Click += new System.EventHandler(this.btn_docs_chek_Click);
            // 
            // btn_docs_obrab
            // 
            this.btn_docs_obrab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_docs_obrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_docs_obrab.Location = new System.Drawing.Point(125, 168);
            this.btn_docs_obrab.Name = "btn_docs_obrab";
            this.btn_docs_obrab.Size = new System.Drawing.Size(132, 106);
            this.btn_docs_obrab.TabIndex = 13;
            this.btn_docs_obrab.Text = "Обработать";
            this.btn_docs_obrab.UseVisualStyleBackColor = true;
            this.btn_docs_obrab.Click += new System.EventHandler(this.btn_docs_obrab_Click);
            // 
            // btn_docs_pereobr
            // 
            this.btn_docs_pereobr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_docs_pereobr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_docs_pereobr.Location = new System.Drawing.Point(263, 168);
            this.btn_docs_pereobr.Name = "btn_docs_pereobr";
            this.btn_docs_pereobr.Size = new System.Drawing.Size(134, 106);
            this.btn_docs_pereobr.TabIndex = 14;
            this.btn_docs_pereobr.Text = "Переобработать";
            this.btn_docs_pereobr.UseVisualStyleBackColor = true;
            this.btn_docs_pereobr.Click += new System.EventHandler(this.btn_docs_pereobr_Click);
            // 
            // label_time
            // 
            this.label_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(125, 277);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(132, 102);
            this.label_time.TabIndex = 15;
            this.label_time.Text = "00:00";
            this.label_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_check_blocking
            // 
            this.label_check_blocking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_check_blocking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_check_blocking.ForeColor = System.Drawing.Color.Red;
            this.label_check_blocking.Location = new System.Drawing.Point(263, 277);
            this.label_check_blocking.Name = "label_check_blocking";
            this.label_check_blocking.Size = new System.Drawing.Size(134, 102);
            this.label_check_blocking.TabIndex = 16;
            this.label_check_blocking.Text = "Проверьте нет ли блокирующих процессов";
            this.label_check_blocking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_check_blocking.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid_unity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid_nefco);
            this.splitContainer1.Size = new System.Drawing.Size(396, 382);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGrid_unity
            // 
            this.dataGrid_unity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_unity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_unity.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_unity.Name = "dataGrid_unity";
            this.dataGrid_unity.Size = new System.Drawing.Size(192, 382);
            this.dataGrid_unity.TabIndex = 0;
            // 
            // dataGrid_nefco
            // 
            this.dataGrid_nefco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_nefco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_nefco.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_nefco.Name = "dataGrid_nefco";
            this.dataGrid_nefco.Size = new System.Drawing.Size(200, 382);
            this.dataGrid_nefco.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // update_sales_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.splitCont_obsh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "update_sales_form";
            this.Text = "Обработка продаж";
            this.Load += new System.EventHandler(this.update_sales_form_Load);
            this.splitCont_obsh.Panel1.ResumeLayout(false);
            this.splitCont_obsh.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCont_obsh)).EndInit();
            this.splitCont_obsh.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_distr.ResumeLayout(false);
            this.panel_distr.PerformLayout();
            this.panel_date_begin.ResumeLayout(false);
            this.panel_date_end.ResumeLayout(false);
            this.panel_UNITY.ResumeLayout(false);
            this.panel_UNITY.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_unity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nefco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCont_obsh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox text_server;
        private System.Windows.Forms.Label label_distr_name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox text_name_distr;
        private System.Windows.Forms.Panel panel_distr;
        private System.Windows.Forms.Panel panel_date_begin;
        private System.Windows.Forms.Panel panel_date_end;
        private System.Windows.Forms.Panel panel_UNITY;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGrid_unity;
        private System.Windows.Forms.DataGridView dataGrid_nefco;
        private System.Windows.Forms.Button btn_docs_chek;
        private System.Windows.Forms.Button btn_docs_obrab;
        private System.Windows.Forms.Button btn_docs_pereobr;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_check_blocking;
        private System.Windows.Forms.Button btn_del_docs_UNITY;
        private System.Windows.Forms.CheckBox check_docs_UNITY;
        private System.Windows.Forms.TextBox text_contractor;
        private System.Windows.Forms.Label label_contractor;
        private System.Windows.Forms.DateTimePicker TimePicker_date_begin;
        private System.Windows.Forms.Label label_date_begin;
        private System.Windows.Forms.DateTimePicker TimePicker_date_end;
        private System.Windows.Forms.Label label_date_end;
        private System.Windows.Forms.ToolTip toolTip_obr;
        private System.Windows.Forms.ToolTip toolTip_reload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}