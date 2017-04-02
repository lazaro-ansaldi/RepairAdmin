using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Entidades;
using Logic;

namespace UiDesktop.ABMWindows
{
    public partial class ABMModel : GenericABMWindows
    {
        private Modelo currentModel;
        private LogicModel logicModel;

        public ABMModel()
        {
            InitializeComponent();
        }

        public void MapToForm(Modelo model)
        {
            currentModel = model;
            txtDescripcion.Text = currentModel.Descripcion;
            txtModel.Text = currentModel.Nombre;
            cbMarcas.Items.Add(model.Marca);
        }
    }
}
