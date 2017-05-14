namespace UiDesktop.Panels
{
    partial class GenericUC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkDelete = new MetroFramework.Controls.MetroLink();
            this.linkEdit = new MetroFramework.Controls.MetroLink();
            this.linkNew = new MetroFramework.Controls.MetroLink();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.linkDelete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkNew, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(101, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // linkDelete
            // 
            this.linkDelete.BackColor = System.Drawing.Color.Transparent;
            this.linkDelete.Location = new System.Drawing.Point(249, 3);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(116, 28);
            this.linkDelete.TabIndex = 2;
            this.linkDelete.Text = "Eliminar";
            this.linkDelete.UseCustomBackColor = true;
            this.linkDelete.UseSelectable = true;
            this.linkDelete.UseStyleColors = true;
            // 
            // linkEdit
            // 
            this.linkEdit.BackColor = System.Drawing.Color.Transparent;
            this.linkEdit.Location = new System.Drawing.Point(126, 3);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(116, 28);
            this.linkEdit.TabIndex = 1;
            this.linkEdit.Text = "Editar";
            this.linkEdit.UseCustomBackColor = true;
            this.linkEdit.UseSelectable = true;
            this.linkEdit.UseStyleColors = true;
            this.linkEdit.Click += new System.EventHandler(this.linkEdit_Click);
            // 
            // linkNew
            // 
            this.linkNew.BackColor = System.Drawing.Color.Transparent;
            this.linkNew.Location = new System.Drawing.Point(3, 3);
            this.linkNew.Name = "linkNew";
            this.linkNew.Size = new System.Drawing.Size(116, 28);
            this.linkNew.TabIndex = 0;
            this.linkNew.Text = "Nuevo";
            this.linkNew.UseCustomBackColor = true;
            this.linkNew.UseSelectable = true;
            this.linkNew.UseStyleColors = true;
            this.linkNew.Click += new System.EventHandler(this.linkNew_Click);
            // 
            // GenericUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GenericUC";
            this.Size = new System.Drawing.Size(675, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected MetroFramework.Controls.MetroLink linkNew;
        protected MetroFramework.Controls.MetroLink linkDelete;
        protected MetroFramework.Controls.MetroLink linkEdit;
    }
}
