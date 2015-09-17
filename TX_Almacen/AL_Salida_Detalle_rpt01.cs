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
using Texfina.Core.Web;
using Texfina.Entity.Al;

namespace TX_Almacen
{
    public partial class Frm_Salida_Detalle_rpt01 : Form
    {
        public Frm_Salida_Detalle_rpt01()
        {
            InitializeComponent();
        }

        private void AL_Salida_Detalle_rpt01_Load(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cbTipo, BGeneral.ObtenerDatoidTabla("145"));
  
            WebHelper.LoadListControl3(cbMercado, BGeneral.ObtenerDatoidTabla("104"));
            WebHelper.LoadListControl3(cbTiptela, BGeneral.ObtenerDatoidTabla("147"));
            cbTipo.SelectedIndex = -1;
        
            cbMercado.SelectedIndex = -1;
            cbTiptela.SelectedIndex = -1;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente_qry frmp = new frmCliente_qry();
            frmp.pasard += new frmCliente_qry.pasar(ejecutarCliente);
            frmp.ShowDialog();
            txtidCliente.Focus();
        }
        public void ejecutarCliente(ECliente cl)
        {
            txtidCliente.Text = cl.Id_clipro;
            lblCliente.Text = cl.Ds_raznombre;
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProducto_qry frmp = new frmProducto_qry();
            frmp.pasard += new frmProducto_qry.pasar(ejecutarProd);
            frmp.ShowDialog();
            txtidProducto.Focus();
        }
        public void ejecutarProd(Texfina.Entity.Co.EDetProducto prd)
        {
            txtidProducto.Text = prd._Codigo;
            lblProducto.Text = prd._Producto;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            frnColor_qry frmp = new frnColor_qry();
            frmp.pasard += new frnColor_qry.pasar(ejecutarColor);
            frmp.ShowDialog();
            txtidColor.Focus();
        }

        public void ejecutarColor(Texfina.Entity.TJ.EColor col)
        {
            txtidColor.Text = col.Id_color;
            lblColor.Text = col.Ds_color;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ExportReporStock("");
        }

        public void ExportReporStock(string key)
        {
            DataSet ds = (DataSet)this.Get_ExportarStock(key);
            //DataSet ds = (DataSet)this.GetDataReport(key);

           // ExcelLibrary.DataSetHelper.CreateWorkbook("C:\\Reporte\\DATA.xls", ds);

           // MessageBox.Show("Registros Exportados", "Advertencia", MessageBoxButtons.OK);

        }

        public object Get_ExportarStock(string key)
        {

            ESalida_Detalle obj = new ESalida_Detalle();

            
            obj.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
            obj.Fe_creatrec = dtFechaIni.Value;
            obj.Fe_uupdarec = dtFechaFin.Value;
            obj.Id_vendedor = txtid_vendedor.Text;
            obj.Id_producto = txtidProducto.Text;
            obj.Id_color = txtidColor.Text;

            obj._id_cliente = txtidCliente.Text;
            obj.Id_tipo = cbTipo.Text;
            obj.Id_mercado = cbMercado.Text;
            obj.Id_tiptela = cbTiptela.Text;

            BSalida_Detalle _obj = new BSalida_Detalle();
            DataTable dt = _obj.AL_Salida_Detalle_rpt02(obj);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            frmVendedorQry frmps = new frmVendedorQry();
            frmps.pasard += new frmVendedorQry.pasar(ejecutarVendedor);
            frmps.ShowDialog();
            txtid_vendedor.Focus();
        }

        public void ejecutarVendedor(string idPers, string dsPers)
        {
            txtid_vendedor.Text = idPers;
            lblvendedor.Text = dsPers;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportReporStock("");
        }
    }
}
