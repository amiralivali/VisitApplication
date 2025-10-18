namespace Visit.UI
{
    partial class frmSendSms
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
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnRetry = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtEnterCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(244, 95);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(96, 17);
            this.lblMobile.TabIndex = 36;
            this.lblMobile.Text = "00000000000";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(355, 95);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(80, 17);
            this.lblText.TabIndex = 35;
            this.lblText.Text = "کد ارسال شد به";
            // 
            // btnRetry
            // 
            this.btnRetry.Animated = true;
            this.btnRetry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRetry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRetry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRetry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRetry.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.Location = new System.Drawing.Point(71, 116);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRetry.Size = new System.Drawing.Size(85, 80);
            this.btnRetry.TabIndex = 34;
            this.btnRetry.Text = "ارسال مجدد";
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Animated = true;
            this.btnEnter.AutoRoundedCorners = true;
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(184, 207);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(145, 53);
            this.btnEnter.TabIndex = 33;
            this.btnEnter.Text = "ورود";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.Red;
            this.lbltime.Location = new System.Drawing.Point(168, 84);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(28, 16);
            this.lbltime.TabIndex = 32;
            this.lbltime.Text = "120";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(368, 139);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 16);
            this.lblCode.TabIndex = 31;
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
            this.txtEnterCode.Location = new System.Drawing.Point(172, 133);
            this.txtEnterCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnterCode.Name = "txtEnterCode";
            this.txtEnterCode.PlaceholderText = "";
            this.txtEnterCode.SelectedText = "";
            this.txtEnterCode.Size = new System.Drawing.Size(169, 33);
            this.txtEnterCode.TabIndex = 30;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSendSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 351);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtEnterCode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSendSms";
            this.Text = "frmSendSms";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSendSms_FormClosed);
            this.Load += new System.EventHandler(this.frmSendSms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2CircleButton btnRetry;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterCode;
        private System.Windows.Forms.Timer timer1;
    }
}