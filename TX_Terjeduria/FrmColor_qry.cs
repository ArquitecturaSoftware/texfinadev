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
using Texfina.Entity.TJ;

namespace TX_Terjeduria
{
    public partial class FrmColor_qry : Form
    {

        public delegate void pasar(EColor col);
        public event pasar pasard;

        int psintypesel = 0;

        public FrmColor_qry()
        {
            InitializeComponent();
        }


        private void ListarColor()
        {
            try
            {
                EColor col = new EColor();
                if (psintypesel == 0)
                {
                    col.psintypesel = 0;
                    col.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    col.Id_color = txtCodigo.Text;
                    col.Ds_color = txtdescripcion.Text;                                   
                    DataSet ds = BColor.GetListFill(col);
                    dgColor.DataSource = ds.Tables[0];
                    lblNum.Text = Convert.ToInt16(dgColor.RowCount).ToString();
                }
                else if (psintypesel == 1)
                {
                    col.psintypesel = 1;
                    col.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    col.Id_color = txtCodigo.Text;
                    col.Ds_color = txtdescripcion.Text;                                      
                    DataSet ds = BColor.GetListFill(col);
                    dgColor.DataSource = ds.Tables[0];
                    lblNum.Text = Convert.ToInt16(dgColor.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void FrmColor_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 0;
            ListarColor();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 0;
                    ListarColor();
                    dgColor.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarColor();
                    dgColor.Focus();
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
                    psintypesel = 0;
                    ListarColor();
                    dgColor.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarColor();
                    dgColor.Focus();

                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (lblNum.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescripcion.Focus();
                }
                else
                {

                    EColor col = new EColor();
                    col.RowNumber = Convert.ToInt16(dgColor.CurrentRow.Cells["RowNumber"].Value);
                    col.Id_color = dgColor.CurrentRow.Cells["id_color"].Value.ToString();
                    col.Ds_color = dgColor.CurrentRow.Cells["ds_color"].Value.ToString();
                    col.Id_vtipcolor = dgColor.CurrentRow.Cells["id_vtipcolor"].Value.ToString();
                    col.Fe_creacion = Convert.ToDateTime(dgColor.CurrentRow.Cells["fe_creacion"].Value);
                    col.Id_cartacol = dgColor.CurrentRow.Cells["id_cartacol"].Value.ToString();
                    col.Nu_opcion = dgColor.CurrentRow.Cells["nu_opcion"].Value.ToString();


                    pasard(col);
                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void FrmColor_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgColor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgColor.BeginEdit(false);
        }

        private void dgColor_DoubleClick(object sender, EventArgs e)
        {
            

                if (lblNum.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescripcion.Focus();
                }
                else
                {

                    EColor col = new EColor();
                    col.RowNumber = Convert.ToInt16(dgColor.CurrentRow.Cells["RowNumber"].Value);
                    col.Id_color = dgColor.CurrentRow.Cells["id_color"].Value.ToString();
                    col.Ds_color = dgColor.CurrentRow.Cells["ds_color"].Value.ToString();
                    col.Id_vtipcolor = dgColor.CurrentRow.Cells["id_vtipcolor"].Value.ToString();
                    col.Fe_creacion = Convert.ToDateTime(dgColor.CurrentRow.Cells["fe_creacion"].Value);
                    col.Id_cartacol = dgColor.CurrentRow.Cells["id_cartacol"].Value.ToString();
                    col.Nu_opcion = dgColor.CurrentRow.Cells["nu_opcion"].Value.ToString();


                    pasard(col);
                    this.Dispose();
                
               
            }
        }
    }
}
