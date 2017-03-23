using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using UiDesktop.Panels;

namespace UiDesktop
{
    public partial class Dashboard : MetroUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void mtModelos_Click(object sender, EventArgs e)
        {
            ManageModels manageModels = new ManageModels();
            if (!Main.Instancia.Panel.Controls.ContainsKey("ManageModels"))
            {
                manageModels.Dock = DockStyle.Fill;
                Main.Instancia.Panel.Controls.Add(manageModels);               
            }
            manageModels.LoadData();
            Main.Instancia.Panel.Controls["ManageModels"].BringToFront();
            Main.Instancia.LinkBack.Visible = true;
        }
    }
}
