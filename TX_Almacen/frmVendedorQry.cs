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
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class frmVendedorQry : Form
    {
        public frmVendedorQry()
        {
            InitializeComponent();
        }

        private void frmVendedorQry_Load(object sender, EventArgs e)
        {
            psintypesel = 1;
            ListarVendedor();
        }

        
        /// Iniciallizando Variables para el sistema
        
        int psintypesel = 1;
        string Id_pers_;
        string ds_pers_;

        public delegate void pasar(string idPers, string dsPers);
        public event pasar pasard;
        private void ListarVendedor()
        {
            try
            {
                EVendedor vn = new EVendedor();
                if (psintypesel == 1)
                {
                    vn.psintypesel = 1;
                    vn.Id_Vendedor = txtCodigo.Text;
                    vn.Nu_dni = txtdni.Text;
                    vn.Ds_razsoc = txtapenom.Text;
                    DataSet ds = BVendedor.MG_Vendedor_qry01(vn);
                    dgvPersonal.DataSource = ds.Tables[0];

                    lblnutot.Text = Convert.ToInt16(dgvPersonal.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
               
                    vn.psintypesel = 2;
                    vn.Id_Vendedor = txtCodigo.Text;
                    vn.Nu_dni = txtdni.Text;
                    vn.Ds_razsoc = txtapenom.Text;


                    DataSet ds = BVendedor.MG_Vendedor_qry01(vn);
                    dgvPersonal.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgvPersonal.RowCount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 2;
                    ListarVendedor();
                    dgvPersonal.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdni.Text != "")
                {
                    psintypesel = 2;
                    ListarVendedor();
                    dgvPersonal.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtapenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtapenom.Text != "")
                {
                    psintypesel = 2;
                    ListarVendedor();
                    dgvPersonal.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Id_pers_ = dgvPersonal.CurrentRow.Cells["id_Vendedor"].Value.ToString();

                ds_pers_ = dgvPersonal.CurrentRow.Cells["dsRazsocial"].Value.ToString();

                pasard(Id_pers_, ds_pers_);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (lblnutot.Text == "0")
                    {
                        MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtapenom.Focus();
                    }
                    else
                    {

                        Id_pers_ = dgvPersonal.CurrentRow.Cells["id_Vendedor"].Value.ToString();

                        ds_pers_ = dgvPersonal.CurrentRow.Cells["dsRazsocial"].Value.ToString();

                        pasard(Id_pers_, ds_pers_);
                        this.Dispose();
                        e.SuppressKeyPress = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void dgvPersonal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvPersonal.BeginEdit(false);
        }

        private void FrmVendedor_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarVendedor();
            dgvPersonal.Focus();
        }
    }
}
