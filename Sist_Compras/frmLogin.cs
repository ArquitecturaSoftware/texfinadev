using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

using Texfina.Core.Common;
using Texfina.ERP;
using Texfina.Entity.Sy;
using Texfina.BOQry.Sy;
using Texfina.Entity.Co;
namespace Sist_Compras
{
    public partial class frmLogin : Form
    {
        //public delegate void pasar(string dato);
        //public event pasar pasardo;
        public static Dato d;
        public frmLogin()
        {
            InitializeComponent();
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Usu = txtUser.Text.Trim();

            string password = txtPass.Text.Trim();


            EUsuario u = new EUsuario();

            // comparamos la infomacion si es igual al de mi base de datos 

            u.IdLogon = Usu;
            u.ds_password = password;


            EUsuario usuarioo;
            usuarioo = Usuarioco.UsuarioFill(u);


            try
            {
                if (usuarioo.StAnulado.ToString() == "0")
                {
                   

                   d = new Dato();
                   d.id = txtUser.Text;
                   d.dsu = usuarioo.DsNombres;

                  
                  
                    wfChgEmpPer frm = new wfChgEmpPer();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta. Inténtelo de nuevo", "Aviso");                   
                }
               
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
        }

        int ancho, alto;


        private void frmLogin_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

      
    }
}
