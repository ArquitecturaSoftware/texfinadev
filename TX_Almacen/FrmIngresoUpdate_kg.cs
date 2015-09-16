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
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmIngresoUpdate_kg : Form
    {
        public FrmIngresoUpdate_kg()
        {
            InitializeComponent();
        }

        private void txtcodbarr_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Buscar();
            }
            catch (Exception ex)
            {
                //Nuevo();
                ex.ToString();
            }


        }


        private void Buscar()
        {

            EParametros objIng = new EParametros();


            objIng.idEmpresa = wfChgEmpPer.datos.idEmpresa;
            objIng.idperiodo = wfChgEmpPer.datos.idperiodo;

            lblNumCodBarra.Text = txtcodbarr.Text;
            objIng.codbarra = lblNumCodBarra.Text;

            EParametros oBtieneIg = new EParametros();            

            oBtieneIg = BIngreso_Detalle.AL_Ingreso_Detalle_qry7(objIng);

            string dsprod = oBtieneIg.ds_producto;
            //MessageBox.Show(dsprod);
            if (dsprod != null)
            {
                lblcodbarra.Text = oBtieneIg.codbarra.ToString();
              //  lblNumCodBarra.Text = oBtieneIg.codbarra.ToString();
                txtCodIngreso.Text = oBtieneIg.idIngreso.ToString().Trim();
                txtItem.Text = oBtieneIg.nu_Item.ToString();
                txtfecha.Text = oBtieneIg.feguia.ToString().Trim();
                cbtipodoc.SelectedValue = oBtieneIg.id_docucom.ToString();
                txtnu_doc.Text = oBtieneIg.nu_doc.ToString();
                cb_almacen.SelectedValue = oBtieneIg.id_Almacen.ToString();
                cb_tipo.SelectedValue = oBtieneIg.id_Tipo.ToString();
                cb_tipoIngreso.SelectedValue = oBtieneIg.id_TipIngreso.ToString();
                txtidproducto.Text = oBtieneIg.id_producto.ToString();
                txtdsproducto.Text = oBtieneIg.ds_producto.ToString();
                txtidcolor.Text = oBtieneIg.id_color.ToString().Trim();
                txtdscolor.Text = oBtieneIg.ds_color.ToString().Trim();
                txtnutf.Text = oBtieneIg.nu_tf.ToString().Trim();
                txtnu_rollo.Text = oBtieneIg.qt_rollo.ToString();
                txtidcliente.Text = oBtieneIg.id_clipro.ToString();
                txtdscliente.Text = oBtieneIg.ds_raznombre.ToString().Trim();
                txtidvendedor.Text = oBtieneIg.id_vendedor.ToString();
                txtvendedor.Text = oBtieneIg.dsVendedor.ToString().Trim();
                txtancho.Text = oBtieneIg.qt_ancho.ToString();
                txtdensidad.Text = oBtieneIg.qt_densidad.ToString();
                txtpesoDespacho.Text = oBtieneIg.qt_peso_desp.ToString();
                txtpesoReal.Text = oBtieneIg.qt_peso_real.ToString();
                txtpesoActual.Text = oBtieneIg.qt_peso_actual.ToString();
         
                txtcodbarr.Focus();
                txtcodbarr.SelectionStart = 0;
                txtcodbarr.SelectionLength = txtcodbarr.Text.Length;
          
            }
            else
            {
                //txtcodbarr.SelectionStart = txtcodbarr.Text.Length;
                //txtcodbarr.SelectionLength = txtcodbarr.Text.Length;
                Nuevo();
            }

        }

    

        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
               
                    EIngresoDetalle objID = new EIngresoDetalle();
                    if (txtcodbarr.Text != "")
                    {


                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objID.Cod_Bar = txtcodbarr.Text;
                        objID.Qt_peso_real = Convert.ToDecimal(txtpesoReal.Text);
                        objID.Id_uupdarec = frmLogin.d.id.ToLower();


                        BIngreso_Detalle.AL_Ingreso_Detalle_mnt02(objID);

                        MessageBox.Show("Datos Grabados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Código", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            txtcodbarr.Clear();
        }


        private void Nuevo()
        {
            txtCodIngreso.Clear();
            txtItem.Clear();
            txtidproducto.Clear();
            txtdsproducto.Clear();
            txtidcolor.Clear();
            txtdscolor.Clear();
            txtnutf.Clear();
            txtpesoReal.Clear();
            txtnu_rollo.Clear();
            txtidcliente.Clear();
            txtdscliente.Clear();            
            txtvendedor.Clear();
            txtidvendedor.Clear();
            txtancho.Clear();
            txtdensidad.Clear();
            txtpesoDespacho.Clear();
            txtpesoActual.Clear();
            cb_almacen.SelectedIndex = - 1;
            cb_tipo.SelectedIndex = -1;
            cb_tipoIngreso.SelectedIndex = -1;
            cbtipodoc.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmIngresoUpdate_kg_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtcodbarr;
            txtcodbarr.Focus();
            WebHelper.LoadListControl3(cb_almacen, BAlmacen.ObtenerDatoAlmacen());
            WebHelper.LoadListControl3(cbtipodoc, BDocumento.ObtenerDatoTfactura());
            WebHelper.LoadListControl3(cb_tipo, BGeneral.ObtenerDatoidTabla("145"));
            WebHelper.LoadListControl3(cb_tipoIngreso, BGeneral.ObtenerDatoidTabla("146"));
        }

        private void FrmIngresoUpdate_kg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            PrintReport("");
        }
        public void PrintReport(string key)
        {
       

            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta02.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + "Etiqueta.pdf";


                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                objRpt.Export();



                this.printDialog1.Document = this.printDocument1;
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

        public object GetDataReport(string key)
        {

            EIngresoDetalle objE = new EIngresoDetalle();
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objE.IdPeriodo =  txtcodbarr.Text.Substring(0,4);
            objE.IdIngreso = ("").Trim();
            objE.Cod_Bar = txtcodbarr.Text;

            BIngreso_Detalle objI = new BIngreso_Detalle();
            DataTable dt = objI.AL_Ingreso_etiqueta02_rpt(objE);

            DataSet ds = new DataSet();

            ds.Tables.Add(dt);


            return ds;
            //-----------------------------------------------------------------

        }


    }
}
