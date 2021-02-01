using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class Form1 : Form
    {
        public string currentFileName;        

        public Form1()
        {
            InitializeComponent();
            currentFileName = "Безымянный";            
            this.Text = currentFileName + " - " + "Notebook version 0.0.1";
        }
        public bool ASaveBloknot(RichTextBox fieldEdit, ref string fileName)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = "rtf";
            sd.Filter = "Текстовый файл (*.rtf)|*rtf|Все файлы(*.*)|*.*";
            if(fileName == "")
            {
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sd.FileName;
                }
                else
                {
                    return false;
                }
            }
            fieldEdit.SaveFile(fileName);
            fieldEdit.Modified = false;
            return true;
        }
    }
}
