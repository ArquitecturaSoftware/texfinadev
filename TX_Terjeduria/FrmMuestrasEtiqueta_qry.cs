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
    public partial class FrmMuestrasEtiqueta_qry : Form
    {
        public FrmMuestrasEtiqueta_qry()
        {
            InitializeComponent();
        }
        public delegate void pasar(ETejeduria col);
        public event pasar pasard;
        private void FrmMuestrasEtiqueta_qry_Load(object sender, EventArgs e)
        {
            psintypesel = 0;
            ListarMuestras();
        }
        int psintypesel = 0;
        private void ListarMuestras()
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


                    DataSet ds = BMuestrasEtiqueta.MS_MuestraEtiquetaTela_qry02(tj);
                    dgMuestras.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgMuestras.RowCount).ToString();
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


                    DataSet ds = BMuestrasEtiqueta.MS_MuestraEtiquetaTela_qry02(tj);
                    dgMuestras.DataSource = ds.Tables[0];
                    lblnutot.Text = Convert.ToInt16(dgMuestras.RowCount).ToString();
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void dgMuestras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgMuestras.BeginEdit(false);
        }

        private void dgMuestras_KeyDown(object sender, KeyEventArgs e)
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

                    tj.Id_producto = dgMuestras.CurrentRow.Cells["id_producto"].Value.ToString();
                    tj.Nu_correficha = dgMuestras.CurrentRow.Cells["nu_correficha"].Value.ToString();
                    tj.Nu_tf = dgMuestras.CurrentRow.Cells["nu_tf"].Value.ToString();
                    tj.idCodBar = dgMuestras.CurrentRow.Cells["idCodBar"].Value.ToString();



                    pasard(tj);
                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
            }

        }

        private void dgMuestras_DoubleClick(object sender, EventArgs e)
        {

            if (lblnutot.Text == "0")
            {

                MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ETejeduria tj = new ETejeduria();

                tj.Id_producto = dgMuestras.CurrentRow.Cells["id_producto"].Value.ToString();
                tj.Nu_correficha = dgMuestras.CurrentRow.Cells["nu_correficha"].Value.ToString();
                tj.Nu_tf = dgMuestras.CurrentRow.Cells["nu_tf"].Value.ToString();
                tj.idCodBar = dgMuestras.CurrentRow.Cells["idCodBar"].Value.ToString();



                pasard(tj);
                this.Dispose();
               
            }
        }

    }
}
