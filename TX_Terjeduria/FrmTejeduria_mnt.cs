using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.BOQry.TJ;
using Texfina.Core.Utility;
using Texfina.Core.Web;
using Texfina.DOQry.Sy;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;
using Texfina.Entity.TJ;


namespace TX_Terjeduria
{
    public partial class FrmTejeduria_mnt : Form
    {
        public FrmTejeduria_mnt()
        {
            InitializeComponent();


            DataGridViewComboBoxColumn comboboxolumn = dgProcesos.Columns["idRutaProces"] as DataGridViewComboBoxColumn;
            //WebHelper.LoadListControl3(comboboxolumn, BGeneral.ObtenerDatoLocal());
            comboboxolumn.DataSource = BTejeduriaDetProces.ObtenerDatoProces();
            comboboxolumn.DisplayMember = "desc";
            comboboxolumn.ValueMember = "id";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Permisos();

            WebHelper.LoadListControl3(cb_Mercado, BGeneral.ObtenerDatoidTabla("104"));
            cb_Mercado.SelectedIndex = -1;
            WebHelper.LoadListControl3(cb_Destino, BGeneral.ObtenerDatoidTabla("142"));
            cb_Destino.SelectedIndex = -1;
            WebHelper.LoadListControl3(cb_InfTecCrudo_ancho, BGeneral.ObtenerDatoidTabla("140"));
            cb_InfTecCrudo_ancho.SelectedIndex = -1;

        }


        private void Permisos()
        {
            try
            {

                string Usu = frmLogin.d.idUser;
                string menu = "01";
                string ifFormulario = "0002";



                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = Usu;
                u.IdModulo = menu;
                u.Id_formulario = ifFormulario;

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
                btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);
               
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            try
            {

                frmModalDetalle frmps = new frmModalDetalle();
                frmps.FormParent = this;
                frmps.EstadoDet = 1;
                //frmps.pasard += new Frmco_modaloc_qry.pasar(ejecutarproducto);
                frmps.ShowDialog();
                //txtIdPedido.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            
        }


      
        //private void NuevoItem2()
        //{
        //    List<ETejeduria_DetProces> lstFact = new List<ETejeduria_DetProces>();

        //    ETejeduria_DetProces lstTJ = new ETejeduria_DetProces();

        //    //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
        //    string str = Convert.ToString(dgProcesos.Rows.Count + 1);

           
        //        // Añande el primer item en blando de la grilla
        //        lstTJ.IdItem = "001";
        //        lstTJ.IdRutaProces = "001";
      
        //        //Muestra la grilla con un fila en blanco 

        //        dgProcesos.DataSource = lstFact;

        //        //dgProducto.DataBind();

        //}


        public string st_NewItem;
        private void Nuevo()
        {
            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox2);
            HabilitarTexto(groupBox3);
            HabilitarTexto(groupBox4);
            HabilitarTexto(groupBox5);
            HabilitarTexto(groupBox8);
         

            txt_idTejido.Text = "";
            txt_nuFicha.Text = "";
          
            Limpiar(groupBox1);
            Limpiar(groupBox2);
            Limpiar(groupBox3);
            Limpiar(groupBox4);
            Limpiar(groupBox5);
            Limpiar(groupBox8);


            //cb_Mercado.SelectedIndex = -1;
            //cb_Destino.SelectedIndex = -1;
            cb_InfTecCrudo_ancho.SelectedIndex = -1;

            txt_infTecCruda_cant.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecCrudo_densidad.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecCrudo_rendim.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecAcab_desnsi.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecAcab_rendim.Text = string.Format("{0:##,##0.0000}", 0);
            txt_encogi_largo.Text = string.Format("{0:##,##0.0000}", 0);
            txt_encog_ancho.Text = string.Format("{0:##,##0.0000}", 0);
            txt_rev_porc.Text = string.Format("{0:##,##0.0000}", 0);
            txt_infTecCruda_cant.Text = string.Format("{0:##,##0.0000}", 0);
            txt_merma_porc.Text = string.Format("{0:##,##0.0000}", 0);

            
            txt_costo_teñido.Text = string.Format("{0:##,##0.0000}", 0);
            txtdiam.Text = string.Format("{0:##,##0.0000}", 0);
            txtgalga.Text = string.Format("{0}", 0);
            txtsistTrab.Text = string.Format("{0}", 0);
            txtsistAnul.Text = string.Format("{0}", 0);
            txt_merma_porc.Text = string.Format("{0:##,##0.0000}", 0);
            txtrpm.Text = string.Format("{0}", 0);
            txtpeso.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecAcab_ancho.Text = string.Format("{0:##,##0.0000}", 0);

            txtReqAcabAnch.Text = string.Format("{0:##,##0.0000}", 0);
            txtReqAcabDens.Text = string.Format("{0:##,##0.0000}", 0);
            txtPlatina.Text = string.Format("{0:##,##0.0000}", 0);

            txt_nuMuestra.Text = string.Format("{0000000000}", 0);
            txt_Nu_GT.Text = string.Format("{0000000000}", 0);
            txt_Nu_Regulacion.Text = string.Format("{0000000000}", 0);
            lblColor.Text = "";

            txtIdColor.Text = txtIdColor.Text.PadLeft(9, '0');

            //---------------------------------------------------------------------
            EColor per = new EColor();
            per.psintypesel = 1;
            per.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            per.Id_color = "000000000";
            per.Ds_color = "";

            List<Dato> oListDato = BColor.ObtenerDatoColor(per);

            if (oListDato.Count > 0)
            {
                lblColor.Text = oListDato[0].desc;

                txt_costo_teñido.SelectionStart = 0;
                txt_costo_teñido.SelectionLength = txt_costo_teñido.Text.Length;
                txt_costo_teñido.Focus();
            }
           //------------------------------------------------------------------------------------------------------------
            this.ActiveControl = txt_idTejido;
            txt_idTejido.Focus();

            btnBuscTejido.Enabled = true;
            btn_cliente.Enabled = true;
            btnBusColor.Enabled = true;

            txtBuscarFicha.Clear();
            txtBuscarnuTF.Clear();
            txtBuscarTejido.Clear();
            txtBuscarTfRef.Clear();
          
            
            dgDetalle.Rows.Clear();
            dgTJLM.Rows.Clear();
            dgProcesos.Rows.Clear();
            dgTempDetProc.Rows.Clear();
            
            

         
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


                    this.txt_idTejido.Focus();

                }
            }

