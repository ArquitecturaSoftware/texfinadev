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
    public partial class FrmExportacion_qry : Form
    {
        public FrmExportacion_qry()
        {
            InitializeComponent();
        }
        int psintypesel = 1;
        private void ListarExportaciones()
        {
            try
            {
                Eexportacion exp = new Eexportacion();
                if (psintypesel == 1)
                {
                   

                    exp.psintypesel = 1;
                    exp.Id_Exporta = txtCodigo.Text;
                    exp.Ds_Exporta = txtCodigo.Text;
                    exp.Id_Periodo = wfChgEmpPer.datos.idperiodo;
                    exp.Id_Empresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BExportacion.GetListFill(exp);
                    dgExportacion.DataSource = ds.Tables[0];
                    lblnumitem.Text = Convert.ToInt16(dgExportacion.RowCount).ToString();
                }
                else if (psintypesel == 2)
                {
                
                    exp.psintypesel = 1;
                    exp.Id_Exporta = txtCodigo.Text;
                    exp.Ds_Exporta = txtexport.Text;
                    exp.Id_Periodo = wfChgEmpPer.datos.idperiodo;
                    exp.Id_Empresa = wfChgEmpPer.datos.idEmpresa;

                    DataSet ds = BExportacion.GetListFill(exp);
                    dgExportacion.DataSource = ds.Tables[0];
                    lblnumitem.Text = Convert.ToInt16(dgExportacion.RowCount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtexport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtexport.Text != "")
                {
                    psintypesel = 2;
                    ListarExportaciones();
                    dgExportacion.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ListarExportaciones();
                    dgExportacion.Focus();
                }
                else
                {
                    MessageBox.Show("Información", "No hay datos a buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        int ancho, alto;
        private void Frmexportacion_qry_Load(object sender, EventArgs e)
        {


            ancho = this.Width;
            alto = this.Height;
            
            psintypesel = 1;
            ListarExportaciones();
        }


        public delegate void pasar(Eexportacion exp);
        public event pasar pasard;

  
        private void dgExportacion_DoubleClick(object sender, EventArgs e)
        {
            Eexportacion exp = new Eexportacion();
            exp.Id_Exporta = dgExportacion.CurrentRow.Cells["Codigo"].Value.ToString();
            exp.Ds_Exporta = dgExportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
            exp.Id_tercom = dgExportacion.CurrentRow.Cells["TComerc"].Value.ToString();
            exp.Id_via = dgExportacion.CurrentRow.Cells["Via"].Value.ToString();
            pasard(exp);

            this.Dispose();
        }

        private void FrmExportacion_qry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmExportacion_qry_Resize(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(ancho, alto);

        }

        private void dgExportacion_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dgExportacion.BeginEdit(false);
        }



        private void dgExportacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lblnumitem.Text == "0")
                {
                    MessageBox.Show("No hay registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtexport.Focus();
                }
                else
                {
                    Eexportacion exp = new Eexportacion();
                    exp.Id_Exporta = dgExportacion.CurrentRow.Cells["Codigo"].Value.ToString();
                    exp.Ds_Exporta = dgExportacion.CurrentRow.Cells["Descripcion"].Value.ToString();
                    exp.Id_tercom = dgExportacion.CurrentRow.Cells["TComerc"].Value.ToString();
                    exp.Id_via = dgExportacion.CurrentRow.Cells["Via"].Value.ToString();
                    pasard(exp);

                    this.Dispose();
                    e.SuppressKeyPress = true;
                }
                }

                

            
        }
    }
}
