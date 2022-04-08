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
    public partial class ViewAnimal : Form
    {
        public ViewAnimal()
        {
            InitializeComponent();
            AnimalMedical.animalDataTable dtAnimalTable = Utility.GetAnimals();
            dgAnimalTable.DataSource = dtAnimalTable;
        }
    }
}
