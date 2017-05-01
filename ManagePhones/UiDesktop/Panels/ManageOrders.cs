using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiDesktop.Panels
{
    public partial class ManageOrders : MiddleUC
    {
        private const string KEYNAME = "ManageOrders";
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


    }
}
