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
    public partial class frmCliente_qry : Form
    {
        public frmCliente_qry()
        {
            InitializeComponent();

            psintypesel = 1;
            ListarProveedor();
        }
        public delegate void pasar(ECliente prov);
        public event pasar pasard;

        ECliente prov = new ECliente();
        int psintypesel = 1;

        private void ListarProveedor()
        {
            try
            {

                if (psintypesel == 1)
                {
                    prov.psintypesel = 1;
                    prov.Ds_raznombre = txtdes.Text.Trim();
                    prov.Id_clipro = txtCodigo.Text.Trim();
                    prov.Nu_ruc = txtruc.Text.Trim();
                    prov.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 

                    DataSet ds = BCliente.ClienteFill(prov);
                    dgproveedor.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgproveedor.RowCount).ToString(); //-1
                }
                else if (psintypesel == 2)
                {
                    prov.psintypesel = 2;
                    prov.Ds_raznombre = txtdes.Text.Trim();
                    prov.Id_clipro = txtCodigo.Text.Trim();
                    prov.Nu_ruc = txtruc.Text.Trim();
                    prov.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 

                    DataSet ds = BCliente.ClienteFill(prov);
                    dgproveedor.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgproveedor.RowCount).ToString();//-1
                }

            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCliente_qry_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 2;
                    ListarProveedor();
                    //dgproveedor.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarProveedor();
                    dgproveedor.Focus();
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtruc.Text != "")
                {
                    psintypesel = 2;
                    ListarProveedor();
                    dgproveedor.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarProveedor();
                    dgproveedor.Focus();
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdes.Text != "")
                {
                    psintypesel = 2;
                    ListarProveedor();
                    dgproveedor.Focus();
                }
                else
                {
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (nuItem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdes.Focus();

                }
                else
                {

                    {
                        prov.Id_clipro = dgproveedor.CurrentRow.Cells["Codigo"].Value.ToString();

                        prov.Ds_raznombre = dgproveedor.CurrentRow.Cells["raszoc"].Value.ToString();

                        try
                        {
                            pasard(prov);
                        }
                        catch (Exception ex)
                        {

                        }

                       
                        this.Dispose();

                    }
                    e.SuppressKeyPress = true;

                }
            }
        }



        private void dgproveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                prov.Id_clipro = dgproveedor.CurrentRow.Cells["Codigo"].Value.ToString();

                prov.Ds_raznombre = dgproveedor.CurrentRow.Cells["raszoc"].Value.ToString();

                pasard(prov);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.ToString();


            }
           
                      

            this.Dispose();
        }

        private void frmCliente_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarProveedor();
            dgproveedor.Focus();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

    }
}
