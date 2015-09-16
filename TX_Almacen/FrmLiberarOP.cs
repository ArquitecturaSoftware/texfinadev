using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmLiberarOP : Form
    {
        public FrmLiberarOP()
        {
            InitializeComponent();
        }

        private void btnLiberarOC_Click(object sender, EventArgs e)
        {
            for (int i = 0; dgvDetalle.Rows.Count > i; i++)
            {

                var nu_op = dgvDetalle.Rows[i].Cells["idreqsalida"].Value;
                var ch1 = dgvDetalle.Rows[i].Cells["chkActivo"].Value;



                if (Convert.ToBoolean(ch1) == true)
                {

                    //Response.Write(lblid.Text + "<br>");

                    EParametros eop = new EParametros();

                    //la entidad obtine los siguientes valores a almacenar



                    eop.Idreqsalida = nu_op.ToString();

                    eop.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                    eop.idperiodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                    BOrdPedido.VE_OrdenPedido_Habilitar(eop);

                }


                CargarGrid_Parametro();
                //}
                //catch (Exception ex)
                //{
                //    Response.Write(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrid_Parametro();
        }

        private void GridInicial()
        {
            try
            {
                dgvDetalle.Rows[0].Cells[0].Value = false;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            try
            {
                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {
                    dgvDetalle.Rows[i].Cells["chkActivo"].Value = false;

                }
            }
            catch (Exception ex)
            {

            }



        }

        private void CargarGrid_Parametro()
        {
            try
            {
                if (txtfechaini.Text == "")
                {
                    //Evaluar();
                    EParametros obj = new EParametros();
                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = wfChgEmpPer.datos.idperiodo;
                    obj.Idreqsalida = txtnu_op.Text;
                    obj.fechaIni = txtfechaini.Text;
                    obj.fechaFin = txtfechafin.Text;
                    
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry09(obj);


                    dgvDetalle.DataSource = ds.Tables[0];
                    lblnu_item.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
                else
                {
                    //Evaluar();



                    EParametros obj = new EParametros();
                    DateTime f = Convert.ToDateTime(txtfechaini.Text);
                    int anio = f.Year;

                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = anio.ToString();
                    obj.Idreqsalida = txtnu_op.Text;
                    obj.fechaIni = txtfechaini.Text;
                    obj.fechaFin = txtfechafin.Text;
                    
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry09(obj);

                    dgvDetalle.DataSource = ds.Tables[0];
                    lblnu_item.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();


            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalle.Columns["chkActivo"].Index)
            {
                dgvDetalle.EndEdit();

            }
        }

        private void txtnu_op_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnu_op.Text = string.IsNullOrEmpty(txtnu_op.Text.PadLeft(7, '0')) ? string.Empty : Convert.ToString(txtnu_op.Text.PadLeft(7, '0'));
                CargarGrid_Parametro();
            }
        }

        private void FrmLiberarOP_Load(object sender, EventArgs e)
        {
            CargarGrid_Parametro();
        }

    }
}
