using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiDesktop
{
    public partial class Main : MetroForm
    {
        //Tiene el constructor publico porque es la ventana que se inicia
        #region Singleton
        private static Main _instancia;

        public static Main Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Main();
                }
                return _instancia;
            }
        }
        
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        public MetroPanel Panel
        {
            get
            {
                return mPanel;
            }
        }

        public MetroLink LinkBack
        {
            get
            {
                return linkHome;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _instancia = this;
            linkHome.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            Panel.Controls.Add(dashboard);          
        }

        private void linkBack_Click(object sender, EventArgs e)
        {
            Panel.Controls["Dashboard"].BringToFront();
            LinkBack.Visible = false;
        }
    }
}
