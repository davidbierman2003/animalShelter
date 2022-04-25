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
            this.mainTabMenu.SuspendLayout();
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
            this.mainTabMenu.Location = new System.Drawing.Point(0, 0);
            this.mainTabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTabMenu.Name = "mainTabMenu";
            this.mainTabMenu.SelectedIndex = 0;
            this.mainTabMenu.Size = new System.Drawing.Size(1082, 677);
            this.mainTabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabMenu.TabIndex = 1;
            // 
            // tabToDo
            // 
            this.tabToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabToDo.Location = new System.Drawing.Point(4, 54);
            this.tabToDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabToDo.Name = "tabToDo";
            this.tabToDo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabToDo.Size = new System.Drawing.Size(1074, 619);
            this.tabToDo.TabIndex = 0;
            this.tabToDo.Text = "To Do";
            this.tabToDo.UseVisualStyleBackColor = true;
            // 
            // tabViewAnimal
            // 
            this.tabViewAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabViewAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabViewAnimal.Name = "tabViewAnimal";
            this.tabViewAnimal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabViewAnimal.Size = new System.Drawing.Size(1074, 619);
            this.tabViewAnimal.TabIndex = 1;
            this.tabViewAnimal.Text = "View Animal";
            this.tabViewAnimal.UseVisualStyleBackColor = true;
            this.tabViewAnimal.Click += new System.EventHandler(this.tabViewAnimal_Click);
            // 
            // tabCreateAnimal
            // 
            this.tabCreateAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabCreateAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCreateAnimal.Name = "tabCreateAnimal";
            this.tabCreateAnimal.Size = new System.Drawing.Size(1341, 1095);
            this.tabCreateAnimal.TabIndex = 2;
            this.tabCreateAnimal.Text = "Add Animal";
            this.tabCreateAnimal.UseVisualStyleBackColor = true;
            // 
            // tabTreatment
            // 
            this.tabTreatment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTreatment.Location = new System.Drawing.Point(4, 54);
            this.tabTreatment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Size = new System.Drawing.Size(1341, 1095);
            this.tabTreatment.TabIndex = 3;
            this.tabTreatment.Text = "Treatment";
            this.tabTreatment.UseVisualStyleBackColor = true;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 677);
            this.Controls.Add(this.mainTabMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MDI";
            this.Text = "Weber County Animal Shelter-Mecical Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabMenu;
        private System.Windows.Forms.TabPage tabToDo;
        private System.Windows.Forms.TabPage tabViewAnimal;
        private System.Windows.Forms.TabPage tabCreateAnimal;
        private System.Windows.Forms.TabPage tabTreatment;
    }
}