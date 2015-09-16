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
using Texfina.BOQry.Co;
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmFactura_mnt : Form
    {
        public FrmFactura_mnt()
        {
            InitializeComponent();

            //WebHelper.LoadListControl3(cbmoneda, BTablaGeneral.TablaGeneralFill("016"), "", "");

            cbmoneda.DataSource = BTablaGeneral.tablaGeneral("016");
            cbmoneda.ValueMember = "id";
            cbmoneda.DisplayMember = "desc";
            
            DataGridViewComboBoxColumn comboboxolumn = dgvDetalle.Columns["TipDoc"] as DataGridViewComboBoxColumn;
            //WebHelper.LoadListControl3(comboboxolumn, BGeneral.ObtenerDatoLocal());
            comboboxolumn.DataSource = BDocumento.ObtenerDatoTfactura();
            comboboxolumn.DisplayMember = "desc";
            comboboxolumn.ValueMember = "id";

        }
        int ancho, alto;
        private void Form1_Load(object sender, EventArgs e)
        {

            //ancho = this.Width;
            //alto = this.Height;
            //DropDownList cbGrillaTipDoc = (DropDownList)e.Row.FindControl("dpTipoDoc");
            //WebHelper.LoadListControl2(cbGrillaTipDoc, BDocumento.GetDocumento_Qry01(), "ds_docucom", "id_docucom");
           
           


        }
        private void mCargarDatos()
        {

            //dgvDetalle.Rows.Clear();
            try
            {
     


               
                if (!string.IsNullOrEmpty(txtOc.Text))
                {
                    EOrdenCompra oCompra = new EOrdenCompra();

                    oCompra.Id_periodo = wfChgEmpPer.datos.idperiodo; //llenar con sesion
                    oCompra.Id_ordenco = string.IsNullOrEmpty(txtOc.Text.PadLeft(7, '0')) ? string.Empty : Convert.ToString(txtOc.Text.PadLeft(7, '0'));
                    oCompra.idEmpresa = wfChgEmpPer.datos.idEmpresa;


                    List<EOrdenCompra> oListDato = BOrdenCompra.CO_Oc_qry05(oCompra);


                        string val = oListDato[0].existe;

                        if (val == "0")
                        {

                            //----------------------------------------------------------------

                            EOrdenCompraFactura oCompraF = new EOrdenCompraFactura();

                            oCompraF.Id_periodo = wfChgEmpPer.datos.idperiodo; //llenar con sesion
                            oCompraF.Id_ordenco = string.IsNullOrEmpty(txtOc.Text.PadLeft(7, '0')) ? string.Empty : Convert.ToString(txtOc.Text.PadLeft(7, '0'));
                            oCompraF.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                            //----------------------------------------------------------------
                            EOrdenCompra oBtieneOC = new EOrdenCompra();

                            oBtieneOC = BOrdenCompra.mObtenerOC_(oCompra);

                            txtOc.Text = oBtieneOC.Id_ordenco.ToString().Trim();
                            txtFechaOC.Text = oBtieneOC.Fe_ordenco.ToString().Trim();
                            txtTotal.Text = oBtieneOC.Mt_total.ToString().Trim();
                            cbmoneda.SelectedValue = oBtieneOC.Id_vmoneda.Trim();
                            txtObservacion.Text = oBtieneOC.Ds_observa.ToString().Trim();

                            txtProveedor.Text = oBtieneOC.clipro.ToString().Trim();

                            //Hddidproveedor.Value = oBtieneOC.Id_clipro.ToString().Trim();
                            lblStAutorizado.Text =  oBtieneOC.st_autorizado.ToString();
                            lblStAprobado.Text = oBtieneOC.stordenco.ToString();

                            List<EOrdenCompraFactura> lstoc = new List<EOrdenCompraFactura>();

                            //lstoc = BOrdenCompraFactura.mListarOcompraFactura2(oCompraF);

                            dgvDetalle.DataSource = BOrdenCompraFactura.mListarOcompraFactura2(oCompraF);




                            if (lblStAutorizado.Text == "(TRANSITO)")
                            {
                                btnAutorizar.Enabled = true;
                            }
                            else
                            {
                                btnAutorizar.Enabled = false;

                            }


                            if (lblStAprobado.Text == "(TRANSITO)")
                            {
                                btnAprobar.Enabled = true;
                            }
                            else
                            {
                                btnAprobar.Enabled = false;
                            }


                            if (lblStAutorizado.Text == "(TRANSITO)" && lblStAprobado.Text == "(TRANSITO)")
                            {
                                btnAprobar.Enabled = false;
                            }


                            getCalculo();
                        }
                        else
                        {

                            MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Limpiar(groupBox1);
                            NuevoItem2();
                           
                        }

                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void btnOC_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra_qry frmoc = new FrmOrdenCompra_qry();
            frmoc.pasard += new FrmOrdenCompra_qry.pasar(EjecutarOC);
            frmoc.ShowDialog();
           

        }

        public void EjecutarOC(EOrdenCompra oc)
        {
            txtOc.Text = oc.Id_ordenco;
            
            mCargarDatos();
          
            txtOc.Focus();
        }

        List<EOrdenCompraFactura> SalvarDatos = new List<EOrdenCompraFactura>();
        private void mSalvarDatosGrilla()
        {
            try
            {
                //recorre la cantidad de items, por cada item la entidad oAsigHorario va almacenando , 
                //esto para que data que se va ingresando en la grilla no se pierda

                List<EOrdenCompraFactura> lstSalvarDatos = new List<EOrdenCompraFactura>();

                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {
                    // la entidad almacena los items de la grilla 

                    EOrdenCompraFactura oFact = new EOrdenCompraFactura();

                    // verificar si los valores ingresados en la grilla estan en label o texbox como tambien en un dropdowlinst
                    oFact.Nu_secuen = dgvDetalle.Rows[i].Cells["Item"].Value.ToString();
                    oFact.Id_docucom = dgvDetalle.Rows[i].Cells["TipDoc"].Value.ToString();
                    oFact.Nu_docum = dgvDetalle.Rows[i].Cells["nuDocumento"].Value.ToString();
                    oFact.Fe_docum = Convert.ToDateTime(dgvDetalle.Rows[i].Cells["fecDocumento"].Value.ToString());
                    oFact.Mt_docum = Convert.ToDecimal(dgvDetalle.Rows[i].Cells["Total"].Value);
                    oFact.ds_observa = dgvDetalle.Rows[i].Cells["ds_observa"].Value.ToString();

                    //añade los valores de la entidad a la lista de la entidad

                    lstSalvarDatos.Add(oFact);

                }
                // se crea una sesion para almacenar la lista que contiene los  datos.

                SalvarDatos = lstSalvarDatos;
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }



        private void NuevoItem()
        {
            List<EOrdenCompraFactura> lstFact= new List<EOrdenCompraFactura>();

            EOrdenCompraFactura fact = new EOrdenCompraFactura();

            //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
            string str = Convert.ToString(dgvDetalle.Rows.Count + 1);
            if (dgvDetalle.Rows.Count > 0)
            {
                //almacena en la entidad la informacion ingresada en la grilla
                //salva los datos, hace que cuando se de agregar no se pierda la informacion ya ingresada

                mSalvarDatosGrilla();
                lstFact = (List<EOrdenCompraFactura>)SalvarDatos;

                //lstAsigHorario = (List<AsignacionHorarioEnt>)(Session["SeslstSalvaDatos"]);
                //añade un registro mas en blaco

                fact.Nu_secuen = str.PadLeft(3, '0');
                fact.Id_docucom = "001";
                fact.Nu_docum = "";
                fact.Fe_docum = Convert.ToDateTime(null);
                fact.Mt_docum = Convert.ToDecimal("0.000");
                fact.ds_observa = "";
                
                // muestra el item en blanco

                lstFact.Add(fact);

                dgvDetalle.DataSource = lstFact;

            }
            else
            {
                // Añande el primer item en blando de la grilla
                fact.Nu_secuen = "001";
                fact.Id_docucom = "001";
                fact.Nu_docum = "";
                fact.Fe_docum = Convert.ToDateTime(null);
                fact.Mt_docum = Convert.ToDecimal("0.000");
                fact.ds_observa = "";
                lstFact.Add(fact);

                //Muestra la grilla con un fila en blanco 

                dgvDetalle.DataSource = lstFact;

                //dgProducto.DataBind();


            }
        }

        private void cmdAñadirRow_Click(object sender, EventArgs e)
        {
            NuevoItem();
        }

        private void cmdEliminarRow_Click(object sender, EventArgs e)
        {
            mSalvarDatosGrilla();

            var LblNum_Secuen = dgvDetalle.CurrentRow.Cells["Item"].Value;

            //lblIdProducto = hddCodigo.Value;

            EOrdenCompraFactura doc = new EOrdenCompraFactura();
            doc.Id_empresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion
            doc.Id_periodo = wfChgEmpPer.datos.idperiodo; // llenar con sesion
            doc.Id_ordenco = txtOc.Text;
            doc.Nu_secuen = LblNum_Secuen.ToString();
            doc.Id_uupdarec = frmLogin.d.id;  //llenar con sesion
            BOrdenCompraFactura.OrderCompraFact_mnt02(doc);
          
          

            //--------------------------------------------/
           
            //int fila = e.RowIndex;
            int u = dgvDetalle.CurrentCell.RowIndex;
            List<EOrdenCompraFactura> lsListadoActual = (List<EOrdenCompraFactura>)SalvarDatos;

            lsListadoActual.RemoveAt(u);
            SalvarDatos = lsListadoActual;
            //BOrdenCompraFactura.OrderCompraFact_mnt02(lsListadoActual);
            dgvDetalle.DataSource = lsListadoActual;

            getCalculo();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                EOrdenCompraFactura ocf = new EOrdenCompraFactura();

                //------------------------Detalle de compra Factura----------------------------------------------------    

                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {
                    //prodxUnd.Id_producto = txtidProducto.Text;

                    var lblItem = dgvDetalle.Rows[i].Cells["Item"].Value;
                    var LbltipDoc = dgvDetalle.Rows[i].Cells["TipDoc"].Value;
                    var LblDocumento = dgvDetalle.Rows[i].Cells["nuDocumento"].Value;
                    var LblfeDocumento = dgvDetalle.Rows[i].Cells["fecDocumento"].Value;
                    var LblTotal = dgvDetalle.Rows[i].Cells["Total"].Value;

                    ocf.Id_periodo = wfChgEmpPer.datos.idperiodo;//llenar con sesion
                    ocf.Id_ordenco = txtOc.Text;

                    ocf.Nu_secuen = lblItem.ToString();
                    ocf.Id_docucom = LbltipDoc.ToString();
                    ocf.Nu_docum = LblDocumento.ToString();
                    ocf.Mt_docum = Convert.ToDecimal(LblTotal);

                    
                    ocf.Fe_docum =  Convert.ToDateTime(LblfeDocumento.ToString());

                    ocf.Id_ucrearec = frmLogin.d.id; //LLENAR DESDE LA SESION
                    ocf.Id_uupdarec = frmLogin.d.id; //LLENAR DESDE LA SESION
                    ocf.St_anulado = "0";
                    ocf.Id_empresa = wfChgEmpPer.datos.idEmpresa;  //LLENAR DESDE LA SESION
                    BOrdenCompraFactura.OrderCompraFact_mnt01(ocf);

                    lblmensaje.Text = "Factura Grabada";

                }
                MessageBox.Show("Datos grabados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //getCalculo();
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error de ingreso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }




        protected void getCalculo()
        {

            decimal total = 0;
            foreach (DataGridViewRow row in dgvDetalle.Rows)
             {

                //TextBox _SubTotal = dgvDetalle.Rows[x].Cells["Total"].Value as TextBox;
                 total += Convert.ToDecimal(row.Cells["Total"].Value);
              
            }

            txtDetTotal.Text = Convert.ToString(total);
            txtDetTotal.Text = decimal.Parse(txtDetTotal.Text).ToString("#,#.00");
        }
        string fecha;

        protected void getValidarFecha()
        {
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {

                //TextBox _SubTotal = dgvDetalle.Rows[x].Cells["Total"].Value as TextBox;
                fecha += (row.Cells["fecDocumento"].Value);


                string[] format = new string[] { "dd/mm/yyyy" };
                //string value = "2011-09-02 15:30:20";
                DateTime datetime;
                if (DateTime.TryParseExact(fecha, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.NoCurrentDateDefault, out datetime))
                { //Console.WriteLine("Valido  : " + datetime);
                }   //MessageBox.Show("Valido  : " + datetime);
                else
                {
                    MessageBox.Show("Invalido ");
                }
            }

        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getCalculo();
       
        }

        private void dgvDetalle_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.IsCurrentRowDirty)
            {
                dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        bool notlastColumn = true;

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.ColumnCount == e.ColumnIndex)
            {
                KeyEventArgs forKeyDown = new KeyEventArgs(Keys.Enter);
                notlastColumn = false;
                dgvDetalle_KeyDown(dgvDetalle, forKeyDown);
            }
            else
            {
                //SendKeys.Send("{up}");
                SendKeys.Send("{right}");
            }

            getCalculo();


        }

        private void txtOc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                mCargarDatos();
            }
        }

        public object GetDataReport(string key)
        {

            EParOCFillrpt objE = new EParOCFillrpt();

            objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            objE.IdOrdenCompra = txtOc.Text;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion

            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.OrderCompra_rpt02(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintReport("");
        }

        public void PrintReport(string key)
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
                crDiskFileDestinationOption.DiskFileName = strfolder + txtOc.Text + ".pdf";
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
                    int ncopy = this.printDocument1.PrinterSettings.Copies;
                    int npage = this.printDocument1.PrinterSettings.FromPage;
                    int epage = this.printDocument1.PrinterSettings.ToPage;
                    string PrinterName = this.printDocument1.PrinterSettings.PrinterName;
                    objRpt.PrintOptions.PrinterName = PrinterName;
                    objRpt.PrintToPrinter(ncopy, false, npage, epage);
                }
            }
            catch (Exception ex)
            {

            }

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
                crDiskFileDestinationOption.DiskFileName = strfolder + txtOc.Text + ".pdf";


                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                objRpt.Export();

            }
            catch (Exception ex)
            {

            }

        }

        private void dgvDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvDetalle.Columns[e.ColumnIndex].Name == "fecDocumento")
            {
                ShortFormDateFormat(e);
            }

        }

        private static void ShortFormDateFormat( DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("dd-MM-yyyy");
                    formatting.Value = dateString;
                    formatting.FormattingApplied = true;

                    //TextBox _SubTotal = dgvDetalle.Rows[x].Cells["Total"].Value as TextBox;
                }
                catch (FormatException)
                {
                    // Set to false in case there are other handlers interested trying to
                    // format this DataGridViewCellFormattingEventArgs instance.
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void txtOc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmOrdenCompra_qry frmoc = new FrmOrdenCompra_qry();
                frmoc.pasard += new FrmOrdenCompra_qry.pasar(EjecutarOC);
                frmoc.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(groupBox1);
            NuevoItem2();
        }


        private void Limpiar(GroupBox grupo)
        {
            //txtnu_oc.Text = "";

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";

                    lblmensaje.Text = "";
                  

                }
            }
        }


        private void NuevoItem2()
        {
            List<EOrdenCompraFactura> lstFact = new List<EOrdenCompraFactura>();

            EOrdenCompraFactura fact = new EOrdenCompraFactura();

            //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
            string str = Convert.ToString(dgvDetalle.Rows.Count + 1);

           
                // Añande el primer item en blando de la grilla
                fact.Nu_secuen = "001";
                fact.Id_docucom = "001";
                fact.Nu_docum = "";
                fact.Fe_docum = Convert.ToDateTime(null); 
                fact.Mt_docum = Convert.ToDecimal("0.000");
                fact.ds_observa = "";
                lstFact.Add(fact);

                btnAprobar.Enabled = false;
                btnAutorizar.Enabled = false;
                lblStAprobado.Text = "";
                lblStAutorizado.Text = "";
                //Muestra la grilla con un fila en blanco 

                dgvDetalle.DataSource = lstFact;

                //dgProducto.DataBind();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFactura_mnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmFactura_mnt_Resize(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void dgvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && notlastColumn) //if not last column move to nex
            {
                
                //SendKeys.Send("{up}");
                SendKeys.Send("{right}");
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{home}");//go to first column
                notlastColumn = true;
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            VistaPrevia("");
            FrmVistaPrevia frm = new FrmVistaPrevia();

            frm.nuOc = txtOc.Text;

            frm.ShowDialog();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            Autorizar();
            btnAprobar.Enabled = true;
            btnAutorizar.Enabled = false;
        }

        private void Autorizar()
        {
           

                    
                        EOrdenCompra eoc = new EOrdenCompra();

                        //la entidad obtine los siguientes valores a almacenar

                        eoc.psin_typeupd = "10";

                        eoc.Id_ordenco = txtOc.Text;
                            
                        eoc.Id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.Autorizado;

                        eoc.Id_uupdarec = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt01(eoc);
               
               
                MessageBox.Show("Los datos fueron autorizados correctamente", "Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
         

        }



        private void Aprobar()
        {
            //------------------------------

                        EOrdenCompra eoc = new EOrdenCompra();

                        //la entidad obtine los siguientes valores a almacenar

                        eoc.psin_typeupd = "11";

                        eoc.Id_ordenco = txtOc.Text;

                        eoc.Id_aprueba = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.Autorizado;

                        eoc.Id_uupdarec = frmLogin.d.id; //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt02(eoc);
                  
              
                MessageBox.Show("Los datos fueron Aprobados correctamente", "Aprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Aprobar();
            btnAprobar.Enabled = false;
        }



    

     

       
    }
}
