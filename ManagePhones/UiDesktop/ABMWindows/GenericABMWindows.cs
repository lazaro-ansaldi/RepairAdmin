using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiDesktop.ABMWindows
{
    public partial class GenericABMWindows : UserControl
    {
        public GenericABMWindows()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        protected virtual void SaveChanges()
        {

        }
    }
}
