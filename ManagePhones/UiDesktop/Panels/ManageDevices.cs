using System.Collections.Generic;
using ManagePhones.Logic.Logic;
using ManagePhones.Util.Exceptions;
using ManagePhones.Entities.Entidades;

namespace UiDesktop.Panels
{
    public partial class ManageDevices : UiDesktop.Panels.MiddleUC
    {

        #region Singleton
        private static ManageDevices _instancia;

        public static ManageDevices Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new ManageDevices();
                }
                return _instancia;
            }
        }

        private ManageDevices()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private LogicPhone _logicPhones;
        private const string KEYNAME = "ManagePhones";
        #endregion

        public string Key
        {
            get { return KEYNAME; }
        }

        #region Public Methods
        public async override void LoadData()
        {
            _logicPhones = new LogicPhone();
            IEnumerable<Phone> listPhones;
            try
            {
                listPhones = await _logicPhones.GetAll();
                foreach(Phone p in listPhones)
                {
                    gridPhones.Rows.Add(p.Id, p.Modelo.Marca, p.Modelo.Nombre, p.Imei, p.Descripcion);
                }
            }
            catch (LoggedException loggex)
            {
                base.ShowError(loggex.Message, "Consultar Dispositivos.");
            }
        }
        #endregion
    }
}
