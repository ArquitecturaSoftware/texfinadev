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
using Texfina.Core.Common;
using Texfina.Core.Data;
using Texfina.Core.Web;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;
using SYBOQry = Texfina.BOQry.Sy;
namespace TX_Terjeduria
{
    public partial class wfChgEmpPer : Form
    {

        public static Dato datos;

        public wfChgEmpPer()
        {
            InitializeComponent();

            CargarEmpresa();
            //CargarModulo();
        }
        private void CargarEmpresa()
        {
            //EUsuario objE = new EUsuario();

            WebHelper.LoadListControl3(cbEmpresa, BGeneral.ObtenerDatoEmpresa(""));

            Dato d = new Dato();
            d.id = cbEmpresa.SelectedValue.ToString();

            cbPeriodo.DataSource = BGeneral.ObtenerDatoEmpresaPeriodo(d);
            cbPeriodo.DisplayMember = "idPeriodo";
            cbPeriodo.ValueMember = "idPeriodo";

            DateTime thisDay = DateTime.Today;
            cbPeriodo.SelectedValue = thisDay.Year.ToString();
         
           

        }


        //private void CargarModulo()
        //{
        //    Dato d = new Dato();
        //    d.idLogon = frmLogin.d.id;

        //    cbModulo.DataSource = BGeneral.ObtenerModulo(d);
        //    cbModulo.DisplayMember = "dsMenu";
        //    cbModulo.ValueMember = "dsWebPage";
        //}

        private void wfChgEmpPer_Load(object sender, EventArgs e)
        {

            txtusuario.Text = frmLogin.d.id;

            cbEmpresa.Focus();
        }

        private void cbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dato d = new Dato();
            d.id = cbEmpresa.SelectedValue.ToString();

            cbPeriodo.DataSource = BGeneral.ObtenerDatoEmpresaPeriodo(d);
            cbPeriodo.DisplayMember = "idPeriodo";
            cbPeriodo.ValueMember = "idPeriodo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbEmpresa.Text != "" && cbPeriodo.Text != "")
            {
                datos = new Dato();
                datos.idEmpresa = cbEmpresa.SelectedValue.ToString();
                datos.idperiodo = cbPeriodo.SelectedValue.ToString();
                datos.dsEmpresa = cbEmpresa.Text;


                FrmMdi_TJ mdi = new FrmMdi_TJ();
                mdi.Show();

                this.Dispose();

               


            }
            else
            {
                MessageBox.Show("Falta Ingresar Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cbEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Dato d = new Dato();
                d.id = cbEmpresa.SelectedValue.ToString();

                cbPeriodo.DataSource = BGeneral.ObtenerDatoEmpresaPeriodo(d);
                cbPeriodo.DisplayMember = "idPeriodo";
                cbPeriodo.ValueMember = "idPeriodo";
                cbPeriodo.Focus();
            }
        }

        private void cbPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                btnAceptar.Focus();


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbEmpresa.Focus();
            }
        }

        private void cbModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }

    

        
    }
}
