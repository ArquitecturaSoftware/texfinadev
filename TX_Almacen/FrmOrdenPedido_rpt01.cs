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
    public partial class FrmOrdenPedido_rpt01 : Form
    {
        public string nuop;
        public string estado;

        public FrmOrdenPedido_rpt01()
        {
            InitializeComponent();
        }


        private void FrmOrdenPedido_rpt01_Load(object sender, EventArgs e)
        {
            VistaPrevia("");
        }

        public object GetDataReport(string key)
        {

            EOrdPedido objE = new EOrdPedido();


            objE.Idreqsalida = nuop;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
            objE.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            BOrdPedido objop = new BOrdPedido();
            DataTable dt = objop.OrdenPedido_rpt01(objE);
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
                string reportPath = "C:\\Reportes\\CROrdenPedido_rpt01.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + nuop + ".pdf";


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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Exportar("");
        }


        public void Exportar(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CROrdenPedido_rpt01.rpt";
                objRpt.Load(reportPath);

                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                saveFileDialog.Filter = "Document (*.pdf)|*.PDF";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = nuop + ".pdf";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (estado == "1")
            {
                EOrdPedido objI = new EOrdPedido();
                objI.Idreqsalida = nuop;
                objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                objI.Ds_observ = txtds_Observacion.Text.ToUpper();
                objI.Id_ucreatrec = frmLogin.d.id.ToLower();

                BOrdPedido.OrdenPedido_mnt03(objI);
            }
            else if (estado =="2")
            {
                EOrdPedido objI = new EOrdPedido();
                objI.Idreqsalida = nuop;
                objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                objI.Ds_observ = txtds_Observacion.Text.ToUpper();
                objI.Id_ucreatrec = frmLogin.d.id.ToLower();

                BOrdPedido.OrdenPedido_mnt04(objI);
            }
            else if(estado == "3")
            {
                EOrdPedido objI = new EOrdPedido();
                objI.Idreqsalida = nuop;
                objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                objI.Ds_observ = txtds_Observacion.Text.ToUpper();
                objI.Id_ucreatrec = frmLogin.d.id.ToLower();

                BOrdPedido.OrdenPedido_mnt05(objI);
            }
        }
    }
}
