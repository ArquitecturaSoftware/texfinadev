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
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class Frmimportacion_qry : Form
    {
        public Frmimportacion_qry()
        {
            InitializeComponent();
        }

        int psintypesel = 1;

        private void ListarImportaciones()
        {
            try
            {
                EImportacion imp = new EImportacion();
                if (psintypesel == 1)
                {                  
                    imp.psintypesel = 1;
                    imp.Id_importa = txtCodigo.Text;
                    imp.Ds_importa = txtimportacion.Text;
                    imp.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BImportacion.GetListFill(imp);
                    dgImportacion.DataSource=ds.Tables[0];
                    lblnumitem.Text = Convert.ToInt16(dgImportacion.RowCount ).ToString();

                }
                else if (psintypesel == 2)
                {
         
                    imp.psintypesel = 2;
                    imp.Id_importa = txtCodigo.Text;
                    imp.Ds_importa = txtimportacion.Text;
                    imp.Id_empresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BImportacion.GetListFill(imp);
                    dgImportacion.DataSource = ds.Tables[0];
                    lblnumitem.Text = Convert.ToInt16(dgImportacion.RowCount).ToString();
                }
            
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtimportacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtimportacion.Text != "")
                {
                    psintypesel = 2;
                    ListarImportaciones();
                    dgImportacion.Focus();
                }
                else
                {
                    MessageBox.Show("No hay datos a buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text != "")
                {
                    psintypesel = 2;
                    ListarImportaciones();
                    dgImportacion.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        string Id_imp_;
        //string ds_exp_;
        //public delegate void pasar(string idimp);
        public delegate void pasar(EImportacion idimp);
        public event pasar pasard;

        //public delegate void pasarImportacion(EImportacion imp);
        //public event pasarImportacion pasarImp;

        //private void dgImportacion_KeyUp(object sender, KeyEventArgs e)
        //{
        //    //if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
        //    //{
        //    //    EImportacion imp = new EImportacion();
        //    //        imp.Id_importa = dgImportacion.CurrentRow.Cells["Codigo"].Value.ToString();
        //    //        imp.Ds_importa = dgImportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
        //    //        imp.Id_tercom = dgImportacion.CurrentRow.Cells["TComerc"].Value.ToString();
        //    //        imp.Id_via = dgImportacion.CurrentRow.Cells["Via"].Value.ToString();

        //    //    pasard(imp);
                       

        //    //        this.Dispose();
        //    //}

        //    if (dgImportacion.SelectedRows.Count == 0)
        //        return;

        //    if (e.KeyCode == Keys.F1)
        //    {
        //        EImportacion imp = new EImportacion();
        //        imp.Id_importa = dgImportacion.CurrentRow.Cells["Codigo"].Value.ToString();
        //        imp.Ds_importa = dgImportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
        //        imp.Id_tercom = dgImportacion.CurrentRow.Cells["TComerc"].Value.ToString();
        //        imp.Id_via = dgImportacion.CurrentRow.Cells["Via"].Value.ToString();

        //        pasard(imp);


        //        this.Dispose();
        //    }
        //}
        int ancho, alto;
        private void Frmimportacion_qry_Load(object sender, EventArgs e)
        {


            ancho = this.Width;
            alto = this.Height;

            
            psintypesel = 1;
            ListarImportaciones();
        }

        private void dgImportacion_DoubleClick(object sender, EventArgs e)
        {
            EImportacion imp = new EImportacion();
            imp.Id_importa = dgImportacion.CurrentRow.Cells["Codigo"].Value.ToString();
            imp.Ds_importa = dgImportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
            imp.Id_tercom = dgImportacion.CurrentRow.Cells["TComerc"].Value.ToString();
            imp.Id_via = dgImportacion.CurrentRow.Cells["Via"].Value.ToString();

            pasard(imp);


            this.Dispose();
        }

        private void Frmimportacion_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Frmimportacion_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);
        }

        private void dgImportacion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgImportacion.BeginEdit(false);
        }

      

        private void dgImportacion_KeyDown(object sender, KeyEventArgs e)
        {
            //if (dgImportacion.SelectedRows.Count == 0)
            //    return;

           if (e.KeyCode == Keys.Enter)
            {
                if (lblnumitem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtimportacion.Focus();
                }
                else
                {
                    EImportacion imp = new EImportacion();
                    imp.Id_importa = dgImportacion.CurrentRow.Cells["Codigo"].Value.ToString();
                    imp.Ds_importa = dgImportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
                    imp.Id_tercom = dgImportacion.CurrentRow.Cells["TComerc"].Value.ToString();
                    imp.Id_via = dgImportacion.CurrentRow.Cells["Via"].Value.ToString();

                    pasard(imp);


                    this.Dispose();


                    e.SuppressKeyPress = true;
                }

            }
        }
    }
}
