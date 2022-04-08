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
            this.ProgramTabMenu = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabViewAnimal = new System.Windows.Forms.TabPage();
            this.tabCreateAnimal = new System.Windows.Forms.TabPage();
            this.tabTreatment = new System.Windows.Forms.TabPage();
            this.ProgramTabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramTabMenu
            // 
            this.ProgramTabMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ProgramTabMenu.Controls.Add(this.tabHome);
            this.ProgramTabMenu.Controls.Add(this.tabViewAnimal);
            this.ProgramTabMenu.Controls.Add(this.tabCreateAnimal);
            this.ProgramTabMenu.Controls.Add(this.tabTreatment);
            this.ProgramTabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramTabMenu.Font = new System.Drawing.Font("Rockwell Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTabMenu.ItemSize = new System.Drawing.Size(600, 50);
            this.ProgramTabMenu.Location = new System.Drawing.Point(0, 0);
            this.ProgramTabMenu.Name = "ProgramTabMenu";
            this.ProgramTabMenu.SelectedIndex = 0;
            this.ProgramTabMenu.Size = new System.Drawing.Size(2398, 1787);
            this.ProgramTabMenu.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabHome.Location = new System.Drawing.Point(4, 54);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(2390, 1729);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "        Home        ";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabViewAnimal
            // 
            this.tabViewAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabViewAnimal.Name = "tabViewAnimal";
            this.tabViewAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAnimal.Size = new System.Drawing.Size(2390, 1729);
            this.tabViewAnimal.TabIndex = 1;
            this.tabViewAnimal.Text = "    View Animal    ";
            this.tabViewAnimal.UseVisualStyleBackColor = true;
            // 
            // tabCreateAnimal
            // 
            this.tabCreateAnimal.Location = new System.Drawing.Point(4, 54);
            this.tabCreateAnimal.Name = "tabCreateAnimal";
            this.tabCreateAnimal.Size = new System.Drawing.Size(2390, 1729);
            this.tabCreateAnimal.TabIndex = 2;
            this.tabCreateAnimal.Text = "    Create Animal   ";
            this.tabCreateAnimal.UseVisualStyleBackColor = true;
            // 
            // tabTreatment
            // 
            this.tabTreatment.Location = new System.Drawing.Point(4, 54);
            this.tabTreatment.Name = "tabTreatment";
            this.tabTreatment.Size = new System.Drawing.Size(2390, 1729);
            this.tabTreatment.TabIndex = 3;
            this.tabTreatment.Text = "      Treatment      ";
            this.tabTreatment.UseVisualStyleBackColor = true;
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2398, 1787);
            this.Controls.Add(this.ProgramTabMenu);
            this.Name = "MDI";
            this.Text = "Weber County Animal Shelter-Mecical Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ProgramTabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProgramTabMenu;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabViewAnimal;
        private System.Windows.Forms.TabPage tabCreateAnimal;
        private System.Windows.Forms.TabPage tabTreatment;
    }
}