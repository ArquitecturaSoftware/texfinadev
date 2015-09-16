using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class FrmSalidaProducto_ModifPopup : Form
    {
        public object FormParent { get; set; }

        public int EstadoDet = 0;
        public delegate void pasar(string estado);
        public event pasar pasard;

        public string _index;
        public int _detalle;

        public FrmSalidaProducto_ModifPopup()
        {
            InitializeComponent();
            WebHelper.LoadListControl3(cbtipo, BGeneral.ObtenerDatoidTabla("145"));       
            WebHelper.LoadListControl3(cb_mercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cb_tipoTela, BGeneral.ObtenerDatoidTabla("147"));
        }

        private void FrmSalidaProducto_ModifPopup_Load(object sender, EventArgs e)
        {
            //WebHelper.LoadListControl3(cbtipo, BGeneral.ObtenerDatoidTabla("145"));          
            //WebHelper.LoadListControl3(cb_mercado, BGeneral.ObtenerDatoidTabla("104"));
            //WebHelper.LoadListControl3(cb_tipoTela, BGeneral.ObtenerDatoidTabla("147"));
           
            
            
            //if (_detalle != 2)
            //{           
            //    txtitem.Text = dgvSalida.Rows[0].Cells["nu_item"].Value.ToString();
            //    txtcodbarr.Text = dgvSalida.Rows[0].Cells["CodBar"].Value.ToString();
            //    txtTf.Text = dgvSalida.Rows[0].Cells["nu_tf"].Value.ToString();
            //    txtnuop.Text = dgvSalida.Rows[0].Cells["nu_op"].Value.ToString();
            //    cb_mercado.SelectedValue = dgvSalida.Rows[0].Cells["id_mercado"].Value.ToString();
            //    cbtipo.SelectedValue = dgvSalida.Rows[0].Cells["id_tipo"].Value.ToString();
            //    cb_tipoTela.Text = dgvSalida.Rows[0].Cells["tipo_tela"].Value.ToString();
            //    txtidproducto.Text = dgvSalida.Rows[0].Cells["id_producto"].Value.ToString();
            //    lblProducto.Text = dgvSalida.Rows[0].Cells["ds_producto"].Value.ToString();
            //    txtidcolor.Text = dgvSalida.Rows[0].Cells["id_color"].Value.ToString();
            //    lblcolor.Text = dgvSalida.Rows[0].Cells["ds_color"].Value.ToString();
            //    txtnurollo.Text = dgvSalida.Rows[0].Cells["_nu_rollo"].Value.ToString();
            //    txtpesodesp.Text = dgvSalida.Rows[0].Cells["qt_peso"].Value.ToString();
            //    txtprecio.Text = dgvSalida.Rows[0].Cells["mt_precio"].Value.ToString();
            //    txtmt_igv.Text = dgvSalida.Rows[0].Cells["mt_igv"].Value.ToString();
            //    txtidcliente.Text = dgvSalida.Rows[0].Cells["id_cliente"].Value.ToString();


            //}
            //else
            //{
           
            //    txtitem.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["nu_item"].Value.ToString();
            //    txtcodbarr.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["CodBar"].Value.ToString();
            //    txtTf.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["nu_tf"].Value.ToString();
            //    txtnuop.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["nu_op"].Value.ToString();
            //    cb_mercado.SelectedValue = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["id_mercado"].Value.ToString();
            //    cbtipo.SelectedValue = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["id_tipo"].Value.ToString();
            //    cb_tipoTela.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["tipo_tela"].Value.ToString();
            //    txtidproducto.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["id_producto"].Value.ToString();
            //    lblProducto.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["ds_producto"].Value.ToString();
            //    txtidcolor.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["id_color"].Value.ToString();
            //    lblcolor.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["ds_color"].Value.ToString();
            //    txtnurollo.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["_nu_rollo"].Value.ToString();
            //    txtpesodesp.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["qt_peso"].Value.ToString();
            //    txtprecio.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["mt_precio"].Value.ToString();
            //    txtmt_igv.Text = dgvSalida.Rows[Convert.ToInt16(_index)].Cells["mt_igv"].Value.ToString();
            //    txtidcliente.Text = dgvSalida.Rows[0].Cells["id_cliente"].Value.ToString();
            //}

        }

        public void LLenarCampos(ESalida_Detalle obj)
        {
            if (EstadoDet == 1)
            {
                txtcodbarr.Text = obj.CodBar;
                txtTf.Text = obj.Nu_tf;
                txtitem.Text = obj.Nu_item;
                txtnuop.Text = obj.Nu_op;
                cb_mercado.SelectedValue = obj.Id_mercado.ToString().Trim();
                cbtipo.SelectedValue = obj.Id_tipo.ToString().Trim();
                cb_tipoTela.SelectedValue = obj.Id_tiptela.ToString().Trim();
                txtidproducto.Text = obj.Id_producto.ToString();
                lblProducto.Text = obj.Ds_producto.ToString();
                txtidcolor.Text = obj.Id_color.ToString();
                lblcolor.Text = obj.Ds_color.ToString();
                txtnurollo.Text = obj.Qt_rollo.ToString();
                txtpeso_actual.Text = obj.Qt_peso_Actual.ToString();
                txtpesodesp.Text = obj.Qt_peso.ToString();
                txtprecio.Text = obj.Mt_precio.ToString();
                txtmt_igv.Text = obj.Mt_igv.ToString();

                if (txtmt_igv.Text != "0.0000")
                {
                    chkigv_pop.Checked = true;
                }
                else
                {
                    chkigv_pop.Checked = false;
                }

                txtidcliente.Text = obj._id_cliente.ToString();
                count = Convert.ToInt16(_index);
            }
            else
            {

                txtcodbarr.Text = obj.CodBar;
                txtTf.Text = obj.Nu_tf;
                txtitem.Text = obj.Nu_item;
                txtnuop.Text = obj.Nu_op;
                cb_mercado.SelectedValue = obj.Id_mercado.ToString().Trim();
                cbtipo.SelectedValue = obj.Id_tipo.ToString().Trim();
                cb_tipoTela.SelectedValue = obj.Id_tiptela.ToString().Trim();
                txtidproducto.Text = obj.Id_producto.ToString();
                lblProducto.Text = obj.Ds_producto.ToString();
                txtidcolor.Text = obj.Id_color.ToString();
                lblcolor.Text = obj.Ds_color.ToString();
                txtnurollo.Text = obj.Qt_rollo.ToString();
                txtpeso_actual.Text = Convert.ToString(Convert.ToDecimal(obj.Qt_peso_Disp) + Convert.ToDecimal(obj.Qt_peso));
                txtpesodesp.Text = obj.Qt_peso.ToString();
                txtprecio.Text = obj.Mt_precio.ToString();
                txtmt_igv.Text = obj.Mt_igv.ToString();

                if (txtmt_igv.Text != "0.0000")
                {
                    chkigv_pop.Checked = true;
                }
                else
                {
                    chkigv_pop.Checked = false;
                }

                txtidcliente.Text = obj._id_cliente.ToString();
                count = Convert.ToInt16(_index);

            }

        }

        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            Aceptar();

        }

        private void Aceptar()
        {

            EDTipImpuesto dti = new EDTipImpuesto();
            ESalida_Detalle obj = new ESalida_Detalle();
            FrmSalida frm = (FrmSalida)FormParent;
            obj.Nu_item = txtitem.Text;
            obj.CodBar = txtcodbarr.Text;
            obj.Nu_tf = txtTf.Text;
            obj.Nu_op = txtnuop.Text;
            obj.Id_mercado = cb_mercado.SelectedValue.ToString();
            obj.Id_tipo = cbtipo.SelectedValue.ToString();
            obj.Id_tiptela = cb_tipoTela.SelectedValue.ToString();
            obj.Id_producto = txtidproducto.Text;
            obj.Ds_producto = lblProducto.Text;
            obj.Id_color = txtidcolor.Text;
            obj.Ds_color = lblcolor.Text;
            obj.Qt_rollo = Convert.ToInt16(txtnurollo.Text);
            obj.Qt_peso = Convert.ToDecimal(txtpesodesp.Text);
            obj.Mt_precio = Convert.ToDecimal(txtprecio.Text);

            decimal imp = 0;
            decimal deSuma = 0;



            dti.IdPeriodo = wfChgEmpPer.datos.idperiodo;

            List<Dato> oListDato = BDeTipImpuesto.ObtenerImpuesto(dti);
            if (oListDato.Count > 0)
            {
                imp = Convert.ToDecimal(oListDato[0].desc);
            }


            if (chkigv_pop.Checked == false)
            {
                deSuma = (Convert.ToDecimal(txtpesodesp.Text)) * (Convert.ToDecimal(txtprecio.Text));
                obj.Mt_igv = Convert.ToDecimal("0.0000");
                obj.Mt_total = Convert.ToDecimal(deSuma);
            }
            else
            {
                deSuma = (Convert.ToDecimal(txtpesodesp.Text)) * (Convert.ToDecimal(txtprecio.Text));
                obj.Mt_igv = imp * deSuma;
                obj.Mt_total = (deSuma);
            }

            obj._id_cliente = txtidcliente.Text;

            obj.Qt_peso_Disp = Convert.ToDecimal(txtpeso_actual.Text) - Convert.ToDecimal(txtpesodesp.Text);

            frm._drow = count.ToString();
            //decimal peso =  Convert.ToDecimal(dgvSalida.Rows[Convert.ToInt16(count)].Cells["qt_peso"].Value.ToString());

           dgvSalida.Rows[Convert.ToInt16(count)].Cells["qt_peso"].Value = txtpesodesp.Text;
           dgvSalida.Rows[Convert.ToInt16(count)].Cells["mt_precio"].Value = txtprecio.Text;



            //frm._peso = peso.ToString();
            frm.ModGuilla2(obj, this);


            



        }


        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
            this.Close();
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



        public void LlenarGrilla(ESalida_Detalle obj, object form)
        {

            string str = Convert.ToString(dgvSalida.Rows.Count + 1);


            //EIngresoDetalle obj= new EIngresoDetalle();
            string[] row = { obj.Nu_item,
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

        }
        int count=0;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            Aceptar();
            
            FrmSalida frm = new FrmSalida();
           
                if (dgvSalida.RowCount -1 > count)
                {
                    
                     count = count + 1;
                  
                    
                    txtitem.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_item"].Value.ToString();
                    txtcodbarr.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["CodBar"].Value.ToString();
                    txtTf.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_tf"].Value.ToString();
                    txtnuop.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_op"].Value.ToString();
                    cb_mercado.SelectedValue = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_mercado"].Value.ToString();
                    cbtipo.SelectedValue = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_tipo"].Value.ToString();
                    cb_tipoTela.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["tipo_tela"].Value.ToString();
                    txtidproducto.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_producto"].Value.ToString();
                    lblProducto.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["ds_producto"].Value.ToString();
                    txtidcolor.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_color"].Value.ToString();
                    lblcolor.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["ds_color"].Value.ToString();
                    txtnurollo.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["_nu_rollo"].Value.ToString();
                    if (EstadoDet == 1)
                    {
                        txtpeso_actual.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["peso_actual"].Value.ToString();
                    }
                    else
                    {
                        txtpeso_actual.Text = Convert.ToString( Convert.ToDecimal(dgvSalida.Rows[Convert.ToInt16(count)].Cells["peso_actual"].Value) + Convert.ToDecimal(dgvSalida.Rows[Convert.ToInt16(count)].Cells["qt_peso"].Value));
                        
                    }
                    txtpesodesp.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["qt_peso"].Value.ToString();
                    txtprecio.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["mt_precio"].Value.ToString();
                    txtmt_igv.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["mt_igv"].Value.ToString();
                    txtidcliente.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_cliente"].Value.ToString();
                    //frm._drow = count.ToString();
                    //MessageBox.Show(frm._drow.ToString());
                 
                }
                else
                {

                 
                     count = 0;
                       //MessageBox.Show(count.ToString());
                       txtitem.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_item"].Value.ToString();
                       txtcodbarr.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["CodBar"].Value.ToString();
                       txtTf.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_tf"].Value.ToString();
                       txtnuop.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["nu_op"].Value.ToString();
                       cb_mercado.SelectedValue = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_mercado"].Value.ToString();
                       cbtipo.SelectedValue = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_tipo"].Value.ToString();
                       cb_tipoTela.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["tipo_tela"].Value.ToString();
                       txtidproducto.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_producto"].Value.ToString();
                       lblProducto.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["ds_producto"].Value.ToString();
                       txtidcolor.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_color"].Value.ToString();
                       lblcolor.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["ds_color"].Value.ToString();
                       txtnurollo.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["_nu_rollo"].Value.ToString();
                       txtpesodesp.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["qt_peso"].Value.ToString();
                       txtprecio.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["mt_precio"].Value.ToString();
                       txtmt_igv.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["mt_igv"].Value.ToString();
                       txtidcliente.Text = dgvSalida.Rows[Convert.ToInt16(count)].Cells["id_cliente"].Value.ToString();
                       //frm._drow = count.ToString();
                       //MessageBox.Show(frm._drow.ToString());
                }                

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        }


    
}
