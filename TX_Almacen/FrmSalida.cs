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
using Texfina.DOQry.Sy;
using Texfina.Entity.Al;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;

namespace TX_Almacen
{
    public partial class FrmSalida : Form
    {
        
        public FrmSalida()
        {
            InitializeComponent();
            validacionFrmSalida();
        }

        private void FrmSalida_Load(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cb_prioridad, BGeneral.ObtenerDatoidTabla("027"));
            WebHelper.LoadListControl3(cbMoneda, BGeneral.ObtenerDatoidTabla("016"));
            cb_tipdoc.DataSource = BDocumento.ObtenerDatoTfactura();
            cb_tipdoc.DisplayMember = "desc";
            cb_tipdoc.ValueMember = "id";
            WebHelper.LoadListControl3(cb_local, BGeneral.ObtenerDatoLocal());

            Permisos();
            //btnAnular.Enabled = false;
            //btnEditar.Enabled = false;
            //btnVistaPrevia.Enabled = false;
            //btnGrabar.Enabled = false;
        }

        private void Permisos()
        {
            try
            {

                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0005";

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
                //btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }


        private void btnNuevoItem_Click(object sender, EventArgs e)
        {
            FrmSalidaProducto_Popup frm = new FrmSalidaProducto_Popup();
            frm.FormParent = this;
            frm.EstadoDet = 1;
            frm.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Limpiar?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    validacionNuevo();
                    Nuevo();
                    
                    //btnAnular.Enabled = true;
                    //btnGrabar.Enabled = true;
                    //btnEditar.Enabled = true;
                    //btnVistaPrevia.Enabled = true;
                }
                else if (result == DialogResult.No)
                {
                }
            }
        }


