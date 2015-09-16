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
    public partial class FrmVistaPreviaIngresoEtiqueta_rpt : Form
    {
        public FrmVistaPreviaIngresoEtiqueta_rpt()
        {
            InitializeComponent();
        }

        public string var_idIngreso;

        private void FrmVistaPreviaIngresoEtiqueta_rpt_Load(object sender, EventArgs e)
        {
            VistaPrevia("");
        }


        public object GetDataReport(string key)
        {

            EIngreso objE = new EIngreso();

            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objE.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            objE.IdIngreso = var_idIngreso;

            BIngreso objI = new BIngreso();
            DataTable dt = objI.AL_Ingreso_etiqueta_rpt(objE);

            DataSet ds = new DataSet();

            ds.Tables.Add(dt);
        

            return ds;
            //-----------------------------------------------------------------
  
        }

        public void VistaPrevia(string key)
        {
            try
            {
            
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";
                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + var_idIngreso + ".pdf";


                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                crystalReportViewer1.ReportSource = objRpt;
             

                //objRpt.Export();
                //------------------------------------------------------


            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void FrmVistaPreviaIngresoEtiqueta_rpt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



        public void PrintReport(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                
                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + var_idIngreso + ".pdf";


                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                objRpt.Export();

                    
                this.printDialog1.Document = this.printDocument1;
                printDialog1.AllowCurrentPage = true;
                printDialog1.AllowSomePages = true;
                printDialog1.AllowSelection = true;

                DialogResult dr = this.printDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    
           

                    PageMargins margins;
                    
                    
                    margins = objRpt.PrintOptions.PageMargins;
                    margins.bottomMargin = 250;
                    margins.leftMargin = 250;
                    margins.rightMargin = 250;
                    margins.topMargin = 250;
                    objRpt.PrintOptions.ApplyPageMargins(margins);

                    string PrinterName = this.printDocument1.PrinterSettings.PrinterName;

                    objRpt.PrintOptions.PrinterName = PrinterName;


                    objRpt.PrintToPrinter(1, false, 0, 0);

                }


            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            Exportar("");
        }

        public void Exportar(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta.rpt";
                objRpt.Load(reportPath);

                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                saveFileDialog.Filter = "Document (*.pdf)|*.PDF";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = var_idIngreso + ".pdf";
                
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintReport("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
