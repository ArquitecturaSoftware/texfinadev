using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.Entity.Sy;
using Texfina.BOQry.Sy;

namespace TX_Sistema
{
    public partial class FrmUsuario_qry : Form
    {
        public delegate void pasar(EUsuario prov);
        public event pasar pasard;
        public FrmUsuario_qry()
        {
            InitializeComponent();
        }


        private void ListarUsuario()
        {
            try
            {
                EUsuario u = new EUsuario();
                u.DsNombres = txtdsNombre.Text;
                DataSet ds = Usuarioco.GetListUsuario(u);
                dgvDetalle.DataSource = ds.Tables[0];
                lblnumitem.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void FrmUsuario_qry_Load(object sender, EventArgs e)
        {
            ListarUsuario();         
           
        }

        private void txtdsNombre_TextChanged(object sender, EventArgs e)
        {
            //ListarUsuario();
        }

        private void txtdsNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ListarUsuario();

                dgvDetalle.Focus();
            }
        }

        private void dgvDetalle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvDetalle.BeginEdit(false);
        }

        private void dgvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblnumitem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdsNombre.Focus();
                }
                else
                {
                    EUsuario u = new EUsuario();
                    u.IdUser = dgvDetalle.CurrentRow.Cells["idUser"].Value.ToString();
                    u.IdLogon = dgvDetalle.CurrentRow.Cells["idLogon"].Value.ToString();
                    u.DsNombres = dgvDetalle.CurrentRow.Cells["dsNombres"].Value.ToString();
                    u.StAnulado = dgvDetalle.CurrentRow.Cells["stAnulado"].Value.ToString();
                   

                    pasard(u);


                    this.Dispose();


                    e.SuppressKeyPress = true;
                }

            }
        }
    }
}
