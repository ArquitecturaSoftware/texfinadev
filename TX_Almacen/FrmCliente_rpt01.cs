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
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmCliente_rpt01 : Form
    {
        public FrmCliente_rpt01()
        {
            InitializeComponent();
        }

        private void MG_Cliente_rpt01_Load(object sender, EventArgs e)
        {

        }

        public object GetDataReport(string key)
        {

            ECliente objE = new ECliente();

            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objE.Nu_ruc = txtnu_ruc.Text.Trim();
            objE.Ds_raznombre = txtds_rs.Text.Trim();// llenar con sesion

            BCliente obj = new BCliente();
            DataTable dt = obj.MG_Cliente_rpt01(objE);
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
                string reportPath = "C:\\Reportes\\CR_Cliente_rpt01.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + "Cliente.pdf";


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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VistaPrevia("");
        }

    }
}
