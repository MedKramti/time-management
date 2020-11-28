namespace dotnetprojet
{
    partial class ChildrenForm
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
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildrenForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.childrenschedule = new System.Windows.Forms.TextBox();
            this.schoolDistanceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.degreeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.childrenNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.combobox = new Bunifu.Framework.UI.BunifuDropdown();
            this.updatebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            bunifuCustomLabel2.AutoSize = true;
            bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkCyan;
            bunifuCustomLabel2.Location = new System.Drawing.Point(55, 261);
            bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            bunifuCustomLabel2.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel2.TabIndex = 30;
            bunifuCustomLabel2.Text = "Schedule of the day:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.combobox);
            this.panel1.Controls.Add(this.childrenschedule);
            this.panel1.Controls.Add(this.schoolDistanceTxt);
            this.panel1.Controls.Add(this.degreeTxt);
            this.panel1.Controls.Add(this.childrenNameTxt);
            this.panel1.Controls.Add(bunifuCustomLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(268, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // childrenschedule
            // 
            this.childrenschedule.Location = new System.Drawing.Point(16, 289);
            this.childrenschedule.Multiline = true;
            this.childrenschedule.Name = "childrenschedule";
            this.childrenschedule.Size = new System.Drawing.Size(322, 97);
            this.childrenschedule.TabIndex = 47;
            // 
            // schoolDistanceTxt
            // 
            this.schoolDistanceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.schoolDistanceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.schoolDistanceTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.HintText = "School distance/Job distance";
            this.schoolDistanceTxt.isPassword = false;
            this.schoolDistanceTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.schoolDistanceTxt.LineThickness = 3;
            this.schoolDistanceTxt.Location = new System.Drawing.Point(16, 196);
            this.schoolDistanceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.schoolDistanceTxt.Name = "schoolDistanceTxt";
            this.schoolDistanceTxt.Size = new System.Drawing.Size(322, 44);
            this.schoolDistanceTxt.TabIndex = 46;
            this.schoolDistanceTxt.Text = "School distance";
            this.schoolDistanceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // degreeTxt
            // 
            this.degreeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.degreeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.degreeTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.degreeTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.HintText = "Degree/Job";
            this.degreeTxt.isPassword = false;
            this.degreeTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.degreeTxt.LineThickness = 3;
            this.degreeTxt.Location = new System.Drawing.Point(16, 133);
            this.degreeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.degreeTxt.Name = "degreeTxt";
            this.degreeTxt.Size = new System.Drawing.Size(322, 44);
            this.degreeTxt.TabIndex = 45;
            this.degreeTxt.Text = "Degree";
            this.degreeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // childrenNameTxt
            // 
            this.childrenNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.childrenNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.childrenNameTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.HintText = "Child Name";
            this.childrenNameTxt.isPassword = false;
            this.childrenNameTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.childrenNameTxt.LineThickness = 3;
            this.childrenNameTxt.Location = new System.Drawing.Point(16, 70);
            this.childrenNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.childrenNameTxt.Name = "childrenNameTxt";
            this.childrenNameTxt.Size = new System.Drawing.Size(322, 44);
            this.childrenNameTxt.TabIndex = 44;
            this.childrenNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // pred
            // 
            this.pred.BackColor = System.Drawing.Color.Transparent;
            this.pred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pred.Image = global::dotnetprojet.Properties.Resources.pred__1_;
            this.pred.ImageActive = null;
            this.pred.Location = new System.Drawing.Point(29, 62);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 34;
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
            this.next.Location = new System.Drawing.Point(828, 62);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 33;
            this.next.TabStop = false;
            this.next.Zoom = 10;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // combobox
            // 
            this.combobox.BackColor = System.Drawing.Color.Transparent;
            this.combobox.BorderRadius = 3;
            this.combobox.ForeColor = System.Drawing.Color.White;
            this.combobox.Items = new string[0];
            this.combobox.Location = new System.Drawing.Point(16, 19);
            this.combobox.Name = "combobox";
            this.combobox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(68)))));
            this.combobox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combobox.selectedIndex = -1;
            this.combobox.Size = new System.Drawing.Size(322, 35);
            this.combobox.TabIndex = 48;
            this.combobox.Visible = false;
            this.combobox.onItemSelected += new System.EventHandler(this.combobox_onItemSelected);
            // 
            // updatebtn
            // 
            this.updatebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(68)))));
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatebtn.BorderRadius = 0;
            this.updatebtn.ButtonText = "Update";
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.DisabledColor = System.Drawing.Color.Gray;
            this.updatebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updatebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updatebtn.Iconimage")));
            this.updatebtn.Iconimage_right = null;
            this.updatebtn.Iconimage_right_Selected = null;
            this.updatebtn.Iconimage_Selected = null;
            this.updatebtn.IconMarginLeft = 0;
            this.updatebtn.IconMarginRight = 0;
            this.updatebtn.IconRightVisible = true;
            this.updatebtn.IconRightZoom = 0D;
            this.updatebtn.IconVisible = true;
            this.updatebtn.IconZoom = 90D;
            this.updatebtn.IsTab = false;
            this.updatebtn.Location = new System.Drawing.Point(110, 392);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(180)))), ((int)(((byte)(68)))));
            this.updatebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updatebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updatebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updatebtn.selected = false;
            this.updatebtn.Size = new System.Drawing.Size(122, 48);
            this.updatebtn.TabIndex = 49;
            this.updatebtn.Text = "Update";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebtn.Textcolor = System.Drawing.Color.White;
            this.updatebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Visible = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // ChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildrenForm";
            this.Text = "ChildrenForm";
            this.Load += new System.EventHandler(this.ChildrenForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox schoolDistanceTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox degreeTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox childrenNameTxt;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private System.Windows.Forms.TextBox childrenschedule;
        private Bunifu.Framework.UI.BunifuDropdown combobox;
        private Bunifu.Framework.UI.BunifuFlatButton updatebtn;
    }
}