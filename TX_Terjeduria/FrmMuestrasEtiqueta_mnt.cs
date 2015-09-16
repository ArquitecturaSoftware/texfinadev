using BarCode;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.TJ;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;


namespace TX_Terjeduria
{
    public partial class FrmMuestrasEtiqueta_mnt : Form
    {
        public FrmMuestrasEtiqueta_mnt()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn comboboxolumn = dgProcesos.Columns["idRutaProces"] as DataGridViewComboBoxColumn;
         
            comboboxolumn.DataSource = BTejeduriaDetProces.MG_RutaProceso_qry03();
            comboboxolumn.DisplayMember = "desc";
            comboboxolumn.ValueMember = "id";
        }

        private void FrmMuestrasEtiqueta_mnt_Load(object sender, EventArgs e)
        {

        }
        string valorCelda;
        private void NuevoItem()
        {
            int countRows = dgProcesos.Rows.Count - 1;

            if (countRows >= 0)
            {
                valorCelda = dgProcesos.Rows[countRows].Cells["idItem"].Value.ToString();
            }
            else
            {
                valorCelda = "0";

            }


            string item = (Convert.ToInt16(valorCelda) + 1).ToString();

            dgProcesos.Rows.Add(item.PadLeft(3, '0').ToString(), "");
            dgProcesos.CurrentCell = dgProcesos.Rows[dgProcesos.Rows.Count - 1].Cells["idRutaProces"];
            dgProcesos.Focus();

        }



        private void btnBuscTejido_Click(object sender, EventArgs e)
        {
            FrnTejeduria_qry frmoc = new FrnTejeduria_qry();
            frmoc.pasard += new FrnTejeduria_qry.pasar(EjecutarTejeduria);
            frmoc.ShowDialog();
        }

        public void EjecutarTejeduria(ETejeduria TJ)
        {
            txt_idTejido.Text = TJ.Id_producto;
            txt_nuFicha.Text = TJ.Nu_correficha;
            txt_nuTf.Text = TJ.Nu_tf;
            TfRef = TJ.Nu_tfref;
            BuscarTejeduria();
            txtBuscarTejido.Focus();
        }
        string TfRef = "";

