using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOMnt.Ve;
using Texfina.BOQry.Co;
using Texfina.Core.Web;
using Texfina.DOQry.Sy;
using Texfina.Entity.Al;
using Texfina.Entity.Ve;
using Texfina.Entity.Sy;


namespace TX_Almacen
{
    public partial class frmAnticiposMnt : Form
    {
        public frmAnticiposMnt()
        {
            InitializeComponent();
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }



        private void Grabar()
        {
            try
            {
                
                EAnticipos Anticipo = new EAnticipos();

                DialogResult result = MessageBox.Show("Seguro que desea Grabar?", "Grabar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (txtIdAnticipo.Text == "")
                    {
                        
                        List<Dato> oListDato = BAnticipos.GenCodeAnticiposMnt(wfChgEmpPer.datos.idEmpresa);

                        if (oListDato.Count > 0)
                        {
                            txtIdAnticipo.Text = oListDato[0].id;
                            Anticipo.IdAnticipo = txtIdAnticipo.Text;
                        }
                    }
                    else
                    {
                        //prov.Id_clipro = txtCodProv.Text;
                    }
                   
                    //MessageBox.Show("Datos Grabados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
