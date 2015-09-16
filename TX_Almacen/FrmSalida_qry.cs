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
    public partial class FrmSalida_qry : Form
    {
        public delegate void pasar(ESalida_Detalle ID);
        public event pasar pasard;

        public FrmSalida_qry()
        {
            InitializeComponent();
        }

        private void FrmSalida_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarSalida();
        }

        int psintypesel = 0;
        private void ListarSalida()
        {
            try
            {
                ESalida_Detalle obj = new ESalida_Detalle();
                if (psintypesel == 1)
                {
                    obj.psintypesel = 1;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    obj.IdSalida = txtCodigo.Text;
                    obj.Nu_tf = txt_nutf.Text;
                    obj.Ds_producto = txtdsproducto.Text;

                    DataSet ds = BSalida_Detalle.AL_Salida_Detalle_qry02(obj);
                    dgSalida.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgSalida.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                    obj.psintypesel = 2;
                    obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                    obj.IdSalida = txtCodigo.Text;
                    obj.Nu_tf = txt_nutf.Text;
                    obj.Ds_producto = txtdsproducto.Text;

                    DataSet ds = BSalida_Detalle.AL_Salida_Detalle_qry02(obj);
                    dgSalida.DataSource = ds.Tables[0];
                    nuItem.Text = Convert.ToInt16(dgSalida.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodigo.Text = txtCodigo.Text.PadLeft(7, '0');

                if (txtCodigo.Text != "")
                {
                    psintypesel = 1;
                    ListarSalida();
                    dgSalida.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarSalida();
                    dgSalida.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txt_nutf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_nutf.Text = txt_nutf.Text.PadLeft(7, '0');
                if (txt_nutf.Text != "")
                {
                    psintypesel = 1;
                    ListarSalida();
                    dgSalida.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarSalida();
                    dgSalida.Focus();
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
                    ListarSalida();
                    dgSalida.Focus();
                }
                else
                {
                    psintypesel = 2;
                    ListarSalida();
                    dgSalida.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgSalida_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ESalida_Detalle obj = new ESalida_Detalle();
                obj.IdSalida = dgSalida.CurrentRow.Cells["idSalida"].Value.ToString();

                pasard(obj);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSalida_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgSalida_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgSalida.BeginEdit(false);
        }

        private void dgSalida_KeyDown(object sender, KeyEventArgs e)
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

                    ESalida_Detalle obj = new ESalida_Detalle();
                    obj.IdSalida = dgSalida.CurrentRow.Cells["idSalida"].Value.ToString();

                    pasard(obj);

                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 1;
            ListarSalida();
        }
    }
}
