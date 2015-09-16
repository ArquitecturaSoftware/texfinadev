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
using Texfina.DOQry.Sy;
using Texfina.Entity.Sy;

namespace TX_Terjeduria
{
    public partial class FrmMdi_TJ : Form
    {
        public FrmMdi_TJ()
        {
            InitializeComponent();
        }

        private Boolean OpenSubForm(Form form)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == form.Name)
                {
                    return false;
                }
            }
            form.Show();
            return true;
        }
        private void BuildTreeMenu()
        {
            DataTable dt = new DataTable();

            BGeneral.ObtenerDatoMenuPrincipal();

            foreach (DataRow dr in dt.Rows)
            {

            }
        }

        private void FrmMdi_TJ_Load(object sender, EventArgs e)
        {
            lblusuario.Text = frmLogin.d.id;
            lblNomape.Text = frmLogin.d.dsu;
            lblEmpresa.Text = wfChgEmpPer.datos.dsEmpresa;
            lblperiodo.Text = wfChgEmpPer.datos.idperiodo;

            DateTime fecha = DateTime.Now;
            lblfecha.Text = fecha.ToString("d");
            Permisos();
        }

        private void ToolTela_Click(object sender, EventArgs e)
        {
            FrmTejeduria_mnt tj = new FrmTejeduria_mnt();
            tj.MdiParent = this;
            OpenSubForm(tj);
        }

        private void ventanaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ventanaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ToolSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Toolproducto_Click(object sender, EventArgs e)
        {
            FrmTejido_mnt pr = new FrmTejido_mnt();
            pr.MdiParent = this;
            OpenSubForm(pr);
        }

        private void ToolactualizarTela_Click(object sender, EventArgs e)
        {
            FrmTejeduriaRutaProces frm = new FrmTejeduriaRutaProces();
            frm.MdiParent = this;
            OpenSubForm(frm);
        }

        private void btnTela_Click(object sender, EventArgs e)
        {
            FrmTejeduria_mnt tj = new FrmTejeduria_mnt();
            tj.MdiParent = this;
            OpenSubForm(tj);
        }

        private void btnActualizarTela_Click(object sender, EventArgs e)
        {
            FrmTejeduriaRutaProces frm = new FrmTejeduriaRutaProces();
            frm.MdiParent = this;
            OpenSubForm(frm);
        }

        private void ToolmuestrasEtiqueta_Click(object sender, EventArgs e)
        {
            FrmMuestrasEtiqueta_mnt frm = new FrmMuestrasEtiqueta_mnt();
            frm.MdiParent = this;
            OpenSubForm(frm);

        }

        private void btnEtiquetaMuestras_Click(object sender, EventArgs e)
        {
            FrmMuestrasEtiqueta_mnt frm = new FrmMuestrasEtiqueta_mnt();
            frm.MdiParent = this;
            OpenSubForm(frm);

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
                btnTela.Enabled = bool.Parse(usuarioo._btnForm);
                ToolTela.Enabled = bool.Parse(usuarioo._btnForm);
                //-------------------------------------------------------------


            

                //EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "01";
                u.Id_formulario = "0003";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                btnActualizarTela.Enabled = bool.Parse(usuarioo._btnForm);
                ToolactualizarTela.Enabled = bool.Parse(usuarioo._btnForm);
                //----------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "01";
                u.Id_formulario = "0004";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                Toolproducto.Enabled = bool.Parse(usuarioo._btnForm);

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "05";
                u.Id_formulario = "0001";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolmuestrasEtiqueta.Enabled = bool.Parse(usuarioo._btnForm);
                btnEtiquetaMuestras.Enabled = bool.Parse(usuarioo._btnForm);
                
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        private void FrmMdi_TJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

      

      
    }
}
