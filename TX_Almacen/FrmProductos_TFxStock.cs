using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmProductos_TFxStock : Form
    {
        public FrmProductos_TFxStock()
        {
            InitializeComponent();
        }

        private void FrmProductos_TFxStock_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarIngreso();
        }
        int psintypesel = 0;
        private void ListarIngreso()
        {
            try
            {
                EIngresoDetalle obj = new EIngresoDetalle();
                if (psintypesel == 1)
                {
                    obj.psintypesel = 1;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.ds_clipro = txt_cliente.Text;

                    //if (chkvendedor.Checked == true)
                    //{
                    //    obj.Ds_Vendedor = txtds_vendedor.Text;
                    //}
                    //else
                    //{
                    //    obj.Ds_Vendedor = frmLogin.d.dsu;
                    //}
                    obj.Ds_Vendedor = txtds_vendedor.Text;
                    obj.ds_producto = txt_producto.Text;
                    obj.ds_color = txtds_color.Text;
                    obj.Nu_tf = txtnu_tf.Text;
                    DataSet ds = BIngreso_Detalle.AL_Ingreso_Detalle_Stock_TF(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    //nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();
                }

                else if (psintypesel == 2)
                {
                    obj.psintypesel = 2;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.ds_clipro = txt_cliente.Text;

                    //if (chkvendedor.Checked == true)
                    //{
                    //    obj.Ds_Vendedor = txtds_vendedor.Text;
                    //}
                    //else
                    //{
                    //    obj.Ds_Vendedor = frmLogin.d.dsu;
                    //}
                    obj.Ds_Vendedor = txtds_vendedor.Text;
                    obj.ds_color = txtds_color.Text;
                    obj.Nu_tf = txtnu_tf.Text;

                    DataSet ds = BIngreso_Detalle.AL_Ingreso_Detalle_Stock_TF(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    //nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();
                }
            }
            catch (Exception EX)
            {
                EX.ToString();
            }

        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (txt_cliente.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_producto.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtds_color_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtds_color.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtds_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtds_vendedor.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chkvendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvendedor.Checked == true)
            {
                txtds_vendedor.Text = "Texfina";
            }
            else
            {
                txtds_vendedor.Text = "";
            }
        }



        public object Get_ExportarStock(string key)
        {

            EIngresoDetalle obj = new EIngresoDetalle();

            obj.psintypesel = 1;
            obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            obj.ds_clipro = txt_cliente.Text;

            //if (chkvendedor.Checked == true)
            //{
            //    obj.Ds_Vendedor = txtds_vendedor.Text;
            //}
            //else
            //{
            //    obj.Ds_Vendedor = frmLogin.d.dsu;
            //}
            obj.Ds_Vendedor = txtds_vendedor.Text;
            obj.ds_producto = txt_producto.Text;
            obj.ds_color = txtds_color.Text;
            obj.Nu_tf = txtnu_tf.Text;


            BIngreso_Detalle _obj = new BIngreso_Detalle();
            DataTable dt = _obj._AL_Ingreso_Detalle_Stock_TF(obj);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }
        public void ExportReporStock(string key)
        {
            DataSet ds = (DataSet)this.Get_ExportarStock(key);
            //DataSet ds = (DataSet)this.GetDataReport(key);

            //ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\DATA.xls", ds);

            //MessageBox.Show("Registros Exportados", "Advertencia", MessageBoxButtons.OK);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 1;
            ListarIngreso();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportReporStock("");
        }

        private void txtnu_tf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnu_tf.Text = txtnu_tf.Text.PadLeft(7, '0');
                if (txtnu_tf.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgProducto.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgProducto.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
