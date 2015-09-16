using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.TJ;
using Texfina.DOQry.Sy;
using Texfina.Entity.Sy;
using Texfina.Entity.TJ;


namespace TX_Terjeduria
{
    public partial class FrmTejeduriaRutaProces : Form
    {
        public FrmTejeduriaRutaProces()
        {
            InitializeComponent();


            DataGridViewComboBoxColumn comboboxolumn = dgProcesos.Columns["idRutaProces"] as DataGridViewComboBoxColumn;
            //WebHelper.LoadListControl3(comboboxolumn, BGeneral.ObtenerDatoLocal());
            comboboxolumn.DataSource = BTejeduriaDetProces.ObtenerDatoProces();
            comboboxolumn.DisplayMember = "desc";
            comboboxolumn.ValueMember = "id";
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


            foreach (Control c in grupo.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txt_idTejido.Focus();

                }
            }

        
        }

        private void Nuevo()
        { 
            txt_InfTecAcab_ancho.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecAcab_desnsi.Text = string.Format("{0:##,##0.0000}", 0);
            txt_InfTecAcab_rendim.Text = string.Format("{0:##,##0.0000}", 0);
            txt_encogi_largo.Text = string.Format("{0:##,##0.0000}", 0);
            txt_encog_ancho.Text = string.Format("{0:##,##0.0000}", 0);
            txt_maq_teñido.Clear();
            txtIdColor.Clear();
            lblColor.Text="";
            txt_idTejido.Clear();
            txt_IdCli.Clear();
            txt_nuTf.Clear();
            txt_nuFicha.Clear();
            lbl_dsTejido.Text="";
            lbl_dsCliente.Text="";
            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox3);
            HabilitarTexto(groupBox4);
            
            dgProcesos.Rows.Clear();
            dgTempDetProc.Rows.Clear();

