namespace dotnetprojet
{
    partial class StatisticController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.Framework.UI.BunifuCustomLabel Person;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticController));
            this.Tasks = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            Person = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Tasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // Person
            // 
            Person.AutoSize = true;
            Person.BackColor = System.Drawing.Color.Transparent;
            Person.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Person.ForeColor = System.Drawing.Color.Green;
            Person.Location = new System.Drawing.Point(128, 37);
            Person.Name = "Person";
            Person.Size = new System.Drawing.Size(48, 17);
            Person.TabIndex = 27;
            Person.Text = "Person";
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.White;
            this.Tasks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tasks.BackgroundImage")));
            this.Tasks.BorderRadius = 5;
            this.Tasks.BottomSahddow = true;
            this.Tasks.color = System.Drawing.Color.OliveDrab;
            this.Tasks.Controls.Add(this.bunifuImageButton2);
            this.Tasks.Controls.Add(Person);
            this.Tasks.Controls.Add(this.bunifuDropdown2);
            this.Tasks.LeftSahddow = false;
            this.Tasks.Location = new System.Drawing.Point(1, -1);
            this.Tasks.Name = "Tasks";
            this.Tasks.RightSahddow = true;
            this.Tasks.ShadowDepth = 20;
            this.Tasks.Size = new System.Drawing.Size(888, 653);
            this.Tasks.TabIndex = 8;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = global::dotnetprojet.Properties.Resources.pdf__1_;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(780, 449);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(37, 57);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 34;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(183, 27);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(183)))), ((int)(((byte)(32)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(183)))), ((int)(((byte)(32)))));
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(297, 38);
            this.bunifuDropdown2.TabIndex = 26;
            this.bunifuDropdown2.onItemSelected += new System.EventHandler(this.bunifuDropdown2_onItemSelected);
            // 
            // StatisticController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tasks);
            this.Name = "StatisticController";
            this.Size = new System.Drawing.Size(900, 650);
            this.Tasks.ResumeLayout(false);
            this.Tasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards Tasks;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
    }
}
