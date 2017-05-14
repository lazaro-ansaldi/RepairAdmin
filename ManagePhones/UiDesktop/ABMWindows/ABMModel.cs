using ManagePhones.Entities.Entidades;
using ManagePhones.Logic.Logic;
using ManagePhones.Util.Exceptions;
using System.Threading.Tasks;
using UiDesktop.Generic.ABMWindows;

namespace UiDesktop.ABMWindows
{
    public partial class ABMModel : GenericABMWindows
    {
        public ABMModel()
        {
            InitializeComponent();
            _currentEntity = new Modelo();
        }

        public void MapToForm(Modelo model)
        {
            LogicMarca logicMarca = new LogicMarca();
            try
            {
                cbMarcas.DataSource = logicMarca.GetMarcas();
            }
            catch(LoggedException logex)
            {
                base.ShowError(logex.Message, "Consultar Modelo.");
            }
            _currentEntity = model;
            txtDesc.Text = model.Descripcion;
            txtModel.Text = model.Nombre;
            cbMarcas.SelectedItem = model.Marca;
        }

        private Modelo MapFromForm()
        {
            Modelo m = new Modelo();
            m.Marca = (Marca)cbMarcas.SelectedItem;
            m.Nombre = txtModel.Text;
            m.Descripcion = txtDesc.Text;
            m.Id = _currentEntity.Id;
            return m;   
        }

        protected override async Task SaveChanges()
        {
            if (!Validar())
            {
                return;
            }
            LogicModel logicModel = new LogicModel();
            try
            {
                if (_currentEntity.Id > 0)
                {
                    await logicModel.UpdateModel(MapFromForm());
                    base.ShowInfo("Modelo modificado correctamente.", "Modificar Modelo.");
                }
                else
                {
                    await logicModel.AddNewModel(MapFromForm());
                    base.ShowInfo("Modelo agregado correctamente.", "Modificar Modelo.");
                }
                if (Caller == ManagePhones.Util.Enums.CallerType.Panel)
                {
                    Panels.ManageModels.Instancia.LoadData();
                }
                this.Close();               
            }
            catch(LoggedException logex)
            {
                base.ShowError(logex.Message, "Modificar Modelo.");
            }
        }

        private bool Validar()
        {
            if (txtModel.Text == string.Empty)
            {
                base.ShowError("El nombe del modelo no puede quedar vacío.", "Modificar Modelo.");
                return false;
            }
            if (cbMarcas.SelectedIndex < 0)
            {
                base.ShowError("Debe seleccionar una marca de la lista.", "Modificar Modelo.");
                return false;
            }
            return true;
        }
    }
}
