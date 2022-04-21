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
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();
        }

        private void ToDoForm_Load(object sender, EventArgs e)
        {
            headerDate.Text = $"To Do List for {DateTime.Today.ToString("MM/dd/yyyy")}";
            
        }
    }
}
