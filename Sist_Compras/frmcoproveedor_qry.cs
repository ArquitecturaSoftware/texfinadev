using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.Core.Web;
using Texfina.Core.Common;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using Texfina.BOQry.Co;
using Sist_Compras.Properties;

namespace Sist_Compras
{
    public partial class frmcoproveedor_qry : Form
    {
        public delegate void pasar(EProveedor prov);
        public event pasar pasard;

        EProveedor prov = new EProveedor();
        int  psintypesel = 1;

        public frmcoproveedor_qry()
        {
            InitializeComponent();
        }
        int ancho, alto;


        private void frmcoproveedor_qry_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;
            
            psintypesel = 1;
            ListarProveedor();
        
        }

        private void ListarProveedor()
        {
            try
            {

                if (psintypesel == 1) 
                {
                    prov.psintypesel = 1;
                    prov.Ds_raznombre = txtrs.Text.Trim();
                    prov.Id_clipro = txtCodigo.Text.Trim();
                    prov.Nu_ruc = txtruc.Text.Trim();
                    prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;
         
                    DataSet ds = BProveedor.ProveedorFill(prov);
                    dgproveedor.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgproveedor.RowCount ).ToString(); //-1
                }
                else if (psintypesel == 2)
                {
                    prov.psintypesel = 2;
                    prov.Ds_raznombre = txtrs.Text.Trim();
                    prov.Id_clipro = txtCodigo.Text.Trim();
                    prov.Nu_ruc = txtruc.Text.Trim();
                    prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BProveedor.ProveedorFill(prov);
                    dgproveedor.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgproveedor.RowCount ).ToString();//-1
                }

            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
               MessageBox.Show(ex.ToString(),"Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        public object FormParent { get; set; }

  

        private void txtrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtrs.Text != "")
                {
                    psintypesel = 2;
                    ListarProveedor();
                    dgproveedor.Focus();
                }
                else {
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void dgproveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                prov.Id_clipro = dgproveedor.CurrentRow.Cells["Codigo"].Value.ToString();

                prov.Ds_raznombre = dgproveedor.CurrentRow.Cells["raszoc"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //pasard(prov);
            try
            {
                pasard(prov);
            }
            catch (Exception ex)
            {

            }

            try
            {
                FrmCOreporteOCxProv frmFormularioAnterior = (FrmCOreporteOCxProv)FormParent;
                frmFormularioAnterior.LlenarGrilla(prov, this);

            }
            catch (Exception ex)
            {

            }

            this.Dispose();
        }

        private void frmcoproveedor_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmcoproveedor_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        } 

        private void dgproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (lblRow_total.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrs.Focus();

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

                        try
                        {
                            FrmCOreporteOCxProv frmFormularioAnterior = (FrmCOreporteOCxProv)FormParent;
                            frmFormularioAnterior.LlenarGrilla(prov, this);

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

      
    }
}