        private void DeshabilitarTexto(GroupBox grupo)
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
                    btnvendedor.Enabled = true;
                    btnCliente.Enabled = true;
                    btnFormapago.Enabled = true;
                }

            }
        }


        private void Limpiar(GroupBox grupo)
        {
        

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtid_cliente.Focus();

                }
            }
            txtds_observ.Clear();
        }
        private void Nuevo()
        {
            //txtBuscarOP.Clear();

           // validacionNuevo();
            Limpiar(groupBox1);
            Limpiar(groupBox2);
            Limpiar(groupBox4);
            Limpiar(groupBox7);
            

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
            txtfe_emision.Text = fecha.ToString("d");

            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox7);
            HabilitarTexto(groupBox2);
            HabilitarTexto(groupBox4);


            cb_tipdoc.SelectedIndex = -1;
            cb_prioridad.SelectedIndex = -1;
            cbMoneda.SelectedIndex = -1;
            cb_local.SelectedValue = "03";
            txtid_local.Text = cb_local.SelectedValue.ToString();

            dgOrdenPedido.Rows.Clear();
            dgTempDet.Rows.Clear();
            dgvSalida.Rows.Clear();

            txtfe_aprobado.Enabled = false;
            txtfe_autorizado.Enabled = false;
            txtdia_desp.Enabled = false;
            txtid_salida.Enabled = false;
            txtds_observ.Enabled = true;
            lblsumrollo1.Text = "";
            txttotpesorollo.Clear();
            txttotnumrollos.Clear();
            txttotal.Clear();
          


            btnReqOP.Enabled = true;
            btnCliente.Enabled = true;
            btnFormapago.Enabled = true;
            btnvendedor.Enabled = true;
            btnchofer.Enabled = true;
            btnNuevoItem.Enabled = true;
            btnEliminarItem.Enabled = true;
            txtid_prioridad.Enabled = false;
            cb_prioridad.Enabled = false;

            editar = "0";
            txtnu_op.Text = "";
            txtnu_op.Focus();
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
            FrmVendedor_qry frmps = new FrmVendedor_qry();
            frmps.pasard += new FrmVendedor_qry.pasar(ejecutarVendedor);
            frmps.ShowDialog();
            txtid_vendedor.Focus();
        }

        public void ejecutarVendedor(string idPers, string dsPers)
        {
            txtid_vendedor.Text = idPers;
            txtds_vendedor.Text = dsPers;
        }

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

        private void btnchofer_Click(object sender, EventArgs e)
        {
            frmPersonal_qry frmps = new frmPersonal_qry();
            frmps.pasard += new frmPersonal_qry.pasar(ejecutarPers);
            frmps.ShowDialog();
            txtid_chofer.Focus();
        }
        public void ejecutarPers(string idPers, string dsPers)
        {
            txtid_chofer.Text = idPers;
            txtds_chofer.Text = dsPers;
        }

        private void btnReqOP_Click(object sender, EventArgs e)
        {
            FrmOrdenPedido_qry frmoc = new FrmOrdenPedido_qry();
            frmoc.pasard += new FrmOrdenPedido_qry.pasar(EjecutarOP);
            frmoc.ShowDialog();
        }

        string periodoOp="";
        public void EjecutarOP(EOrdPedido_Detalle oc)
        {
            txtnu_op.Text = oc.Idreqsalida;
            periodoOp = oc.IdPeriodo;
            BuscarOrdenPedido();
        }
        private void BuscarOrdenPedido()
        {
            dgOrdenPedido.Rows.Clear();
            dgTempDet.Rows.Clear();


            EOrdPedido objOp = new EOrdPedido();

            if (periodoOp != "")
            {
                objOp.IdPeriodo = periodoOp;
            }
            else
            {
                objOp.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            }



            objOp.Idreqsalida = txtnu_op.Text.PadLeft(7, '0');

            objOp.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            List<EOrdPedido> oListDato = BOrdPedido.VE_OrdPedido_qry05(objOp);


            string val = oListDato[0].Existe;

            if (val == "0")
            {

                try
                {
                    EOrdPedido oBtieneOC = new EOrdPedido();

                    oBtieneOC = BOrdPedido.VE_OrdPedido_qry01(objOp);

                    //txtid_op.Text = oBtieneOC.Idreqsalida;
                    //txtfecha.Text = oBtieneOC.Fe_requer.ToString();
                    txtid_cliente.Text = oBtieneOC.Id_clipro.ToString().Trim();
                    txtds_cliente.Text = oBtieneOC.ds_raznombre.ToString().Trim();
                    txtds_direccion.Text = oBtieneOC.Ds_direntrega.ToString();
                    //txtid_emitido.Text = oBtieneOC.Idpersonal1.ToString().Trim();
                    //txtds_emitido.Text = oBtieneOC.emitidap.ToString().Trim();
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
                    txtfe_autorizado.Text = oBtieneOC.fe_autorizado.ToString().Trim();
                    txtfe_aprobado.Text = oBtieneOC.fe_aprobado.ToString();
                    txtMoneda.Text = oBtieneOC.id_vmoneda.ToString();
                    cbMoneda.SelectedValue = oBtieneOC.id_vmoneda.ToString();

                    DateTime fe_aprob = Convert.ToDateTime(txtfe_aprobado.Text);
                    DateTime fe_emision = Convert.ToDateTime(txtfe_emision.Text);
                    txtdia_desp.Text =  Convert.ToString(fe_aprob.Day - fe_emision.Day); 

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
                    objOpd.Idreqsalida = txtnu_op.Text;

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
                                };
                        dgOrdenPedido.Rows.Add(row);
                    }

                    //mCalcula1();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        string valorCelda;
        public void LlenarGrilla(ESalida_Detalle obj, object form)
        {
            int countRows = dgvSalida.Rows.Count - 1;
            if (countRows >= 0)
            {
                valorCelda = dgvSalida.Rows[countRows].Cells["nu_item"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }
            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            //-----------------------------------------------------------------------------
            int count2 = 0;
            for (int i = 0; dgvSalida.Rows.Count > i; i++)
            {
                var codBarra = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();


                if (codBarra == obj.CodBar)
                {
                    count2 = count2 + 1;
                }
                else
                {

                }
            }


            //-----------------------------------------------------------------------------
            if (count2 == 0)
            {
                string[] row = { 
                             obj.Nu_item=item.PadLeft(2, '0'),
                             obj.CodBar,
                             obj.Nu_tf,
                             obj.Nu_op,
                             obj.Id_mercado,
                             obj.Id_tipo,
                             obj.Id_tiptela,
                             obj.Id_producto,
                             obj.Ds_producto,
                             obj.Id_color,
                             obj.Ds_color,                             
                             obj.Qt_rollo.ToString(),
                             obj.Qt_peso_Actual.ToString(),
                             obj.Qt_peso.ToString(),
                             obj.Mt_precio.ToString(), 
                             obj.Mt_igv.ToString(),
                             obj.Mt_total.ToString(),
                             obj._id_cliente,
                           };

                dgvSalida.Rows.Add(row);

                FrmSalidaProducto_Popup frmPopup = (FrmSalidaProducto_Popup)form;
                //frmPopup.Close();
            }
            else
            {
                MessageBox.Show("Ya existe este Articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSalidaProducto_Popup frm = (FrmSalidaProducto_Popup)form;
                //frm.Close();
            }

                mCalcula1();
                mCalcula2();
       
        }



        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    ESalida objS = new ESalida();
                    ESalida_Detalle objSD = new ESalida_Detalle();

                    if (txtid_salida.Text == "")
                    {

                        List<Dato> oListDato = BSalida.Al_Salida_GenCod(wfChgEmpPer.datos.idperiodo,wfChgEmpPer.datos.idEmpresa);
                        if (oListDato.Count > 0)
                        {
                            txtid_salida.Text = oListDato[0].id;
                        }

                        objS.IdSalida = txtid_salida.Text;
                        objSD.IdSalida = txtid_salida.Text;
                    }
                    else
                    {
                        objS.IdSalida = txtid_salida.Text;
                        objSD.IdSalida = txtid_salida.Text;
                    }
                    objS.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objS.IdPeriodo = wfChgEmpPer.datos.idperiodo;

        
                 

                    //if (txtnu_op.Text == "")
                    //{
                    //    objS.Idreqsalida = ;
                    //}
                    //else
                    //{
                        objS.Idreqsalida = txtnu_op.Text;
                    //}
                    objS.IdPersonal1 = txtid_emitido.Text;
                    objS.IdLocal = txtid_local.Text;
                    objS.Fe_salida = txtfe_emision.Text;
                    objS.Id_clipro = txtid_cliente.Text;
                    objS.Ds_direntrega = txtds_direccion.Text.ToUpper();
                    objS.Id_condpago = txtid_formapago.Text;
                    objS.Ds_placa = txtnu_placa.Text.ToUpper();
                    objS.IdPersonal2 = txtid_chofer.Text;                    
                    objS.Id_docucom = txtid_documento.Text;
                    objS.Id_vendedor = txtid_vendedor.Text;
                    objS.Id_vmoneda = txtMoneda.Text;
                    objS.Ds_observ = txtds_observ.Text.ToUpper();
                    objS.Mt_total = Convert.ToDecimal(txttotal.Text);
                    objS.Id_ucreatrec = frmLogin.d.id.ToLower();

                    BSalida.AL_Salida_mnt01(objS);

                     for (int W = 0; dgvSalida.Rows.Count > W; W++)
                    {
                        var id_cliente = dgvSalida.Rows[W].Cells["id_cliente"].Value.ToString();
                        var _id_producto = dgvSalida.Rows[W].Cells["id_producto"].Value.ToString();
                        var id_color = dgvSalida.Rows[W].Cells["id_color"].Value.ToString();
                       
                        EOrdPedido_Detalle op = new EOrdPedido_Detalle();
                        op.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        op.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        op.Idreqsalida = txtnu_op.Text;
                        op.Id_clipro = id_cliente.ToString();
                        op.Id_producto = _id_producto.ToString();
                        op.Id_color = id_color.ToString();
                    
                    BOrdPedido_Detalle.VE_OrdPedido_Detalle_mnt05(op);
                    }

                    ////------------------------Detalle de compras----------------------------------------------------  


                    for (int i = 0; dgvSalida.Rows.Count > i; i++)
                    {
                        var nu_item = dgvSalida.Rows[i].Cells["nu_item"].Value.ToString();
                        var CodBar = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();
                        var nu_tf = dgvSalida.Rows[i].Cells["nu_tf"].Value.ToString();
                        var nu_op = dgvSalida.Rows[i].Cells["nu_op"].Value.ToString();
                        var id_mercado = dgvSalida.Rows[i].Cells["id_mercado"].Value.ToString();
                        var id_tipo = dgvSalida.Rows[i].Cells["id_tipo"].Value.ToString();
                        var tipo_tela = dgvSalida.Rows[i].Cells["tipo_tela"].Value.ToString();
                        var _id_producto = dgvSalida.Rows[i].Cells["id_producto"].Value.ToString();
                        var id_color = dgvSalida.Rows[i].Cells["id_color"].Value.ToString();
                        var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value.ToString();
                        var qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value.ToString();
                        var mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value.ToString();

                        var mt_igv = dgvSalida.Rows[i].Cells["mt_igv"].Value.ToString();
                        var mt_total = dgvSalida.Rows[i].Cells["mt_total"].Value.ToString();

                        var id_cliente = dgvSalida.Rows[i].Cells["id_cliente"].Value.ToString();
                        

                        objSD.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion                        
                        objSD.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objSD.IdSalida = txtid_salida.Text;

                        objSD.Id_producto = _id_producto.ToString();
                        objSD.Nu_item = nu_item.ToString();
                        objSD.CodBar = CodBar.ToString();
                        objSD.Nu_op = nu_op.ToString().ToUpper();
                        objSD.Nu_tf = nu_tf.ToString().ToUpper();                        
                        objSD.Id_color = id_color.ToString();
                        objSD.Id_tipo = id_tipo.ToString();
                        objSD.Id_mercado = id_mercado.ToString();
                        objSD.Id_tiptela = tipo_tela.ToString();
                        objSD.Qt_rollo = Convert.ToInt32(_nu_rollo);
                        objSD.Qt_peso = Convert.ToDecimal(qt_peso);
                        objSD.Mt_precio = Convert.ToDecimal(mt_precio);
                        objSD.Mt_igv = Convert.ToDecimal(mt_igv);
                        objSD.Mt_total = Convert.ToDecimal(mt_total);
                     

                        objSD.Id_ucreatrec = frmLogin.d.id.ToLower();

                        BSalida_Detalle.AL_Salida_Detalle_mnt01(objSD);

                        // disminuir cantidad de rollos de la tabla Orden de pedido para saber si se llego a despachar todas las OP

                        ESalida_Detalle _obj = new ESalida_Detalle();
                        _obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        _obj.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        _obj._pidreqsalida = txtnu_op.Text;
                        _obj._id_cliente = id_cliente.ToString();
                        _obj.Id_producto = _id_producto.ToString();
                        _obj.Id_color = id_color.ToString();
                        _obj.Qt_rollo = Convert.ToInt16(_nu_rollo);

                        BSalida_Detalle.VE_OrdPedido_Detalle_mnt02(_obj);
                       
                    }






                    dgTempDet.Rows.Clear();
                    txtbuscaridsalida.Text = txtid_salida.Text;
                    
                    MessageBox.Show(txtid_salida.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

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


                if ((cliente != "") & (dir != "") &  (id_vendedor != "") & (id_formapago != "") & (id_documento != "") )                    
                    {
                        validacionGrabar();
                        Grabar();
                        PrintReport("");
                        BuscarSalida();

                        DeshabilitarTexto(groupBox1);
                        DeshabilitarTexto(groupBox2);
                        DeshabilitarTexto(groupBox4);
                        DeshabilitarTexto(groupBox7);
     

                        //HabilitarTexto(tableLayoutPanel9);
                        //HabilitarTexto(tableLayoutPanel10);
                       dgvSalida.Enabled=false;
	                   btnNuevoItem.Enabled=false;
                       btnEliminarItem.Enabled = false;

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

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            txtbuscaridsalida.Text = txtid_salida.Text;
            try
            {
                var nuSecuen = dgvSalida.CurrentRow.Cells["nu_item"].Value;
                var codbarr = dgvSalida.CurrentRow.Cells["CodBar"].Value;
                var peso = dgvSalida.CurrentRow.Cells["qt_peso"].Value;

                var _id_cliente = dgvSalida.CurrentRow.Cells["id_cliente"].Value;
                var _id_producto = dgvSalida.CurrentRow.Cells["id_producto"].Value;
                var _id_color = dgvSalida.CurrentRow.Cells["id_color"].Value;
                var nu_rollo_ = dgvSalida.CurrentRow.Cells["_nu_rollo"].Value; 

                dgTempDet.Rows.Add(nuSecuen.ToString(),codbarr.ToString(),peso.ToString(),_id_cliente.ToString(),_id_producto.ToString(),_id_color.ToString(),nu_rollo_.ToString());

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            try
            {              
                if (txtid_salida.Text != "")
                {
                    //ANULAR EL DETALLE
                    DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    {
                        if (result == DialogResult.OK)
                        {
                            ESalida_Detalle objDS = new ESalida_Detalle();

                            for (int i = 0; dgTempDet.Rows.Count > i; i++)
                            {
                                var nu_secue = dgTempDet.Rows[i].Cells["nusecuencia"].Value;
                                var cod_barra = dgTempDet.Rows[i].Cells["codbarra"].Value;
                                var peso = dgTempDet.Rows[i].Cells["peso"].Value;

                                var _id_cliente2 = dgTempDet.Rows[i].Cells["_id_cliente"].Value;
                                var _id_producto2 = dgTempDet.Rows[i].Cells["_id_producto"].Value;
                                var _id_color2 = dgTempDet.Rows[i].Cells["_id_color"].Value;
                                var _nu_rollo2 = dgTempDet.Rows[i].Cells["nu_rollo_"].Value;

                                objDS.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                                objDS.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion

                                objDS.IdSalida = txtid_salida.Text;
                                objDS.Nu_item = nu_secue.ToString();
                                objDS.CodBar = cod_barra.ToString();
                                objDS.Qt_peso = Convert.ToDecimal(peso);
                                objDS._pidreqsalida = txtnu_op.Text;
                                objDS._id_cliente = _id_cliente2.ToString();
                                objDS.Id_producto = _id_producto2.ToString();
                                objDS.Id_color = _id_color2.ToString();
                                objDS.Qt_rollo = Convert.ToInt16(_nu_rollo2);
                                objDS.Id_uupdarec = frmLogin.d.id.ToLower();
                                BSalida_Detalle.Al_Salida_Detalle_mnt03(objDS);
                            }

                          
                        }
                        else if (result == DialogResult.Cancel)
                        {

                        }
                        RefrescarOP();
                    }
                }
                dgvSalida.Rows.Remove(dgvSalida.CurrentRow);
                dgTempDet.Rows.Clear();

             

                mCalcula1();
                mCalcula2();
                
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmSalida_qry frmoc = new FrmSalida_qry();

            frmoc.pasard += new FrmSalida_qry.pasar(EjecutarOP);
            frmoc.ShowDialog();
            validacionBuscar();
            //btnAnular.Enabled = true;
            //btnGrabar.Enabled = false;
            //btnEditar.Enabled = true;
            //btnVistaPrevia.Enabled = true;

        }


        public void EjecutarOP(ESalida_Detalle obj)
        {
            txtbuscaridsalida.Text = obj.IdSalida;
            //txtid_op.Text = oc.Idreqsalida;
            //periodoOp = oc.IdPeriodo;

            BuscarSalida();
            editar = "1";
        }

        private void BuscarSalida()
        {
            ESalida objS = new ESalida();

            objS.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objS.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            txtbuscaridsalida.Text = txtbuscaridsalida.Text.PadLeft(7, '0');
            objS.IdSalida = txtbuscaridsalida.Text;

            List<ESalida> oListDato = BSalida.Al_Salida_qry05(objS);

            string val = oListDato[0].Existe;

            if (val == "0")
            {

                try
                {
                    validacionBuscar();
                    Nuevo();

                    ESalida objIng = new ESalida();

                    objIng.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objIng.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objIng.IdSalida = txtbuscaridsalida.Text;

                    ESalida oBtiene = new ESalida();
                    oBtiene = BSalida.AL_Salida_qry01(objIng);
                    txtid_salida.Text = oBtiene.IdSalida.ToString();
                    txtnu_op.Text = oBtiene.Idreqsalida.ToString();
                    txtid_emitido.Text = oBtiene.IdPersonal1;
                    txtds_emitido.Text = oBtiene.dsPersonal1.ToString();
                    txtid_local.Text = oBtiene.IdLocal.ToString().Trim();
                    cb_local.SelectedValue = txtid_local.Text;
                    txtfe_emision.Text = oBtiene.Fe_salida.ToString();
                    txtid_cliente.Text = oBtiene.Id_clipro.ToString().Trim();
                    txtds_cliente.Text = oBtiene.ds_clipro.ToString();
                    txtds_direccion.Text = oBtiene.Ds_direntrega.ToString().Trim();
                    txtid_formapago.Text = oBtiene.Id_condpago.ToString();
                    txtds_formapago.Text = oBtiene.ds_condpago.ToString();
                    txtnu_placa.Text = oBtiene.Ds_placa.ToString().Trim();
                    txtid_chofer.Text = oBtiene.IdPersonal2.ToString().Trim();
                    txtds_chofer.Text = oBtiene.dsPersonal2.ToString();
                    txtid_documento.Text = oBtiene.Id_docucom.ToString();
                    cb_tipdoc.SelectedValue = txtid_documento.Text;
                    txtid_vendedor.Text = oBtiene.Id_vendedor.ToString();
                    txtds_vendedor.Text = oBtiene.ds_vendedor.ToString();
                    txtds_observ.Text = oBtiene.Ds_observ.ToString();
                    txtfe_autorizado.Text = oBtiene.fe_autorizado.ToString();
                    txtfe_aprobado.Text = oBtiene.fe_aprobado.ToString();
                    txtid_prioridad.Text = oBtiene.id_prioridad.ToString();
                    cb_prioridad.SelectedValue = oBtiene.id_prioridad.ToString();
                    txtMoneda.Text = oBtiene.Id_vmoneda.ToString();
                    cbMoneda.SelectedValue = oBtiene.Id_vmoneda.ToString();

                    ESalida_Detalle objSD = new ESalida_Detalle();

                    objSD.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objSD.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objSD.IdSalida = txtbuscaridsalida.Text;


                    List<ESalida_Detalle> lstIG = new List<ESalida_Detalle>();
                    lstIG = BSalida_Detalle.AL_Salida_Detalle_qry01(objSD);

                    foreach (ESalida_Detalle _objSD in lstIG)
                    {
                        string[] row =
                        
                                {    _objSD.Nu_item,
                                     _objSD.CodBar,
                                     _objSD.Nu_tf,
                                     _objSD.Nu_op,
                                     _objSD.Id_mercado,
                                     _objSD.Id_tipo,
                                     _objSD.Id_tiptela,
                                     _objSD.Id_producto,
                                     _objSD.Ds_producto,
                                     _objSD.Id_color,
                                     _objSD.Ds_color,
                                     _objSD.Qt_rollo.ToString(),
                                     _objSD.Qt_peso_Actual.ToString(),
                                     _objSD.Qt_peso.ToString(),
                                     _objSD.Mt_precio.ToString(), 
                                     _objSD.Mt_igv.ToString(),
                                     _objSD.Mt_total.ToString(),
                                     _objSD._id_cliente.ToString(), 
                                     _objSD.Qt_peso_Disp.ToString(),
                                                    
                                };
                        dgvSalida.Rows.Add(row);
                    }

                    ///// detalle de OP

                    EOrdPedido_Detalle objOpd = new EOrdPedido_Detalle();

                    objOpd.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objOpd.IdPeriodo = wfChgEmpPer.datos.idperiodo;

                  
                    objOpd.Idreqsalida = txtnu_op.Text;

                    List<EOrdPedido_Detalle> lstOP = new List<EOrdPedido_Detalle>();
                    lstOP = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry02(objOpd);

                    foreach (EOrdPedido_Detalle _objOP in lstOP)
                    {
                        string[] row =
                        
                                {    _objOP.NuItem,
                                     _objOP.Id_clipro,
                                     _objOP.ds_clipro,
                                     _objOP.Id_producto,
                                     _objOP.ds_producto,
                                     _objOP.Id_color,
                                     _objOP.DsColor,
                                     _objOP.Qt_rollo.ToString(),
                                     _objOP.Qt_rollo_pend.ToString(),
                                     _objOP.Qt_peso.ToString(),
                                     _objOP.Id_vendedor,
                                     _objOP.Ds_vendedor,
                                     _objOP.Mt_preunit_actual.ToString(),
                                     _objOP._igvActivo.ToString(),
                                                        
                                };
                        dgOrdenPedido.Rows.Add(row);
                    }



                    mCalcula1();
                    mCalcula2();

                }

                catch (Exception ex)
                {
                    ex.ToString();
                }
                //mCalcula1();
                //mCalcula2();
            }
            else
            {
                MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nuevo();
                validacionNuevo();

            }


        }


        private void RefrescarOP()
        {

            dgOrdenPedido.Rows.Clear();

              EOrdPedido_Detalle objOpd = new EOrdPedido_Detalle();

                    objOpd.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objOpd.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objOpd.Idreqsalida =  txtnu_op.Text;

                    List<EOrdPedido_Detalle> lstOP = new List<EOrdPedido_Detalle>();
                    lstOP = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry02(objOpd);

                    foreach (EOrdPedido_Detalle _objOP in lstOP)
                    {
                        string[] row =
                        
                                {    _objOP.NuItem,
                                     _objOP.Id_clipro,
                                     _objOP.ds_clipro,
                                     _objOP.Id_producto,
                                     _objOP.ds_producto,
                                     _objOP.Id_color,
                                     _objOP.DsColor,
                                     _objOP.Qt_rollo.ToString(),
                                     _objOP.Qt_rollo_pend.ToString(),
                                     _objOP.Qt_peso.ToString(),
                                     _objOP.Id_vendedor,
                                     _objOP.Ds_vendedor,
                                     _objOP.Mt_preunit_actual.ToString(),
                                     _objOP._igvActivo.ToString(),
                                                        
                                };
                        dgOrdenPedido.Rows.Add(row);
                    }
                    mCalcula1();
                    mCalcula2();
        }
      public  string _drow;
      public string _peso;
        private void dgvSalida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            try
            {
               
                    DataGridViewRow dRow = dgvSalida.Rows[e.RowIndex];
                    _drow = dRow.Index.ToString();


                    ESalida_Detalle _obj = new ESalida_Detalle();

                    _obj.CodBar = (dRow.Cells["CodBar"].Value == null) ? "" : dRow.Cells["CodBar"].Value.ToString();
                    _obj.Nu_tf = (dRow.Cells["nu_tf"].Value == null) ? "" : dRow.Cells["nu_tf"].Value.ToString();
                    _obj.Nu_op = (dRow.Cells["nu_op"].Value == null) ? "" : dRow.Cells["nu_op"].Value.ToString();
                    _obj.Nu_item = (dRow.Cells["nu_item"].Value == null) ? "" : dRow.Cells["nu_item"].Value.ToString();
                    _obj.Id_mercado = (dRow.Cells["id_mercado"].Value == null) ? "" : dRow.Cells["id_mercado"].Value.ToString();


                    _obj.Id_tipo = (dRow.Cells["id_tipo"].Value == null) ? "" : dRow.Cells["id_tipo"].Value.ToString();
                    _obj.Id_tiptela = (dRow.Cells["tipo_tela"].Value == null) ? "" : dRow.Cells["tipo_tela"].Value.ToString();
                    _obj.Id_producto = (dRow.Cells["id_producto"].Value == null) ? "" : dRow.Cells["id_producto"].Value.ToString();
                    _obj.Ds_producto = (dRow.Cells["ds_producto"].Value == null) ? "" : dRow.Cells["ds_producto"].Value.ToString();


                    _obj.Id_color = (dRow.Cells["id_color"].Value == null) ? "" : dRow.Cells["id_color"].Value.ToString();
                    _obj.Ds_color = (dRow.Cells["ds_color"].Value == null) ? "" : dRow.Cells["ds_color"].Value.ToString();
                    _obj.Qt_rollo = (dRow.Cells["_nu_rollo"].Value == null) ? 0 : Convert.ToInt16(dRow.Cells["_nu_rollo"].Value.ToString());
                    _obj.Qt_peso_Actual = (dRow.Cells["peso_actual"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["peso_actual"].Value.ToString());
                    _obj.Qt_peso = (dRow.Cells["qt_peso"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["qt_peso"].Value.ToString());
                    _obj.Mt_precio = (dRow.Cells["mt_precio"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["mt_precio"].Value.ToString());


                    _obj.Mt_igv = (dRow.Cells["mt_igv"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["mt_igv"].Value.ToString());
                    _obj._id_cliente = (dRow.Cells["id_cliente"].Value == null) ? "" : (dRow.Cells["id_cliente"].Value.ToString());
                    _obj.Qt_peso_Disp = (dRow.Cells["Peso_disponible"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["Peso_disponible"].Value.ToString());
                    //_obj. = (dRow.Cells["id_cliente"].Value == null) ? "" : (dRow.Cells["id_cliente"].Value.ToString());


                FrmSalidaProducto_ModifPopup frm = new FrmSalidaProducto_ModifPopup();

                    if (editar == "0")
                    {
                    
                    frm.FormParent = this;
                    frm.EstadoDet = 1;
                    frm._index = _drow;
                    frm.LLenarCampos(_obj);
                    }
                    else
                    {                                      
                    frm.FormParent = this;
                    frm.EstadoDet = 1;
                    frm._index = _drow;
                    frm.LLenarCampos(_obj);
                    }

            

                ESalida_Detalle obj = new ESalida_Detalle();
                for (int i = 0; dgvSalida.Rows.Count > i; i++)
                {
                    var nu_item = dgvSalida.Rows[i].Cells["nu_item"].Value.ToString();
                    var CodBar = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();
                    var nu_tf = dgvSalida.Rows[i].Cells["nu_tf"].Value.ToString();
                    var nu_op = dgvSalida.Rows[i].Cells["nu_op"].Value.ToString();
                    var id_mercado = dgvSalida.Rows[i].Cells["id_mercado"].Value.ToString();
                    var id_tipo = dgvSalida.Rows[i].Cells["id_tipo"].Value.ToString();
                    var tipo_tela = dgvSalida.Rows[i].Cells["tipo_tela"].Value.ToString();
                    var _id_producto = dgvSalida.Rows[i].Cells["id_producto"].Value.ToString();
                    var _ds_producto = dgvSalida.Rows[i].Cells["ds_producto"].Value.ToString();
                    var id_color = dgvSalida.Rows[i].Cells["id_color"].Value.ToString();
                    var ds_color = dgvSalida.Rows[i].Cells["ds_color"].Value.ToString();
                    var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value.ToString();
                    var qt_peso_actual = dgvSalida.Rows[i].Cells["peso_actual"].Value.ToString();
                    var qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value.ToString();
                    var mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value.ToString();
                    var mt_igv = dgvSalida.Rows[i].Cells["mt_igv"].Value.ToString();
                    var mt_total = dgvSalida.Rows[i].Cells["mt_total"].Value.ToString();
                    var id_cliente = dgvSalida.Rows[i].Cells["id_cliente"].Value.ToString();

                    obj.Nu_item = nu_item.ToString();
                    obj.CodBar = CodBar.ToString();
                    obj.Nu_tf = nu_tf.ToString();
                    obj.Nu_op = nu_op.ToString();
                    obj.Id_mercado = id_mercado.ToString();
                    obj.Id_tipo = id_tipo.ToString();
                    obj.Id_tiptela = tipo_tela.ToString();
                    obj.Id_producto = _id_producto.ToString();
                    obj.Ds_producto = _ds_producto.ToString();
                    obj.Id_color = id_color.ToString();
                    obj.Ds_color = ds_color.ToString();
                    obj.Qt_rollo = Convert.ToInt16(_nu_rollo);
                    obj.Qt_peso_Actual = Convert.ToDecimal(qt_peso_actual);
                    obj.Qt_peso = Convert.ToDecimal(qt_peso);
                    
                    obj.Mt_precio = Convert.ToDecimal(mt_precio);
                    obj.Mt_igv = Convert.ToDecimal(mt_igv);
                    obj.Mt_total = Convert.ToDecimal(mt_total);
                    obj._id_cliente = id_cliente;
                    
                    frm.LlenarGrilla(obj, this);

                    //  frm._lblIdIngreso = (idIngreso);
                }
           
            
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
        private void CargarGrid()
        {
            
            ESalida_Detalle obj = new ESalida_Detalle();
            FrmSalidaProducto_ModifPopup frm = new FrmSalidaProducto_ModifPopup();
            for (int i = 0; dgvSalida.Rows.Count > i; i++)
            {
                var nu_item = dgvSalida.Rows[i].Cells["nu_item"].Value.ToString();
                var CodBar = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();
                var nu_tf = dgvSalida.Rows[i].Cells["nu_tf"].Value.ToString();
                var nu_op = dgvSalida.Rows[i].Cells["nu_op"].Value.ToString();
                var id_mercado = dgvSalida.Rows[i].Cells["id_mercado"].Value.ToString();
                var id_tipo = dgvSalida.Rows[i].Cells["id_tipo"].Value.ToString();
                var tipo_tela = dgvSalida.Rows[i].Cells["tipo_tela"].Value.ToString();
                var _id_producto = dgvSalida.Rows[i].Cells["id_producto"].Value.ToString();
                var _ds_producto = dgvSalida.Rows[i].Cells["ds_producto"].Value.ToString();
                var id_color = dgvSalida.Rows[i].Cells["id_color"].Value.ToString();
                var ds_color = dgvSalida.Rows[i].Cells["ds_color"].Value.ToString();
                var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value.ToString();
                var qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value.ToString();
                var mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value.ToString();

                var mt_igv = dgvSalida.Rows[i].Cells["mt_igv"].Value.ToString();
                var mt_total = dgvSalida.Rows[i].Cells["mt_total"].Value.ToString();

                var id_cliente = dgvSalida.Rows[i].Cells["id_cliente"].Value.ToString();

                obj.Nu_item = nu_item.ToString();
                obj.CodBar = CodBar.ToString();
                obj.Nu_tf = nu_tf.ToString();
                obj.Nu_op = nu_op.ToString();
                obj.Id_mercado = id_mercado.ToString();
                obj.Id_tipo = id_tipo.ToString();
                obj.Id_tiptela = tipo_tela.ToString();
                obj.Id_producto = _id_producto.ToString();
                obj.Ds_producto = _ds_producto.ToString();
                obj.Id_color = id_color.ToString();
                obj.Ds_color = ds_color.ToString();
                obj.Qt_rollo = Convert.ToInt16(_nu_rollo);
                obj.Qt_peso = Convert.ToDecimal(qt_peso);
                obj.Mt_precio = Convert.ToDecimal(mt_precio);
                obj.Mt_igv = Convert.ToDecimal(mt_igv);
                obj.Mt_total = Convert.ToDecimal(mt_total);
                obj._id_cliente = id_cliente;
                frm.LlenarGrilla(obj, this);

              //  frm._lblIdIngreso = (idIngreso);
            }
            //frm.pasard += new FrmProductoDetallePopup.pasar(ejecutarConsulta);
            //frm.EstadoDet = 1;
            frm.ShowDialog();
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
                obj.Qt_rollo_pend = (dRow.Cells["qt_rollo_pend"].Value == null) ? 0 : Convert.ToInt32(dRow.Cells["qt_rollo_pend"].Value.ToString());
                obj.Qt_peso = (dRow.Cells["Peso_desp"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["Peso_desp"].Value.ToString());
                obj.Id_vendedor = (dRow.Cells["id_Vendedor"].Value == null) ? "" : dRow.Cells["id_Vendedor"].Value.ToString();
                obj.Ds_vendedor = (dRow.Cells["ds_Vendedor"].Value == null) ? "" : dRow.Cells["ds_Vendedor"].Value.ToString();
                obj.Mt_preunit_actual = (dRow.Cells["precio_unitario"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["precio_unitario"].Value.ToString());
                string chkCell = dRow.Cells["chkIgv"].Value.ToString();
                obj._igvActivo = Convert.ToBoolean(chkCell);
                FrmSalida_Detalle_popup frm = new FrmSalida_Detalle_popup();
                frm.FormParent = this;
                frm.EstadoDet = 2;
                frm.idSalida = txtid_salida.Text;
                frm.idreqsalida = txtnu_op.Text;

                frm.LLenarCampos(obj);

                //-------------------------------------------------------
                //if (txtid_salida.Text.Trim() =="")
                //{
                //    ESalida_Detalle _obj = new ESalida_Detalle();

                //    for (int i = 0; dgvSalida.Rows.Count > i; i++)
                //    {
                //        var nu_item = dgvSalida.Rows[i].Cells["nu_item"].Value.ToString();
                //        var CodBar = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();
                //        var nu_tf = dgvSalida.Rows[i].Cells["nu_tf"].Value.ToString();
                //        var nu_op = dgvSalida.Rows[i].Cells["nu_op"].Value.ToString();
                //        var id_mercado = dgvSalida.Rows[i].Cells["id_mercado"].Value.ToString();
                //        var id_tipo = dgvSalida.Rows[i].Cells["id_tipo"].Value.ToString();
                //        var tipo_tela = dgvSalida.Rows[i].Cells["tipo_tela"].Value.ToString();
                //        var _id_producto = dgvSalida.Rows[i].Cells["id_producto"].Value.ToString();
                //        var _ds_producto = dgvSalida.Rows[i].Cells["ds_producto"].Value.ToString();
                //        var id_color = dgvSalida.Rows[i].Cells["id_color"].Value.ToString();
                //        var ds_color = dgvSalida.Rows[i].Cells["ds_color"].Value.ToString();
                //        var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value.ToString();
                //        var qt_peso_actual = dgvSalida.Rows[i].Cells["peso_actual"].Value.ToString();
                //        var qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value.ToString();
                //        var mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value.ToString();
                //        var mt_igv = dgvSalida.Rows[i].Cells["mt_igv"].Value.ToString();
                //        var mt_total = dgvSalida.Rows[i].Cells["mt_total"].Value.ToString();
                //        var id_cliente = dgvSalida.Rows[i].Cells["id_cliente"].Value.ToString();

                //        _obj.Nu_item = nu_item.ToString();
                //        _obj.CodBar = CodBar.ToString();
                //        _obj.Nu_tf = nu_tf.ToString();
                //        _obj.Nu_op = nu_op.ToString();
                //        _obj.Id_mercado = id_mercado.ToString();
                //        _obj.Id_tipo = id_tipo.ToString();
                //        _obj.Id_tiptela = tipo_tela.ToString();
                //        _obj.Id_producto = _id_producto.ToString();
                //        _obj.Ds_producto = _ds_producto.ToString();
                //        _obj.Id_color = id_color.ToString();
                //        _obj.Ds_color = ds_color.ToString();
                //        _obj.Qt_rollo = Convert.ToInt16(_nu_rollo);
                //        _obj.Qt_peso_Actual = Convert.ToDecimal(qt_peso_actual);
                //        _obj.Qt_peso = Convert.ToDecimal(qt_peso);

                //        _obj.Mt_precio = Convert.ToDecimal(mt_precio);
                //        //_obj.Mt_igv = Convert.ToDecimal(mt_igv);
                //        //_obj.Mt_total = Convert.ToDecimal(mt_total);
                //        //_obj._id_cliente = id_cliente;

                //        frm.LlenarGrilla_temp(_obj, this);


                //    }
                //}
                //else
                //{ 

                //}
                //-------------------------------------------------------



                frm.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void  CargarGrilla(ESalida_Detalle obj, object form)
        {
            int countRows = dgvSalida.Rows.Count - 1;
            if (countRows >= 0)
            {
                valorCelda = dgvSalida.Rows[countRows].Cells["nu_item"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }

            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            //------------------------------------------------------------------------

            int count2 = 0;
            for (int i = 0; dgvSalida.Rows.Count > i; i++)
            {
                var codBarra = dgvSalida.Rows[i].Cells["CodBar"].Value.ToString();


                if (codBarra == obj.CodBar)
                {
                    count2 = count2 + 1;
                }
                else
                {

                }
            }


            //-------------------------------------------------------------------------

            if (count2 == 0)
            {
                string[] row = { 
                             obj.Nu_item=item.PadLeft(2, '0'),
                             obj.CodBar,
                             obj.Nu_tf,
                             obj.Nu_op,
                             obj.Id_mercado,
                             obj.Id_tipo,
                             obj.Id_tiptela,
                             obj.Id_producto,
                             obj.Ds_producto,
                             obj.Id_color,
                             obj.Ds_color,                             
                             obj.Qt_rollo.ToString(),
                             string.Format("{0:##,##0.0000}",obj.Qt_peso_Actual),
                             string.Format("{0:##,##0.0000}",obj.Qt_peso),
                             string.Format("{0:##,##0.0000}",obj.Mt_precio), 
                             string.Format("{0:##,##0.0000}",obj.Mt_igv),
                             string.Format("{0:##,##0.0000}",obj.Mt_total), 
                             obj._id_cliente,
                            };

                dgvSalida.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Ya existe este Articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSalida_Detalle_popup frm = (FrmSalida_Detalle_popup)form;
                frm.Close();
            }
            mCalcula1();
            mCalcula2();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmSalida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Nuevo();
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                //Grabar();
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {

            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                FrmSalida_rpt01 frm = new FrmSalida_rpt01();
                frm.nuSalida = txtid_salida.Text;
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrmSalida_qry frmoc = new FrmSalida_qry();
                frmoc.pasard += new FrmSalida_qry.pasar(EjecutarOP);
                frmoc.ShowDialog();

            }

            else if (e.KeyCode == Keys.E && e.Control)
            {

            }
            else if (e.KeyCode == Keys.O && e.Control)
            {
                FrmOrdenPedido_qry frmoc = new FrmOrdenPedido_qry();
                frmoc.pasard += new FrmOrdenPedido_qry.pasar(EjecutarOP);
                frmoc.ShowDialog();

            }
            else  if (e.KeyCode == Keys.Escape)
            {
              
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {
                FrmSalidaProducto_Popup frm = new FrmSalidaProducto_Popup();
                frm.FormParent = this;
                frm.EstadoDet = 1;
                frm.ShowDialog();
               
            }
        
        }


        protected void mCalcula1()
        {
            try
            {

                decimal totdeTotrollo1 = 0;
  

                for (int x = 0; x < dgOrdenPedido.Rows.Count; x++)
                {

                    decimal nu_rollo = Convert.ToDecimal(dgOrdenPedido.Rows[x].Cells["nu_rollo"].Value);


                    totdeTotrollo1 = totdeTotrollo1 + nu_rollo;


                    lblsumrollo1.Text = string.Format("{0:##,##0.0000}", totdeTotrollo1);
                  

                }

              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }



        protected void mCalcula2()
        {
            try
            {

                decimal tot_igv = 0;
                decimal tot_subtotal = 0;
                decimal totpesorollo1 = 0;
          
                int tot_rollo = 0;
                decimal Total = 0;

                for (int x = 0; x < dgvSalida.Rows.Count; x++)
                {

                    int nu_rollo = Convert.ToInt16(dgvSalida.Rows[x].Cells["_nu_rollo"].Value);

                    decimal qt_peso = Convert.ToDecimal(dgvSalida.Rows[x].Cells["qt_peso"].Value);
                    decimal mt_precio = Convert.ToDecimal(dgvSalida.Rows[x].Cells["mt_precio"].Value);
                    decimal mt_igv = Convert.ToDecimal(dgvSalida.Rows[x].Cells["mt_igv"].Value);
                    decimal mt_subtotal = Convert.ToDecimal(dgvSalida.Rows[x].Cells["mt_total"].Value);
                                     
                    totpesorollo1 = totpesorollo1 + qt_peso;
                    tot_rollo = tot_rollo + nu_rollo;
                    tot_igv = tot_igv + mt_igv;
                    tot_subtotal = tot_subtotal + mt_subtotal;
                    Total = tot_subtotal + tot_igv;
                    txtsubTotal.Text = string.Format("{0:##,##0.0000}", tot_subtotal);
                    txtTotIgv.Text = string.Format("{0:##,##0.0000}", tot_igv);
                    txttotal.Text = string.Format("{0:##,##0.0000}", Total);                    
                    txttotpesorollo.Text = string.Format("{0:##,##0.00}", totpesorollo1);
                    txttotnumrollos.Text = tot_rollo.ToString();

                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void dgOrdenPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgOrdenPedido.Columns["chkIgv"].Index)
            {
                dgOrdenPedido.EndEdit();
            }
        }

        private void txtMoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtMoneda.Text = txtMoneda.Text.PadLeft(3, '0');
                cbMoneda.SelectedValue = txtMoneda.Text;

                if (txtMoneda.Text != "")
                {
                    txtds_observ.Focus();
                    txtds_observ.SelectionStart = 0;
                    txtds_observ.SelectionLength = txtds_observ.Text.Length;
                }
                else
                {
                    MessageBox.Show("Moneda no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMoneda.Clear();
                    txtMoneda.Focus();
                }




              

            } 
        }

        private void cbMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtMoneda.Text = cbMoneda.SelectedValue.ToString();
            txtMoneda.Focus();
        }

        private void cb_local_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtid_local.Text = cb_local.SelectedValue.ToString();
            txtid_local.Focus();
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

        private void txtbuscaridsalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarSalida();
                editar = "1";
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            //validacionVistaPrevia();
            FrmSalida_rpt01 frm = new FrmSalida_rpt01();
            frm.nuSalida = txtid_salida.Text;
            frm.ShowDialog();
            btnGrabar.Enabled = false;
        }
        string editar = "0";
        private void btnEditar_Click(object sender, EventArgs e)
        {
            validacionEditar();
            btnReqOP.Enabled = true;
            btnCliente.Enabled = true;
            btnFormapago.Enabled = true;
            btnvendedor.Enabled = true;
            btnchofer.Enabled = true;
            btnNuevoItem.Enabled = true;
            btnEliminarItem.Enabled = true;
            dgvSalida.Enabled = true;
            btnNuevoItem.Enabled = true;
            btnEliminarItem.Enabled = true;
            btnGrabar.Enabled = true;

            editar = "1";
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

        private void btnFormapago_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                Frmcocondicionpago_qry frmcp = new Frmcocondicionpago_qry();
                frmcp.pasard += new Frmcocondicionpago_qry.pasar(ejecutarCondpago);
                frmcp.ShowDialog();
                txtid_formapago.Focus();
            }

        }

        private void txtid_vendedor_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                FrmVendedor_qry frmps = new FrmVendedor_qry();
                frmps.pasard += new FrmVendedor_qry.pasar(ejecutarVendedor);
                frmps.ShowDialog();
                txtid_vendedor.Focus();
            }
          
        }

        private void txtid_chofer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPersonal_qry frmps = new frmPersonal_qry();
                frmps.pasard += new frmPersonal_qry.pasar(ejecutarPers);
                frmps.ShowDialog();
                txtid_chofer.Focus();
            }          
        }

        private void txtnu_op_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmOrdenPedido_qry frmoc = new FrmOrdenPedido_qry();
                frmoc.pasard += new FrmOrdenPedido_qry.pasar(EjecutarOP);
                frmoc.ShowDialog();
            }            
        }

        private void txtnu_op_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_salida.Focus();

            }
        }

        private void txtid_salida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtfe_emision.Focus();

            }
        }

        private void txtfe_emision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_emitido.Focus();

            }
        }

        private void txtid_emitido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_local.Focus();

            }
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

        private void txtid_prioridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_cliente.Focus();

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
                txtid_formapago.Focus();

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
                    txtid_chofer.Focus();
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

        private void txtid_chofer_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtid_chofer.Text = txtid_chofer.Text.PadLeft(5, '0');
                EPersonalBandeja per = new EPersonalBandeja();
                per.psintypesel = 1;
                per.IdPersonal = txtid_chofer.Text;
                per.NuDocIden = "";
                per.DsApellNom = "";
                ComboBox cb = new ComboBox();

                List<Dato> oListDato = BPersonalBandeja.ObtenerDatoPersonal(per);
                if (oListDato.Count > 0)
                {
                    txtds_chofer.Text = oListDato[0].desc;
                    txtid_chofer.SelectionStart = 0;
                    txtid_chofer.SelectionLength = txtid_chofer.Text.Length;
                }
                else
                {
                    MessageBox.Show("Vendedor no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtid_chofer.Clear();
                    txtds_chofer.Clear();
                    txtid_chofer.Focus();
                }

                txtnu_placa.Focus();
            }
        }

        private void txtnu_placa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtds_observ.Focus();
            }
        }

        public void ModGuilla(ESalida_Detalle obj, object form)
        {


            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_item"]).Value = obj.Nu_item;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["CodBar"]).Value = obj.CodBar;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_tf"]).Value = obj.Nu_tf;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_op"]).Value = obj.Nu_op;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_mercado"]).Value = obj.Id_mercado;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_tipo"]).Value = obj.Id_tipo;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["tipo_tela"]).Value = obj.Id_tiptela;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_producto"]).Value = obj.Id_producto;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["ds_producto"]).Value = obj.Ds_producto;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_color"]).Value = obj.Id_color;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["ds_color"]).Value = obj.Ds_color;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["_nu_rollo"]).Value = obj.Qt_rollo;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["qt_peso"]).Value = obj.Qt_peso;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_precio"]).Value = obj.Mt_precio;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_igv"]).Value = obj.Mt_igv;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_total"]).Value = obj.Mt_total;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_cliente"]).Value = obj._id_cliente;


            FrmSalidaProducto_ModifPopup frm = (FrmSalidaProducto_ModifPopup)form;
            //frm.EstadoDet = 2;
            mCalcula2();



            frm.Close();
        }


        public void ModGuilla2(ESalida_Detalle obj, object form)
        {


            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_item"]).Value = obj.Nu_item;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["CodBar"]).Value = obj.CodBar;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_tf"]).Value = obj.Nu_tf;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["nu_op"]).Value = obj.Nu_op;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_mercado"]).Value = obj.Id_mercado;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_tipo"]).Value = obj.Id_tipo;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["tipo_tela"]).Value = obj.Id_tiptela;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_producto"]).Value = obj.Id_producto;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["ds_producto"]).Value = obj.Ds_producto;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_color"]).Value = obj.Id_color;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["ds_color"]).Value = obj.Ds_color;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["_nu_rollo"]).Value = obj.Qt_rollo;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["qt_peso"]).Value = obj.Qt_peso;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_precio"]).Value = obj.Mt_precio;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_igv"]).Value = obj.Mt_igv;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["mt_total"]).Value = obj.Mt_total;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["id_cliente"]).Value = obj._id_cliente;
            (dgvSalida.Rows[int.Parse(_drow)].Cells["Peso_disponible"]).Value = obj.Qt_peso_Disp;


            FrmSalidaProducto_ModifPopup frm = (FrmSalidaProducto_ModifPopup)form;
            //frm.EstadoDet = 2;

            mCalcula2();
            //Imprimir();


            //frm.Close();
        }

        //private void Imprimir()
        //{
        //    decimal peso2 = Convert.ToDecimal((dgvSalida.Rows[int.Parse(_drow)].Cells["qt_peso"]).Value);
        //    if (Convert.ToDecimal(_peso) > peso2)
        //    {

        //        MessageBox.Show("imprimir");
        //    }
        //    else
        //    {

        //    }
        //}

        private void Imprimir2()
        {
            //decimal peso2 = Convert.ToDecimal((dgvSalida.Rows[int.Parse(_drow)].Cells["qt_peso"]).Value);

            for (int x = 0; x < dgvSalida.Rows.Count; x++)
            {
                decimal peso1 = Convert.ToDecimal((dgvSalida.Rows[x].Cells["peso_actual"]).Value);
                decimal peso2 = Convert.ToDecimal((dgvSalida.Rows[x].Cells["qt_peso"]).Value);

                if (peso1 > peso2)
                {

                }
                else
                { 

                }

            }



            //if (Convert.ToDecimal(_peso) > peso2)
            //{

            //    MessageBox.Show("imprimir");
            //}
            //else
            //{

            //}
        }


        public void PrintReport(string key)
        {

            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport2(key);

                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta03.rpt";
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

        public object GetDataReport2(string key)
        {
            DataSet ds = new DataSet();

            string idcodbarra = "";
            int count3 = 0;

            for (int x = 0; x < dgvSalida.Rows.Count; x++)
            {
                decimal peso1 = Convert.ToDecimal((dgvSalida.Rows[x].Cells["Peso_disponible"]).Value);
                decimal peso2 = Convert.ToDecimal((dgvSalida.Rows[x].Cells["qt_peso"]).Value);
                string codbarra = dgvSalida.Rows[x].Cells["CodBar"].Value.ToString();
                //decimal pesoDisp = peso1 - peso2;

               

                if (peso1 > peso2)
              //  if(pesoDisp >0)
                {
                    count3 = count3 + 1;

                    idcodbarra = idcodbarra + "," + codbarra;

                }
                else
                { 

                }
            }
                if (count3 > 0)
                {
                    EIngresoDetalle objE = new EIngresoDetalle();

                    objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objE.Cod_Bar = idcodbarra.Substring(1, idcodbarra.Length - 1); //solo podra coger 55 codigos de barra, suficiente como para una salida 

                    BIngreso_Detalle objI = new BIngreso_Detalle();
                    DataTable dt = objI.AL_Ingreso_etiqueta03_rpt(objE);



                    ds.Tables.Add(dt);
                    return ds;
                } 
      
            return ds;             
        }



        private void dgvSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Anular el Despacho?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    ESalida_Detalle objDS = new ESalida_Detalle();
                    btnGrabar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnVistaPrevia.Enabled = false;
                    for (int i = 0; dgvSalida.Rows.Count > i; i++)
                    {
                        var nu_secue = dgvSalida.Rows[i].Cells["nu_item"].Value;
                        var cod_barra = dgvSalida.Rows[i].Cells["CodBar"].Value;
                        var peso = dgvSalida.Rows[i].Cells["qt_peso"].Value;

                        var _id_cliente2 = dgvSalida.Rows[i].Cells["id_cliente"].Value;
                        var _id_producto2 = dgvSalida.Rows[i].Cells["id_producto"].Value;
                        var _id_color2 = dgvSalida.Rows[i].Cells["id_color"].Value;
                        var _nu_rollo2 = dgvSalida.Rows[i].Cells["_nu_rollo"].Value;

                        objDS.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objDS.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion

                        objDS.IdSalida = txtid_salida.Text;
                        objDS.Nu_item = nu_secue.ToString();
                        objDS.CodBar = cod_barra.ToString();
                        objDS.Qt_peso = Convert.ToDecimal(peso);
                        objDS._pidreqsalida = txtnu_op.Text;
                        objDS._id_cliente = _id_cliente2.ToString();
                        objDS.Id_producto = _id_producto2.ToString();
                        objDS.Id_color = _id_color2.ToString();
                        objDS.Qt_rollo = Convert.ToInt16(_nu_rollo2);
                        objDS.Id_uupdarec = frmLogin.d.id.ToLower();
                        BSalida_Detalle.Al_Salida_Detalle_mnt04(objDS);
                        // btnGrabar_Click() = false;
                    }


                }
                else if (result == DialogResult.Cancel)
                {

                }
                RefrescarOP();
            }
        }

        /*
         * Validacion
         * usuario :jvillavicencio
         * 
         */ 
        public void validacionNuevo()
        {
            btnEditar.Enabled = false;
            btnGrabar.Enabled = true;
            btnVistaPrevia.Enabled = false;
            btnAnular.Enabled = false;
        }
        public void validacionEditar()
        {
            btnGrabar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGrabar.Enabled = true;
            btnVistaPrevia.Enabled = false;
        }

        public void validacionGrabar()
        {
            btnGrabar.Enabled = false;
            btnEditar.Enabled = true;
            btnVistaPrevia.Enabled = true;
        }
        public void validacionVistaPrevia()
        {
            Nuevo();
        }
        public void validacionBuscar()
        {
            btnAnular.Enabled = true;
            btnGrabar.Enabled = false;
            btnEditar.Enabled = true;
            btnVistaPrevia.Enabled = true;
            btnNuevo.Enabled = true;
        }
        public void validacionFrmSalida()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnVistaPrevia.Enabled = false;
            btnAnular.Enabled = false;
        }


    }
}
