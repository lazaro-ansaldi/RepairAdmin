namespace UiDesktop
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtClientes = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.mtModelos = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtClientes
            // 
            this.mtClientes.ActiveControl = null;
            this.mtClientes.Location = new System.Drawing.Point(22, 21);
            this.mtClientes.Name = "mtClientes";
            this.mtClientes.Size = new System.Drawing.Size(177, 95);
            this.mtClientes.TabIndex = 0;
            this.mtClientes.Text = "Administrar Clientes";
            this.mtClientes.UseSelectable = true;
            this.mtClientes.Click += new System.EventHandler(this.mtClientes_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(22, 122);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(360, 79);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Registrar nueva reparacion";
            this.metroTile2.UseSelectable = true;
            // 
            // mtModelos
            // 
            this.mtModelos.ActiveControl = null;
            this.mtModelos.Location = new System.Drawing.Point(205, 21);
            this.mtModelos.Name = "mtModelos";
            this.mtModelos.Size = new System.Drawing.Size(177, 95);
            this.mtModelos.TabIndex = 2;
            this.mtModelos.Text = "Administrar Modelos";
            this.mtModelos.UseSelectable = true;
            this.mtModelos.Click += new System.EventHandler(this.mtModelos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtModelos);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtClientes);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(675, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtClientes;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile mtModelos;
    }
}
