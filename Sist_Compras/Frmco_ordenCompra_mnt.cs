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
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Co;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
namespace Sist_Compras
{
    public partial class Frmco_ordenCompra_mnt : Form
    {
        public Frmco_ordenCompra_mnt()
        {
            InitializeComponent();
            DeshabilitarTexto(groupBox2);
         

        }

        int ancho, alto;
        private void DeshabilitarTexto(GroupBox grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is  TextBox)
                {
                    c.Enabled = false;
                }
                if (c is ComboBox)
                {
                    c.Enabled = false;
                }
            }

        }

        private void HabilitarTexto(GroupBox grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                }
                if (c is ComboBox)
                {
                    c.Enabled = true;
                }

            }
        }

        

        private void btnProv_Click(object sender, EventArgs e)
        {
          frmcoproveedor_qry frmp  = new frmcoproveedor_qry();
            frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
            frmp.ShowDialog();
            txtIdProv.Focus();
        }

        public void ejecutarProv(EProveedor prov)
        {
            txtIdProv.Text = prov.Id_clipro;
            txtDsprov.Text = prov.Ds_raznombre;
        }

        public void ejecutarPers(string idPers, string dsPers)
        {
            txtIdPedido.Text = idPers;
            lblPedidoPor.Text = dsPers;
        }

        private void btnPedidoPor_Click(object sender, EventArgs e)
        {
            Frmpersonal_qry frmps = new Frmpersonal_qry();
            frmps.pasard += new Frmpersonal_qry.pasar(ejecutarPers);
            frmps.ShowDialog();
            txtIdPedido.Focus();
        }

        private void btnEmitidoPor_Click(object sender, EventArgs e)
        {
            Frmpersonal_qry frmps = new Frmpersonal_qry();
            frmps.ShowDialog();
        }

        private void btnCondPago_Click(object sender, EventArgs e)
        {
            Frmcocondicionpago_qry frmcp = new Frmcocondicionpago_qry();
            frmcp.pasard += new Frmcocondicionpago_qry.pasar(ejecutarCondpago);
            frmcp.ShowDialog();
            txtCondPago.Focus();
        }

        public void ejecutarCondpago(string idCondpago, string dsCondpago)
        {
            txtCondPago.Text = idCondpago;
            lblcondpago.Text = dsCondpago;

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Frmimportacion_qry frmimp = new Frmimportacion_qry();
            frmimp.pasard += new Frmimportacion_qry.pasar(ejecutarImp);
            frmimp.ShowDialog();
            txtimport.Focus();
        }


        public void ejecutarImp(EImportacion Imp)
        {
            txtimport.Text = Imp.Id_importa;
            lblimportacion.Text = Imp.Ds_importa;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            FrmExportacion_qry frmexport = new FrmExportacion_qry();
            frmexport.pasard += new FrmExportacion_qry.pasar(ejecutarExpo);
            frmexport.ShowDialog();
            txtExport.Focus();
        }

        public void ejecutarExpo(Eexportacion exp)
        {
            txtExport.Text = exp.Id_Exporta;
            lblexportacion.Text = exp.Ds_Exporta;
        }

        private void txtIdProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtIdProv.Text = txtIdProv.Text.PadLeft(6, '0');
          
                EProveedor per = new EProveedor();
                per.psintypesel = 1;
                per.Ds_raznombre = "";
                per.Id_clipro = txtIdProv.Text;
                per.Nu_ruc = txtnu_oc.Text;
                per.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                    
              
                
                List<Dato> oListDato = BProveedor.ObtenerDatoProveedor(per);
                if (oListDato.Count > 0)
                {
                    txtDsprov.Text = oListDato[0].desc;
                }


                txtEntregaEn.Focus();
            }
        }

        private void txtEntregaEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEntregaEn.Text = txtEntregaEn.Text.PadLeft(2, '0');
                cbEntregaEn.SelectedValue = txtEntregaEn.Text;

                txtIdPedido.Focus();
            }
        }

        private void txtIdPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == Convert.ToChar(Keys.Enter))
            
          {
              txtIdPedido.Text = txtIdPedido.Text.PadLeft(5, '0');
                EPersonalBandeja per = new EPersonalBandeja();
                per.psintypesel = 1;
                per.IdPersonal = txtIdPedido.Text;
                per.NuDocIden = "";
                per.DsApellNom = "";
                ComboBox cb = new ComboBox();
               
               List<Dato> oListDato = BPersonalBandeja.ObtenerDatoPersonal(per);
               if (oListDato.Count > 0) {

                   
                   lblPedidoPor.Text = oListDato[0].desc;

               }
             
              
               
                txtUsadoEn.Focus();

            } 
        }

        private void txtUsadoEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUsadoEn.Text = txtUsadoEn.Text.PadLeft(2, '0');

                cbUsadoEn.SelectedValue = txtUsadoEn.Text;
                txtEmitidoPor.Focus();
            }  
        }

        private void txtEmitidoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                               txtPrioridad.Focus();
            }  
        }

        private void txtPrioridad_KeyPress(object sender, KeyPressEventArgs e)
        { if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrioridad.Text = txtPrioridad.Text.PadLeft(3, '0');
                cbPrioridad.SelectedValue = txtPrioridad.Text;
                txtObserv.Focus();
            } 
            
        }

        private void txtObserv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCondPago.Focus();
            } 
            
        }

        private void txtCondPago_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                 txtCondPago.Text=txtCondPago.Text.PadLeft(4,'0');
                ECondicionPago per = new ECondicionPago();
                per.psintypesel = 1;
                per.Ds_condpago = "";
                per.Id_condpago = txtCondPago.Text;

                ComboBox cb = new ComboBox();
           
                List<Dato> oListDato = BCondicionPago.ObtenerDatoFormaPago(per);
                if (oListDato.Count > 0)
                {
                    lblcondpago.Text = oListDato[0].desc;
                }
               


                txtTipo.Focus();
            }  
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTipo.Text = txtTipo.Text.PadLeft(3, '0');
                cbTipo.SelectedValue = txtTipo.Text;
                txtModalidad.Focus();
            }  
        }

        private void txtimport_KeyPress(object sender, KeyPressEventArgs e)
        {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

               
                    //txtIdProv.Text = txtIdProv.Text.PadLeft(6, '0');

                    //EProveedor per = new EProveedor();
                    //per.psintypesel = 1;
                    //per.Ds_raznombre = "";
                    //per.Id_clipro = txtIdProv.Text;
                    //per.Nu_ruc = txtnu_oc.Text;
                    //per.Id_empresa = wfChgEmpPer.datos.idEmpresa;



                 

                    EImportacion imp = new EImportacion();
                    imp.psintypesel = 2;
                    imp.Id_importa = txtimport.Text;
                    imp.Ds_importa = "";
                    imp.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    List<Dato> oListDato = BImportacion.ObtenerDatoImportacion(imp);
                    if (oListDato.Count > 0)
                    {
                        lblimportacion.Text = oListDato[0].desc;
                    }
                    else
                    {
                        lblimportacion.Text = "";
                    }


                   


            


             
             txtMoneda.Focus();



            }  
        }


        private void ValidarModalidad()
        {
            try
            {
                if ((cbModalidad.SelectedValue.ToString() == "001") || (txtModalidad.Text == "001"))
                {
                    //compra local
                    txtimport.Text = "000000";
                    txtExport.Text = "000000";
                    txtimport.Enabled = false;
                    txtExport.Enabled = false;
                    lblexportacion.Text = "";
                    lblimportacion.Text = "";
                    txtMoneda.Focus();

                }
                else if ((cbModalidad.SelectedValue.ToString() == "002") || (txtModalidad.Text == "002"))
                {
                    ///inportacion 

                    txtExport.Text = "000000";
                    txtimport.Text = "000000";
                    txtimport.Enabled = true;
                    txtExport.Enabled = false;
                    lblexportacion.Text = "";

                    txtimport.Focus();

                }
                else if ((cbModalidad.SelectedValue.ToString() == "004") || (txtModalidad.Text == "002"))
                {
                    //exportacion 
                    txtExport.Text = "000000";
                    txtimport.Text = "000000";
                    txtimport.Enabled = false;
                    txtExport.Enabled = true;
                    lblimportacion.Text = "";
                    txtExport.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falta Ingresar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               
                txtModalidad.Text = txtModalidad.Text.PadLeft(3,'0');
                cbModalidad.SelectedValue = txtModalidad.Text;

                ValidarModalidad();
                //txtModalidad.Focus();
               
            }  
        }

        private void txtExport_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Eexportacion exp = new Eexportacion();
                exp.psintypesel = 2;
                exp.Id_Exporta = txtExport.Text;
                exp.Ds_Exporta = "";
                exp.Id_Empresa = wfChgEmpPer.datos.idEmpresa;

                
                List<Dato> oListDato = BExportacion.ObtenerDatoExport(exp);
                if (oListDato.Count > 0)
                {
                    lblexportacion.Text = oListDato[0].desc;
                }
                else
                {
                    lblexportacion.Text = "";
                }


                txtMoneda.Focus();
            } 
            
        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoneda.Text = txtMoneda.Text.PadLeft(3, '0');

                cbMoneda.SelectedValue = txtMoneda.Text;
                txtFechaEntrega.Focus();
            } 
            
        }

        private void Frmco_ordenCompra_mnt_Load(object sender, EventArgs e)
        {


            //ancho = this.Width;
            //alto = this.Height;

           //programacion escritorio
            WebHelper.LoadListControl3(cbEntregaEn, BGeneral.ObtenerDatoLocal());
            WebHelper.LoadListControl3(cbUsadoEn, BGeneral.ObtenerDatoLocal());
            WebHelper.LoadListControl3(cbTipo, BGeneral.ObtenerDatoidTabla("123"));
            WebHelper.LoadListControl3(cbModalidad, BGeneral.ObtenerDatoidTabla("127"));
            WebHelper.LoadListControl3(cbMoneda, BGeneral.ObtenerDatoidTabla("016"));
            WebHelper.LoadListControl3(cbPrioridad, BGeneral.ObtenerDatoidTabla("027"));

    
            //web
            //WebHelper.LoadListControl3(cbTipo, BTablaGeneral.TablaGeneralFill("123"), "ds_item", "id_item");         
            //WebHelper.LoadListControl3(cbModalidad, BTablaGeneral.TablaGeneralFill("127"), "ds_item", "id_item");
            //WebHelper.LoadListControl3(cbMoneda, BTablaGeneral.TablaGeneralFill("016"), "ds_item", "id_item");
            //WebHelper.LoadListControl3(cbPeriodo, BTablaGeneral.TablaGeneralFill("027"), "ds_item", "id_item");



        }

        private void cbEntregaEn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtEntregaEn.Text = Convert.ToString(cbEntregaEn.SelectedValue);
            txtEntregaEn.Focus();
        }

        private void cbUsadoEn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtUsadoEn.Text = Convert.ToString(cbUsadoEn.SelectedValue);
            txtUsadoEn.Focus();
        }

        private void cbPrioridad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPrioridad.Text = Convert.ToString(cbPrioridad.SelectedValue);
            txtPrioridad.Focus();
        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTipo.Text = Convert.ToString(cbTipo.SelectedValue);
            txtTipo.Focus();

        }

        private void cbModalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtModalidad.Text = Convert.ToString(cbModalidad.SelectedValue);
            if((cbModalidad.SelectedValue.ToString() == "001") || (txtModalidad.Text=="001") )
            {
                //compra local
                txtimport.Text = "000000";
                txtExport.Text = "000000";

                lblexportacion.Text = "";
                lblimportacion.Text = "";

                txtimport.Enabled = false;
                txtExport.Enabled = false;
                txtMoneda.Focus();
            }
            else if ((cbModalidad.SelectedValue.ToString() == "002") || (txtModalidad.Text=="002"))
            {
                ///inportacion 

                txtExport.Text = "000000";
                txtimport.Text = "000000";
                lblexportacion.Text = "";
                lblimportacion.Text = "";

                txtimport.Enabled = true;
                txtExport.Enabled = false;

                txtimport.Focus();
            }
            else if ((cbModalidad.SelectedValue.ToString() == "004") || (txtModalidad.Text=="002"))
            {
                //exportacion 
                txtExport.Text = "000000";
                txtimport.Text = "000000";
                lblexportacion.Text = "";
                lblimportacion.Text = "";
                txtimport.Enabled = false;
                txtExport.Enabled = true;
                txtExport.Focus();
      
            }

            //txtModalidad.Focus();
        }

        private void cbMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtMoneda.Text = Convert.ToString(cbMoneda.SelectedValue);
            txtMoneda.Focus();

        }

        Decimal mtDesc;
        decimal mtIgv = 0;
        int n = 0;
        protected void mCalculaTotal()
        {
            try
            {

              decimal imp=0;
              decimal deSuma = 0;
              decimal deTot =0;
              decimal detIgv=0;
              decimal detDesc=0;
              decimal total=0;
              decimal subtotal=0;
              
                EDTipImpuesto dti = new EDTipImpuesto();
                dti.IdPeriodo = wfChgEmpPer.datos.idperiodo;

                List<Dato> oListDato = BDeTipImpuesto.ObtenerImpuesto(dti);
                if (oListDato.Count > 0)
                {
                   imp = Convert.ToDecimal(oListDato[0].desc);
                }
        
                string stigv;

                for (int x = 0; x < dgvDetalle.Rows.Count; x++)
                {
                      

                   stigv = (dgvDetalle.Rows[x].Cells["chkIgv"].Value).ToString();
                   decimal PorcDesc = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtPorDesc"].Value);
                   decimal txtCant = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtCantidad"].Value);
                   decimal txtPU = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtPU"].Value);
                 
                if (stigv.ToString() == "False")
                 {
                     if (PorcDesc.ToString() == "0.0000")
                       {
                         deSuma = (txtCant) * (txtPU);
                         (dgvDetalle.Rows[x].Cells["txtSubTotal"]).Value = deSuma.ToString();
                         (dgvDetalle.Rows[x].Cells["txtDscto"]).Value = "0.0000";

                        }
                        else
                        {
                            deSuma = (txtCant) * (txtPU);
                            (dgvDetalle.Rows[x].Cells["txtSubTotal"]).Value = deSuma.ToString("#,#.0000");
                             mtDesc = ((PorcDesc / 100) * deSuma);
                             (dgvDetalle.Rows[x].Cells["txtDscto"]).Value = mtDesc.ToString("#,#.0000");
                        }


        //                ((TextBox)GVDetalleProducto.Rows[x].FindControl("txtSubTotal")).Text = deSuma.ToString();
        //                ((TextBox)GVDetalleProducto.Rows[x].FindControl("txtIGV")).Text = "0.0000";
        //                mtDesc = (Convert.ToDecimal(PorcDesc.Text) / 100) * Convert.ToDecimal(txtSubTotal_.Text);
        //                ((TextBox)GVDetalleProducto.Rows[x].FindControl("txtDscto")).Text = mtDesc.ToString();
                   }
                else
                   {
                        if (PorcDesc.ToString() == "0.0000")
                        {
                         deSuma = (txtCant) * (txtPU);
                         (dgvDetalle.Rows[x].Cells["txtSubTotal"]).Value = deSuma.ToString();
                         mtIgv = imp * deSuma;
                         (dgvDetalle.Rows[x].Cells["txtIGV"]).Value = mtIgv.ToString();
                         (dgvDetalle.Rows[x].Cells["txtDscto"]).Value = "0.0000";
                        }
                        else
                        {
                         deSuma = (txtCant) * (txtPU);
                         (dgvDetalle.Rows[x].Cells["txtSubTotal"]).Value = deSuma.ToString();
                         mtDesc = (PorcDesc / 100) * (deSuma);
                         (dgvDetalle.Rows[x].Cells["txtDscto"]).Value = mtDesc.ToString();
                         mtIgv = ((deSuma) - mtDesc) * imp;
                        (dgvDetalle.Rows[x].Cells["txtIGV"]).Value = mtIgv.ToString();
                        }
                     }

                decimal txtigv = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtIGV"].Value);
                decimal txtDesc = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtDscto"].Value);
                decimal txtSubTotal_ = Convert.ToDecimal(dgvDetalle.Rows[x].Cells["txtSubTotal"].Value);
            
                deTot = deTot + deSuma;
                detDesc = detDesc + txtDesc;
                detIgv = detIgv + (txtigv);
                txtTotDesc_.Text = string.Format("{0:##,##0.0000}", detDesc);
                txtTotIgv_.Text = string.Format("{0:##,##0.0000}",detIgv);
                total = (deTot - detDesc) + detIgv;
                subtotal =  subtotal + txtSubTotal_;
                txtsubTotal_.Text = string.Format("{0:##,##0.0000}",subtotal);
                txtTotal.Text = string.Format("{0:##,##0.0000}",total);
      

           }  
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void ModGuilla(EDetProducto objProd, object form)
        {

            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtIdproducto"]).Value = objProd._Codigo.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtDsProducto"]).Value = objProd._Producto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtPresentacion"]).Value = objProd._Presenta.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtUM"]).Value = objProd._UM.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtCantidad"]).Value = objProd._Cant.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtPU"]).Value = objProd._PreUnit.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtPorDesc"]).Value = objProd._nu_pordscto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtDscto"]).Value = objProd._Dscto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtIGV"]).Value = objProd._Igv.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtSubTotal"]).Value = objProd._subTotal.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["dpdOP"]).Value = objProd._OP.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtidUn"]).Value = objProd._id_Gasto.Trim().ToString();

            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtdsUn"]).Value = objProd._C_Gasto.Trim().ToString();

            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtIdccostos"]).Value = objProd._idCosto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtdsCosto"]).Value = objProd._C_Costos.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtidtipoGasto"]).Value = objProd._Tipgasto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtdsTipoGasto"]).Value = objProd._dstg.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["dpTG"]).Value = objProd._idclase.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["chkIgv"]).Value = objProd._igvActivo.ToString();

            (dgvDetalle.Rows[int.Parse(_drow)].Cells["Clase"]).Value = objProd._clase.ToString();
          
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtIdPres"]).Value = objProd._Pres.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtDescrip"]).Value = objProd._detalle.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtPneto"]).Value = objProd._PreNeto.ToString();
            (dgvDetalle.Rows[int.Parse(_drow)].Cells["txtPesoBruto"]).Value = objProd._Peso_Bruto.ToString();


            mCalculaTotal();

            Frmco_modaloc_qry frmPopup = (Frmco_modaloc_qry)form;
            frmPopup.Close();
      

        }

        public void LlenarGrilla(EDetProducto objProd, object form)
        {
            string str = Convert.ToString(dgvDetalle.Rows.Count + 1);
            string[] row = { objProd._Nu_Correla=str.PadLeft(3, '0'),
                             objProd._Codigo,
                             objProd._Producto,
                             objProd._Presenta,
                             objProd._UM,
                             objProd._Cant.ToString(),
                             objProd._PreUnit.ToString(),
                             objProd._nu_pordscto.ToString(),
                             objProd._Dscto.ToString(),
                             objProd._Igv.ToString(),
                             objProd._subTotal.ToString(),
                             objProd._OP,
                             objProd._id_Gasto,
                             objProd._C_Gasto,
                             objProd._idCosto,
                             objProd._C_Costos,
                             objProd._Tipgasto,
                             objProd._dstg,
                             objProd._clase,
                             objProd._igvActivo.ToString(),
                             objProd._idclase,
                             objProd._Pres,
                             objProd._detalle,
                             objProd._PreNeto.ToString(),
                             objProd._Peso_Bruto.ToString(),
                             objProd._Lote,
                             //objProd._fe_venc,
                             //objProd._fe_Entrega,
                             
                             
                            
                             
                           };
            dgvDetalle.Rows.Add(row);
            mCalculaTotal();

            Frmco_modaloc_qry frmPopup = (Frmco_modaloc_qry)form;
            frmPopup.Close();


            
        }

 
        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            try
            {

                Frmco_modaloc_qry frmps = new Frmco_modaloc_qry();
                frmps.FormParent = this;
                //frmps.pasard += new Frmco_modaloc_qry.pasar(ejecutarproducto);
                frmps.ShowDialog();
                //txtIdPedido.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ////limpiarDetalle();

        }
    
        string _drow;

        private void dgvDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dg = (DataGridView)sender;
            //DataGridViewRow dRow = dg.Rows[e.RowIndex];
            try
            {
            DataGridViewRow dRow = dgvDetalle.Rows[e.RowIndex];
            _drow = dRow.Index.ToString();

            //MessageBox.Show(dRow.Index.ToString());
            if (dRow.Cells["txtIdproducto"].Value == null) return;

            EDetProducto objProd = new EDetProducto();
            objProd._Codigo = (dRow.Cells["txtIdproducto"].Value == null) ? "" : dRow.Cells["txtIdproducto"].Value.ToString();
            objProd._Producto = (dRow.Cells["txtDsProducto"].Value == null) ? "" : dRow.Cells["txtDsProducto"].Value.ToString();
            objProd._Presenta = (dRow.Cells["txtPresentacion"].Value == null) ? "" : dRow.Cells["txtPresentacion"].Value.ToString();
            objProd._UM = (dRow.Cells["txtUM"].Value == null) ? "" : dRow.Cells["txtUM"].Value.ToString();

            objProd._Cant = (dRow.Cells["txtCantidad"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtCantidad"].Value);
            objProd._PreUnit = (dRow.Cells["txtPU"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtPU"].Value.ToString());
            objProd._nu_pordscto = (dRow.Cells["txtPorDesc"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtPorDesc"].Value.ToString());
            objProd._Dscto = (dRow.Cells["txtDscto"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtDscto"].Value.ToString());
            objProd._Igv = (dRow.Cells["txtIGV"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtIGV"].Value.ToString());
            objProd._subTotal = (dRow.Cells["txtSubTotal"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtSubTotal"].Value.ToString());
            objProd._OP = (dRow.Cells["dpdOP"].Value == null) ? "" : dRow.Cells["dpdOP"].Value.ToString();
            objProd._id_Gasto = (dRow.Cells["txtidUn"].Value == null) ? "" : dRow.Cells["txtidUn"].Value.ToString();
            objProd._idCosto = (dRow.Cells["txtIdccostos"].Value == null) ? "" : dRow.Cells["txtIdccostos"].Value.ToString();
            objProd._C_Costos = (dRow.Cells["txtdsCosto"].Value == null) ? "" : dRow.Cells["txtdsCosto"].Value.ToString();
            objProd._Tipgasto = (dRow.Cells["txtidtipoGasto"].Value == null) ? "" : dRow.Cells["txtidtipoGasto"].Value.ToString();
            objProd._dstg = (dRow.Cells["txtdsTipoGasto"].Value == null) ? "" : dRow.Cells["txtdsTipoGasto"].Value.ToString();
            objProd._clase = (dRow.Cells["Clase"].Value == null) ? "" : dRow.Cells["Clase"].Value.ToString();
            string chkCell = dRow.Cells["chkIgv"].Value.ToString();
            objProd._igvActivo = Convert.ToBoolean(chkCell);
            objProd._idclase = (dRow.Cells["dpTG"].Value == null) ? "" : dRow.Cells["dpTG"].Value.ToString();
            objProd._Pres = (dRow.Cells["txtIdPres"].Value == null) ? "" : dRow.Cells["txtIdPres"].Value.ToString();
            objProd._detalle = (dRow.Cells["txtDescrip"].Value == null) ? "" : dRow.Cells["txtDescrip"].Value.ToString();
            objProd._PreNeto = (dRow.Cells["txtPneto"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtPneto"].Value.ToString());

            objProd._Peso_Bruto = (dRow.Cells["txtPesoBruto"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["txtPesoBruto"].Value.ToString());

            objProd._Lote = "1";
            Frmco_modaloc_qry frmpop = new Frmco_modaloc_qry();
            frmpop.FormParent = this;
            frmpop.LLenarCampos(objProd);
            frmpop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }



        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    mCalculaTotal();

                    EOrdenCompra oc = new EOrdenCompra();
                    EDetOrdenCompra doc = new EDetOrdenCompra();

                    if (txtnu_oc.Text == "")
                    {
                        List<Dato> oListDato = BOrdenCompra.OrderCompra_qry02_(wfChgEmpPer.datos.idperiodo, wfChgEmpPer.datos.idEmpresa);
                        if (oListDato.Count > 0)
                        {
                            txtnu_oc.Text = oListDato[0].id;
                        }

                        oc.Id_ordenco = txtnu_oc.Text;
                        doc.Id_ordenco = txtnu_oc.Text;
                    }
                    else
                    {
                        oc.Id_ordenco = txtnu_oc.Text;
                        doc.Id_ordenco = txtnu_oc.Text;
                    }

                    oc.Id_periodo = wfChgEmpPer.datos.idperiodo;//llenar con sesion
                    oc.Id_importa = txtimport.Text;
                    oc.Id_Exporta = txtExport.Text;
                    oc.Id_cotiza = "000000";
                    oc.Fe_ordenco = txtFechaOc.Text;
                    oc.Fe_entrega = txtFechaEntrega.Text;
                    oc.Id_docucom = "";
                    oc.Nu_docu = "";
                    oc.Id_clipro = txtIdProv.Text;
                    oc.Id_clipro2 = txtIdProv.Text;
                    oc.Id_clipro3 = txtIdProv.Text;
                    oc.Id_condpago = txtCondPago.Text;
                    oc.Id_personal = txtIdPedido.Text;
                    oc.Id_local = cbEntregaEn.SelectedValue.ToString();
                    oc.Id_local2 = cbUsadoEn.SelectedValue.ToString();
                    oc.Id_personal2 = txtEmitidoPor.Text;

                    oc.Ds_observa = txtObserv.Text.ToUpper();
                    oc.Id_vmoneda = cbMoneda.SelectedValue.ToString();
                    oc.Mt_total = Convert.ToDecimal(txtTotal.Text);
                    oc.Id_modcomp = cbModalidad.SelectedValue.ToString();
                    oc.Id_tipcomp = cbTipo.SelectedValue.ToString();
                    oc.Id_prioridad = cbPrioridad.SelectedValue.ToString();
                    oc.Id_aprueba = "";
                    oc.St_aprueba = "T";
                    oc.Id_autoriza = "";
                    oc.St_ordenco = "T";
                    oc.Id_ucrearec =  frmLogin.d.id.ToLower();//LLENAR DESDE LA SESION
                    oc.Id_uupdarec = frmLogin.d.id.ToLower();//LLENAR DESDE LA SESION
                    oc.St_anulado = "0";
                    oc.idEmpresa = wfChgEmpPer.datos.idEmpresa; //LLENAR DESDE LA SESION
                    oc.stfactura = "ABIERTO";
                    BOrdenCompra.OrderCompra_mnt03(oc);


                    //---------------------------------
                    if (txtnu_oc.Text != "")
                    {
                        if (dgTemp.Rows.Count > 0)
                        {
                            for (int i = 0; dgTemp.Rows.Count > i; i++)
                            {

                                var lblnu_corre = dgTemp.Rows[i].Cells["nucorre"].Value;
                                var lbllote = dgTemp.Rows[i].Cells["lote"].Value;
                                var lblop = dgTemp.Rows[i].Cells["op"].Value;
                                var lblidproducto = dgTemp.Rows[i].Cells["idproducto"].Value;
                                var lblidpres = dgTemp.Rows[i].Cells["idpres"].Value;

                                EDetOrdenCompra doc_ = new EDetOrdenCompra();
                                doc_.Id_periodo = wfChgEmpPer.datos.idperiodo;
                                doc_.Id_op = lblop.ToString();
                                doc_.Id_ordenco = txtnu_oc.Text;
                                doc_.Nu_correla = lblnu_corre.ToString();
                                doc_.Nu_lote = lbllote.ToString();
                                doc_.Id_producto = lblidproducto.ToString();
                                doc_.Id_prodprese = lblidpres.ToString();
                                doc_.idEmpresa = wfChgEmpPer.datos.idEmpresa;

                                BDetOrdenCompra.DetOrderCompra_mnt02(doc_);
                            }
                        }
                    }


                    ////------------------------Detalle de compras----------------------------------------------------  


                    for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                    {
                        
                        var LblNum_Correla = dgvDetalle.Rows[i].Cells["txtnu_correla"].Value;
                        var LblIdproducto = dgvDetalle.Rows[i].Cells["txtIdproducto"].Value;
                        var LblDsProducto = dgvDetalle.Rows[i].Cells["txtDsProducto"].Value;
                        var LblUM = dgvDetalle.Rows[i].Cells["txtUM"].Value;
                        var LblCantidad = dgvDetalle.Rows[i].Cells["txtCantidad"].Value;
                        var LblPU = dgvDetalle.Rows[i].Cells["txtPU"].Value;
                        var LblprodDscto = dgvDetalle.Rows[i].Cells["txtPorDesc"].Value;
                        var LblDscto = dgvDetalle.Rows[i].Cells["txtDscto"].Value;
                        var LblIGV = dgvDetalle.Rows[i].Cells["txtIGV"].Value;
                        var LblSubTotal = dgvDetalle.Rows[i].Cells["txtSubTotal"].Value;
                        var LblOP = dgvDetalle.Rows[i].Cells["dpdOP"].Value;
                        var LblUN = dgvDetalle.Rows[i].Cells["txtidUn"].Value;
                        var LblIdccostos = dgvDetalle.Rows[i].Cells["txtIdccostos"].Value;
                        var LblClase = dgvDetalle.Rows[i].Cells["dpTG"].Value;
                        var LblIdPres = dgvDetalle.Rows[i].Cells["txtIdPres"].Value;
                        var LblObsev = dgvDetalle.Rows[i].Cells["txtDescrip"].Value;
                        var LblPneto = dgvDetalle.Rows[i].Cells["txtPneto"].Value;
                        var LblPesoBruto = dgvDetalle.Rows[i].Cells["txtPesoBruto"].Value;                     
                        var LblTg = dgvDetalle.Rows[i].Cells["txtidtipoGasto"].Value;
                        var LbldsCosto = dgvDetalle.Rows[i].Cells["txtdsCosto"].Value;                    
                        doc.Id_periodo = wfChgEmpPer.datos.idperiodo;//llenar con sesion
                        doc.Id_op = LblOP.ToString();
                        doc.Id_ordenco = txtnu_oc.Text;
                        doc.Nu_correla = LblNum_Correla.ToString();
                        doc.Nu_lote = "1";
                        doc.Id_producto = LblIdproducto.ToString();
                        doc.Id_prodprese = LblIdPres.ToString();
                        doc.Qt_producto = Convert.ToDecimal(LblCantidad);
                        doc.Qt_difcierre = Convert.ToDecimal("0.0000");
                        doc.Id_vmoneda = cbMoneda.SelectedValue.ToString();
                        doc.Qt_pesobruto = Convert.ToDecimal(LblPesoBruto);
                        doc.Qt_pesoneto = Convert.ToDecimal(LblPneto);
                        doc.Mt_precuni = Convert.ToDecimal(LblPU);
                        doc.Mt_igv = Convert.ToDecimal(LblIGV);
                        doc.Mt_subtotal = Convert.ToDecimal(LblSubTotal);
                        doc.Nu_pordscto = Convert.ToDecimal(LblprodDscto);
                        doc.Mt_dscto = Convert.ToDecimal(LblDscto);
                        doc.Id_clase = LblClase.ToString();
                        doc.Id_tipogsto = LblTg.ToString();
                        doc.Id_ccosto = LblIdccostos.ToString();
                        doc.Id_cgasto = LblUN.ToString();
                        doc.Id_tipgstimp = "000";
                        doc.St_gastodist = "0";
                        doc.Id_ucrearec = frmLogin.d.id.ToLower(); //llenar con sesion
                        doc.Id_uupdarec = frmLogin.d.id.ToLower(); //llenar con sesion
                        doc.St_anulado = "0";
                        doc.idEmpresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion
                        doc._Detalle = LblObsev.ToString();
                        BDetOrdenCompra.DetOrderCompra_mnt01(doc);
                      
                    }
                    
                    //if (txtnu_oc.Text !=  "")
                    //{
                    //    if (dgTemp.Rows.Count > 0)
                    //    {
                    //        for (int i = 0; dgTemp.Rows.Count > i; i++)
                    //        {

                    //            var lblnu_corre = dgTemp.Rows[i].Cells["nucorre"].Value;
                    //            var lbllote = dgTemp.Rows[i].Cells["lote"].Value;
                    //            var lblop = dgTemp.Rows[i].Cells["op"].Value;
                    //            var lblidproducto = dgTemp.Rows[i].Cells["idproducto"].Value;
                    //            var lblidpres = dgTemp.Rows[i].Cells["idpres"].Value;

                    //            EDetOrdenCompra doc_ = new EDetOrdenCompra();
                    //            doc_.Id_periodo = wfChgEmpPer.datos.idperiodo;
                    //            doc_.Id_op = lblop.ToString();
                    //            doc_.Id_ordenco = txtnu_oc.Text;
                    //            doc_.Nu_correla = lblnu_corre.ToString();
                    //            doc_.Nu_lote = lbllote.ToString();
                    //            doc_.Id_producto = lblidproducto.ToString();
                    //            doc_.Id_prodprese = lblidpres.ToString();
                    //            doc_.idEmpresa = wfChgEmpPer.datos.idEmpresa;

                    //            BDetOrdenCompra.DetOrderCompra_mnt02(doc_);
                    //        }
                    //    }
                    //}


                    dgTemp.Rows.Clear();


                    MessageBox.Show(txtnu_oc.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(result == DialogResult.Cancel)
                {

                    

                }
   
            }
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var mod = cbModalidad.SelectedValue.ToString();
            var import = txtimport.Text;
            var export = txtExport.Text;
            var prio = cbPrioridad.SelectedValue.ToString();
            var prov = txtIdProv.Text;
            var entrep = txtEntregaEn.Text;
            var perso = txtIdPedido.Text;
            var usadoen = txtUsadoEn.Text;
            var perso2 = txtEmitidoPor.Text;
            
            var idpago = txtCondPago.Text;
            var tip = cbTipo.SelectedValue.ToString();
            var moneda = cbMoneda.SelectedValue.ToString();

            if ((mod != "") & (import != "") & (export != "") & (prio != "") & (prov != "") & (entrep != "") & (perso != "") & (perso2 != "") & (moneda != "") & (idpago != "") & (tip != ""))
            {
                Grabar();
            }
            else
            {
                MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }


        
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtnu_oc.Text = "";
            periodoOC = "";
            lblestado.Text = "(COPIA  ACTIVADA)";
        
            DateTime fecha = DateTime.Now;
            txtFechaOc.Text = fecha.ToString("d");
            txtFechaEntrega.Text = fecha.ToString("d");


            //DropDownList idOC = new DropDownList();
            List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
             if (oListUsu.Count >0)
             {
                 txtEmitidoPor.Text = oListUsu[0].id;
                 lblEmitidoPor.Text = oListUsu[0].desc;
             }
             lblNuDoc.Text = "";

             dgTemp.Rows.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra_qry frmoc = new FrmOrdenCompra_qry();
            frmoc.pasard += new FrmOrdenCompra_qry.pasar(EjecutarOC);
            frmoc.ShowDialog();

            //frmoc.Show();
 
        }

        string periodoOC="";
        public void EjecutarOC(EOrdenCompra oc)
        {
           txtBuscaroc.Text = oc.Id_ordenco;
           txtnu_oc.Text = oc.Id_ordenco;
           periodoOC =  oc.Id_periodo;

           BuscarOrdenCompra();
           txtBuscaroc.Focus();
        }

        private void Limpiar(GroupBox grupo)
         {
            //txtnu_oc.Text = "";

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtIdProv.Focus();

                }
            }
         }
        private void Nuevo()
        {

           Limpiar(groupBox2);
           Limpiar(groupBox3);

           HabilitarTexto(groupBox2);

           lblPedidoPor.Text = "";
           lblestado.Text = "";

           DateTime fecha = DateTime.Now;
           txtFechaOc.Text = fecha.ToString("d");
           txtFechaEntrega.Text = fecha.ToString("d");


            List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
            if (oListUsu.Count > 0)
            {
                txtEmitidoPor.Text = oListUsu[0].id;
                lblEmitidoPor.Text = oListUsu[0].desc;
            }

            txtFechaOc.Focus();

            txtEntregaEn.Text = cbEntregaEn.SelectedValue.ToString();
            txtUsadoEn.Text = cbUsadoEn.SelectedValue.ToString();
            txtPrioridad.Text = cbPrioridad.SelectedValue.ToString();
            txtTipo.Text = cbTipo.SelectedValue.ToString();
            txtModalidad.Text = cbModalidad.SelectedValue.ToString();
            txtMoneda.Text = cbMoneda.SelectedValue.ToString();
            ValidarModalidad();
        

            dgvDetalle.Rows.Clear();

            dgTemp.Rows.Clear();

            periodoOC = "";
            lblNuDoc.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }



        private void btnEliminarRow_Click(object sender, EventArgs e)
        {

                // almacena en variables los items que va recorriendo
            try
            {
                var LblOP = dgvDetalle.CurrentRow.Cells["dpdOP"].Value;
                var LblIdproducto = dgvDetalle.CurrentRow.Cells["txtIdproducto"].Value;
                var LblIdPres = dgvDetalle.CurrentRow.Cells["txtIdPres"].Value;

                var LblNum_Correla = dgvDetalle.CurrentRow.Cells["txtnu_correla"].Value;

                var LblLote = dgvDetalle.CurrentRow.Cells["nu_lote"].Value;


                if (LblLote.ToString() == "")
                {
                    LblLote = "1";
                }
                else
                {
                    LblLote = "1";
                }



                dgTemp.Rows.Add(LblNum_Correla.ToString(), LblLote.ToString(), LblOP.ToString(), LblIdproducto.ToString(), LblIdPres.ToString());
                
            }
            catch (Exception ex)
            {

            }

            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            mCalculaTotal();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintReport("");
        }

        public  object GetDataReport(string key)
        {

            EParOCFillrpt objE = new EParOCFillrpt();


            if (periodoOC != "")
            {
                objE.IdAnio = periodoOC;
            }
            else
            {
                objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            }

            objE.IdOrdenCompra = txtnu_oc.Text;
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion

            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.OrderCompra_rpt02(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

        private string documentContents;
        private string stringToPrint;
        public  void VistaPrevia(string key)
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
                crDiskFileDestinationOption.DiskFileName = strfolder + txtnu_oc.Text + ".pdf";

                
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




        public void PrintReport(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\co_ordenCompra_rpt.rpt";
                objRpt.Load(reportPath);


                //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";

                //objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + txtnu_oc.Text + ".pdf";


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

        private void txtsubTotal__Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtTotDesc__Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtTotIgv__Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void BuscarOrdenCompra()
        {
         
               EOrdenCompra oOC = new EOrdenCompra();

               if (periodoOC != "")
               {
                   oOC.Id_periodo = periodoOC;
               }
               else
               {
                   oOC.Id_periodo = wfChgEmpPer.datos.idperiodo;
               }

         

               oOC.Id_ordenco = txtBuscaroc.Text.PadLeft(7, '0');

               oOC.idEmpresa = wfChgEmpPer.datos.idEmpresa;

              List<EOrdenCompra> oListDato = BOrdenCompra.CO_Oc_qry05(oOC);

           
                string val = oListDato[0].existe;

                if (val == "0")
                {

                    try
                    {

                        dgvDetalle.Rows.Clear();
                        EOrdenCompra oCompra = new EOrdenCompra();

                        if (periodoOC != "")
                        {
                            oCompra.Id_periodo = periodoOC;
                        }
                        else
                        {
                            oCompra.Id_periodo = wfChgEmpPer.datos.idperiodo;
                        }

                        oCompra.Id_ordenco = txtBuscaroc.Text.PadLeft(7, '0');
                        oCompra.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                        EOrdenCompra oBtieneOC = new EOrdenCompra();
                        oBtieneOC = BOrdenCompra.mObtenerOC(oCompra);
                        txtnu_oc.Text = oBtieneOC.Id_ordenco.ToString();
                        txtFechaOc.Text = oBtieneOC.Fe_ordenco.ToString();
                        txtIdProv.Text = oBtieneOC.Id_clipro.ToString().Trim();
                        txtDsprov.Text = oBtieneOC.clipro.ToString().Trim();
                        txtEntregaEn.Text = oBtieneOC.Id_local.ToString();
                        cbEntregaEn.SelectedValue = oBtieneOC.Id_local.ToString().Trim();
                        txtIdPedido.Text = oBtieneOC.Id_personal.ToString().Trim();
                        lblPedidoPor.Text = oBtieneOC.Pedidop.ToString().Trim();
                        txtUsadoEn.Text = oBtieneOC.Id_local2.ToString();
                        cbUsadoEn.SelectedValue = oBtieneOC.Id_local2.ToString().Trim();
                        txtEmitidoPor.Text = oBtieneOC.Id_personal2.ToString().Trim();
                        lblEmitidoPor.Text = oBtieneOC.Emitidap.ToString().Trim();
                        txtPrioridad.Text = oBtieneOC.Id_prioridad.ToString().Trim();
                        cbPrioridad.SelectedValue = oBtieneOC.Id_prioridad.ToString().Trim();
                        txtObserv.Text = oBtieneOC.Ds_observa.ToString().Trim();
                        txtCondPago.Text = oBtieneOC.Id_condpago.ToString().Trim();
                        lblcondpago.Text = oBtieneOC.dsCondPago.ToString().Trim();
                        cbTipo.SelectedValue = oBtieneOC.Id_tipcomp.ToString().Trim();
                        txtTipo.Text = oBtieneOC.Id_tipcomp.ToString().Trim();
                        cbModalidad.SelectedValue = oBtieneOC.Id_modcomp.ToString().Trim();
                        txtModalidad.Text = oBtieneOC.Id_modcomp.ToString().Trim();
                        txtimport.Text = oBtieneOC.Id_importa.ToString().Trim();
                        lblimportacion.Text = oBtieneOC.Ds_importa.ToString().Trim();
                        txtExport.Text = oBtieneOC.Id_Exporta.ToString().Trim();
                        lblexportacion.Text = oBtieneOC.Ds_Exporta.ToString().Trim();
                        txtMoneda.Text = oBtieneOC.Id_vmoneda.ToString().Trim();
                        cbMoneda.SelectedValue = oBtieneOC.Id_vmoneda.ToString().Trim();
                        txtFechaEntrega.Text = oBtieneOC.Fe_entrega.ToString();
                        lblNuDoc.Text = oBtieneOC.Nu_docu.ToString();
                        lblestado.Text = oBtieneOC.stordenco.ToString();
                        List<EDetProducto> lstoc = new List<EDetProducto>();
                        lstoc = BDetOrdenCompra.mListarOcompra(oCompra);

                        foreach (EDetProducto objproducto in lstoc)
                        {
                            string[] row =
                        
                                {    objproducto._Nu_Correla,
                                     objproducto._Codigo,
                                     objproducto._Producto,
                                     objproducto._Presenta,
                                     objproducto._UM,
                                     objproducto._Cant.ToString("#,#.0000"),
                                     objproducto._PreUnit.ToString("#,#.0000"),
                                     objproducto._nu_pordscto.ToString("#,#.0000"),
                                     objproducto._Dscto.ToString("#,#.0000"),
                                     objproducto._Igv.ToString("#,#.0000"),
                                     objproducto._subTotal.ToString("#,#.0000"),
                                     objproducto._OP,
                                     objproducto._id_Gasto,
                                     objproducto._C_Gasto,
                                     objproducto._idCosto,
                                     objproducto._C_Costos,
                                     objproducto._Tipgasto,
                                     objproducto._dstg,
                                     objproducto._clase,
                                     objproducto._igvActivo.ToString(),
                                     objproducto._idclase,
                                     objproducto._Pres,
                                     objproducto._detalle,
                                     objproducto._PreNeto.ToString(),
                                     objproducto._Peso_Bruto.ToString(),
                                     objproducto._Lote,                     
                                };
                            dgvDetalle.Rows.Add(row);
                            for (int r = 0; dgvDetalle.Rows.Count > r; r++)
                            {
                                string igv = Convert.ToString(dgvDetalle.Rows[r].Cells["txtIGV"].Value).ToString();
                                if ((igv == "0.0000") || (igv == "0") || (igv == ".0000"))
                                {
                                    (dgvDetalle.Rows[r].Cells["chkIgv"].Value) = false;
                                }
                                else
                                {
                                    (dgvDetalle.Rows[r].Cells["chkIgv"].Value) = true;
                                }
                            }
                            mCalculaTotal();

                            dgTemp.Rows.Clear();
                        }

                    }
                    catch (Exception ex)
                    {
                        ex.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Nuevo();

                }

                  
        }

        private void txtBuscaroc_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                BuscarOrdenCompra();
            }
        }

        private void txtFechaOc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtIdProv.Focus();
            }
        }

        private void txtIdProv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmcoproveedor_qry frmp = new frmcoproveedor_qry();
                frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
                frmp.ShowDialog();
                txtIdProv.Focus();
            }
        }

        private void txtIdPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Frmpersonal_qry frmps = new Frmpersonal_qry();
                frmps.pasard += new Frmpersonal_qry.pasar(ejecutarPers);
                frmps.ShowDialog();
                txtIdPedido.Focus();
            }
        }

        private void txtCondPago_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.F1)
            {
                Frmcocondicionpago_qry frmcp = new Frmcocondicionpago_qry();
                frmcp.pasard += new Frmcocondicionpago_qry.pasar(ejecutarCondpago);
                frmcp.ShowDialog();
                txtCondPago.Focus();
            }
        }

        private void txtimport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Frmimportacion_qry frmimp = new Frmimportacion_qry();
                frmimp.pasard += new Frmimportacion_qry.pasar(ejecutarImp);
                frmimp.ShowDialog();
                txtimport.Focus();
            }
        }

        private void txtExport_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmExportacion_qry frmexport = new FrmExportacion_qry();
                frmexport.pasard += new FrmExportacion_qry.pasar(ejecutarExpo);
                frmexport.ShowDialog();
                txtExport.Focus();
            }
        }

      

        private void Frmco_ordenCompra_mnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N  && e.Control)
            {
                Nuevo();
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                var mod = cbModalidad.SelectedValue.ToString();
                var import = txtimport.Text;
                var export = txtExport.Text;
                var prio = cbPrioridad.SelectedValue.ToString();
                var prov = txtIdProv.Text;
                var entrep = txtEntregaEn.Text;
                var perso = txtIdPedido.Text;
                var usadoen = txtUsadoEn.Text;
                var perso2 = txtEmitidoPor.Text;

                var idpago = txtCondPago.Text;
                var tip = cbTipo.SelectedValue.ToString();
                var moneda = cbMoneda.SelectedValue.ToString();

                if ((mod != "") & (import != "") & (export != "") & (prio != "") & (prov != "") & (entrep != "") & (perso != "") & (perso2 != "") & (moneda != ""))
                {
                    Grabar();
                }
                else
                {
                    MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {
                txtnu_oc.Text = "";


                DateTime fecha = DateTime.Now;
                txtFechaOc.Text = fecha.ToString("d");
                txtFechaEntrega.Text = fecha.ToString("d");

                List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
                if (oListUsu.Count > 0)
                {
                    txtEmitidoPor.Text = oListUsu[0].id;
                    lblEmitidoPor.Text = oListUsu[0].desc;
                }

            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                PrintReport("");
            }
            else if(e.KeyCode== Keys.B && e.Control)
            {
                FrmOrdenCompra_qry frmoc = new FrmOrdenCompra_qry();
                frmoc.pasard += new FrmOrdenCompra_qry.pasar(EjecutarOC);
                frmoc.ShowDialog();

            }

            else if (e.KeyCode == Keys.E && e.Control)
            {
                HabilitarTexto(groupBox2);

                DateTime fecha = DateTime.Now;
                txtFechaOc.Text = fecha.ToString("d");
                txtFechaEntrega.Text = fecha.ToString("d");


                List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
                if (oListUsu.Count > 0)
                {
                    txtEmitidoPor.Text = oListUsu[0].id;
                    lblEmitidoPor.Text = oListUsu[0].desc;
                }
                txtFechaOc.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {
                try
                {

                    Frmco_modaloc_qry frmps = new Frmco_modaloc_qry();
                    frmps.FormParent = this;
                    frmps.ShowDialog();              

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
              
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarTexto(groupBox2);
          
            DateTime fecha = DateTime.Now;
            txtFechaOc.Text = fecha.ToString("d");
            txtFechaEntrega.Text = fecha.ToString("d");

            List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
            if (oListUsu.Count > 0)
            {
                txtEmitidoPor.Text = oListUsu[0].id;
                lblEmitidoPor.Text = oListUsu[0].desc;
            }
            txtFechaOc.Focus();
           
        }

        private void txtBuscaroc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmOrdenCompra_qry frmoc = new FrmOrdenCompra_qry();
                frmoc.pasard += new FrmOrdenCompra_qry.pasar(EjecutarOC);
                frmoc.ShowDialog();
            }
        }


        private void ReadDocument()
        {
            string strfolder = "C:\\Reporte\\";
            using (FileStream stream = new FileStream(strfolder + txtnu_oc.Text + ".pdf", FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                documentContents = reader.ReadToEnd();
            }

            stringToPrint = documentContents;
        }

        //public static Dato varIO_rpt;//variable publica para jalar el numero de OC para el reporte

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {

            FrmVistaPrevia frm = new FrmVistaPrevia();

            frm.nuOc = txtnu_oc.Text;

            frm.periodoRpt = periodoOC;
            frm.ShowDialog();

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
