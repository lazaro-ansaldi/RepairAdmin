using Entities.Entidades;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace UiDesktop.ABMWindows
{
    public partial class GenericABMWindows : MetroForm
    {
        protected Entity _currentEntity;

        public GenericABMWindows()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        protected virtual void SaveChanges()
        {

        }
        protected void ShowInfo(string message, string title)
        {
            MetroMessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowError(string message, string title)
        {
            MetroMessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
