using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmOrdenCompra_qry : Form
    {

        string Id_imp_;
        //string ds_exp_;
        //public delegate void pasar(string idimp);
        public delegate void pasar(EOrdenCompra idOC);
        public event pasar pasard;


        public FrmOrdenCompra_qry()
        {
            InitializeComponent();
            
            WebHelper.LoadListControl3(cbLocal, BGeneral.ObtenerDatoLocal());
            txtrazsoc.Focus();
        }

        int ancho, alto;

        private void FrmOrdenCompra_qry_Load(object sender, EventArgs e)
        {


            ancho = this.Width;
            alto = this.Height;
            
            txtrazsoc.Focus();
            LlenarGrid();
        }


        private void LlenarGrid()
        {
            try
            {

                if (txtfechaIni.Text == "  /  /")
                {
               
                    EParOCFillrpt pm = new EParOCFillrpt();
                    pm.psintypesel = 2;
                    pm.IdAnio = wfChgEmpPer.datos.idperiodo;
                    pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    pm.IdOrdenCompra = txtcodOc.Text;
                    pm.dsRazonSoc = txtrazsoc.Text.ToUpper();
                    pm.fechaini = "";
                    pm.fechaFin = "";
                    pm.local = cbLocal.SelectedValue.ToString();
                    pm.idProducto = txtproducto.Text;
                   DataSet ds = BOrdenCompra.OrderCompra_qry04(pm);
                   dgOrdenCompra.DataSource = ds.Tables[0];

                   lblNumItem.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                }
                else
                {
                    DateTime f = Convert.ToDateTime(txtfechaIni.Text);
                    String anio = Convert.ToString(f.Year);

                    EParOCFillrpt pm = new EParOCFillrpt();
                    pm.psintypesel = 2;
                    pm.IdAnio = anio;
                    pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    pm.IdOrdenCompra = txtcodOc.Text;
                    pm.dsRazonSoc = txtrazsoc.Text;
                    pm.fechaini = txtfechaIni.Text;
                    pm.fechaFin = txtFechaFin.Text;
                    pm.local = cbLocal.SelectedValue.ToString();
                    pm.idProducto = txtproducto.Text;
                    DataSet ds = BOrdenCompra.OrderCompra_qry04(pm);
                    dgOrdenCompra.DataSource = ds.Tables[0];
                    lblNumItem.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                    
                }

            }
            catch (Exception ex)
            {
                //Response.Write(ex.ToString());
            }

        }


        private void BuscarOc()
        {
            try
            {

                if (txtfechaIni.Text == "  /  /")
                {

                    EParOCFillrpt pm = new EParOCFillrpt();
                    pm.psintypesel = 1;
                    pm.IdAnio = wfChgEmpPer.datos.idperiodo;
                    pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    pm.IdOrdenCompra = txtcodOc.Text;
                    pm.dsRazonSoc = txtrazsoc.Text.ToUpper();
                    pm.fechaini = "";
                    pm.fechaFin = "";
                    pm.local = cbLocal.SelectedValue.ToString();
                    pm.idProducto = txtproducto.Text;
                    DataSet ds = BOrdenCompra.OrderCompra_qry04(pm);
                    dgOrdenCompra.DataSource = ds.Tables[0];
                    lblNumItem.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1

                }
                else
                {
                    DateTime f = Convert.ToDateTime(txtfechaIni.Text);
                    String anio = Convert.ToString(f.Year);

                    EParOCFillrpt pm = new EParOCFillrpt();
                    pm.psintypesel = 1;
                    pm.IdAnio = anio;
                    pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                    pm.IdOrdenCompra = txtcodOc.Text;
                    pm.dsRazonSoc = txtrazsoc.Text;
                    pm.fechaini = txtfechaIni.Text;
                    pm.fechaFin = txtFechaFin.Text;
                    pm.local = cbLocal.SelectedValue.ToString();
                    pm.idProducto = txtproducto.Text;
                    DataSet ds = BOrdenCompra.OrderCompra_qry04(pm);
                    dgOrdenCompra.DataSource = ds.Tables[0];
                    lblNumItem.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1

                }

            }
            catch (Exception ex)
            {
                //Response.Write(ex.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarOc();
        }

        private void txtrazsoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtproducto.Focus();
                BuscarOc();
                dgOrdenCompra.Focus();
            }
        }

        private void cbLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtrazsoc.Focus();
                BuscarOc();
            }
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarOc();
                dgOrdenCompra.Focus();
            }
        }

        private void txtfechaIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtFechaFin.Focus();
               
            }
        }

        private void txtFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cbLocal.Focus();
               
            }
        }

        private void txtfechaIni_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dgOrdenCompra_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F1) //e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control
        //    {
        //        EOrdenCompra OC = new EOrdenCompra();
        //        DateTime periodo;
        //        OC.Id_ordenco = dgOrdenCompra.CurrentRow.Cells["id_ordenco"].Value.ToString();
        //        periodo =     Convert.ToDateTime(dgOrdenCompra.CurrentRow.Cells["fe_ordenco"].Value.ToString());

        //        OC.Id_periodo = Convert.ToString(periodo.Year);
              
        //        pasard(OC);
        //        this.Dispose();
        //    }
        //}

        private void txtcodOc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcodOc.Text = txtcodOc.Text.PadLeft(7,'0');
                BuscarOc();
                dgOrdenCompra.Focus();
            }
        }

        private void dgOrdenCompra_DoubleClick(object sender, EventArgs e)
        {
            //EOrdenCompra OC = new EOrdenCompra();
            //OC.Id_ordenco = dgOrdenCompra.CurrentRow.Cells["id_ordenco"].Value.ToString();
            
            //pasard(OC);

            //this.Dispose();


            EOrdenCompra OC = new EOrdenCompra();
            DateTime periodo;
            OC.Id_ordenco = dgOrdenCompra.CurrentRow.Cells["id_ordenco"].Value.ToString();
            periodo = Convert.ToDateTime(dgOrdenCompra.CurrentRow.Cells["fe_ordenco"].Value.ToString());

            OC.Id_periodo = Convert.ToString(periodo.Year);

            pasard(OC);
            this.Dispose();



        }

        private void FrmOrdenCompra_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmOrdenCompra_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

        //private void dgOrdenCompra_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
    
        //    {
        //        EOrdenCompra OC = new EOrdenCompra();
        //        DateTime periodo;
        //        OC.Id_ordenco = dgOrdenCompra.CurrentRow.Cells["id_ordenco"].Value.ToString();
        //        periodo = Convert.ToDateTime(dgOrdenCompra.CurrentRow.Cells["fe_ordenco"].Value.ToString());

        //        OC.Id_periodo = Convert.ToString(periodo.Year);

        //        pasard(OC);
        //        this.Dispose();
        //    }
        //}

        private void dgOrdenCompra_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgOrdenCompra.BeginEdit(false);
        }

        private void dgOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (lblNumItem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrazsoc.Focus();

                }
                else
                {
                    EOrdenCompra OC = new EOrdenCompra();
                    DateTime periodo;
                    OC.Id_ordenco = dgOrdenCompra.CurrentRow.Cells["id_ordenco"].Value.ToString();
                    periodo = Convert.ToDateTime(dgOrdenCompra.CurrentRow.Cells["fe_ordenco"].Value.ToString());

                    OC.Id_periodo = Convert.ToString(periodo.Year);

                    pasard(OC);
                    this.Dispose();

                    e.SuppressKeyPress = true;
                }

            }
        }

       
    }
}
