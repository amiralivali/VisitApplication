namespace Visit.UI
{
    partial class frmTakhasos
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
            this.brnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // brnSave
            // 
            this.brnSave.Animated = true;
            this.brnSave.AutoRoundedCorners = true;
            this.brnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.brnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.brnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.brnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.brnSave.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.brnSave.ForeColor = System.Drawing.Color.White;
            this.brnSave.Location = new System.Drawing.Point(81, 110);
            this.brnSave.Margin = new System.Windows.Forms.Padding(2);
            this.brnSave.Name = "brnSave";
            this.brnSave.Size = new System.Drawing.Size(119, 41);
            this.brnSave.TabIndex = 0;
            this.brnSave.Text = "ثبت";
            this.brnSave.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox.ItemHeight = 30;
            this.ComboBox.Location = new System.Drawing.Point(50, 28);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(182, 36);
            this.ComboBox.TabIndex = 1;
            // 
            // frmTakhasos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 180);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.brnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmTakhasos";
            this.Text = "تخصص";
            this.Load += new System.EventHandler(this.frmTakhasos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button brnSave;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox;
    }
}