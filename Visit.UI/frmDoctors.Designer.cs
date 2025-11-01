namespace Visit.UI
{
    partial class frmDoctors
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
            this.btnCheckProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistoryes = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCheckProfile
            // 
            this.btnCheckProfile.Animated = true;
            this.btnCheckProfile.AutoRoundedCorners = true;
            this.btnCheckProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckProfile.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckProfile.ForeColor = System.Drawing.Color.White;
            this.btnCheckProfile.Location = new System.Drawing.Point(579, 14);
            this.btnCheckProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(207, 70);
            this.btnCheckProfile.TabIndex = 3;
            this.btnCheckProfile.Text = "تغییر پروفایل";
            this.btnCheckProfile.Click += new System.EventHandler(this.btnCheckProfile_Click);
            // 
            // btnHistoryes
            // 
            this.btnHistoryes.Animated = true;
            this.btnHistoryes.AnimatedGIF = true;
            this.btnHistoryes.AutoRoundedCorners = true;
            this.btnHistoryes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistoryes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistoryes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistoryes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistoryes.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnHistoryes.ForeColor = System.Drawing.Color.White;
            this.btnHistoryes.Location = new System.Drawing.Point(579, 89);
            this.btnHistoryes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistoryes.Name = "btnHistoryes";
            this.btnHistoryes.Size = new System.Drawing.Size(207, 70);
            this.btnHistoryes.TabIndex = 2;
            this.btnHistoryes.Text = "تاریخچه ویزیت ها ";
            this.btnHistoryes.Click += new System.EventHandler(this.btnHistoryes_Click);
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.btnHistoryes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDoctors";
            this.Text = "ویزیت 24";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoctors_FormClosed);
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCheckProfile;
        private Guna.UI2.WinForms.Guna2Button btnHistoryes;
    }
}