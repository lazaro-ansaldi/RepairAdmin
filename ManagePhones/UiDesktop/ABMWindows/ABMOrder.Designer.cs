namespace UiDesktop.ABMWindows
{
    partial class ABMOrder
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
            this.chckSd = new MetroFramework.Controls.MetroCheckBox();
            this.chckSim = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbClientes = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dateIngreso = new MetroFramework.Controls.MetroDateTime();
            this.rbOtra = new MetroFramework.Controls.MetroRadioButton();
            this.rbHoy = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDateEgreso = new MetroFramework.Controls.MetroTextBox();
            this.cbPhones = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnNuevoCliente = new MetroFramework.Controls.MetroButton();
            this.btnNuevoPhone = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // chckSd
            // 
            this.chckSd.AutoSize = true;
            this.chckSd.Location = new System.Drawing.Point(138, 236);
            this.chckSd.Name = "chckSd";
            this.chckSd.Size = new System.Drawing.Size(76, 15);
            this.chckSd.TabIndex = 3;
            this.chckSd.Text = "Tarjeta SD";
            this.chckSd.UseSelectable = true;
            // 
            // chckSim
            // 
            this.chckSim.AutoSize = true;
            this.chckSim.Location = new System.Drawing.Point(238, 236);
            this.chckSim.Name = "chckSim";
            this.chckSim.Size = new System.Drawing.Size(82, 15);
            this.chckSim.TabIndex = 4;
            this.chckSim.Text = "Tarjeta Sim";
            this.chckSim.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(73, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.ItemHeight = 23;
            this.cbClientes.Location = new System.Drawing.Point(139, 21);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(249, 29);
            this.cbClientes.TabIndex = 6;
            this.cbClientes.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Fecha de Ingreso";
            // 
            // dateIngreso
            // 
            this.dateIngreso.Location = new System.Drawing.Point(138, 131);
            this.dateIngreso.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(200, 29);
            this.dateIngreso.TabIndex = 8;
            // 
            // rbOtra
            // 
            this.rbOtra.AutoSize = true;
            this.rbOtra.Location = new System.Drawing.Point(343, 129);
            this.rbOtra.Name = "rbOtra";
            this.rbOtra.Size = new System.Drawing.Size(46, 15);
            this.rbOtra.TabIndex = 9;
            this.rbOtra.Text = "Otra";
            this.rbOtra.UseSelectable = true;
            this.rbOtra.CheckedChanged += new System.EventHandler(this.rbOtra_CheckedChanged);
            // 
            // rbHoy
            // 
            this.rbHoy.AutoSize = true;
            this.rbHoy.Checked = true;
            this.rbHoy.Location = new System.Drawing.Point(343, 152);
            this.rbHoy.Name = "rbHoy";
            this.rbHoy.Size = new System.Drawing.Size(45, 15);
            this.rbHoy.TabIndex = 10;
            this.rbHoy.TabStop = true;
            this.rbHoy.Text = "Hoy";
            this.rbHoy.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Fecha de Egreso:";
            // 
            // txtDateEgreso
            // 
            // 
            // 
            // 
            this.txtDateEgreso.CustomButton.Image = null;
            this.txtDateEgreso.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtDateEgreso.CustomButton.Name = "";
            this.txtDateEgreso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDateEgreso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDateEgreso.CustomButton.TabIndex = 1;
            this.txtDateEgreso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDateEgreso.CustomButton.UseSelectable = true;
            this.txtDateEgreso.CustomButton.Visible = false;
            this.txtDateEgreso.Lines = new string[0];
            this.txtDateEgreso.Location = new System.Drawing.Point(139, 189);
            this.txtDateEgreso.MaxLength = 32767;
            this.txtDateEgreso.Name = "txtDateEgreso";
            this.txtDateEgreso.PasswordChar = '\0';
            this.txtDateEgreso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDateEgreso.SelectedText = "";
            this.txtDateEgreso.SelectionLength = 0;
            this.txtDateEgreso.SelectionStart = 0;
            this.txtDateEgreso.ShortcutsEnabled = true;
            this.txtDateEgreso.Size = new System.Drawing.Size(200, 23);
            this.txtDateEgreso.TabIndex = 12;
            this.txtDateEgreso.UseSelectable = true;
            this.txtDateEgreso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDateEgreso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPhones
            // 
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.ItemHeight = 23;
            this.cbPhones.Location = new System.Drawing.Point(138, 73);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(250, 29);
            this.cbPhones.TabIndex = 13;
            this.cbPhones.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(51, 83);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "Dispositivo:";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(398, 21);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCliente.TabIndex = 15;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseSelectable = true;
            // 
            // btnNuevoPhone
            // 
            this.btnNuevoPhone.Location = new System.Drawing.Point(398, 73);
            this.btnNuevoPhone.Name = "btnNuevoPhone";
            this.btnNuevoPhone.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPhone.TabIndex = 16;
            this.btnNuevoPhone.Text = "Nuevo";
            this.btnNuevoPhone.UseSelectable = true;
            // 
            // ABMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 327);
            this.Controls.Add(this.btnNuevoPhone);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.txtDateEgreso);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.rbHoy);
            this.Controls.Add(this.rbOtra);
            this.Controls.Add(this.dateIngreso);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chckSim);
            this.Controls.Add(this.chckSd);
            this.Name = "ABMOrder";
            this.Controls.SetChildIndex(this.chckSd, 0);
            this.Controls.SetChildIndex(this.chckSim, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.cbClientes, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.dateIngreso, 0);
            this.Controls.SetChildIndex(this.rbOtra, 0);
            this.Controls.SetChildIndex(this.rbHoy, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.txtDateEgreso, 0);
            this.Controls.SetChildIndex(this.cbPhones, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.btnNuevoCliente, 0);
            this.Controls.SetChildIndex(this.btnNuevoPhone, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chckSd;
        private MetroFramework.Controls.MetroCheckBox chckSim;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbClientes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dateIngreso;
        private MetroFramework.Controls.MetroRadioButton rbOtra;
        private MetroFramework.Controls.MetroRadioButton rbHoy;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDateEgreso;
        private MetroFramework.Controls.MetroComboBox cbPhones;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnNuevoCliente;
        private MetroFramework.Controls.MetroButton btnNuevoPhone;
    }
}