using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmAprobacionOC : Form
    {
        public FrmAprobacionOC()
        {
            InitializeComponent();
            WebHelper.LoadListControl3(cbplanta, BGeneral.ObtenerDatoLocal());
        }


              
        string estado;
        private void Evaluar()
        {

            if (chkPendiente.Checked == true)
            {
                estado = Constants2.ConstEstadoOC.Pendiente;
            }
            else if (chkNoAutorizar.Checked == true)
            {
                estado = Constants2.ConstEstadoOC.nPendiente;
            }
            else
            {
                estado = Constants2.ConstEstadoOC.Autorizado;
            }
        }

        private void CargarGrid_Parametro()
        {
            try
            {
                if (dtpfechaini.Text == "")
                {
                    Evaluar();
                    EOrdenCompra eoc = new EOrdenCompra();

                    eoc.Fe_ordenco_ini = dtpfechaini.Text;
                    eoc.Fe_ordenco_fin = dtpfechafin.Text;
                    eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                    eoc.Id_periodo = wfChgEmpPer.datos.idperiodo;
                    eoc.strEmitido = cbplanta.Text;
                    eoc.Estado = estado;
                    eoc.Id_ordenco = txt_idOC.Text; 
                    DataSet ds = BOrdenCompra.OrderCompra_qry02(eoc);
                    dgvDetalle.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
                else
                {
                    Evaluar();
                    EOrdenCompra eoc = new EOrdenCompra();

                    eoc.Fe_ordenco_ini = dtpfechaini.Text;
                    eoc.Fe_ordenco_fin = dtpfechafin.Text;
                    DateTime f = Convert.ToDateTime(dtpfechaini.Text);
                    int anio = f.Year;

                    eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                    eoc.Id_periodo = wfChgEmpPer.datos.idperiodo;
                    eoc.strEmitido = cbplanta.Text;
                    eoc.Estado = estado;
                    eoc.Id_ordenco = txt_idOC.Text; 
                    DataSet ds = BOrdenCompra.OrderCompra_qry02(eoc);
                    dgvDetalle.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

                //MessageBox.Show(ex.ToString());
            }
        }


        private void GridInicial()
        {
            dgvDetalle.Rows[0].Cells[0].Value = false;

            try
            {
                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {
                    dgvDetalle.Rows[i].Cells["_estado"].Value = false;

                }
            }
            catch (Exception ex)
            {

            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrid_Parametro();
        }
    
        private void FrmAprobacionOC_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            dtpfechaini.Text = fecha.ToString("d");
            dtpfechafin.Text = fecha.ToString("d");
            chkPendiente.Checked = true;
            CargarGrid_Parametro();

       

        }


        private void Aprobar()
        {
            //------------------------------

            try
            {
                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {

                    var nu_oc = dgvDetalle.Rows[i].Cells["id_ordenco"].Value;

                    var ch1 = dgvDetalle.Rows[i].Cells["_estado"].Value;

                    if (Convert.ToBoolean(ch1) == true)
                    {
                       

                        EOrdenCompra eoc = new EOrdenCompra();

                        //la entidad obtine los siguientes valores a almacenar

                        eoc.psin_typeupd = "11";

                        eoc.Id_ordenco = nu_oc.ToString();

                        eoc.Id_aprueba = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.Autorizado;

                        eoc.Id_uupdarec = frmLogin.d.id; //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt02(eoc);
                    }
                    else
                      {
                          //MessageBox.Show(nu_oc.ToString());
                          //MessageBox.Show(nu_oc.ToString(), "false");

                      }
                }
                MessageBox.Show("Los datos fueron autorizados correctamente", "Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid_Parametro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void NoAprobar()
        {
            try
            {
                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {

                    var nu_oc = dgvDetalle.Rows[i].Cells["id_ordenco"].Value;
                    var ch1 = dgvDetalle.Rows[i].Cells["_estado"].Value;

                    if (Convert.ToBoolean(ch1) == true)
                    {


                        EOrdenCompra eoc = new EOrdenCompra();

                        //la entidad obtine los siguientes valores a almacenar

                        eoc.psin_typeupd = "11";

                        eoc.Id_ordenco = nu_oc.ToString();

                        eoc.Id_autoriza = frmLogin.d.id.ToLower();  //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.nPendiente;

                        eoc.Id_uupdarec = frmLogin.d.id;  //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt01(eoc);
                    }
                    else
                    {
 
                    }
                }
                MessageBox.Show("Los datos fueron desautorizados", "Rechazar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid_Parametro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Aprobar();
        }

        private void btnNAprobar_Click(object sender, EventArgs e)
        {
            NoAprobar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void FrmAprobacionOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                Aprobar();
            }
            else if (e.KeyCode == Keys.N && e.Control)
            {
                NoAprobar();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                CargarGrid_Parametro();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalle.Columns["_estado"].Index)
            {
                dgvDetalle.EndEdit();  
            }

        }

        private void cbplanta_TextChanged(object sender, EventArgs e)
        {
            CargarGrid_Parametro();
        }

        private void txt_idOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_idOC.Text = string.IsNullOrEmpty(txt_idOC.Text.PadLeft(7, '0')) ? string.Empty : Convert.ToString(txt_idOC.Text.PadLeft(7, '0'));
                CargarGrid_Parametro();
            }
          
        }

      
    

      
    }
}
