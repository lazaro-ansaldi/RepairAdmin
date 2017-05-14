using ManagePhones.Entities.Entidades;
using ManagePhones.Logic.Logic;
using ManagePhones.Util.Exceptions;
using System.Threading.Tasks;
using UiDesktop.Generic.ABMWindows;

namespace UiDesktop.ABMWindows
{
    public partial class ABMPhone : GenericABMWindows
    {
        public ABMPhone()
        {
            InitializeComponent();
            _currentEntity = new Phone();
        }

        public void MapToForm(Phone phone)
        {
            LogicModel logicModel = new LogicModel();
            try
            {             
                cbModelos.DataSource = logicModel.GetAll();
            }
            catch (LoggedException logex)
            {
                base.ShowError(logex.Message, "Consultar Modelos.");
            }
            _currentEntity = phone;
            txtDescripcion.Text = phone.Descripcion;
            txtImei.Text = phone.Imei;
            cbModelos.SelectedItem = phone.Modelo;
        }

        private Phone MapFromForm()
        {
            Phone p = new Phone();
            p.Modelo = (Modelo)cbModelos.SelectedItem;
            p.Imei = txtImei.Text;
            p.Descripcion = txtDescripcion.Text;
            p.Id = _currentEntity.Id;
            return p;
        }

        protected override async Task SaveChanges()
        {
            if (!Validar())
            {
                return;
            }
            LogicPhone logicPhone = new LogicPhone();
            try
            {
                if (_currentEntity.Id > 0)
                {
                    await logicPhone.UpdatePhone(MapFromForm());
                    base.ShowInfo("Telefono modificado correctamente.", "Modificar Modelo.");
                }
                else
                {
                    await logicPhone.AddNewPhone(MapFromForm());
                    base.ShowInfo("Telefono agregado correctamente.", "Modificar Modelo.");
                }
                if (Caller == ManagePhones.Util.Enums.CallerType.Panel)
                {
                    Panels.ManageDevices.Instancia.LoadData();
                }
                this.Close();
            }
            catch (LoggedException logex)
            {
                base.ShowError(logex.Message, "Modificar Modelo.");
            }
        }

        private bool Validar()
        {
            if (txtImei.Text == string.Empty)
            {
                base.ShowError("Debe ingresar un codigo de IMEI.", "Modificar Dispositivo.");
                return false;
            }
            if (cbModelos.SelectedIndex < 0)
            {
                base.ShowError("Debe seleccionar un modelo de la lista.", "Modificar Dispositivo.");
                return false;
            }
            return true;
        }
    }
}
