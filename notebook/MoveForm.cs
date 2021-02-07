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
    public partial class MoveForm : Form
    {
        public MoveForm()
        {
            InitializeComponent();            
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if((int)firstRow.Value == (int)secondRow.Value)
            {
                MessageBox.Show("Ошибка. Номера перетавляемых строк должны быть разными.", "Ошибка.");
            }
            else
            {
                Rows.moveResolution = true;
                Rows.firstRow = (int)firstRow.Value;
                Rows.secondRow = (int)secondRow.Value;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Rows.moveResolution = false;
            this.Close();
        }
    }
}
