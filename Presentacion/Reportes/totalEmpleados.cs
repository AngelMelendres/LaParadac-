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
    public partial class totalEmpleados : Form
    {
        ClassReportes reportes = new ClassReportes();

        public totalEmpleados()
        {
            InitializeComponent();
            mostrarFactura();
        }



        public void mostrarFactura()
        {
            DataTable dt = new DataTable();
            dt=reportes.getClientes();

            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();




        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientPanel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel4_Click(object sender, EventArgs e)
        {

        }

        private void totalEmpleados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            mostrarFactura();
        }
    }
}
