namespace Visit.UI
{
    partial class frmDoctorSignIn
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lbltime = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtEnterCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.panelTexBoxes = new System.Windows.Forms.Panel();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNezam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TimeProgressBar.SuspendLayout();
            this.panelTexBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // TimeProgressBar
            // 
            this.TimeProgressBar.Controls.Add(this.lbltime);
            this.TimeProgressBar.FillColor = System.Drawing.Color.White;
            this.TimeProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimeProgressBar.ForeColor = System.Drawing.Color.White;
            this.TimeProgressBar.Location = new System.Drawing.Point(146, 173);
            this.TimeProgressBar.Minimum = 0;
            this.TimeProgressBar.Name = "TimeProgressBar";
            this.TimeProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TimeProgressBar.Size = new System.Drawing.Size(94, 94);
            this.TimeProgressBar.TabIndex = 55;
            this.TimeProgressBar.Text = "guna2CircleProgressBar1";
            this.TimeProgressBar.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lbltime.Location = new System.Drawing.Point(36, 39);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(24, 17);
            this.lbltime.TabIndex = 36;
            this.lbltime.Text = "60";
            this.lbltime.Visible = false;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(33, 199);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(62, 54);
            this.ProgressBar.TabIndex = 53;
            this.ProgressBar.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Animated = true;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(169, 181);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.Size = new System.Drawing.Size(69, 65);
            this.btnSend.TabIndex = 51;
            this.btnSend.Text = "ارسال پیامک";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(396, 171);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(44, 13);
            this.lblCode.TabIndex = 50;
            this.lblCode.Text = "کد ورود";
            // 
            // txtEnterCode
            // 
            this.txtEnterCode.Animated = true;
            this.txtEnterCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterCode.DefaultText = "";
            this.txtEnterCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnterCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterCode.Location = new System.Drawing.Point(246, 158);
            this.txtEnterCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PlaceholderText = "";
            this.txtEnterCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEnterCode.SelectedText = "";
            this.txtEnterCode.Size = new System.Drawing.Size(127, 27);
            this.txtEnterCode.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Animated = true;
            this.btnEnter.AutoRoundedCorners = true;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.Enabled = false;
            this.btnEnter.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(277, 206);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(129, 40);
            this.btnEnter.TabIndex = 48;
            this.btnEnter.Text = "ثبت اطلاعات";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(387, 94);
            this.lblNcNezam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(80, 13);
            this.lblNcNezam.TabIndex = 46;
            this.lblNcNezam.Text = "کد نظام پزشکی";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(388, 59);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 13);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(388, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(20, 13);
            this.lblFirstName.TabIndex = 44;
            this.lblFirstName.Text = "نام";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(387, 138);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 13);
            this.lblMobile.TabIndex = 43;
            this.lblMobile.Text = "شماره همراه";
            // 
            // panelTexBoxes
            // 
            this.panelTexBoxes.Controls.Add(this.txtFirstName);
            this.panelTexBoxes.Controls.Add(this.txtLastName);
            this.panelTexBoxes.Controls.Add(this.txtNezam);
            this.panelTexBoxes.Controls.Add(this.txtMobile);
            this.panelTexBoxes.Location = new System.Drawing.Point(243, 11);
            this.panelTexBoxes.Name = "panelTexBoxes";
            this.panelTexBoxes.Size = new System.Drawing.Size(132, 140);
            this.panelTexBoxes.TabIndex = 0;
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
            this.txtFirstName.Location = new System.Drawing.Point(3, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "";
            this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(127, 27);
            this.txtFirstName.TabIndex = 0;
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
            this.txtLastName.Location = new System.Drawing.Point(2, 41);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(127, 27);
            this.txtLastName.TabIndex = 1;
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
            this.txtNezam.Location = new System.Drawing.Point(3, 76);
            this.txtNezam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNezam.Name = "txtNezam";
            this.txtNezam.PlaceholderText = "";
            this.txtNezam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNezam.SelectedText = "";
            this.txtNezam.Size = new System.Drawing.Size(127, 27);
            this.txtNezam.TabIndex = 2;
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
            this.txtMobile.Location = new System.Drawing.Point(3, 111);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(127, 27);
            this.txtMobile.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(156, 181);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(86, 67);
            this.guna2Panel1.TabIndex = 54;
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.PictureBoxProfile.ImageRotate = 0F;
            this.PictureBoxProfile.Location = new System.Drawing.Point(11, 11);
            this.PictureBoxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PictureBoxProfile.Size = new System.Drawing.Size(180, 180);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 47;
            this.PictureBoxProfile.TabStop = false;
            this.PictureBoxProfile.Click += new System.EventHandler(this.PictureBoxProfile_Click);
            // 
            // frmDoctorSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 271);
            this.Controls.Add(this.TimeProgressBar);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtEnterCode);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.lblNcNezam);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.panelTexBoxes);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmDoctorSignIn";
            this.Text = "frmDoctorSignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoctorSignIn_FormClosed);
            this.Load += new System.EventHandler(this.frmDoctorSignIn_Load);
            this.TimeProgressBar.ResumeLayout(false);
            this.TimeProgressBar.PerformLayout();
            this.panelTexBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar TimeProgressBar;
        private System.Windows.Forms.Label lbltime;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressBar;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterCode;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PictureBoxProfile;
        private System.Windows.Forms.Label lblNcNezam;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Panel panelTexBoxes;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtNezam;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}