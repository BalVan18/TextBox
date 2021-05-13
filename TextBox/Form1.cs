using System;
using System.IO;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox
{
    public partial class Form1 : Form
    {
        public string filename;
        public bool filechanged;
        public Form1()
        {
            InitializeComponent();
            Init();
            openFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt";
            saveFileDialog1.Filter = "Текстовые документы(*.txt)|*.txt";
        }
        public void Init()
        {
            filename = "";
            filechanged = false;
            Title();
        }
        public void CreateText(Object sender, EventArgs e)
        {
            UnsavedFile();
            textBox1.Text = "";
            filename = "";
            filechanged = false;
            Title();
        }
        public void Exit (Object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            UnsavedFile();
            Close();
        }
        public void Open (Object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            UnsavedFile();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                    filechanged = false;
                }
                catch 
                { 
                    MessageBox.Show("Ошибка");
                }
                Title();
        }
        public void SaveFile(string _filename)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                     _filename = saveFileDialog1.FileName;
                     StreamWriter sw = new StreamWriter(_filename);
                     sw.Write(textBox1.Text);
                     sw.Close();
                     filename = _filename;
                     filechanged = false;
                }
                catch
                {
                     MessageBox.Show("Ошибка");
                }
        }
        public void Save (Object sender, EventArgs e)
        {
            SaveFile(filename);
            Title();
        }
        public void Title ()
        {
            if (filename != "")
            this.Text = filename + " - SimpleNote";
            else this.Text = "Безымянный - SimpleNote";
        }
        public void UnsavedFile()
        {
            if (filechanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения ?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveFile(filename); 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!filechanged)
            {
               this.Text = this.Text.Replace("*", "");
               filechanged = true;
               this.Text = "*" + this.Text;
            }
        }
        public void CopyText (object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void CutText (object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void PasteText (object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.SelectionStart) + Clipboard.GetText() + textBox1.Text.Substring(textBox1.SelectionStart, textBox1.Text.Length - textBox1.SelectionStart);
        }
        public void DelText (object sender, EventArgs e)
        {
             textBox1.SelectedText = "";
        }
        public void FontMenu (object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            if (font.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               textBox1.Font = font.Font;
            }
        }
        public void PrintMenu (object sender, EventArgs e)
        {
            PrintDialog p1 = new PrintDialog();
            PrintDocument p2 = new PrintDocument();
            if (p1.ShowDialog() == DialogResult.OK)
            {
               p2.Print();
            }
        }
    }
}