            lbl_dsCliente.Text = "";
            lbl_dsTejido.Text = "";
        }

    

        private void txt_infTecCruda_cant_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }





        private void txt_InfTecCrudo_densidad_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_InfTecCrudo_rendim_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_InfTecAcab_ancho_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_InfTecAcab_desnsi_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_InfTecAcab_rendim_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_encogi_largo_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_encog_ancho_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_rev_porc_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txt_merma_porc_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

       

        private void txt_costo_teñido_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtdiam_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtgalga_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void txtsistTrab_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void txtpeso_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            frmcoproveedor_qry frmp = new frmcoproveedor_qry();
            frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
            frmp.ShowDialog();
            txt_IdCli.Focus();
        }

        public void ejecutarProv(EProveedor prov)
        {
            txt_IdCli.Text = prov.Id_clipro;
            lbl_dsCliente.Text = prov.Ds_raznombre;
        }

        private void txt_idTejido_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_IdCli.SelectionStart = 0;
                txt_IdCli.SelectionLength = txt_IdCli.Text.Length;

                txt_IdCli.Focus();
            }
        }

        private void txt_IdCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_IdCli.Text = txt_IdCli.Text.PadLeft(6, '0');

                EProveedor per = new EProveedor();
                per.psintypesel = 1;
                per.Ds_raznombre = "";
                per.Id_clipro = txt_IdCli.Text;
                per.Nu_ruc = "";
                per.Id_empresa = wfChgEmpPer.datos.idEmpresa;



                List<Dato> oListDato = BProveedor.ObtenerDatoProveedor(per);
                if (oListDato.Count > 0)
                {
                    lbl_dsCliente.Text = oListDato[0].desc;

                    txt_nuMuestra.SelectionStart = 0;
                    txt_nuMuestra.SelectionLength = txt_nuMuestra.Text.Length;
                    txt_nuMuestra.Focus();

                }
                else
                {

                    MessageBox.Show("Codigo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdCli.Clear();
                    lbl_dsCliente.Text = "";
                   
                    txt_IdCli.Focus();

                }

            }
        }

        private void txt_nuMuestra_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_nuMuestra.Text = txt_nuMuestra.Text.PadLeft(10, '0');

                txt_nuTf.SelectionStart = 0;
                txt_nuTf.SelectionLength = txt_nuTf.Text.Length;

                txt_nuTf.Focus();
            }
        }

        private void txt_nuTf_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_Nu_GT.SelectionStart = 0;
                txt_Nu_GT.SelectionLength = txt_Nu_GT.Text.Length;

                txt_Nu_GT.Focus();
            }
        }

        private void txt_Nu_GT_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_Nu_GT.Text = txt_Nu_GT.Text.PadLeft(10, '0');
                txt_nu_tfref.SelectionStart = 0;
                txt_nu_tfref.SelectionLength = txt_nu_tfref.Text.Length;
                txt_nu_tfref.Focus();
            }
        }

        private void txt_nu_tfref_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_idMercado.Focus();
            }

        }

        private void txt_idMercado_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_idMercado.Text = txt_idMercado.Text.PadLeft(3, '0');
                cb_Mercado.SelectedValue = txt_idMercado.Text;

                if (cb_Mercado.Text == "")
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_idMercado.Clear();
                    txt_idMercado.Focus();
                }
                else
                { 
               
                txt_Nu_Regulacion.SelectionStart = 0;
                txt_Nu_Regulacion.SelectionLength = txt_Nu_Regulacion.Text.Length;
                txt_Nu_Regulacion.Focus();
                }
                
            

            }
        }

        private void txt_Nu_Regulacion_KeyPress(object sender, KeyPressEventArgs e)
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
        
                    txt_Nu_Regulacion.Text = txt_Nu_Regulacion.Text.PadLeft(10, '0');
                    txt_IdDestino.SelectionStart = 0;
                    txt_IdDestino.SelectionLength = txt_IdDestino.Text.Length;
                    txt_IdDestino.Focus();
                
            }
        }

        private void txt_IdDistrito_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_IdDestino.Text = txt_IdDestino.Text.PadLeft(3, '0');
                cb_Destino.SelectedValue = txt_IdDestino.Text;

                if (cb_Destino.Text == "")
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_IdDestino.Clear();
                    txt_IdDestino.Focus();
                }
                else
                {
                   
                    txt_InfTecCrudo_idancho.SelectionStart = 0;
                    txt_InfTecCrudo_idancho.SelectionLength = txt_InfTecCrudo_idancho.Text.Length;
                    txt_InfTecCrudo_idancho.Focus();
                }
       

            }
        }

        private void txt_InfTecCrudo_idancho_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_InfTecCrudo_idancho.Text = txt_InfTecCrudo_idancho.Text.PadLeft(3, '0');
                cb_InfTecCrudo_ancho.SelectedValue = txt_InfTecCrudo_idancho.Text;

                if (cb_InfTecCrudo_ancho.Text == "")
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_InfTecCrudo_idancho.Clear();
                    txt_InfTecCrudo_idancho.Focus();
                }
                else
                {
                   
                  


                    txt_infTecCruda_cant.SelectionStart = 0;
                    txt_infTecCruda_cant.SelectionLength = txt_infTecCruda_cant.Text.Length;
                    txt_infTecCruda_cant.Focus();
                }
            }
        }

        private void txt_infTecCruda_cant_KeyPress(object sender, KeyPressEventArgs e)
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


                txt_InfTecCrudo_densidad.SelectionStart = 0;
                txt_InfTecCrudo_densidad.SelectionLength = txt_InfTecCrudo_densidad.Text.Length;
                txt_InfTecCrudo_densidad.Focus();
            }
        }

        private void txt_InfTecCrudo_densidad_KeyPress(object sender, KeyPressEventArgs e)
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

                txt_InfTecCrudo_rendim.SelectionStart = 0;
                txt_InfTecCrudo_rendim.SelectionLength = txt_InfTecCrudo_rendim.Text.Length;

                txt_InfTecCrudo_rendim.Focus();
            }
        }

        private void txt_InfTecCrudo_rendim_KeyPress(object sender, KeyPressEventArgs e)
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
                txtReqAcabAnch.SelectionStart = 0;
                txtReqAcabAnch.SelectionLength = txtReqAcabAnch.Text.Length;
                txtReqAcabAnch.Focus();
            }
        }

        private void txt_InfTecAcab_ancho_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_InfTecAcab_desnsi.SelectionStart = 0;
                txt_InfTecAcab_desnsi.SelectionLength = txt_InfTecAcab_desnsi.Text.Length;
                txt_InfTecAcab_desnsi.Focus();
            }
        }

        private void txt_InfTecAcab_desnsi_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_InfTecAcab_rendim.SelectionStart = 0;
                txt_InfTecAcab_rendim.SelectionLength = txt_InfTecAcab_rendim.Text.Length;
                txt_InfTecAcab_rendim.Focus();
            }
        }

        private void txt_InfTecAcab_rendim_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_maq_teñido.SelectionStart = 0;
                txt_maq_teñido.SelectionLength = txt_maq_teñido.Text.Length;
                txt_maq_teñido.Focus();
            }
        }

        private void txt_maq_teñido_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_encogi_largo.SelectionStart = 0;
                txt_encogi_largo.SelectionLength = txt_encogi_largo.Text.Length;
                txt_encogi_largo.Focus();
            }
        }

        private void txt_encog_ancho_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_observ.SelectionStart = 0;
                txt_observ.SelectionLength = txt_observ.Text.Length;
                txt_observ.Focus();
            }
        }

        private void txt_observ_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_rev_porc.SelectionStart = 0;
                txt_rev_porc.SelectionLength = txt_rev_porc.Text.Length;
                txt_rev_porc.Focus();
            }
        }

        private void txt_rev_porc_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_merma_porc.SelectionStart = 0;
                txt_merma_porc.SelectionLength = txt_merma_porc.Text.Length;
                txt_merma_porc.Focus();
            }
        }

        private void txt_merma_porc_KeyPress(object sender, KeyPressEventArgs e)
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
                txtIdColor.SelectionStart = 0;
                txtIdColor.SelectionLength = txtIdColor.Text.Length;
                txtIdColor.Focus();
            }
        }

        private void txt_rev_grados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMaquina_KeyPress(object sender, KeyPressEventArgs e)
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
                txtdiam.SelectionStart = 0;
                txtdiam.SelectionLength = txtdiam.Text.Length;
                txtdiam.Focus();
            }
        }

        private void txtdiam_KeyPress(object sender, KeyPressEventArgs e)
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
                txtPlatina.SelectionStart = 0;
                txtPlatina.SelectionLength = txtPlatina.Text.Length;
                txtPlatina.Focus();
            }
        }

        private void txtgalga_KeyPress(object sender, KeyPressEventArgs e)
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
                txtsistTrab.SelectionStart = 0;
                txtsistTrab.SelectionLength = txtsistTrab.Text.Length;
                txtsistTrab.Focus();
            }
        }

        private void txtsistTrab_KeyPress(object sender, KeyPressEventArgs e)
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
                txtsistAnul.SelectionStart = 0;
                txtsistAnul.SelectionLength = txtsistAnul.Text.Length;
                txtsistAnul.Focus();
            }
        }

        private void txtsistAnul_KeyPress(object sender, KeyPressEventArgs e)
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
                txtrpm.SelectionStart = 0;
                txtrpm.SelectionLength = txtrpm.Text.Length;
                txtrpm.Focus();
            }
        }

        private void txtrpm_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDs_obstejido.SelectionStart = 0;
                txtDs_obstejido.SelectionLength = txtDs_obstejido.Text.Length;
                txtDs_obstejido.Focus();
               
            }
        }

      
        private void txt_encogi_largo_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_encog_ancho.SelectionStart = 0;
                txt_encog_ancho.SelectionLength = txt_encog_ancho.Text.Length;
                txt_encog_ancho.Focus();
            }
        }

        private void cb_Mercado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_idMercado.Text = Convert.ToString(cb_Mercado.SelectedValue);
        }

        private void cb_Distrito_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_IdDestino.Text = Convert.ToString(cb_Destino.SelectedValue);
        }

        private void cb_InfTecCrudo_ancho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_InfTecCrudo_idancho.Text = Convert.ToString(cb_InfTecCrudo_ancho.SelectedValue);
        }

        private void txt_InfTecAcab_rendim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscTejido_Click(object sender, EventArgs e)
        {



            FrmTejido_qry frmp = new FrmTejido_qry();
            frmp.pasard += new FrmTejido_qry.pasar(ejecutarTejido);
            frmp.ShowDialog();
            txt_IdCli.Focus();
        }

        public void ejecutarTejido(EDetProducto prod)
        {
            txt_idTejido.Text = prod._Codigo;
            lbl_dsTejido.Text = prod._Producto;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrnTejeduria_qry frmoc = new FrnTejeduria_qry();
            frmoc.pasard += new FrnTejeduria_qry.pasar(EjecutarTejeduria);
            frmoc.ShowDialog();

        }


        public void EjecutarTejeduria(ETejeduria TJ)
        {
            Nuevo();

            txtBuscarTejido.Text = TJ.Id_producto;
            txtBuscarFicha.Text = TJ.Nu_correficha;
            txtBuscarnuTF.Text = TJ.Nu_tf;
            txtBuscarTfRef.Text = TJ.Nu_tfref;

           
            BuscarTejeduria();
            txtBuscarTejido.Focus();
        }



        private void BuscarTejeduria()
        {


            ETejeduria oT = new ETejeduria();

            //oT.IdPeriodo = "2014";
            oT.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 
            oT.Id_producto = txtBuscarTejido.Text;
            oT.Nu_correficha = txtBuscarFicha.Text;


            List<ETejeduria> oListDato = BTejeduria.TJ_Tejeduria_qry06(oT);


            string val = oListDato[0].existe;

            if (val == "0")
            {

                try
                {

                    dgDetalle.Rows.Clear();
                    dgTJLM.Rows.Clear();
                    dgTempDet.Rows.Clear();
                    dgProcesos.Rows.Clear();
                    dgTempDetProc.Rows.Clear();
                    ETejeduria oTJ = new ETejeduria();

                    //oTJ.IdPeriodo = "2014";
                    oTJ.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 

                    oTJ.Id_producto = txtBuscarTejido.Text;
                    oTJ.Nu_correficha = txtBuscarFicha.Text;
                    oTJ.Nu_tf = txtBuscarnuTF.Text;
                    oTJ.Nu_tfref = txtBuscarTfRef.Text;
        


              
                    ETejeduria oBtieneTJ = new ETejeduria();
                    oBtieneTJ = BTejeduria.TJ_Tejeduria_qry07(oTJ);

                    txt_idTejido.Text = oBtieneTJ.Id_producto.ToString().Trim();
                    txt_nuFicha.Text = oBtieneTJ.Nu_correficha.ToString().Trim();
                    lbl_dsTejido.Text = oBtieneTJ.ds_producto.ToString().Trim();

                    txt_fecha.Text =  oBtieneTJ.Fe_registro.ToString();
                    txt_IdCli.Text = oBtieneTJ.Id_clipro.ToString().Trim();
                    lbl_dsCliente.Text = oBtieneTJ.ds_razonSoc.ToString().Trim();
                    txt_nuMuestra.Text = oBtieneTJ.Nu_refmuestra.ToString().Trim();
                    txt_nuTf.Text = oBtieneTJ.Nu_tf.ToString().Trim();
                    txt_Nu_GT.Text = oBtieneTJ.Nu_gt.ToString();
                    txt_nu_tfref.Text = oBtieneTJ.Nu_tfref.ToString().Trim();
                    txt_idMercado.Text = oBtieneTJ.Id_vtipmcdo.ToString().Trim();
                    cb_Mercado.SelectedValue = txt_idMercado.Text;
                    txt_Nu_Regulacion.Text = oBtieneTJ.Nu_regula.ToString().Trim();
                    txt_IdDestino.Text = oBtieneTJ.Id_vdestino.ToString().Trim();
                    cb_Destino.SelectedValue = txt_IdDestino.Text;
                    txt_InfTecCrudo_idancho.Text = oBtieneTJ.Id_vtipancru.ToString().Trim();
                    cb_InfTecCrudo_ancho.SelectedValue = txt_InfTecCrudo_idancho.Text;

                    txt_infTecCruda_cant.Text = oBtieneTJ.Qt_anchcrudo.ToString().Trim();
                    txt_InfTecCrudo_densidad.Text = oBtieneTJ.Qt_denscrudo.ToString().Trim();
                    txt_InfTecCrudo_rendim.Text = oBtieneTJ.Qt_rendcrudo.ToString().Trim();


                    txt_InfTecAcab_ancho.Text = oBtieneTJ.Qt_anchacaba.ToString().Trim();
                    txt_InfTecAcab_desnsi.Text = oBtieneTJ.Qt_densacaba.ToString().Trim();
                    txt_InfTecAcab_rendim.Text = oBtieneTJ.Qt_rendacaba.ToString().Trim();

                    txt_maq_teñido.Text = oBtieneTJ.Id_maqtenido.ToString().Trim();
                    txt_encogi_largo.Text = oBtieneTJ.Nu_porencla.ToString().Trim();
                    txt_encog_ancho.Text = oBtieneTJ.Nu_porencan.ToString().Trim();
                    txt_rev_porc.Text = oBtieneTJ.Nu_porrev.ToString().Trim();
                    txt_merma_porc.Text = oBtieneTJ.Nu_pormerma.ToString().Trim();


                    txt_costo_teñido.Text = oBtieneTJ.Mt_costtenido.ToString().Trim();
                    txtMaquina.Text = oBtieneTJ.Id_ptmaq.ToString().Trim();
                    txtdiam.Text = oBtieneTJ.Nu_ptdiame.ToString();
                    txtpeso.Text = oBtieneTJ.Qt_ptpeso.ToString();
                    txtgalga.Text = oBtieneTJ.Nu_ptgalga.ToString();
                    txtsistTrab.Text = oBtieneTJ.Nu_ptsistrab.ToString();
                    txtsistAnul.Text = oBtieneTJ.Nu_ptsisanul.ToString();
                    txtrpm.Text = oBtieneTJ.Nu_ptrpm.ToString();

                    txtReqAcabAnch.Text = oBtieneTJ.qt_anchdatreqacaba.ToString();
                    txtReqAcabDens.Text = oBtieneTJ.qt_densdatreqacaba.ToString();

                    txtPlatina.Text = oBtieneTJ.nu_platina.ToString();
                    txtIdColor.Text = oBtieneTJ.Id_Color.ToString();
                    lblColor.Text = oBtieneTJ.ds_Color.ToString();
                    txt_observ.Text = oBtieneTJ.Ds_observa.ToString();
                    txtDs_obstejido.Text = oBtieneTJ.Ds_obstejido.ToString();
                    txtDs_evadeftj.Text = oBtieneTJ.Ds_evadeftj.ToString();

                    ///detalle de tejeduria

                    ETejeduriaDet oTJD = new ETejeduriaDet();


                    //oTJD.IdPeriodo = "2014";
                    oTJD.IdEmpresa = wfChgEmpPer.datos.idEmpresa; ;

                    oTJD.Id_producto = txtBuscarTejido.Text;
                    oTJD.Nu_correficha = txtBuscarFicha.Text;


                    List<ETejeduriaDet> lstoc = new List<ETejeduriaDet>();
                    lstoc = BTejeduriaDet.mListarTejeduriaDet(oTJD);

                    foreach (ETejeduriaDet objTJD in lstoc)
                    {
                        string[] row =
                        
                                {    objTJD.Nu_secuen.ToString(),
                                     objTJD.Id_numalim.ToString(),
                                     objTJD.Ds_distrib,
                                     objTJD.Ds_estruct,
                                     objTJD.Id_prodhilo,
                                     objTJD.ds_prodhilo,
                                     objTJD.Ds_tipfibra,
                                     objTJD.Ds_carachilo,
                                     objTJD.Ds_titulo,
                                     objTJD.Id_vlustre,
                                     
                                     objTJD.ds_lustre,
                                     objTJD.Nu_torsion,
                                     objTJD.Id_clipro,
                                     objTJD.ds_razsoc,
                                     objTJD.Nu_lote,
                                     objTJD.Ds_etiqueta,

                                     objTJD.Nu_porhilo.ToString(),
                                     objTJD.Nu_porhiloaca.ToString(),

                                     objTJD.Nu_tension.ToString(),
                                     objTJD.Nu_bobinas.ToString(),
                                     objTJD.Nu_alimenta.ToString(),
                                     objTJD.Mt_preuni.ToString(),
                                     objTJD.Mt_subtotcon.ToString(),
                                                        
                                };
                        dgDetalle.Rows.Add(row);
                       


                   
                    }

                    /// detalle de procesos de tejeduria
                   

                     ETejeduria_DetProces oTJDP = new ETejeduria_DetProces();


                     //oTJDP.IdPeriodo = "2014";
                     oTJDP.IdEmpresa = wfChgEmpPer.datos.idEmpresa; ;

                     oTJDP.Id_producto = txtBuscarTejido.Text;
                     oTJDP.Nu_correficha = txtBuscarFicha.Text;


                    //List<ETejeduria_DetProces> lsTJP = new List<ETejeduria_DetProces>();

                     List<ETejeduria_DetProces> lstTJP = new List<ETejeduria_DetProces>();
                     lstTJP = BTejeduriaDetProces.mListarTejeduriaDetProces(oTJDP);

                     foreach (ETejeduria_DetProces objTJDP in lstTJP)
                    {
                        string[] row =
                        
                                {    objTJDP.IdItem.ToString(),                                  
                                     objTJDP.IdRutaProces.ToString(),
                                };
                        dgProcesos.Rows.Add(row);
                    }

                    //dgProcesos.DataSource = BTejeduriaDetProces.mListarTejeduriaDetProces(oTJDP);
                    
                    /// Detalle de longitud malla



                    ETejeduria_DetMall oTJDM = new ETejeduria_DetMall();


                    //oTJDM.IdPeriodo = "2014";
                    oTJDM.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 

                    oTJDM.Id_producto =txt_idTejido.Text;
                    oTJDM.Nu_correficha =txt_nuFicha.Text;
          
                    //dgTJLM.DataSource = BTejeduriaDetMall.mListarTejeduriaDetMall(oTJDM);

                    List<ETejeduria_DetMall> lstTJ = new List<ETejeduria_DetMall>();
                    lstTJ = BTejeduriaDetMall.mListarTejeduriaDetMall(oTJDM);

                    foreach (ETejeduria_DetMall objTJDM in lstTJ)
                    {
                        string[] row =
                        
                                {    objTJDM.Nu_secuen.ToString(),
                                     objTJDM.Nu_item.ToString(),
                                     objTJDM.Nu_longmalla.ToString(),
                                     objTJDM.St_anulado.ToString(),
                                                        
                                };
                        dgTJLM.Rows.Add(row);

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

        string _drow;
       
       
        private void dgDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dRow = dgDetalle.Rows[e.RowIndex];
                _drow = dRow.Index.ToString();

           
                ETejeduriaDet objTJ = new ETejeduriaDet();


                objTJ.Id_producto = txt_idTejido.Text;
                objTJ.Nu_correficha = txt_nuFicha.Text;

                objTJ.Nu_secuen = (dRow.Cells["_nu_secuen"].Value == null) ? "" : dRow.Cells["_nu_secuen"].Value.ToString();
                objTJ.Id_numalim = (dRow.Cells["Alim"].Value == null) ? "" : dRow.Cells["Alim"].Value.ToString();
                objTJ.Ds_distrib = (dRow.Cells["Distribucion"].Value == null) ? "" : dRow.Cells["Distribucion"].Value.ToString();
                objTJ.Ds_estruct = (dRow.Cells["estructura"].Value == null) ? "" : dRow.Cells["estructura"].Value.ToString();
                objTJ.Id_prodhilo = (dRow.Cells["idHilo"].Value == null) ? "" : dRow.Cells["idHilo"].Value.ToString();

                objTJ.ds_prodhilo = (dRow.Cells["Hilo"].Value == null) ? "" : dRow.Cells["Hilo"].Value.ToString();
                objTJ.Ds_tipfibra = (dRow.Cells["tipo_fibra"].Value == null) ?  "" : dRow.Cells["tipo_fibra"].Value.ToString();
                objTJ.Ds_carachilo = (dRow.Cells["carac_hilo"].Value == null) ? "" : dRow.Cells["carac_hilo"].Value.ToString();
                objTJ.Ds_titulo = (dRow.Cells["titulo"].Value == null) ? "" : dRow.Cells["titulo"].Value.ToString();
                objTJ.Id_vlustre = (dRow.Cells["idLustre"].Value == null) ?  "" : dRow.Cells["idLustre"].Value.ToString();
                objTJ.ds_lustre = (dRow.Cells["lustre"].Value == null) ? "" : dRow.Cells["lustre"].Value.ToString();
                objTJ.Nu_torsion = (dRow.Cells["Nu_torsion"].Value == null) ? "" : dRow.Cells["Nu_torsion"].Value.ToString();
                objTJ.Id_clipro = (dRow.Cells["idProv"].Value == null) ? "" : dRow.Cells["idProv"].Value.ToString();
                objTJ.ds_razsoc = (dRow.Cells["proveedor"].Value == null) ? "" : dRow.Cells["proveedor"].Value.ToString();
                objTJ.Nu_lote = (dRow.Cells["Lote"].Value == null) ? "" : dRow.Cells["Lote"].Value.ToString();
                objTJ.Ds_etiqueta = (dRow.Cells["etiqueta"].Value == null) ? "" : dRow.Cells["etiqueta"].Value.ToString();
                objTJ.Nu_porhilo = (dRow.Cells["porHiloCrudo"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["porHiloCrudo"].Value.ToString());
                objTJ.Nu_porhiloaca = (dRow.Cells["porHiloAcab"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["porHiloAcab"].Value.ToString());
            
                objTJ.Nu_tension = (dRow.Cells["nu_tension"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["nu_tension"].Value.ToString());
                objTJ.Nu_bobinas = (dRow.Cells["nu_bobinas"].Value == null) ? 0  : Convert.ToInt16(dRow.Cells["nu_bobinas"].Value.ToString());
                objTJ.Nu_alimenta = (dRow.Cells["nu_aliment"].Value == null) ? 0  : Convert.ToInt16(dRow.Cells["nu_aliment"].Value.ToString());
                objTJ.Mt_preuni = (dRow.Cells["pre_uni"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["pre_uni"].Value.ToString());

                objTJ.Mt_subtotcon = (dRow.Cells["Sub_total"].Value == null) ? 0 : Convert.ToDecimal(dRow.Cells["Sub_total"].Value.ToString());

             

                ///
                frmModalDetalle frmpop = new frmModalDetalle();
                frmpop.FormParent = this;
                frmpop.EstadoDet = 2;


                frmpop.LLenarCampos(objTJ);


                /// DETALLE DE LONGITUD MALLA


                ETejeduria_DetMall objLM = new ETejeduria_DetMall();
                //DataGridViewRow dRow2 = dgTJLM.Rows[e.RowIndex];



                for (int i = 0; dgTJLM.Rows.Count > i; i++)
                {
                    var nu_secuen = dgTJLM.Rows[i].Cells["nu_secuen"].Value;
                    var nu_item = dgTJLM.Rows[i].Cells["nu_item"].Value;
                    var nu_longmalla = dgTJLM.Rows[i].Cells["nu_longmalla"].Value;
                    var st_anulado = dgTJLM.Rows[i].Cells["_st_anulado"].Value;
                    if (nu_secuen.ToString() == objTJ.Nu_secuen.ToString() & st_anulado.ToString()=="0")
                    {
                        objLM.Nu_secuen = nu_secuen.ToString();
                        objLM.Nu_item = nu_item.ToString();
                        objLM.Nu_longmalla = Convert.ToDecimal(nu_longmalla);
                        objLM.St_anulado = st_anulado.ToString();
                        frmpop.LlenarGrillaLM2(objLM, this);
                    }
                }

                frmpop.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ModGuilla(ETejeduriaDet objTJ, object form)
        {

            (dgDetalle.Rows[int.Parse(_drow)].Cells["Alim"]).Value = objTJ.Id_numalim.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["Distribucion"]).Value = objTJ.Ds_distrib.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["estructura"]).Value = objTJ.Ds_estruct.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["idHilo"]).Value = objTJ.Id_prodhilo.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["Hilo"]).Value = objTJ.ds_prodhilo.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["tipo_fibra"]).Value = objTJ.Ds_tipfibra.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["carac_hilo"]).Value = objTJ.Ds_carachilo.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["titulo"]).Value = objTJ.Ds_titulo.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["idLustre"]).Value = objTJ.Id_vlustre.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["lustre"]).Value = objTJ.ds_lustre.ToString();

            (dgDetalle.Rows[int.Parse(_drow)].Cells["nu_torsion"]).Value = objTJ.Nu_torsion.ToString();

            (dgDetalle.Rows[int.Parse(_drow)].Cells["idProv"]).Value = objTJ.Id_clipro.Trim().ToString();

            (dgDetalle.Rows[int.Parse(_drow)].Cells["proveedor"]).Value = objTJ.ds_razsoc.Trim().ToString();

            (dgDetalle.Rows[int.Parse(_drow)].Cells["Lote"]).Value = objTJ.Nu_lote.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["etiqueta"]).Value = objTJ.Ds_etiqueta.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["porHiloCrudo"]).Value = objTJ.Nu_porhilo.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["porHiloAcab"]).Value = objTJ.Nu_porhiloaca.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["nu_tension"]).Value = objTJ.Nu_tension.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["nu_bobinas"]).Value = objTJ.Nu_bobinas.ToString();

            (dgDetalle.Rows[int.Parse(_drow)].Cells["nu_aliment"]).Value = objTJ.Nu_alimenta.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["pre_uni"]).Value = objTJ.Mt_preuni.ToString();
            (dgDetalle.Rows[int.Parse(_drow)].Cells["Sub_total"]).Value = objTJ.Mt_subtotcon.ToString();

            frmModalDetalle frmPopup = (frmModalDetalle)form;
            frmPopup.EstadoDet = 2;
            frmPopup.Close();


        }




        public void ElimiItemMall(ETejeduria_DetMall objTJM, object form)
        {


            string str = Convert.ToString(dgTJLM.Rows.Count + 1);

            for (int i = 0; dgTJLM.Rows.Count > i; i++)
            {
                var nu_secu = dgTJLM.Rows[(i)].Cells["nu_secuen"].Value;
                var nu_Item = dgTJLM.Rows[(i)].Cells["nu_item"].Value;


                if (nu_secu.ToString() == objTJM.Nu_secuen.ToString() & nu_Item.ToString() == objTJM.Nu_item.ToString())
                {

                    (dgTJLM.Rows[(i)].Cells["nu_secuen"]).Value = objTJM.Nu_secuen.ToString();
                    (dgTJLM.Rows[(i)].Cells["nu_item"]).Value = objTJM.Nu_item.ToString();
                    (dgTJLM.Rows[(i)].Cells["nu_longmalla"]).Value = objTJM.Nu_longmalla.ToString();
                    (dgTJLM.Rows[(i)].Cells["_st_anulado"]).Value = objTJM.St_anulado.ToString();
                }

            }

        }

        public void AddMall(ETejeduria_DetMall objTJM, object form)
        {
            int count=0;
            for (int i = 0; dgTJLM.Rows.Count > i; i++)
            {
                var nu_secu = dgTJLM.Rows[(i)].Cells["nu_secuen"].Value;
                var nu_Item = dgTJLM.Rows[(i)].Cells["nu_item"].Value;


                if (nu_secu.ToString() == objTJM.Nu_secuen.ToString() & nu_Item.ToString() == objTJM.Nu_item.ToString())
                {
                    count = count + 1;
                   
                }

      
            }

           if (count == 0)
            {

                dgTJLM.Rows.Add(objTJM.Nu_secuen.ToString(), objTJM.Nu_item.ToString(), objTJM.Nu_longmalla.ToString(), objTJM.St_anulado.ToString());
            }

        }


        public void LlenarGrilla(ETejeduriaDet objTj, object form)
        {
            string str = Convert.ToString(dgDetalle.Rows.Count + 1);
            string[] row = { objTj.Nu_secuen,
                             objTj.Id_numalim,
                             objTj.Ds_distrib,
                             objTj.Ds_estruct,
                             objTj.Id_prodhilo,
                             objTj.ds_prodhilo,
                             objTj.Ds_tipfibra,
                             objTj.Ds_carachilo,
                             objTj.Ds_titulo,
                             objTj.Id_vlustre,
                             objTj.ds_lustre,
                             objTj.Nu_torsion,
                             objTj.Id_clipro,
                             objTj.ds_razsoc,
                             objTj.Nu_lote,
                             objTj.Ds_etiqueta,
                             objTj.Nu_porhilo.ToString(),
                             objTj.Nu_porhiloaca.ToString(),
                             objTj.Nu_tension.ToString(),
                             objTj.Nu_bobinas.ToString(),
                             objTj.Nu_alimenta.ToString(),

                             objTj.Mt_preuni.ToString(),
                             objTj.Mt_subtotcon.ToString(),
                           };
            dgDetalle.Rows.Add(row);


            frmModalDetalle frmPopup = (frmModalDetalle)form;
            frmPopup.Close();

        }

   //string _drow2;

        public void LlenarGrillaLI(ETejeduria_DetMall OBJTJLM, object form)
        {

            string str = Convert.ToString(dgTJLM.Rows.Count + 1);

            string[] row = { OBJTJLM.Nu_secuen,
                             OBJTJLM.Nu_item,
                             OBJTJLM.Nu_longmalla.ToString(),
                             OBJTJLM.St_anulado,
                            };

            dgTJLM.Rows.Add(row);

        }



        public void LlenarGrillaLM(ETejeduria_DetMall OBJTJLM, object form)
        {

            string str = Convert.ToString(dgTJLM.Rows.Count + 1);

            var nusecu = OBJTJLM.Nu_secuen;
            var nuItem = OBJTJLM.Nu_item;
            var nulong = OBJTJLM.Nu_longmalla.ToString();
            var stanu = OBJTJLM.St_anulado;

             for (int i = 0; dgTJLM.Rows.Count > i; i++)
                {
                    var nu_secu = dgTJLM.Rows[(i)].Cells["nu_secuen"].Value;
                    var nu_Item = dgTJLM.Rows[(i)].Cells["nu_item"].Value;
                    //var stAnulado = dgTJLM.Rows[(i)].Cells["_st_anulado"].Value;
                    //var stAnulado = dgTJLM.Rows[(i)].Cells["_st_anulado"].Value;

                    if (nu_secu.ToString() == nusecu.ToString() & nu_Item.ToString() == nuItem.ToString())
                    {// & stAnulado.ToString() == stanu.ToString()

                        (dgTJLM.Rows[(i)].Cells["nu_secuen"]).Value = nusecu.ToString();
                        (dgTJLM.Rows[(i)].Cells["nu_item"]).Value = nu_Item.ToString();
                        (dgTJLM.Rows[(i)].Cells["nu_longmalla"]).Value = nulong.ToString();
                        (dgTJLM.Rows[(i)].Cells["_st_anulado"]).Value = stanu.ToString();
                    }
            

                  }



             int count2 = 0;
             for (int u = 0; dgTJLM.Rows.Count > u;u++)
             {
                 var _nu_secu = dgTJLM.Rows[(u)].Cells["nu_secuen"].Value;
                 var _nu_Item = dgTJLM.Rows[(u)].Cells["nu_item"].Value;


                 if (_nu_secu.ToString() == OBJTJLM.Nu_secuen && _nu_Item.ToString() == OBJTJLM.Nu_item)
                 {
                     count2 = count2 + 1;
                 }
                 else
                 {

                 }
             }

             if (count2 == 0)
             {
                 //string str = Convert.ToString(dgTJLM.Rows.Count + 1);

                 string[] row = { OBJTJLM.Nu_secuen,
                             OBJTJLM.Nu_item,
                             OBJTJLM.Nu_longmalla.ToString(),
                             OBJTJLM.St_anulado,
                            };

                 dgTJLM.Rows.Add(row);
             }

             else
             {
                 //MessageBox.Show("Ya existe este Articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                 //frm.Close();
             }

        
        }

        private void btnNewProc_Click(object sender, EventArgs e)
        {
            NuevoItem();
        }


        private void mSalvarDatosGrilla()
        {
            try
            {
                //recorre la cantidad de items, por cada item la entidad oAsigHorario va almacenando , 
                //esto para que data que se va ingresando en la grilla no se pierda

                List<ETejeduria_DetProces> lstSalvarDatos = new List<ETejeduria_DetProces>();

                for (int i = 0; dgProcesos.Rows.Count > i; i++)
                {
                    // la entidad almacena los items de la grilla 

                    ETejeduria_DetProces oTJ = new ETejeduria_DetProces();

                    // verificar si los valores ingresados en la grilla estan en label o texbox como tambien en un dropdowlinst
                    oTJ.IdItem = dgProcesos.Rows[i].Cells["idItem"].Value.ToString();
                    oTJ.IdRutaProces = dgProcesos.Rows[i].Cells["idRutaProces"].Value.ToString();
                   

                    //añade los valores de la entidad a la lista de la entidad

                    lstSalvarDatos.Add(oTJ);

                }
            
                // se crea una sesion para almacenar la lista que contiene los  datos.

                SalvarDatos = lstSalvarDatos;
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }


        List<ETejeduria_DetProces> SalvarDatos = new List<ETejeduria_DetProces>();

        string valorCelda;
        private void NuevoItem()
        {
            int countRows = dgProcesos.Rows.Count - 1;

            if (countRows >= 0)
            {
                valorCelda = dgProcesos.Rows[countRows].Cells["idItem"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }


            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            dgProcesos.Rows.Add(item.PadLeft(3, '0').ToString(), "");
            dgProcesos.CurrentCell = dgProcesos.Rows[dgProcesos.Rows.Count - 1].Cells["idRutaProces"];
            dgProcesos.Focus();
         
        }




        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    
                    ETejeduria tj = new ETejeduria();


                    tj.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idEmpresa;//llenar con sesion
                    DateTime periodo = DateTime.Parse(txt_fecha.Text);
                    tj.IdPeriodo = periodo.Year.ToString();
                    tj.Id_producto = txt_idTejido.Text;

                    if (txt_nuFicha.Text == "")
                    {
                        List<Dato> oListDato = BTejeduria.TJ_TejeduriaGenCod( wfChgEmpPer.datos.idEmpresa,txt_idTejido.Text);
                        if (oListDato.Count > 0)
                        {
                            txt_nuFicha.Text = oListDato[0].id;
                            tj.Nu_correficha = txt_nuFicha.Text;
                        }
                      
                    }
                    else
                    {
                        tj.Nu_correficha = txt_nuFicha.Text;
                       
                    }
                   
                    tj.Id_clipro = txt_IdCli.Text;
                    tj.Fe_registro = txt_fecha.Text;
                    tj.Nu_refmuestra = txt_nuMuestra.Text;
                    tj.Nu_tf = txt_nuTf.Text;
                    tj.Nu_gt = txt_Nu_GT.Text;
                    tj.Nu_tfref = txt_nu_tfref.Text;
                    tj.Id_vtipmcdo = cb_Mercado.SelectedValue.ToString();
                    tj.Nu_regula = txt_Nu_Regulacion.Text;
                    tj.Id_vdestino = cb_Destino.SelectedValue.ToString();
                    tj.Id_vtipancru = cb_InfTecCrudo_ancho.SelectedValue.ToString();
                    tj.Qt_anchcrudo = Convert.ToDecimal(txt_InfTecCrudo_idancho.Text);
                    tj.Qt_denscrudo = Convert.ToDecimal(txt_InfTecCrudo_densidad.Text);
                    tj.Qt_rendcrudo = Convert.ToDecimal(txt_InfTecCrudo_rendim.Text);
                    tj.Qt_anchacaba = Convert.ToDecimal(txt_InfTecAcab_ancho.Text);
                    tj.Qt_densacaba = Convert.ToDecimal(txt_InfTecAcab_desnsi.Text);
                    tj.Qt_rendacaba = Convert.ToDecimal(txt_InfTecAcab_rendim.Text);
                    tj.Id_maqtenido = txt_maq_teñido.Text;
                    tj.Nu_porencla = Convert.ToDecimal(txt_encogi_largo.Text);
                    tj.Nu_porencan = Convert.ToDecimal(txt_encog_ancho.Text); 
                    tj.Ds_observa = txt_observ.Text;
                    tj.Id_ptmaq = txtMaquina.Text;
                    tj.Nu_ptdiame = Convert.ToDecimal(txtdiam.Text);
                    tj.Nu_ptgalga =  Convert.ToInt16(txtgalga.Text);
                    tj.Nu_ptsistrab = Convert.ToInt16(txtsistTrab.Text);
                    tj.Nu_ptsisanul = Convert.ToInt16(txtsistAnul.Text);
                    tj.Nu_ptrpm = Convert.ToInt16(txtrpm.Text);
                    tj.Qt_ptpeso = Convert.ToDecimal(txtpeso.Text);
                    tj.Ds_obstejido = txtDs_obstejido.Text.ToUpper();
                    tj.Ds_evadeftj = txtDs_evadeftj.Text.ToUpper();
                    tj.Nu_porrev = Convert.ToDecimal(txt_rev_porc.Text);
                    tj.Nu_gradosrev = Convert.ToDecimal("0.0000") ;
                    tj.Nu_pormerma = Convert.ToDecimal(txt_merma_porc.Text);
                    tj.Mt_costtenido = Convert.ToDecimal(txt_costo_teñido.Text);
                    tj.Mt_totconsumo = Convert.ToDecimal("0.0000");
                    tj.nu_platina = Convert.ToDecimal(txtPlatina.Text);                       
                    tj.qt_anchdatreqacaba = Convert.ToDecimal(txtReqAcabAnch.Text);
                    tj.qt_densdatreqacaba = Convert.ToDecimal(txtReqAcabDens.Text);
                    tj.Id_ucrearec = frmLogin.d.id.ToLower();//frmLogin.d.id.ToLower();//LLENAR DESDE LA SESION
                    tj.Id_Color = txtIdColor.Text;
                    BTejeduria.TJ_Tejeduria_mnt02(tj);
           

                    //-----------------DETALLE 1 DE TEJIDO----------------
                    ETejeduriaDet TJD = new ETejeduriaDet();

                    for (int i = 0; dgDetalle.Rows.Count > i; i++)
                    {
                        var nusecu = dgDetalle.Rows[i].Cells["_nu_secuen"].Value;
                        var Alim = dgDetalle.Rows[i].Cells["Alim"].Value;
                        var Distribucion = dgDetalle.Rows[i].Cells["Distribucion"].Value;
                        var estructura = dgDetalle.Rows[i].Cells["estructura"].Value;
                        var idHilo = dgDetalle.Rows[i].Cells["idHilo"].Value;
                        var Hilo = dgDetalle.Rows[i].Cells["Hilo"].Value;
                        var tipo_fibra = dgDetalle.Rows[i].Cells["tipo_fibra"].Value;
                        var carac_hilo = dgDetalle.Rows[i].Cells["carac_hilo"].Value;
                        var titulo = dgDetalle.Rows[i].Cells["titulo"].Value;
                        var idLustre = dgDetalle.Rows[i].Cells["idLustre"].Value;
                        var lustre = dgDetalle.Rows[i].Cells["lustre"].Value;
                        var torsion = dgDetalle.Rows[i].Cells["nu_torsion"].Value;
                        var idProv = dgDetalle.Rows[i].Cells["idProv"].Value;
                        var proveedor = dgDetalle.Rows[i].Cells["proveedor"].Value;
                        var Lote = dgDetalle.Rows[i].Cells["Lote"].Value;
                        var etiqueta = dgDetalle.Rows[i].Cells["etiqueta"].Value;
                        var porHiloCrudo = dgDetalle.Rows[i].Cells["porHiloCrudo"].Value;
                        var porHiloAcab = dgDetalle.Rows[i].Cells["porHiloAcab"].Value;
                        var nu_tension = dgDetalle.Rows[i].Cells["nu_tension"].Value;
                        var nu_bobinas = dgDetalle.Rows[i].Cells["nu_bobinas"].Value;
                        var nu_aliment = dgDetalle.Rows[i].Cells["nu_aliment"].Value;
                        var pre_uni = dgDetalle.Rows[i].Cells["pre_uni"].Value;
                        var Sub_total = dgDetalle.Rows[i].Cells["Sub_total"].Value;

                        TJD.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        TJD.IdPeriodo    = periodo.Year.ToString(); //wfChgEmpPer.datos.idperiodo;//llenar con sesion
                        TJD.Id_producto  = txt_idTejido.Text;
                        TJD.Nu_correficha= txt_nuFicha.Text;
                        TJD.Nu_secuen    = nusecu.ToString();
                        TJD.Id_numalim   = Alim.ToString();
                        TJD.Ds_distrib   = Distribucion.ToString();
                        TJD.Ds_estruct   = estructura.ToString();
                        TJD.Id_prodhilo  = idHilo.ToString();
                        TJD.ds_prodhilo  = Hilo.ToString();
                        TJD.Ds_tipfibra  = tipo_fibra.ToString();
                        TJD.Ds_carachilo = carac_hilo.ToString();
                        TJD.Ds_titulo    = titulo.ToString();
                        TJD.Id_vlustre   = idLustre.ToString();
                        TJD.ds_lustre    = lustre.ToString();
                        TJD.Nu_torsion   = torsion.ToString();
                        TJD.Id_clipro    = idProv.ToString();
                        TJD.ds_razsoc    = proveedor.ToString();
                        TJD.Nu_lote      = Lote.ToString();
                        TJD.Ds_etiqueta  = etiqueta.ToString();
                        TJD.Nu_porhilo   = Convert.ToDecimal(porHiloCrudo);
                        TJD.Nu_porhiloaca= Convert.ToDecimal(porHiloAcab);
                        TJD.Nu_longmalla = Convert.ToDecimal("0.0000");
                        TJD.Nu_tension   = Convert.ToDecimal(nu_tension);
                        TJD.Nu_bobinas   = Convert.ToInt16(nu_bobinas);
                        TJD.Nu_alimenta  = Convert.ToInt16(nu_aliment);
                        TJD.Mt_preuni    = Convert.ToDecimal(pre_uni);
                        TJD.Mt_subtotcon = Convert.ToDecimal(Sub_total);
                        TJD.Id_ucrearec = frmLogin.d.id.ToLower(); //frmLogin.d.id; //llenar con sesion
                        BTejeduriaDet.TJ_TejeduriaDet_mnt01(TJD);

                    }

                    //detalle tejeduria proceso



                    ETejeduria_DetProces TJDP = new ETejeduria_DetProces();

                    for (int i = 0; dgProcesos.Rows.Count > i; i++)
                    {

                        var idItem = dgProcesos.Rows[i].Cells["idItem"].Value;
                        var idRutaProces = dgProcesos.Rows[i].Cells["idRutaProces"].Value;

                        TJDP.IdPeriodo = periodo.Year.ToString(); //wfChgEmpPer.datos.idperiodo;//llenar con sesion
                        TJDP.Id_producto = txt_idTejido.Text;
                        TJDP.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        TJDP.Nu_correficha = txt_nuFicha.Text;
                        TJDP.IdItem = idItem.ToString();
                        TJDP.IdRutaProces = idRutaProces.ToString();
                        TJDP.Id_ucrearec = frmLogin.d.id.ToLower(); //frmLogin.d.id; //llenar con sesion
                        BTejeduriaDetProces.TJ_TejeduriaRutaProces_mnt01(TJDP);

                    }

                    // Detalle Tejeduria Malla

                    ETejeduria_DetMall TJDPLM = new ETejeduria_DetMall();

                    for (int i = 0; dgTJLM.Rows.Count > i; i++)
                    {
                        var nu_secue = dgTJLM.Rows[i].Cells["nu_secuen"].Value;
                        var idItem = dgTJLM.Rows[i].Cells["nu_item"].Value;
                        var nulongMall = dgTJLM.Rows[i].Cells["nu_longmalla"].Value;
                        var stAnaulado = dgTJLM.Rows[i].Cells["_st_anulado"].Value;

                        TJDPLM.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion
                        TJDPLM.IdPeriodo = periodo.Year.ToString(); 
                        TJDPLM.Id_producto = txt_idTejido.Text;
                        TJDPLM.Nu_correficha = txt_nuFicha.Text;
                        TJDPLM.Nu_secuen = nu_secue.ToString();
                        TJDPLM.Nu_item = idItem.ToString();
                        TJDPLM.Nu_longmalla = Convert.ToDecimal(nulongMall);
                        TJDPLM.Id_ucrearec = frmLogin.d.id.ToLower(); //frmLogin.d.id; //llenar con sesion
                        TJDPLM.St_anulado = stAnaulado.ToString();
                        BTejeduriaDetMall.TJ_Tejeduria_DetMall_mnt01(TJDPLM);

                    }

                   


                    //ANULAR EL DETALLE

                ETejeduriaDet TJDPLME = new ETejeduriaDet();

                for (int i = 0; dgTempDet.Rows.Count > i; i++)
                    {
                        var nu_secue = dgTempDet.Rows[i].Cells["nusecuencia"].Value;


                        TJDPLME.IdPeriodo = periodo.Year.ToString();
                        TJDPLME.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion

                        TJDPLME.Id_producto = txt_idTejido.Text;
                        TJDPLME.Nu_correficha = txt_nuFicha.Text;
                        TJDPLME.Nu_secuen = nu_secue.ToString();
                        TJDPLME.Id_ucrearec = frmLogin.d.id.ToLower();
                        
                        BTejeduriaDet.TJ_TejeduriaDet_mnt03(TJDPLME);

                    }

                    //ANULAR EL DETALLE DEL PROCESO

                ETejeduria_DetProces TJDPE = new ETejeduria_DetProces();

                for (int i = 0; dgTempDetProc.Rows.Count > i; i++)
                    {
                        var nu_Item = dgTempDetProc.Rows[i].Cells["nuItem"].Value;
                     

                        TJDPE.IdPeriodo = periodo.Year.ToString();
                        TJDPE.Id_producto = txt_idTejido.Text;
                        TJDPE.IdEmpresa = wfChgEmpPer.datos.idEmpresa; //wfChgEmpPer.datos.idperiodo;//llenar con sesion
                   
                        TJDPE.Nu_correficha = txt_nuFicha.Text;
                        TJDPE.IdItem = nu_Item.ToString();
                        TJDPE.Id_ucrearec = frmLogin.d.id.ToLower();
                        
                        BTejeduriaDetProces.TJ_TejeduriaRutaProces_mnt03(TJDPE);

                    }

                 


                    MessageBox.Show("Datos Grabados","Información" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var idCli = txt_IdCli.Text;
            var idTejido = txt_idTejido.Text;
            var idMercado = cb_Mercado.Text;
            var idDestino = cb_Destino.Text;
            var idAncho = txt_InfTecCrudo_idancho.Text;
            var idColor = txtIdColor.Text;

            if ((idCli != "") & (idTejido != "") &  (idMercado != "") & (idDestino != "") & (idAncho != "") & (idColor != ""))
            {
                Grabar();
            }
            else
            {
                MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nuMuestra_KeyUp(object sender, KeyEventArgs e)
        {

            Funcion.ValidarCampoEntero((TextBox)sender);
          
        }

        private void txtReqAcabAnch_KeyPress(object sender, KeyPressEventArgs e)
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


                txtReqAcabDens.SelectionStart = 0;
                txtReqAcabDens.SelectionLength = txtReqAcabDens.Text.Length;
                txtReqAcabDens.Focus();
            }
        }

        private void txtReqAcabDens_KeyPress(object sender, KeyPressEventArgs e)
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
                txt_InfTecAcab_ancho.SelectionStart = 0;
                txt_InfTecAcab_ancho.SelectionLength = txt_InfTecAcab_ancho.Text.Length;
                txt_InfTecAcab_ancho.Focus();
            }
        }

        private void btnBusColor_Click(object sender, EventArgs e)
        {
            FrmColor_qry frmp = new FrmColor_qry();
            frmp.pasard += new FrmColor_qry.pasar(ejecutarColor);
            frmp.ShowDialog();
            txtIdColor.Focus();
        }

        public void ejecutarColor(EColor col)
        {
            txtIdColor.Text = col.Id_color;
            lblColor.Text = col.Ds_color;
        }

        private void txtsistAnul_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void txtrpm_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void txt_IdCli_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmcoproveedor_qry frmp = new frmcoproveedor_qry();
                frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
                frmp.ShowDialog();
                txt_IdCli.Focus();
            }
        }

        private void txt_idTejido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmTejido_qry frmp = new FrmTejido_qry();
                frmp.pasard += new FrmTejido_qry.pasar(ejecutarTejido);
                frmp.ShowDialog();
                txt_IdCli.Focus();
            }
        }

        private void txtIdColor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmColor_qry frmp = new FrmColor_qry();
                frmp.pasard += new FrmColor_qry.pasar(ejecutarColor);
                frmp.ShowDialog();
                txtIdColor.Focus();
            }
        }

        private void FrmTejeduria_mnt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.N && e.Control)
            {
                Nuevo();
            }
          

            else if (e.KeyCode == Keys.I && e.Control)
            {
                try
                {

                    frmModalDetalle frmps = new frmModalDetalle();
                    frmps.FormParent = this;
                    frmps.EstadoDet = 1;
                    frmps.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


            else if (e.KeyCode == Keys.R && e.Control)
            {
                NuevoItem();

            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrnTejeduria_qry frmoc = new FrnTejeduria_qry();
                frmoc.pasard += new FrnTejeduria_qry.pasar(EjecutarTejeduria);
                frmoc.ShowDialog();

            }

            else if (e.KeyCode == Keys.G && e.Control)
            {
                var idCli = txt_IdCli.Text;
                var idTejido = txt_idTejido.Text;
                var idMercado = cb_Mercado.Text;
                var idDestino = cb_Destino.Text;
                var idAncho = txt_InfTecCrudo_idancho.Text;
                var idColor = txtIdColor.Text;

                if ((idCli != "") & (idTejido != "") & (idMercado != "") & (idDestino != "") & (idAncho != "") & (idColor != ""))
                {
                    Grabar();
                }
                else
                {
                    MessageBox.Show("Falta ingresar un dato", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else if (e.KeyCode == Keys.E && e.Control)
            {
                HabilitarTexto(groupBox1);
                HabilitarTexto(groupBox2);
                HabilitarTexto(groupBox3);
                HabilitarTexto(groupBox4);
                HabilitarTexto(groupBox5);
                HabilitarTexto(groupBox8);

            }




            else if(e.KeyCode == Keys.Escape)
                 {
                this.Close();
            }
        }

       


        private void btnEliminarRow_Click(object sender, EventArgs e)
        {
            if (dgDetalle.RowCount > 0)
            {
                var nuSecuen = dgDetalle.CurrentRow.Cells["_nu_secuen"].Value;


                try
                {
                    dgTempDet.Rows.Add(nuSecuen.ToString());

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                dgDetalle.Rows.Remove(dgDetalle.CurrentRow);
            }
            else
            {

            }

        }

        private void btnDelProc_Click(object sender, EventArgs e)
        {
            if (dgProcesos.RowCount > 0)
            {
                var nuItem = dgProcesos.CurrentRow.Cells["idItem"].Value;


                try
                {
                    dgTempDetProc.Rows.Add(nuItem.ToString());

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                dgProcesos.Rows.Remove(dgProcesos.CurrentRow);

            }
            else
            { 

            }
        }

        private void txtBuscarTfRef_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public object GetDataReport(string key)
        {

            ETejeduria objE = new ETejeduria();
            ETejeduria objED = new ETejeduria();

        
      

            objE.psintypesel = 12;
            objE.Id_producto = txt_idTejido.Text;
            objE.Nu_correficha = txt_nuFicha.Text;


            objED.psintypesel = 13;
            objED.Id_producto = txt_idTejido.Text;
            objED.Nu_correficha = txt_nuFicha.Text;

            BTejeduria objTJ = new BTejeduria();
            DataTable dt = objTJ.GetFichaTejeduria_rpt01(objE);

            BTejeduria objTJD = new BTejeduria();
            DataTable dtD = objTJ.GetFichaTejeduria_rpt01(objED);

            DataSet ds = new DataSet();
            ds.Tables.Add(dtD);




            return ds;

        }

        public void PrintReport(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRfichatela_rpt.rpt";
                objRpt.Load(reportPath);


                //string reportPath = Application.StartupPath + "\\Reporte\\co_ordenCompra_rpt.rpt";

                //objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + txt_idTejido.Text + txt_nuFicha.Text + ".pdf";


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





        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintReport("");
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            FrmTejeduria_rpt rpt = new FrmTejeduria_rpt();
            rpt.var_idProducto = txt_idTejido.Text;
            rpt.var_nucorrelativo = txt_nuFicha.Text;
            rpt.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscarFicha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                BuscarTejeduria();
            }
         


        }

        private void txt_costo_teñido_KeyPress(object sender, KeyPressEventArgs e)
        {
    
        }

        private void txtPlatina_KeyPress(object sender, KeyPressEventArgs e)
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
                txtpeso.SelectionStart = 0;
                txtpeso.SelectionLength = txtpeso.Text.Length;
                txtpeso.Focus();
            }
        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
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
                txtgalga.SelectionStart = 0;
                txtgalga.SelectionLength = txtgalga.Text.Length;
                txtgalga.Focus();
            }
        }

        private void txtDs_obstejido_KeyPress(object sender, KeyPressEventArgs e)
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
                txtDs_evadeftj.SelectionStart = 0;
                txtDs_evadeftj.SelectionLength = txtDs_evadeftj.Text.Length;
                txtDs_evadeftj.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox2);
            HabilitarTexto(groupBox3);
            HabilitarTexto(groupBox4);
            HabilitarTexto(groupBox5);
            HabilitarTexto(groupBox8);
        }

        private void txtIdColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtIdColor.Text = txtIdColor.Text.PadLeft(9, '0');

                EColor per = new EColor();
                per.psintypesel = 1;
                per.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                per.Id_color = txtIdColor.Text;
                per.Ds_color = "";

                List<Dato> oListDato = BColor.ObtenerDatoColor(per);

                if (oListDato.Count > 0)
                {
                    lblColor.Text = oListDato[0].desc;

                    txt_costo_teñido.SelectionStart = 0;
                    txt_costo_teñido.SelectionLength = txt_costo_teñido.Text.Length;
                    txt_costo_teñido.Focus();
                }
                else
                {
                    MessageBox.Show("Color no Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdColor.Clear();
                    lblColor.Text = "";
                    txtIdColor.Focus();
                }



            }
        }

        private void dgProcesos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProcesos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NuevoItem();
            }
        }
        
    }
}
