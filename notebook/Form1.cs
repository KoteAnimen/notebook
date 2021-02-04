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

        private void OpenButton_Click(object sender, EventArgs e)
        {
            notebook.Open(ref head);
            this.Text = head;
        }

        private void ExitButton_Click(object sender, EventArgs e)//здесь баг
        {
            bool exit = true;
            notebook.Exit(ref exit);
            if (exit == true) this.Close();
        }

        private void ExitForm(object sender, FormClosingEventArgs e)
        {
            bool exit = false;
            notebook.Exit(ref exit);
            e.Cancel = exit;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            fieldEdit.Undo();
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            fieldEdit.Cut();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            fieldEdit.Paste();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            fieldEdit.Copy();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            fieldEdit.SelectedText = "";
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
    public bool AOpenBloknot()
    {
        OpenFileDialog od = new OpenFileDialog();
        od.DefaultExt = "rtf";
        od.Filter = "Текстовый файл (*.rtf)|*rtf|Все файлы(*.*)|*.*";
        if (od.ShowDialog() == DialogResult.OK)
        {
            nameFile = od.FileName;
            fieldEdit.LoadFile(nameFile);
            fieldEdit.Modified = false;
            return true;
        }
        else return false;

    }

    public void Open(ref string formText)
    {
        if(fieldEdit.Modified == true)
        {
            ShowSaveMessage();//тут поосторожнее            
        }
        if (AOpenBloknot() == true)
        {
            formText = nameFile + " - " + "Notebook version 0.0.1";
        }
        else AOpenBloknot();   

    }

    public void Exit(ref bool exit)
    {
        if (fieldEdit.Modified == true)
        {
            ShowSaveMessage(ref exit);
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
    public void ShowSaveMessage(ref bool exit)
    {
        DialogResult result;
        result = MessageBox.Show("Вы хотите сохранить изменения в файле?", "Блокнот", MessageBoxButtons.YesNoCancel);
        if (result == DialogResult.Yes)
        {
            if (ASaveBloknot() == false)  exit = false;
        }
        if (result == DialogResult.Cancel)
        {
            exit = true; ;
        }        
    }
}
