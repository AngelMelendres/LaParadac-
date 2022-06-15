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
    public partial class clientesRiobamba : Form
    {
        ClassReportes reportes= new ClassReportes();
        public clientesRiobamba()
        {
            InitializeComponent();
            mostrarReporte();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesRiobamba_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
            mostrarReporte();
        }
        public void mostrarReporte()
        {
            DataTable dt = new DataTable();
            dt = reportes.getEmpleados();

            ReportDataSource rp = new ReportDataSource("DataSet2", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();


        }
    }
    }
