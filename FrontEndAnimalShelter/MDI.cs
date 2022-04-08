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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            #region Event Initialization
            tabHome.Enter += TabHome_Enter;
            tabViewAnimal.Enter += TabViewAnimal_Enter;
            tabCreateAnimal.Enter += TabCreateAnimal_Enter;
            #endregion
        }

        private void TabHome_Enter(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// When "Create Animal" tab is entered the AddAnimal form is generated in the tabpage
        /// </summary>
        private void TabCreateAnimal_Enter(object sender, EventArgs e)
        {
            Form childForm = new AddAnimal();
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            tabCreateAnimal.Controls.Add(childForm);
            childForm.Visible = true;
        }

        /// <summary>
        /// When "View Animal" tab is entered the ViewAnimal form is generated in the tabpage
        /// </summary>
        private void TabViewAnimal_Enter(object sender, EventArgs e)
        {
            Form childForm = new ViewAnimal();
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            tabViewAnimal.Controls.Add(childForm);
            childForm.Visible = true;
        }

    }
}
