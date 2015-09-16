using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmOrdenPedido_qry02 : Form
    {
        public FrmOrdenPedido_qry02()
        {
            InitializeComponent();
        }

        private void FrmOrdenPedido_qry02_Load(object sender, EventArgs e)
        {
            psintypesel = 2;
            LlenarGrid();
        }
        int psintypesel = 0;
        private void LlenarGrid()
        {
            try
            {
                if (psintypesel == 2)
                {

                    if (txtfechaIni.Text == "  /  /")
                    {

                        EParametros pm = new EParametros();
                        pm.psintypesel = 2;
                        pm.pidreqsalida = txtcodOp.Text;
                        pm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                        pm.idperiodo = wfChgEmpPer.datos.idperiodo;
                        pm.fechaIni = "";
                        pm.fechaFin = "";
                        pm.dsRazonSoc = txtcliente.Text;
                        pm.dsproducto = txtproducto.Text;
                        if (chkAprobado.Checked == true)
                        {
                            pm.st_autoriza = "P";
                        }
                        else
                        {
                            pm.st_autoriza = "T";
                        }

                        if (chkPendiente.Checked == true)
                        {
                            pm.estado = "Pendiente";
                        }
                        else
                        {
                            pm.estado = "Despachado";
                        }

                        DataSet ds = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry01(pm);
                        dgOrdenPedido.DataSource = ds.Tables[0];

                        //lblNumItem.Text = Convert.ToInt16(dgOrdenPedido.RowCount).ToString();//-1
                    }
                    else
                    {
                        DateTime f = Convert.ToDateTime(txtfechaIni.Text);
                        String anio = Convert.ToString(f.Year);

                        EParametros pm = new EParametros();
                        pm.psintypesel = 2;
                        pm.pidreqsalida = txtcodOp.Text;
                        pm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                        pm.idperiodo = wfChgEmpPer.datos.idperiodo;
                        pm.fechaIni = txtfechaIni.Text;
                        pm.fechaFin = txtFechaFin.Text;
                        pm.dsRazonSoc = txtcliente.Text;
                        pm.dsproducto = txtproducto.Text;

                        if (chkAprobado.Checked == true)
                        {
                            pm.st_autoriza = "P";
                        }
                        else
                        {
                            pm.st_autoriza = "T";
                        }

                        if (chkPendiente.Checked == true)
                        {
                            pm.estado = "Pendiente";
                        }
                        else
                        {
                            pm.estado = "Despachado";
                        }


                        DataSet ds = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry01(pm);
                        dgOrdenPedido.DataSource = ds.Tables[0];
                        //lblNumItem.Text = Convert.ToInt16(dgOrdenPedido.RowCount).ToString();//-1

                    }

                }
                else
                {
                    if (txtfechaIni.Text == "  /  /")
                    {

                        EParametros pm = new EParametros();
                        pm.psintypesel = 1;
                        pm.pidreqsalida = txtcodOp.Text;
                        pm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                        pm.idperiodo = wfChgEmpPer.datos.idperiodo;
                        pm.fechaIni = "";
                        pm.fechaFin = "";
                        pm.dsRazonSoc = txtcliente.Text;
                        pm.dsproducto = txtproducto.Text;
                        if (chkAprobado.Checked == true)
                        {
                            pm.st_autoriza = "P";
                        }
                        else
                        {
                            pm.st_autoriza = "T";
                        }

                        if (chkPendiente.Checked == true)
                        {
                            pm.estado = "Pendiente";
                        }
                        else
                        {
                            pm.estado = "Despachado";
                        }

                        DataSet ds = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry01(pm);
                        dgOrdenPedido.DataSource = ds.Tables[0];

                        //lblNumItem.Text = Convert.ToInt16(dgOrdenPedido.RowCount).ToString();//-1
                    }
                    else
                    {
                        DateTime f = Convert.ToDateTime(txtfechaIni.Text);
                        String anio = Convert.ToString(f.Year);

                        EParametros pm = new EParametros();
                        pm.psintypesel = 1;
                        pm.pidreqsalida = txtcodOp.Text;
                        pm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                        pm.idperiodo = wfChgEmpPer.datos.idperiodo;
                        pm.fechaIni = txtfechaIni.Text;
                        pm.fechaFin = txtFechaFin.Text;
                        pm.dsRazonSoc = txtcliente.Text;
                        pm.dsproducto = txtproducto.Text;
                        if (chkAprobado.Checked == true)
                        {
                            pm.st_autoriza = "P";
                        }
                        else
                        {
                            pm.st_autoriza = "T";
                        }

                        if (chkPendiente.Checked == true)
                        {
                            pm.estado = "Pendiente";
                        }
                        else
                        {
                            pm.estado = "Despachado";
                        }

                        DataSet ds = BOrdPedido_Detalle.VE_OrdPedido_Detalle_qry01(pm);
                        dgOrdenPedido.DataSource = ds.Tables[0];
                        //lblNumItem.Text = Convert.ToInt16(dgOrdenPedido.RowCount).ToString();//-1

                    }

                }


            }



            catch (Exception ex)
            {
                //Response.Write(ex.ToString());
            }

        }

        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtcliente.Text != "")
                {
                    psintypesel = 1;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                }
                else
                {
                    psintypesel = 2;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtproducto.Text != "")
                {
                    psintypesel = 1;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                }
                else
                {
                    psintypesel = 2;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtcodOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcodOp.Text = txtcodOp.Text.PadLeft(7, '0');

                if (txtcodOp.Text != "")
                {
                    psintypesel = 1;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                }
                else
                {
                    psintypesel = 2;
                    LlenarGrid();
                    dgOrdenPedido.Focus();
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            psintypesel = 1;
            LlenarGrid();
            dgOrdenPedido.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
