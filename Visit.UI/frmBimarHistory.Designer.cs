namespace Visit.UI
{
    partial class frmBimarHistory
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvHistorys = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorys.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.AutoRoundedCorners = true;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(43, 30);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(121, 38);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "تازه سازی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(495, 40);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(62, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = ": جست و جو";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(318, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(175, 28);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvHistorys
            // 
            this.dgvHistorys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.dgvHistorys.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvHistorys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistorys.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvHistorys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvHistorys.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvHistorys.Location = new System.Drawing.Point(0, 114);
            // 
            // 
            // 
            this.dgvHistorys.MasterTemplate.AllowAddNewRow = false;
            this.dgvHistorys.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "FullNameBimar";
            gridViewTextBoxColumn1.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewTextBoxColumn1.HeaderText = "نام بیمار";
            gridViewTextBoxColumn1.Name = "FullNameBimar";
            gridViewTextBoxColumn1.Width = 122;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "FullNameDoctor";
            gridViewTextBoxColumn2.HeaderText = "نام دکتر";
            gridViewTextBoxColumn2.Name = "FullNameDoctor";
            gridViewTextBoxColumn2.Width = 124;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DateTime";
            gridViewDateTimeColumn1.FilteringMode = ((Telerik.WinControls.UI.GridViewTimeFilteringMode)((Telerik.WinControls.UI.GridViewTimeFilteringMode.Time | Telerik.WinControls.UI.GridViewTimeFilteringMode.Date)));
            gridViewDateTimeColumn1.FormatInfo = new System.Globalization.CultureInfo("fa-IR");
            gridViewDateTimeColumn1.HeaderText = "تاریخ و ساعت";
            gridViewDateTimeColumn1.Name = "DateTime";
            gridViewDateTimeColumn1.ReadOnly = true;
            gridViewDateTimeColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDateTimeColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewDateTimeColumn1.Width = 191;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "صفحه چت";
            gridViewCommandColumn1.Name = "Chat";
            gridViewCommandColumn1.Width = 112;
            this.dgvHistorys.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewCommandColumn1});
            this.dgvHistorys.MasterTemplate.EnableGrouping = false;
            this.dgvHistorys.MasterTemplate.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "DateTime";
            this.dgvHistorys.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.dgvHistorys.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.dgvHistorys.Name = "dgvHistorys";
            this.dgvHistorys.ReadOnly = true;
            this.dgvHistorys.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dgvHistorys.RootElement.AutoSize = true;
            this.dgvHistorys.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.dgvHistorys.RootElement.ClipDrawing = false;
            this.dgvHistorys.RootElement.EnableRippleAnimation = false;
            this.dgvHistorys.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds;
            this.dgvHistorys.Size = new System.Drawing.Size(567, 230);
            this.dgvHistorys.TabIndex = 8;
            // 
            // frmBimarHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.dgvHistorys);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.MaximizeBox = false;
            this.Name = "frmBimarHistory";
            this.Text = "ویزیت 24";
            this.Load += new System.EventHandler(this.frmBimarHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorys.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Telerik.WinControls.UI.RadGridView dgvHistorys;
    }
}