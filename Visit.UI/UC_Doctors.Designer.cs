namespace Visit.UI
{
    partial class UC_Doctors
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
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTakhasos = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnVisit = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxProfile.ErrorImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.InitialImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Location = new System.Drawing.Point(378, 0);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Location = new System.Drawing.Point(146, 76);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(227, 33);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = ".";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTakhasos
            // 
            this.lblTakhasos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTakhasos.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTakhasos.Location = new System.Drawing.Point(146, 43);
            this.lblTakhasos.Name = "lblTakhasos";
            this.lblTakhasos.Size = new System.Drawing.Size(227, 33);
            this.lblTakhasos.TabIndex = 11;
            this.lblTakhasos.Text = ".";
            this.lblTakhasos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullName.Location = new System.Drawing.Point(143, 10);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(230, 33);
            this.lblFullName.TabIndex = 10;
            this.lblFullName.Text = ".";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Animated = true;
            this.btnVisit.AutoRoundedCorners = true;
            this.btnVisit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVisit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVisit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVisit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVisit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnVisit.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnVisit.ForeColor = System.Drawing.Color.White;
            this.btnVisit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnVisit.Location = new System.Drawing.Point(11, 25);
            this.btnVisit.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(84, 63);
            this.btnVisit.TabIndex = 13;
            this.btnVisit.Text = "دریافت نوبت";
            this.btnVisit.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // UC_Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTakhasos);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Doctors";
            this.Size = new System.Drawing.Size(493, 115);
            this.Load += new System.EventHandler(this.UC_Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTakhasos;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2GradientButton btnVisit;
    }
}
