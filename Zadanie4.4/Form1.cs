using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingSource sotrBindingSource;
        private void Form1_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            sotrBindingSource = new BindingSource(rbProductDataSet1, "Поставщики");
            FamtextBox.DataBindings.Add("Text", sotrBindingSource, "Код поставщика");
            NametextBox.DataBindings.Add("Text", sotrBindingSource, "Поставщик");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSource, "Телефон");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            sotrBindingSource.MoveNext();
        }
    }
}
