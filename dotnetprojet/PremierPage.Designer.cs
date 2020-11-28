namespace dotnetprojet
{
    partial class PremierPage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PremierPage));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Commencer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CreationCompte = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(316, 146);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 42);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // Commencer
            // 
            this.Commencer.AccessibleName = "ToStart";
            this.Commencer.ActiveBorderThickness = 1;
            this.Commencer.ActiveCornerRadius = 20;
            this.Commencer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Commencer.ActiveForecolor = System.Drawing.Color.White;
            this.Commencer.ActiveLineColor = System.Drawing.Color.Green;
            this.Commencer.BackColor = System.Drawing.SystemColors.Control;
            this.Commencer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Commencer.BackgroundImage")));
            this.Commencer.ButtonText = "To Start";
            this.Commencer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Commencer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Commencer.ForeColor = System.Drawing.Color.DarkGreen;
            this.Commencer.IdleBorderThickness = 1;
            this.Commencer.IdleCornerRadius = 20;
            this.Commencer.IdleFillColor = System.Drawing.Color.White;
            this.Commencer.IdleForecolor = System.Drawing.Color.Green;
            this.Commencer.IdleLineColor = System.Drawing.Color.DarkGreen;
            this.Commencer.Location = new System.Drawing.Point(302, 234);
            this.Commencer.Margin = new System.Windows.Forms.Padding(5);
            this.Commencer.Name = "Commencer";
            this.Commencer.Size = new System.Drawing.Size(249, 55);
            this.Commencer.TabIndex = 8;
            this.Commencer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Commencer.Click += new System.EventHandler(this.Commencer_Click);
            // 
            // CreationCompte
            // 
            this.CreationCompte.ActiveBorderThickness = 1;
            this.CreationCompte.ActiveCornerRadius = 20;
            this.CreationCompte.ActiveFillColor = System.Drawing.Color.Peru;
            this.CreationCompte.ActiveForecolor = System.Drawing.Color.White;
            this.CreationCompte.ActiveLineColor = System.Drawing.Color.Peru;
            this.CreationCompte.BackColor = System.Drawing.SystemColors.Control;
            this.CreationCompte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreationCompte.BackgroundImage")));
            this.CreationCompte.ButtonText = "I already have a family account";
            this.CreationCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreationCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreationCompte.ForeColor = System.Drawing.Color.DarkGreen;
            this.CreationCompte.IdleBorderThickness = 1;
            this.CreationCompte.IdleCornerRadius = 20;
            this.CreationCompte.IdleFillColor = System.Drawing.Color.White;
            this.CreationCompte.IdleForecolor = System.Drawing.Color.Green;
            this.CreationCompte.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.CreationCompte.Location = new System.Drawing.Point(302, 319);
            this.CreationCompte.Margin = new System.Windows.Forms.Padding(5);
            this.CreationCompte.Name = "CreationCompte";
            this.CreationCompte.Size = new System.Drawing.Size(249, 60);
            this.CreationCompte.TabIndex = 9;
            this.CreationCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreationCompte.Click += new System.EventHandler(this.CreationCompte_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.Image = global::dotnetprojet.Properties.Resources.close;
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(793, 46);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(51, 55);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 12;
            this.Close.TabStop = false;
            this.Close.Zoom = 10;
            // 
            // PremierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 667);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CreationCompte);
            this.Controls.Add(this.Commencer);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PremierPage";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Commencer;
        private Bunifu.Framework.UI.BunifuThinButton2 CreationCompte;
        private Bunifu.Framework.UI.BunifuImageButton Close;
    }
}

