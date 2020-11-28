namespace dotnetprojet
{
    partial class Parent
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
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.fatherJobTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fatherNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.next = new Bunifu.Framework.UI.BunifuImageButton();
            this.pred = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.motherJobTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.motherNameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fatherScheduleTxt = new System.Windows.Forms.TextBox();
            this.motherScheduleTxt = new System.Windows.Forms.TextBox();
            bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            bunifuCustomLabel2.AutoSize = true;
            bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bunifuCustomLabel2.Location = new System.Drawing.Point(56, 243);
            bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            bunifuCustomLabel2.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel2.TabIndex = 32;
            bunifuCustomLabel2.Text = "Schedule of the day:";
            // 
            // bunifuCustomLabel1
            // 
            bunifuCustomLabel1.AutoSize = true;
            bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            bunifuCustomLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            bunifuCustomLabel1.Location = new System.Drawing.Point(56, 243);
            bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            bunifuCustomLabel1.Size = new System.Drawing.Size(107, 15);
            bunifuCustomLabel1.TabIndex = 32;
            bunifuCustomLabel1.Text = "Schedule of the day:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.fatherScheduleTxt);
            this.panel1.Controls.Add(this.fatherJobTxt);
            this.panel1.Controls.Add(this.fatherNameTxt);
            this.panel1.Controls.Add(bunifuCustomLabel2);
            this.panel1.Location = new System.Drawing.Point(85, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 447);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fatherJobTxt
            // 
            this.fatherJobTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fatherJobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fatherJobTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.fatherJobTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.fatherJobTxt.HintText = "Father\'s job";
            this.fatherJobTxt.isPassword = false;
            this.fatherJobTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.fatherJobTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.fatherJobTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.fatherJobTxt.LineThickness = 3;
            this.fatherJobTxt.Location = new System.Drawing.Point(56, 143);
            this.fatherJobTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fatherJobTxt.Name = "fatherJobTxt";
            this.fatherJobTxt.Size = new System.Drawing.Size(262, 44);
            this.fatherJobTxt.TabIndex = 35;
            this.fatherJobTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fatherNameTxt
            // 
            this.fatherNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fatherNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fatherNameTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.fatherNameTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.fatherNameTxt.HintText = "Father\'s Name";
            this.fatherNameTxt.isPassword = false;
            this.fatherNameTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.fatherNameTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.fatherNameTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.fatherNameTxt.LineThickness = 3;
            this.fatherNameTxt.Location = new System.Drawing.Point(56, 64);
            this.fatherNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.fatherNameTxt.Name = "fatherNameTxt";
            this.fatherNameTxt.Size = new System.Drawing.Size(262, 44);
            this.fatherNameTxt.TabIndex = 34;
            this.fatherNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.Image = global::dotnetprojet.Properties.Resources.next__1_;
            this.next.ImageActive = null;
            this.next.Location = new System.Drawing.Point(808, 36);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(43, 41);
            this.next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.next.TabIndex = 30;
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
            this.pred.Location = new System.Drawing.Point(51, 36);
            this.pred.Name = "pred";
            this.pred.Size = new System.Drawing.Size(43, 41);
            this.pred.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pred.TabIndex = 31;
            this.pred.TabStop = false;
            this.pred.Zoom = 10;
            this.pred.Click += new System.EventHandler(this.pred_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.motherScheduleTxt);
            this.panel2.Controls.Add(this.motherJobTxt);
            this.panel2.Controls.Add(this.motherNameTxt);
            this.panel2.Controls.Add(bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(479, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 447);
            this.panel2.TabIndex = 18;
            // 
            // motherJobTxt
            // 
            this.motherJobTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motherJobTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.motherJobTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.motherJobTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.motherJobTxt.HintText = "Mother\'s job";
            this.motherJobTxt.isPassword = false;
            this.motherJobTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.motherJobTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.motherJobTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.motherJobTxt.LineThickness = 3;
            this.motherJobTxt.Location = new System.Drawing.Point(44, 143);
            this.motherJobTxt.Margin = new System.Windows.Forms.Padding(4);
            this.motherJobTxt.Name = "motherJobTxt";
            this.motherJobTxt.Size = new System.Drawing.Size(262, 44);
            this.motherJobTxt.TabIndex = 37;
            this.motherJobTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // motherNameTxt
            // 
            this.motherNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.motherNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.motherNameTxt.ForeColor = System.Drawing.Color.SeaGreen;
            this.motherNameTxt.HintForeColor = System.Drawing.Color.SeaGreen;
            this.motherNameTxt.HintText = "Mother\'s Name";
            this.motherNameTxt.isPassword = false;
            this.motherNameTxt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.motherNameTxt.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.motherNameTxt.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.motherNameTxt.LineThickness = 3;
            this.motherNameTxt.Location = new System.Drawing.Point(44, 64);
            this.motherNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.motherNameTxt.Name = "motherNameTxt";
            this.motherNameTxt.Size = new System.Drawing.Size(262, 44);
            this.motherNameTxt.TabIndex = 36;
            this.motherNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fatherScheduleTxt
            // 
            this.fatherScheduleTxt.Location = new System.Drawing.Point(56, 280);
            this.fatherScheduleTxt.Multiline = true;
            this.fatherScheduleTxt.Name = "fatherScheduleTxt";
            this.fatherScheduleTxt.Size = new System.Drawing.Size(262, 116);
            this.fatherScheduleTxt.TabIndex = 36;
            // 
            // motherScheduleTxt
            // 
            this.motherScheduleTxt.Location = new System.Drawing.Point(44, 280);
            this.motherScheduleTxt.Multiline = true;
            this.motherScheduleTxt.Name = "motherScheduleTxt";
            this.motherScheduleTxt.Size = new System.Drawing.Size(262, 116);
            this.motherScheduleTxt.TabIndex = 37;
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pred);
            this.Controls.Add(this.next);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parent";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pred)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton next;
        private Bunifu.Framework.UI.BunifuImageButton pred;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fatherJobTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fatherNameTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox motherJobTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox motherNameTxt;
        private System.Windows.Forms.TextBox fatherScheduleTxt;
        private System.Windows.Forms.TextBox motherScheduleTxt;
    }
}