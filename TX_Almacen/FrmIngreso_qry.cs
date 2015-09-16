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
    public partial class FrmIngreso_qry : Form
    {
        public FrmIngreso_qry()
        {
            InitializeComponent();
        }
        public delegate void pasar(EIngresoDetalle ID);
        public event pasar pasard;

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
                    obj.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    obj.IdIngreso = txtCodigo.Text;
                    obj.Nu_tf = txt_nutf.Text;
                    obj.ds_producto = txtdsproducto.Text;

                    DataSet ds = BIngreso_Detalle.AL_IngresoDetalle_qry02(obj);
                    dgIngreso.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgIngreso.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                    obj.psintypesel = 2;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa; 
                    obj.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    obj.IdIngreso = txtCodigo.Text;
                    obj.Nu_tf = txt_nutf.Text;
                    obj.ds_producto = txtdsproducto.Text;

                    DataSet ds = BIngreso_Detalle.AL_IngresoDetalle_qry02(obj);
                    dgIngreso.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgIngreso.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmIngreso_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarIngreso();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgIngreso.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgIngreso.Focus();
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
                    ListarIngreso();
                    dgIngreso.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgIngreso.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtdsproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdsproducto.Text != "")
                {
                    psintypesel = 1;
                    ListarIngreso();
                    dgIngreso.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarIngreso();
                    dgIngreso.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgIngreso_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                EIngresoDetalle obj = new EIngresoDetalle();
                obj.IdIngreso = dgIngreso.CurrentRow.Cells["idIngreso"].Value.ToString();
              
                pasard(obj);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmIngreso_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgIngreso_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgIngreso.BeginEdit(false);
        }

        private void dgIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (nuItem.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdsproducto.Focus();
                }
                else
                {

                    EIngresoDetalle obj = new EIngresoDetalle();
                    obj.IdIngreso = dgIngreso.CurrentRow.Cells["idIngreso"].Value.ToString();

                    pasard(obj);

                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }
        }

    }
}
