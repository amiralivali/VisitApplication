namespace Visit.UI
{
    partial class frmLogin
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
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.txtNcNezam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtEnterCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.btnEnter.Location = new System.Drawing.Point(178, 228);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(161, 53);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "ورود";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtNcNezam
            // 
            this.txtNcNezam.Animated = true;
            this.txtNcNezam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNcNezam.DefaultText = "";
            this.txtNcNezam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNcNezam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNcNezam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNcNezam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNcNezam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNcNezam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNcNezam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNcNezam.Location = new System.Drawing.Point(170, 90);
            this.txtNcNezam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNcNezam.Name = "txtNcNezam";
            this.txtNcNezam.PlaceholderText = "";
            this.txtNcNezam.SelectedText = "";
            this.txtNcNezam.Size = new System.Drawing.Size(169, 33);
            this.txtNcNezam.TabIndex = 0;
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
            this.txtMobile.Location = new System.Drawing.Point(170, 132);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(169, 33);
            this.txtMobile.TabIndex = 1;
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(366, 90);
            this.lblNcNezam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(10, 16);
            this.lblNcNezam.TabIndex = 5;
            this.lblNcNezam.Text = ".";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(363, 139);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(71, 16);
            this.lblMobile.TabIndex = 6;
            this.lblMobile.Text = "شماره همراه";
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
            this.btnSignUp.Location = new System.Drawing.Point(372, 319);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(119, 38);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "ثبت نام";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(366, 181);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 16);
            this.lblCode.TabIndex = 33;
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
            this.txtEnterCode.Location = new System.Drawing.Point(170, 175);
            this.txtEnterCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PlaceholderText = "";
            this.txtEnterCode.SelectedText = "";
            this.txtEnterCode.Size = new System.Drawing.Size(169, 33);
            this.txtEnterCode.TabIndex = 32;
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
            this.btnSend.Location = new System.Drawing.Point(69, 154);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.Size = new System.Drawing.Size(85, 80);
            this.btnSend.TabIndex = 35;
            this.btnSend.Text = "ارسال پیامک";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.Red;
            this.lbltime.Location = new System.Drawing.Point(98, 132);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(28, 16);
            this.lbltime.TabIndex = 36;
            this.lbltime.Text = "120";
            this.lbltime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtEnterCode);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblNcNezam);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNcNezam);
            this.Controls.Add(this.btnEnter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویزیت 24";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmBimar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Guna.UI2.WinForms.Guna2TextBox txtNcNezam;
        private Guna.UI2.WinForms.Guna2TextBox txtMobile;
        private System.Windows.Forms.Label lblNcNezam;
        private System.Windows.Forms.Label lblMobile;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterCode;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
    }
}