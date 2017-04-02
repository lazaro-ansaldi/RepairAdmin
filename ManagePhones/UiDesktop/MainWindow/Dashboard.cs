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
            if (!Main.Instancia.Panel.Controls.ContainsKey(ManageModels.Instancia.Key))
            {
                ManageModels.Instancia.Dock = DockStyle.Fill;
                Main.Instancia.Panel.Controls.Add(ManageModels.Instancia);               
            }
            ManageModels.Instancia.LoadData();
            Main.Instancia.Panel.Controls[ManageModels.Instancia.Key].BringToFront();
            Main.Instancia.LinkBack.Visible = true;
        }
    }
}
