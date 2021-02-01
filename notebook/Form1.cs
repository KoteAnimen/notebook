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
            Form1 form = new Form1();
            form.Text = currentFileName + " - " + "Notebook version 0.0.1";
        }
    }
}
