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
using Texfina.Entity.Sy;
using Texfina.DOQry.Sy;
namespace TX_Almacen
{
    public partial class FrmMdi_AL : Form
    {
        public FrmMdi_AL()
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

        private void ToolCliente_Click(object sender, EventArgs e)
        {
            //frnCliente frm = new frnCliente();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmCliente)
                {
                    childForm = (frmCliente)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmCliente();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }


        }

        private void ToolColor_Click(object sender, EventArgs e)
        {
            //frmColor frm = new frmColor();
            //frm.MdiParent = this;
            //OpenSubForm(frm);

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmColor)
                {
                    childForm = (frmColor)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmColor();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }


        }

        private void ToolIngresoInv_Click(object sender, EventArgs e)
        {
            //frmIngreso frm = new frmIngreso();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmIngreso)
                {
                    childForm = (frmIngreso)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmIngreso();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            //frmIngreso frm = new frmIngreso();
            //frm.MdiParent = this;
            //OpenSubForm(frm);

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmIngreso)
                {
                    childForm = (frmIngreso)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmIngreso();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            //frmColor frm = new frmColor();
            //frm.MdiParent = this;
            //OpenSubForm(frm);

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmColor)
                {
                    childForm = (frmColor)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmColor();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }

            


        }

        private void toolactualizarpeso_Click(object sender, EventArgs e)
        {
            //FrmIngresoUpdate_kg frm = new FrmIngresoUpdate_kg();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmIngresoUpdate_kg)
                {
                    childForm = (FrmIngresoUpdate_kg)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmIngresoUpdate_kg();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }

        }

