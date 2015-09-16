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
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class FrmSalidaProducto_Popup : Form
    {
        public FrmSalidaProducto_Popup()
        {
            InitializeComponent();
        }
        public int EstadoDet = 0;// esto define si se añade un nuevo Item o solo va a ser modificado el item  // 1 --> para añadir un nuevo item , 2 --> para modificar un item
        public object FormParent { get; set; }
        public string mensaje;
     
        private void FrmSalidaProducto_Popup_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtcodbarr;
            txtcodbarr.Focus();

            WebHelper.LoadListControl3(cbtipo, BGeneral.ObtenerDatoidTabla("145"));
            WebHelper.LoadListControl3(cbtipIng, BGeneral.ObtenerDatoidTabla("146"));
            WebHelper.LoadListControl3(cb_mercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cb_tipoTela, BGeneral.ObtenerDatoidTabla("147"));

       
            

            if (EstadoDet == 1)
            {
                
            
                lblprecio.Visible = true;
                btnprecio.Visible = true;
                txtprecio.Visible = true;
                chkigv_pop.Visible = true;
                label15.Visible = true;
            }
            else if (EstadoDet == 2)
            {
               
               
            }

        }


        private void Buscar()
        {
            lblmensaje.Text = "";

            EParametros objIng = new EParametros();
            objIng.idEmpresa = wfChgEmpPer.datos.idEmpresa;
            objIng.idperiodo = wfChgEmpPer.datos.idperiodo;

            objIng.codbarra = txtcodbarr.Text;

            EParametros oBtieneIg = new EParametros();

            oBtieneIg = BIngreso_Detalle.AL_Ingreso_Detalle_qry7(objIng);

            string dsprod = oBtieneIg.ds_producto;
            
            if (dsprod != null)
            {

                txtTf.Text = oBtieneIg.nu_tf.ToString().Trim();
                cb_mercado.SelectedValue = oBtieneIg.id_mercado.ToString();
                cb_tipoTela.SelectedValue = oBtieneIg.id_tiptela.ToString();                               
                cbtipo.SelectedValue = oBtieneIg.id_Tipo.ToString();
                cbtipIng.SelectedValue = oBtieneIg.id_TipIngreso.ToString();
                txtidproducto.Text = oBtieneIg.id_producto.ToString();
                lblProducto.Text = oBtieneIg.ds_producto.ToString();
                txtnuop.Text = oBtieneIg.nu_op.ToString();
                txtidcolor.Text = oBtieneIg.id_color.ToString().Trim();
                lblcolor.Text = oBtieneIg.ds_color.ToString().Trim();
                
                txtnurollo.Text = oBtieneIg.qt_rollo.ToString();
                txtidcliente.Text = oBtieneIg.id_clipro.ToString();
                lblCliente.Text = oBtieneIg.ds_raznombre.ToString().Trim();
                txtidVendedor.Text = oBtieneIg.id_vendedor.ToString();
                lblVendedor.Text = oBtieneIg.dsVendedor.ToString().Trim();

                txtancho.Text = oBtieneIg.qt_ancho.ToString();
                txtdensidad.Text = oBtieneIg.qt_densidad.ToString();
                txtpesoactual.Text = oBtieneIg.qt_peso_actual.ToString();
                txtpesodesp.Text = oBtieneIg.qt_peso_actual.ToString();

                if (EstadoDet.ToString() == "1")
                {
                    txtprecio.Text = "0.0000";
                }
                else
                { 

                }

                txtcodbarr.Focus();
                txtcodbarr.SelectionStart = 0;
                txtcodbarr.SelectionLength = txtcodbarr.Text.Length;

                Aceptar();
            }
            else
            {
                Nuevo();
                //txtcodbarr.SelectionStart = 0;
                //txtcodbarr.SelectionLength = txtcodbarr.Text.Length;
          
            }

        
        }
        
        private void cbtipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcodbarr_TextChanged(object sender, EventArgs e)
        {
                Buscar();
              
               
        }


        private void Aceptar()
        {
            ESalida_Detalle obj = new ESalida_Detalle();
            obj.Nu_item = txtitem.Text;
            obj.CodBar = txtcodbarr.Text;
            obj.Nu_op = txtnuop.Text;
            obj.Nu_tf = txtTf.Text;
            obj.Id_mercado = cb_mercado.SelectedValue.ToString();
            obj.Id_tipo = cbtipo.SelectedValue.ToString();
            obj.Id_tiptela = cb_tipoTela.SelectedValue.ToString();
            obj.Id_producto = txtidproducto.Text;
            obj.Ds_producto = lblProducto.Text;
            obj.Id_color = txtidcolor.Text;
            obj.Ds_color = lblcolor.Text;
            obj.Qt_rollo = Convert.ToInt16(txtnurollo.Text);
            obj.Qt_peso_Actual = Convert.ToDecimal(txtpesodesp.Text);
            obj.Qt_peso = Convert.ToDecimal(txtpesodesp.Text);
            obj.Mt_precio = Convert.ToDecimal("0.0000");


            if (EstadoDet == 1)
            {
                if (txtidproducto.Text != "" && txtprecio.Text != ""  && txtpesodesp.Text != "0.0000")
                {
                    decimal imp = 0;
                    decimal deSuma = 0;

                    EDTipImpuesto dti = new EDTipImpuesto();
                    dti.IdPeriodo = wfChgEmpPer.datos.idperiodo;

                    List<Dato> oListDato = BDeTipImpuesto.ObtenerImpuesto(dti);
                    if (oListDato.Count > 0)
                    {
                        imp = Convert.ToDecimal(oListDato[0].desc);
                    }

                    if (chkigv_pop.Checked == false)
                    {
                        obj.Mt_precio = Convert.ToDecimal(txtprecio.Text);
                        deSuma = (Convert.ToDecimal(txtpesodesp.Text)) * (Convert.ToDecimal(txtprecio.Text));
                        obj.Mt_igv = Convert.ToDecimal("0.0000");
                        obj.Mt_total = Convert.ToDecimal(deSuma);
                    }
                    else
                    {
                        obj.Mt_precio = Convert.ToDecimal(txtprecio.Text);
                        deSuma = (Convert.ToDecimal(txtpesodesp.Text)) * (Convert.ToDecimal(txtprecio.Text));
                        obj.Mt_igv = imp * deSuma;
                        obj.Mt_total = (deSuma);
                    }

                    obj._id_cliente = txtidcliente.Text;
                    FrmSalida frm = (FrmSalida)FormParent;
                    frm.LlenarGrilla(obj, this);
                    //this.Close();
                }
                else
                {
                    lblmensaje.Text = "Falta completar información";
                    //MessageBox.Show("Falta completar información ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (EstadoDet == 3)
            {
                if (txtidproducto.Text != "" &&  txtpesodesp.Text != "0.0000")
                {


                    FrmSalida_Detalle_popup frm = (FrmSalida_Detalle_popup)FormParent;
                    frm._id_cliprod = txtidcliente.Text;

                    frm.LlenarGrilla(obj, this);

                    //this.Close();


                }
                else
                {
                    lblmensaje.Text = "Falta completar información";
                    //MessageBox.Show("Falta completar información ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (EstadoDet == 2)
            {

                //FrmOrdenPedido_mnt frm = (FrmOrdenPedido_mnt)FormParent;
                //frm.ModGuilla(obj, this);

                //this.Close();

            }
        }

        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalidaProducto_Popup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {

            }
            else if (e.KeyCode == Keys.P && e.Control)
            {

            }
            else if (e.KeyCode == Keys.B && e.Control)
            {

            }

            else if (e.KeyCode == Keys.E && e.Control)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {

               
            }
        }

        private void btnprecio_Click(object sender, EventArgs e)
        {
            FrmListadoPrecio_qry frmp = new FrmListadoPrecio_qry();
            frmp.pasard += new FrmListadoPrecio_qry.pasar(ejecutarPrecio);
            frmp._lblproducto = lblProducto.Text;

            frmp.ShowDialog();
            txtprecio.Focus();
        }

        public void ejecutarPrecio(ElistPrecio_Detalle lp)
        {
            txtprecio.Text = lp.Precio_mnt.ToString();

        }


        private void Limpiar(TableLayoutPanel grupo)
        {


            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtcodbarr.Focus();

                }
               
            }
        }

        private void Nuevo()
        {
            Limpiar(tableLayoutPanel1);
            Limpiar(tableLayoutPanel2);
            Limpiar(tableLayoutPanel3);
            Limpiar(tableLayoutPanel4);
            Limpiar(tableLayoutPanel6);

            lblCliente.Text = "";
            lblcolor.Text = "";
            lblProducto.Text = "";
            lblVendedor.Text = "";

            cb_mercado.SelectedIndex = -1;
            cb_tipoTela.SelectedIndex = -1;
            cbtipIng.SelectedIndex = -1;
            cbtipo.SelectedIndex = -1;


        }

        private void txtcodbarr_TextAlignChanged(object sender, EventArgs e)
        {

        }
    }
}
