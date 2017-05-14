using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using UiDesktop.Panels;
using UiDesktop.ABMWindows;

namespace UiDesktop
{
    public partial class Dashboard : MetroUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region Dashboard
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

        private void mtClientes_Click(object sender, EventArgs e)
        {
            if (!Main.Instancia.Panel.Controls.ContainsKey(ManageClients.Instancia.Key))
            {
                ManageClients.Instancia.Dock = DockStyle.Fill;
                Main.Instancia.Panel.Controls.Add(ManageClients.Instancia);
            }
            ManageClients.Instancia.LoadData();
            Main.Instancia.Panel.Controls[ManageClients.Instancia.Key].BringToFront();
            Main.Instancia.LinkBack.Visible = true;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (!Main.Instancia.Panel.Controls.ContainsKey(ManageOrders.Instancia.Key))
            {
                ManageOrders.Instancia.Dock = DockStyle.Fill;
                Main.Instancia.Panel.Controls.Add(ManageOrders.Instancia);
            }
            ManageOrders.Instancia.LoadData();
            Main.Instancia.Panel.Controls[ManageOrders.Instancia.Key].BringToFront();
            Main.Instancia.LinkBack.Visible = true;
        }

        private void mtPhones_Click(object sender, EventArgs e)
        {
            if (!Main.Instancia.Panel.Controls.ContainsKey(ManageDevices.Instancia.Key))
            {
                ManageDevices.Instancia.Dock = DockStyle.Fill;
                Main.Instancia.Panel.Controls.Add(ManageDevices.Instancia);
            }
            ManageDevices.Instancia.LoadData();
            Main.Instancia.Panel.Controls[ManageDevices.Instancia.Key].BringToFront();
            Main.Instancia.LinkBack.Visible = true;
        }

        private void mtNewOrder_Click(object sender, EventArgs e)
        {
            ABMOrder abm = new ABMOrder();
            abm.Show();
        }

        #endregion
    }
}
