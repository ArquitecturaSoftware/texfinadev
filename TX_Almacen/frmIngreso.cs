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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            WebHelper.LoadListControl3(cb_sedeEnvio, BGeneral.ObtenerDatoLocal());
            
            WebHelper.LoadListControl3(cb_almacen, BAlmacen.ObtenerDatoAlmacen());
            WebHelper.LoadListControl3(cbtipo_doc, BDocumento.ObtenerDatoTfactura());
            //btnGrabar.Enabled = false;
            //btnNuevoRow.Enabled = false;
            //btnEliminarRow.Enabled = false;

            validacionFrmIngreso();
            
        }

        private void frmIngreso_Load(object sender, EventArgs e)
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
                u.IdModulo = "04";
                u.Id_formulario = "0002";

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

        private void NuevoRegistro()
        {
            List<EIngresoDetalle> lstProd = new List<EIngresoDetalle>();
 
            dgDetalle.DataSource = lstProd;
         //----------------------------------------------------------------
            //List<EIngresoDetalle> lst = new List<EIngresoDetalle>();

        }

        private void nuevo()
        {

           
            HabilitarTexto(tableLayoutPanel1);
            HabilitarTexto(tableLayoutPanel2);
            
            HabilitarTexto(tableLayoutPanel4);
            HabilitarTexto(tableLayoutPanel5);
           
            dgvDetalle_.Rows.Clear();
            NuevoRegistro();
            cb_almacen.SelectedValue = "001";
          
            cb_sedeEnvio.SelectedIndex = -1;
            cbtipo_doc.SelectedIndex = -1;

            Limpiar(tableLayoutPanel1);
            Limpiar(tableLayoutPanel2);
            
            Limpiar(tableLayoutPanel4);
            Limpiar(tableLayoutPanel5);
            txtidIngreso.ReadOnly = true;

            List<Dato> oListUsu = BOrdenCompra.OrderCompra_Usuario_qry_(frmLogin.d.dsu);
            if (oListUsu.Count > 0)
            {
                txtidrecibidopor.Text = oListUsu[0].id;
                txtrecibidopor.Text = oListUsu[0].desc;
            }
            btnentregapor.Enabled = true;
          
            tabControl1.SelectedIndex = 0;
            
            btnNuevoRow.Enabled = true;
            btnEliminarRow.Enabled = true;

            txtpesodesp1.Clear();
            txtnrollo1.Clear();
           

            DateTime fecha = DateTime.Now;
            txtfecha.Text = fecha.ToString("d");
            txtfecha.Focus();

        }



        private void HabilitarTexto(TableLayoutPanel grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                    txtfecha.Enabled = true;
                }
                if (c is ComboBox)
                {
                    c.Enabled = true;
                }
                
            }
        }


        private void DeshabilitarTexto(TableLayoutPanel grupo)
        {
            foreach (Control c in grupo.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                    txtfecha.Enabled = false;
                }
                if (c is ComboBox)
                {
                    c.Enabled = false;
                }
            }

        }


        private void Limpiar(TableLayoutPanel grupo)
        {
           foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtfecha.Focus();

                }
            }

     
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Seguro que desea Limpiar?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    validacionNuevo();
                    nuevo();
                    btnGrabar.Enabled = true;
                }
                else if (result == DialogResult.No)
                {
                }
            }

            
        }

        private void txtfecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cb_sedeEnvio.Focus();
            }
        }

        private void cbsedeEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEntregadoPor.Focus();
            }
        }

        private void txtEntregadoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
              if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtEntregadoPor.Text = txtEntregadoPor.Text.PadLeft(5, '0');
                EPersonalBandeja per = new EPersonalBandeja();
                per.psintypesel = 1;
                per.IdPersonal = txtEntregadoPor.Text;
                per.NuDocIden = "";
                per.DsApellNom = "";
                ComboBox cb = new ComboBox();

                List<Dato> oListDato = BPersonalBandeja.ObtenerDatoPersonal(per);
                if (oListDato.Count > 0)
                {
                    txtdsEntregadoPor.Text = oListDato[0].desc;
                    cb_almacen.Focus();
                }
                else

                {
                    MessageBox.Show("Personal no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEntregadoPor.Clear();
                    txtdsEntregadoPor.Clear();
                    txtEntregadoPor.Focus();
                }
             

           
            }
         
        }

        private void cb_sedeEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtidrecibidopor.Focus();
            }

        }

        private void cb_almacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbtipo_doc.Focus();
            }
        }

        private void cbtipo_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuDoc.Focus();
            }
        }

        private void txtnuDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsObserv.Focus();
            }
        }

        private void txtidrecibidopor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cb_almacen.Focus();
            }
        }

        private void btnentregapor_Click(object sender, EventArgs e)
        {
            frmPersonal_qry frmps = new frmPersonal_qry();
            frmps.pasard += new frmPersonal_qry.pasar(ejecutarPers);
            frmps.ShowDialog();
            txtEntregadoPor.Focus();
        }

        public void ejecutarPers(string idPers, string dsPers)
        {
            txtEntregadoPor.Text = idPers;
            txtdsEntregadoPor.Text = dsPers;
        }

        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            try
            {


                //**********************************************************************************************

                frmProductoPopup frmps = new frmProductoPopup();
                frmps.FormParent = this;
                frmps.EstadoDet = 1;             
                frmps.ShowDialog();          
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtEntregadoPor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmPersonal_qry frmps = new frmPersonal_qry();
                frmps.pasard += new frmPersonal_qry.pasar(ejecutarPers);
                frmps.ShowDialog();
                txtEntregadoPor.Focus();
            }
        }


        public void LlenarGrilla(EIngresoDetalle obj, object form)
        {
            string str = Convert.ToString(dgvDetalle_.Rows.Count + 1);
            string[] row = { 
                             obj.Nu_Item=str.PadLeft(3, '0'),
                             obj.Nu_tf,
                             obj.Nu_op,
                             obj.Id_mercado,
                             obj.Id_tipTela,
                             obj.Id_Tipo,
                             obj.Id_TipIngreso,
                             obj.Id_clipro,
                             obj.ds_clipro,
                             obj.Id_producto,
                             obj.ds_producto,
                             obj.Id_color,
                             obj.ds_color,
                             obj.Qt_rollo.ToString(),
                             obj.Qt_peso_desp.ToString(),
                             obj.Qt_ancho.ToString(),
                             obj.Qt_densidad.ToString(), 
                             obj.id_Vendedor.ToString(),
                             obj.Ds_Vendedor.ToString(),
                           };
            dgvDetalle_.Rows.Add(row);

            
            frmProductoPopup frmPopup = (frmProductoPopup)form;
            mCalcula1();
            frmPopup.Close();
            

        }


        private void AñadirRow()
        {
            DateTime fecha = Convert.ToDateTime(txtfecha.Text);
            string periodo = fecha.Year.ToString();
            string mes = fecha.Month.ToString();
            string dia = fecha.Day.ToString();

            NuevoRegistro();


            if (dgDetalle.Rows.Count > 0)
            {
                SalvarGrilla();
                //-------------------------------------------------------------------------------------



                List<EIngresoDetalle> lstSalvarDatos = new List<EIngresoDetalle>();
                lstSalvarDatos = (List<EIngresoDetalle>)SalvarDatos;


                for (int u = 0; dgvDetalle_.Rows.Count > u; u++)
                {
                    var nrollo = dgvDetalle_.Rows[u].Cells["qt_rollo"].Value;


                    for (int i = 0; Convert.ToInt16(nrollo) > i; i++)
                    {
                        EIngresoDetalle obj = new EIngresoDetalle();

                        string str = Convert.ToString(i + 1);
                        obj.Nu_Item = str.PadLeft(2, '0');
                        //obj.Cod_Bar = periodo + mes.PadLeft(2, '0') + dia.PadLeft(2, '0') + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + "1" + obj.Nu_Item.ToString().Trim();
                        obj.Cod_Bar = periodo + wfChgEmpPer.datos.idEmpresa + txtidIngreso.Text + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() +  obj.Nu_Item.ToString().Trim();
                        obj.Cod_Bar2 = BarCode.BarcodeConverter128.StringToBarcode(periodo + wfChgEmpPer.datos.idEmpresa + txtidIngreso.Text + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + obj.Nu_Item.ToString().Trim());

                        obj.Nu_tf = dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString();
                        obj.Nu_op = dgvDetalle_.Rows[u].Cells["nu_op"].Value.ToString();
                        obj.Id_mercado = dgvDetalle_.Rows[u].Cells["_Id_mercado"].Value.ToString();
                        obj.Id_tipTela = dgvDetalle_.Rows[u].Cells["_Id_TipTela"].Value.ToString();
                        obj.Id_Tipo = dgvDetalle_.Rows[u].Cells["id_tipo"].Value.ToString();
                        obj.Id_TipIngreso = dgvDetalle_.Rows[u].Cells["tipo_ingreso"].Value.ToString();
                        obj.Id_clipro = dgvDetalle_.Rows[u].Cells["iDCliente"].Value.ToString();
                        obj.ds_clipro = dgvDetalle_.Rows[u].Cells["nom_cliente"].Value.ToString();
                        obj.Id_producto = dgvDetalle_.Rows[u].Cells["iDProducto"].Value.ToString();
                        obj.ds_producto = dgvDetalle_.Rows[u].Cells["dsProducto"].Value.ToString();
                        obj.Id_color = dgvDetalle_.Rows[u].Cells["iDcolor"].Value.ToString();
                        obj.ds_color = dgvDetalle_.Rows[u].Cells["dsColor"].Value.ToString();
                        obj.Qt_rollo = Convert.ToInt16(nrollo) / Convert.ToInt16(nrollo);
                        obj.Qt_peso_desp = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_peso_desp"].Value);
                        obj.Qt_peso_real = decimal.Parse("0.0000");
                        obj.Qt_ancho = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_ancho"].Value);
                        obj.Qt_densidad = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_densidad"].Value);
                        obj.id_Vendedor = dgvDetalle_.Rows[u].Cells["_id_Vendedor"].Value.ToString();
                        obj.Ds_Vendedor = dgvDetalle_.Rows[u].Cells["_dsVendedor"].Value.ToString();


                        lstSalvarDatos.Add(obj);



                    }
                }
                dgDetalle.DataSource = lstSalvarDatos;
                //tabControl1.SelectedIndex = 1;
                dgDetalle.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            else
            {
                List<EIngresoDetalle> lstSalvarDatos = new List<EIngresoDetalle>();

                for (int u = 0; dgvDetalle_.Rows.Count > u; u++)
                {
                    var nrollo = dgvDetalle_.Rows[u].Cells["qt_rollo"].Value;

                    //var nrollo = dgvDetalle_.CurrentRow.Cells["qt_rollo"].Value;



                    for (int i = 0; Convert.ToInt16(nrollo) > i; i++)
                    {
                        EIngresoDetalle obj = new EIngresoDetalle();

                        string str = Convert.ToString(i + 1);
                        obj.Nu_Item = str.PadLeft(2, '0');
                        //obj.Cod_Bar = periodo + mes.PadLeft(2, '0') + dia.PadLeft(2, '0') + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + "1" + str.PadLeft(2, '0');
                        obj.Cod_Bar = periodo + wfChgEmpPer.datos.idEmpresa + txtidIngreso.Text + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + obj.Nu_Item.ToString().Trim();
                        obj.Cod_Bar2 = BarCode.BarcodeConverter128.StringToBarcode(periodo + wfChgEmpPer.datos.idEmpresa + txtidIngreso.Text + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + obj.Nu_Item.ToString().Trim());

                        //obj.Cod_Bar2 = BarCode.BarcodeConverter128.StringToBarcode(periodo + mes.PadLeft(2, '0') + dia.PadLeft(2, '0') + dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString().Trim() + "1" + obj.Nu_Item.ToString().Trim());

                        obj.Nu_tf = dgvDetalle_.Rows[u].Cells["nu_tf"].Value.ToString();
                        obj.Nu_op = dgvDetalle_.Rows[u].Cells["nu_op"].Value.ToString();

                        obj.Id_mercado = dgvDetalle_.Rows[u].Cells["_Id_mercado"].Value.ToString();
                        obj.Id_tipTela = dgvDetalle_.Rows[u].Cells["_Id_TipTela"].Value.ToString();

                        obj.Id_Tipo = dgvDetalle_.Rows[u].Cells["id_tipo"].Value.ToString();
                        obj.Id_TipIngreso = dgvDetalle_.Rows[u].Cells["tipo_ingreso"].Value.ToString();
                        obj.Id_clipro = dgvDetalle_.Rows[u].Cells["iDCliente"].Value.ToString();
                        obj.ds_clipro = dgvDetalle_.Rows[u].Cells["nom_cliente"].Value.ToString();
                        obj.Id_producto = dgvDetalle_.Rows[u].Cells["iDProducto"].Value.ToString();
                        obj.ds_producto = dgvDetalle_.Rows[u].Cells["dsProducto"].Value.ToString();
                        obj.Id_color = dgvDetalle_.Rows[u].Cells["iDcolor"].Value.ToString();
                        obj.ds_color = dgvDetalle_.Rows[u].Cells["dsColor"].Value.ToString();
                        obj.Qt_rollo = Convert.ToInt16(nrollo) / Convert.ToInt16(nrollo);
                        obj.Qt_peso_desp = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_peso_desp"].Value);
                        obj.Qt_peso_real = decimal.Parse("0.0000");

                        obj.Qt_ancho = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_ancho"].Value);
                        obj.Qt_densidad = Convert.ToDecimal(dgvDetalle_.Rows[u].Cells["qt_densidad"].Value);
                        obj.id_Vendedor = dgvDetalle_.Rows[u].Cells["_id_Vendedor"].Value.ToString();
                        obj.Ds_Vendedor = dgvDetalle_.Rows[u].Cells["_dsVendedor"].Value.ToString();

                        lstSalvarDatos.Add(obj);

                    }
                }
                dgDetalle.DataSource = lstSalvarDatos;
                //tabControl1.SelectedIndex = 1;
                dgDetalle.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            }

            mCalcula2();

        }


     

        List<EIngresoDetalle> SalvarDatos = new List<EIngresoDetalle>();

        private void SalvarGrilla()
        {
         
            List<EIngresoDetalle> lstSalvarDatos = new List<EIngresoDetalle>();
            for (int i = 0; dgDetalle.Rows.Count > i; i++)
            {
                EIngresoDetalle obj = new EIngresoDetalle();

                obj.Nu_Item = dgDetalle.Rows[i].Cells["Item_"].Value.ToString();
                obj.Cod_Bar = dgDetalle.Rows[i].Cells["codBarr"].Value.ToString();
                obj.Cod_Bar2 = dgDetalle.Rows[i].Cells["Cod_Bar2"].Value.ToString();
                obj.Nu_tf = dgDetalle.Rows[i].Cells["nu_tf_"].Value.ToString();
                obj.Nu_op = dgDetalle.Rows[i].Cells["nu_op_"].Value.ToString();

                obj.Id_mercado = dgDetalle.Rows[i].Cells["id_Mercado"].Value.ToString();
                obj.Id_tipTela = dgDetalle.Rows[i].Cells["id_tipTela"].Value.ToString();


                obj.Id_Tipo = dgDetalle.Rows[i].Cells["id_tipo_"].Value.ToString();
                obj.Id_TipIngreso = dgDetalle.Rows[i].Cells["tipo_ingreso_"].Value.ToString();
                obj.Id_clipro = dgDetalle.Rows[i].Cells["iDCliente_"].Value.ToString();
                obj.ds_clipro = dgDetalle.Rows[i].Cells["nom_cliente_"].Value.ToString();
                obj.Id_producto = dgDetalle.Rows[i].Cells["iDProducto_"].Value.ToString();
                obj.ds_producto = dgDetalle.Rows[i].Cells["dsProducto_"].Value.ToString();
                obj.Id_color = dgDetalle.Rows[i].Cells["iDcolor_"].Value.ToString();
                obj.ds_color = dgDetalle.Rows[i].Cells["dsColor_"].Value.ToString();
                obj.Qt_rollo = Convert.ToInt16(dgDetalle.Rows[i].Cells["qt_rollo_"].Value.ToString());
                obj.Qt_peso_desp = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_peso_desp_"].Value.ToString());
                obj.Qt_peso_real = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_peso_real"].Value.ToString());

                obj.Qt_ancho = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_ancho_"].Value);
                obj.Qt_densidad = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_densidad_"].Value);

                obj.id_Vendedor = dgDetalle.Rows[i].Cells["id_Vendedor"].Value.ToString();
                obj.Ds_Vendedor = dgDetalle.Rows[i].Cells["dsVendedor"].Value.ToString();
           
                lstSalvarDatos.Add(obj);
                
            } SalvarDatos = lstSalvarDatos;
      
        }




        List<EIngresoDetalle> SalvarDatos1 = new List<EIngresoDetalle>();
        private void SalvarGrilla1()
        {

            List<EIngresoDetalle> lstSalvarDatos = new List<EIngresoDetalle>();
            for (int i = 0; dgvDetalle_.Rows.Count > i; i++)
            {
                EIngresoDetalle obj = new EIngresoDetalle();

                obj.Nu_Item = dgvDetalle_.Rows[i].Cells["Item"].Value.ToString();
              
                obj.Nu_tf = dgvDetalle_.Rows[i].Cells["nu_tf"].Value.ToString();
                obj.Nu_op = dgvDetalle_.Rows[i].Cells["nu_op"].Value.ToString();

                obj.Id_mercado = dgvDetalle_.Rows[i].Cells["_Id_mercado"].Value.ToString();
                obj.Id_tipTela = dgvDetalle_.Rows[i].Cells["_Id_TipTela"].Value.ToString();

                obj.Id_Tipo = dgvDetalle_.Rows[i].Cells["id_tipo"].Value.ToString();
                obj.Id_TipIngreso = dgvDetalle_.Rows[i].Cells["tipo_ingreso"].Value.ToString();
                obj.Id_clipro = dgvDetalle_.Rows[i].Cells["iDCliente"].Value.ToString();
                obj.ds_clipro = dgvDetalle_.Rows[i].Cells["nom_cliente"].Value.ToString();
                obj.Id_producto = dgvDetalle_.Rows[i].Cells["iDProducto"].Value.ToString();
                obj.ds_producto = dgvDetalle_.Rows[i].Cells["dsProducto"].Value.ToString();
                obj.Id_color = dgvDetalle_.Rows[i].Cells["iDcolor"].Value.ToString();
                obj.ds_color = dgvDetalle_.Rows[i].Cells["dsColor"].Value.ToString();
                obj.Qt_rollo = Convert.ToInt16(dgvDetalle_.Rows[i].Cells["qt_rollo"].Value.ToString());
                obj.Qt_peso_desp = Convert.ToDecimal(dgvDetalle_.Rows[i].Cells["qt_peso_desp"].Value.ToString());                
                obj.Qt_ancho = Convert.ToDecimal(dgvDetalle_.Rows[i].Cells["qt_ancho"].Value);
                obj.Qt_densidad = Convert.ToDecimal(dgvDetalle_.Rows[i].Cells["qt_densidad"].Value);

                lstSalvarDatos.Add(obj);
                
            } SalvarDatos1 = lstSalvarDatos;

        }

        private void btnEliminarRow_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtidIngreso.Text == "")
                {
                    dgvDetalle_.Rows.RemoveAt(dgvDetalle_.CurrentCell.RowIndex);

                    AñadirRow();

                }
                else
                { 
                    AnularDetalleIngreso();
                    dgvDetalle_.Rows.RemoveAt(dgvDetalle_.CurrentCell.RowIndex);
                    BuscarIngreso();

                }

               
            }
            catch (Exception EX)
            {
                EX.ToString();
            }

        }

        //private void btnEliminarRow2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SalvarGrilla();

        //        int u = dgDetalle.CurrentCell.RowIndex;


        //        List<EIngresoDetalle> lsListadoActual = (List<EIngresoDetalle>)SalvarDatos;
        //        lsListadoActual.RemoveAt(u);


        //        SalvarDatos = lsListadoActual;
        //        dgDetalle.DataSource = lsListadoActual;
        //    }
        //    catch (Exception ex)
        //    {
        //        e.ToString();
        //    }


        //}

        private void btnNuevoRow2_Click(object sender, EventArgs e)
        {
            NuevoRegistro();
        }

        string _drow;
        private void dgvDetalle__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dRow = dgvDetalle_.Rows[e.RowIndex];
                _drow = dRow.Index.ToString();


                EIngresoDetalle obj = new EIngresoDetalle();
                obj.IdIngreso = txtidIngreso.Text;
                string fecha = txtfecha.Value.Date.ToShortDateString();
                obj.fecha = fecha;
                obj.Nu_Item = (dRow.Cells["Item"].Value == null) ? "" : dRow.Cells["Item"].Value.ToString();
                obj.Nu_tf = (dRow.Cells["nu_tf"].Value == null) ? "" : dRow.Cells["nu_tf"].Value.ToString();
                obj.Nu_op = (dRow.Cells["nu_op"].Value == null) ? "" : dRow.Cells["nu_op"].Value.ToString();

                obj.Id_mercado = (dRow.Cells["_Id_mercado"].Value == null) ? "" : dRow.Cells["_Id_mercado"].Value.ToString();
                obj.Id_tipTela = (dRow.Cells["_Id_TipTela"].Value == null) ? "" : dRow.Cells["_Id_TipTela"].Value.ToString();

                obj.Id_Tipo = (dRow.Cells["id_tipo"].Value == null) ? "" : dRow.Cells["id_tipo"].Value.ToString();
                obj.Id_TipIngreso = (dRow.Cells["tipo_ingreso"].Value == null) ? "" : dRow.Cells["tipo_ingreso"].Value.ToString();
                obj.Id_clipro = (dRow.Cells["iDCliente"].Value == null) ? "" : dRow.Cells["iDCliente"].Value.ToString();
                obj.ds_clipro = (dRow.Cells["nom_cliente"].Value == null) ? "" : dRow.Cells["nom_cliente"].Value.ToString();
                obj.Id_producto = (dRow.Cells["iDProducto"].Value == null) ? "" : dRow.Cells["iDProducto"].Value.ToString();
                obj.ds_producto = (dRow.Cells["dsProducto"].Value == null) ? "" : dRow.Cells["dsProducto"].Value.ToString();
                obj.Id_color = (dRow.Cells["iDcolor"].Value == null) ? "" : dRow.Cells["iDcolor"].Value.ToString();
                obj.ds_color = (dRow.Cells["dsColor"].Value == null) ? "" : dRow.Cells["dsColor"].Value.ToString();
                obj.Qt_rollo = (dRow.Cells["qt_rollo"].Value == null) ? 0 : Convert.ToInt16(dRow.Cells["qt_rollo"].Value.ToString());
                obj.Qt_peso_desp = (dRow.Cells["qt_peso_desp"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["qt_peso_desp"].Value.ToString());
                obj.Qt_ancho = (dRow.Cells["qt_ancho"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["qt_ancho"].Value.ToString());
                obj.Qt_densidad = (dRow.Cells["qt_densidad"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["qt_densidad"].Value.ToString());

                obj.id_Vendedor = (dRow.Cells["_id_Vendedor"].Value == null) ? string.Empty : (dRow.Cells["_id_Vendedor"].Value.ToString());
                obj.Ds_Vendedor = (dRow.Cells["_dsVendedor"].Value == null) ? string.Empty : (dRow.Cells["_dsVendedor"].Value.ToString());

                frmProductoPopup frm = new frmProductoPopup();
                frm.FormParent = this;
                frm.EstadoDet = 2;
                frm._idIngreso = txtidIngreso.Text;
                frm.LLenarCampos(obj);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ModGuilla(EIngresoDetalle obj, object form)
        {


            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["Item"]).Value = obj.Nu_Item;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["nu_tf"]).Value = obj.Nu_tf;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["nu_op"]).Value = obj.Nu_op;

            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["_Id_mercado"]).Value = obj.Id_mercado;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["_Id_TipTela"]).Value = obj.Id_tipTela;

            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["id_tipo"]).Value = obj.Id_Tipo;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["tipo_ingreso"]).Value = obj.Id_TipIngreso;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["iDCliente"]).Value = obj.Id_clipro;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["nom_cliente"]).Value = obj.ds_clipro;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["iDProducto"]).Value = obj.Id_producto;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["dsProducto"]).Value = obj.ds_producto;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["iDcolor"]).Value = obj.Id_color;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["dsColor"]).Value = obj.ds_color;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["qt_rollo"]).Value = obj.Qt_rollo;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["qt_peso_desp"]).Value = obj.Qt_peso_desp;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["qt_ancho"]).Value = obj.Qt_ancho;

            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["qt_densidad"]).Value = obj.Qt_densidad;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["_id_Vendedor"]).Value = obj.id_Vendedor;
            (dgvDetalle_.Rows[int.Parse(_drow)].Cells["_dsVendedor"]).Value = obj.Ds_Vendedor;


            frmProductoPopup frm = (frmProductoPopup)form;
            frm.EstadoDet = 2;
        
            frm.Close();          
        }



        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    EIngreso objI = new EIngreso();
                    EIngresoDetalle objID = new EIngresoDetalle();


                 

                    if (txtidIngreso.Text == "")
                    {
                       
                        
                        List<Dato> oListDato = BIngreso.IngresoGenCod(wfChgEmpPer.datos.idperiodo, wfChgEmpPer.datos.idEmpresa);
                        if (oListDato.Count > 0)
                        {
                            txtidIngreso.Text = oListDato[0].id;
                        }

                        objI.IdIngreso = txtidIngreso.Text;
                        objID.IdIngreso = txtidIngreso.Text;
                    }
                    else
                    {
                        

                        objI.IdIngreso = txtidIngreso.Text;
                        objID.IdIngreso = txtidIngreso.Text;
                    }
                    objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;

                    string fecha = txtfecha.Value.Date.ToShortDateString();
                    
                    objI.Feguia = fecha;
                    objI.Id_local = cb_sedeEnvio.SelectedValue.ToString();
                    objI.Id_Personal1 = txtEntregadoPor.Text;
                 
                    objI.Id_Personal2 = txtidrecibidopor.Text;
                    objI.Id_docucom = cbtipo_doc.SelectedValue.ToString();
                    objI.Nu_doc = txtnuDoc.Text;
                    objI.Id_Almacen = cb_almacen.SelectedValue.ToString();
                    objI.ds_observ = txtdsObserv.Text;
                    objI.Id_ucreatrec = frmLogin.d.id.ToLower(); 

                    BIngreso.Ingreso_mnt01(objI);


                    AñadirRow();
      

                    ////------------------------Detalle de compras----------------------------------------------------  


                    for (int i = 0; dgDetalle.Rows.Count > i; i++)
                    {
                       var Nu_Item = dgDetalle.Rows[i].Cells["Item_"].Value.ToString();
                        var Cod_Bar = dgDetalle.Rows[i].Cells["codBarr"].Value.ToString();
                        var Cod_Bar2 = dgDetalle.Rows[i].Cells["Cod_Bar2"].Value.ToString();

                        var Nu_tf = dgDetalle.Rows[i].Cells["nu_tf_"].Value.ToString();
                        var Nu_op = dgDetalle.Rows[i].Cells["nu_op_"].Value.ToString();

                        var Id_mercado = dgDetalle.Rows[i].Cells["id_Mercado"].Value.ToString();
                        var Id_tiptela = dgDetalle.Rows[i].Cells["id_tipTela"].Value.ToString();


                        var Id_Tipo = dgDetalle.Rows[i].Cells["id_tipo_"].Value.ToString();
                        var Id_TipIngreso = dgDetalle.Rows[i].Cells["tipo_ingreso_"].Value.ToString();
                        var Id_clipro = dgDetalle.Rows[i].Cells["iDCliente_"].Value.ToString();
                        var ds_clipro = dgDetalle.Rows[i].Cells["nom_cliente_"].Value.ToString();
                        var Id_producto = dgDetalle.Rows[i].Cells["iDProducto_"].Value.ToString();
                        var ds_producto = dgDetalle.Rows[i].Cells["dsProducto_"].Value.ToString();
                        var Id_color = dgDetalle.Rows[i].Cells["iDcolor_"].Value.ToString();
                        var ds_color = dgDetalle.Rows[i].Cells["dsColor_"].Value.ToString();
                        var Qt_rollo = Convert.ToInt16(dgDetalle.Rows[i].Cells["qt_rollo_"].Value.ToString());
                        var Qt_peso_desp = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_peso_desp_"].Value.ToString());
                        var Qt_peso_real = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_peso_real"].Value.ToString());
                        var Qt_ancho = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_ancho_"].Value);
                        var Qt_densidad = Convert.ToDecimal(dgDetalle.Rows[i].Cells["qt_densidad_"].Value);
                        var IdVendedor = dgDetalle.Rows[i].Cells["id_Vendedor"].Value.ToString();



                        objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //llenar con sesion
                        objID.IdIngreso = txtidIngreso.Text;
                        objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                        objID.Cod_Bar = Cod_Bar.ToString();
                        objID.Id_producto = Id_producto;
                        objID.Id_clipro = Id_clipro.ToString();
                        objID.Id_color = Id_color.ToString();
                        objID.Nu_Item = Nu_Item.ToString();
                        objID.Nu_tf = Nu_tf.ToString();
                        objID.Nu_op = Nu_op.ToString();
                        objID.Id_mercado = Id_mercado.ToString();
                        objID.Id_tipTela = Id_tiptela.ToString();
                        objID.Id_Tipo = Id_Tipo.ToString();
                        objID.Id_TipIngreso = Id_TipIngreso.ToString();
                        objID.Qt_rollo = Convert.ToInt16(Qt_rollo);
                        objID.Qt_peso_desp = Convert.ToDecimal(Qt_peso_desp);
                        objID.Qt_peso_real = Convert.ToDecimal(Qt_peso_real);
                        objID.Qt_peso_actual = Convert.ToDecimal("0.000");
                        objID.Qt_densidad = Convert.ToDecimal(Qt_densidad);
                        objID.Qt_ancho = Convert.ToDecimal(Qt_ancho);
                        objID.id_Vendedor = IdVendedor.ToString();
                        objID.St_estado = "Pendiente";
                        objID.Id_ucreatrec = frmLogin.d.id.ToLower();
                        objID.Cod_Bar2 = Cod_Bar2.ToString();
                        BIngreso_Detalle.IngresoDetalle_mnt01(objID);
                        

                    }


                    //dgTemp.Rows.Clear();


                    MessageBox.Show(txtidIngreso.Text, "Datos Grabados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            validacionGrabar();
            Grabar();
            validacionNuevo();
        }

        private void frmIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                nuevo();
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                Grabar();
            }
            else if (e.KeyCode == Keys.C && e.Control)
            {

            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
               
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrmIngreso_qry frmoc = new FrmIngreso_qry();
                frmoc.pasard += new FrmIngreso_qry.pasar(EjecutarIngreso);
                frmoc.ShowDialog();
            }

            else if (e.KeyCode == Keys.E && e.Control)
            {
        
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {

                frmProductoPopup frmps = new frmProductoPopup();
                frmps.FormParent = this;
                frmps.EstadoDet = 1;
                frmps.ShowDialog();    
            }

        }


        protected void mCalcula1()
        {
            try
            {
   
                decimal nupesoDesp1 = 0;
                decimal deTotrollo1 = 0;

                for (int x = 0; x < dgvDetalle_.Rows.Count; x++)
                {

                    decimal nupesodes = Convert.ToDecimal(dgvDetalle_.Rows[x].Cells["qt_peso_desp"].Value);


                    decimal nurollo = Convert.ToDecimal(dgvDetalle_.Rows[x].Cells["qt_rollo"].Value);

                    nupesoDesp1 = nupesoDesp1 + nupesodes;
                    deTotrollo1 = deTotrollo1 + nurollo;

                    txtpesodesp1.Text = string.Format("{0:##,##0.0000}", nupesoDesp1);
                    txtnrollo1.Text = string.Format("{0:##,##0.0000}", deTotrollo1);

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

                decimal nupesoDesp2 = 0;
                decimal nupesoReal = 0;
                decimal deTotrollo2 = 0;

                for (int x = 0; x < dgDetalle.Rows.Count; x++)
                {

                    decimal nupesodes = Convert.ToDecimal(dgDetalle.Rows[x].Cells["qt_peso_desp_"].Value);

                    decimal nupesoreal = Convert.ToDecimal(dgDetalle.Rows[x].Cells["qt_peso_real"].Value);
                    decimal nurollo = Convert.ToDecimal(dgDetalle.Rows[x].Cells["qt_rollo_"].Value);


                    nupesoDesp2 = nupesoDesp2 + nupesodes;
                    nupesoReal = nupesoReal + nupesoreal;
                    deTotrollo2 = deTotrollo2 + nurollo;

                    txtpesoDesp2.Text = string.Format("{0:##,##0.0000}", nupesoDesp2);
                    txtPesoReal.Text = string.Format("{0:##,##0.0000}", nupesoReal);
                    txtnrollo2.Text = string.Format("{0:##,##0.0000}", deTotrollo2);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }



        private void dgDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            mCalcula2();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FrmIngreso_qry frmoc = new FrmIngreso_qry();
            frmoc.pasard += new FrmIngreso_qry.pasar(EjecutarIngreso);

            frmoc.ShowDialog();
            validacionBuscar();
                


            //btnGrabar.Enabled = false;
        }

        public void EjecutarIngreso(EIngresoDetalle obj)
        {
            txtBuscarIngreso.Text = obj.IdIngreso;
            BuscarIngreso();
            txtBuscarIngreso.Focus();
        }

        private void BuscarIngreso()
        {

            EIngreso objI = new EIngreso();

            objI.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objI.IdPeriodo = wfChgEmpPer.datos.idperiodo;

            txtBuscarIngreso.Text = txtBuscarIngreso.Text.PadLeft(7, '0'); 

            objI.IdIngreso = txtBuscarIngreso.Text.PadLeft(7, '0'); 

            List<EIngreso> oListDato = BIngreso.AL_Ingreso_qry05(objI);


            string val = oListDato[0].existe;

            if (val == "0")
            {

                try
                {

                    nuevo();
                    validacionBuscar();

                    EIngreso objIng = new EIngreso();


                    objIng.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objIng.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objIng.IdIngreso = txtBuscarIngreso.Text;

                    EIngreso oBtieneIg = new EIngreso();
                    oBtieneIg = BIngreso.AL_Ingreso_qry02(objIng);

                    txtidIngreso.Text = oBtieneIg.IdIngreso.ToString().Trim();
                    txtfecha.Text = oBtieneIg.Feguia.ToString();
                    

                    cb_sedeEnvio.SelectedValue = oBtieneIg.Id_local;

                    txtEntregadoPor.Text = oBtieneIg.Id_Personal1.ToString();
                    txtdsEntregadoPor.Text = oBtieneIg.dsPesonal1.ToString().Trim();
                    txtidrecibidopor.Text = oBtieneIg.Id_Personal2.ToString().Trim();
                    txtrecibidopor.Text = oBtieneIg.dsPesonal2.ToString().Trim();
                    
                    cb_almacen.SelectedValue = oBtieneIg.Id_Almacen.ToString().Trim();
                    cbtipo_doc.SelectedValue = oBtieneIg.Id_docucom.ToString();
                    txtnuDoc.Text = oBtieneIg.Nu_doc.ToString().Trim();
                    txtdsObserv.Text = oBtieneIg.ds_observ.ToString().Trim();
                    
                    ///Detalle de tejeduria

                    EIngresoDetalle objID = new EIngresoDetalle();

                    objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    objID.IdIngreso = txtidIngreso.Text;


                    List<EIngresoDetalle> lstIG = new List<EIngresoDetalle>();
                    lstIG = BIngreso_Detalle.AL_IngresoDetalle_qry01(objID);

                    foreach (EIngresoDetalle _objID in lstIG)
                    {
                        string[] row =
                        
                                {    _objID.Nu_Item,
                                     _objID.Nu_tf,
                                     _objID.Nu_op,
                                     _objID.Id_mercado,
                                     _objID.Id_tipTela,
                                     _objID.Id_Tipo,
                                     _objID.Id_TipIngreso,
                                     _objID.Id_clipro,
                                     _objID.ds_clipro,
                                     _objID.Id_producto,
                                     _objID.ds_producto,
                                     _objID.Id_color,                                     
                                     _objID.ds_color,
                                     _objID.Qt_rollo.ToString(),
                                     _objID.Qt_peso_desp.ToString(),
                                     _objID.Qt_ancho.ToString(),
                                     _objID.Qt_densidad.ToString(),  
                                     _objID.id_Vendedor.ToString(),
                                     _objID.Ds_Vendedor.ToString(),
                                                        
                                };
                        dgvDetalle_.Rows.Add(row);
                    }

              

                    List<EIngresoDetalle> lstIGD = new List<EIngresoDetalle>();
                    lstIGD = BIngreso_Detalle.AL_IngresoDetalle_qry03(objID);

                    dgDetalle.DataSource = lstIGD;
     
                 

                }

                catch (Exception ex)
                {
                    ex.ToString();
                }
                mCalcula1();
                mCalcula2();
            }
            else
            {
                MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nuevo();
                validacionNuevo();

            }


        }

       
      
        private void txtidVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsObserv.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AnularDetalleIngreso()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Anular?", "Anulado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    
                    EIngresoDetalle objID = new EIngresoDetalle();

                    if (txtidIngreso.Text == "")
                    {
                        
                    }
                    else
                    {
                        
                    objID.IdIngreso = txtidIngreso.Text;

                    objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    var Nu_tf = dgvDetalle_.CurrentRow.Cells["nu_tf"].Value.ToString();
                    var Id_producto = dgvDetalle_.CurrentRow.Cells["iDProducto"].Value.ToString();

                    objID.Id_producto = Id_producto.ToString();
                    objID.Nu_tf = Nu_tf.ToString();
                    objID.Id_uupdarec = frmLogin.d.id.ToLower();

                    BIngreso_Detalle.AL_Ingreso_Detalle_mnt03(objID);
                    }

                    MessageBox.Show(txtidIngreso.Text, "Datos Anulados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {

                }

            }
        }

        private void txtBuscarIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                BuscarIngreso();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            validacionEditar();
            HabilitarTexto(tableLayoutPanel1);
            HabilitarTexto(tableLayoutPanel2);
            
            HabilitarTexto(tableLayoutPanel4);
            HabilitarTexto(tableLayoutPanel5);
            btnEditar.Enabled = true;

            btnentregapor.Enabled = true;
            btnNuevoRow.Enabled = true;
            btnEliminarRow.Enabled = true;
            btnGrabar.Enabled = true;
       
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            FrmVistaPreviaIngresoEtiqueta_rpt frm = new FrmVistaPreviaIngresoEtiqueta_rpt();

            
            frm.var_idIngreso = txtidIngreso.Text;
            frm.ShowDialog();
            //btnGrabar.Enabled = false;
        }

        public void ConsultarDetalle()
        {            

            dgvDetalle_.Rows.Clear();
            EIngresoDetalle objID = new EIngresoDetalle();

            objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
            objID.IdIngreso = txtidIngreso.Text;


            List<EIngresoDetalle> lstIG = new List<EIngresoDetalle>();
            lstIG = BIngreso_Detalle.AL_IngresoDetalle_qry01(objID);

            foreach (EIngresoDetalle _objID in lstIG)
            {
                string[] row =
                        
                                {    _objID.Nu_Item,
                                     _objID.Nu_tf,
                                     _objID.Nu_op,
                                     _objID.Id_mercado,
                                     _objID.Id_tipTela,
                                     _objID.Id_Tipo,
                                     _objID.Id_TipIngreso,
                                     _objID.Id_clipro,
                                     _objID.ds_clipro,
                                     _objID.Id_producto,
                                     _objID.ds_producto,
                                     _objID.Id_color,                                     
                                     _objID.ds_color,
                                     _objID.Qt_rollo.ToString(),
                                     _objID.Qt_peso_desp.ToString(),
                                     _objID.Qt_ancho.ToString(),
                                     _objID.Qt_densidad.ToString(),  
                                     _objID.id_Vendedor.ToString(),
                                     _objID.Ds_Vendedor.ToString(),
                                                        
                                };
                dgvDetalle_.Rows.Add(row);
            }

            /// Detalle de Ingreso

            List<EIngresoDetalle> lstIGD = new List<EIngresoDetalle>();
            lstIGD = BIngreso_Detalle.AL_IngresoDetalle_qry03(objID);

            dgDetalle.DataSource = lstIGD;

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
            nuevo();
        }
        public void validacionBuscar()
        {
            btnGrabar.Enabled = false;
            btnEditar.Enabled = true;
            btnVistaPrevia.Enabled = true;
            btnNuevo.Enabled = true;
        }

        public void validacionFrmIngreso()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnGrabar.Enabled = false;
            btnVistaPrevia.Enabled = false;

        }

      
      
    }
}
