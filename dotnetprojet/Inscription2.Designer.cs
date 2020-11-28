namespace dotnetprojet
{
    partial class Inscription2
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
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription2));
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mother = new Bunifu.Framework.UI.BunifuCheckbox();
            this.father = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nbrchild = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.married = new Bunifu.Framework.UI.BunifuCheckbox();
            this.single = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.job = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adresse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AddImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.male = new Bunifu.Framework.UI.BunifuCheckbox();
            this.female = new Bunifu.Framework.UI.BunifuCheckbox();
            this.datebirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.userschedule = new System.Windows.Forms.TextBox();
            bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            bunifuCustomLabel6.AutoSize = true;
            bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel6.ForeColor = System.Drawing.Color.Teal;
            bunifuCustomLabel6.Location = new System.Drawing.Point(54, 21);
            bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            bunifuCustomLabel6.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel6.TabIndex = 41;
            bunifuCustomLabel6.Text = "Schedule of the day:";
            bunifuCustomLabel6.Click += new System.EventHandler(this.bunifuCustomLabel6_Click);
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(31, 35);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 31;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(821, 35);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 30;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.userschedule);
            this.panel2.Controls.Add(this.mother);
            this.panel2.Controls.Add(this.father);
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.bunifuCustomLabel8);
            this.panel2.Controls.Add(this.nbrchild);
            this.panel2.Controls.Add(bunifuCustomLabel6);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Controls.Add(this.married);
            this.panel2.Controls.Add(this.single);
            this.panel2.Location = new System.Drawing.Point(464, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 447);
            this.panel2.TabIndex = 21;
            // 
            // mother
            // 
            this.mother.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.mother.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.mother.Checked = false;
            this.mother.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.mother.ForeColor = System.Drawing.Color.White;
            this.mother.Location = new System.Drawing.Point(176, 270);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(20, 20);
            this.mother.TabIndex = 47;
            // 
            // father
            // 
            this.father.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.father.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.father.Checked = false;
            this.father.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.father.ForeColor = System.Drawing.Color.White;
            this.father.Location = new System.Drawing.Point(176, 231);
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(20, 20);
            this.father.TabIndex = 43;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AllowDrop = true;
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(45, 277);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(40, 13);
            this.bunifuCustomLabel11.TabIndex = 43;
            this.bunifuCustomLabel11.Text = "Mother";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(45, 231);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(34, 13);
            this.bunifuCustomLabel8.TabIndex = 43;
            this.bunifuCustomLabel8.Text = "father";
            // 
            // nbrchild
            // 
            this.nbrchild.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nbrchild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nbrchild.ForeColor = System.Drawing.Color.SeaGreen;
            this.nbrchild.HintForeColor = System.Drawing.Color.SeaGreen;
            this.nbrchild.HintText = "";
            this.nbrchild.isPassword = false;
            this.nbrchild.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.nbrchild.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.nbrchild.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.nbrchild.LineThickness = 3;
            this.nbrchild.Location = new System.Drawing.Point(154, 361);
            this.nbrchild.Margin = new System.Windows.Forms.Padding(4);
            this.nbrchild.Name = "nbrchild";
            this.nbrchild.Size = new System.Drawing.Size(191, 44);
            this.nbrchild.TabIndex = 46;
            this.nbrchild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(51, 182);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(60, 13);
            this.bunifuCustomLabel5.TabIndex = 45;
            this.bunifuCustomLabel5.Text = "Civil status:";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 374);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 13);
            this.bunifuCustomLabel1.TabIndex = 39;
            this.bunifuCustomLabel1.Text = "Number of children";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(134, 175);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(36, 13);
            this.bunifuCustomLabel10.TabIndex = 44;
            this.bunifuCustomLabel10.Text = "Single";
            this.bunifuCustomLabel10.Click += new System.EventHandler(this.bunifuCustomLabel10_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(233, 175);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel9.TabIndex = 43;
            this.bunifuCustomLabel9.Text = "Married";
            // 
            // married
            // 
            this.married.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.married.CausesValidation = false;
            this.married.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.married.Checked = false;
            this.married.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.married.ForeColor = System.Drawing.Color.White;
            this.married.Location = new System.Drawing.Point(298, 175);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(20, 20);
            this.married.TabIndex = 42;
            this.married.OnChange += new System.EventHandler(this.married_OnChange);
            // 
            // single
            // 
            this.single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.single.CausesValidation = false;
            this.single.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.single.Checked = false;
            this.single.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.single.ForeColor = System.Drawing.Color.White;
            this.single.Location = new System.Drawing.Point(187, 175);
            this.single.Name = "single";
            this.single.Size = new System.Drawing.Size(20, 20);
            this.single.TabIndex = 41;
            this.single.OnChange += new System.EventHandler(this.single_OnChange);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.job);
            this.panel1.Controls.Add(this.adresse);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.AddImage);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.datebirth);
            this.panel1.Location = new System.Drawing.Point(85, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 20;
            // 
            // job
            // 
            this.job.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.job.ForeColor = System.Drawing.Color.SeaGreen;
            this.job.HintForeColor = System.Drawing.Color.SeaGreen;
            this.job.HintText = "Job";
            this.job.isPassword = false;
            this.job.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.job.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.job.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.job.LineThickness = 3;
            this.job.Location = new System.Drawing.Point(25, 374);
            this.job.Margin = new System.Windows.Forms.Padding(4);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(309, 44);
            this.job.TabIndex = 42;
            this.job.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adresse
            // 
            this.adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.adresse.ForeColor = System.Drawing.Color.SeaGreen;
            this.adresse.HintForeColor = System.Drawing.Color.SeaGreen;
            this.adresse.HintText = "Address";
            this.adresse.isPassword = false;
            this.adresse.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.adresse.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.adresse.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.adresse.LineThickness = 3;
            this.adresse.Location = new System.Drawing.Point(25, 307);
            this.adresse.Margin = new System.Windows.Forms.Padding(4);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(309, 44);
            this.adresse.TabIndex = 41;
            this.adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(42, 199);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel4.TabIndex = 40;
            this.bunifuCustomLabel4.Text = "Gender";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 154);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "Date of Birth";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(112, 262);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel3.TabIndex = 38;
            this.bunifuCustomLabel3.Text = "Male";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Green;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(112, 224);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel7.TabIndex = 37;
            this.bunifuCustomLabel7.Text = "female";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
            // 
            // AddImage
            // 
            this.AddImage.BackColor = System.Drawing.Color.Transparent;
            this.AddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddImage.Image = global::dotnetprojet.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_23121;
            this.AddImage.ImageActive = null;
            this.AddImage.Location = new System.Drawing.Point(130, 32);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(91, 88);
            this.AddImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddImage.TabIndex = 35;
            this.AddImage.TabStop = false;
            this.AddImage.Zoom = 10;
            // 
            // male
            // 
            this.male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.male.CausesValidation = false;
            this.male.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.male.Checked = false;
            this.male.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.male.ForeColor = System.Drawing.Color.White;
            this.male.Location = new System.Drawing.Point(181, 255);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(20, 20);
            this.male.TabIndex = 6;
            this.male.OnChange += new System.EventHandler(this.male_OnChange);
            // 
            // female
            // 
            this.female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.female.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.female.Checked = false;
            this.female.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.female.ForeColor = System.Drawing.Color.White;
            this.female.Location = new System.Drawing.Point(181, 224);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(20, 20);
            this.female.TabIndex = 5;
            this.female.OnChange += new System.EventHandler(this.female_OnChange);
            // 
            // datebirth
            // 
            this.datebirth.BackColor = System.Drawing.Color.SeaGreen;
            this.datebirth.BorderRadius = 0;
            this.datebirth.ForeColor = System.Drawing.Color.White;
            this.datebirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datebirth.FormatCustom = null;
            this.datebirth.Location = new System.Drawing.Point(126, 141);
            this.datebirth.Name = "datebirth";
            this.datebirth.Size = new System.Drawing.Size(169, 36);
            this.datebirth.TabIndex = 4;
            this.datebirth.Value = new System.DateTime(2020, 3, 10, 14, 7, 11, 581);
            this.datebirth.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // userschedule
            // 
            this.userschedule.Location = new System.Drawing.Point(24, 51);
            this.userschedule.Multiline = true;
            this.userschedule.Name = "userschedule";
            this.userschedule.Size = new System.Drawing.Size(262, 116);
            this.userschedule.TabIndex = 48;
            // 
            // Inscription2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscription2";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Inscription2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker datebirth;
        private Bunifu.Framework.UI.BunifuCheckbox male;
        private Bunifu.Framework.UI.BunifuCheckbox female;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuImageButton AddImage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox married;
        private Bunifu.Framework.UI.BunifuCheckbox single;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nbrchild;
        private Bunifu.Framework.UI.BunifuMaterialTextbox job;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adresse;
        private Bunifu.Framework.UI.BunifuCheckbox mother;
        private Bunifu.Framework.UI.BunifuCheckbox father;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.TextBox userschedule;
    }
}