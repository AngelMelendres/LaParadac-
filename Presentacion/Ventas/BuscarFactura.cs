using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
using Microsoft.Reporting.WinForms;

namespace Presentacion.Ventas
{
    public partial class BuscarFactura : Form
    {
        ClassReportes reportes = new ClassReportes();
        int numFactura;
        public BuscarFactura(int numFactura)
        {
            InitializeComponent();
            this.numFactura = numFactura;
            llenarReporte();
        }

        public void llenarReporte()
        {
            DataTable dt = new DataTable();
            dt = reportes.getDetallesIdFactura(numFactura);

            ReportDataSource rp = new ReportDataSource("DataSet3", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }

        private void BuscarFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            llenarReporte();
        }
    }
}
