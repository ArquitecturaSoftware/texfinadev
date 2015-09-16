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
    public partial class FrmListadoPrecio_qry : Form
    {
        public FrmListadoPrecio_qry()
        {
            InitializeComponent();
        }

        public delegate void pasar(ElistPrecio_Detalle ID);
        public event pasar pasard;
        public string _lblproducto;

        int psintypesel = 0;
        private void ListarPrecio()
        {
            try
            {
                ElistPrecio_Detalle obj = new ElistPrecio_Detalle();
                if (psintypesel == 1)
                {
                    obj.psintypesel = 1;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    if (_lblproducto != "")
                    {
                        obj.ds_producto = _lblproducto;
                    }
                    else
                    {
                        obj.ds_producto = txt_producto.Text;
                    }
                    obj.NuTF = txt_nutf.Text;
                    DataSet ds = BlistPrecio_Detalle.AL_ListaPrecio_qry(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                    obj.psintypesel = 2;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    if (_lblproducto != "")
                    {
                        obj.ds_producto = _lblproducto;
                    }
                    else
                    {
                        obj.ds_producto = txt_producto.Text;
                    }

                    obj.NuTF = txt_nutf.Text;

                    DataSet ds = BlistPrecio_Detalle.AL_ListaPrecio_qry(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmListadoPrecio_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarPrecio();
        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_producto.Text != "")
                {
                    psintypesel = 1;
                    ListarPrecio();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarPrecio();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_nutf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_nutf.Text != "")
                {
                    psintypesel = 1;
                    ListarPrecio();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarPrecio();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgProducto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ElistPrecio_Detalle obj = new ElistPrecio_Detalle();



                obj.Precio_mnt = Convert.ToDecimal(dgProducto.CurrentRow.Cells["precio_mnt"].Value);
                pasard(obj);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgProducto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgProducto.BeginEdit(false);
        }

        private void dgProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (nuItem.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_producto.Focus();
                }
                else
                {

                    ElistPrecio_Detalle obj = new ElistPrecio_Detalle();



                    obj.Precio_mnt = Convert.ToDecimal(dgProducto.CurrentRow.Cells["precio_mnt"].Value);
                    pasard(obj);

                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void FrmListadoPrecio_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
