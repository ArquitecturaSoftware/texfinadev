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
    public partial class FrmProveedor_mnt : Form
    {
        public FrmProveedor_mnt()
        {
            InitializeComponent();

            LlenarCombo();
          
        }

        private void LlenarCombo()
        {
           
            WebHelper.LoadListControl3(cbTipPersoneria, BTablaGeneral.tablaGeneral("023"));
            
            WebHelper.LoadListControl3(cbCalificacion, BTablaGeneral.tablaGeneral("138"));
            WebHelper.LoadListControl3(cbTipSociedad, BTablaGeneral.tablaGeneral("026"));
            WebHelper.LoadListControl3(cbTipDoc, BTablaGeneral.tablaGeneral_2("001"));
            WebHelper.LoadListControl3(cbDir, BTablaGeneral.tablaGeneral_2("002"));
            WebHelper.LoadListControl3(cbGrupo, BGrupo.TablaGrupo_qry02_());
            WebHelper.LoadListControl3(cbPais, BUbigeo.Pais_qry01_());
            cbPais.SelectedIndex = 168;

            DataTable dt1;
            dt1 = new DataTable("Tabla1");
            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");
            DataRow dr;
            dr = dt1.NewRow();
            dr["Codigo"] = "1";
            dr[1] = "SI";
            dt1.Rows.Add(dr);
            dr = dt1.NewRow();
            dr["Codigo"] = "0";
            dr[1] = "NO";
            dt1.Rows.Add(dr);
            this.cbCliente.DataSource = dt1;
            this.cbCliente.ValueMember = "Codigo";
            this.cbCliente.DisplayMember = "Descripcion";

            DataTable dt2;
            dt2 = new DataTable("Tabla2");
            dt2.Columns.Add("Codigo");
            dt2.Columns.Add("Descripcion");
            DataRow dr2;
            dr2 = dt2.NewRow();
            dr2["Codigo"] = "1";
            dr2[1] = "SI";
            dt2.Rows.Add(dr2);
            dr2 = dt2.NewRow();
            dr2["Codigo"] = "0";
            dr2[1] = "NO";
            dt2.Rows.Add(dr2);
            this.cbProveedor.DataSource = dt2;
            this.cbProveedor.ValueMember = "Codigo";
            this.cbProveedor.DisplayMember = "Descripcion";
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WebHelper.LoadListControl3(cbDepa, BUbigeo.Departamento_qry01_(cbPais.SelectedValue.ToString()));
            }
            catch (Exception ex)
            { 

            }
        }

        private void cbDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            WebHelper.LoadListControl3(cbProv, BUbigeo.Provincia_qry01_(cbPais.SelectedValue.ToString() ,cbDepa.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {

            }
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
          try
          {
            WebHelper.LoadListControl3(cbDist, BUbigeo.Distrito_qry01_(cbPais.SelectedValue.ToString(), cbDepa.SelectedValue.ToString(),cbProv.SelectedValue.ToString()));
          }
          catch (Exception ex)
          {

          }
        }
        int ancho, alto;
        private void FrmProveedor_mnt_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;
            
            
            Deshabilitar(groupBox1);
            Deshabilitar(groupBox2);
            Deshabilitar(groupBox3);
            LlenarCombo();
        }

        private void cbTipPersoneria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               txtRuc.Focus();
            }
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = false;
                txtRasonSoc.Focus();
                return;
            }
            //else if(e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            // txtRasonSoc.Focus();
            //}

        }

        private void txtRasonSoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtNomCom.Focus();
            }

        }

        private void txtNomCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbTipDoc.Focus();
            }
        }

        private void cbTipDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuDoc.Focus();
            }
        }

        private void txtnuDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
   
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = false;
                cbGrupo.Focus();
                return;
            }
           
        }

        private void cbGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbCliente.Focus();
            }
        }

        private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbProveedor.Focus();
            }
        }

        private void cbProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbTipSociedad.Focus();
            }
        }

        private void cbTipSociedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtapellido.Focus();
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuCelular.Focus();
            }
        }

        private void txtnuCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtweb.Focus();
            }
        }

        private void txtweb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtfax.Focus();
            }
        }

     
        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbCalificacion.Focus();
            }
        }


        private void cbCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDir.Focus();
            }
        }

        private void cbDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdireccion.Focus();
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbPais.Focus();
            }
        }

        private void cbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDepa.Focus();
            }
        }

        private void cbDepa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbProv.Focus();
            }
        }

        private void cbProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDist.Focus();
            }
        }

        private void cbDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtUrbanizacion.Focus();
            }
        }

       private void txtUrbanizacion_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == Convert.ToChar(Keys.Enter))
              {
                txtRpApe.Focus();
              }
         }

        private void txtRpApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRepMat.Focus();
            }
        }

        private void txtRepMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRepNom.Focus();
            }
        }

        private void txtRepNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRepEmail.Focus();
            }
        }

        private void txtRepEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRepTef.Focus();
            }
        }

        private void txtRepTef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRepAnexo.Focus();
            }
        }

        private void txtRepAnexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbTipPersoneria.Focus();
            }
        }


        private void Grabar()
        {
            try
            {
            ETerceros prov = new ETerceros();
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (txtCodProv.Text == "")
                {
                    List<Dato> oListDato = BTercero.Terceso_qry02_(wfChgEmpPer.datos.idEmpresa);
                    if (oListDato.Count > 0)
                    {
                        txtCodProv.Text = oListDato[0].id;
                        prov.Id_clipro = txtCodProv.Text;
                    }
                }
                else
                {
                    prov.Id_clipro = txtCodProv.Text;
                }
                prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                prov.Id_vpersjuri = cbTipPersoneria.SelectedValue.ToString();
                prov.Id_vtipsocie = cbTipSociedad.SelectedValue.ToString();
                prov.Ds_raznombre = txtRasonSoc.Text.ToUpper();
                prov.Ds_apellido = txtapellido.Text.ToUpper();
                prov.Ds_nomcomer = txtNomCom.Text.ToUpper();
                prov.Nu_ruc = txtRuc.Text;
                prov.Id_vtipdoc = cbTipDoc.SelectedValue.ToString();
                prov.Nu_dociden = txtnuDoc.Text;
                prov.Id_grupo = cbGrupo.SelectedValue.ToString();
                prov.St_activo = "1";
                prov.Ds_direccion = txtdireccion.Text.ToUpper();
                prov.Ds_urbaniza = txtUrbanizacion.Text.ToUpper();

                prov.Id_pais = cbPais.SelectedValue.ToString();

                if (cbDepa.Text != "")
                {
                    prov.Id_depto = cbDepa.SelectedValue.ToString();
                }
                else
                {
                    prov.Id_depto = "";
                }

                if (cbProv.Text != "")
                {
                    prov.Id_prov = cbProv.SelectedValue.ToString();
                }
                else
                {
                    prov.Id_prov = "";
                }

                if (cbDist.Text != "")
                {
                    prov.Id_dist = cbDist.SelectedValue.ToString();
                }
                else
                {
                    prov.Id_dist = "";
                }
                

                prov.Ds_pobox = "";
                prov.Nu_telf1 = txtRepTef.Text;
                prov.Nu_telf2 = txtnuCelular.Text;
                prov.Nu_telf3 = "";
                prov.Nu_fax1 = txtfax.Text;
                prov.Nu_fax2 = "";
                prov.Ds_emailco = txtEmail.Text;
                prov.Ds_url = txtweb.Text.ToUpper();
                prov.Ds_nomreleg = txtRepNom.Text.ToUpper();
                prov.Ds_appreleg = txtRpApe.Text.ToUpper();
                prov.Ds_apmreleg = txtRepMat.Text.ToUpper();
                prov.Nu_tlfreleg = "";
                prov.Nu_anxreleg = txtRepAnexo.Text;
                prov.Nu_nxtreleg = "";
                prov.Ds_emareleg = txtRepEmail.Text;
                prov.Id_vtipcalle = cbDir.SelectedValue.ToString();
                prov.Id_vendedor = "";
                prov.Nu_maquinas = 0;
                prov.Nu_trabaja = 0;
                prov.Id_cpago = "";
                prov.Nu_lcredit = 0;
                prov.Nu_placredit = 0;
                prov.Nu_diapag1 = "0";
                prov.Nu_diapag2 = "0";
                prov.Nu_diapag3 = "0";
                prov.Nu_diapag4 = "0";
                prov.Nu_diapag5 = "0";
                prov.Nu_diapag6 = "0";
                prov.Nu_diapag7 = "0";
                prov.Ho_diapag1_1 = "00:00";
                prov.Ho_diapag1_2 = "00:00";
                prov.Ho_diapag2_1 = "00:00";
                prov.Ho_diapag2_2 = "00:00";
                prov.Ho_diapag3_1 = "00:00";
                prov.Ho_diapag3_2 = "00:00";
                prov.Ho_diapag4_1 = "00:00";
                prov.Ho_diapag4_2 = "00:00";
                prov.Ho_diapag5_1 = "00:00";
                prov.Ho_diapag5_2 = "00:00";
                prov.Ho_diapag6_1 = "00:00";
                prov.Ho_diapag6_2 = "00:00";
                prov.Ho_diapag7_1 = "00:00";
                prov.Ho_diapag7_2 = "00:00";
                prov.St_vtipcli = cbCliente.SelectedValue.ToString();
                prov.St_vtippro = cbProveedor.SelectedValue.ToString();
                prov.St_prospecto = "0";
                prov.Id_ucrearec = frmLogin.d.id;
                BTercero.Btercero_mnt01(prov);
                MessageBox.Show("Datos Grabados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtRasonSoc.Text != "")
            {
                Grabar();
            }
            else
            {
                MessageBox.Show("Fantan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           

            frmcoproveedor_qry frmp = new frmcoproveedor_qry();
            frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
            frmp.ShowDialog();
        }

        private void Buscar()
        {

            ETerceros prov = new ETerceros();
            prov.Id_clipro = txtBuscarCodigo.Text;
            prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;

            List<ETerceros> oListDato = BProveedor.MG_Tercero_qry05(prov);

            if (oListDato.Count > 0)
            {
                string val = oListDato[0].existe;

                if (val == "0")
                {
                    if (!string.IsNullOrEmpty(txtBuscarCodigo.Text))
                    {
                        ETerceros ocliprov = new ETerceros();

                        ocliprov.Id_clipro = string.IsNullOrEmpty(txtBuscarCodigo.Text) ? string.Empty : Convert.ToString(txtBuscarCodigo.Text);

                        ocliprov.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                        ETerceros oBtieneOC = new ETerceros();
                        oBtieneOC = BProveedor.mObtenerCliProv_(ocliprov);

                        txtCodProv.Text = oBtieneOC.Id_clipro.ToString().Trim();

                        if (oBtieneOC.Id_vpersjuri.ToString().Trim() != "")
                        {
                            cbTipPersoneria.SelectedValue = oBtieneOC.Id_vpersjuri.ToString().Trim();
                        }
                        else
                        {
                            cbTipPersoneria.SelectedValue = "";
                        }

                        if (oBtieneOC.Id_vtipclasi.ToString().Trim() != "")
                        {
                            cbCalificacion.SelectedValue = oBtieneOC.Id_vtipclasi.ToString().Trim();
                        }
                        else
                        {
                            cbCalificacion.SelectedValue = "";
                        }

                      
                       cbTipSociedad.SelectedValue = oBtieneOC.Id_vtipsocie.ToString().Trim();
                   


                        txtRasonSoc.Text = oBtieneOC.Ds_raznombre.ToString().Trim();
                        txtapellido.Text = oBtieneOC.Ds_apellido.ToString().Trim();
                        txtNomCom.Text = oBtieneOC.Ds_nomcomer.ToString().Trim();
                        txtRuc.Text = oBtieneOC.Nu_ruc.ToString().Trim();
                        cbTipDoc.SelectedValue = oBtieneOC.Id_vtipdoc.ToString().Trim();
                        txtnuDoc.Text = oBtieneOC.Nu_dociden.ToString().Trim();
                        cbGrupo.SelectedValue = oBtieneOC.Id_grupo.ToString().Trim();
                        txtdireccion.Text = oBtieneOC.Ds_direccion.ToString().Trim();
                        txtUrbanizacion.Text = oBtieneOC.Ds_urbaniza.ToString().Trim();

                        if (oBtieneOC.Id_depto.ToString().Trim() == "")
                        {
                            //cbPais.SelectedValue = "";
                            cbDepa.SelectedValue = "";
                            cbProv.SelectedValue = "";
                            cbDist.SelectedValue = "";
                        }
                        else
                        {
                            cbPais.SelectedValue = oBtieneOC.Id_pais.ToString().Trim();
                            WebHelper.LoadListControl3(cbDepa, BUbigeo.Departamento_qry01_(cbPais.SelectedValue.ToString()));
                            cbDepa.SelectedValue = oBtieneOC.Id_depto.ToString().Trim();
                            WebHelper.LoadListControl3(cbProv, BUbigeo.Provincia_qry01_(cbPais.SelectedValue.ToString(), cbDepa.SelectedValue.ToString()));
                            cbProv.SelectedValue = oBtieneOC.Id_prov.ToString().Trim();
                            WebHelper.LoadListControl3(cbDist, BUbigeo.Distrito_qry01(cbPais.SelectedValue.ToString(), cbDepa.SelectedValue.ToString(), cbProv.SelectedValue.ToString()));
                            cbDist.SelectedValue = oBtieneOC.Id_dist.ToString().Trim();


                        }

                        txtRepTef.Text = oBtieneOC.Nu_telf1.ToString().Trim();
                        txtnuCelular.Text = oBtieneOC.Nu_telf2.ToString().Trim();
                        txtfax.Text = oBtieneOC.Nu_fax1.ToString().Trim();
                        txtEmail.Text = oBtieneOC.Ds_emailco.ToString().Trim();
                        txtweb.Text = oBtieneOC.Ds_url.ToString().Trim();
                        txtRpApe.Text = oBtieneOC.Ds_appreleg.ToString();
                        txtRepMat.Text = oBtieneOC.Ds_apmreleg.ToString().Trim();
                        txtRepNom.Text = oBtieneOC.Ds_nomreleg.ToString().Trim();
                        //txtRepTef.Text = oBtieneOC.Nu_tlfreleg.ToString().Trim();
                        //txtRepTef.Text = oBtieneOC.Nu_telf2.ToString().Trim();
                        txtRepAnexo.Text = oBtieneOC.Nu_anxreleg.ToString().Trim();
                        txtRepEmail.Text = oBtieneOC.Ds_emareleg.ToString().Trim();
                        cbDir.SelectedValue = oBtieneOC.Id_vtipcalle.ToString().Trim();
                        cbCliente.SelectedValue = oBtieneOC.St_vtipcli.ToString().Trim();
                        cbProveedor.SelectedValue = oBtieneOC.St_vtippro.ToString().Trim();

                    }
                }
                else
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }


        public void ejecutarProv(EProveedor prov)
        {

            txtBuscarCodigo.Text = prov.Id_clipro;
            txtCodProv.Text = prov.Id_clipro;
            txtRasonSoc.Text = prov.Ds_raznombre;
         
            Buscar();
                 
            }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            txtCodProv.Text = "";
          
        }
        private void Eliminar()
        {
           try
            {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                if (!string.IsNullOrEmpty(txtCodProv.Text))
                {
                    ETerceros ocliprov = new ETerceros();

                    ocliprov.Id_clipro = string.IsNullOrEmpty(txtCodProv.Text) ? string.Empty : Convert.ToString(txtCodProv.Text);

                    ocliprov.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    ETerceros oBtieneOC = new ETerceros();

                    BProveedor.DeleteCliProv(ocliprov);                   
              
                }
            }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(groupBox1);
            Limpiar(groupBox2);
            Limpiar(groupBox3);

            Habilitar(groupBox1);
            Habilitar(groupBox2);
            Habilitar(groupBox3);

            txtBuscarCodigo.Focus();
        }

        private void Limpiar( GroupBox grupo)
        {
            //txtnu_oc.Text = "";

            foreach (Control c in  grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.cbTipPersoneria.Focus();

                }
               

            }
        }

        private void Deshabilitar(GroupBox grupo)
        {
            //txtnu_oc.Text = "";

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Enabled = false;


                    this.txtBuscarCodigo.Focus();

                }

                else if (c is ComboBox)
                {
                    c.Enabled = false;


                    this.txtBuscarCodigo.Focus();

                }

            }
        }

        private void Habilitar(GroupBox grupo)
        {
            //txtnu_oc.Text = "";

            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Enabled = true;


                    this.txtBuscarCodigo.Focus();

                }
                else if (c is ComboBox)
                {
                    c.Enabled = true;


                    this.txtBuscarCodigo.Focus();

                }
            }
        }



        private void FrmProveedor_mnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Limpiar(groupBox1);
                Limpiar(groupBox2);
                Limpiar(groupBox3);
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                Grabar();
             }
            else if (e.KeyCode == Keys.E && e.Control)
            {
                Eliminar();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void txtBuscarCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmcoproveedor_qry frmp = new frmcoproveedor_qry();
                frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
                frmp.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProveedor_mnt_Resize(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(groupBox1);
            Habilitar(groupBox2);
            Habilitar(groupBox3);
        }

        private void txtBuscarCodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }

   }
        
      
    
}
