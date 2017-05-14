using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagePhones.Entities.Entidades;

namespace UiDesktop.Reports.ShowReports
{
    public partial class ShowReport : UserControl
    {
        public ShowReport()
        {
            InitializeComponent();
        }

        public void LoadData(RepairOrder order)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("nombreCliente", string.Format("{0}, {1}", new object[] { order.Cliente.Apellido, order.Cliente.Nombre})),
                new Microsoft.Reporting.WinForms.ReportParameter("razonSocial", "Razon Social"),
                new Microsoft.Reporting.WinForms.ReportParameter("modeloEquipo", order.Phone.Modelo.Nombre),
                new Microsoft.Reporting.WinForms.ReportParameter("fechaIngreso", order.FechaIngreso.ToString("dd/MM/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("fechaEgreso", order.GetFechaEgreso("dd/MM/yyyy"))
            };
            rptViewer.LocalReport.SetParameters(parameters);
            rptViewer.RefreshReport();
        }
    }
}
