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
    public partial class FrmTipoGasto_qry : Form
    {

        public delegate void pasar(ETipGasto tg);
        public event pasar pasard;
        public FrmTipoGasto_qry()
        {
            InitializeComponent();
        }

        private void ListarTipoGasto()
        {
            try
            {
                ETipGasto tg = new ETipGasto();

                tg.Id_tipogsto = txtCodigo.Text;
                tg.Ds_tipogsto = txtTg.Text;

                

                 DataSet ds = BTipGasto.TipoGasto_qry01(tg);
                 dgtipoGasto.DataSource =  ds.Tables[0];

                 lblRow_total.Text = dgtipoGasto.RowCount.ToString();
               
            }
            catch (Exception ex)
            {
                //Response.Write(ex.ToString());
            }
        }
        int ancho, alto;
        private void FrmTipoGasto_qry_Load(object sender, EventArgs e)
        {


            ancho = this.Width;
            alto = this.Height;
            ListarTipoGasto();
        }

        //private void dgtipoGasto_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F1) //e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
        //    {
        //        ETipGasto tg = new ETipGasto();
        //        tg.Id_tipogsto = dgtipoGasto.CurrentRow.Cells["Codigo"].Value.ToString();
        //        tg.Ds_tipogsto = dgtipoGasto.CurrentRow.Cells["Descripcion"].Value.ToString();
        //        pasard(tg);
        //        this.Dispose();
        //    }
        //}

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                 ListarTipoGasto();
                 dgtipoGasto.Focus();
            }
        }

        private void txtTg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ListarTipoGasto();
                dgtipoGasto.Focus();
            }
        }

        private void dgtipoGasto_DoubleClick(object sender, EventArgs e)
        {
            ETipGasto tg = new ETipGasto();
            tg.Id_tipogsto = dgtipoGasto.CurrentRow.Cells["Codigo"].Value.ToString();
            tg.Ds_tipogsto = dgtipoGasto.CurrentRow.Cells["Descripcion"].Value.ToString();
            pasard(tg);
            this.Dispose();
        }

        private void FrmTipoGasto_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmTipoGasto_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void dgtipoGasto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgtipoGasto.BeginEdit(false);
        }

        //private void dgtipoGasto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyChar == Convert.ToChar(Keys.Enter))
        //        {
        //            ETipGasto tg = new ETipGasto();
        //            tg.Id_tipogsto = dgtipoGasto.CurrentRow.Cells["Codigo"].Value.ToString();
        //            tg.Ds_tipogsto = dgtipoGasto.CurrentRow.Cells["Descripcion"].Value.ToString();
        //            pasard(tg);
        //            this.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    { 
        //        ex.ToString();
        //    }
        //}

        private void dgtipoGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblRow_total.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTg.Focus();

                }
                else
                {

                    ETipGasto tg = new ETipGasto();
                    tg.Id_tipogsto = dgtipoGasto.CurrentRow.Cells["Codigo"].Value.ToString();
                    tg.Ds_tipogsto = dgtipoGasto.CurrentRow.Cells["Descripcion"].Value.ToString();
                    pasard(tg);
                    this.Dispose();

                    e.SuppressKeyPress = true;
                }
            }
        }
    }
}