        private void toolordenDePedido_Click(object sender, EventArgs e)
        {         

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmOrdenPedidoMnt)
                {
                    childForm = (frmOrdenPedidoMnt)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmOrdenPedidoMnt();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }


        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            //FrmIngresoUpdate_kg frm = new FrmIngresoUpdate_kg();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmIngresoUpdate_kg)
                {
                    childForm = (FrmIngresoUpdate_kg)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmIngresoUpdate_kg();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }

        }

        private void btnOrdenPedido_Click(object sender, EventArgs e)
        {
            //FrmOrdenPedido_mnt frm = new FrmOrdenPedido_mnt();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmOrdenPedidoMnt)
                {
                    childForm = (frmOrdenPedidoMnt)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmOrdenPedidoMnt();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }


        }

        private void ToolautorizarOP_Click(object sender, EventArgs e)
        {
            //FrmAutorizacionOP frm = new FrmAutorizacionOP();
            //frm.MdiParent = this;
            //OpenSubForm(frm);



            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmAutorizacionOP)
                {
                    childForm = (FrmAutorizacionOP)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmAutorizacionOP();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }

        }

        private void ToolaprobarOP_Click(object sender, EventArgs e)
        {
            //FrmAprobacionOP frm = new FrmAprobacionOP();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmAprobacionMnt)
                {
                    childForm = (frmAprobacionMnt)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmAprobacionMnt();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            //FrmSalida frm = new FrmSalida();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmSalida)
                {
                    childForm = (FrmSalida)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmSalida();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }


        }

        private void Toolstock_Click(object sender, EventArgs e)
        {
            //FrmProductos_Stock frm = new FrmProductos_Stock();
            //frm.MdiParent = this;
            //OpenSubForm(frm);


            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmProductos_Stock)
                {
                    childForm = (FrmProductos_Stock)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmProductos_Stock();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            //FrmProductos_Stock frm = new FrmProductos_Stock();
            //frm.MdiParent = this;
            //OpenSubForm(frm);

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmProductos_Stock)
                {
                    childForm = (FrmProductos_Stock)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmProductos_Stock();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolordenesDePedidoPendiente_Click(object sender, EventArgs e)
        {
            //FrmOrdenPedido_qry02 frm = new FrmOrdenPedido_qry02();
            //frm.MdiParent = this;
            //OpenSubForm(frm);

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmOrdenPedido_qry02)
                {
                    childForm = (FrmOrdenPedido_qry02)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmOrdenPedido_qry02();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }

        }

        private void Permisos()
        {
            try
            {

                string Usu = frmLogin.d.idUser;
                string menu = "03";
                string ifFormulario = "0001";

                EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = Usu;
                u.IdModulo = menu;
                u.Id_formulario = ifFormulario;

                EControlUsuario usuarioo;
                
                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolaprobarOP.Enabled = bool.Parse(usuarioo._btnForm);
                
                //-------------------------------------------------------------

                //EControlUsuario u = new EControlUsuario();
                // comparamos la infomacion si es igual al de mi base de datos 

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0002";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolautorizarOP.Enabled = bool.Parse(usuarioo._btnForm);
                
                //----------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0003";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolCliente.Enabled = bool.Parse(usuarioo._btnForm);
                

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0004";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                toolordenDePedido.Enabled = bool.Parse(usuarioo._btnForm);
                btnOrdenPedido.Enabled = bool.Parse(usuarioo._btnForm);

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0005";

                //EControlUsuario usuarioo;
                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolordenesDePedidoPendiente.Enabled = bool.Parse(usuarioo._btnForm);

                //-----------------------------------------
                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0006";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolSalidaInv.Enabled = bool.Parse(usuarioo._btnForm);
                btnSalida.Enabled = bool.Parse(usuarioo._btnForm);
               
                //-----------------------------------------
                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0007";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolautorizarOP2.Enabled = bool.Parse(usuarioo._btnForm);


                //-----------------------------------------
                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "03";
                u.Id_formulario = "0008";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolliberarOP.Enabled = bool.Parse(usuarioo._btnForm);
                btnLiberarOP.Enabled = bool.Parse(usuarioo._btnForm);

                //----------------------------
                
                //u.IdUser = frmLogin.d.idUser;
                //u.IdModulo = "03";
                //u.Id_formulario = "0006";

            
                //usuarioo = DControlUsuario.UsuarioFill(u);
                //Toolstock.Enabled = bool.Parse(usuarioo._btnForm);
                //btnStock.Enabled = bool.Parse(usuarioo._btnForm);
                
                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0001";

                usuarioo = DControlUsuario.UsuarioFill(u);
                btnColor.Enabled = bool.Parse(usuarioo._btnForm);
                ToolColor.Enabled = bool.Parse(usuarioo._btnForm);

                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0002";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolIngresoInv.Enabled = bool.Parse(usuarioo._btnForm);
                btnIngreso.Enabled = bool.Parse(usuarioo._btnForm);


                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0003";

                usuarioo = DControlUsuario.UsuarioFill(u);
                toolactualizarpeso.Enabled = bool.Parse(usuarioo._btnForm);
                btnActualizarStock.Enabled = bool.Parse(usuarioo._btnForm);


                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0004";

                usuarioo = DControlUsuario.UsuarioFill(u);
                Toolstock.Enabled = bool.Parse(usuarioo._btnForm);
                btnStock.Enabled = bool.Parse(usuarioo._btnForm);


                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0005";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolSalidaInv.Enabled = bool.Parse(usuarioo._btnForm);
                btnSalida.Enabled = bool.Parse(usuarioo._btnForm);

                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0006";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolProducto.Enabled = bool.Parse(usuarioo._btnForm);
                btnColor.Enabled = bool.Parse(usuarioo._btnForm);

                //-----------------------------------------

                u.IdUser = frmLogin.d.idUser;
                u.IdModulo = "04";
                u.Id_formulario = "0007";

                usuarioo = DControlUsuario.UsuarioFill(u);
                ToolstockPorPartida.Enabled = bool.Parse(usuarioo._btnForm);
               // btnColor.Enabled = bool.Parse(usuarioo._btnForm);

            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }

        private void ToolCliente_rpt_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmCliente_rpt01)
                {
                    childForm = (FrmCliente_rpt01)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmCliente_rpt01();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolingresoInventario_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmIngreso_Detalle_rpt01)
                {
                    childForm = (FrmIngreso_Detalle_rpt01)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmIngreso_Detalle_rpt01();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolProducto_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmTejido_mnt)
                {
                    childForm = (FrmTejido_mnt)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmTejido_mnt();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolautorizarOP2_Click(object sender, EventArgs e)
        {

            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmAutorizacion2OP)
                {
                    childForm = (FrmAutorizacion2OP)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmAutorizacion2OP();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolliberarOP_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmLiberarOP)
                {
                    childForm = (FrmLiberarOP)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmLiberarOP();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnLiberarOP_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmLiberarOP)
                {
                    childForm = (FrmLiberarOP)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmLiberarOP();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void ToolstockPorPartida_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmProductos_TFxStock)
                {
                    childForm = (FrmProductos_TFxStock)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmProductos_TFxStock();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void FrmMdi_AL_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolsalidaDeInventario_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is Frm_Salida_Detalle_rpt01)
                {
                    childForm = (Frm_Salida_Detalle_rpt01)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new Frm_Salida_Detalle_rpt01();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnStockTF_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is FrmProductos_StockTF)
                {
                    childForm = (FrmProductos_StockTF)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new FrmProductos_StockTF();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }

        private void btnAnticipos_Click(object sender, EventArgs e)
        {
            Form childForm = null;
            foreach (Form f in this.MdiChildren)
            {
                if (f is frmAnticiposMnt)
                {
                    childForm = (frmAnticiposMnt)f;
                    break;
                }
                else
                {
                    f.WindowState = FormWindowState.Minimized;
                    f.Show();
                }

            }

            if (childForm != null)
            {
                childForm.Focus();
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                childForm = new frmAnticiposMnt();
                childForm.MdiParent = this;
                OpenSubForm(childForm);
            }
        }
    }
}
