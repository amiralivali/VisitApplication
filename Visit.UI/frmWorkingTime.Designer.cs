namespace Visit.UI
{
    partial class frmWorkingTime
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
            this.timePickerStart = new Telerik.WinControls.UI.RadTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.timePickerEnd = new Telerik.WinControls.UI.RadTimePicker();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // timePickerStart
            // 
            this.timePickerStart.BackColor = System.Drawing.Color.White;
            this.timePickerStart.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.timePickerStart.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.timePickerStart.ForeColor = System.Drawing.Color.Black;
            this.timePickerStart.Location = new System.Drawing.Point(17, 20);
            this.timePickerStart.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.timePickerStart.MinValue = new System.DateTime(((long)(0)));
            this.timePickerStart.Name = "timePickerStart";
            // 
            // 
            // 
            this.timePickerStart.RootElement.CustomFontSize = 16F;
            this.timePickerStart.Size = new System.Drawing.Size(180, 33);
            this.timePickerStart.TabIndex = 0;
            this.timePickerStart.TabStop = false;
            this.timePickerStart.ThemeName = "Fluent";
            this.timePickerStart.Value = new System.DateTime(2025, 11, 7, 12, 56, 21, 817);
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerStart.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerStart.GetChildAt(0))).CustomFontSize = 17F;
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerStart.GetChildAt(0))).CustomFontStyle = System.Drawing.FontStyle.Bold;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(214, 28);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 18);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = ": ساعت شروع کار";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(218, 73);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(94, 18);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = ": ساعت پایان کار";
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.BackColor = System.Drawing.Color.White;
            this.timePickerEnd.Culture = new System.Globalization.CultureInfo("fa-IR");
            this.timePickerEnd.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold);
            this.timePickerEnd.ForeColor = System.Drawing.Color.Black;
            this.timePickerEnd.Location = new System.Drawing.Point(17, 63);
            this.timePickerEnd.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.timePickerEnd.MinValue = new System.DateTime(((long)(0)));
            this.timePickerEnd.Name = "timePickerEnd";
            // 
            // 
            // 
            this.timePickerEnd.RootElement.CustomFontSize = 16F;
            this.timePickerEnd.Size = new System.Drawing.Size(180, 33);
            this.timePickerEnd.TabIndex = 1;
            this.timePickerEnd.TabStop = false;
            this.timePickerEnd.ThemeName = "Fluent";
            this.timePickerEnd.Value = new System.DateTime(2025, 11, 7, 12, 56, 21, 817);
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerEnd.GetChildAt(0))).FocusBorderColor = System.Drawing.Color.White;
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerEnd.GetChildAt(0))).CustomFontSize = 17F;
            ((Telerik.WinControls.UI.RadTimePickerElement)(this.timePickerEnd.GetChildAt(0))).CustomFontStyle = System.Drawing.FontStyle.Bold;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(98, 124);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "ثبت";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWorkingTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 181);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.timePickerStart);
            this.Name = "frmWorkingTime";
            this.Text = "ساعت کاری";
            ((System.ComponentModel.ISupportInitialize)(this.timePickerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePickerEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTimePicker timePickerStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private Telerik.WinControls.UI.RadTimePicker timePickerEnd;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}