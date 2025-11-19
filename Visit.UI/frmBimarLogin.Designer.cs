namespace Visit.UI
{
    partial class frmBimarLogin
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
            this.ProgressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.lbltime = new System.Windows.Forms.Label();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TimeProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtEnterCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.TimeProgressBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(281, 178);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(62, 54);
            this.ProgressBar.TabIndex = 51;
            this.ProgressBar.Visible = false;
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
            // btnSend
            // 
            this.btnSend.Animated = true;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(5, 2);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.Size = new System.Drawing.Size(74, 72);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "ارسال پیامک";
            // 
            // TimeProgressBar
            // 
            this.TimeProgressBar.Controls.Add(this.lbltime);
            this.TimeProgressBar.FillColor = System.Drawing.Color.White;
            this.TimeProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimeProgressBar.ForeColor = System.Drawing.Color.White;
            this.TimeProgressBar.Location = new System.Drawing.Point(34, 106);
            this.TimeProgressBar.Minimum = 0;
            this.TimeProgressBar.Name = "TimeProgressBar";
            this.TimeProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TimeProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.TimeProgressBar.Size = new System.Drawing.Size(94, 94);
            this.TimeProgressBar.TabIndex = 52;
            this.TimeProgressBar.Text = "guna2CircleProgressBar1";
            this.TimeProgressBar.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnSend);
            this.guna2Panel1.Location = new System.Drawing.Point(34, 120);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(97, 80);
            this.guna2Panel1.TabIndex = 53;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(280, 140);
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
            this.txtEnterCode.Location = new System.Drawing.Point(134, 135);
            this.txtEnterCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PlaceholderText = "";
            this.txtEnterCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEnterCode.SelectedText = "";
            this.txtEnterCode.Size = new System.Drawing.Size(127, 27);
            this.txtEnterCode.TabIndex = 49;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Animated = true;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(279, 259);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(89, 31);
            this.btnSignUp.TabIndex = 48;
            this.btnSignUp.Text = "ثبت نام";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(278, 106);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 13);
            this.lblMobile.TabIndex = 47;
            this.lblMobile.Text = "شماره همراه";
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(280, 73);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(40, 13);
            this.lblNcNezam.TabIndex = 46;
            this.lblNcNezam.Text = "کد ملی";
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
            this.txtMobile.Location = new System.Drawing.Point(134, 100);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(127, 27);
            this.txtMobile.TabIndex = 44;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Animated = true;
            this.txtNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.DefaultText = "";
            this.txtNationalCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationalCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationalCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationalCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationalCode.Location = new System.Drawing.Point(134, 66);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.PlaceholderText = "";
            this.txtNationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNationalCode.SelectedText = "";
            this.txtNationalCode.Size = new System.Drawing.Size(127, 27);
            this.txtNationalCode.TabIndex = 43;
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
            this.btnEnter.Location = new System.Drawing.Point(140, 178);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(121, 43);
            this.btnEnter.TabIndex = 45;
            this.btnEnter.Text = "ورود";
            // 
            // frmBimarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 302);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.TimeProgressBar);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtEnterCode);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblNcNezam);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmBimarLogin";
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.frmBimarLogin_Load);
            this.TimeProgressBar.ResumeLayout(false);
            this.TimeProgressBar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProgressBar;
        private System.Windows.Forms.Label lbltime;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private Guna.UI2.WinForms.Guna2CircleProgressBar TimeProgressBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterCode;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblNcNezam;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalCode;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
    }
}