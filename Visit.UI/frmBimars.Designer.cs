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
            this.btnOpenChat = new Guna.UI2.WinForms.Guna2Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCheckProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistoryes = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.Animated = true;
            this.btnOpenChat.AnimatedGIF = true;
            this.btnOpenChat.AutoRoundedCorners = true;
            this.btnOpenChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenChat.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnOpenChat.ForeColor = System.Drawing.Color.White;
            this.btnOpenChat.Location = new System.Drawing.Point(474, 270);
            this.btnOpenChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(155, 57);
            this.btnOpenChat.TabIndex = 4;
            this.btnOpenChat.Text = "مشاهده چت";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(287, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(218, 33);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = ".";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.ErrorImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.InitialImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Location = new System.Drawing.Point(511, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(118, 116);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
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
            this.btnCheckProfile.Location = new System.Drawing.Point(473, 148);
            this.btnCheckProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(155, 57);
            this.btnCheckProfile.TabIndex = 1;
            this.btnCheckProfile.Text = "تغییر پروفایل";
            this.btnCheckProfile.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.btnHistoryes.Location = new System.Drawing.Point(474, 209);
            this.btnHistoryes.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistoryes.Name = "btnHistoryes";
            this.btnHistoryes.Size = new System.Drawing.Size(155, 57);
            this.btnHistoryes.TabIndex = 0;
            this.btnHistoryes.Text = "تاریخچه ویزیت ها ";
            this.btnHistoryes.Click += new System.EventHandler(this.btnHistoryes_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Animated = true;
            this.btnDeleteAccount.AnimatedGIF = true;
            this.btnDeleteAccount.AutoRoundedCorners = true;
            this.btnDeleteAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAccount.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(474, 331);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(155, 57);
            this.btnDeleteAccount.TabIndex = 5;
            this.btnDeleteAccount.Text = "حذف حساب کاربری";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // frmBimars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 404);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnOpenChat);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.btnHistoryes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmBimars";
            this.Text = "ویزیت 24";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBimars_FormClosing);
            this.Load += new System.EventHandler(this.frmBimars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHistoryes;
        private Guna.UI2.WinForms.Guna2Button btnCheckProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2Button btnOpenChat;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
    }
}