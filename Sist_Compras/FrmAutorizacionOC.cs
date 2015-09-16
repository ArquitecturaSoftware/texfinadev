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
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmAutorizacionOC : Form
    {


        public FrmAutorizacionOC()
        {
            InitializeComponent();
          
            WebHelper.LoadListControl3(cbplanta, BGeneral.ObtenerDatoLocal());
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

        private void FrmAutorizacionOC_Load(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Now;
            dtpfechaini.Text = fecha.ToString("d");
            dtpfechafin.Text = fecha.ToString("d");
            chkPendiente.Checked = true;
            CargarGrid_Parametro();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    DataSet ds = BOrdenCompra.OrderCompra_qry01(eoc);
                    dgvDetalle.DataSource = ds.Tables[0];
                    lblnu_item.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString(); //-1

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
                    DataSet ds = BOrdenCompra.OrderCompra_qry01(eoc);
                    dgvDetalle.DataSource = ds.Tables[0];
                    lblnu_item.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString(); //-1
                    GridInicial();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrid_Parametro();
        
        }

        private void Autorizar()
        {
            try
            {

        

                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {

                    var nu_oc = dgvDetalle.Rows[i].Cells["id_ordenco"].Value;

                    var ch1 = dgvDetalle.Rows[i].Cells["_estado"].Value;

                    //MessageBox.Show(ch1.ToString() + "" + nu_oc.ToString());


                    if (Convert.ToBoolean(ch1) == true)
                    {
                        EOrdenCompra eoc = new EOrdenCompra();

                        //la entidad obtine los siguientes valores a almacenar

                        eoc.psin_typeupd = "10";

                        eoc.Id_ordenco = nu_oc.ToString();

                        eoc.Id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.Autorizado;

                        eoc.Id_uupdarec = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt01(eoc);
                        //MessageBox.Show(ch1.ToString() + "" + nu_oc.ToString());     

                    }
                    else
                    {
                        //MessageBox.Show(nu_oc.ToString());

                   
                    }
                }
                MessageBox.Show("Los datos fueron autorizados correctamente", "Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid_Parametro();
            }
                catch(Exception ex)
                {
                    ex.ToString();
                    MessageBox.Show("No hay registros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }


     


        private void NAutorizar()
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

                        eoc.psin_typeupd = "10";

                        eoc.Id_ordenco = nu_oc.ToString();

                        eoc.Id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.stordenco = Constants2.ConstEstadoOC.nPendiente;

                        eoc.Id_uupdarec = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt01(eoc);

                        //-------------------------------------------------------------------

                        eoc.psin_typeupd = "11";

                        eoc.Id_ordenco = nu_oc.ToString();

                        eoc.Id_aprueba = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.St_aprueba = Constants2.ConstEstadoOC.nPendiente;

                        eoc.Id_uupdarec = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        eoc.Id_Empresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        eoc.Id_periodo = wfChgEmpPer.datos.idperiodo; // LLENAR CON SESSION

                        BOrdenCompra.OrderCompra_mnt01(eoc);


                    }
                    else
                    {
 
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

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
          
            Autorizar();
        }

        private void btnNAutorizar_Click(object sender, EventArgs e)
        {
            NAutorizar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAutorizacionOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                Autorizar();
            }
            else if (e.KeyCode == Keys.N && e.Control)
            {
                NAutorizar();
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
                dgvDetalle.EndEdit();  //Stop editing of cell.
                //if ((bool)dgvDetalle.Rows[e.RowIndex].Cells["_estado"].Value)
                //    MessageBox.Show("The Value is Checked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show("UnChecked", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

