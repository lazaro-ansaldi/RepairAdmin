using ManagePhones.Entities.Entidades;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiDesktop.Generic.ABMWindows
{
    public partial class GenericABMWindows : MetroForm
    {
        protected Entity _currentEntity;
        // Esta property es para saber desde que window se llamó al abm //
        public ManagePhones.Util.Enums.CallerType Caller { get; set; }

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

        protected virtual Task SaveChanges()
        {
            throw new NotImplementedException();
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
