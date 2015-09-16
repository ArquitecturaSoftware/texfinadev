using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class Frmcocondicionpago_qry : Form
    {
        public Frmcocondicionpago_qry()
        {
            InitializeComponent();
        }
        ECondicionPago CP = new ECondicionPago();
     
        int psintypesel = 1;

        private void ListarCondiPago()
        {
              
            if(psintypesel == 1)
            {
                CP.psintypesel = 1;
                CP.Ds_condpago = txtdescripcion.Text;
                CP.Id_condpago = txtCodigo.Text;
                DataSet ds = BCondicionPago.CondiPagoFill(CP);
                dgCondPago.DataSource = ds.Tables[0];
                lblnumitem.Text = Convert.ToInt16(dgCondPago.RowCount).ToString();
            }
            else if (psintypesel == 2)
            {
                CP.psintypesel = 2;
                CP.Ds_condpago = txtdescripcion.Text;
                CP.Id_condpago = txtCodigo.Text;
                DataSet ds = BCondicionPago.CondiPagoFill(CP);
                dgCondPago.DataSource = ds.Tables[0];
                lblnumitem.Text = Convert.ToInt16(dgCondPago.RowCount).ToString();
            }
      
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 2;
                    ListarCondiPago();
                    dgCondPago.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarCondiPago();
                    MessageBox.Show("No hay datos a buscar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtdescripcion.Text != "")
                {
                    psintypesel = 2;
                    ListarCondiPago();
                    dgCondPago.Focus();
                }
                else
                {
                    psintypesel = 1;
                    ListarCondiPago();
                    MessageBox.Show("No hay datos a buscar", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        int ancho, alto;
        private void Frmcocondicionpago_qry_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;
            psintypesel = 1;
            ListarCondiPago();
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
                Id_condpago_ = dgCondPago.CurrentRow.Cells["id_condpago"].Value.ToString();

                ds_condpago_ = dgCondPago.CurrentRow.Cells["ds_condpago"].Value.ToString();

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
            dgCondPago.BeginEdit(false);
        }

        private void dgCondPago_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1) //e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control -- CODIFICADO EN EL EVENTO KEYUP

            if (e.KeyCode == Keys.Enter)
            {

                if (lblnumitem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescripcion.Focus();
                }
                else
                {
                    Id_condpago_ = dgCondPago.CurrentRow.Cells["id_condpago"].Value.ToString();

                    ds_condpago_ = dgCondPago.CurrentRow.Cells["ds_condpago"].Value.ToString();

                    pasard(Id_condpago_, ds_condpago_);
                    this.Dispose();

                    e.SuppressKeyPress = true;
                }
        
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 2;
            ListarCondiPago();
        }
    }
}
