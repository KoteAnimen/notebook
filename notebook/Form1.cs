using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using notebook;

namespace notebook
{
    public partial class Form1 : Form
    {
        public string head = "" + " - " + "Notebook version 0.0.1";
        Notebook notebook;
        public Form1()
        {
            InitializeComponent();                      
            this.Text = head;
            notebook = new Notebook(fieldEdit);
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {                        
            notebook.Save(ref head);
            this.Text = head;
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            notebook.SaveAs(ref head);
            this.Text = head;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            notebook.Create();
        }
    }
}

public class Notebook
{
    string nameFile;
    RichTextBox fieldEdit;

    public string NameFile
    {
        get { return nameFile; }
    }

    public Notebook(RichTextBox fieldEdit)
    {
        nameFile = "";
        this.fieldEdit = fieldEdit;
    }

    public bool ASaveBloknot()
    {
        SaveFileDialog sd = new SaveFileDialog();
        sd.DefaultExt = "rtf";
        sd.Filter = "Текстовый файл (*.rtf)|*rtf|Все файлы(*.*)|*.*";
        if (nameFile == "")
        {
            if (sd.ShowDialog() == DialogResult.OK)
            {
                nameFile = sd.FileName;
            }
            else
            {
                return false;
            }
        }
        fieldEdit.SaveFile(nameFile);
        fieldEdit.Modified = false;
        return true;
    }

    public void Create()
    {
        if (fieldEdit.Modified == true)
        {
            ShowSaveMessage();
            fieldEdit.Clear();
            nameFile = "";
            fieldEdit.Modified = false;
        }
    }

    public void Save(ref string formText)
    {
        
        if(ASaveBloknot() == true)
        {            
            formText = nameFile + " - " + "Notebook version 0.0.1";
        }
    }
    public void SaveAs(ref string formText)
    {
        nameFile = "";
        if(ASaveBloknot() == true)
        {
            formText = nameFile + " - " + "Notebook version 0.0.1";
        }
    }

    public void ShowSaveMessage()
    {
        DialogResult result;
        result = MessageBox.Show("Вы хотите сохранить изменения в файле?", "Блокнот", MessageBoxButtons.YesNoCancel);
        if (result == DialogResult.Yes)
        {
            if (ASaveBloknot() == false) return;
        }
        if (result == DialogResult.Cancel)
        {
            return;
        }        
    }
}
