using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOMnt.Al;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class FrmProductoDetallePopup : Form
    {
        public delegate void pasar(string estado);
        public event pasar pasard;


        public FrmProductoDetallePopup()
        {

            InitializeComponent();
            //if (EstadoDet == 1)
            //{
                txtpeso.Focus();
           
            //}
        }

        public object FormParent3 { get; set; }

        public int EstadoDet = 0;
        public string _lblIdIngreso;
        public string _index;
        public int _detalle;
        private void FrmProductoDetallePopup_Load(object sender, EventArgs e)
        {
            lblcont.Text = "1";
            lblIdIngreso.Text = _lblIdIngreso;

            
            if (_detalle != 2)
            {
                txtnuitem.Text = dgDetalle.Rows[0].Cells["Item"].Value.ToString();
                txtCodbarra.Text = dgDetalle.Rows[0].Cells["CodBarra"].Value.ToString();
                txtnrollo.Text = dgDetalle.Rows[0].Cells["Und"].Value.ToString();
                txtpeso.Text = dgDetalle.Rows[0].Cells["peso_real"].Value.ToString();
                lblnuitem.Text = dgDetalle.RowCount.ToString();
            }
            else
            {
                txtnuitem.Text = dgDetalle.Rows[Convert.ToInt16(_index)].Cells["Item"].Value.ToString();
                txtCodbarra.Text = dgDetalle.Rows[Convert.ToInt16(_index)].Cells["CodBarra"].Value.ToString();
                txtnrollo.Text = dgDetalle.Rows[Convert.ToInt16(_index)].Cells["Und"].Value.ToString();
                txtpeso.Text = dgDetalle.Rows[Convert.ToInt16(_index)].Cells["peso_real"].Value.ToString();
                lblnuitem.Text = dgDetalle.RowCount.ToString();
            }

        }


        public void LlenarGrilla(EIngresoDetalle obj, object form)
        {

            string str = Convert.ToString(dgDetalle.Rows.Count + 1);


            //EIngresoDetalle obj= new EIngresoDetalle();
            string[] row = { obj.Nu_Item,
                            obj.Cod_Bar,
                            obj.Qt_rollo.ToString(),
                            obj.Qt_peso_desp.ToString(),
                            obj.Qt_peso_real.ToString(),                           
                           };

            dgDetalle.Rows.Add(row);
           
        }


         int count = 0;



        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {

            Carga();
            pasard("1");

        }

        private void Carga()
        {
            //*********************************
            Grabar();
            PrintReport("");
            //*********************************

            if (_detalle != 2)
            {
                if (Convert.ToInt16(lblnuitem.Text) > Convert.ToInt16(lblcont.Text))
                {
                    txtnuitem.Text = dgDetalle.Rows[Convert.ToInt16(lblcont.Text)].Cells["Item"].Value.ToString();
                    txtCodbarra.Text = dgDetalle.Rows[Convert.ToInt16(lblcont.Text)].Cells["CodBarra"].Value.ToString();
                    txtnrollo.Text = dgDetalle.Rows[Convert.ToInt16(lblcont.Text)].Cells["Und"].Value.ToString();
                    txtpeso.Text = dgDetalle.Rows[Convert.ToInt16(lblcont.Text)].Cells["peso_real"].Value.ToString();
                    lblcont.Text = Convert.ToString(Convert.ToInt16(lblcont.Text) + (count + 1));
                }
                else
                {
                    MessageBox.Show("No hay mas registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmProductoPopup frmanterior = (frmProductoPopup)FormParent3;
                    //EIngresoDetalle obj = new EIngresoDetalle();
                    //frmanterior.CargarDetalle();
                    this.Dispose();
                }

            }

            else
            {
                this.Dispose();
            }
            //********************************************************************
        }
         

        private void Grabar()
        {
            EIngresoDetalle objID = new EIngresoDetalle();
            if (lblIdIngreso.Text != "")
            {

                objID.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objID.IdPeriodo = wfChgEmpPer.datos.idperiodo;
                objID.Cod_Bar = txtCodbarra.Text;
                objID.IdIngreso = lblIdIngreso.Text;
                objID.Qt_peso_real = Convert.ToDecimal(txtpeso.Text);
                objID.Id_uupdarec = frmLogin.d.id.ToLower();


               if (_detalle != 2)
                {
                    BIngreso_Detalle.AL_Ingreso_Detalle_mnt05(objID);
                }
               else
               {
                   BIngreso_Detalle.AL_Ingreso_Detalle_mnt05(objID);
                   //this.Dispose();
               }
              
             }
            }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Carga();
                pasard("1");
                txtpeso.SelectionStart = 0;
                txtpeso.SelectionLength = txtpeso.Text.Length;
            }
        
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }


        public object GetDataReport(string key)
        {
            EIngresoDetalle objE = new EIngresoDetalle();
            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            //objE.IdPeriodo = txtCodbarra.Text.Substring(0,4);
            objE.IdIngreso = lblIdIngreso.Text;
            objE.Cod_Bar  = txtCodbarra.Text;

            BIngreso_Detalle objI = new BIngreso_Detalle();
            DataTable dt = objI.AL_Ingreso_etiqueta02_rpt(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
            //-----------------------------------------------------------------
        }

       

        public void PrintReport(string key)
        {
            try
            {
                //----------------------------------------
                ReportDocument objRpt = new ReportDocument();
                DataSet ds = (DataSet)this.GetDataReport(key);

                string reportPath = "C:\\Reportes\\CRIngreso_etiqueta02.rpt";
                objRpt.Load(reportPath);

                DiskFileDestinationOptions crDiskFileDestinationOption = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions crFormatTypeOption = new PdfRtfWordFormatOptions();
                ExportOptions crExportOptions = new ExportOptions();

                objRpt.SetDataSource(ds.Tables[0]);
                string strfolder = "C:\\Reporte\\";
                crDiskFileDestinationOption.DiskFileName = strfolder + "Etiqueta.pdf";
                crExportOptions = objRpt.ExportOptions;
                crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                crExportOptions.ExportDestinationOptions = crDiskFileDestinationOption;
                crExportOptions.ExportFormatOptions = crFormatTypeOption;
                objRpt.Export();
                //---------------------------------------
                 ////string PrinterName = this.printDocument1.PrinterSettings.PrinterName;
                 //string NombreImpresora = "";

                 ////for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                 ////{
                 ////    PrinterSettings a = new PrinterSettings();
                 ////    a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                 ////    if (a.IsDefaultPrinter)
                 ////    {

                 ////        PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                 ////    }
                 ////}

                //this.printDialog1.Document = this.printDocument1;
                //DialogResult dr = this.printDialog1.ShowDialog();
                //if (dr == DialogResult.OK)
                //     {
                         PageMargins margins;
                         margins = objRpt.PrintOptions.PageMargins;
                         margins.bottomMargin = 250;
                         margins.leftMargin = 250;
                         margins.rightMargin = 250;
                         margins.topMargin = 250;
                         objRpt.PrintOptions.ApplyPageMargins(margins);
                     //string PrinterName = this.printDocument1.PrinterSettings.PrinterName;
                     //                    ////objRpt.PrintOptions.PrinterName = PrinterName;
                    objRpt.PrintOptions.PrinterName = GetImpresoraDefecto();
                         //objRpt.PrintOptions.PrinterName = PrinterName;
                         objRpt.PrintToPrinter(1, false, 0, 0);
                     //}
                 
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

        }


        
    public static string  GetImpresoraDefecto()
        {
         for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                   return   PrinterSettings.InstalledPrinters[i].ToString();

                }
            }
            return "";
        }

        private void FrmProductoDetallePopup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        //listado de impresoras

        //private void PopulateInstalledPrintersCombo()
        //{
        //    // Add list of installed printers found to the combo box.
        //    // The pkInstalledPrinters string will be used to provide the display string.
        //    String pkInstalledPrinters;
        //    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
        //    {
        //        pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
        //        comboBox1.Items.Add(pkInstalledPrinters);
        //    }
        //}

       



    }
}
