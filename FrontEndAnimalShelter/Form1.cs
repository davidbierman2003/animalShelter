using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace FrontEndAnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            AnimalTable.DataSource = dtAnimalTable;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(cmbBox1.Text) + Convert.ToInt32(cmbBox2.Text);

            MessageBox.Show(cmbBox1.Text + " + " + cmbBox2.Text + " = "  + answer);
        }

    }
}
