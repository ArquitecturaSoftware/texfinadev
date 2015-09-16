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
    public partial class FrnTejeduria_qry : Form
    {
        public FrnTejeduria_qry()
        {
            InitializeComponent();
        }

        public delegate void pasar(ETejeduria col);
        public event pasar pasard;

        int psintypesel = 0;

        private void FrnTejeduria_qry_Load(object sender, EventArgs e)
        {
          
            psintypesel = 0;
            ListarTejeduria();
        }

        private void ListarTejeduria()
        {
            try
            {
                ETejeduria tj = new ETejeduria();
                if (psintypesel == 0)
                {
                    tj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    //tj.IdPeriodo = "2014";
                    tj.Id_producto = txtIdTejido.Text;
                    tj.Ds_Producto = txtTejido.Text;
                    tj.Nu_correficha = txtFicha.Text;
                    tj.Nu_tf = txtNumTf.Text;
                    tj.Nu_tfref = txtNumTfRef.Text;
                    tj.psintypesel = 0;


                    DataSet ds = BTejeduria.TJ_Tejeduria_qry05(tj);
                    dgTejeduria.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgTejeduria.RowCount).ToString();
                }
                else if (psintypesel == 1)
                {
                    tj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    //tj.IdPeriodo = "2014";
                    tj.Id_producto = txtIdTejido.Text;
                    tj.Ds_Producto = txtTejido.Text;
                    tj.Nu_correficha = txtFicha.Text;
                    tj.Nu_tf = txtNumTf.Text;
                    tj.Nu_tfref = txtNumTfRef.Text;
                    tj.psintypesel = 1;


                    DataSet ds = BTejeduria.TJ_Tejeduria_qry05(tj);
                    dgTejeduria.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgTejeduria.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtIdTejido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtIdTejido.Text != "")
                {
                    psintypesel = 0;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtTejido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtTejido.Text != "")
                {
                    psintypesel = 0;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtFicha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtFicha.Text != "")
                {
                    psintypesel = 0;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtNumTf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNumTf.Text != "")
                {
                    psintypesel = 0;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtNumTfRef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtNumTfRef.Text != "")
                {
                    psintypesel = 0;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarTejeduria();
                    dgTejeduria.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgTejeduria_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgTejeduria.BeginEdit(false);
        }

        private void dgTejeduria_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (lblnutot.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                }
                else
                {

                    ETejeduria tj = new ETejeduria();
          
                    tj.Id_producto = dgTejeduria.CurrentRow.Cells["id_producto"].Value.ToString();
                    tj.Nu_correficha = dgTejeduria.CurrentRow.Cells["nu_correficha"].Value.ToString();
                    tj.Nu_tf = dgTejeduria.CurrentRow.Cells["nu_tf"].Value.ToString();
                    tj.Nu_tfref = dgTejeduria.CurrentRow.Cells["nu_tfref"].Value.ToString();
   


                    pasard(tj);
                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }


        }

        private void dgTejeduria_DoubleClick(object sender, EventArgs e)
        {
         

                if (lblnutot.Text == "0")
                {

                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                }
                else
                {

                    ETejeduria tj = new ETejeduria();
                   
                    tj.Id_producto = dgTejeduria.CurrentRow.Cells["id_producto"].Value.ToString();
                    tj.Nu_correficha = dgTejeduria.CurrentRow.Cells["nu_correficha"].Value.ToString();
                    tj.Nu_tf = dgTejeduria.CurrentRow.Cells["nu_tf"].Value.ToString();
                    tj.Nu_tfref = dgTejeduria.CurrentRow.Cells["nu_tfref"].Value.ToString();
         


                    pasard(tj);
                    this.Dispose();
     
                }
            
        }

  

    }
}
