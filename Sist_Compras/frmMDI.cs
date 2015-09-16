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
using Texfina.Entity.Co;
using Texfina.Entity.Sy;
using SYBOQry = Texfina.BOQry.Sy;

namespace Sist_Compras
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private Boolean OpenSubForm(Form form)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == form.Name)
                {
                    return false;
                }
            }
            form.Show();
            return true;
        }



        private void frmMDI_Load(object sender, EventArgs e)
        {
            lblusuario.Text = frmLogin.d.id;
            lblNomape.Text = frmLogin.d.dsu;
            lblEmpresa.Text = wfChgEmpPer.datos.dsEmpresa;
            lblperiodo.Text = wfChgEmpPer.datos.idperiodo;

            DateTime fecha = DateTime.Now;
            lblfecha.Text = fecha.ToString("d");

            //BuildTreeMenu();
        }

        private void BuildTreeMenu()
        {
            DataTable dt = new DataTable();
            
           BGeneral.ObtenerDatoMenuPrincipal();

           foreach (DataRow dr in dt.Rows)
           { 

           }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmImportacion imp = new frmImportacion();
            imp.MdiParent = this;
            //imp.Show();
            OpenSubForm(imp);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmExportacion EXP = new FrmExportacion();
            EXP.MdiParent = this;
            OpenSubForm(EXP);
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmProveedor_mnt prov = new FrmProveedor_mnt();
            prov.MdiParent = this;
            OpenSubForm(prov);
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Frmco_ordenCompra_mnt oc = new Frmco_ordenCompra_mnt();
            oc.MdiParent = this;
            OpenSubForm(oc);
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Frmproducto_mnt prd = new Frmproducto_mnt();
            prd.MdiParent = this;
            OpenSubForm(prd);
            

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            FrmAutorizacionOC au = new FrmAutorizacionOC();
            au.MdiParent = this;
            OpenSubForm(au);
            
        }

        private void ventanaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ventanaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FrmFactura_mnt fac = new FrmFactura_mnt();
            fac.MdiParent = this;
            OpenSubForm(fac);
                       
        }

        private void btnAprobacion_Click(object sender, EventArgs e)
        {
            FrmAprobacionOC frm = new FrmAprobacionOC();
            frm.MdiParent = this;
            OpenSubForm(frm);

        }

        private void ToolExportación_Click(object sender, EventArgs e)
        {
            FrmExportacion EXP = new FrmExportacion();
            EXP.MdiParent = this;
            OpenSubForm(EXP);
            
        }

        private void ToolImportaciones_Click(object sender, EventArgs e)
        {
            frmImportacion imp = new frmImportacion();
            imp.MdiParent = this;
            OpenSubForm(imp);
            
        }

        private void ToolProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor_mnt prov = new FrmProveedor_mnt();
            prov.MdiParent = this;
            OpenSubForm(prov);
            
        }

        private void ToolProducto_Click(object sender, EventArgs e)
        {
            Frmproducto_mnt prd = new Frmproducto_mnt();
            prd.MdiParent = this;
            OpenSubForm(prd);
            
        }

        private void ToolOC_Click(object sender, EventArgs e)
        {
            Frmco_ordenCompra_mnt oc = new Frmco_ordenCompra_mnt();
            oc.MdiParent = this;
            OpenSubForm(oc);
            
        }

        private void ToolAutorizacion_Click(object sender, EventArgs e)
        {
            FrmAutorizacionOC au = new FrmAutorizacionOC();
            au.MdiParent = this;
            OpenSubForm(au);
            
        }

        private void ToolAprobacion_Click(object sender, EventArgs e)
        {
            FrmAprobacionOC frm = new FrmAprobacionOC();
            frm.MdiParent = this;
            OpenSubForm(frm);
            
        }

        private void ToolFacturas_Click(object sender, EventArgs e)
        {
            FrmFactura_mnt fac = new FrmFactura_mnt();
            fac.MdiParent = this;
            OpenSubForm(fac);
            
        }

        private void ToolSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLiberarOC_Click(object sender, EventArgs e)
        {
            FrmLiberarOC loc = new FrmLiberarOC();
            loc.MdiParent = this;
            OpenSubForm(loc);
            
        }
  
        private void ToolliberarOC_Click(object sender, EventArgs e)
        {
            FrmLiberarOC frm = new FrmLiberarOC();
            frm.MdiParent = this;
            OpenSubForm(frm);
            
        }

        private void ToolordenCompra_rpt_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra_Rpt rpt = new FrmOrdenCompra_Rpt();
            rpt.MdiParent = this;
            OpenSubForm(rpt);
            
        }

        private void ToolOrdenCompraXProveedores_rpt_Click(object sender, EventArgs e)
        {
            FrmCOreporteOCxProv rpt = new FrmCOreporteOCxProv();
            rpt.MdiParent = this;
            OpenSubForm(rpt);
        }

        private void Toolfamilia_Click(object sender, EventArgs e)
        {
            FrmFamilia_mnt fm = new FrmFamilia_mnt();
            fm.MdiParent = this;
            OpenSubForm(fm);                          
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
