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
using Texfina.Entity.Co;
using Texfina.Entity.Sy;
using Texfina.Entity.TJ;

namespace TX_Almacen
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void frmColor_Load(object sender, EventArgs e)
        {
            psintypesel = 0;
            ListarColor();
            Permisos();
        }


        int psintypesel = 0;
        private void ListarColor()
        {
            //try
            //{
                EColor col = new EColor();
                if (psintypesel == 0)
                {
                    col.psintypesel = 0;
                    col.Id_color = txtidcolor.Text;
                    col.Ds_color = txtdsColor.Text;
                    col.IdEmpresa = wfChgEmpPer.datos.idEmpresa;


                    DataSet ds = BColor.GetListFill(col);
                    dgvDetalle_.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgvDetalle_.RowCount).ToString();
                }
                else if (psintypesel == 1)
                {
                    col.psintypesel = 1;
                    col.Id_color = txtidcolor.Text;
                    col.Ds_color = txtdsColor.Text;
                    col.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BColor.GetListFill(col);
                    dgvDetalle_.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgvDetalle_.RowCount).ToString();
                }

            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //}
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
            psintypesel = 0;
            ListarColor();
        }

        private void Grabar()
        {
            try
            {
                EColor CL = new EColor();
                DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (txtidcolor.Text == "")
                    {
                        List<Dato> oListDato = BColor.Color_qry06(wfChgEmpPer.datos.idEmpresa);
                        if (oListDato.Count > 0)
                        {
                            txtidcolor.Text = oListDato[0].id;
                            CL.Id_color = txtidcolor.Text;
                        }
                    
                    }
                    else
                    {
                        CL.Id_color = txtidcolor.Text;
                    }

                    CL.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    CL.Ds_color = txtdsColor.Text.ToUpper();
                    CL.Id_vtipcolor = "000";
                    CL.Fe_creacion = txtfecha.Value;
                    CL.Id_cartacol = "0000000";
                    CL.Nu_opcion = "0";
                    CL.Id_ucrearec = frmLogin.d.id.ToLower();
                    BColor.TJ_Color_mnt04(CL);
                    MessageBox.Show("Datos Grabados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtidcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                psintypesel = 0;
                ListarColor();
            }
        }

        private void txtdsColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                psintypesel = 0;
                ListarColor();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtidcolor.Clear();
            txtdsColor.Clear();
            txtdsColor.Focus();

            txtidcolor.Enabled = false;
            txtdsColor.Enabled = true;
            txtfecha.Enabled = true;

            psintypesel = 0;
            ListarColor();

        }

        private void dgvDetalle__DoubleClick(object sender, EventArgs e)
        {
            try
            {

                txtidcolor.Text = dgvDetalle_.CurrentRow.Cells["Item"].Value.ToString();
                txtdsColor.Text = dgvDetalle_.CurrentRow.Cells["Color"].Value.ToString();
                txtfecha.Text = dgvDetalle_.CurrentRow.Cells["fe_creacion"].Value.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtidcolor.Enabled = false;
            txtdsColor.Enabled = true;
            txtfecha.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Permisos()
        {
            try
            {

                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0001";

                EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnNuevo.Enabled = bool.Parse(usuarioo._btnNuevo);
                btnEditar.Enabled = bool.Parse(usuarioo._btnEditar);
                btnGrabar.Enabled = bool.Parse(usuarioo._btnGrabar);
                //btnImprimir.Enabled = bool.Parse(usuarioo._btnImprimir);
                //btnVistaPrevia.Enabled = bool.Parse(usuarioo._btnVistaPrevia);
                //btnBuscar.Enabled = bool.Parse(usuarioo._btnBuscar);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

    }
}
