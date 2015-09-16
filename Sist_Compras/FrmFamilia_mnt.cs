using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.Entity.Co;


namespace Sist_Compras
{
    public partial class FrmFamilia_mnt : Form
    {
        public FrmFamilia_mnt()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar3();
        }

        private void Grabar()
        {
            EFamilia fm = new EFamilia();

            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                fm.Id_grupo = cbidgrupo2.SelectedValue.ToString();
                fm.Id_familia = cbidfamilia2.SelectedValue.ToString();
                fm.Id_subfami = txtidsubfamilia.Text;
                fm.Ds_familia = txtdsSubFamila.Text;
                fm.Nu_ultgen = 0;
                fm.Id_ucrearec = frmLogin.d.id;
                fm.Id_uupdarec = frmLogin.d.id;
                fm.St_anulado = "0";
                BFamilia.Familia_mnt01(fm);
                llenarSubFamilia();
            }
        }


        private void Grabar2()
        {
            EFamilia fm = new EFamilia();

            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                fm.Id_grupo = cbIdgrupo.SelectedValue.ToString();
                fm.Id_familia = txtidfamilia.Text;
                fm.Id_subfami = "00";
                fm.Ds_familia = txtdsfamilia.Text;
                fm.Nu_ultgen = 0;
                fm.Id_ucrearec = frmLogin.d.id;
                fm.Id_uupdarec = frmLogin.d.id;
                fm.St_anulado = "0";
                BFamilia.Familia_mnt01(fm);
                llenarFamilia(); 
            }
        }

        private void Grabar3()
        {
            EFamilia fm = new EFamilia();

            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
                fm.Id_grupo = txtidgrupo.Text;
                fm.Id_familia = "00";
                fm.Id_subfami = "00";
                fm.Ds_familia = txtdsgrupo.Text;
                fm.Nu_ultgen = 0;
                fm.Id_ucrearec = frmLogin.d.id;
                fm.Id_uupdarec = frmLogin.d.id;
                fm.St_anulado = "0";
                BFamilia.Familia_mnt01(fm);
                llenarGrupo();
            }
        }


        private void FrmFamilia_mnt_Load(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cbIdgrupo, BFamilia.GetListFill_Qry01_(11, wfChgEmpPer.datos.idEmpresa));
            WebHelper.LoadListControl3(cbidgrupo2, BFamilia.GetListFill_Qry01_(11, wfChgEmpPer.datos.idEmpresa));

            llenarGrupo();
        }

        private void llenarGrupo()
        {
            EFamilia fm = new EFamilia();
            fm.psintypesel = 11;
            fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
            fm.Id_grupo = "";
            fm.Id_familia = "";
            fm.Id_subfami = "";

            DataSet ds = BFamilia.GetFamilia(fm);
            dgFamilia.DataSource = ds.Tables[0];
            
        }


        private void llenarFamilia()
        {
            EFamilia fm = new EFamilia();
            fm.psintypesel = 12;
            fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
            fm.Id_grupo = cbIdgrupo.SelectedValue.ToString();
            fm.Id_familia = "";
            fm.Id_subfami = "";

            DataSet ds = BFamilia.GetFamilia(fm);
            dgFamilia2.DataSource = ds.Tables[0];

        }


        private void llenarSubFamilia()
        {
            EFamilia fm = new EFamilia();
            fm.psintypesel = 13;
            fm.idEmpresa = wfChgEmpPer.datos.idEmpresa;
            fm.Id_grupo = cbidgrupo2.SelectedValue.ToString();
            fm.Id_familia = cbidfamilia2.SelectedValue.ToString();
            fm.Id_subfami = "";

            DataSet ds = BFamilia.GetFamilia(fm);
            dgfamilia3.DataSource = ds.Tables[0];

        }


        private void cbIdgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarFamilia(); 
        }

        private void cbIdgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                llenarFamilia();
                txtidfamilia.Focus();
            }
        }

        private void cbidgrupo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cbidfamilia2, BFamilia.GetListFill_Qry02_(12, cbidgrupo2.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));

        }


        private void cbidgrupo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                WebHelper.LoadListControl3(cbidfamilia2, BFamilia.GetListFill_Qry02_(12, cbidgrupo2.SelectedValue.ToString(), wfChgEmpPer.datos.idEmpresa));
                cbidfamilia2.Focus();
            }
            
            
           
        }

        private void cbidfamilia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                llenarSubFamilia();
                txtidsubfamilia.Focus();
            }
        }

        private void btnGrabar3_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btnGrabar2_Click(object sender, EventArgs e)
        {
            Grabar2();
        }

        private void txtidgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsgrupo.Focus();
            }
        }

        private void txtidfamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsfamilia.Focus();
            }
        }

        private void txtidsubfamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtdsSubFamila.Focus();
            }
        }

        private void txtdsSubFamila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtnumult.Focus();
            }
        }

    }
}
