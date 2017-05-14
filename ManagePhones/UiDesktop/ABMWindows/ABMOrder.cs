using ManagePhones.Entities.Entidades;
using ManagePhones.Logic.Logic;
using System;
using System.Linq;
using UiDesktop.Generic.ABMWindows;

namespace UiDesktop.ABMWindows
{
    public partial class ABMOrder : GenericABMWindows
    {

        public ABMOrder()
        {
            InitializeComponent();
            LoadData();
        }

        public void MapToForm(RepairOrder order)
        {
            _currentEntity = order;
            txtDateEgreso.Text = order.GetFechaEgreso("dd/MM/yyyy");
            cbClientes.SelectedItem = order.Cliente;
            if (order.Id > 0)
            {
                dateIngreso.Value = order.FechaIngreso;
            }else
            {
                dateIngreso.Value = DateTime.Now;
            }
            chckSd.Checked = order.IsSd;
            chckSim.Checked = order.IsSim;
        }

        private async void LoadData()
        {
            LogicClient logicCliente = new LogicClient();
            LogicPhone logicPhone = new LogicPhone();
            try
            {                
                cbClientes.DataSource = (await logicCliente.GetAll()).ToList();
                cbPhones.DataSource = (await logicPhone.GetAll()).ToList();
            }
            catch(Exception ex)
            {
                base.ShowError(ex.Message, "Cargar Información.");
            }
        }

        private void rbOtra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtra.Checked)
            {
                dateIngreso.Enabled = true;
            }else
            {
                dateIngreso.Enabled = false;
            }
        }
    }
}
