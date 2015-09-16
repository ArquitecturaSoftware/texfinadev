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
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class frmPersonal_qry : Form
    {
        public frmPersonal_qry()
        {
            InitializeComponent();
        }
        int psintypesel = 1;
        string Id_pers_;
        string ds_pers_;

        public delegate void pasar(string idPers, string dsPers);
        public event pasar pasard;

        private void ListarPersonal()
        {
            try
            {
                EPersonalBandeja per = new EPersonalBandeja();
                if (psintypesel == 1)
                {
                    per.psintypesel = 1;
                    per.IdPersonal = txtCodigo.Text;
                    per.NuDocIden = txtdni.Text;
                    per.DsApellNom = txtapenom.Text;
                    DataSet ds = BPersonalBandeja.GetListFill(per);
                    dgvPersonal.DataSource = ds.Tables[0];

                    lblnutot.Text = Convert.ToInt16(dgvPersonal.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                    per.psintypesel = 2;
                    per.IdPersonal = txtCodigo.Text;
                    per.NuDocIden = txtdni.Text;
                    per.DsApellNom = txtapenom.Text;


                    DataSet ds = BPersonalBandeja.GetListFill(per);
                    dgvPersonal.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgvPersonal.RowCount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPersonal_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 1;
            ListarPersonal();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 2;
                    ListarPersonal();
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
                    ListarPersonal();
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
                    ListarPersonal();
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
                Id_pers_ = dgvPersonal.CurrentRow.Cells["idPersonal"].Value.ToString();

                ds_pers_ = dgvPersonal.CurrentRow.Cells["dsRazSocial"].Value.ToString();

                pasard(Id_pers_, ds_pers_);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmPersonal_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvPersonal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvPersonal.BeginEdit(false);
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

                        Id_pers_ = dgvPersonal.CurrentRow.Cells["idPersonal"].Value.ToString();

                        ds_pers_ = dgvPersonal.CurrentRow.Cells["dsRazSocial"].Value.ToString();

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
    }
}
