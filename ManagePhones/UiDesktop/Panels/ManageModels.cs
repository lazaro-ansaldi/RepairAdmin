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
using Logic;
using Entities;
using Util;

namespace UiDesktop.Panels
{
    public partial class ManageModels : GenericUC
    {
        LogicModel logicModel;
        
        public ManageModels()
        {
            InitializeComponent();
        }

        public override void LoadData()
        {
            logicModel = new LogicModel();
            try
            {
                List<Modelo> modelos = logicModel.GetAll();

            }
            catch(AppException appex)
            {
                base.ShowError(appex.Message, "Cargar Modelos");
            }
            catch(Exception ex)
            {
                base.ShowError(ex.Message, "Cargar Modelos");
            }            
        }
    }
}
