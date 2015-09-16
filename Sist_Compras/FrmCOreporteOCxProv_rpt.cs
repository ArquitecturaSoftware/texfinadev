using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmCOreporteOCxProv : Form
    {
        public FrmCOreporteOCxProv()
        {
            InitializeComponent();
        }

        int ancho, alto;


        private void FrmCOreporteOCxProv_Load(object sender, EventArgs e)
        {
            //ancho = this.Width;
            //alto = this.Height;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmcoproveedor_qry frmp = new frmcoproveedor_qry();
            frmp.FormParent = this;
            frmp.ShowDialog();   
        }


       public void LlenarGrilla(EProveedor objProv, object form)
        {
            string str = Convert.ToString(dgvDetalle.Rows.Count + 1);
            string[] row = { objProv.Id_clipro,
                             objProv.Ds_raznombre,
                           };
            dgvDetalle.Rows.Add(row);
         

            frmcoproveedor_qry frmqry = (frmcoproveedor_qry)form;
            frmqry.Close();     
        }


         private void btnExportar_Click(object sender, EventArgs e)
         {
             PrintReport("");
         }

         public void PrintReport(string key)
         {
             try
             {
                 ReportDocument objRpt = new ReportDocument();
                 DataSet ds = (DataSet)this.GetDataReport(key);

                 //string reportPath = Application.StartupPath + "\\Reportes\\OrdenCompraxprov.rpt";

                 string reportPath = "C:\\Reportes\\OrdenCompraxprov.rpt";
                 objRpt.Load(reportPath);

                 DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                 PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                 ExportOptions crExportOptions = new ExportOptions();

                 objRpt.SetDataSource(ds.Tables[0]);
                 string strfolder = "C:\\Reporte\\";
                 crDiskFileDestinationOption.DiskFileName = strfolder +  "Data.pdf";
                 crExportOptions = objRpt.ExportOptions;

                 crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                 crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

                 crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                 crExportOptions.ExportFormatOptions = crFormatTypeOption;
                 objRpt.Export();

                 MessageBox.Show("Registros exportados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


             }
             catch (Exception ex)
             {

             }

         }

         public object GetDataReport(string key)
         {

             EParOCFillrpt objE = new EParOCFillrpt();

             String Cadena = "";
             String cadenaCliprov;
             for (int i = 0; dgvDetalle.Rows.Count > i; i++)
             {

                 cadenaCliprov =   dgvDetalle.Rows[i].Cells["id_clipro"].Value  +",";
                 Cadena = Cadena + "" + cadenaCliprov;
 
             }

             String _cadena = Cadena.Substring(0, Cadena.Length - 1);

             objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
             objE.fechaini = txtfechaIni.Text;
             objE.fechaFin = txtFechaFin.Text;
             objE.idProv = _cadena.ToString();

             BOrdenCompra objOC = new BOrdenCompra();
             DataTable dt = objOC.OrderCompra_rpt03(objE);
             DataSet ds = new DataSet();
             ds.Tables.Add(dt);
             return ds;

         }

         private void FrmCOreporteOCxProv_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.N && e.Control)
             {
                 frmcoproveedor_qry frmp = new frmcoproveedor_qry();
                 frmp.FormParent = this;
                 frmp.ShowDialog();  
             }
             else if (e.KeyCode == Keys.F3)
             {
                 PrintReport("");
             }
             else if (e.KeyCode == Keys.F2)
             {
                 ExportReport("");
             }
             else if(e.KeyCode == Keys.Space)
             {
                 this.Close();
             }

         }

         private void btnExportarExcel_Click(object sender, EventArgs e)
         {
             //ReportExcel("");
             ExportReport("");
         }

         public  void ExportReport(string key)
         {
             try
             {
                 DataSet ds = (DataSet)this.GetDataReport(key);

                 ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\Data.xls", ds);

                 MessageBox.Show("Registros exportados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             catch (Exception ex)
             {
 
             }
       
         }

         private void btnSalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void txtfechaIni_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
             {
                 txtFechaFin.Focus();
             }
         }

         private void FrmCOreporteOCxProv_Resize(object sender, EventArgs e)
         {
             //this.Size = new System.Drawing.Size(ancho, alto);

         }

         public void ReportExcel(string key)
         {
             try
             {
                 ReportDocument objRpt = new ReportDocument();
                 DataSet ds = (DataSet)this.GetDataReport(key);

                 //string reportPath = Application.StartupPath + "\\Reportes\\CROrdenCompraxprov.rpt";
                 string reportPath = "C:\\Reportes\\CROrdenCompraxprov.rpt";
                 objRpt.Load(reportPath);

                 DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                 //PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                 ExcelFormatOptions crFormatTypeOption = new ExcelFormatOptions();
                 ExportOptions crExportOptions = new ExportOptions();

                 objRpt.SetDataSource(ds.Tables[0]);
                 string strfolder = "C:\\Reporte\\";
                 crDiskFileDestinationOption.DiskFileName = strfolder + "DATA.xls";
                 crExportOptions = objRpt.ExportOptions;

                 crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                 crExportOptions.ExportFormatType = ExportFormatType.Excel;

                 crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                 crExportOptions.ExportFormatOptions = crFormatTypeOption;
                 objRpt.Export();

                 MessageBox.Show("Registros exportados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);


             }
             catch (Exception ex)
             {
                 ex.ToString();
             }

         }


       
}
}