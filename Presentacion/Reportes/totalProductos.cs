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

namespace Presentacion.Reportes
{
    public partial class totalProductos : Form
    {
        ClassReportes reportes= new ClassReportes();
        public totalProductos()
        {
            InitializeComponent();
            mostrarReporte();
        }
        public void mostrarReporte()
        {
            DataTable dt = new DataTable();
            dt = reportes.getProductos();

            ReportDataSource rp = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }
            private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void totalProductos_Load(object sender, EventArgs e)
        {
            mostrarReporte();
        }
    }
}
