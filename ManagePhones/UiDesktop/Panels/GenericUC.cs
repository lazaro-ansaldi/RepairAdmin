using MetroFramework;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace UiDesktop.Panels
{
    public abstract partial class GenericUC : MetroUserControl
    {
        protected string _title;

        public GenericUC()
        {
            InitializeComponent();
        }

        public abstract void LoadData();

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
