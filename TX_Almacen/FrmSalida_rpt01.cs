using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmSalida_rpt01 : Form
    {
        public string nuSalida;

        public FrmSalida_rpt01()
        {
            InitializeComponent();
        }

        private void FrmSalida_rpt01_Load(object sender, EventArgs e)
        {
            VistaPrevia("");
        }
        public object GetDataReport(string key)
        {

            ESalida objE = new ESalida();

            objE.IdSalida = nuSalida;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
            objE.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            BSalida objop = new BSalida();
            DataTable dt = objop.AL_Salida_rpt01(objE);
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
                string reportPath = "C:\\Reportes\\CRSalida_despacho_rpt01.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + nuSalida + ".pdf";


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
                ex.ToString();
            }

        }


        public void Exportar(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRSalida_despacho_rpt01.rpt";
                objRpt.Load(reportPath);

                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                saveFileDialog.Filter = "Document (*.pdf)|*.PDF";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = nuSalida + ".pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    objRpt.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog.FileName); ;
                }

                crExportOptions = objRpt.ExportOptions;
                objRpt.Export();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
