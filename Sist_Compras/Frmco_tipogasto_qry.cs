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

namespace Sist_Compras
{
    public partial class Frmco_tipogasto_qry : Form
    {
        public delegate void pasar(ETipGasto tg);
        public event pasar pasard;


        public Frmco_tipogasto_qry()
        {
            InitializeComponent();
        }
        int ancho, alto;
        private void Frmco_tipogasto_qry_Load(object sender, EventArgs e)
        {

            ancho = this.Width;
            alto = this.Height;

            BusquedaTGasto();
            txtdes.Focus();
        }

        private void BusquedaTGasto()
        {
            ETipGasto tg = new ETipGasto();

            tg.Id_tipogsto = txtCodigo.Text;
            tg.Ds_tipogsto = txtdes.Text;

            DataSet ds = BTipGasto.TipoGasto_qry01(tg);
            dgtipogasto.DataSource = ds.Tables[0];
            lblRow_total.Text = Convert.ToInt16(dgtipogasto.RowCount).ToString(); //-1
        }


        private void txtdes_TextChanged(object sender, EventArgs e)
        {
            BusquedaTGasto();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
            BusquedaTGasto();
            dgtipogasto.Focus();
            }
        }



        private void txtdes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BusquedaTGasto();
                dgtipogasto.Focus();
            }
        }

        private void Frmco_tipogasto_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Frmco_tipogasto_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }



        private void dgtipogasto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgtipogasto.BeginEdit(false);
        }

        private void dgtipogasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblRow_total.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdes.Focus();
                }
                else
                {

                    ETipGasto tg = new ETipGasto();
                    tg.Id_tipogsto = dgtipogasto.CurrentRow.Cells["Codigo"].Value.ToString();
                    tg.Ds_tipogsto = dgtipogasto.CurrentRow.Cells["Descripcion"].Value.ToString();
                    pasard(tg);
                    this.Dispose();

                    e.SuppressKeyPress = true;
                }
            }
        }

        private void dgtipogasto_DoubleClick(object sender, EventArgs e)
        {

            ETipGasto tg = new ETipGasto();
            tg.Id_tipogsto = dgtipogasto.CurrentRow.Cells["Codigo"].Value.ToString();
            tg.Ds_tipogsto = dgtipogasto.CurrentRow.Cells["Descripcion"].Value.ToString();
            pasard(tg);
            this.Dispose();

            


        }
    }
}
