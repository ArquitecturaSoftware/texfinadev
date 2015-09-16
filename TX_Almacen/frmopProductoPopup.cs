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
    public partial class frmopProductoPopup : Form
    {
        public frmopProductoPopup()
        {
            InitializeComponent();
        }
        public object FormParent { get; set; }

        public int EstadoDet = 0;// esto define si se añade un nuevo Item o solo va a ser modificado el item  // 1 --> para añadir un nuevo item , 2 --> para modificar un item
        public string dscliente,dsvendedor,nuOp;
        private void btnprodupop_Click(object sender, EventArgs e)
        {
            FrmProducto_stock_qry frmp = new FrmProducto_stock_qry();
            frmp.pasard += new FrmProducto_stock_qry.pasar(ejecutarProducto);
            frmp._dscliente = dscliente;
            frmp._dsvendedor = dsvendedor;
            frmp.ShowDialog();
            txtidproducto.Focus();
        }

        public void ejecutarProducto(EIngresoDetalle id)
        {
            txtidproducto.Text = id.Id_producto;
            lblproducto.Text = id.ds_producto;
            txtidcolor.Text = id.Id_color;
            lblcolor.Text = id.ds_color;
            txtstock.Text = id.Qt_rollo.ToString();
            txtid_cliente.Text = id.Id_clipro;
            txtds_cliente.Text = id.ds_clipro;
            txtid_vendedor.Text = id.id_Vendedor;
            txtds_vendedor.Text = id.Ds_Vendedor;
            txt_rollo_reservado.Text = id.qt_rollo_reserv.ToString();
            txt_rollo_dispo.Text = Convert.ToString(Convert.ToInt16(txtstock.Text) - Convert.ToInt16(txt_rollo_reservado.Text));
        }

        private void btnprecio_Click(object sender, EventArgs e)
        {
            FrmListadoPrecio_qry frmp = new FrmListadoPrecio_qry();
            frmp.pasard += new FrmListadoPrecio_qry.pasar(ejecutarPrecio);
            frmp._lblproducto = lblproducto.Text;
            
            frmp.ShowDialog();
            txtprecio.Focus();
        }

        public void ejecutarPrecio(ElistPrecio_Detalle lp)
        {
            txtprecio.Text = lp.Precio_mnt.ToString(); 

        }

        private void txtidproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnurollo.Focus();
                
            }
        }

        private void txtnurollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Convert.ToInt16(txt_rollo_dispo.Text) >= Convert.ToInt16(txtnurollo.Text))
                {

                }
                else
                {
                    MessageBox.Show("Stock Insuficiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnurollo.Text = "0";

                }

                txtprecio.Focus();
                txtprecio.SelectionStart = 0;
                txtprecio.SelectionLength = txtprecio.Text.Length;
                
            }
        }

        private void txtidproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmProducto_stock_qry frmp = new FrmProducto_stock_qry();
                frmp.pasard += new FrmProducto_stock_qry.pasar(ejecutarProducto);
                frmp._dscliente = dscliente;
                frmp._dsvendedor = dsvendedor;
                frmp.ShowDialog();
                txtidproducto.Focus();
            }
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmListadoPrecio_qry frmp = new FrmListadoPrecio_qry();
                frmp.pasard += new FrmListadoPrecio_qry.pasar(ejecutarPrecio);
                frmp._lblproducto = lblproducto.Text;
                frmp.ShowDialog();
                txtprecio.Focus();
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar_pop.Focus();
            }
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            EOrdPedido_Detalle obj = new EOrdPedido_Detalle();
            obj.NuItem = txtnuitem.Text;
            obj.Id_clipro = txtid_cliente.Text;
            obj.ds_clipro = txtds_cliente.Text;
            obj.Id_producto = txtidproducto.Text;
            obj.ds_producto = lblproducto.Text;
            obj.Id_color = txtidcolor.Text;
            obj.DsColor = lblcolor.Text;
            obj.Qt_rollo = Convert.ToInt16(txtnurollo.Text);
            obj.Qt_peso = Convert.ToDecimal("0.0000");
            obj.Id_vendedor = txtid_vendedor.Text;
            obj.Ds_vendedor = txtds_vendedor.Text;
            obj.Mt_preunit_actual = Convert.ToDecimal(txtprecio.Text);
            obj._igvActivo = chkigv_pop.Checked;

            if (EstadoDet == 1)
            {
                if (txtidproducto.Text != "")
                {

                    if (Convert.ToInt16(txt_rollo_dispo.Text) >= Convert.ToInt16(txtnurollo.Text))
                    {
                        FrmOrdenPedido_mnt frmanterior = (FrmOrdenPedido_mnt)FormParent;
                        frmanterior.LlenarGrilla(obj, this);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Stock Insuficiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnurollo.Text = "0";
                    }

                }
                else
                {
                    MessageBox.Show("Falta completar información ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (EstadoDet == 2)
            {

                 if (Convert.ToInt16(txt_rollo_dispo.Text) >= Convert.ToInt16(txtnurollo.Text))
                    {

                        FrmOrdenPedido_mnt frm = (FrmOrdenPedido_mnt)FormParent;
                        frm.ModGuilla(obj, this);
                        this.Close();
                    }
                 else
                    {
                         MessageBox.Show("Stock Insuficiente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // txtnurollo.Text = "0";
                    }


            }
        }

        public void LLenarCampos(EOrdPedido_Detalle obj)
        {
            

            txtnuitem.Text = obj.NuItem;
            txtid_cliente.Text = obj.Id_clipro;
            txtds_cliente.Text = obj.ds_clipro;
            txtidproducto.Text = obj.Id_producto;
            lblproducto.Text = obj.ds_producto;
            txtidcolor.Text = obj.Id_color;
            lblcolor.Text = obj.DsColor;            
            txtnurollo.Text = obj.Qt_rollo.ToString();
            txtpesoDesp.Text = obj.Qt_peso.ToString();
            txtid_vendedor.Text = obj.Id_vendedor.ToString();
            txtds_vendedor.Text = obj.Ds_vendedor.ToString();
            txtprecio.Text = obj.Mt_preunit_actual.ToString();
            chkigv_pop.Checked = obj._igvActivo;


            EIngresoDetalle _obj = new EIngresoDetalle();
            _obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            _obj.Id_clipro = txtid_cliente.Text;
            _obj.Id_producto = txtidproducto.Text;
            _obj.id_Vendedor = txtid_vendedor.Text;
            _obj.Id_color = txtidcolor.Text;


            List<EIngresoDetalle> oListDato = BIngreso_Detalle.AL_Ingreso_Detalle_Stock02(_obj);
            if (oListDato.Count > 0)
            {
                int reservado = 0;
                    txtstock.Text = oListDato[0].Qt_rollo.ToString();
                    if (nuOp != "")
                    {
                        
                        if (obj.St_estado.ToString().Trim() == "Despachado")
                        {
                            txt_rollo_reservado.Text = oListDato[0].qt_rollo_reserv.ToString();
                            reservado = Convert.ToInt16(oListDato[0].Qt_rollo - txtnurollo.Value);                            
                            txt_rollo_dispo.Text = Convert.ToString((Convert.ToInt16(txtstock.Text) - Convert.ToInt16(txt_rollo_reservado.Text)) );                            
                        }
                        else
                        {
                            txt_rollo_reservado.Text = oListDato[0].qt_rollo_reserv.ToString();
                            reservado = Convert.ToInt16(oListDato[0].Qt_rollo - txtnurollo.Value);                            
                            txt_rollo_dispo.Text = Convert.ToString((Convert.ToInt16(txtstock.Text) - Convert.ToInt16(txt_rollo_reservado.Text)) + Convert.ToInt16(txtnurollo.Text));                 
                        }
                    }
                    else
                    {
                        txt_rollo_reservado.Text = oListDato[0].qt_rollo_reserv.ToString();
                        reservado = Convert.ToInt16(oListDato[0].Qt_rollo - txtnurollo.Value);
                        txt_rollo_dispo.Text = Convert.ToString((Convert.ToInt16(txtstock.Text) - Convert.ToInt16(txt_rollo_reservado.Text)));
 

                    }
            }
            else
            {
                txtstock.Text = "0";
                txt_rollo_reservado.Text = "0";
                txt_rollo_dispo.Text = "0";
            }

            
        }
        private void frmopProductoPopup_Load(object sender, EventArgs e)
        {
            if (EstadoDet == 1)
            {
                txtpesoDesp.Text = string.Format("{0:##,##0.0000}", 0);
                txtprecio.Text = string.Format("{0:##,##0.0000}", 0);
                //btnAddRow.Enabled = false;
            }
            else if (EstadoDet == 2)
            {
                //btnAddRow.Enabled = true;
            }
        }

        private void txtpesoDesp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnurollo.Focus();
            }
        }

        private void frmopProductoPopup_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

         
        }



     
    }
}
