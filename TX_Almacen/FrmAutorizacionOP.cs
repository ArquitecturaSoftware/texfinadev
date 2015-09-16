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
using Texfina.BOQry.Co;
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace TX_Almacen
{
    public partial class FrmAutorizacionOP : Form
    {


        public FrmAutorizacionOP()
        {
            InitializeComponent();
          
          
        }
        int w = 1;
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
                ex.ToString();
 
            }
           
    

        }

        private void FrmAutorizacionOC_Load(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Now;
            dtpfechaini.Text = fecha.ToString("d");
            dtpfechafin.Text = fecha.ToString("d");
            //chkPendiente.Checked = true;


            DataTable dt1;
            dt1 = new DataTable("Tabla1");
            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");
            DataRow dr;
            dr = dt1.NewRow();
            dr["Codigo"] = Constants2.ConstEstadoOC.Pendiente;
            dr[1] = "Pendiente";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = Constants2.ConstEstadoOC.nPendiente;
            dr[1] = "No Autorizada";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = Constants2.ConstEstadoOC.Autorizado;
            dr[1] = "Autorizada";
            dt1.Rows.Add(dr);

            
            this.cbEstado.DataSource = dt1;
            this.cbEstado.ValueMember = "Codigo";
            this.cbEstado.DisplayMember = "Descripcion";




            CargarGrid_Parametro();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //string estado;
        //private void Evaluar()
        //{

        //    if (chkPendiente.Checked == true)
        //    {
        //        estado = Constants2.ConstEstadoOC.Pendiente;
        //    }
        //    else if (chkNoAutorizar.Checked == true)
        //    {
        //        estado = Constants2.ConstEstadoOC.nPendiente;
        //    }
        //    else
        //    {
        //        estado = Constants2.ConstEstadoOC.Autorizado;
        //    }
        //}

        private void CargarGrid_Parametro()
        {

            try
            {


                if (dtpfechaini.Text == "")
                {


                    //Evaluar();
                    EParametros obj = new EParametros();

                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = wfChgEmpPer.datos.idperiodo;
                    obj.Idreqsalida = txt_idop.Text;
                    obj.fechaIni = dtpfechaini.Text;
                    obj.fechaFin = dtpfechafin.Text;
                    obj.estado = cbEstado.SelectedValue.ToString();
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry06(obj);
                    dgvDetalle.DataSource = ds.Tables[0];
                    lblnu_item.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString(); //-1

                    GridInicial();
                }
                else
                {
                    //Evaluar();
                    EParametros obj = new EParametros();

                    obj.fechaIni = dtpfechaini.Text;
                    obj.fechaFin = dtpfechafin.Text;
                    DateTime f = Convert.ToDateTime(dtpfechaini.Text);
                    int anio = f.Year;

                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = anio.ToString();
                    obj.Idreqsalida = txt_idop.Text;
                    obj.estado = cbEstado.SelectedValue.ToString();
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry06(obj);
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

                    var nu_op = dgvDetalle.Rows[i].Cells["idreqsalida"].Value;

                    var ch1 = dgvDetalle.Rows[i].Cells["_estado"].Value;

               


                    if (Convert.ToBoolean(ch1) == true)
                    {
                        EParametros obj = new EParametros();

                        //la entidad obtine los siguientes valores a almacenar

                        obj.psintypesel = 10;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.Autorizado;
                      
                        obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj);
                      

                    }
                    else
                    {
                        //MessageBox.Show(nu_oc.ToString());


                    }
                }
                MessageBox.Show("Los datos fueron autorizados correctamente", "Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid_Parametro();
            }
            catch (Exception ex)
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

                    var nu_op = dgvDetalle.Rows[i].Cells["idreqsalida"].Value;
                    var ch1 = dgvDetalle.Rows[i].Cells["_estado"].Value;

                    EParametros obj = new EParametros();
                    if (Convert.ToBoolean(ch1) == true)
                    {


                        obj.psintypesel = 10;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj);

                  

                        //-------------------------------------------------------------------


                        obj.psintypesel = 11;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj);



                        //-------------------------------------------------------------------


                        obj.psintypesel = 12;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj);
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
                txt_idop.Text = string.IsNullOrEmpty(txt_idop.Text.PadLeft(7, '0')) ? string.Empty : Convert.ToString(txt_idop.Text.PadLeft(7, '0'));
                CargarGrid_Parametro();
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            FrmOrdenPedido_rpt01 frm = new FrmOrdenPedido_rpt01();

            frm.nuop = txt_idop.Text;
            frm.estado = "1";
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            w = w + 1;

            if (w == 120)
            {
                timer1.Stop();
                try
                {
                    lbltimer.Text = w.ToString();
                    w = 0;
                    //cambiar.....
                    CargarGrid_Parametro();
         
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }

            timer1.Start();
        }

        private void btnAutorizar_CheckStateChanged(object sender, EventArgs e)
        {

        }

    
       
        }
    }

