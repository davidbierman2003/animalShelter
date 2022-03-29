using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEndAnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(cmbBox1.Text) + Convert.ToInt32(cmbBox2.Text);

            MessageBox.Show(cmbBox1.Text + " + " + cmbBox2.Text + " = "  + answer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animal_medicalDataSet.animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.animal_medicalDataSet.animal);

        }
    }
}
