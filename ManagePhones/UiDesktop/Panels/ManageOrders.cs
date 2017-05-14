using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UiDesktop.ABMWindows;
using ManagePhones.Logic.Logic;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;
using UiDesktop.Reports.ShowReports;

namespace UiDesktop.Panels
{
    public partial class ManageOrders : MiddleUC
    {
        private const string KEYNAME = "ManageOrders";
        private LogicOrders _logicOrders;
        private IEnumerable<RepairOrder> listOrders;

        public string Key
        {
            get
            {
                return KEYNAME;
            }
        }

        #region Singleton
        private static ManageOrders _instancia;

        public static ManageOrders Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ManageOrders();
                }
                return _instancia;
            }
        }

        private ManageOrders()
        {
            InitializeComponent();
        }
        #endregion

        public async override void LoadData()
        {
            _logicOrders = new LogicOrders();
            try
            {
                listOrders = await _logicOrders.GetAll();
                foreach(RepairOrder rp in listOrders)
                {
                    gridOrders.Rows.Add(rp.Id, rp.Id.ToString().PadLeft(5, '0'), string.Format("{0}, {1}", new object[] { rp.Cliente.Apellido, rp.Cliente.Nombre }), rp.FechaIngreso.ToString("dd/MM/yyyy"), rp.GetFechaEgreso("dd/MM/yyyy"), rp.Importe, rp.Phone.Modelo.Nombre);
                }
            }
            catch(LoggedException loggex)
            {
                base.ShowError(loggex.Message, "Consultar Ordenes.");
            }
        }

        protected override void linkEdit_Click(object sender, System.EventArgs e)
        {
            ABMOrder abmWin = new ABMOrder();          
            abmWin.MapToForm(MapFromList());
            abmWin.Show();
        }

        private RepairOrder MapFromList()
        {
            int id = int.Parse(gridOrders.CurrentRow.Cells["Id"].Value.ToString());
            var order = (from ord in listOrders where ord.Id == id select ord).SingleOrDefault();
            return order;
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            _logicOrders = new LogicOrders();
            try
            {
                RepairOrder currentOrder = await _logicOrders.GetOrderData(MapFromList());
                ShowReport showReport = new ShowReport();
                showReport.LoadData(currentOrder);
                showReport.Show();          
            }
            catch(LoggedException loggex)
            {
                base.ShowError(loggex.Message, "Consultar Ordenes.");
            }
        }
    }
}
