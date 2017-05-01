namespace UiDesktop.ABMWindows
{
    partial class ABMPhone
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
            this.cbModelos = new MetroFramework.Controls.MetroComboBox();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblImei = new MetroFramework.Controls.MetroLabel();
            this.txtImei = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cbModelos
            // 
            this.cbModelos.FormattingEnabled = true;
            this.cbModelos.ItemHeight = 23;
            this.cbModelos.Location = new System.Drawing.Point(103, 54);
            this.cbModelos.Name = "cbModelos";
            this.cbModelos.Size = new System.Drawing.Size(188, 29);
            this.cbModelos.TabIndex = 2;
            this.cbModelos.UseSelectable = true;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(30, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(58, 19);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Modelo:";
            // 
            // lblImei
            // 
            this.lblImei.AutoSize = true;
            this.lblImei.Location = new System.Drawing.Point(51, 110);
            this.lblImei.Name = "lblImei";
            this.lblImei.Size = new System.Drawing.Size(37, 19);
            this.lblImei.TabIndex = 4;
            this.lblImei.Text = "IMEI:";
            // 
            // txtImei
            // 
            // 
            // 
            // 
            this.txtImei.CustomButton.Image = null;
            this.txtImei.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtImei.CustomButton.Name = "";
            this.txtImei.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtImei.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImei.CustomButton.TabIndex = 1;
            this.txtImei.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImei.CustomButton.UseSelectable = true;
            this.txtImei.CustomButton.Visible = false;
            this.txtImei.Lines = new string[0];
            this.txtImei.Location = new System.Drawing.Point(103, 110);
            this.txtImei.MaxLength = 32767;
            this.txtImei.Name = "txtImei";
            this.txtImei.PasswordChar = '\0';
            this.txtImei.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImei.SelectedText = "";
            this.txtImei.SelectionLength = 0;
            this.txtImei.SelectionStart = 0;
            this.txtImei.ShortcutsEnabled = true;
            this.txtImei.Size = new System.Drawing.Size(188, 23);
            this.txtImei.TabIndex = 5;
            this.txtImei.UseSelectable = true;
            this.txtImei.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImei.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(103, 167);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(278, 62);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ABMPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 327);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtImei);
            this.Controls.Add(this.lblImei);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.cbModelos);
            this.Name = "ABMPhone";
            this.Controls.SetChildIndex(this.cbModelos, 0);
            this.Controls.SetChildIndex(this.lblModel, 0);
            this.Controls.SetChildIndex(this.lblImei, 0);
            this.Controls.SetChildIndex(this.txtImei, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbModelos;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroLabel lblImei;
        private MetroFramework.Controls.MetroTextBox txtImei;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
    }
}