
namespace TextBox
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.втавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(0, 24);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(800, 426);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.печатьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // создатьToolStripMenuItem
      // 
      this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
      this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.создатьToolStripMenuItem.Text = "Создать";
      this.создатьToolStripMenuItem.Click += new System.EventHandler(this.CreateText);
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.Open);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.Save);
      // 
      // печатьToolStripMenuItem
      // 
      this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
      this.печатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.печатьToolStripMenuItem.Text = "Печать";
      this.печатьToolStripMenuItem.Click += new System.EventHandler(this.PrintMenu);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      this.выходToolStripMenuItem.Click += new System.EventHandler(this.Exit);
      // 
      // вставкаToolStripMenuItem
      // 
      this.вставкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.втавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
      this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
      this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
      this.вставкаToolStripMenuItem.Text = "Правка";
      // 
      // копироватьToolStripMenuItem
      // 
      this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
      this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.копироватьToolStripMenuItem.Text = "Копировать";
      this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyText);
      // 
      // вырезатьToolStripMenuItem
      // 
      this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
      this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.вырезатьToolStripMenuItem.Text = "Вырезать";
      this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.CutText);
      // 
      // втавитьToolStripMenuItem
      // 
      this.втавитьToolStripMenuItem.Name = "втавитьToolStripMenuItem";
      this.втавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.втавитьToolStripMenuItem.Text = "Втавить";
      this.втавитьToolStripMenuItem.Click += new System.EventHandler(this.PasteText);
      // 
      // удалитьToolStripMenuItem
      // 
      this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
      this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.удалитьToolStripMenuItem.Text = "Удалить";
      this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DelText);
      // 
      // шрифтToolStripMenuItem
      // 
      this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
      this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
      this.шрифтToolStripMenuItem.Text = "Шрифт";
      this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.FontMenu);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
      // 
      // Form1
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.menuStrip1);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "SimpleNote";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem втавитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
  }
}

