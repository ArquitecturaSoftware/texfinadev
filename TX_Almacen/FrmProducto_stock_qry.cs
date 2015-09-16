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
    public partial class FrmProducto_stock_qry : Form
    {
        public FrmProducto_stock_qry()
        {
            InitializeComponent();
        }

        public delegate void pasar(EIngresoDetalle ID);
        public event pasar pasard;
        public string _dscliente,_dsvendedor;
 

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

                    if (_dscliente.ToString() != "")
                    {
                        if (_dsvendedor.ToString() != "")
                        {
                            if (chk_cliente.Checked == true)
                            {

                                obj.ds_clipro = txt_cliente.Text;
                                obj.Ds_Vendedor = txt_vendedor.Text;
                            }
                            else
                            {

                                obj.ds_clipro = _dscliente;
                                obj.Ds_Vendedor = _dsvendedor;
                                //obj.Ds_Vendedor = txt_vendedor.Text;

                            }
                        }
                        else
                        {
                            obj.Ds_Vendedor = "Texfina";
                        }

                    }
                    else
                    {
                        if (chk_cliente.Checked == true)
                        {
                            obj.ds_clipro = txt_cliente.Text;
                            obj.Ds_Vendedor = txt_vendedor.Text;
                        }
                        else
                        {
                            obj.ds_clipro = txt_cliente.Text;
                            obj.Ds_Vendedor = "";
                        }
                    }


                    obj.ds_producto = txt_producto.Text;
                    obj.ds_color = txtds_color.Text;

                    DataSet ds = BIngreso_Detalle.AL_Producto_Stock(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();

                }

                else if (psintypesel == 2)
                {

                    obj.psintypesel = 2;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    if (_dscliente.ToString() != "")
                    {
                        if (_dsvendedor.ToString() != "")
                        {
                            if (chk_cliente.Checked == true)
                            {

                                obj.ds_clipro = txt_cliente.Text;
                                obj.Ds_Vendedor = "Texfina";
                            }
                            else
                            {

                                obj.ds_clipro = _dscliente;
                                obj.Ds_Vendedor = _dsvendedor;
                                //obj.Ds_Vendedor = txt_vendedor.Text;
                            }
                        }
                        else
                        {
                            obj.Ds_Vendedor = "Texfina";
                        }

                    }
                    else
                    {
                        if (chk_cliente.Checked == true)
                        {
                            obj.ds_clipro = txt_cliente.Text;
                            obj.Ds_Vendedor = txt_vendedor.Text;
                        }
                        else
                        {
                            obj.ds_clipro = txt_cliente.Text;
                            obj.Ds_Vendedor = _dsvendedor;
                        }
                    }



                    obj.ds_color = txtds_color.Text;
                    DataSet ds = BIngreso_Detalle.AL_Producto_Stock(obj);
                    dgProducto.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgProducto.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmProducto_stock_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarIngreso();
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

        private void txt_vendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txt_vendedor.Text != "")
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

        private void dgIngreso_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EIngresoDetalle obj = new EIngresoDetalle();
                obj.Id_clipro = dgProducto.CurrentRow.Cells["id_clipro"].Value.ToString();
                obj.ds_clipro = dgProducto.CurrentRow.Cells["ds_raznombre"].Value.ToString();
                obj.Id_producto = dgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                obj.ds_producto = dgProducto.CurrentRow.Cells["ds_producto"].Value.ToString();
                obj.Id_color = dgProducto.CurrentRow.Cells["id_color"].Value.ToString();
                obj.ds_color = dgProducto.CurrentRow.Cells["ds_color"].Value.ToString();
                obj.Qt_rollo = Convert.ToInt16(dgProducto.CurrentRow.Cells["qt_rollo_actual"].Value);
                obj.qt_rollo_reserv = Convert.ToInt16(dgProducto.CurrentRow.Cells["reservado"].Value);
                obj.Qt_peso_actual =  Convert.ToDecimal(dgProducto.CurrentRow.Cells["qt_peso_actual"].Value);

                obj.id_Vendedor = dgProducto.CurrentRow.Cells["id_vendedor"].Value.ToString();
                obj.Ds_Vendedor = dgProducto.CurrentRow.Cells["dsRazsocial"].Value.ToString();

                pasard(obj);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgIngreso_CellEnter(object sender, DataGridViewCellEventArgs e)
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

                    EIngresoDetalle obj = new EIngresoDetalle();
                    obj.Id_clipro = dgProducto.CurrentRow.Cells["id_clipro"].Value.ToString();
                    obj.ds_clipro = dgProducto.CurrentRow.Cells["ds_raznombre"].Value.ToString();
                    obj.Id_producto = dgProducto.CurrentRow.Cells["id_producto"].Value.ToString();
                    obj.ds_producto = dgProducto.CurrentRow.Cells["ds_producto"].Value.ToString();
                    obj.Id_color = dgProducto.CurrentRow.Cells["id_color"].Value.ToString();
                    obj.ds_color = dgProducto.CurrentRow.Cells["ds_color"].Value.ToString();
                    obj.Qt_rollo = Convert.ToInt16(dgProducto.CurrentRow.Cells["qt_rollo_actual"].Value);
                    obj.qt_rollo_reserv = Convert.ToInt16(dgProducto.CurrentRow.Cells["reservado"].Value);
                    obj.Qt_peso_actual = Convert.ToDecimal(dgProducto.CurrentRow.Cells["qt_peso_actual"].Value);

                    obj.id_Vendedor = dgProducto.CurrentRow.Cells["id_vendedor"].Value.ToString();
                    obj.Ds_Vendedor = dgProducto.CurrentRow.Cells["dsRazsocial"].Value.ToString();

                    pasard(obj);

                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }

        }

        private void FrmProducto_stock_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

   

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 1;
            ListarIngreso();
        }

        private void chk_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cliente.Checked == true)
            {
                txt_vendedor.Text = "";
            }
            else
            {
                txt_vendedor.Text = "";
            }
        }
    }
}
