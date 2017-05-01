using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Logic;
using Entities.Entidades;
using Util.Exceptions;

namespace UiDesktop.Panels
{
    public partial class ManageOrders : MiddleUC
    {
        private const string KEYNAME = "ManageOrders";
        private LogicOrders _logicOrders;

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
                IEnumerable<RepairOrder> listOrders = await _logicOrders.GetAll();
                foreach(RepairOrder rp in listOrders)
                {
                    gridOrders.Rows.Add(rp.Id, rp.Id.ToString().PadLeft(5, '0'), rp.Cliente.Nombre, rp.FechaIngreso.ToString("dd/MM/yyyy"), rp.FechaEgreso, rp.Phone.Modelo.Nombre);
                }
            }
            catch(LoggedException loggex)
            {
                base.ShowError(loggex.Message, "Consultar Ordenes.");
            }

        }
    }
}
