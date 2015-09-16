using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.BOQry.Co;
using Texfina.Core.Common;
using Texfina.Core.Web;
using Texfina.Entity.Al;
using Texfina.Entity.Co;
//using System.IO;



namespace TX_Almacen
{
    public partial class frmAprobacionMnt : Form
    {
        public frmAprobacionMnt()
        {
            InitializeComponent();
            
        }

        int w = 1;
              
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
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry07(obj);

                    dgvDetalle.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
                else
                {
                    //Evaluar();
               
                    EParametros obj = new EParametros();
                    DateTime f = Convert.ToDateTime(dtpfechaini.Text);
                    int anio = f.Year;

                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = anio.ToString();
                    obj.Idreqsalida = txt_idop.Text;
                    obj.fechaIni = dtpfechaini.Text;
                    obj.fechaFin = dtpfechafin.Text;
                    obj.estado = cbEstado.SelectedValue.ToString();
                    DataSet ds = BOrdPedido.VE_OrdenPedido_qry07(obj);

                    dgvDetalle.DataSource = ds.Tables[0];
                    lblRow_total.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    GridInicial();
                }
            }
            catch (Exception ex)
            {
                ex.ToString();

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
                ex.ToString();
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

        private void Aprobar()
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
                        obj.psintypesel = 11;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.Autorizado;

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
        
        private void NoAprobar()
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
                        obj.psintypesel = 11;

                        obj.Idreqsalida = nu_op.ToString();

                        obj.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj);

                        //------------------------------------------------------------------

                        EParametros obj2 = new EParametros();
                        obj2.psintypesel = 10;

                        obj2.Idreqsalida = nu_op.ToString();

                        obj2.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj2.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj2.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj2.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj2);

                        //-------------------------------------------------------------------



                        EParametros obj3 = new EParametros();
                        obj3.psintypesel = 12;

                        obj3.Idreqsalida = nu_op.ToString();

                        obj3.id_autoriza = frmLogin.d.id.ToLower(); //LLENAR CON SESSION

                        obj3.st_autoriza = Constants2.ConstEstadoOC.nPendiente;

                        obj3.idEmpresa = wfChgEmpPer.datos.idEmpresa;  // LLENAR CON SESSION

                        obj3.idperiodo = wfChgEmpPer.datos.idperiodo;// LLENAR CON SESSION

                        BOrdPedido.VE_OrdPedido_mnt02(obj3);

                        //-------------------------------------------------------------------
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
            frm.estado = "2";
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

        public object GetDataReport03(string key)
        {

        
                    EParametros obj = new EParametros();
                    obj.estado = cbEstado.SelectedValue.ToString();
                    obj.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                    obj.idperiodo = wfChgEmpPer.datos.idperiodo;
                    obj.Idreqsalida = txt_idop.Text;
                    obj.fechaIni = dtpfechaini.Text;
                    obj.fechaFin = dtpfechafin.Text;
                       
                    BOrdPedido _obj = new BOrdPedido();
                    DataTable dt = _obj.VE_OrdenPedido_qry07_rpt(obj);
                    DataSet ds = new DataSet();
                    ds.Tables.Add(dt);
                    return ds;
                         
    

                    //if(string.Compare(obj.estado,"Pendiente")==1)
                    //{
                    //    DataTable dt = _obj.VE_OrdenPedido_qry07_rpt(obj);
                    //    DataSet ds = new DataSet();
                    //    ds.Tables.Add(dt);
                    //    return ds;
                    //}
                    //else if(string.Compare(obj.estado,"No Autorizado")==1)
                    //    {
                    //        DataTable dt = _obj.VE_OrdenPedido_qry07_rpt(obj);
                    //        DataSet ds = new DataSet();
                    //        ds.Tables.Add(dt);
                    //        return ds;
                            
                    //    }
                    //    else if (string.Compare("Autorizado",obj.estado)==1)
                    //        {
                    //            DataTable dt = _obj.VE_OrdenPedido_qry07_rpt(obj);
                    //            DataSet ds = new DataSet();
                    //            ds.Tables.Add(dt);
                    //            return ds;
                    //        }
                    //        else
                    //        {
                    //            return   MessageBox.Show("Ingresar fecha Inicio - Fecha Fin", "Advertencia", MessageBoxButtons.OK);
                            
                    //        }



                    //dgvDetalle.DataSource = ds.Tables[0];
                    //lblRow_total.Text = Convert.ToInt16(dgvDetalle.RowCount).ToString();//-1
                    //GridInicial();
                
            //}
            //catch (Exception ex)
            //{
            //    ex.ToString();
            //    return true;

            //}
            

            

        }

        public void ExportReportAutorizado(string key)
        {
            DataSet ds = (DataSet)this.GetDataReport03(key);
            //DataSet ds = (DataSet)this.GetDataReport(key);

            //ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\DATA.xls", ds);

            //MessageBox.Show("Registros Exportados", "Advertencia", MessageBoxButtons.OK);

            //////////////



        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            //ExportReportAutorizado("");
           

        }


        private void UI_GV_CopyData(object sender, EventArgs e)
        {
            if (dgvDetalle.DataSource != null)
            {
                StringBuilder Output = new StringBuilder();

                //CellSkippers comes into play with copying cell data in each row.
                List<int> CellSkippers = new List<int>();

                //The first "line" will be the Headers.
                for (int i = 0; i < dgvDetalle.Columns.Count; i++)
                {
                    if (dgvDetalle.Columns[i].Visible)
                    {
                        Output.Append(dgvDetalle.Columns[i].HeaderText + "\t");
                    }
                    else
                    {
                        CellSkippers.Add(i);
                    }
                }

                Output.Append("\n");

                //Generate Cell Value Data
                foreach (DataGridViewRow Row in dgvDetalle.Rows)
                {
                    //Don't generate a new line at all if Row is not visible
                    if (Row.Visible)
                    {
                        if (CellSkippers.Any())
                        {
                            for (int i = 0; i < Row.Cells.Count; i++)
                            {
                                //Handling the last cell of the line.
                                if (i == (Row.Cells.Count - 1))
                                {
                                    if (CellSkippers.Contains(i))
                                    {
                                        Output.Append("\n");
                                    }
                                    else
                                    {
                                        Output.Append(Row.Cells[i].Value + "\n");
                                    }
                                }
                                else
                                {
                                    //If CellSkippers contains the index value, it means a
                                    //column was hidden and the data should not be saved
                                    //to memory, so skip it!
                                    if (!(CellSkippers.Contains(i)))
                                    {
                                        Output.Append(Row.Cells[i].Value + "\t");
                                    }
                                }
                            }

                        }
                        else
                        {
                            for (int i = 0; i < Row.Cells.Count; i++)
                            {
                                if (i == (Row.Cells.Count - 1))
                                {
                                    Output.Append(Row.Cells[i].Value + "\n");
                                }
                                else
                                {

                                    Output.Append(Row.Cells[i].Value + "\t");
                                }
                            }
                        }
                    }
                }

                Clipboard.SetText(Output.ToString());
            }
        }

        private void dgvDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (dgvDetalle.Columns[e.ColumnIndex].Name.Equals("estado_"))
                {

                    String estado = e.Value as string; ;
                    if (estado == "(APROBADA)")
                    {
                        e.CellStyle.BackColor = Color.LawnGreen;
                        e.CellStyle.SelectionBackColor = Color.DarkGreen;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
                }


        }
    }
}
