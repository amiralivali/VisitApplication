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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTimeSpanColumn gridViewTimeSpanColumn1 = new Telerik.WinControls.UI.GridViewTimeSpanColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnCheckProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistoryes = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenChat = new Guna.UI2.WinForms.Guna2Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblTakhasos = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dgvHistory = new Telerik.WinControls.UI.RadGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory.MasterTemplate)).BeginInit();
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
            this.btnCheckProfile.Location = new System.Drawing.Point(453, 132);
            this.btnCheckProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckProfile.Name = "btnCheckProfile";
            this.btnCheckProfile.Size = new System.Drawing.Size(155, 57);
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
            this.btnHistoryes.Location = new System.Drawing.Point(453, 193);
            this.btnHistoryes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHistoryes.Name = "btnHistoryes";
            this.btnHistoryes.Size = new System.Drawing.Size(155, 57);
            this.btnHistoryes.TabIndex = 2;
            this.btnHistoryes.Text = "تاریخچه ویزیت ها ";
            this.btnHistoryes.Click += new System.EventHandler(this.btnHistoryes_Click);
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
            this.btnOpenChat.Location = new System.Drawing.Point(454, 254);
            this.btnOpenChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(155, 57);
            this.btnOpenChat.TabIndex = 5;
            this.btnOpenChat.Text = "مشاهده چت";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(134, 22);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(350, 33);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = ".";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTakhasos
            // 
            this.lblTakhasos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTakhasos.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblTakhasos.Location = new System.Drawing.Point(118, 54);
            this.lblTakhasos.Name = "lblTakhasos";
            this.lblTakhasos.Size = new System.Drawing.Size(366, 33);
            this.lblTakhasos.TabIndex = 8;
            this.lblTakhasos.Text = ".";
            this.lblTakhasos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(134, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(350, 33);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = ".";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnDeleteAccount.Location = new System.Drawing.Point(453, 315);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(155, 57);
            this.btnDeleteAccount.TabIndex = 10;
            this.btnDeleteAccount.Text = "حذف حساب کاربری";
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.ErrorImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Image = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.InitialImage = global::Visit.UI.Properties.Resources.Profile;
            this.pictureBoxProfile.Location = new System.Drawing.Point(490, 11);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(118, 116);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.BackColor = System.Drawing.SystemColors.Control;
            this.dgvHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvHistory.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvHistory.Location = new System.Drawing.Point(-1, 133);
            // 
            // 
            // 
            this.dgvHistory.MasterTemplate.AllowAddNewRow = false;
            this.dgvHistory.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "FullNameBimar";
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewTextBoxColumn1.HeaderText = "نام بیمار";
            gridViewTextBoxColumn1.Name = "FullNameBimar";
            gridViewTextBoxColumn1.Width = 177;
            gridViewTimeSpanColumn1.EnableExpressionEditor = false;
            gridViewTimeSpanColumn1.FieldName = "Time";
            gridViewTimeSpanColumn1.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewTimeSpanColumn1.FormatString = "hh:mm:ss";
            gridViewTimeSpanColumn1.HeaderText = "ساعت";
            gridViewTimeSpanColumn1.Name = "Time";
            gridViewTimeSpanColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTimeSpanColumn1.Width = 134;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "صفحه چت";
            gridViewCommandColumn1.Name = "Chat";
            gridViewCommandColumn1.Width = 81;
            this.dgvHistory.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTimeSpanColumn1,
            gridViewCommandColumn1});
            this.dgvHistory.MasterTemplate.EnableGrouping = false;
            this.dgvHistory.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
            sortDescriptor1.PropertyName = "Time";
            this.dgvHistory.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgvHistory.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dgvHistory.RootElement.AutoSize = true;
            this.dgvHistory.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dgvHistory.RootElement.BorderHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dgvHistory.RootElement.ClipDrawing = false;
            this.dgvHistory.RootElement.EnableRippleAnimation = false;
            this.dgvHistory.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            this.dgvHistory.Size = new System.Drawing.Size(449, 249);
            this.dgvHistory.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(11, 99);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(175, 28);
            this.txtSearch.TabIndex = 13;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSearch.Location = new System.Drawing.Point(53, 64);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 23);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = " جست و جو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(83, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // frmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 382);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTakhasos);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.btnOpenChat);
            this.Controls.Add(this.btnCheckProfile);
            this.Controls.Add(this.btnHistoryes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmDoctors";
            this.Text = "ویزیت 24";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDoctors_FormClosed);
            this.Load += new System.EventHandler(this.frmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCheckProfile;
        private Guna.UI2.WinForms.Guna2Button btnHistoryes;
        private Guna.UI2.WinForms.Guna2Button btnOpenChat;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblTakhasos;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAccount;
        private Telerik.WinControls.UI.RadGridView dgvHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
    }
}