
namespace Smart_House
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.moduleList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьМодульToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьМодульToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьМодульToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИмяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОМодулеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleList
            // 
            this.moduleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.moduleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleList.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moduleList.FormattingEnabled = true;
            this.moduleList.ItemHeight = 38;
            this.moduleList.Location = new System.Drawing.Point(0, 67);
            this.moduleList.Margin = new System.Windows.Forms.Padding(4);
            this.moduleList.Name = "moduleList";
            this.moduleList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moduleList.Size = new System.Drawing.Size(546, 436);
            this.moduleList.TabIndex = 0;
            this.moduleList.SelectedIndexChanged += new System.EventHandler(this.moduleList_SelectedIndexChanged);
            this.moduleList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваши модули";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.ForeColor = System.Drawing.Color.Teal;
            this.toolStripButton3.Image = global::Smart_House.Properties.Resources.new1;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(108, 28);
            this.toolStripButton3.Text = "Добавить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМодульToolStripMenuItem,
            this.удалитьМодульToolStripMenuItem,
            this.изменитьМодульToolStripMenuItem,
            this.информацияОМодулеToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.SlateBlue;
            this.toolStripDropDownButton1.Image = global::Smart_House.Properties.Resources.edit;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(161, 28);
            this.toolStripDropDownButton1.Text = "Редактировать";
            // 
            // добавитьМодульToolStripMenuItem
            // 
            this.добавитьМодульToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.добавитьМодульToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.добавитьМодульToolStripMenuItem.Image = global::Smart_House.Properties.Resources.new1;
            this.добавитьМодульToolStripMenuItem.Name = "добавитьМодульToolStripMenuItem";
            this.добавитьМодульToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.добавитьМодульToolStripMenuItem.Text = "Добавить модуль";
            this.добавитьМодульToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // удалитьМодульToolStripMenuItem
            // 
            this.удалитьМодульToolStripMenuItem.ForeColor = System.Drawing.Color.IndianRed;
            this.удалитьМодульToolStripMenuItem.Image = global::Smart_House.Properties.Resources.del;
            this.удалитьМодульToolStripMenuItem.Name = "удалитьМодульToolStripMenuItem";
            this.удалитьМодульToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.удалитьМодульToolStripMenuItem.Text = "Удалить модуль";
            this.удалитьМодульToolStripMenuItem.Click += new System.EventHandler(this.удалитьМодульToolStripMenuItem_Click);
            // 
            // изменитьМодульToolStripMenuItem
            // 
            this.изменитьМодульToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьИмяToolStripMenuItem,
            this.изменитьIPToolStripMenuItem});
            this.изменитьМодульToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.изменитьМодульToolStripMenuItem.Image = global::Smart_House.Properties.Resources.edit;
            this.изменитьМодульToolStripMenuItem.Name = "изменитьМодульToolStripMenuItem";
            this.изменитьМодульToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.изменитьМодульToolStripMenuItem.Text = "Изменить модуль";
            // 
            // изменитьИмяToolStripMenuItem
            // 
            this.изменитьИмяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3,
            this.toolStripSeparator1,
            this.изменитьToolStripMenuItem2});
            this.изменитьИмяToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.изменитьИмяToolStripMenuItem.Image = global::Smart_House.Properties.Resources.edit;
            this.изменитьИмяToolStripMenuItem.Name = "изменитьИмяToolStripMenuItem";
            this.изменитьИмяToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.изменитьИмяToolStripMenuItem.Text = "Изменить имя";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox3.Text = "Введите новое имя модуля";
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(271, 6);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.изменитьToolStripMenuItem2.Image = global::Smart_House.Properties.Resources.edit;
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(274, 26);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // изменитьIPToolStripMenuItem
            // 
            this.изменитьIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.изменитьToolStripMenuItem});
            this.изменитьIPToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.изменитьIPToolStripMenuItem.Image = global::Smart_House.Properties.Resources.edit;
            this.изменитьIPToolStripMenuItem.Name = "изменитьIPToolStripMenuItem";
            this.изменитьIPToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.изменитьIPToolStripMenuItem.Text = "Изменить IP";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "Введите новое IP модуля";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.изменитьToolStripMenuItem.Image = global::Smart_House.Properties.Resources.edit;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // информацияОМодулеToolStripMenuItem
            // 
            this.информацияОМодулеToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.информацияОМодулеToolStripMenuItem.Image = global::Smart_House.Properties.Resources.info;
            this.информацияОМодулеToolStripMenuItem.Name = "информацияОМодулеToolStripMenuItem";
            this.информацияОМодулеToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.информацияОМодулеToolStripMenuItem.Text = "Информация о модуле";
            this.информацияОМодулеToolStripMenuItem.Click += new System.EventHandler(this.информацияОМодулеToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.toolStripButton1.Image = global::Smart_House.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 28);
            this.toolStripButton1.Text = "Настройки";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.ForeColor = System.Drawing.Color.DarkGreen;
            this.toolStripButton2.Image = global::Smart_House.Properties.Resources.info;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(137, 28);
            this.toolStripButton2.Text = "О Программе";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(0, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(546, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_openWorkModule);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_House.Properties.Resources.sh_fon_2;
            this.ClientSize = new System.Drawing.Size(546, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moduleList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(450, 330);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart House";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ListBox moduleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьМодульToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьМодульToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьМодульToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИмяToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem информацияОМодулеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

