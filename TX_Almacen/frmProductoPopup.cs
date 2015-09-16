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
using Texfina.BOQry.TJ;
using Texfina.Core.Web;
using Texfina.Entity.Al;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace TX_Almacen
{
    public partial class frmProductoPopup : Form
    {
        public frmProductoPopup()
        {
            InitializeComponent();
            WebHelper.LoadListControl3(cbtipo, BGeneral.ObtenerDatoidTabla("145"));
            WebHelper.LoadListControl3(cbtipIng, BGeneral.ObtenerDatoidTabla("146"));
            WebHelper.LoadListControl3(cb_mercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cb_tipoTela, BGeneral.ObtenerDatoidTabla("147"));
            this.ActiveControl = txtTf;
            txtTf.Focus();
        }
        public object FormParent { get; set; }

        public int EstadoDet = 0;// esto define si se añade un nuevo Item o solo va a ser modificado el item  // 1 --> para añadir un nuevo item , 2 --> para modificar un item
        //public string fecha, _idIngreso;
        public string _idIngreso;
        private void frmProductoPopup_Load(object sender, EventArgs e)
        {

            if (EstadoDet == 1)
            {
                //this.Size = new Size(438, 441);
                detalle = "1";
                this.Width = 438;
                cbtipIng.SelectedIndex = -1;
                cbtipo.SelectedIndex = -1;
                cb_mercado.SelectedIndex = -1;
                cb_tipoTela.SelectedIndex = -1;

                txtpesoDesp.Text = string.Format("{0:##,##0.0000}", 0);
                txtancho.Text = string.Format("{0:##,##0.0000}", 0);
                txtdensidad.Text = string.Format("{0:##,##0.0000}", 0);
                txtTf.Focus();
                //btnAddRow.Enabled = false;
            }
            else if (EstadoDet == 2)
            {
                detalle = "1";
                this.Width = 438;
                txtnurollo.Enabled = false;
                txtTf.Enabled = false;
                txtidproducto.Enabled = false;
                txtTf.Focus();
                //btnAddRow.Enabled = true;
            }

        }

        private void txtTf_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtTf.Text= txtTf.Text.PadLeft(7, '0');

            
               txtnuop.Focus();
               txtnuop.SelectionStart = 0;
               txtnuop.SelectionLength = txtnuop.Text.Length;
            }
        }

        private void txtnuop_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cb_mercado.Focus();
            }
        }

        private void cbtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbtipIng.Focus();
            }
        }

        private void cbtipIng_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cb_tipoTela.Focus();
            }
        }

        private void txtidcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
             {
                 txtidcliente.Text = txtidcliente.Text.PadLeft(6, '0');

                 ECliente per = new ECliente();
                 per.psintypesel = 1;
                 per.Ds_raznombre = "";
                 per.Id_clipro = txtidcliente.Text;
                 per.Nu_ruc = "";
                 per.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                 List<Dato> oListDato = BCliente.ObtenerDatoCliente(per);

                 if (oListDato.Count > 0)
                 {
                     lblCliente.Text = oListDato[0].desc;

                     txtidVendedor.SelectionStart = 0;
                     txtidVendedor.SelectionLength = txtidVendedor.Text.Length;
                     txtidVendedor.Focus();
                 }
                 else
                 {
                     MessageBox.Show("Cliente no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtidcliente.Clear();
                     lblCliente.Text = "";
                     txtidcliente.Focus();
                 }



             }

        }

        private void txtidproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                 txtidcolor.Focus();

                 txtidcolor.SelectionStart = 0;
                 txtidcolor.SelectionLength = txtidcolor.Text.Length;
            }



        }

        private void txtidcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
     
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
             {
                 txtidcolor.Text = txtidcolor.Text.PadLeft(9, '0');

                 EColor per = new EColor();
                 per.psintypesel = 1;
                 per.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 
                 per.Id_color = txtidcolor.Text;
                 per.Ds_color = "";

                 List<Dato> oListDato = BColor.ObtenerDatoColor(per);

                 if (oListDato.Count > 0)
                 {
                     lblcolor.Text = oListDato[0].desc;

                     txtidcliente.SelectionStart = 0;
                     txtidcliente.SelectionLength = txtidcliente.Text.Length;
                     txtidcliente.Focus();
                 }
                 else
                 {
                     MessageBox.Show("Color no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtidcolor.Clear();
                     lblcolor.Text="";
                     txtidcolor.Focus();
                 }



             }




        }

        private void txtnurollo_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpesoDesp.Focus();

                txtpesoDesp.SelectionStart = 0;
                txtpesoDesp.SelectionLength = txtpesoDesp.Text.Length;
            }
        }

        private void txtpesoDesp_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtancho.Focus();
                txtancho.SelectionStart = 0;
                txtancho.SelectionLength = txtancho.Text.Length;
            }
        }

        private void txtancho_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdensidad.Focus();
                txtdensidad.SelectionStart = 0;
                txtdensidad.SelectionLength = txtdensidad.Text.Length;
            }
        }

        private void btnprodupop_Click(object sender, EventArgs e)
        {

            frmProducto_qry frmp = new frmProducto_qry();
            frmp.pasard += new frmProducto_qry.pasar(ejecutarProd);
            frmp.ShowDialog();
            txtidproducto.Focus();
        }

        public void ejecutarProd(EDetProducto prd)
        {
            txtidproducto.Text = prd._Codigo;           
            lblProducto.Text = prd._Producto;
        }

        private void btncolorpop_Click(object sender, EventArgs e)
        {

            frnColor_qry frmp = new frnColor_qry();
            frmp.pasard += new frnColor_qry.pasar(ejecutarColor);
            frmp.ShowDialog();
            txtidcolor.Focus();
        }

        public void ejecutarColor(EColor col)
        {
            txtidcolor.Text = col.Id_color;
            lblcolor.Text = col.Ds_color;
        }

        private void btnClientepop_Click(object sender, EventArgs e)
        {
            frmCliente_qry frmp = new frmCliente_qry();
            frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
            frmp.ShowDialog();
            txtidcliente.Focus();
        }

        public void ejecutarCliente(ECliente cl)
        {
            txtidcliente.Text = cl.Id_clipro;
            lblCliente.Text = cl.Ds_raznombre;
        }

        private void txtidcliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmCliente_qry frmp = new frmCliente_qry();
                frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
                frmp.ShowDialog();
                txtidcliente.Focus();
            }
        }

        private void txtidproducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmProducto_qry frmp = new frmProducto_qry();
                frmp.pasard += new frmProducto_qry.pasar(ejecutarProd);
                frmp.ShowDialog();
                txtidproducto.Focus();
            }

        }

        private void txtidcolor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frnColor_qry frmp = new frnColor_qry();
                frmp.pasard += new frnColor_qry.pasar(ejecutarColor);
                frmp.ShowDialog();
                txtidcolor.Focus();
            }
        }

        private void txtpesoDesp_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtancho_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtdensidad_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            EIngresoDetalle obj = new EIngresoDetalle();
            obj.Nu_Item = txtitem.Text;
            obj.Nu_tf = txtTf.Text;
            obj.Nu_op = txtnuop.Text;
            try
            {
                obj.Id_mercado = cb_mercado.SelectedValue.ToString();
                obj.Id_tipTela = cb_tipoTela.SelectedValue.ToString();
                obj.Id_Tipo = cbtipo.SelectedValue.ToString();
                obj.Id_TipIngreso = cbtipIng.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


            obj.Id_clipro = txtidcliente.Text.Trim();
            obj.Id_producto = txtidproducto.Text.Trim();
            obj.Id_color = txtidcolor.Text.Trim();
            obj.Qt_rollo = Convert.ToInt16(txtnurollo.Value);
            obj.Qt_peso_desp = Convert.ToDecimal(txtpesoDesp.Text);
            obj.Qt_ancho = Convert.ToDecimal(txtancho.Text);
            obj.Qt_densidad = Convert.ToDecimal(txtdensidad.Text);
            obj.ds_producto = lblProducto.Text;
            obj.ds_clipro = lblCliente.Text;
            obj.ds_color = lblcolor.Text;
            obj.id_Vendedor = txtidVendedor.Text;
            obj.Ds_Vendedor = lblVendedor.Text;

 


            if (EstadoDet == 1)
            {
                if ((txtTf.Text != "") & (txtnuop.Text != "") & (txtidcliente.Text != "") & (txtidproducto.Text != "") & (txtidcolor.Text != "") & (txtnurollo.Text != "") & (txtidVendedor.Text != "") & (cbtipIng.Text != "") & (cbtipo.Text != ""))
                {
                    frmIngreso frmanterior = (frmIngreso)FormParent;

                    frmanterior.LlenarGrilla(obj, this);
                
                    this.Close();
                


                }
                else
                {
                    MessageBox.Show("Falta completar información ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (EstadoDet == 2)
            {
                if ((txtTf.Text != "") & (txtnuop.Text != "") & (txtidcliente.Text != "") & (txtidproducto.Text != "") & (txtidcolor.Text != "") & (txtnurollo.Text != "") & (txtidVendedor.Text != "") & (cbtipIng.Text != "") & (cbtipo.Text != ""))
                {
                    ModificarDetalle();
                    frmIngreso frm = (frmIngreso)FormParent;
                    frm.ModGuilla(obj, this);
                    

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Falta completar información ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtdensidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar_pop.Focus();
            }
        }

        string idIngreso;
        public void LLenarCampos(EIngresoDetalle obj)
        {
            idIngreso = obj.IdIngreso;
            txtfechaGuia.Text = obj.fecha;
            txtitem.Text= obj.Nu_Item;
            txtTf.Text = obj.Nu_tf;
            txtnuop.Text = obj.Nu_op;
            cb_mercado.SelectedValue = obj.Id_mercado;
            cb_tipoTela.SelectedValue = obj.Id_tipTela;
            cbtipo.SelectedValue = obj.Id_Tipo;
            cbtipIng.SelectedValue = obj.Id_TipIngreso;
            txtidcliente.Text = obj.Id_clipro;
            txtidproducto.Text = obj.Id_producto ;
            txtidcolor.Text = obj.Id_color;
            txtnurollo.Value = Convert.ToInt16(obj.Qt_rollo);
            txtpesoDesp.Text = obj.Qt_peso_desp.ToString();
            txtancho.Text = obj.Qt_ancho.ToString();
            txtdensidad.Text = obj.Qt_densidad.ToString();
            lblProducto.Text = obj.ds_producto;
            lblCliente.Text = obj.ds_clipro;
            lblcolor.Text = obj.ds_color;
            txtidVendedor.Text = obj.id_Vendedor;
            lblVendedor.Text = obj.Ds_Vendedor;
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {

            //frmIngreso frmanterior = (frmIngreso)FormParent;
            //frmanterior.ConsultarDetalle();
            this.Dispose();

        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            FrmVendedor_qry frmps = new FrmVendedor_qry();
            frmps.pasard += new FrmVendedor_qry.pasar(ejecutarVendedor);
            frmps.ShowDialog();
            txtidVendedor.Focus();
        }


        public void ejecutarVendedor(string idPers, string dsPers)
        {
            txtidVendedor.Text = idPers;
            lblVendedor.Text = dsPers;
        }

        private void txtidVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
    

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtidVendedor.Text = txtidVendedor.Text.PadLeft(5, '0');

                EVendedor per = new EVendedor();
                per.psintypesel = 1;
                per.Id_Vendedor = txtidVendedor.Text;
                per.Nu_dni = "";
                per.Ds_razsoc = "";

                List<Dato> oListDato = BVendedor.ObtenerDatoProveedor(per);
                if (oListDato.Count > 0)
                {
                    lblVendedor.Text = oListDato[0].desc;

                    
                    txtnurollo.Focus();
                }
                else
                {
                    MessageBox.Show("Vendedor no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtidVendedor.Clear();
                    lblVendedor.Text = "";
                    txtidVendedor.Focus();
                }



            }

        }

        private void frmProductoPopup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtidVendedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmVendedor_qry frmps = new FrmVendedor_qry();
                frmps.pasard += new FrmVendedor_qry.pasar(ejecutarVendedor);
                frmps.ShowDialog();
                txtidVendedor.Focus();
            }
        }

        private void txtTf_Leave(object sender, EventArgs e)
        {
            txtTf.Text = txtTf.Text.PadLeft(7, '0');
            txtnuop.Focus();
        }

        string detalle;

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (EstadoDet != 1)
            {

                if (detalle == "1")
                {

                    this.Width = 1125;

                    CargarDetalle();
                    mCalcula1();

                    detalle = "2";
                }
                else if (detalle == "2")
                {

                    this.Width = 438;
                    CargarDetalle();
                    mCalcula1();
                    detalle = "1";

                }
            }
            else
            {
                //MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAñadir.Enabled = false;
            }



        }





        private void CargarDetalle()
        {
            dgDetalle.Rows.Clear();
            EIngresoDetalle objID = new EIngresoDetalle();
            objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            objID.IdIngreso = idIngreso.ToString();
            objID.Nu_tf = txtTf.Text.Trim();
            objID.Id_clipro = txtidcliente.Text.Trim();
            objID.Id_producto = txtidproducto.Text.Trim();
            objID.Id_color = txtidcolor.Text.Trim();
            objID.nrollo = txtnurollo.Value.ToString();

            List<EIngresoDetalle> lstIG = new List<EIngresoDetalle>();
            lstIG = BIngreso_Detalle.AL_IngresoDetalle_qry04(objID);

            foreach (EIngresoDetalle _objID in lstIG)
            {
                string[] row =                        
                                {
                                    _objID.Nu_Item,
                                    _objID.Cod_Bar,
                                    _objID.Qt_rollo.ToString(),
                                    _objID.Qt_peso_desp.ToString(),
                                    _objID.Qt_peso_real.ToString(),
                          
                                };
                dgDetalle.Rows.Add(row);
            }
            lblitem.Text = dgDetalle.RowCount.ToString();
        }


    

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoItem();
            GrabarDetalle();
            mCalcula1();
            
        
        }
        string valorCelda;

  

        private void NuevoItem()
        {

            DateTime fecha = Convert.ToDateTime(txtfechaGuia.Text);
            string periodo = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();

            int countRows = dgDetalle.Rows.Count - 1;

            if (countRows >= 0)
            {
                valorCelda = dgDetalle.Rows[countRows].Cells["Item"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }


            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            //string codBarr = periodo + mes.PadLeft(2, '0') + dia.PadLeft(2, '0') + txtTf.Text.Trim() + "1" + item.PadLeft(2, '0').ToString();
            string codBarr = periodo + wfChgEmpPer.datos.idEmpresa + _idIngreso.ToString() + txtTf.Text.Trim() + item.PadLeft(2, '0').ToString();

            
            dgDetalle.Rows.Add(item.PadLeft(2, '0').ToString(),codBarr,"1", "0.0000","0.0000");
            dgDetalle.CurrentCell = dgDetalle.Rows[dgDetalle.Rows.Count - 1].Cells["peso_real"];
            txtnurollo.Value = dgDetalle.RowCount;
            lblitem.Text = dgDetalle.RowCount.ToString();
            dgDetalle.Focus();

        }



        private void btnAnular_Click(object sender, EventArgs e)
        {

            AnularDetalleIngreso();
            mCalcula1();
        }

        private void AnularDetalleIngreso()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Anular?", "Anulado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {

                    EIngresoDetalle objID = new EIngresoDetalle();

                    if (idIngreso == "")
                    {
                        dgDetalle.Rows.Remove(dgDetalle.CurrentRow);
                    }
                    else
                    {
                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objID.IdIngreso = idIngreso;
                        var codBarr = dgDetalle.CurrentRow.Cells["CodBarra"].Value.ToString();
                        var nuItem = dgDetalle.CurrentRow.Cells["Item"].Value.ToString();
                        objID.Nu_tf = txtTf.Text.Trim();
                        objID.Id_producto = txtidproducto.Text.Trim();
                        objID.Nu_Item = nuItem.ToString();
                        objID.Cod_Bar = codBarr.ToString();
                        objID.Id_uupdarec = frmLogin.d.id.ToLower();
                        BIngreso_Detalle.AL_Ingreso_Detalle_mnt04(objID);
                        dgDetalle.Rows.Remove(dgDetalle.CurrentRow);
                    }

                    txtnurollo.Value = dgDetalle.RowCount;
                    lblitem.Text = dgDetalle.RowCount.ToString();
                  
                  //  MessageBox.Show(idIngreso, "Datos Anulados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }



        protected void mCalcula1()
        {
            try
            {

                if (lblitem.Text != "0")
                {
                    decimal nupesoDesp1 = 0;
                    decimal nupesoReal1 = 0;

                    for (int x = 0; x < dgDetalle.Rows.Count; x++)
                    {

                        decimal totpesodesp = Convert.ToDecimal(dgDetalle.Rows[x].Cells["Peso_desp"].Value);
                        decimal totpesoreal = Convert.ToDecimal(dgDetalle.Rows[x].Cells["peso_real"].Value);

                        nupesoDesp1 = nupesoDesp1 + totpesodesp;
                        nupesoReal1 = nupesoReal1 + totpesoreal;

                        txttotpesodesp.Text = string.Format("{0:##,##0.0000}", nupesoDesp1);
                        txttotpesoreal.Text = string.Format("{0:##,##0.0000}", nupesoReal1);
                        txtpesoRestante.Text = string.Format("{0:##,##0.0000}", Convert.ToString(Convert.ToDecimal(txttotpesoreal.Text) - Convert.ToDecimal(txttotpesodesp.Text)));

                    }
                }
                else
                {
                    txttotpesodesp.Text = "0.0000";
                    txttotpesoreal.Text = "0.0000";
                    txtpesoRestante.Text = "0.0000";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        
              EIngresoDetalle obj = new EIngresoDetalle();
              FrmProductoDetallePopup frm = new FrmProductoDetallePopup();
                for (int i = 0; dgDetalle.Rows.Count > i; i++)
                {
                    var Item = dgDetalle.Rows[i].Cells["Item"].Value;
                    var CodBarra = dgDetalle.Rows[i].Cells["CodBarra"].Value;
                    var Und = dgDetalle.Rows[i].Cells["Und"].Value;
                    var Peso_desp = dgDetalle.Rows[i].Cells["Peso_desp"].Value;
                    var peso_real = dgDetalle.Rows[i].Cells["peso_real"].Value;
                   
                        obj.Nu_Item = Item.ToString();
                        obj.Cod_Bar = CodBarra.ToString();
                        obj.Qt_rollo = Convert.ToInt16(Und);
                        obj.Qt_peso_desp = Convert.ToDecimal(Peso_desp);
                        obj.Qt_peso_real = Convert.ToDecimal(peso_real);
                        frm.LlenarGrilla(obj, this);
                        frm._lblIdIngreso = (idIngreso);
                }
                frm.pasard += new FrmProductoDetallePopup.pasar(ejecutarConsulta);
                frm.EstadoDet = 1;
                frm.ShowDialog();
        }

        public void ejecutarConsulta(string estado)
        {
            if (estado == "1")
            {
                CargarDetalle();
                mCalcula1();
            }
         
        }

    

        string _drow;
        private void dgDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dRow = dgDetalle.Rows[e.RowIndex];
                _drow = dRow.Index.ToString();


                EIngresoDetalle obj = new EIngresoDetalle();
                FrmProductoDetallePopup frm = new FrmProductoDetallePopup();
                for (int i = 0; dgDetalle.Rows.Count > i; i++)
                {
                    var Item = dgDetalle.Rows[i].Cells["Item"].Value;
                    var CodBarra = dgDetalle.Rows[i].Cells["CodBarra"].Value;
                    var Und = dgDetalle.Rows[i].Cells["Und"].Value;
                    var Peso_desp = dgDetalle.Rows[i].Cells["Peso_desp"].Value;
                    var peso_real = dgDetalle.Rows[i].Cells["peso_real"].Value;

                    obj.Nu_Item = Item.ToString();
                    obj.Cod_Bar = CodBarra.ToString();
                    obj.Qt_rollo = Convert.ToInt16(Und);
                    obj.Qt_peso_desp = Convert.ToDecimal(Peso_desp);
                    obj.Qt_peso_real = Convert.ToDecimal(peso_real);
                 
                    frm.LlenarGrilla(obj, this);
                    frm._lblIdIngreso = (idIngreso);
                }
                frm.pasard += new FrmProductoDetallePopup.pasar(ejecutarConsulta);
                frm._detalle = 2;
                frm._index = _drow;
                frm.ShowDialog();



                
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void GrabarDetalle()
        {
           
               
                    EIngresoDetalle objID = new EIngresoDetalle();

                    ////------------------------Detalle de compras----------------------------------------------------  


                    for (int i = 0; dgDetalle.Rows.Count > i; i++)
                    {
                        var Nu_Item = dgDetalle.Rows[i].Cells["Item"].Value.ToString();
                        var Cod_Bar = dgDetalle.Rows[i].Cells["CodBarra"].Value.ToString();
                        var Qt_peso_real = Convert.ToDecimal(dgDetalle.Rows[i].Cells["peso_real"].Value.ToString());
                        var Qt_rollo = Convert.ToInt16(dgDetalle.Rows[i].Cells["Und"].Value.ToString());

                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 
                        objID.IdIngreso = idIngreso;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objID.Cod_Bar = Cod_Bar.ToString();
                        
                        
                        objID.Id_producto = txtidproducto.Text;
                        objID.Id_clipro = txtidcliente.Text;
                        objID.Id_color = txtidcolor.Text.Trim();
                        objID.Nu_Item = Nu_Item.ToString();
                        
                        objID.Nu_tf = txtTf.Text;
                        objID.Nu_op = txtnuop.Text;
                        objID.Id_mercado = cb_mercado.SelectedValue.ToString();
                        objID.Id_tipTela = cb_tipoTela.SelectedValue.ToString();
                        objID.Id_Tipo = cbtipo.SelectedValue.ToString();
                        objID.Id_TipIngreso = cbtipIng.SelectedValue.ToString();
                        objID.Qt_rollo = Convert.ToInt16(Qt_rollo);
                        objID.Qt_peso_desp = Convert.ToDecimal(txtpesoDesp.Text);
                        objID.Qt_peso_real = Convert.ToDecimal(Qt_peso_real);
                        objID.Qt_peso_actual = Convert.ToDecimal(Qt_peso_real);
                        objID.Qt_densidad = Convert.ToDecimal(txtdensidad.Text);
                        objID.Qt_ancho = Convert.ToDecimal(txtancho.Text);
                        objID.id_Vendedor = txtidVendedor.Text;
                        objID.St_estado = "Pendiente";
                        objID.Cod_Bar2 = BarCode.BarcodeConverter128.StringToBarcode(Cod_Bar.ToString());
                        objID.Id_ucreatrec = frmLogin.d.id.ToLower();

                        BIngreso_Detalle.AL_Ingreso_Detalle_mnt06(objID);
      
            }
        }






        private void ModificarDetalle()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Modificar?", "Actualizado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {

                    EIngresoDetalle objID = new EIngresoDetalle();

                    ////------------------------Detalle de compras----------------------------------------------------  

                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        objID.IdIngreso = idIngreso;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;                        
                        objID.Id_producto = txtidproducto.Text;
                        objID.Id_clipro = txtidcliente.Text;
                        objID.Id_color = txtidcolor.Text;                        
                        objID.Nu_tf = txtTf.Text;
                        objID.Nu_op = txtnuop.Text;
                        objID.Id_mercado = cb_mercado.SelectedValue.ToString();
                        objID.Id_tipTela = cb_tipoTela.SelectedValue.ToString();
                        objID.Id_Tipo = cbtipo.SelectedValue.ToString();
                        objID.Id_TipIngreso = cbtipIng.SelectedValue.ToString();                        
                        objID.Qt_peso_desp = Convert.ToDecimal(txtpesoDesp.Text);                        
                        objID.Qt_densidad = Convert.ToDecimal(txtdensidad.Text);
                        objID.Qt_ancho = Convert.ToDecimal(txtancho.Text);
                        objID.id_Vendedor = txtidVendedor.Text;
                        
                        objID.Id_ucreatrec = frmLogin.d.id.ToLower();

                        BIngreso_Detalle.AL_Ingreso_Detalle_mnt07(objID);

                
                }

                else if (result == DialogResult.Cancel)
                {



                }
            }
        }

        private void cb_mercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbtipo.Focus();
            }
        }

        private void cb_tipoTela_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtidproducto.Focus();

                txtidproducto.SelectionStart = 0;
                txtidproducto.SelectionLength = txtidproducto.Text.Length;
            }
        }


    }
}
