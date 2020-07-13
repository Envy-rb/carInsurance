using System.ComponentModel;

namespace kursvaya
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчествоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 311);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.удалитьВыбраннуюToolStripMenuItem,
            this.информацияToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьВыбраннуюToolStripMenuItem
            // 
            this.удалитьВыбраннуюToolStripMenuItem.Name = "удалитьВыбраннуюToolStripMenuItem";
            this.удалитьВыбраннуюToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.удалитьВыбраннуюToolStripMenuItem.Text = "Удалить выбранную";
            this.удалитьВыбраннуюToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраннуюToolStripMenuItem_Click);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.автомобилиToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            this.автомобилиToolStripMenuItem.Click += new System.EventHandler(this.автомобилиToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.автомобильToolStripMenuItem,
            this.записьToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имяToolStripMenuItem,
            this.фамилияToolStripMenuItem,
            this.отчествоToolStripMenuItem,
            this.возрастToolStripMenuItem});
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // имяToolStripMenuItem
            // 
            this.имяToolStripMenuItem.Name = "имяToolStripMenuItem";
            this.имяToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.имяToolStripMenuItem.Text = "Имя";
            this.имяToolStripMenuItem.Click += new System.EventHandler(this.имяToolStripMenuItem_Click);
            // 
            // фамилияToolStripMenuItem
            // 
            this.фамилияToolStripMenuItem.Name = "фамилияToolStripMenuItem";
            this.фамилияToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.фамилияToolStripMenuItem.Text = "Фамилия";
            this.фамилияToolStripMenuItem.Click += new System.EventHandler(this.фамилияToolStripMenuItem_Click);
            // 
            // отчествоToolStripMenuItem
            // 
            this.отчествоToolStripMenuItem.Name = "отчествоToolStripMenuItem";
            this.отчествоToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.отчествоToolStripMenuItem.Text = "Отчество";
            this.отчествоToolStripMenuItem.Click += new System.EventHandler(this.отчествоToolStripMenuItem_Click);
            // 
            // возрастToolStripMenuItem
            // 
            this.возрастToolStripMenuItem.Name = "возрастToolStripMenuItem";
            this.возрастToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.возрастToolStripMenuItem.Text = "Возраст";
            this.возрастToolStripMenuItem.Click += new System.EventHandler(this.возрастToolStripMenuItem_Click);
            // 
            // автомобильToolStripMenuItem
            // 
            this.автомобильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номерToolStripMenuItem,
            this.модельToolStripMenuItem});
            this.автомобильToolStripMenuItem.Name = "автомобильToolStripMenuItem";
            this.автомобильToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.автомобильToolStripMenuItem.Text = "Автомобиль";
            // 
            // номерToolStripMenuItem
            // 
            this.номерToolStripMenuItem.Name = "номерToolStripMenuItem";
            this.номерToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.номерToolStripMenuItem.Text = "Номер";
            this.номерToolStripMenuItem.Click += new System.EventHandler(this.номерToolStripMenuItem_Click);
            // 
            // модельToolStripMenuItem
            // 
            this.модельToolStripMenuItem.Name = "модельToolStripMenuItem";
            this.модельToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.модельToolStripMenuItem.Text = "Модель";
            this.модельToolStripMenuItem.Click += new System.EventHandler(this.модельToolStripMenuItem_Click);
            // 
            // записьToolStripMenuItem
            // 
            this.записьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.номерToolStripMenuItem1});
            this.записьToolStripMenuItem.Name = "записьToolStripMenuItem";
            this.записьToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.записьToolStripMenuItem.Text = "Запись";
            // 
            // номерToolStripMenuItem1
            // 
            this.номерToolStripMenuItem1.Name = "номерToolStripMenuItem1";
            this.номерToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.номерToolStripMenuItem1.Text = "Номер";
            this.номерToolStripMenuItem1.Click += new System.EventHandler(this.номерToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Очистить критерии поиска";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номерToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem модельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчествоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возрастToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}