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
            tabToDo.Enter += TabToDo_Enter;
            tabViewAnimal.Enter += TabViewAnimal_Enter;
            tabCreateAnimal.Enter += TabCreateAnimal_Enter;
            tabTreatment.Enter += TabTreatment_Enter;
            mainTabMenu.DrawItem += ProgramTabMenu_DrawItem;
            #endregion
        }

        


        /// <summary>
        /// ProgramTabMenu characteristics are set/drawn here
        /// </summary>
        private void ProgramTabMenu_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage CurrentTab = mainTabMenu.TabPages[e.Index];
            Rectangle ItemRect = mainTabMenu.GetTabRect(e.Index);
            SolidBrush FillBrush = new SolidBrush(Color.Red);
            SolidBrush TextBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            
            //If we are currently painting the Selected TabItem we'll
            //change the brush colors and inflate the rectangle.
            if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
            {
                FillBrush.Color = Color.White;
                TextBrush.Color = Color.Red;
                ItemRect.Inflate(2, 2);
            }

            //Next we'll paint the TabItem with our Fill Brush
            e.Graphics.FillRectangle(FillBrush, ItemRect);

            //Now draw the text.
            e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

            //Reset any Graphics rotation
            e.Graphics.ResetTransform();

            //Finally, we should Dispose of our brushes.
            FillBrush.Dispose();
            TextBrush.Dispose();

        }
        /// <summary>
        /// When "To Do" tab is entered the ToDoForm is generated in the tabpage
        /// </summary>
        private void TabToDo_Enter(object sender, EventArgs e)
        {
            Form childForm = new ToDoForm();
            childForm.TopLevel = false;
            childForm.Parent = tabToDo;
            childForm.Dock = DockStyle.Fill;
            childForm.Font = new Font("Ariel", 10);
            tabToDo.Controls.Add(childForm);
            childForm.Visible = true;
        }
        /// <summary>
        /// When "Create Animal" tab is entered the AddAnimalForm is generated in the tabpage
        /// </summary>
        private void TabCreateAnimal_Enter(object sender, EventArgs e)
        {
            Form childForm = new AddAnimalForm();
            childForm.TopLevel = false;
            childForm.Parent = tabCreateAnimal;
            childForm.Dock = DockStyle.Fill;
            childForm.Font = new Font("Ariel", 10);
            tabCreateAnimal.Controls.Add(childForm);
            childForm.Visible = true;
        }

        /// <summary>
        /// When "View Animal" tab is entered the ViewAnimalForm is generated in the tabpage
        /// </summary>
        private void TabViewAnimal_Enter(object sender, EventArgs e)
        {
            Form childForm = new ViewAnimalForm();
            childForm.TopLevel = false;
            childForm.Parent = tabViewAnimal;
            childForm.Dock = DockStyle.Fill;
            childForm.Font = new Font("Ariel", 10);
            tabViewAnimal.Controls.Add(childForm);
            childForm.Visible = true;
        }
        /// <summary>
        /// When "Treatment" tab is entered the TreatmentForm is generated in the tabpage
        /// </summary>
        private void TabTreatment_Enter(object sender, EventArgs e)
        {
            Form childForm = new TreatmentForm();
            childForm.TopLevel = false;
            childForm.Parent = tabTreatment;
            childForm.Dock = DockStyle.Fill;
            childForm.Font = new Font("Ariel", 10);
            tabTreatment.Controls.Add(childForm);
            childForm.Visible = true;
        }

    }
}
