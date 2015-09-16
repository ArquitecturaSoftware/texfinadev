using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmLiberarOC : Form
    {
        public FrmLiberarOC()
        {
            InitializeComponent();
        }

        private void LlenarGrid()
        {
            //try
            //{

            if (txtfechaini.Text == "  /  /")
            {


                EParOCFillrpt pm = new EParOCFillrpt();
                pm.psintypesel = 2;
                pm.IdAnio = wfChgEmpPer.datos.idperiodo;
                pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                pm.IdOrdenCompra = txtnuoc.Text;
                pm.idProv = "";
                pm.fechaini = "";
                pm.fechaFin = "";
                pm.local = "";
                pm.idProducto = "";

                DataSet ds = new DataSet();

                ds = BOrdenCompra.OrderCompra_qry04(pm);
                dgOrdenCompra.DataSource = ds.Tables[0];
                lblnu_item.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                GridInicial();
            }
            else
            {
                DateTime f = Convert.ToDateTime(txtfechaini.Text);
                String anio = Convert.ToString(f.Year);

                EParOCFillrpt pm = new EParOCFillrpt();
                pm.psintypesel = 2;
                pm.IdAnio = anio;
                pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                pm.IdOrdenCompra = txtnuoc.Text;
                pm.idProv = "";
                pm.fechaini = txtfechaini.Text;
                pm.fechaFin = txtfechafin.Text;
                pm.local = "";
                pm.idProducto = "";
                DataSet ds = new DataSet();
                ds = BOrdenCompra.OrderCompra_qry04(pm);
                dgOrdenCompra.DataSource = ds.Tables[0];
                lblnu_item.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                GridInicial();
            }

            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.ToString());
            //}

        }


         private void  BuscarOC()
        {
            //try
            //{

            if (txtfechaini.Text == "  /  /")
            {


                EParOCFillrpt pm = new EParOCFillrpt();
                pm.psintypesel = 1;
                pm.IdAnio = wfChgEmpPer.datos.idperiodo;
                pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                pm.IdOrdenCompra = txtnuoc.Text.PadLeft(7, '0');
                pm.idProv = "";
                pm.fechaini = "";
                pm.fechaFin = "";
                pm.local = "";
                pm.idProducto = "";

                DataSet ds = new DataSet();

                ds = BOrdenCompra.OrderCompra_qry04(pm);
                dgOrdenCompra.DataSource = ds.Tables[0];
                lblnu_item.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                GridInicial();
            }
            else
            {
                DateTime f = Convert.ToDateTime(txtfechaini.Text);
                String anio = Convert.ToString(f.Year);

                EParOCFillrpt pm = new EParOCFillrpt();
                pm.psintypesel = 1;
                pm.IdAnio = anio;
                pm.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                pm.IdOrdenCompra = txtnuoc.Text;
                pm.idProv = "";
                pm.fechaini = txtfechaini.Text;
                pm.fechaFin = txtfechafin.Text;
                pm.local = "";
                pm.idProducto = "";
                DataSet ds = new DataSet();
                ds = BOrdenCompra.OrderCompra_qry04(pm);
                dgOrdenCompra.DataSource = ds.Tables[0];
                lblnu_item.Text = Convert.ToInt16(dgOrdenCompra.RowCount).ToString();//-1
                GridInicial();

            }

            }

         private void GridInicial()
         {
             try
             {
                 dgOrdenCompra.Rows[0].Cells[0].Value = false;
             }
             catch(Exception ex)
             {
                 ex.ToString();
             }

             try
             {
                 for (int i = 0; dgOrdenCompra.Rows.Count > i; i++)
                 {
                     dgOrdenCompra.Rows[i].Cells["chkActivo"].Value = false;

                 }
             }
             catch (Exception ex)
             {

             }



         }


        private void FrmLiberarOC_Load(object sender, EventArgs e)
        {
       
            
            txtnuoc.Focus();
            LlenarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarOC();
        }

        private void txtnuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuoc.Text = txtnuoc.Text.PadLeft(7, '0');
                BuscarOC();
            }
        }

        private void txtfechaini_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtfechafin.Focus();
            }
        }

        private void txtfechafin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnuoc.Focus();
            }
        }

 

        private void btnLiberarOC_Click(object sender, EventArgs e)
        {
            for (int i = 0; dgOrdenCompra.Rows.Count > i; i++)
            {

                var nu_oc = dgOrdenCompra.Rows[i].Cells["id_ordenco"].Value;
                var ch1 = dgOrdenCompra.Rows[i].Cells["chkActivo"].Value;



                if (Convert.ToBoolean(ch1) == true)
                {
                   
                    //Response.Write(lblid.Text + "<br>");

                    EOrdenCompra eoc = new EOrdenCompra();

                    //la entidad obtine los siguientes valores a almacenar



                    eoc.Id_ordenco = nu_oc.ToString();

                    eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                    eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                    BOrdenCompra.OrderCompra_Habilitar(eoc);

                }


                LlenarGrid();
                //}
                //catch (Exception ex)
                //{
                //    Response.Write(ex.ToString());
            }
        }

        private void dgOrdenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgOrdenCompra.Columns["chkActivo"].Index)
            {
                dgOrdenCompra.EndEdit();  
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLiberarOC_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


       
    }
}
