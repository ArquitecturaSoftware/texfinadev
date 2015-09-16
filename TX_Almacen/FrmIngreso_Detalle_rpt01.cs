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
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Al;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace TX_Almacen
{
    public partial class FrmIngreso_Detalle_rpt01 : Form
    {
        public FrmIngreso_Detalle_rpt01()
        {
            InitializeComponent();


            WebHelper.LoadListControl3(cbTipo, BGeneral.ObtenerDatoidTabla("145"));
            WebHelper.LoadListControl3(cbTipIngreso, BGeneral.ObtenerDatoidTabla("146"));
            WebHelper.LoadListControl3(cbMercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cbTiptela, BGeneral.ObtenerDatoidTabla("147"));
            cbTipo.SelectedIndex = -1;
            cbTipIngreso.SelectedIndex = -1;
            cbMercado.SelectedIndex = -1;
            cbTiptela.SelectedIndex = -1;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente_qry frmp = new frmCliente_qry();
            frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
            frmp.ShowDialog();
            txtidCliente.Focus();
        }

        public void ejecutarCliente(ECliente cl)
        {
            txtidCliente.Text = cl.Id_clipro;
            lblCliente.Text = cl.Ds_raznombre;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProducto_qry frmp = new frmProducto_qry();
            frmp.pasard += new frmProducto_qry.pasar(ejecutarProd);
            frmp.ShowDialog();
            txtidProducto.Focus();
        }

        public void ejecutarProd(EDetProducto prd)
        {
            txtidProducto.Text = prd._Codigo;
            lblProducto.Text = prd._Producto;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frnColor_qry frmp = new frnColor_qry();
            frmp.pasard += new frnColor_qry.pasar(ejecutarColor);
            frmp.ShowDialog();
            txtidColor.Focus();
        }

        public void ejecutarColor(EColor col)
        {
            txtidColor.Text = col.Id_color;
            lblColor.Text = col.Ds_color;
        }

        private void FrmIngreso_Detalle_rpt01_Load(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cbTipo, BGeneral.ObtenerDatoidTabla("145"));
            WebHelper.LoadListControl3(cbTipIngreso, BGeneral.ObtenerDatoidTabla("146"));
            WebHelper.LoadListControl3(cbMercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cbTiptela, BGeneral.ObtenerDatoidTabla("147"));
            cbTipo.SelectedIndex = -1;
            cbTipIngreso.SelectedIndex = -1;
            cbMercado.SelectedIndex = -1;
            cbTiptela.SelectedIndex = -1;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VistaPrevia("");
        }



        public object GetDataReport(string key)
        {

            EIngresoDetalle objE = new EIngresoDetalle();


            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 
            objE.fecha = dtFechaIni.Value.ToString();
            objE.fechaFin = dtFechaFin.Value.ToString();
            objE.ds_clipro = lblCliente.Text;
            objE.ds_producto = lblProducto.Text;
            objE.ds_color = lblColor.Text;
            objE.Id_mercado = cbMercado.Text.ToString();
            objE.Id_tipTela = cbTiptela.Text.ToString();
            objE.Id_TipIngreso = cbTipIngreso.Text.ToString();
            objE.Id_Tipo = cbTipo.Text.ToString();

            BIngreso_Detalle obj = new BIngreso_Detalle();
            DataTable dt = obj.AL_Ingreso_Detalle_rpt01(objE);
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
                string reportPath = "C:\\Reportes\\CR_Ingreso_rpt01.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder +  "DATA.pdf";


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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblCliente.Text = "";
            lblColor.Text = "";
            lblProducto.Text = "";
            txtidCliente.Clear();
            txtidColor.Clear();
            txtidProducto.Clear();

            cbTipo.SelectedIndex = -1;
            cbTipIngreso.SelectedIndex = -1;
            cbMercado.SelectedIndex = -1;
            cbTiptela.SelectedIndex = -1;
        }




    }
}
