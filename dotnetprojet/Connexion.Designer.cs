namespace dotnetprojet
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Facebook = new Bunifu.Framework.UI.BunifuImageButton();
            this.Gmail = new Bunifu.Framework.UI.BunifuImageButton();
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.Facebook);
            this.panel1.Controls.Add(this.Gmail);
            this.panel1.Location = new System.Drawing.Point(261, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 14;
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
            this.password.Location = new System.Drawing.Point(17, 214);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(315, 44);
            this.password.TabIndex = 45;
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
            this.email.Location = new System.Drawing.Point(23, 133);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(309, 44);
            this.email.TabIndex = 43;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 42);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(324, 29);
            this.bunifuCustomLabel2.TabIndex = 41;
            this.bunifuCustomLabel2.Text = "Let\'s start with your profile.";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuImageButton2.Image = global::dotnetprojet.Properties.Resources.twitter1;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(270, 354);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(43, 41);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 21;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Facebook
            // 
            this.Facebook.BackColor = System.Drawing.Color.Transparent;
            this.Facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Facebook.Image = global::dotnetprojet.Properties.Resources.facebook1;
            this.Facebook.ImageActive = null;
            this.Facebook.Location = new System.Drawing.Point(34, 354);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(43, 41);
            this.Facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Facebook.TabIndex = 20;
            this.Facebook.TabStop = false;
            this.Facebook.Zoom = 10;
            // 
            // Gmail
            // 
            this.Gmail.BackColor = System.Drawing.Color.Transparent;
            this.Gmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Gmail.Image = global::dotnetprojet.Properties.Resources.icons8_gmail_48;
            this.Gmail.ImageActive = null;
            this.Gmail.Location = new System.Drawing.Point(151, 354);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(43, 41);
            this.Gmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Gmail.TabIndex = 19;
            this.Gmail.TabStop = false;
            this.Gmail.Zoom = 10;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(818, 39);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 29;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(39, 39);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 30;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "Voice_Recognition";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Connexion";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Connexion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton Gmail;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton Facebook;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.Button button1;
    }
}