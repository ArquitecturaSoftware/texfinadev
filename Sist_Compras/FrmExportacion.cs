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
using Texfina.Core.Web;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmExportacion : Form
    {
        public FrmExportacion()
        {
            InitializeComponent();

            WebHelper.LoadListControl3(cbTermino, BTablaGeneral.tablaGeneral("135"));
            WebHelper.LoadListControl3(cbEmbarque, BTablaGeneral.tablaGeneral("134"));     
        }
        int ancho, alto;
        private void FrmExportacion_Load(object sender, EventArgs e)
        {
            ancho = this.Width;
            alto = this.Height;
        }

        private void btnExportacion_Click(object sender, EventArgs e)
        {
            FrmExportacion_qry frmp = new FrmExportacion_qry();
            frmp.pasard += new FrmExportacion_qry.pasar(EjecutarExp);
            frmp.ShowDialog();

            txtCodigo.Focus();
        }

        public void EjecutarExp(Eexportacion imp)
        {
            txtCodigo.Text = imp.Id_Exporta;
            txtdescripcion.Text = imp.Ds_Exporta;
            cbTermino.SelectedValue = imp.Id_tercom;
            cbEmbarque.SelectedValue = imp.Id_via;

        }
        private void Grabar()
        {
            Eexportacion prov = new Eexportacion();

                       DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                       if (result == DialogResult.OK)
                       {
                           if (txtCodigo.Text == "")
                           {

                               //WebHelper.LoadListControl2(idImp, BExportacion.Exportacion_qry01(Session[ConstSessionVar.PERIODO].ToString(), Session[ConstSessionVar.EMPRESA].ToString()), "id_Exportacion", "id_Exportacion");
                               //hdnidExportacion.Value = idImp.SelectedItem.Text;

                               List<Dato> oListDato = BExportacion.Exportacion_qry01_(wfChgEmpPer.datos.idperiodo, wfChgEmpPer.datos.idEmpresa);
                               if (oListDato.Count > 0)
                               {
                                   txtCodigo.Text = oListDato[0].id;
                               }

                               prov.Id_Exporta = txtCodigo.Text;
                               prov.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                           }
                           else
                           {
                               prov.Id_Exporta = txtCodigo.Text;
                               prov.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                           }
                           prov.Ds_Exporta = txtdescripcion.Text.ToUpper();
                           prov.Id_via = cbEmbarque.SelectedValue.ToString();
                           prov.Id_tercom = cbTermino.SelectedValue.ToString();
                           prov.Id_ucrearec = frmLogin.d.id;
                           prov.Id_uupdarec = frmLogin.d.id;
                          BExportacion.Exportacion_mnt01(prov);
                          MessageBox.Show("Datos Grabados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text != "")
            {
                Grabar();
            }
            else {
                MessageBox.Show("Faltan Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(tableLayoutPanel1);
        }

        private void Limpiar(TableLayoutPanel table )
        {
            //txtnu_oc.Text = "";

            foreach (Control c in table.Controls)
            {

                if (c is TextBox)
                {

                    c.Text = "";


                    this.txtdescripcion.Focus();

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eexportacion prov = new Eexportacion();

            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                prov.Id_Exporta = txtCodigo.Text;
                prov.Id_Empresa = wfChgEmpPer.datos.idEmpresa;
                prov.Id_uupdarec = frmLogin.d.id;
                BExportacion.ExportacionEliminar_mnt01(prov);
                MessageBox.Show("Datos Anulados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(tableLayoutPanel1);
            }
          
        }

        private void FrmExportacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G && e.Control)
            {
                Grabar();
            }
            else if (e.KeyCode == Keys.N && e.Control)
            {
                Limpiar(tableLayoutPanel1);
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                FrmExportacion_qry frmp = new FrmExportacion_qry();
                frmp.pasard += new FrmExportacion_qry.pasar(EjecutarExp);
                frmp.ShowDialog();

                txtCodigo.Focus();
            }
            else if (e.KeyCode == Keys.Escape )
            {
                this.Close();
            }

        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmExportacion_qry frmp = new FrmExportacion_qry();
                frmp.pasard += new FrmExportacion_qry.pasar(EjecutarExp);
                frmp.ShowDialog();

                txtCodigo.Focus();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExportacion_Resize(object sender, EventArgs e)
        {
            //this.Size = new System.Drawing.Size(ancho, alto);
        }
    }
}
