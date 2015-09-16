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
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class FrmSalida_Detalle_popup : Form
    {

        public object FormParent { get; set; }

        public int EstadoDet = 0;// esto define si se añade un nuevo Item o solo va a ser modificado el item  // 1 --> para añadir un nuevo item , 2 --> para modificar un item
        //public string dscliente, dsvendedor;
        public string idSalida,idreqsalida;
        public string _id_cliprod;
        public FrmSalida_Detalle_popup()
        {
            InitializeComponent();
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
            txtnu_rollo_pend.Text = obj.Qt_rollo_pend.ToString();
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
                txtstock.Text = oListDato[0].Qt_rollo.ToString();
            }
            else
            {
                txtstock.Text = "0";
            }
            if (idSalida.ToString() == "")
            {

            }
            else
            {
                CargarDetalle();
            }

        }

        //--------------------------------------------------------------

        private void CargarDetalle()
        {


            if (idSalida != "" && idreqsalida != "")
            {
                ESalida_Detalle objSD = new ESalida_Detalle();
                objSD.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objSD.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                objSD.IdSalida = idSalida.ToString();
                objSD._pidreqsalida = idreqsalida.ToString();
                objSD.Id_producto = txtidproducto.Text.Trim();
                objSD.Id_color = txtidcolor.Text.Trim();


                List<ESalida_Detalle> lstIG = new List<ESalida_Detalle>();
                lstIG = BSalida_Detalle.AL_Salida_Detalle_qry03(objSD);

                foreach (ESalida_Detalle _objSD in lstIG)
                {
                    string[] row =                        
                                {
                             _objSD.Nu_item,
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
                                                   
                             txtprecio.Text,             
                          
                                };
                    dgvSalida.Rows.Add(row);
                }
                lblitem.Text = dgvSalida.RowCount.ToString();
            }
            else
            { 

            }

        }



  

        public void LlenarGrilla_temp(ESalida_Detalle obj, object form)
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
                MessageBox.Show(row[17].ToString() + " "+ row[7].ToString() + " "+ row[9].ToString());
                //if ((row[17].ToString() == txtds_cliente.Text) && (row[7].ToString() == txtidproducto.Text) && (row[9].ToString() == txtidcolor.Text))
                //{
                    //dgvSalida.Rows.Add(row);
                //}
                //else
                //{
 
                //}

        }

        //-------------------------------------------------------------




        private void FrmSalida_Detalle_popup_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoRow_Click(object sender, EventArgs e)
        {

            FrmSalidaProducto_Popup frm = new FrmSalidaProducto_Popup();
            frm.FormParent = this;
            frm.EstadoDet = 3;
            frm.ShowDialog();
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
            int count = 0;
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



            if (txtid_cliente.Text.Trim() == _id_cliprod && txtidproducto.Text.Trim() == obj.Id_producto && txtidcolor.Text.Trim() == obj.Id_color )//&& id_vendedor == obj.Id_vendedor
            {
                count = count + 1;
            }
            else
            {

            }
            //----------------------------------------------------------------------------
            if (count != 0)
            {
                if (count2 ==0)
                {
                    if ((Convert.ToInt16(txtnurollo.Text) > Convert.ToInt16(lblitem.Text)) & (Convert.ToInt16(txtnu_rollo_pend.Text) > 0))
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
                             //obj.Mt_precio.ToString(),                            
                             txtprecio.Text,                         
                           };

                        dgvSalida.Rows.Add(row);
                        lblitem.Text = dgvSalida.RowCount.ToString();
                        FrmSalidaProducto_Popup frmPopup = (FrmSalidaProducto_Popup)form;
                        
                        //frmPopup.Close();
                    }
                    else
                    {
                        MessageBox.Show("Llego al limite de # Rollos de la OP", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        FrmSalidaProducto_Popup frm = (FrmSalidaProducto_Popup)form;
                        //frm.mensaje = "Llego al limite de # Rollos de la OP";
                        //frm.Close();
                    }
                }
                else
                {                    
                    MessageBox.Show("Ya existe este Articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmSalidaProducto_Popup frm = (FrmSalidaProducto_Popup)form;
                    //frm.mensaje = "Ya existe este Articulo";
                    //frm.Close();
                }
            }
            else
            {
                
                MessageBox.Show("Producto no existe en la Orden de Pedido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmSalidaProducto_Popup frm = (FrmSalidaProducto_Popup)form;
//                frm.mensaje = "Producto no existe en la Orden de Pedido";
                //frm.Close();
            }
        }

        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            ESalida_Detalle obj = new ESalida_Detalle();


            FrmSalida frm = (FrmSalida)FormParent;
            EDTipImpuesto dti = new EDTipImpuesto();
            for (int i = 0; dgvSalida.Rows.Count > i; i++)
            {


                var _nu_item = dgvSalida.Rows[i].Cells["nu_item"].Value;
                var _CodBar = dgvSalida.Rows[i].Cells["CodBar"].Value;
                var _nu_tf = dgvSalida.Rows[i].Cells["nu_tf"].Value;
                var _nu_op = dgvSalida.Rows[i].Cells["nu_op"].Value;
                var _id_mercado = dgvSalida.Rows[i].Cells["id_mercado"].Value;
                var _id_tipo = dgvSalida.Rows[i].Cells["id_tipo"].Value;
                var _tipo_tela = dgvSalida.Rows[i].Cells["tipo_tela"].Value;
                var _id_producto = dgvSalida.Rows[i].Cells["id_producto"].Value;
                var _ds_producto = dgvSalida.Rows[i].Cells["ds_producto"].Value;
                var _id_color = dgvSalida.Rows[i].Cells["id_color"].Value;
                var _ds_color = dgvSalida.Rows[i].Cells["ds_color"].Value;
                var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value;
                var _qt_peso_actual = dgvSalida.Rows[i].Cells["qt_peso"].Value;
                var _qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value;
                var _mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value;
                
      

                obj.Nu_item = _nu_item.ToString();
                obj.CodBar = _CodBar.ToString();
                obj.Nu_tf = _nu_tf.ToString();
                obj.Nu_op = _nu_op.ToString();
                obj.Id_mercado = _id_mercado.ToString();
                obj.Id_tipo = _id_tipo.ToString();
                obj.Id_tiptela = _tipo_tela.ToString();
                obj.Id_producto = _id_producto.ToString();
                obj.Ds_producto = _ds_producto.ToString();
                obj.Id_color = _id_color.ToString();
                obj.Ds_color = _ds_color.ToString();
                obj.Qt_rollo = Convert.ToInt16(_nu_rollo);
                obj.Qt_peso_Actual = Convert.ToDecimal(_qt_peso_actual);
                obj.Qt_peso = Convert.ToDecimal(_qt_peso);
                obj.Mt_precio = Convert.ToDecimal(_mt_precio);



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

                    deSuma = (Convert.ToDecimal(_qt_peso)) * (Convert.ToDecimal(_mt_precio));
                    obj.Mt_igv = Convert.ToDecimal("0.0000");
                    obj.Mt_total = Convert.ToDecimal(deSuma);

                }
                else
                {

                    deSuma = (Convert.ToDecimal(_qt_peso)) * (Convert.ToDecimal(_mt_precio));
                        
                    obj.Mt_igv = imp * deSuma;
                    obj.Mt_total = (deSuma);                   
                }

                obj._id_cliente = txtid_cliente.Text;
                frm.CargarGrilla(obj, this);
          
                this.Close();
            }

        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalida_Detalle_popup_KeyDown(object sender, KeyEventArgs e)
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

                FrmSalidaProducto_Popup frm = new FrmSalidaProducto_Popup();
                frm.FormParent = this;
                frm.EstadoDet = 3;
                frm.ShowDialog();
            }
        }

        //private void Grabar()
        //{

        //    ESalida_Detalle objSD = new ESalida_Detalle();
        //    ////------------------------Detalle de compras----------------------------------------------------  


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
        //        var id_color = dgvSalida.Rows[i].Cells["id_color"].Value.ToString();
        //        var _nu_rollo = dgvSalida.Rows[i].Cells["_nu_rollo"].Value.ToString();
        //        var qt_peso = dgvSalida.Rows[i].Cells["qt_peso"].Value.ToString();
        //        var mt_precio = dgvSalida.Rows[i].Cells["mt_precio"].Value.ToString();






        //        objSD.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion                        
        //        objSD.IdPeriodo = wfChgEmpPer.datos.idperiodo;
        //        objSD.IdSalida = txtid_salida.Text;

        //        objSD.Id_producto = _id_producto.ToString();
        //        objSD.Nu_item = nu_item.ToString();
        //        objSD.CodBar = CodBar.ToString();
        //        objSD.Nu_op = nu_op.ToString().ToUpper();
        //        objSD.Nu_tf = nu_tf.ToString().ToUpper();
        //        objSD.Id_color = id_color.ToString();
        //        objSD.Id_tipo = id_tipo.ToString();
        //        objSD.Id_mercado = id_mercado.ToString();
        //        objSD.Id_tiptela = tipo_tela.ToString();
        //        objSD.Qt_rollo = Convert.ToInt32(_nu_rollo);
        //        objSD.Qt_peso = Convert.ToDecimal(qt_peso);
        //        objSD.Mt_precio = Convert.ToDecimal(mt_precio);
        //        objSD.Id_ucreatrec = frmLogin.d.id.ToLower();

        //        BSalida_Detalle.AL_Salida_Detalle_mnt01(objSD);


        //    }





        //    //ANULAR EL DETALLE

        //    ESalida_Detalle objDS = new ESalida_Detalle();

        //    for (int i = 0; dgTempDet.Rows.Count > i; i++)
        //    {
        //        var nu_secue = dgTempDet.Rows[i].Cells["nusecuencia"].Value;

        //        var cod_barra = dgTempDet.Rows[i].Cells["codbarra"].Value;
        //        var peso = dgTempDet.Rows[i].Cells["peso"].Value;

        //        objDS.IdPeriodo = wfChgEmpPer.datos.idperiodo;
        //        objDS.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion

        //        objDS.IdSalida = txtid_salida.Text;
        //        objDS.Nu_item = nu_secue.ToString();
        //        objDS.CodBar = cod_barra.ToString();
        //        objDS.Qt_peso = Convert.ToDecimal(peso);
        //        objDS.Id_uupdarec = frmLogin.d.id.ToLower();
        //        BSalida_Detalle.Al_Salida_Detalle_mnt03(objDS);
        //    }

        //    dgTempDet.Rows.Clear();


        //    MessageBox.Show(txtid_salida.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

    }
}
