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
    public partial class frmImportacion : Form
    {
        public frmImportacion()
        {
            InitializeComponent();

            WebHelper.LoadListControl3(cbTermino, BTablaGeneral.tablaGeneral("135"));
            WebHelper.LoadListControl3(cbEmbarque, BTablaGeneral.tablaGeneral("134"));              
        }
        int ancho, alto;
        private void frmImportacion_Load(object sender, EventArgs e)
        {
            ancho = this.Width;
            alto = this.Height;
        }

        private void btnImportacion_Click(object sender, EventArgs e)
        {
            Frmimportacion_qry frmp = new Frmimportacion_qry();
            frmp.pasard += new Frmimportacion_qry.pasar(EjecutarImp);
            frmp.ShowDialog();

            txtCodigo.Focus();

        }

        public void EjecutarImp(EImportacion imp)
        {
            txtCodigo.Text = imp.Id_importa;
            txtdescripcion.Text = imp.Ds_importa;
            cbTermino.SelectedValue = imp.Id_tercom;
            cbEmbarque.SelectedValue = imp.Id_via;
          
        }

        private void Grabar()
        { 
            EImportacion prov = new EImportacion();

            DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                if (txtCodigo.Text == "")
                {
                    List<Dato> oListDato = BImportacion.Importacion_qry01_(wfChgEmpPer.datos.idperiodo, wfChgEmpPer.datos.idEmpresa);

                    if (oListDato.Count > 0)
                    {
                        txtCodigo.Text = oListDato[0].id;
                    }

                    prov.Id_importa = txtCodigo.Text;
                    prov.Id_periodo = wfChgEmpPer.datos.idperiodo;
                    prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                }
                else
                {
                    prov.Id_importa = txtCodigo.Text;
                    prov.Id_periodo = wfChgEmpPer.datos.idperiodo;
                    prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                }
                prov.Ds_importa = txtdescripcion.Text.ToUpper();
                prov.Id_via = cbEmbarque.SelectedValue.ToString();
                prov.Id_tercom = cbTermino.SelectedValue.ToString();
                prov.Id_ucrearec = frmLogin.d.id;
                prov.Id_uupdarec = frmLogin.d.id;
                BImportacion.Importacion_mnt01(prov);
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

        private void Eliminar() {
            EImportacion prov = new EImportacion();

            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                prov.Id_importa = txtCodigo.Text;
                prov.Id_empresa = wfChgEmpPer.datos.idEmpresa;
                prov.Id_uupdarec = frmLogin.d.id;
                BImportacion.ImportacionEliminar_mnt01(prov);
                MessageBox.Show("Datos Anulados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar(tableLayoutPanel1);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();                     
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(tableLayoutPanel1);
        }

        private void Limpiar( TableLayoutPanel table)
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

        private void frmImportacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                Limpiar(tableLayoutPanel1);
            }
            else if (e.KeyCode == Keys.G && e.Control)
            {
                Grabar();
            }
            else if (e.KeyCode == Keys.E && e.Control)
            {
                Eliminar();
            }
            else if (e.KeyCode == Keys.B && e.Control)
            {
                Frmimportacion_qry frmp = new Frmimportacion_qry();
                frmp.pasard += new Frmimportacion_qry.pasar(EjecutarImp);
                frmp.ShowDialog();

                txtCodigo.Focus();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Frmimportacion_qry frmp = new Frmimportacion_qry();
                frmp.pasard += new Frmimportacion_qry.pasar(EjecutarImp);
                frmp.ShowDialog();

                txtCodigo.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImportacion_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);
        }
    }
}
