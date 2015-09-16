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
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class Frmco_modaloc_qry : Form
    {
        public Frmco_modaloc_qry()
        {
            InitializeComponent();
            DataTable dt;
            dt = new DataTable("Tabla");

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            DataRow dr;

            dr = dt.NewRow();
            dr["Codigo"] = "P000003";
            dr[1] = "FAUCETT";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Codigo"] = "P000002";
            dr[1] = "BOCANEGRA";
            dt.Rows.Add(dr);

            this.cbop_pop.DataSource = dt;
            this.cbop_pop.ValueMember = "Codigo";
            this.cbop_pop.DisplayMember = "Descripcion";


            try
            {
                EUnidadNegocio UN = new EUnidadNegocio();
                UN.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                
                WebHelper.LoadListControl3(cbunidnego_pop, BUndNegocio.ObtenerDatoUN(UN));
                cbunidnego_pop.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnPedidoPor_Click(object sender, EventArgs e)
        {
            FrmProducto_qry frmp = new FrmProducto_qry();
            frmp.pasard += new FrmProducto_qry.pasar(ejecutarProd);
            frmp.ShowDialog();

            txtcant_pop.Text = "0.000";
            txtpu_pop.Text = "0.000";
            txtpordes_pop.Text = "0.000";
            txtdetalle_pop.Text = "";
            txtidProducto_pop.Focus();

        }
        public void ejecutarProd(EDetProducto prd)
        {
            txtidProducto_pop.Text=prd._Codigo;
            txtidPrese_pop.Text= prd._Pres;
            txtpresentacion.Text = prd._Presenta;
            txtdsProducto_pop.Text= prd._Producto;
            txtunid_pop.Text=prd._UM;
            txtpesobruto_pop.Text= prd._Peso_Bruto.ToString();
            txtidtg_pop.Text = prd._id_tipgstimp;
            txtdstg_pop.Text = prd._Tipgasto;

        }

        private void txtidProducto_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtidtg_pop.Focus();
            }
        }

        private void cbop_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcant_pop.Focus();
            }
        }

        private void txtcant_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }



                txtpu_pop.Focus();
            }
        }

        private void txtpordes_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                chkigv_pop.Focus();
               
            }
        }

        private void cbunidnego_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                EUnidadNegocio UN = new EUnidadNegocio();
                UN.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                UN.IdUNegocio = cbunidnego_pop.SelectedValue.ToString();            
                WebHelper.LoadListControl3(cbccosto_pop, BUndNegocio.ObtenerDatoCC(UN));
                cbccosto_pop.Focus();
            }
        }

        private void cbccosto_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ETipGasto tg = new ETipGasto();
                tg.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                tg.Id_unegocio = cbunidnego_pop.SelectedValue.ToString();
                tg.Id_ccosto = cbccosto_pop.SelectedValue.ToString();
                WebHelper.LoadListControl3(cbclase_pop, BTipGasto.ObtenerDatotg(tg));
                cbclase_pop.Focus();
            }
        }

        private void cbclase_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdetalle_pop.Focus();
            }

        }
 

        private void btntipogasto_Click(object sender, EventArgs e)
        {
            Frmco_tipogasto_qry frmp = new Frmco_tipogasto_qry();
            frmp.pasard += new Frmco_tipogasto_qry.pasar(ejecutarTGasto);
            frmp.ShowDialog();
            txtidProducto_pop.Focus();

        }

        public void ejecutarTGasto(ETipGasto tg)
        {
            txtidtg_pop.Text = tg.Id_tipogsto;
            txtdstg_pop.Text = tg.Ds_tipogsto;
        }

        public object FormParent { get; set; }

        private void Frmco_modaloc_qry_Load(object sender, EventArgs e)
        {
            btnPedidoPor.Focus();
        }

        private void txtpu_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtpordes_pop.Focus();
            }
        }

        private void txtpu_pop_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);

        }

        private void txtcant_pop_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

 
        private void txtpordes_pop_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);
            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }


        //public delegate void pasar(EDetProducto Detprod);
        //public event pasar pasard;
        //public static pasar pasard;
        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
            
            EDetProducto dprod = new EDetProducto();
            dprod._Nu_Correla = "";
            dprod._Codigo = txtidProducto_pop.Text;         
            dprod._Producto = txtdsProducto_pop.Text;
            dprod._Presenta = txtpresentacion.Text;
            dprod._UM = txtunid_pop.Text;
            dprod._OP = "P000003";//cbop_pop.SelectedValue.ToString();          
            dprod._Cant = Convert.ToDecimal(txtcant_pop.Text);
            dprod._PreUnit = Convert.ToDecimal(txtpu_pop.Text);
            dprod._nu_pordscto = Convert.ToDecimal(txtpordes_pop.Text);
          
            dprod._Dscto = Convert.ToDecimal("0.000");
            dprod._Igv = Convert.ToDecimal("0.000");
            dprod._subTotal = Convert.ToDecimal("0.000");
            dprod._id_Gasto = cbunidnego_pop.SelectedValue.ToString();
            dprod._C_Gasto = cbunidnego_pop.Text;
            dprod._idCosto = cbccosto_pop.SelectedValue.ToString();
            dprod._C_Costos = cbccosto_pop.Text;
            dprod._Tipgasto = txtidtg_pop.Text;
            dprod._dstg = txtdstg_pop.Text;
            dprod._clase = cbclase_pop.Text;
            dprod._igvActivo = chkigv_pop.Checked;
            dprod._idclase = cbclase_pop.SelectedValue.ToString();
            dprod._Pres = txtidPrese_pop.Text;
            dprod._detalle = txtdetalle_pop.Text; //descripcion en la grilla oculta
            dprod._PreNeto = Convert.ToDecimal("0.000");
            dprod._Peso_Bruto = Convert.ToDecimal("0.000");
            dprod._Lote = "1";



            if (txtdstg_pop.Text == "")
            {
                
                MessageBox.Show("Tipo de Gasto, No Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frmco_ordenCompra_mnt frmFormularioAnterior = (Frmco_ordenCompra_mnt)FormParent;
                frmFormularioAnterior.LlenarGrilla(dprod, this);
                this.Close();
            }
            
        }

        private void txtdsProducto_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtpresentacion.Focus();
            }
        }

        private void txtpresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtunid_pop.Focus();
            }
            
        }

      

        private void cbunidnego_pop_SelectionChangeCommitted(object sender, EventArgs e)
        {
           

            EUnidadNegocio UN = new EUnidadNegocio();
            UN.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            UN.IdUNegocio = cbunidnego_pop.SelectedValue.ToString();
            WebHelper.LoadListControl3(cbccosto_pop, BUndNegocio.ObtenerDatoCC(UN));
            cbccosto_pop.Focus();
        }

        string _descto;
        string _igv;
         string _subtotal;
        decimal _pesobruto = 0;
        decimal _preneto = 0;

        public void LLenarCampos(EDetProducto objProd)
        {
    
            txtidProducto_pop.Text = objProd._Codigo;
            txtdsProducto_pop.Text = objProd._Producto;
            txtpresentacion.Text = objProd._Presenta;
            txtunid_pop.Text = objProd._UM;
            cbop_pop.SelectedValue = objProd._OP.ToString();
       
            txtcant_pop.Text = objProd._Cant.ToString(); 
            txtpu_pop.Text = objProd._PreUnit.ToString();
            txtpordes_pop.Text = objProd._nu_pordscto.ToString();
            _descto = objProd._Dscto.ToString();
            _igv = objProd._Igv.ToString();
            _subtotal = objProd._subTotal.ToString();

           

            EUnidadNegocio eu = new EUnidadNegocio();

            eu.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            eu.IdUNegocio = objProd._id_Gasto.ToString();
            List<EUnidadNegocio> oListDato = BUndNegocio.MG_Unegocio_qry06(eu);

            if (oListDato.Count > 0)
            {
                string val = oListDato[0].Existe;

                if (val == "1")
                {
                    cbunidnego_pop.SelectedValue = objProd._id_Gasto.ToString();

                    WebHelper.LoadListControl3(cbccosto_pop, BUndNegocio.ObtenerDatoCC(eu));
                    cbccosto_pop.SelectedValue = objProd._idCosto;
                    cbccosto_pop.Text = objProd._C_Costos;


                    ETipGasto tg = new ETipGasto();
                    tg.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    tg.Id_unegocio = cbunidnego_pop.SelectedValue.ToString();
                    tg.Id_ccosto = cbccosto_pop.SelectedValue.ToString();
                    WebHelper.LoadListControl3(cbclase_pop, BTipGasto.ObtenerDatotg(tg));
                    cbclase_pop.SelectedValue = objProd._idclase;

                }
                else
                {
 
                }
            }

            txtidtg_pop.Text = objProd._Tipgasto;
            txtdstg_pop.Text = objProd._dstg;
           
            chkigv_pop.Checked = objProd._igvActivo;
           
            txtidPrese_pop.Text = objProd._Pres;
            txtdetalle_pop.Text = objProd._detalle;   //descripcion en la grilla oculta
            _preneto = objProd._PreNeto;
            txtpesobruto_pop.Text = objProd._Peso_Bruto.ToString();
          
        }

        private void btnModificar_pop_Click(object sender, EventArgs e)
        {

            try
            { 
             EDetProducto dprod = new EDetProducto();
       
            dprod._Codigo = txtidProducto_pop.Text;
            dprod._Producto = txtdsProducto_pop.Text;
            dprod._Presenta = txtpresentacion.Text;
            dprod._UM = txtunid_pop.Text;
            dprod._OP = "P000003";//cbop_pop.SelectedValue.ToString();
            dprod._Cant = Convert.ToDecimal(txtcant_pop.Text);
            dprod._PreUnit = Convert.ToDecimal(txtpu_pop.Text);
            dprod._nu_pordscto = Convert.ToDecimal(txtpordes_pop.Text);
            dprod._Dscto = Convert.ToDecimal("0.000");
            dprod._Igv = Convert.ToDecimal("0.000");
            dprod._subTotal = Convert.ToDecimal("0.000");
            dprod._id_Gasto = cbunidnego_pop.SelectedValue.ToString();
            dprod._C_Gasto = cbunidnego_pop.Text;
            dprod._idCosto = cbccosto_pop.SelectedValue.ToString();
            dprod._C_Costos = cbccosto_pop.Text;
            dprod._Tipgasto = txtidtg_pop.Text;
            dprod._dstg = txtdstg_pop.Text;
            dprod._clase = cbclase_pop.Text;
            dprod._igvActivo = chkigv_pop.Checked;
            dprod._idclase = cbclase_pop.SelectedValue.ToString();
            dprod._Pres = txtidPrese_pop.Text;
            dprod._detalle = txtdetalle_pop.Text; //descripcion en la grilla oculta
            dprod._PreNeto = Convert.ToDecimal("0.000");
            dprod._Peso_Bruto = Convert.ToDecimal("0.000");
            dprod._Lote = "1";



            if (txtdstg_pop.Text == "")
            {

                MessageBox.Show("Tipo de Gasto, No Existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Frmco_ordenCompra_mnt frmFormularioAnterior = (Frmco_ordenCompra_mnt)FormParent;
                frmFormularioAnterior.ModGuilla(dprod, this);

            }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
           this.Dispose();
        }

      

        private void cbccosto_pop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ETipGasto tg = new ETipGasto();
            tg.Id_empresa = wfChgEmpPer.datos.idEmpresa;
            tg.Id_unegocio = cbunidnego_pop.SelectedValue.ToString();
            tg.Id_ccosto = cbccosto_pop.SelectedValue.ToString();
            WebHelper.LoadListControl3(cbclase_pop, BTipGasto.ObtenerDatotg(tg));
            cbclase_pop.Focus();
        }

        private void txtidProducto_pop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmProducto_qry frmp = new FrmProducto_qry();
                frmp.pasard += new FrmProducto_qry.pasar(ejecutarProd);
                frmp.ShowDialog();

                txtidProducto_pop.Focus();
            }


        }

        private void chkigv_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbunidnego_pop.Focus();
            }
        }

        private void txtidtg_pop_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Frmco_tipogasto_qry frmp = new Frmco_tipogasto_qry();
                frmp.pasard += new Frmco_tipogasto_qry.pasar(ejecutarTGasto);
                frmp.ShowDialog();
                txtidProducto_pop.Focus();
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



                }


            }
        }



        private void txtidPrese_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtidProducto_pop.Text == "" || txtidPrese_pop.Text == "")
                {
                    MessageBox.Show("Falta ingresar un dato del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
 
          

                EDetProducto prod = new EDetProducto();
                prod._Codigo = txtidProducto_pop.Text;
                prod._Pres = txtidPrese_pop.Text;
                prod._Empresa = wfChgEmpPer.datos.idEmpresa;

                 EDetProducto productoGen = new EDetProducto();
                 productoGen = BProducto.mListarProductoDG(prod);

                 if (productoGen._Producto.ToString() != "" || productoGen._Codigo != "" )
                 {
                     if (productoGen._Pres.ToString() != "")
                     {
                         txtdsProducto_pop.Text = productoGen._Producto.ToString();
                         txtpresentacion.Text = productoGen._Presenta.ToString();
                         txtunid_pop.Text = productoGen._UM.ToString();
                         txtpesobruto_pop.Text = productoGen._Peso_Bruto.ToString();
                         txtidtg_pop.Text = productoGen._id_tipgstimp.ToString();
                         txtdstg_pop.Text = productoGen._dstg.ToString();

                         

                         txtcant_pop.Text = "0.000";
                         txtpu_pop.Text = "0.000";
                         txtpordes_pop.Text = "0.000";
                         txtidtg_pop.Focus();
                     }
                     else {
                         Limpiar(groupBox1);
                         MessageBox.Show("Falta ingresar la Presentación del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                     }
                     
                 }
                 else
                 {
                     Limpiar(groupBox1);
                     MessageBox.Show("Producto no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                 }
            }
            }

        }

        private void txtidtg_pop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ETipGasto etg = new ETipGasto();
                etg.Id_tipogsto = txtidtg_pop.Text;
                etg.Ds_tipogsto = "";
          

                ETipGasto TipGastoGen = new ETipGasto();
                TipGastoGen = BTipGasto.TipoGasto_qry02(etg);

                txtdstg_pop.Text = TipGastoGen.Ds_tipogsto.ToString();
                 
                if (TipGastoGen.Ds_tipogsto.ToString() != "")
                {
                    txtcant_pop.Focus();
                   
                }
                else
                {
                    MessageBox.Show("Producto no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }



        }

     
       
    }
}
