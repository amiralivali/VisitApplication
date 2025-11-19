namespace Visit.UI
{
    partial class frmCheckProfileBimar
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
            this.btnRecordinformation = new Guna.UI2.WinForms.Guna2Button();
            this.pbProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNc = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecordinformation
            // 
            this.btnRecordinformation.Animated = true;
            this.btnRecordinformation.AutoRoundedCorners = true;
            this.btnRecordinformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecordinformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecordinformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecordinformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecordinformation.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRecordinformation.ForeColor = System.Drawing.Color.White;
            this.btnRecordinformation.Location = new System.Drawing.Point(211, 255);
            this.btnRecordinformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordinformation.Name = "btnRecordinformation";
            this.btnRecordinformation.Size = new System.Drawing.Size(209, 52);
            this.btnRecordinformation.TabIndex = 43;
            this.btnRecordinformation.Text = "ثبت اطلاعات";
            this.btnRecordinformation.Click += new System.EventHandler(this.btnRecordinformation_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pbProfile.ImageRotate = 0F;
            this.pbProfile.Location = new System.Drawing.Point(345, 14);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProfile.Size = new System.Drawing.Size(241, 222);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 42;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.PictureBoxProfile_Click);
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(225, 139);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(42, 16);
            this.lblNcNezam.TabIndex = 41;
            this.lblNcNezam.Text = "کد ملی";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(220, 91);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(73, 16);
            this.lblLastName.TabIndex = 40;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // txtLastName
            // 
            this.txtLastName.Animated = true;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(31, 85);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(169, 33);
            this.txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(225, 41);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(21, 16);
            this.lblFirstName.TabIndex = 39;
            this.lblFirstName.Text = "نام";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Animated = true;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(31, 41);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(169, 33);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(224, 190);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(71, 16);
            this.lblMobile.TabIndex = 38;
            this.lblMobile.Text = "شماره همراه";
            // 
            // txtMobile
            // 
            this.txtMobile.Animated = true;
            this.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobile.DefaultText = "";
            this.txtMobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobile.Location = new System.Drawing.Point(31, 177);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(169, 33);
            this.txtMobile.TabIndex = 3;
            // 
            // txtNc
            // 
            this.txtNc.Animated = true;
            this.txtNc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNc.DefaultText = "";
            this.txtNc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNc.Location = new System.Drawing.Point(31, 132);
            this.txtNc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNc.Name = "txtNc";
            this.txtNc.PlaceholderText = "";
            this.txtNc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNc.SelectedText = "";
            this.txtNc.Size = new System.Drawing.Size(169, 33);
            this.txtNc.TabIndex = 2;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(60, 234);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(81, 73);
            this.ProgressBar.TabIndex = 44;
            this.ProgressBar.Visible = false;
            // 
            // frmCheckProfileBimar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 322);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnRecordinformation);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.lblNcNezam);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmCheckProfileBimar";
            this.Text = "ویزیت 24";
            this.Load += new System.EventHandler(this.frmCheckProfileBimar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRecordinformation;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfile;
        private System.Windows.Forms.Label lblNcNezam;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtNc;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressBar;
    }
}