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
            this.btnCheckProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistoryes = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.flpDoctors = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnOpenChat.Location = new System.Drawing.Point(659, 331);
            this.btnOpenChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(207, 70);
            this.btnOpenChat.TabIndex = 4;
            this.btnOpenChat.Text = "مشاهده چت";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(408, 38);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(291, 41);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = ".";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnCheckProfile.Location = new System.Drawing.Point(658, 181);
            this.btnCheckProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(207, 70);
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
            this.btnHistoryes.Location = new System.Drawing.Point(659, 256);
            this.btnHistoryes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistoryes.Name = "btnHistoryes";
            this.btnHistoryes.Size = new System.Drawing.Size(207, 70);
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
            this.btnDeleteAccount.Location = new System.Drawing.Point(659, 406);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(207, 70);
            this.btnDeleteAccount.TabIndex = 5;
            this.btnDeleteAccount.Text = "حذف حساب کاربری";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // flpDoctors
            // 
            this.flpDoctors.AutoScroll = true;
            this.flpDoctors.Location = new System.Drawing.Point(2, 155);
            this.flpDoctors.Name = "flpDoctors";
            this.flpDoctors.Size = new System.Drawing.Size(650, 342);
            this.flpDoctors.TabIndex = 6;
            this.flpDoctors.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(13, 106);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(248, 41);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.Location = new System.Drawing.Point(257, 115);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 27);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = ": جست و جو  ";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.ErrorImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.InitialImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Location = new System.Drawing.Point(707, 13);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(157, 143);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // cbFilter
            // 
            this.cbFilter.AutoRoundedCorners = true;
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "دکتر های آنلاین",
            "دکتر های آفلاین"});
            this.cbFilter.Location = new System.Drawing.Point(348, 111);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(188, 36);
            this.cbFilter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(542, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = ": فیلتر بر اساس  ";
            // 
            // frmBimars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flpDoctors);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnOpenChat);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.btnHistoryes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmBimars";
            this.Text = "ویزیت 24";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBimars_FormClosing);
            this.Load += new System.EventHandler(this.frmBimars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHistoryes;
        private Guna.UI2.WinForms.Guna2Button btnCheckProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2Button btnOpenChat;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private System.Windows.Forms.FlowLayoutPanel flpDoctors;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
    }
}