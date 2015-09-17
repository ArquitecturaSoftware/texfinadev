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
using Texfina.DOQry.Sy;
using Texfina.Entity.Al;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;

namespace TX_Almacen
{
    public partial class frmOrdenPedidoMnt : Form
    {
        public frmOrdenPedidoMnt()
        {
            InitializeComponent();

            WebHelper.LoadListControl3(cb_prioridad, BGeneral.ObtenerDatoidTabla("027"));
            WebHelper.LoadListControl3(cbMoneda, BGeneral.ObtenerDatoidTabla("016"));
            cb_tipdoc.DataSource = BDocumento.ObtenerDatoTfactura();
            cb_tipdoc.DisplayMember = "desc";
            cb_tipdoc.ValueMember = "id";
           
            /*
             * Validacion 
             * usuario : jvillavicencio
             * 
             */

            validacionOrdenCompra();
          


            WebHelper.LoadListControl3(cb_local, BGeneral.ObtenerDatoLocal());
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente_qry frmp = new frmCliente_qry();
            frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
            frmp.ShowDialog();
            txtid_cliente.Focus();
        }

        public void ejecutarCliente(ECliente cl)
        {
            txtid_cliente.Text = cl.Id_clipro;
            txtds_cliente.Text = cl.Ds_raznombre;
        }

        private void btnvendedor_Click(object sender, EventArgs e)
        {
            frmVendedorQry frmps = new frmVendedorQry();
            frmps.pasard += new frmVendedorQry.pasar(ejecutarVendedor);
            frmps.ShowDialog();
            txtid_vendedor.Focus();
        }

        public void ejecutarVendedor(string idPers, string dsPers)
        {
            txtid_vendedor.Text = idPers;
            txtds_vendedor.Text = dsPers;
        }


