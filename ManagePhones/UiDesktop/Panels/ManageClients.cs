using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagePhones.Logic.Logic;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace UiDesktop.Panels
{
    public partial class ManageClients : MiddleUC
    {
        #region Singleton
        private static ManageClients _instance;

        public static ManageClients Instancia
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageClients();
                }
                return _instance;
            }
        }
        private ManageClients()
        {
            InitializeComponent();
        }
        #endregion

        private const string KEYNAME = "ManageClients";
        public string Key
        {
            get
            {
                return KEYNAME;
            }
        }

        private LogicClient _logicClient;

        public async override void LoadData()
        {
            _logicClient = new LogicClient();
            gridClientes.Rows.Clear();
            try
            {
                IEnumerable<Cliente> listClientes = await _logicClient.GetAll();
                foreach (Cliente c in listClientes)
                {
                    // IdCliente | Apellido | Nombre //
                    gridClientes.Rows.Add(c.Id, c.Apellido, c.Nombre);
                }
            }
            catch (LoggedException logex)
            {
                base.ShowError(logex.Message, "Cargar Modelos");
            }
            catch (Exception ex)
            {
                base.ShowError(ex.Message, "Cargar Modelos");
            }
        }

    }
}
