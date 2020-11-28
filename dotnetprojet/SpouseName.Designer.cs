namespace dotnetprojet
{
    partial class SpouseName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpouseName));
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spouseschedule = new System.Windows.Forms.TextBox();
            this.spouseJobTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.spouseNametxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel6
            // 
            bunifuCustomLabel6.AutoSize = true;
            bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel6.ForeColor = System.Drawing.Color.Teal;
            bunifuCustomLabel6.Location = new System.Drawing.Point(23, 209);
            bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            bunifuCustomLabel6.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel6.TabIndex = 43;
            bunifuCustomLabel6.Text = "Schedule of the day:";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(814, 32);
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
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.spouseschedule);
            this.panel1.Controls.Add(this.spouseJobTxt);
            this.panel1.Controls.Add(this.spouseNametxt);
            this.panel1.Controls.Add(bunifuCustomLabel6);
            this.panel1.Location = new System.Drawing.Point(249, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 14;
            // 
            // spouseschedule
            // 
            this.spouseschedule.Location = new System.Drawing.Point(23, 249);
            this.spouseschedule.Multiline = true;
            this.spouseschedule.Name = "spouseschedule";
            this.spouseschedule.Size = new System.Drawing.Size(318, 116);
            this.spouseschedule.TabIndex = 47;
            // 
            // spouseJobTxt
            // 
            this.spouseJobTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spouseJobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.spouseJobTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.HintText = "Job";
            this.spouseJobTxt.isPassword = false;
            this.spouseJobTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.spouseJobTxt.LineThickness = 3;
            this.spouseJobTxt.Location = new System.Drawing.Point(23, 144);
            this.spouseJobTxt.Margin = new System.Windows.Forms.Padding(4);
            this.spouseJobTxt.Name = "spouseJobTxt";
            this.spouseJobTxt.Size = new System.Drawing.Size(318, 44);
            this.spouseJobTxt.TabIndex = 46;
            this.spouseJobTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // spouseNametxt
            // 
            this.spouseNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spouseNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.spouseNametxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.HintText = "Partner Name";
            this.spouseNametxt.isPassword = false;
            this.spouseNametxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.spouseNametxt.LineThickness = 3;
            this.spouseNametxt.Location = new System.Drawing.Point(23, 63);
            this.spouseNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.spouseNametxt.Name = "spouseNametxt";
            this.spouseNametxt.Size = new System.Drawing.Size(318, 44);
            this.spouseNametxt.TabIndex = 45;
            this.spouseNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(55, 32);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 32;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(68)))));
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(120, 371);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(68)))));
            this.updateBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(122, 48);
            this.updateBtn.TabIndex = 50;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // SpouseName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpouseName";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuMaterialTextbox spouseJobTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox spouseNametxt;
        private System.Windows.Forms.TextBox spouseschedule;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
    }
}