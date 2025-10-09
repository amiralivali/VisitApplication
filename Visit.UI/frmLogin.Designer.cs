﻿namespace Visit.UI
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
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.txtNcNezam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNcNezam = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
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
            this.btnEnter.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(119, 169);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(121, 50);
            this.btnEnter.TabIndex = 0;
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
            this.txtNcNezam.Location = new System.Drawing.Point(119, 73);
            this.txtNcNezam.Name = "txtNcNezam";
            this.txtNcNezam.PlaceholderText = "";
            this.txtNcNezam.SelectedText = "";
            this.txtNcNezam.Size = new System.Drawing.Size(127, 27);
            this.txtNcNezam.TabIndex = 1;
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
            this.txtMobile.Location = new System.Drawing.Point(119, 113);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PlaceholderText = "";
            this.txtMobile.SelectedText = "";
            this.txtMobile.Size = new System.Drawing.Size(127, 27);
            this.txtMobile.TabIndex = 2;
            // 
            // lblNcNezam
            // 
            this.lblNcNezam.AutoSize = true;
            this.lblNcNezam.Location = new System.Drawing.Point(274, 79);
            this.lblNcNezam.Name = "lblNcNezam";
            this.lblNcNezam.Size = new System.Drawing.Size(10, 13);
            this.lblNcNezam.TabIndex = 5;
            this.lblNcNezam.Text = ".";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(264, 119);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(65, 13);
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
            this.btnSignUp.Location = new System.Drawing.Point(279, 259);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(89, 31);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "ثبت نام";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 302);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblNcNezam);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtNcNezam);
            this.Controls.Add(this.btnEnter);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویزیت 24";
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
    }
}