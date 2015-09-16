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
    public partial class FrmOrdenCompra_Rpt : Form
    {
        public FrmOrdenCompra_Rpt()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {

            string estado = cbEstado.SelectedValue.ToString();

            if (estado == "P")
            {
                ExportReportAprobado("");
            }
            else
            {
                ExportReportTransito("");
            }
        }

        public void ExportReportAprobado(string key)
        {
            DataSet ds = (DataSet)this.GetDataReport02(key);
            //DataSet ds = (DataSet)this.GetDataReport(key);

            ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\DATA.xls", ds);
            
            MessageBox.Show("Registros Exportados", "Advertencia", MessageBoxButtons.OK);
            
        }

        public void ExportReportTransito(string key)
        {
            DataSet ds = (DataSet)this.GetDataReportTransito(key);
            //DataSet ds = (DataSet)this.GetDataReport(key);

            ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\DATA.xls", ds);

            MessageBox.Show("Registros Exportados", "Advertencia", MessageBoxButtons.OK);

        }


        public object GetDataReport(string key)
        {

            EParOCFillrpt objE = new EParOCFillrpt();

            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
            objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            objE.IdMesIni = cbMesIni.SelectedValue.ToString().Trim();
           
            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.OrderCompra_rpt01(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }



        public object GetDataReport02(string key)
        {//aprobado

            EParOCFillrpt objE = new EParOCFillrpt();

            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
            objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            objE.IdMesIni = cbMesIni.SelectedValue.ToString().Trim();
            objE.IdMesfin = cbMesFin.SelectedValue.ToString().Trim();
            objE.st_aprueba = cbEstado.SelectedValue.ToString().Trim();

            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.CO_OrdenCompra_qry08_rpt(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

        public object GetDataReportTransito(string key)
        {
            //transito
            EParOCFillrpt objE = new EParOCFillrpt();

            objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
            objE.IdAnio = wfChgEmpPer.datos.idperiodo;
            objE.IdMesIni = cbMesIni.SelectedValue.ToString().Trim();
            objE.IdMesfin = cbMesFin.SelectedValue.ToString().Trim();
            objE.st_aprueba = cbEstado.SelectedValue.ToString().Trim();

            BOrdenCompra objOC = new BOrdenCompra();
            DataTable dt = objOC.CO_OrdenCompra_qry09_rpt(objE);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }
        private void FrmOrdenCompra_Rpt_Load(object sender, EventArgs e)
        {
           
            
            
            DataTable dt1;
            dt1 = new DataTable("Tabla1");
            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");

            DataRow dr;
            dr = dt1.NewRow();
            dr["Codigo"] = "01";
            dr[1] = "Enero";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "02";
            dr[1] = "Febrero";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "03";
            dr[1] = "Marzo";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "04";
            dr[1] = "Abril";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "05";
            dr[1] = "Mayo";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "06";
            dr[1] = "Junio";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "07";
            dr[1] = "Julio";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "08";
            dr[1] = "Agosto";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "09";
            dr[1] = "Setiembre";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "10";
            dr[1] = "Octubre";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "11";
            dr[1] = "Noviembre";
            dt1.Rows.Add(dr);

            dr = dt1.NewRow();
            dr["Codigo"] = "12";
            dr[1] = "Diciembre";
            dt1.Rows.Add(dr);

            this.cbMesIni.DataSource = dt1;
            this.cbMesIni.ValueMember = "Codigo";
            this.cbMesIni.DisplayMember = "Descripcion";


            //-------------------------------------------------------------------------------

            DataTable dt3;
            dt3 = new DataTable("Tabla3");
            dt3.Columns.Add("Codigo3");
            dt3.Columns.Add("Descripcion");

            DataRow dr3;
            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "01";
            dr3[1] = "Enero";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "02";
            dr3[1] = "Febrero";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "03";
            dr3[1] = "Marzo";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "04";
            dr3[1] = "Abril";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "05";
            dr3[1] = "Mayo";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "06";
            dr3[1] = "Junio";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "07";
            dr3[1] = "Julio";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "08";
            dr3[1] = "Agosto";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "09";
            dr3[1] = "Setiembre";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "10";
            dr3[1] = "Octubre";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "11";
            dr3[1] = "Noviembre";
            dt3.Rows.Add(dr3);

            dr3 = dt3.NewRow();
            dr3["Codigo3"] = "12";
            dr3[1] = "Diciembre";
            dt3.Rows.Add(dr3);


            this.cbMesFin.DataSource = dt3;
            this.cbMesFin.ValueMember = "Codigo3";
            this.cbMesFin.DisplayMember = "Descripcion";


            DataTable dt2;
            dt2 = new DataTable("Tabla2");
            dt2.Columns.Add("Codigo2");
            dt2.Columns.Add("Descripcion2");

            DataRow dr2;
            dr2 = dt2.NewRow();
            dr2["Codigo2"] = "P";
            dr2[1] = "Aprobado";
            dt2.Rows.Add(dr2);

            dr2 = dt2.NewRow();
            dr2["Codigo2"] = "T";
            dr2[1] = "Transito";
            dt2.Rows.Add(dr2);

      


            this.cbEstado.DataSource = dt2;
            this.cbEstado.ValueMember = "Codigo2";
            this.cbEstado.DisplayMember = "Descripcion2";

        }

        private void FrmOrdenCompra_Rpt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && e.Control)
            {
                ExportReportAprobado("");
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmOrdenCompra_Rpt_Resize(object sender, EventArgs e)
        {
 


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
      

            FrmInconsistencia frm = new FrmInconsistencia();
            frm.idmesini = cbMesIni.SelectedValue.ToString();
            frm.idmesfin = cbMesFin.SelectedValue.ToString();
            frm.st_aprueba = "P";
            frm.ShowDialog();
        }

        private void btnoccf_Click(object sender, EventArgs e)
        {
            FrmInconsistencia frm = new FrmInconsistencia();
            frm.idmesini = cbMesIni.SelectedValue.ToString();
            frm.idmesfin = cbMesFin.SelectedValue.ToString();
            frm.st_aprueba = "T";
            frm.ShowDialog();
        }

  

    }
}