        private void DeshabilitarTexto(TableLayoutPanel grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                }
                if (c is ComboBox)
                {
                    c.Enabled = false;
                    btnvendedor.Enabled = false;
                    btnCliente.Enabled = false;
                    btnFormapago.Enabled = false;
                }
            }

        }

        private void HabilitarTexto(GroupBox  grupo)
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
                    btnvendedor.Enabled = true;
                    btnCliente.Enabled = true;
                    btnFormapago.Enabled = true;
                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Limpiar?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    Nuevo();
                    btnGrabar.Enabled = true;
                }
                else if (result == DialogResult.No)
                {
                }
            }
             
        }

        private void Limpiar(GroupBox grupo)
        {
            //txtnu_oc.Text = "";

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtid_cliente.Focus();

                }
            }
        }
        private void Nuevo()
        {



            validacionNuevo();
            txtBuscarOP.Clear();
            Limpiar(groupBox1);
            Limpiar(groupBox2);
           
  

            List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
            if (oListUsu.Count > 0)
            {
                txtid_emitido.Text = oListUsu[0].id;
                txtds_emitido.Text = oListUsu[0].desc;
            }

            List<Dato> oListVen = BVendedor.MG_Vendedor_qry02(frmLogin.d.dsu);
            if (oListVen.Count > 0)
            {
                txtid_vendedor.Text = oListVen[0].id;
                txtds_vendedor.Text = oListVen[0].desc;
            }
            DateTime fecha = DateTime.Now;
            txtfecha.Text = fecha.ToString("d");
            txtfecha_venc.Text = fecha.AddDays(5).ToString();
    

            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox2);
            


            cb_tipdoc.SelectedIndex = - 1;
            cb_prioridad.SelectedIndex = -1;
            cb_local.SelectedValue = "03";
            cbMoneda.SelectedIndex = -1;
            
            txtid_local.Text = cb_local.SelectedValue.ToString();
            dgOrdenPedido.Rows.Clear();
            dgTempDet.Rows.Clear();

            txtid_op.Enabled = false;
            txtfechaAutorizado.Enabled = false;
            txtfechaAprobado.Enabled = false;            
            txtfecha.Focus();

            btnCliente.Enabled = true;
            btnAnticipo.Enabled = true;
            btnvendedor.Enabled = true;
            btnFormapago.Enabled = true;
            btnNuevoRow.Enabled = true;
            btnEliminarRow.Enabled = true;
            editar = "0";
        }

        /*
         * Validacion
         * usuario :jvillavicencio
         * 
         */ 




        private void btnFormapago_Click(object sender, EventArgs e)
        {
            Frmcocondicionpago_qry frmcp = new Frmcocondicionpago_qry();
            frmcp.pasard += new Frmcocondicionpago_qry.pasar(ejecutarCondpago);
            frmcp.ShowDialog();
            txtid_formapago.Focus();
        }

        public void ejecutarCondpago(string idCondpago, string dsCondpago)
        {
            txtid_formapago.Text = idCondpago;
            txtds_formapago.Text = dsCondpago;

        }

        private void frmOrdenPedidoMnt_Load(object sender, EventArgs e)
        {
            Permisos();
        }

        private void Permisos()
        {
            try
            {

                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0004";

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
                //btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);
                btnCopiar.Enabled = bool.Parse(usuarioo._btnCopiar);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }




        private void txtid_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_cliente.Text = txtid_cliente.Text.PadLeft(6, '0');

                ECliente per = new ECliente();
                per.psintypesel = 1;
                per.Ds_raznombre = "";
                per.Id_clipro = txtid_cliente.Text;
                per.Nu_ruc = "";
                per.IdEmpresa = wfChgEmpPer.datos.idEmpresa;



                List<Dato> oListDato = BCliente.ObtenerDatoCliente(per);

                if (oListDato.Count > 0)
                {
                    txtds_cliente.Text = oListDato[0].desc;

                    txtds_direccion.SelectionStart = 0;
                    txtds_direccion.SelectionLength = txtds_direccion.Text.Length;
                    txtds_direccion.Focus();
                }
                else

                {
                    MessageBox.Show("Cliente no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_cliente.Clear();
                    txtds_cliente.Clear();
                    txtid_cliente.Focus();
                }
                 
               
           
            }
        }

        private void txtds_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtid_vendedor.SelectionStart = 0;
                txtid_vendedor.SelectionLength = txtid_vendedor.Text.Length;
                txtid_vendedor.Focus();
            }
        }

        private void txtid_prioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtid_prioridad.Text = txtid_prioridad.Text.PadLeft(3, '0');
                cb_prioridad.SelectedValue = txtid_prioridad.Text;

                if (cb_prioridad.Text != "")
                {
                    txtid_formapago.Focus();
                    txtid_formapago.SelectionStart = 0;
                    txtid_formapago.SelectionLength = txtid_formapago.Text.Length;
                }
                else
                {
                    MessageBox.Show("Local no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_prioridad.Clear();
                    txtid_prioridad.Focus();
                }

              
            }
        }

        private void txtid_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_vendedor.Text = txtid_vendedor.Text.PadLeft(5, '0');

                EVendedor per = new EVendedor();
                per.psintypesel = 1;
                per.Id_Vendedor = txtid_vendedor.Text;
                per.Nu_dni = "";
                per.Ds_razsoc = "";

                List<Dato> oListDato = BVendedor.ObtenerDatoProveedor(per);
                if (oListDato.Count > 0)
                {
                    txtds_vendedor.Text = oListDato[0].desc;

                    txtid_emitido.SelectionStart = 0;
                    txtid_emitido.SelectionLength = txtid_emitido.Text.Length;
                    txtid_emitido.Focus();
                }
                else
                {
                    MessageBox.Show("Vendedor no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_vendedor.Clear();
                    txtds_vendedor.Clear();
                    txtid_vendedor.Focus();
                }


        
            }
        }

        private void txtid_formapago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_formapago.Text = txtid_formapago.Text.PadLeft(4, '0');
                ECondicionPago per = new ECondicionPago();
                per.psintypesel = 1;
                per.Ds_condpago = "";
                per.Id_condpago = txtid_formapago.Text;

                ComboBox cb = new ComboBox();

                List<Dato> oListDato = BCondicionPago.ObtenerDatoFormaPago(per);
                if (oListDato.Count > 0)
                {
                    txtds_formapago.Text = oListDato[0].desc;
                    txtid_documento.Focus();
                    txtid_documento.SelectionStart = 0;
                    txtid_documento.SelectionLength = txtid_documento.Text.Length;
                }
                else
                {
                    MessageBox.Show("Forma de pago no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_formapago.Clear();
                    txtds_formapago.Clear();
                    txtid_formapago.Focus();
                }

           
            }
        }

        private void txtid_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_documento.Text = txtid_documento.Text.PadLeft(3, '0');
                cb_tipdoc.SelectedValue = txtid_documento.Text;

                if (cb_tipdoc.Text != "")
                {
                    txtMoneda.Focus();
                    txtMoneda.SelectionStart = 0;
                    txtMoneda.SelectionLength = txtMoneda.Text.Length;
                }
                else
                {
                    MessageBox.Show("Local no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_documento.Clear();
                    txtid_documento.Focus();
                }


               
            }
        }

        private void txtid_cliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmCliente_qry frmp = new frmCliente_qry();
                frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
                frmp.ShowDialog();
                txtid_cliente.Focus();
            }
        }

        private void txtid_vendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmVendedorQry frmps = new frmVendedorQry();
                frmps.pasard += new frmVendedorQry.pasar(ejecutarVendedor);
                frmps.ShowDialog();
                txtid_vendedor.Focus();
            }

        }

        private void txtid_formapago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Frmcocondicionpago_qry frmcp = new Frmcocondicionpago_qry();
                frmcp.pasard += new Frmcocondicionpago_qry.pasar(ejecutarCondpago);
                frmcp.ShowDialog();
                txtid_formapago.Focus();
            }
        }

        private void cb_prioridad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtid_prioridad.Text = cb_prioridad.SelectedValue.ToString();
            txtid_prioridad.Focus();
        }

        private void cb_tipdoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtid_documento.Text = cb_tipdoc.SelectedValue.ToString();
            txtid_documento.Focus();
        }

        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            frmopProductoPopup frmps = new frmopProductoPopup();
            frmps.FormParent = this;

            if (txtid_vendedor.Text != "")
            {
                frmps.EstadoDet = 1;
                frmps.dscliente = txtds_cliente.Text;
                frmps.dsvendedor = txtds_vendedor.Text;
                txtid_vendedor.Enabled = false;
                btnvendedor.Enabled = false;
                txtds_vendedor.Enabled = false;
                frmps.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingrese el vendedor","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            
        }

        string valorCelda;

        public void LlenarGrilla(EOrdPedido_Detalle obj, object form)
        {
            int countRows = dgOrdenPedido.Rows.Count - 1;
            if (countRows >= 0)
            {
                valorCelda = dgOrdenPedido.Rows[countRows].Cells["NuItem"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }
            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            //-----------------------------------------------------------------------------
            int count=0;
            for (int i = 0; dgOrdenPedido.Rows.Count > i; i++)
            {
                var id_clipro = dgOrdenPedido.Rows[i].Cells["id_clipro"].Value.ToString();
                var idprod = dgOrdenPedido.Rows[i].Cells["Codigo"].Value.ToString();
                var idcolor = dgOrdenPedido.Rows[i].Cells["idcolor"].Value.ToString();
                var id_vendedor = dgOrdenPedido.Rows[i].Cells["id_Vendedor"].Value.ToString();
                
             if (id_clipro == obj.Id_clipro && idprod == obj.Id_producto && idcolor == obj.Id_color && id_vendedor == obj.Id_vendedor)
                {
                    count = count + 1;
                }
                else
                { 

                }
            }

            //----------------------------------------------------------------------------
            if (count == 0)
            {
                string[] row = { 
                             obj.NuItem=item.PadLeft(3, '0'),
                             obj.Id_clipro,
                             obj.ds_clipro,
                             obj.Id_producto,
                             obj.ds_producto,
                             obj.Id_color,
                             obj.DsColor,
                             obj.Qt_rollo.ToString(),
                             obj.Qt_rollo_pend.ToString(),
                             obj.Qt_peso.ToString(),
                             obj.Id_vendedor,
                             obj.Ds_vendedor,
                             obj.Mt_preunit_actual.ToString(),
                             obj._igvActivo.ToString(),
                           };

                dgOrdenPedido.Rows.Add(row);

                frmopProductoPopup frmPopup = (frmopProductoPopup)form;
                mCalcula1();
                frmPopup.Close();
            }
            else
            {
                MessageBox.Show("Ya existe este Articulo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);

                frmopProductoPopup frmPopup = (frmopProductoPopup)form;
                mCalcula1();
                frmPopup.Close();
            }
        }

        string _drow;
        public void ModGuilla(EOrdPedido_Detalle obj, object form)
        {


            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["NuItem"]).Value = obj.NuItem;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["Id_clipro"]).Value = obj.Id_clipro;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["ds_clipro"]).Value = obj.ds_clipro;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["Codigo"]).Value = obj.Id_producto;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["Articulo"]).Value = obj.ds_producto;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["idcolor"]).Value = obj.Id_color;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["Color"]).Value = obj.DsColor;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["nu_rollo"]).Value = obj.Qt_rollo;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["Peso_desp"]).Value = obj.Qt_peso;

            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["id_Vendedor"]).Value = obj.Id_vendedor;
            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["ds_Vendedor"]).Value = obj.Ds_vendedor;

            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["precio_unitario"]).Value = obj.Mt_preunit_actual;

            (dgOrdenPedido.Rows[int.Parse(_drow)].Cells["chkIgv"]).Value = obj._igvActivo.ToString();

            frmopProductoPopup frm = (frmopProductoPopup)form;
            frm.EstadoDet = 2;
            mCalcula1();
            frm.Close();
        }

        private void dgOrdenPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dRow = dgOrdenPedido.Rows[e.RowIndex];
                _drow = dRow.Index.ToString();


                EOrdPedido_Detalle obj = new EOrdPedido_Detalle();

                obj.NuItem = (dRow.Cells["NuItem"].Value == null) ? "" : dRow.Cells["NuItem"].Value.ToString();

                obj.Id_clipro = (dRow.Cells["id_clipro"].Value == null) ? "" : dRow.Cells["id_clipro"].Value.ToString();
                obj.ds_clipro = (dRow.Cells["ds_clipro"].Value == null) ? "" : dRow.Cells["ds_clipro"].Value.ToString();

                obj.Id_producto = (dRow.Cells["Codigo"].Value == null) ? "" : dRow.Cells["Codigo"].Value.ToString();
                obj.ds_producto = (dRow.Cells["Articulo"].Value == null) ? "" : dRow.Cells["Articulo"].Value.ToString();
                obj.Id_color = (dRow.Cells["idcolor"].Value == null) ? "" : dRow.Cells["idcolor"].Value.ToString();
                obj.DsColor = (dRow.Cells["Color"].Value == null) ? "" : dRow.Cells["Color"].Value.ToString();
                obj.Qt_rollo = (dRow.Cells["nu_rollo"].Value == null) ? 0 : Convert.ToInt32(dRow.Cells["nu_rollo"].Value.ToString());
                obj.Qt_peso = (dRow.Cells["Peso_desp"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["Peso_desp"].Value.ToString());

                obj.Id_vendedor = (dRow.Cells["id_Vendedor"].Value == null) ? "" : dRow.Cells["id_Vendedor"].Value.ToString();
                obj.Ds_vendedor = (dRow.Cells["ds_Vendedor"].Value == null) ? "" : dRow.Cells["ds_Vendedor"].Value.ToString();

                obj.Mt_preunit_actual = (dRow.Cells["precio_unitario"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["precio_unitario"].Value.ToString());

                string chkCell = dRow.Cells["chkIgv"].Value.ToString();
                obj._igvActivo = Convert.ToBoolean(chkCell);
                obj.St_estado = (dRow.Cells["st_estado"].Value == null) ? "" : (dRow.Cells["st_estado"].Value.ToString());

                frmopProductoPopup frm = new frmopProductoPopup();
          

                    frm.FormParent = this;
                    frm.EstadoDet = 2;
                    frm.nuOp = txtid_op.Text;
                    frm.dscliente = txtds_cliente.Text;
                    frm.dsvendedor = txtds_vendedor.Text;
                    frm.LLenarCampos(obj);
                    frm.ShowDialog();

                //if (editar == "0")
                //{

                    
                //}
                //else
                //{
                //    frm.FormParent = this;
                //    frm.EstadoDet = 1;
                //    frm.nuOp = txtid_op.Text;
                //    frm.dscliente = txtds_cliente.Text;
                //    frm.dsvendedor = txtds_vendedor.Text;
                //    frm.LLenarCampos(obj);
                //    frm.ShowDialog();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        protected void mCalcula1()
        {
            try
            {

                decimal totdeTotrollo1 = 0;
                decimal totdeTotrollo2 = 0;
                decimal deTotrollo1 = 0;

                for (int x = 0; x < dgOrdenPedido.Rows.Count; x++)
                {

                    decimal nu_rollo = Convert.ToDecimal(dgOrdenPedido.Rows[x].Cells["nu_rollo"].Value);


                    decimal precio = Convert.ToDecimal(dgOrdenPedido.Rows[x].Cells["precio_unitario"].Value);

                    totdeTotrollo1 = nu_rollo * precio;
                    deTotrollo1 = deTotrollo1 + totdeTotrollo1;
                    totdeTotrollo2 = totdeTotrollo2 + nu_rollo;

                    txttotal.Text = string.Format("{0:##,##0.0000}", deTotrollo1);
                    txttotRollo.Text = totdeTotrollo2.ToString();

                }

                lblnuitem.Text = dgOrdenPedido.RowCount.ToString();

                if (lblnuitem.Text == "0")
                {
                    txttotRollo.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                

            }
        }

        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    EOrdPedido objI = new EOrdPedido();
                    EOrdPedido_Detalle objID = new EOrdPedido_Detalle();

                    if (txtid_op.Text == "")
                    {

                        List<Dato> oListDato = BOrdPedido.OrdenPedidoGenCod_qry01_(wfChgEmpPer.datos.idEmpresa,wfChgEmpPer.datos.idperiodo);
                        if (oListDato.Count > 0)
                        {
                            txtid_op.Text = oListDato[0].id;
                        }

                        objI.Idreqsalida = txtid_op.Text;
                        objID.Idreqsalida = txtid_op.Text;
                    }
                    else
                    {
                        objI.Idreqsalida = txtid_op.Text;
                        objID.Idreqsalida = txtid_op.Text;
                    }
                    objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objI.Id_condpago = txtid_formapago.Text;
                    objI.Id_clipro = txtid_cliente.Text;
                    objI.Fe_requer = txtfecha.Value.ToShortDateString();
                    objI.Idpersonal1 = txtid_emitido.Text;
                    objI.IdLocal = txtid_local.Text;
                    objI.Fe_venc = txtfecha_venc.Value.ToShortDateString();
                    objI.Ds_direntrega = txtds_direccion.Text.ToUpper();
                    objI.Id_vendedor = txtid_vendedor.Text;
                    objI.Id_tipsalida = txtid_documento.Text;
                    objI.Id_prioridad = txtid_prioridad.Text;
                    objI.id_vmoneda = txtMoneda.Text;
                    objI.Id_autorizado = "";
                    objI.Id_autorizado2 = "";
                    objI.Id_aprobado = "";
                    objI.St_autorizado = "T";
                    objI.St_autorizado2 = "T";
                    objI.St_aprobado = "T";
                    objI.Ds_observ = txtds_observ.Text.ToUpper();
                    objI.Id_ucreatrec = frmLogin.d.id.ToLower();
                    objI.Ds_prontoPago = txtProntoPago.Text;
                    objI.Ds_promocion = txtPromocion.Text ;
                                     
                    BOrdPedido.OrdenPedido_mnt01(objI);
                    



                    ////------------------------Detalle de compras----------------------------------------------------  
                    string _st_igv;

                    for (int i = 0; dgOrdenPedido.Rows.Count > i; i++)
                    {
                        var Nu_Item = dgOrdenPedido.Rows[i].Cells["NuItem"].Value.ToString();
                        var id_clipro = dgOrdenPedido.Rows[i].Cells["id_clipro"].Value.ToString();
                        var Codigo = dgOrdenPedido.Rows[i].Cells["Codigo"].Value.ToString();
                        var idcolor = dgOrdenPedido.Rows[i].Cells["idcolor"].Value.ToString();
                        var nu_rollo = dgOrdenPedido.Rows[i].Cells["nu_rollo"].Value.ToString();
                        var Peso_desp = dgOrdenPedido.Rows[i].Cells["Peso_desp"].Value.ToString();
                        var id_vendedor = dgOrdenPedido.Rows[i].Cells["id_Vendedor"].Value.ToString();
                        var precio_unitario = dgOrdenPedido.Rows[i].Cells["precio_unitario"].Value.ToString();
                        var st_igv = dgOrdenPedido.Rows[i].Cells["chkIgv"].Value.ToString();

                        
                        if (st_igv == "True")
                        {
                             _st_igv = "1";
                        }
                        else
                        {
                            _st_igv = "0";

                        }


                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion
                        objID.Idreqsalida = txtid_op.Text;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objID.Id_clipro = id_clipro.ToString();
                        objID.Id_producto = Codigo.ToString();
                        objID.Id_color = idcolor.ToString();
                        objID.NuItem = Nu_Item.ToString();
                        objID.Qt_rollo = Convert.ToInt16(nu_rollo);
                        objID.Mt_preunit_real = Convert.ToDecimal(precio_unitario);
                        objID.Mt_preunit_actual = Convert.ToDecimal(precio_unitario);
                        objID.Qt_peso = Convert.ToDecimal(Peso_desp);
                        objID.Id_vendedor = id_vendedor.ToString();
                        objID.st_igv = _st_igv.ToString();
                        objID.St_estado = "Pendiente";                  
                        objID.Id_ucreatrec = frmLogin.d.id.ToLower();

                        BOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt01(objID);


                    }





                    //ANULAR EL DETALLE

                    EOrdPedido_Detalle objdop = new EOrdPedido_Detalle();

                    for (int i = 0; dgTempDet.Rows.Count > i; i++)
                    {
                        var nu_secue = dgTempDet.Rows[i].Cells["nusecuencia"].Value;


                        objdop.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objdop.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion

                        objdop.Idreqsalida = txtid_op.Text;
                        objdop.NuItem = nu_secue.ToString();
                    
                        objdop.Id_uupdarec = frmLogin.d.id.ToLower();
                        BOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt03(objdop);                  
                    }

                    dgTempDet.Rows.Clear();


                    MessageBox.Show(txtid_op.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                var cliente = txtid_cliente.Text;
                var dir = txtds_direccion.Text;
                var id_prioridad = txtid_prioridad.Text;
                var id_vendedor = txtid_vendedor.Text;
                var id_formapago = txtid_formapago.Text;
                var id_documento = txtid_documento.Text;


                if ((cliente != "") & (dir != "") & (id_prioridad != "") & (id_vendedor != "") & (id_formapago != "") & (id_documento != "") & (txttotRollo.Text != ""))
                {
                    Grabar();
                    /*
                     * Validacion
                     * usuario : jvillavicencio
                     * 
                     */
                    validacionGrabar();
                    //Nuevo();
                }
                else
                {
                    MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }


        private void btnEliminarRow_Click(object sender, EventArgs e)
        {
  

            try
            {
                var nuSecuen = dgOrdenPedido.CurrentRow.Cells["NuItem"].Value;
                dgTempDet.Rows.Add(nuSecuen.ToString());

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            try
            {

                dgOrdenPedido.Rows.Remove(dgOrdenPedido.CurrentRow);
                mCalcula1();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }



            if (lblnuitem.Text == "0")
            {
                txtid_vendedor.Enabled = true;
                txtds_vendedor.Enabled = true;
                btnvendedor.Enabled = true;
               
            }
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                txtid_cliente.Focus();
                txtid_cliente.SelectionStart = 0;
                txtid_cliente.SelectionLength = txtid_cliente.Text.Length;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmOrdenPedido_qry frmoc = new FrmOrdenPedido_qry();
            frmoc.pasard += new FrmOrdenPedido_qry.pasar(EjecutarOP);
            frmoc.ShowDialog();

            /*
             * Validacion
             * Usuario :jvillavicencio
             * 
             */
            validacionBuscar();

        }

        string periodoOp="";
        public void EjecutarOP(EOrdPedido_Detalle oc)
        {
            txtBuscarOP.Text = oc.Idreqsalida;
            txtid_op.Text = oc.Idreqsalida;
            periodoOp = oc.IdPeriodo;

            BuscarOrdenPedido();
            //txtBuscaroc.Focus();
        }
        
        private void BuscarOrdenPedido()
        {
            dgOrdenPedido.Rows.Clear();
            dgTempDet.Rows.Clear();


            EOrdPedido objOp = new EOrdPedido();

            if ((periodoOp != ""))
            {
                objOp.IdPeriodo = periodoOp;
            }
            else
            {
                objOp.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            }

            txtBuscarOP.Text = txtBuscarOP.Text.PadLeft(7, '0');

            objOp.Idreqsalida = txtBuscarOP.Text;

            objOp.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            List<EOrdPedido> oListDato = BOrdPedido.VE_OrdPedido_qry05(objOp);


            string val = oListDato[0].Existe;

            if (val == "0")
            {

                try
                {
                    validacionBuscar();
                    EOrdPedido oBtieneOC = new EOrdPedido();

                    oBtieneOC = BOrdPedido.VE_OrdPedido_qry01(objOp);

                    txtid_op.Text = oBtieneOC.Idreqsalida;
                    txtfecha.Text = oBtieneOC.Fe_requer.ToString();
                    txtid_cliente.Text = oBtieneOC.Id_clipro.ToString().Trim();
                    txtds_cliente.Text = oBtieneOC.ds_raznombre.ToString().Trim();
                    txtds_direccion.Text = oBtieneOC.Ds_direntrega.ToString();
                    txtid_emitido.Text = oBtieneOC.Idpersonal1.ToString().Trim();
                    txtds_emitido.Text = oBtieneOC.emitidap.ToString().Trim();
                    txtid_local.Text = oBtieneOC.IdLocal.ToString().Trim();
                    cb_local.SelectedValue = txtid_local.Text;
                    txtid_prioridad.Text = oBtieneOC.Id_prioridad.ToString();
                    cb_prioridad.SelectedValue = txtid_prioridad.Text;
                    txtid_vendedor.Text = oBtieneOC.Id_vendedor.ToString().Trim();
                    txtds_vendedor.Text = oBtieneOC.dsVendedor.ToString().Trim();
                    txtid_formapago.Text = oBtieneOC.Id_condpago.ToString().Trim();
                    txtds_formapago.Text = oBtieneOC.ds_condpago.ToString().Trim();
                    txtid_documento.Text = oBtieneOC.Id_tipsalida.ToString().Trim();
                    cb_tipdoc.SelectedValue = txtid_documento.Text.ToString();
                    txtds_observ.Text = oBtieneOC.Ds_observ.ToString().Trim();
                    txtfecha_venc.Text = oBtieneOC.Fe_venc.ToString().Trim();
                    txtfechaAutorizado.Text = oBtieneOC.fe_autorizado.ToString();
                    txtfechaAprobado.Text = oBtieneOC.fe_aprobado.ToString();
                    
                    txtMoneda.Text = oBtieneOC.id_vmoneda.ToString().Trim();
                    cbMoneda.SelectedValue = oBtieneOC.id_vmoneda.ToString().Trim();
                    txtProntoPago.Text = oBtieneOC.Ds_prontoPago.ToString();
                    txtPromocion.Text = oBtieneOC.Ds_promocion.ToString();


                    EOrdPedido_Detalle objOpd = new EOrdPedido_Detalle();

                    objOpd.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    if (periodoOp != "")
                    {
                        objOpd.IdPeriodo = periodoOp;
                    }
                    else
                    {
                        objOpd.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    }                    
                    objOpd.Idreqsalida = txtid_op.Text;


                    List<EOrdPedido_Detalle> lstIG = new List<EOrdPedido_Detalle>();
                    lstIG = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry02(objOpd);

                    foreach (EOrdPedido_Detalle _objID in lstIG)
                    {
                        string[] row =
                        
                                {    _objID.NuItem,
                                     _objID.Id_clipro,
                                     _objID.ds_clipro,
                                     _objID.Id_producto,
                                     _objID.ds_producto,
                                     _objID.Id_color,
                                     _objID.DsColor,
                                     _objID.Qt_rollo.ToString(),
                                     _objID.Qt_rollo_pend.ToString(),
                                     _objID.Qt_peso.ToString(),
                                     _objID.Id_vendedor,
                                     _objID.Ds_vendedor,
                                     _objID.Mt_preunit_actual.ToString(),
                                     _objID._igvActivo.ToString(),
                                     _objID.St_estado,
                                     
                                                        
                                };
                        dgOrdenPedido.Rows.Add(row);
                    }

                    mCalcula1();
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
                validacionNuevo();

            }


        }

        private void txtBuscarOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                BuscarOrdenPedido();
            }
        }

        private void cb_local_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtid_local.Text = cb_local.SelectedValue.ToString();
            txtid_local.Focus();
        }

        private void txtid_local_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtid_local.Text = txtid_local.Text.PadLeft(2, '0');
                cb_local.SelectedValue = txtid_local.Text;

                if (txtid_local.Text != "")
                {
                    txtid_prioridad.Focus();
                    txtid_prioridad.SelectionStart = 0;
                    txtid_prioridad.SelectionLength = txtid_prioridad.Text.Length;
                   
                }
                else
                {
                    MessageBox.Show("Local no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_local.Clear();
                    txtid_local.Focus();
                }

              
            }
        }

        private void FrmOrdenPedido_mnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Nuevo();
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {

                //var cliente = txtid_cliente.Text;
                //var dir = txtds_direccion.Text;
                //var id_prioridad = txtid_prioridad.Text;
                //var id_vendedor = txtid_vendedor.Text;
                //var id_formapago = txtid_formapago.Text;
                //var id_documento = txtid_documento.Text;


                //if ((cliente != "") & (dir != "") & (id_prioridad != "") & (id_vendedor != "") & (id_formapago != "") & (id_documento != ""))
                //{
                //    Grabar();
                //}
                //else
                //{
                //    MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //}

            }
            else if (e.KeyCode == Keys.C && e.Control)
            {
                

            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                FrmOrdenPedido_rpt01 frm = new FrmOrdenPedido_rpt01();
                frm.nuop = txtid_op.Text;
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrmOrdenPedido_qry frmoc = new FrmOrdenPedido_qry();
                frmoc.pasard += new FrmOrdenPedido_qry.pasar(EjecutarOP);
                frmoc.ShowDialog();

            }

            else if (e.KeyCode == Keys.E && e.Control)
            {
                //HabilitarTexto(groupBox2);

                //DateTime fecha = DateTime.Now;
                //txtFechaOc.Text = fecha.ToString("d");
                //txtFechaEntrega.Text = fecha.ToString("d");


                //List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
                //if (oListUsu.Count > 0)
                //{
                //    txtEmitidoPor.Text = oListUsu[0].id;
                //    lblEmitidoPor.Text = oListUsu[0].desc;
                //}
                //txtFechaOc.Focus();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {
                frmopProductoPopup frmps = new frmopProductoPopup();
                frmps.FormParent = this;

                if (txtid_vendedor.Text != "")
                {
                    frmps.EstadoDet = 1;
                    frmps.dscliente = txtds_cliente.Text;
                    frmps.dsvendedor = txtds_vendedor.Text;
                    txtid_vendedor.Enabled = false;
                    btnvendedor.Enabled = false;
                    txtds_vendedor.Enabled = false;
                    frmps.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ingrese el vendedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void txtid_vendedor_KeyDown(object sender, KeyEventArgs e)
        {




        }
        string editar = "0";
        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox2);    
            //btnCliente.Enabled = false;
            //btnvendedor.Enabled = false;
            //btnFormapago.Enabled = false;

            btnNuevoRow.Enabled = true;
            btnEliminarRow.Enabled = true;

            /*
             * Validacion
             * usuario :jvillavicencio
             * 
             */
            validacionEditar();

            editar = "1";
        }

         /*
         * Validacion
         * usuario :jvillavicencio
         * 
         */

        public void validacionNuevo()
        {
            btnEditar.Enabled = false;
            btnCopiar.Enabled = false;
            btnGrabar.Enabled = true;
            btnVistaPrevia.Enabled = false;
        }
        public void validacionEditar()
        {
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = true;
            btnCopiar.Enabled = true;
            btnGrabar.Enabled = true;
            btnVistaPrevia.Enabled = false;
        }
        public void validacionCopiar()
        {
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;
            btnVistaPrevia.Enabled = false;
            btnNuevo.Enabled = true;
        }
        public void validacionGrabar()
        {
            btnGrabar.Enabled = false;
            btnCopiar.Enabled = true;
            btnEditar.Enabled = true;
            btnVistaPrevia.Enabled = true;
        }
        public void validacionVistaPrevia()
        {
            Nuevo();
        }
        public void validacionBuscar()
        {
            btnGrabar.Enabled = false;
            btnEditar.Enabled = true;
            btnCopiar.Enabled = true;
            btnVistaPrevia.Enabled = true;
            btnNuevo.Enabled = true;
        }


        public void validacionOrdenCompra()
        {
            btnGrabar.Enabled = false;
            btnCopiar.Enabled = false;
            btnEditar.Enabled = false;
            btnVistaPrevia.Enabled = false;
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            FrmOrdenPedido_rpt01 frm = new FrmOrdenPedido_rpt01();

            
            frm.nuop = txtid_op.Text;
            frm.ShowDialog();
            btnGrabar.Enabled = false;
           // validacionVistaPrevia();
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtds_observ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtfecha_venc.Focus();
              


            }
        }

        private void txtid_emitido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_local.SelectionStart = 0;
                txtid_local.SelectionLength = txtid_local.Text.Length;
                txtid_local.Focus();

            }
        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoneda.Text = txtMoneda.Text.PadLeft(3, '0');
                cbMoneda.SelectedValue = txtMoneda.Text;
                txtds_observ.Focus();
                txtds_observ.SelectionStart = 0;
                txtds_observ.SelectionLength = txtds_observ.Text.Length;
            } 
        }

        private void dgOrdenPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgOrdenPedido.Columns["chkIgv"].Index)
            {
                dgOrdenPedido.EndEdit();
            }

        }

        private void cbMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtMoneda.Text = cbMoneda.SelectedValue.ToString();
            txtMoneda.Focus();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtid_op.Text = "";
            dgOrdenPedido.Rows.Clear();

            /*
             * Validacion
             * usuario: jvillavicencio
             * 
             */
            validacionCopiar();

        }

        private void btnAnticipo_Click(object sender, EventArgs e)
        {
            ///Llama al formulario de anticipos (frmAnticiposQry)
            /// 

            frmAnticiposQry frmcp = new frmAnticiposQry();
            frmcp.pasard += new frmAnticiposQry.pasar(ejecutarCondpago);
            frmcp.ShowDialog();
            txtid_formapago.Focus();
        }
    }
}
