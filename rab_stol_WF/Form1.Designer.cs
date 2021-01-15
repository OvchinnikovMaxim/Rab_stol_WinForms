
namespace rab_stol_WF
{
    partial class Main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.SQL_searching = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.update_sales = new System.Windows.Forms.Button();
            this.label_hello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.workSQL = new System.Windows.Forms.Button();
            this.create_TT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQL_searching
            // 
            this.SQL_searching.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQL_searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SQL_searching.ForeColor = System.Drawing.Color.Green;
            this.SQL_searching.Location = new System.Drawing.Point(3, 3);
            this.SQL_searching.Name = "SQL_searching";
            this.SQL_searching.Size = new System.Drawing.Size(287, 219);
            this.SQL_searching.TabIndex = 0;
            this.SQL_searching.Text = "Поиск по базе";
            this.SQL_searching.UseVisualStyleBackColor = true;
            this.SQL_searching.Click += new System.EventHandler(this.SQL_searching_Click);
            this.SQL_searching.MouseEnter += new System.EventHandler(this.SQL_searching_MouseEnter);
            this.SQL_searching.MouseLeave += new System.EventHandler(this.SQL_searching_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.update_sales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SQL_searching, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // update_sales
            // 
            this.update_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_sales.ForeColor = System.Drawing.Color.Green;
            this.update_sales.Location = new System.Drawing.Point(3, 228);
            this.update_sales.Name = "update_sales";
            this.update_sales.Size = new System.Drawing.Size(287, 219);
            this.update_sales.TabIndex = 2;
            this.update_sales.Text = "Обработка продаж";
            this.update_sales.UseVisualStyleBackColor = true;
            this.update_sales.Click += new System.EventHandler(this.update_sales_Click);
            this.update_sales.MouseEnter += new System.EventHandler(this.update_sales_MouseEnter);
            this.update_sales.MouseLeave += new System.EventHandler(this.update_sales_MouseLeave);
            // 
            // label_hello
            // 
            this.label_hello.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_hello.BackColor = System.Drawing.Color.White;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hello.ForeColor = System.Drawing.Color.Green;
            this.label_hello.Location = new System.Drawing.Point(297, 3);
            this.label_hello.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(210, 444);
            this.label_hello.TabIndex = 1;
            this.label_hello.Text = "Привет тебе";
            this.label_hello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.label_hello);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.workSQL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.create_TT, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(511, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 450);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // workSQL
            // 
            this.workSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workSQL.ForeColor = System.Drawing.Color.Green;
            this.workSQL.Location = new System.Drawing.Point(3, 3);
            this.workSQL.Name = "workSQL";
            this.workSQL.Size = new System.Drawing.Size(283, 219);
            this.workSQL.TabIndex = 0;
            this.workSQL.Text = "Работа с базой";
            this.workSQL.UseVisualStyleBackColor = true;
            this.workSQL.Click += new System.EventHandler(this.workSQL_Click);
            this.workSQL.MouseEnter += new System.EventHandler(this.workSQL_MouseEnter);
            this.workSQL.MouseLeave += new System.EventHandler(this.workSQL_MouseLeave);
            // 
            // create_TT
            // 
            this.create_TT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_TT.ForeColor = System.Drawing.Color.Green;
            this.create_TT.Location = new System.Drawing.Point(3, 228);
            this.create_TT.Name = "create_TT";
            this.create_TT.Size = new System.Drawing.Size(283, 219);
            this.create_TT.TabIndex = 1;
            this.create_TT.Text = "Заведение клиентских карточек";
            this.create_TT.UseVisualStyleBackColor = true;
            this.create_TT.Click += new System.EventHandler(this.create_TT_Click);
            this.create_TT.MouseEnter += new System.EventHandler(this.create_TT_MouseEnter);
            this.create_TT.MouseLeave += new System.EventHandler(this.create_TT_MouseLeave);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.Text = "Рабочий стол";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SQL_searching;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button update_sales;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button workSQL;
        private System.Windows.Forms.Button create_TT;
    }
}

