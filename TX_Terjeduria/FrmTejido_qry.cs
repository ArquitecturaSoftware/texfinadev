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
using Texfina.Entity.Co;

namespace TX_Terjeduria
{
    public partial class FrmTejido_qry : Form
    {

        public delegate void pasar(EDetProducto prd);
        public event pasar pasard;

        int psintypesel = 0;

        public FrmTejido_qry()
        {
            InitializeComponent();
        }


        private void ListarProducto()
        {
            try
            {
                EProducto prod = new EProducto();
                if (psintypesel == 1)
                {
                    prod.psintypesel = 1;
                    prod.Id_producto = txtCodigo.Text;
                    prod.Ds_producto = txtdescripcion.Text;
                    //prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    prod.Ds_prese = txtpresentacion.Text;
                    DataSet ds = BTejido.GetListFill(prod);
                    dgproducto.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgproducto.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                    prod.psintypesel = 2;
                    prod.Id_producto = txtCodigo.Text;
                    prod.Ds_producto = txtdescripcion.Text;
                    //prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    prod.Ds_prese = txtpresentacion.Text;
                    DataSet ds = BTejido.GetListFill(prod);
                    dgproducto.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgproducto.RowCount).ToString();
                }
               
            }
            catch (Exception ex)
            {
               
            }
        }
        int ancho, alto;


        private void Frmproducto_qry_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;
            psintypesel = 2;
            ListarProducto();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 1;
                    ListarProducto();
                    dgproducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarProducto();
                    dgproducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdescripcion.Text != "")
                {
                    psintypesel = 1;
                    ListarProducto();

                    dgproducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarProducto();

                    dgproducto.Focus();

                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtpresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtpresentacion.Text != "")
                {
                    psintypesel = 1;
                    ListarProducto();

                    dgproducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarProducto();

                    dgproducto.Focus();

                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

      
    

        private void dgproducto_DoubleClick(object sender, EventArgs e)
        {
            try
            { 
            EDetProducto prd = new EDetProducto();
                prd._Producto = dgproducto.CurrentRow.Cells["Producto"].Value.ToString();
                prd._Codigo = dgproducto.CurrentRow.Cells["Codigo"].Value.ToString();
                prd._Pres = dgproducto.CurrentRow.Cells["idPresentacion"].Value.ToString();
                prd._Presenta = dgproducto.CurrentRow.Cells["Presenta"].Value.ToString();
                prd._UM = dgproducto.CurrentRow.Cells["UM"].Value.ToString();
                prd._Peso_Bruto = Convert.ToDecimal(dgproducto.CurrentRow.Cells["Peso_Bruto"].Value.ToString());
                prd._id_tipgstimp = dgproducto.CurrentRow.Cells["Id_Tipgasto"].Value.ToString();
                prd._Tipgasto = dgproducto.CurrentRow.Cells["Tipo_gasto"].Value.ToString();

                pasard(prd);
                this.Dispose();
              }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }

        private void Frmproducto_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Frmproducto_qry_Resize(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(ancho, alto);


        }

        private void dgproducto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgproducto.BeginEdit(false);
        }

        private void dgproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (lblnutot.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescripcion.Focus();
                }
                else
                {

                    EDetProducto prd = new EDetProducto();
                    prd._Producto = dgproducto.CurrentRow.Cells["Producto"].Value.ToString();
                    prd._Codigo = dgproducto.CurrentRow.Cells["Codigo"].Value.ToString();
                    prd._Pres = dgproducto.CurrentRow.Cells["idPresentacion"].Value.ToString();
                    prd._Presenta = dgproducto.CurrentRow.Cells["Presenta"].Value.ToString();
                    prd._UM = dgproducto.CurrentRow.Cells["UM"].Value.ToString();
                    prd._Peso_Bruto = Convert.ToDecimal(dgproducto.CurrentRow.Cells["Peso_Bruto"].Value.ToString());
                    prd._id_tipgstimp = dgproducto.CurrentRow.Cells["Id_Tipgasto"].Value.ToString();
                    prd._Tipgasto = dgproducto.CurrentRow.Cells["Tipo_gasto"].Value.ToString();

                    pasard(prd);
                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
