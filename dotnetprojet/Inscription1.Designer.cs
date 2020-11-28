namespace dotnetprojet
{
    partial class Inscription1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription1));
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.firstname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(803, 36);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 30;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Location = new System.Drawing.Point(273, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.HintForeColor = System.Drawing.Color.SeaGreen;
            this.password.HintText = "Password";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.password.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.password.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(19, 350);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(322, 44);
            this.password.TabIndex = 44;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.email.ForeColor = System.Drawing.Color.SeaGreen;
            this.email.HintForeColor = System.Drawing.Color.SeaGreen;
            this.email.HintText = "Email";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.email.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.email.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(19, 253);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(322, 44);
            this.email.TabIndex = 43;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lastname
            // 
            this.lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastname.HintForeColor = System.Drawing.Color.SeaGreen;
            this.lastname.HintText = "Last Name";
            this.lastname.isPassword = false;
            this.lastname.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.lastname.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.lastname.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.lastname.LineThickness = 3;
            this.lastname.Location = new System.Drawing.Point(19, 160);
            this.lastname.Margin = new System.Windows.Forms.Padding(4);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(322, 44);
            this.lastname.TabIndex = 42;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // firstname
            // 
            this.firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.firstname.ForeColor = System.Drawing.Color.SeaGreen;
            this.firstname.HintForeColor = System.Drawing.Color.SeaGreen;
            this.firstname.HintText = "";
            this.firstname.isPassword = false;
            this.firstname.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.firstname.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.firstname.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.firstname.LineThickness = 3;
            this.firstname.Location = new System.Drawing.Point(19, 71);
            this.firstname.Margin = new System.Windows.Forms.Padding(4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(322, 44);
            this.firstname.TabIndex = 41;
            this.firstname.Text = "First Name";
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(62, 32);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(244, 25);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "Create a family account.";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(32, 36);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(43, 41);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 33;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Inscription1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscription1";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Inscription1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastname;
    }
}