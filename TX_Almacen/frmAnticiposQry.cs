using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Ve;
using Texfina.Entity.Co;
using Texfina.Entity.Ve;

namespace TX_Almacen
{
    public partial class frmAnticiposQry : Form
    {
        public frmAnticiposQry()
        {
            InitializeComponent();
        }

        EAnticipos objAnticipos = new EAnticipos();
        
        private void ListarAnticipos()
        {
                
                objAnticipos.IdEmpresa= wfChgEmpPer.datos.idEmpresa;
                objAnticipos.IdAnticipo = txtIdAnticipo.Text;
                objAnticipos.DsCliente = txtDsCliente.Text;
                
                DataSet ds = BAnticipos.FillDatoAnticipos(objAnticipos);
                dgvAnticipos.DataSource = ds.Tables[0];
                lblnumitem.Text = Convert.ToInt16(dgvAnticipos.RowCount).ToString();

      
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    if (txtIdAnticipo.Text != "")
            //    {
            //        psintypesel = 2;
            //        ListarCondiPago();
            //        dgCondPago.Focus();
            //    }
            //    else
            //    {
            //        psintypesel = 1;
            //        ListarCondiPago();
            //        MessageBox.Show("No hay datos a buscar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //{
            //    if (txtDsCliente.Text != "")
            //    {
            //        psintypesel = 2;
            //        ListarCondiPago();
            //        dgCondPago.Focus();
            //    }
            //    else
            //    {
            //        psintypesel = 1;
            //        ListarCondiPago();
            //        MessageBox.Show("No hay datos a buscar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
        }
        int ancho, alto;
        private void frmAnticiposQry_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;
            //psintypesel = 1;
            ListarAnticipos();
        }
        string Id_condpago_;

        string ds_condpago_;

        public delegate void pasar(string idPers, string dsPers);

        public event pasar pasard;

       


        private void Frmcocondicionpago_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Frmcocondicionpago_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void dgCondPago_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Id_condpago_ = dgvAnticipos.CurrentRow.Cells["id_condpago"].Value.ToString();

                ds_condpago_ = dgvAnticipos.CurrentRow.Cells["ds_condpago"].Value.ToString();

                pasard(Id_condpago_, ds_condpago_);

                this.Dispose();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }

           
        }


        private void dgCondPago_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgvAnticipos.BeginEdit(false);
        }

        private void dgCondPago_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1) //e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control -- CODIFICADO EN EL EVENTO KEYUP

            if (e.KeyCode == Keys.Enter)
            {

                if (lblnumitem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDsCliente.Focus();
                }
                else
                {
                    Id_condpago_ = dgvAnticipos.CurrentRow.Cells["id_condpago"].Value.ToString();

                    ds_condpago_ = dgvAnticipos.CurrentRow.Cells["ds_condpago"].Value.ToString();

                    pasard(Id_condpago_, ds_condpago_);
                    this.Dispose();

                    e.SuppressKeyPress = true;
                }
        
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            ListarAnticipos();
        }
    }
}
