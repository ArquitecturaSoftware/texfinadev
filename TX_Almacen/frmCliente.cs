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
    public partial class frmCliente : Form
    {
        public frmCliente()
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtRasonSoc.Focus();
            }
           
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbGrupo.Focus();
            }
        }

        private void cbTipSociedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtapellido.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuCelular.Focus();
            }
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtEmail.Focus();
            }
        }

        private void txtweb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbCalificacion.Focus();
            }
        }

        private void txtnuCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txttelf.Focus();
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
                txtid_vendedor.Focus();
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
                txtUrbanizacion.Focus();
            }
        }

        private void cbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDepa.Focus();
            }
        }

        private void cbProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDist.Focus();
            }
        }

        private void txtUrbanizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbPais.Focus();
            }

        }

        private void cbDepa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbProv.Focus();
            }
        }

        private void cbDist_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtweb.Focus();
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



        private void Grabar()
        {
            try
            {
                ECliente prov = new ECliente();
                DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (txtCodProv.Text == "")
                    {
                        List<Dato> oListDato = BCliente.Cliente_qry06(wfChgEmpPer.datos.idEmpresa);
                        
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
                    prov.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    prov.Id_vptipsocie = cbTipSociedad.SelectedValue.ToString();
                    prov.Id_vpersjuri = cbTipPersoneria.SelectedValue.ToString();
                    prov.Ds_raznombre = txtRasonSoc.Text.ToUpper();
                    prov.Ds_apellido = txtapellido.Text.ToUpper();
                    prov.Nu_ruc = txtRuc.Text.ToUpper();
                    prov.Id_vtipdoc = cbTipDoc.SelectedValue.ToString();
                    prov.Nu_dociden = txtnuDoc.Text;
                    prov.Ds_nomcomer = txtNomCom.Text.ToUpper();
                    prov.Id_grupo = cbGrupo.SelectedValue.ToString();
                    prov.Id_vtipclasi = cbCalificacion.SelectedValue.ToString();
                    prov.St_activo = "1";
                    prov.Id_vtipcalle = cbDir.SelectedValue.ToString();
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


                    prov.Nu_telf1 = txttelf.Text;
                    prov.Nu_telf2 = txtnuCelular.Text;
                    prov.Ds_emailco = txtEmail.Text;
                    prov.Ds_url = txtweb.Text;
                    prov.Ds_monreleg = txtRepNom.Text;
                    prov.Ds_appreleg = txtRpApe.Text;
                    prov.Ds_apmreleg = txtRepMat.Text;
                    prov.Nu_anxreleg = txtRepAnexo.Text;
                    prov.Nu_telfeg = txtRepTef.Text;
                    prov.Ds_emareleg = txtRepEmail.Text;
                    prov.Id_ucrearec = frmLogin.d.id.ToLower();
                    prov.Id_cliFox = txtid_clifox.Text;
                    prov.id_Vendedor = txtid_vendedor.Text;
                    BCliente.BCliente_mnt01(prov);
                    
                    MessageBox.Show("Datos Grabados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WebHelper.LoadListControl3(cbDepa, BUbigeo.Departamento_qry01_(cbPais.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void cbDepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WebHelper.LoadListControl3(cbProv, BUbigeo.Provincia_qry01_(cbPais.SelectedValue.ToString(), cbDepa.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                WebHelper.LoadListControl3(cbDist, BUbigeo.Distrito_qry01_(cbPais.SelectedValue.ToString(), cbDepa.SelectedValue.ToString(), cbProv.SelectedValue.ToString()));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(groupBox1);
            Limpiar(groupBox2);
            Limpiar(groupBox3);

            Habilitar(groupBox1);
            Habilitar(groupBox2);
            Habilitar(groupBox3);
            txtBuscarCodigo.Clear();
            txtid_clifox.Focus();
        }

        private void frnCliente_Load(object sender, EventArgs e)
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
                u.IdModulo = "03";
                u.Id_formulario = "0003";

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
                //btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                //btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);

            }
            catch (Exception ex)
            {
                ex.ToString();
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


                    this.cbTipPersoneria.Focus();

                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(groupBox1);
            Habilitar(groupBox2);
            Habilitar(groupBox3);
        }


        private void Buscar()
        {

            ECliente prov = new ECliente();
            prov.Id_clipro = txtBuscarCodigo.Text;
            prov.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            List<ECliente> oListDato = BCliente.MG_Cliente_qry05(prov);

            if (oListDato.Count > 0)
            {
                string val = oListDato[0].existe;

                if (val == "0")
                {
                    if (!string.IsNullOrEmpty(txtBuscarCodigo.Text))
                    {
                        ECliente ocliprov = new ECliente();

                        ocliprov.Id_clipro = string.IsNullOrEmpty(txtBuscarCodigo.Text) ? string.Empty : Convert.ToString(txtBuscarCodigo.Text);

                        ocliprov.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                        ECliente oBtieneOC = new ECliente();
                        oBtieneOC = BCliente.MG_Cliente_qry02(ocliprov);

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

                        cbTipSociedad.SelectedValue = oBtieneOC.Id_vptipsocie.ToString().Trim();
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
                        txtRepTef.Text = oBtieneOC.Nu_telfeg.ToString().Trim();
                        txttelf.Text = oBtieneOC.Nu_telf1.ToString().Trim();
                        txtnuCelular.Text = oBtieneOC.Nu_telf2.ToString().Trim();
                       
                        txtEmail.Text = oBtieneOC.Ds_emailco.ToString().Trim();
                        txtweb.Text = oBtieneOC.Ds_url.ToString().Trim();
                        txtRpApe.Text = oBtieneOC.Ds_appreleg.ToString();
                        txtRepMat.Text = oBtieneOC.Ds_apmreleg.ToString().Trim();
                        txtRepNom.Text = oBtieneOC.Ds_monreleg.ToString().Trim();
                        txtRepAnexo.Text = oBtieneOC.Nu_anxreleg.ToString().Trim();
                        txtRepEmail.Text = oBtieneOC.Ds_emareleg.ToString().Trim();
                        cbDir.SelectedValue = oBtieneOC.Id_vtipcalle.ToString().Trim();
                        txtid_clifox.Text = oBtieneOC.Id_cliFox.ToString();
                        txtid_vendedor.Text = oBtieneOC.id_Vendedor.ToString();
                        txtds_vendedor.Text = oBtieneOC.ds_Vendedor.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


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
                        ECliente ocliprov = new ECliente();

                        ocliprov.Id_clipro = string.IsNullOrEmpty(txtCodProv.Text) ? string.Empty : Convert.ToString(txtCodProv.Text);

                        ocliprov.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                        ECliente oBtieneOC = new ECliente();

                        BCliente.DeleteCliente(ocliprov);
                        

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            frmCliente_qry frmp = new frmCliente_qry();
            frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
            frmp.ShowDialog();
        }

        public void ejecutarCliente(ECliente c)
        {

            txtBuscarCodigo.Text = c.Id_clipro;
            txtCodProv.Text = c.Id_clipro;
            txtRasonSoc.Text = c.Ds_raznombre;

            Buscar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frnCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //this.Close();
            }
        }

        private void txtcodFox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbTipPersoneria.Focus();
            }
        }

        private void txtid_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbDir.Focus();
            }
        }

    

        private void btnvendedor_Click(object sender, EventArgs e)
        {
            frmVendedorQry frmps = new frmVendedorQry();
            frmps.pasard += new frmVendedorQry.pasar(ejecutarVendedor);
            frmps.ShowDialog();
            txtid_vendedor.Focus();
        }

        public void ejecutarVendedor(string idPers, string dsPers)
        {
            txtid_vendedor.Text = idPers;
            txtds_vendedor.Text = dsPers;
        }

    }
}
