namespace Visit.UI
{
    partial class frmBimars
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
            this.btnHistoryes = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckProfile = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnHistoryes
            // 
            this.btnHistoryes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistoryes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistoryes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistoryes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistoryes.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHistoryes.ForeColor = System.Drawing.Color.White;
            this.btnHistoryes.Location = new System.Drawing.Point(634, 83);
            this.btnHistoryes.Name = "btnHistoryes";
            this.btnHistoryes.Size = new System.Drawing.Size(154, 55);
            this.btnHistoryes.TabIndex = 0;
            this.btnHistoryes.Text = "تاریخچه ویزیت ها ";
            // 
            // btnCheckProfile
            // 
            this.btnCheckProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckProfile.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCheckProfile.ForeColor = System.Drawing.Color.White;
            this.btnCheckProfile.Location = new System.Drawing.Point(634, 22);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(154, 55);
            this.btnCheckProfile.TabIndex = 1;
            this.btnCheckProfile.Text = "مشاهده پروفایل";
            this.btnCheckProfile.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmBimars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.btnHistoryes);
            this.Name = "frmBimars";
            this.Text = "frmBimars";
            this.Load += new System.EventHandler(this.frmBimars_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHistoryes;
        private Guna.UI2.WinForms.Guna2Button btnCheckProfile;
    }
}