            txtBuscarFicha.Clear();
            txtBuscarnuTF.Clear();
            txtBuscarTejido.Clear();
            txtBuscarTfRef.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Nuevo();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FrnTejeduria_qry frmoc = new FrnTejeduria_qry();
            frmoc.pasard += new FrnTejeduria_qry.pasar(EjecutarTejeduria);
            frmoc.ShowDialog();
        }

        public void EjecutarTejeduria(ETejeduria TJ)
        {
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
            dgProcesos.Rows.Clear();
            dgTempDetProc.Rows.Clear();

            oT.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            oT.Id_producto = txtBuscarTejido.Text;
            oT.Nu_correficha = txtBuscarFicha.Text;


            List<ETejeduria> oListDato = BTejeduria.TJ_Tejeduria_qry06(oT);


            string val = oListDato[0].existe;

            if (val == "0")
            {

                try
                {

               
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

                    txt_fecha.Text = oBtieneTJ.Fe_registro.ToString();
                    txt_IdCli.Text = oBtieneTJ.Id_clipro.ToString().Trim();
                    lbl_dsCliente.Text = oBtieneTJ.ds_razonSoc.ToString().Trim();
                
                    txt_nuTf.Text = oBtieneTJ.Nu_tf.ToString().Trim();
   

                    txt_maq_teñido.Text = oBtieneTJ.Id_maqtenido.ToString().Trim();
                    txt_encogi_largo.Text = oBtieneTJ.Nu_porencla.ToString().Trim();
                    txt_encog_ancho.Text = oBtieneTJ.Nu_porencan.ToString().Trim();

                    //txt_rev_porc.Text = oBtieneTJ.Nu_porrev.ToString().Trim();
                    //txt_merma_porc.Text = oBtieneTJ.Nu_pormerma.ToString().Trim();

                    txt_InfTecAcab_ancho.Text = oBtieneTJ.Qt_anchacaba.ToString();
                    txt_InfTecAcab_desnsi.Text = oBtieneTJ.Qt_densacaba.ToString();
                    txt_InfTecAcab_rendim.Text = oBtieneTJ.Qt_rendacaba.ToString();
                    //txt_costo_teñido.Text = oBtieneTJ.Mt_costtenido.ToString().Trim();
                    //txtMaquina.Text = oBtieneTJ.Id_ptmaq.ToString().Trim();
                    //txtdiam.Text = oBtieneTJ.Nu_ptdiame.ToString();
                    //txtpeso.Text = oBtieneTJ.Qt_ptpeso.ToString();
                    //txtgalga.Text = oBtieneTJ.Nu_ptgalga.ToString();
                    //txtsistTrab.Text = oBtieneTJ.Nu_ptsistrab.ToString();
                    //txtsistAnul.Text = oBtieneTJ.Nu_ptsisanul.ToString();
                    //txtrpm.Text = oBtieneTJ.Nu_ptrpm.ToString();

                    //txtReqAcabAnch.Text = oBtieneTJ.qt_anchdatreqacaba.ToString();
                    //txtReqAcabDens.Text = oBtieneTJ.qt_densdatreqacaba.ToString();

                    //txtPlatina.Text = oBtieneTJ.nu_platina.ToString();


                    txtIdColor.Text = oBtieneTJ.Id_Color.ToString();
                    lblColor.Text = oBtieneTJ.ds_Color.ToString();
                    //txt_observ.Text = oBtieneTJ.Ds_observa.ToString();


                    /// detalle de procesos de tejeduria


                    ETejeduria_DetProces oTJDP = new ETejeduria_DetProces();


                    oTJDP.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    oTJDP.Id_producto = txtBuscarTejido.Text;
                    oTJDP.Nu_correficha = txtBuscarFicha.Text;


              

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


                }

                catch (Exception ex)
                {
                    ex.ToString();
                }

            }
            else
            {
                MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
              

            }

        }

        private void btnNewProc_Click(object sender, EventArgs e)
        {
            NuevoItem();

        }

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

        private void btnDelProc_Click(object sender, EventArgs e)
        {
            if (dgProcesos.RowCount > 0)
            {
                try
                {

                    var nuItem = dgProcesos.CurrentRow.Cells["idItem"].Value;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarTejeduria();

            }
        }

        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {
                    ETejeduria tj = new ETejeduria();

                    tj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;//wfChgEmpPer.datos.idEmpresa;//llenar con sesion
                    DateTime periodo = DateTime.Parse(txt_fecha.Text);
                    tj.IdPeriodo = periodo.Year.ToString();
                    tj.Id_producto = txt_idTejido.Text;
                    tj.Nu_correficha = txt_nuFicha.Text;
                    tj.Id_clipro = txt_IdCli.Text;
                    tj.Qt_anchacaba = Convert.ToDecimal(txt_InfTecAcab_ancho.Text);
                    tj.Qt_densacaba = Convert.ToDecimal(txt_InfTecAcab_desnsi.Text);
                    tj.Qt_rendacaba = Convert.ToDecimal(txt_InfTecAcab_rendim.Text);
                    tj.Id_maqtenido = txt_maq_teñido.Text;
                    tj.Nu_porencla = Convert.ToDecimal(txt_encogi_largo.Text);
                    tj.Nu_porencan = Convert.ToDecimal(txt_encog_ancho.Text);
           
                    tj.Id_uupdarec = frmLogin.d.id.ToLower();//frmLogin.d.id.ToLower();//LLENAR DESDE LA SESION
                    tj.Id_Color = txtIdColor.Text;
                    BTejeduria.TJ_Tejeduria_mnt04(tj);
        
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




                    MessageBox.Show("Datos Grabados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.Cancel)
                {



                }

            }
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarTexto(groupBox1);
            HabilitarTexto(groupBox3);
            HabilitarTexto(groupBox4);
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

        private void txt_InfTecAcab_ancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_InfTecAcab_desnsi.Focus();
            }
        }

        private void txt_InfTecAcab_desnsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_InfTecAcab_rendim.Focus();
            }
        }

        private void txt_InfTecAcab_rendim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_maq_teñido.Focus();
            }
        }

        private void txt_maq_teñido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_encogi_largo.Focus();
            }
        }

        private void txt_encogi_largo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_encog_ancho.Focus();
            }
        }

        private void txt_encog_ancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtIdColor.Focus();
            }

        }

        private void FrmTejeduriaRutaProces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Nuevo();
            }

            else if (e.KeyCode == Keys.I && e.Control)
            {
                NuevoItem();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrnTejeduria_qry frmoc = new FrnTejeduria_qry();
                frmoc.pasard += new FrnTejeduria_qry.pasar(EjecutarTejeduria);
                frmoc.ShowDialog();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

           
        }

        private void FrmTejeduriaRutaProces_Load(object sender, EventArgs e)
        {
            Permisos();
        }


        private void Permisos()
        {
            try
            {

                string Usu = frmLogin.d.idUser;
                string menu = "01";
                string ifFormulario = "0003";



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
                //btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                //btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
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

        private void dgProcesos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NuevoItem();
            }
        }


    }
}
