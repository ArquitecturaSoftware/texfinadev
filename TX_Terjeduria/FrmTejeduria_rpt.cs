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
using Texfina.BOQry.TJ;
using Texfina.Entity.TJ;

namespace TX_Terjeduria
{
    public partial class FrmTejeduria_rpt : Form
    {
        public FrmTejeduria_rpt()
        {
            InitializeComponent();
        }

        public string var_idProducto,var_nucorrelativo;
        
        public object GetDataReport(string key)
        {

            ETejeduria objE = new ETejeduria();
            ETejeduria objED = new ETejeduria();

            //objE.psintypesel = 12;
            objE.Id_producto = var_idProducto.ToString();//txt_idTejido.Text;
            objE.Nu_correficha = var_nucorrelativo.ToString();//txt_nuFicha.Text;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            BTejeduria objTJ = new BTejeduria();
            DataTable dt = objTJ.GetFichaTejeduria_rpt01(objE);

            DataSet ds = new DataSet();

            ds.Tables.Add(dt);
            //ds.Tables.Add(dtD);

            return ds;
        

        }

        public void VistaPrevia(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";

                string reportPath = "C:\\Reportes\\CRfichatela_rpt.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);

                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + var_idProducto.ToString() + var_nucorrelativo.ToString() + ".pdf";


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

        private void FrmTejeduria_rpt_Load(object sender, EventArgs e)
        {
            VistaPrevia("");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}
