namespace Visit.UI
{
    partial class frmCheckProfileDoctor
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
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.btnRecordinformation = new Guna.UI2.WinForms.Guna2Button();
            this.pbProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNezam = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeTime = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(374, 195);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(80, 77);
            this.guna2CircleButton1.TabIndex = 36;
            this.guna2CircleButton1.Text = "اضافه کردن تخصص";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(36, 207);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(72, 52);
            this.ProgressBar.TabIndex = 34;
            this.ProgressBar.Visible = false;
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
            this.btnRecordinformation.Location = new System.Drawing.Point(125, 217);
            this.btnRecordinformation.Name = "btnRecordinformation";
            this.btnRecordinformation.Size = new System.Drawing.Size(157, 42);
            this.btnRecordinformation.TabIndex = 33;
            this.btnRecordinformation.Text = "ثبت اطلاعات";
            this.btnRecordinformation.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pbProfile.ImageRotate = 0F;
            this.pbProfile.Location = new System.Drawing.Point(259, 11);
            this.pbProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProfile.Size = new System.Drawing.Size(181, 180);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 32;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.PictureBoxProfile_Click);
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(175, 114);
            this.lblNcNezam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(80, 13);
            this.lblNcNezam.TabIndex = 31;
            this.lblNcNezam.Text = "کد نظام پزشکی";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(182, 74);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 13);
            this.lblLastName.TabIndex = 30;
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
            this.txtLastName.Location = new System.Drawing.Point(36, 69);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(127, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(182, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(20, 13);
            this.lblFirstName.TabIndex = 29;
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
            this.txtFirstName.Location = new System.Drawing.Point(36, 33);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(127, 27);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(181, 154);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 13);
            this.lblMobile.TabIndex = 28;
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
            this.txtMobile.Location = new System.Drawing.Point(36, 144);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(127, 27);
            this.txtMobile.TabIndex = 3;
            // 
            // txtNezam
            // 
            this.txtNezam.Animated = true;
            this.txtNezam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNezam.DefaultText = "";
            this.txtNezam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNezam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNezam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNezam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNezam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNezam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNezam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNezam.Location = new System.Drawing.Point(36, 107);
            this.txtNezam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNezam.Name = "txtNezam";
            this.txtNezam.PlaceholderText = "";
            this.txtNezam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNezam.SelectedText = "";
            this.txtNezam.Size = new System.Drawing.Size(127, 27);
            this.txtNezam.TabIndex = 2;
            // 
            // btnChangeTime
            // 
            this.btnChangeTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeTime.ForeColor = System.Drawing.Color.White;
            this.btnChangeTime.Location = new System.Drawing.Point(288, 196);
            this.btnChangeTime.Name = "btnChangeTime";
            this.btnChangeTime.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChangeTime.Size = new System.Drawing.Size(80, 77);
            this.btnChangeTime.TabIndex = 37;
            this.btnChangeTime.Text = "تغییر ساعت کاری";
            this.btnChangeTime.Click += new System.EventHandler(this.btnChangeTime_Click);
            // 
            // frmCheckProfileDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 284);
            this.Controls.Add(this.btnChangeTime);
            this.Controls.Add(this.guna2CircleButton1);
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
            this.Controls.Add(this.txtNezam);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmCheckProfileDoctor";
            this.Text = "ویزیت 24";
            this.Load += new System.EventHandler(this.frmCheckProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfile;
        private System.Windows.Forms.Label lblNcNezam;
        private System.Windows.Forms.Label lblLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label lblMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtNezam;
        private Guna.UI2.WinForms.Guna2Button btnRecordinformation;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressBar;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton btnChangeTime;
    }
}