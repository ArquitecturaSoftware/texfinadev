using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmVistaPrevia : Form
    {
        public FrmVistaPrevia()
        {
            InitializeComponent();
        }
        public string nuOc="";
        public string periodoRpt = "";

        private void FrmVistaPrevia_Load(object sender, EventArgs e)
        {
               VistaPrevia("");
        }

 
        private void FrmVistaPrevia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        public object GetDataReport(string key)
        {

            EParOCFillrpt objE = new EParOCFillrpt();


            if (periodoRpt != "")
            {

                objE.IdAnio = periodoRpt;

            }
            else
            {
                objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            }

            objE.IdOrdenCompra = nuOc;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion

            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.OrderCompra_rpt02(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

     
        public void VistaPrevia(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";
                string reportPath = "C:\\Reportes\\co_ordenCompra_rpt.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + nuOc + ".pdf";


                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                crystalReportViewer1.ReportSource = objRpt;
                //objRpt.Export();

            }
            catch (Exception ex)
            {

            }

        }


        public void Exportar(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);
      
                string reportPath = "C:\\Reportes\\co_ordenCompra_rpt.rpt";
                objRpt.Load(reportPath);

                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                saveFileDialog.Filter = "Document (*.pdf)|*.PDF";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = nuOc + ".pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    objRpt.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog.FileName); ;
                }

                crExportOptions = objRpt.ExportOptions;
                objRpt.Export();
               
            }
            catch (Exception ex)
            {

            }

        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar("");
        }


    }
}