        private void BuscarTejeduria()
        {

            ETejeduria oT = new ETejeduria();

          
            dgProcesos.Rows.Clear();
       

            oT.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            oT.Id_producto = txt_idTejido.Text;
            oT.Nu_correficha = txt_nuFicha.Text;


            List<ETejeduria> oListDato = BTejeduria.TJ_Tejeduria_qry06(oT);


            string val = oListDato[0].existe;

            if (val == "0")
            {

                try
                {
                    

                    ETejeduria oTJ = new ETejeduria();

                 
                    oTJ.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    oTJ.Id_producto = txt_idTejido.Text;
                    oTJ.Nu_correficha = txt_nuFicha.Text;
                    oTJ.Nu_tf = txt_nuTf.Text;
                    oTJ.Nu_tfref = TfRef;




                    ETejeduria oBtieneTJ = new ETejeduria();
                    oBtieneTJ = BTejeduria.TJ_Tejeduria_qry07(oTJ);

               
                    lbl_dsTejido.Text = oBtieneTJ.ds_producto.ToString().Trim();

                    txt_fecha.Text = oBtieneTJ.Fe_registro.ToString();
                    txt_IdCli.Text = oBtieneTJ.Id_clipro.ToString().Trim();
                    lbl_dsCliente.Text = oBtieneTJ.ds_razonSoc.ToString().Trim();

                 



                    ETejeduria_DetProces oTJDP = new ETejeduria_DetProces();


                    oTJDP.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    oTJDP.Id_producto = txt_idTejido.Text;
                    oTJDP.Nu_correficha =txt_nuFicha.Text;




                    List<ETejeduria_DetProces> lstTJP = new List<ETejeduria_DetProces>();
                    lstTJP = BTejeduriaDetProces.mListarTejeduriaDetProces(oTJDP);

                    foreach (ETejeduria_DetProces objTJDP in lstTJP)
                    {
                        string[] row =
                        
                                {    objTJDP.IdItem.ToString(),                                  
                                     objTJDP.IdRutaProces.ToString(),
                                };
                        dgProcesos.Rows.Add(row);
                    }


                }

                catch (Exception ex)
                {
                    ex.ToString();
                }

            }
            else
            {
                MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnNewProc_Click(object sender, EventArgs e)
        {
            NuevoItem();
        }

        private void btnDelProc_Click(object sender, EventArgs e)
        {
            if (dgProcesos.RowCount > 0)
            {
                try
                {

                    var nuItem = dgProcesos.CurrentRow.Cells["idItem"].Value;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                try
                {
                    dgTempDetProc.Rows.Add(nuItem.ToString());

                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

                dgProcesos.Rows.Remove(dgProcesos.CurrentRow);
            }
            else
            { 

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {    
            txt_idTejido.Clear();
            txt_IdCli.Clear();
            txt_nuTf.Clear();
            txt_nuFicha.Clear();
            lbl_dsTejido.Text = "";
            lbl_dsCliente.Text = "";
            dgProcesos.Rows.Clear();
            dgTempDetProc.Rows.Clear();
            txtBuscarFicha.Clear();
            txtBusCodBarr.Clear();
            txtBuscarTejido.Clear();
            TfRef = "";
        }


        public void EjecutarMuestraEtiqueta(ETejeduria TJ)
        {
            txt_idTejido.Text = TJ.Id_producto;
            txt_nuFicha.Text = TJ.Nu_correficha;
            txt_nuTf.Text = TJ.Nu_tf;
            TfRef = TJ.Nu_tfref;
            BuscarMuestrasEtiqueta();
            txtBuscarTejido.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmMuestrasEtiqueta_qry frm = new FrmMuestrasEtiqueta_qry();
            frm.pasard += new FrmMuestrasEtiqueta_qry.pasar(EjecutarMuestraEtiqueta);
            frm.ShowDialog();
         

        }

        private void BuscarMuestrasEtiqueta()
        {

            ETejeduria oT = new ETejeduria();

            //oT.IdPeriodo = "2014";
            dgProcesos.Rows.Clear();
            //dgTempDetProc.Rows.Clear();

            oT.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

            oT.Id_producto = txt_idTejido.Text;
            oT.Nu_correficha = txt_nuFicha.Text;


            List<ETejeduria> oListDato = BTejeduria.TJ_Tejeduria_qry06(oT);


            string val = oListDato[0].existe;

            if (val == "0")
            {

                try
                {


                    ETejeduria oTJ = new ETejeduria();

                    //oTJ.IdPeriodo = "2014";
                    oTJ.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    oTJ.Id_producto = txt_idTejido.Text;
                    oTJ.Nu_correficha = txt_nuFicha.Text;
                




                    ETejeduria oBtieneTJ = new ETejeduria();
                    oBtieneTJ = BMuestrasEtiqueta.MS_MuestraEtiquetaTela_qry01(oTJ);

                    //txt_idTejido.Text = oBtieneTJ.Id_producto.ToString().Trim();
                    //txt_nuFicha.Text = oBtieneTJ.Nu_correficha.ToString().Trim();
                    txtBuscarTejido.Text = oBtieneTJ.Id_producto.ToString().Trim();
                    txtBuscarFicha.Text = oBtieneTJ.Nu_correficha.ToString().Trim();
                    lbl_dsTejido.Text = oBtieneTJ.ds_producto.ToString().Trim();

                    txt_fecha.Text = oBtieneTJ.Fe_registro.ToString();
                    txt_IdCli.Text = oBtieneTJ.Id_clipro.ToString().Trim();
                    lbl_dsCliente.Text = oBtieneTJ.ds_razonSoc.ToString().Trim();
                    txtBusCodBarr.Text = oBtieneTJ.idCodBar.ToString().Trim();




                    ETejeduria_DetProces oTJDP = new ETejeduria_DetProces();


                    oTJDP.IdEmpresa = wfChgEmpPer.datos.idEmpresa;

                    oTJDP.Id_producto = txt_idTejido.Text;
                    oTJDP.Nu_correficha = txt_nuFicha.Text;




                    List<ETejeduria_DetProces> lstTJP = new List<ETejeduria_DetProces>();
                    lstTJP = BMuestrasEtiqueta.MS_MuestrasEtiquetaDet_qry03(oTJDP);

                    foreach (ETejeduria_DetProces objTJDP in lstTJP)
                    {
                        string[] row =
                        
                                {    objTJDP.IdItem.ToString(),                                  
                                     objTJDP.IdRutaProces.ToString(),
                                };
                        dgProcesos.Rows.Add(row);
                    }


                }

                catch (Exception ex)
                {
                    ex.ToString();
                }

            }
            else
            {
                MessageBox.Show("Datos no existen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            FrnMuestrasEtiqueta_rpt frm = new FrnMuestrasEtiqueta_rpt();
            frm.idProducto = txtBuscarTejido.Text;
            frm.idNuficha = txtBuscarFicha.Text;
            frm.ShowDialog();
           
 
        }

        public object GetDataReport(string key)
        {

            ETejeduria objE = new ETejeduria();


            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            objE.Id_producto = txtBuscarTejido.Text;
            objE.Nu_correficha = txtBuscarFicha.Text;

            BMuestrasEtiqueta objtj = new BMuestrasEtiqueta();
            DataTable dt = objtj.GetMuestraEtiqueta_rpt01(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

        public void Exportar(string key)
        {
            try
            {
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRTejTicket_rpt.rpt";
                objRpt.Load(reportPath);

                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
                saveFileDialog.Filter = "Document (*.pdf)|*.PDF";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.FileName = txtBusCodBarr + ".pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    objRpt.ExportToDisk(ExportFormatType.PortableDocFormat, saveFileDialog.FileName); 
                }

                crExportOptions = objRpt.ExportOptions;


            }
            catch (Exception ex)
            {
                ex.ToString();

            }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }
        private void Grabar()
        {
            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            {
                if (result == DialogResult.OK)
                {


                    DateTime periodo = Convert.ToDateTime(txt_fecha.Text);
                    EEtiqueta_tela ms = new EEtiqueta_tela();

                    if (txtBusCodBarr.Text == "")
                    {
                        List<Dato> oListDato = BMuestrasEtiqueta.MuestraEtiquetaCodBar_qry01(wfChgEmpPer.datos.idEmpresa,periodo.Year.ToString(),txt_nuTf.Text);
                        if (oListDato.Count > 0)
                        {
                            txtBusCodBarr.Text = oListDato[0].id;
                        }                                           
                    }
                    else
                    {
 
                      
                    }
                  
                    for (int i = 0; dgProcesos.Rows.Count > i; i++)
                    {

                      
                       
                        var lblidItem = dgProcesos.Rows[i].Cells["idItem"].Value;
                        var lblidRutaProces = dgProcesos.Rows[i].Cells["idRutaProces"].Value;
                        ms.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                        ms.IdPeriodo = periodo.Year.ToString();
                        ms.Id_producto = txt_idTejido.Text;
                        ms.Nu_correficha = txt_nuFicha.Text;
                        ms.IdCodBar = txtBusCodBarr.Text;
                        ms.Item = lblidItem.ToString();
                        ms.IdRutaProces = lblidRutaProces.ToString();
                        ms.IdCodBar2 = BarcodeConverter128.StringToBarcode(txtBusCodBarr.Text);
                        ms.Id_ucrearec = frmLogin.d.id.ToLower(); //frmLogin.d.id; //llenar con sesion
                        ms.StAnulado = "0";
                        BMuestrasEtiqueta.MS_MuestrasEtiqueta_mnt01(ms);
                    }
                    txtBuscarTejido.Text = txt_idTejido.Text;
                    txtBuscarFicha.Text = txt_nuFicha.Text;
            


                }

            }
        }

        private void dgProcesos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NuevoItem();
            }
        }

        private void btnVistapreviaST_Click(object sender, EventArgs e)
        {
            FrnMuestrasEtiqueta_rpt02 frm = new FrnMuestrasEtiqueta_rpt02();
            frm.idProducto = txtBuscarTejido.Text;
            frm.idNuficha = txtBuscarFicha.Text;
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

    }
}
