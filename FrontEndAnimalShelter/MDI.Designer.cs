namespace FrontEndAnimalShelter
{
    partial class MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabMenu = new System.Windows.Forms.TabControl();
            this.tabToDo = new System.Windows.Forms.TabPage();
            this.tabViewAnimal = new System.Windows.Forms.TabPage();
            this.tabCreateAnimal = new System.Windows.Forms.TabPage();
            this.tabTreatment = new System.Windows.Forms.TabPage();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabMenu
            // 
            this.mainTabMenu.Controls.Add(this.tabToDo);
            this.mainTabMenu.Controls.Add(this.tabViewAnimal);
            this.mainTabMenu.Controls.Add(this.tabCreateAnimal);
            this.mainTabMenu.Controls.Add(this.tabTreatment);
            this.mainTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabMenu.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabMenu.ItemSize = new System.Drawing.Size(300, 50);
            this.mainTabMenu.Location = new System.Drawing.Point(0, 52);
            this.mainTabMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainTabMenu.Name = "mainTabMenu";
            this.mainTabMenu.SelectedIndex = 0;
            this.mainTabMenu.Size = new System.Drawing.Size(1924, 997);
            this.mainTabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabMenu.TabIndex = 1;
            // 
            // tabToDo
            // 
            this.tabToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabToDo.Location = new System.Drawing.Point(4, 54);
            this.tabToDo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabToDo.Name = "tabToDo";
            this.tabToDo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabToDo.Size = new System.Drawing.Size(1916, 939);
            this.tabToDo.TabIndex = 0;
            this.tabToDo.Text = "To Do";
            this.tabToDo.UseVisualStyleBackColor = true;
            // 
            // tabViewAnimal
            // 
            this.tabViewAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabViewAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabViewAnimal.Name = "tabViewAnimal";
            this.tabViewAnimal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabViewAnimal.Size = new System.Drawing.Size(1916, 991);
            this.tabViewAnimal.TabIndex = 1;
            this.tabViewAnimal.Text = "View Animal";
            this.tabViewAnimal.UseVisualStyleBackColor = true;
            // 
            // tabCreateAnimal
            // 
            this.tabCreateAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabCreateAnimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabCreateAnimal.Name = "tabCreateAnimal";
            this.tabCreateAnimal.Size = new System.Drawing.Size(1916, 991);
            this.tabCreateAnimal.TabIndex = 2;
            this.tabCreateAnimal.Text = "Add Animal";
            this.tabCreateAnimal.UseVisualStyleBackColor = true;
            // 
            // tabTreatment
            // 
            this.tabTreatment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTreatment.Location = new System.Drawing.Point(4, 54);
            this.tabTreatment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Size = new System.Drawing.Size(1916, 991);
            this.tabTreatment.TabIndex = 3;
            this.tabTreatment.Text = "Treatment";
            this.tabTreatment.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployees});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1924, 52);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Database Menu";
            // 
            // viewEmployees
            // 
            this.viewEmployees.Name = "viewEmployees";
            this.viewEmployees.Size = new System.Drawing.Size(286, 48);
            this.viewEmployees.Text = "Shelter Employees";
            this.viewEmployees.Click += new System.EventHandler(this.viewEmployees_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.mainTabMenu);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDI";
            this.Text = "Weber County Animal Shelter-Mecical Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabMenu;
        private System.Windows.Forms.TabPage tabToDo;
        private System.Windows.Forms.TabPage tabViewAnimal;
        private System.Windows.Forms.TabPage tabCreateAnimal;
        private System.Windows.Forms.TabPage tabTreatment;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewEmployees;
    }
}