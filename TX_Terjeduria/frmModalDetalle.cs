using Sist_Compras;
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
using Texfina.BOQry.TJ;
using Texfina.Core.Web;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace TX_Terjeduria
{
    public partial class frmModalDetalle : Form
    {
        public frmModalDetalle()
        {
            InitializeComponent();
        }

        private void frmModalDetalle_Load(object sender, EventArgs e)
        {
            WebHelper.LoadListControl3(cblustre, BGeneral.ObtenerDatoidTabla("141"));
            txtlustre.Text = cblustre.SelectedValue.ToString();


            if (EstadoDet == 1)
            {
                txtpreuni.Text = string.Format("{0:##,##0.0000}", 0);
                txtporcHiloCrudo.Text = string.Format("{0:##,##0.0000}", 0);
                txtporcHiloAcabado.Text = string.Format("{0:##,##0.0000}", 0);
                txttension.Text = string.Format("{0:##,##0.0000}", 0);
                txtNumBobinas.Text = string.Format("{0}", 0);
                txtnumAliment.Text = string.Format("{0}", 0);
                
            }
            else if (EstadoDet == 2)
            {
                
            }

         

        }

        private void btnHilo_Click(object sender, EventArgs e)
        {
            FrmTejido_qry frmp = new FrmTejido_qry();
            frmp.pasard += new FrmTejido_qry.pasar(ejecutarProd);
            frmp.ShowDialog();
            txtHilo.Focus();
        }

        public void ejecutarProd(EDetProducto prd)
        {
            txtHilo.Text = prd._Codigo;
            lblds_producto.Text = prd._Producto;
          
        }

        private void txtAlimenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtAlimenta.Text = txtAlimenta.Text.PadLeft(3, '0');
                txtDistribucion.Focus();
            }
        }

        private void txtDistribucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtEstructura.Focus();
            }
        }

        private void txtEstructura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtHilo.Focus();
            }
        }

        private void txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txttipfibra.Focus();
            }
        }

        private void txttipfibra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtcaracHilo.Focus();
            }

        }

        private void txttitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtlustre.Focus();
            }
        }

        private void txttorsion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtidprov.Focus();
            }
        }

        private void txtidprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtidprov.Text = txtidprov.Text.PadLeft(6, '0');

                EProveedor per = new EProveedor();
                per.psintypesel = 1;
                per.Ds_raznombre = "";
                per.Id_clipro = txtidprov.Text;
                per.Nu_ruc = "";
                per.Id_empresa = wfChgEmpPer.datos.idEmpresa;



                List<Dato> oListDato = BProveedor.ObtenerDatoProveedor(per);
                if (oListDato.Count > 0)
                {
                    lblprov.Text = oListDato[0].desc;
                }
                else
                {
                    MessageBox.Show("Codigo no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtidprov.Clear();
                    lblprov.Text = "";
                    txtidprov.Focus();
                }


                txtlote.Focus();
            }



        }

        private void txtlote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtpreuni.Focus();
            }
        }

        private void txtpreuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtetiqueta.Focus();
            }
        }

        private void txtetiqueta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtporcHiloCrudo.Focus();
            }
        }

        private void txtporcHiloCrudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtporcHiloAcabado.Focus();
            }
        }

        private void txtporcHiloAcabado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txttension.Focus();
            }
        }

        private void txttersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtNumBobinas.Focus();
            }
        }

        private void txtNumBobinas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txtnumAliment.Focus();
            }
        }

        private void txtHilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


                if (txtHilo.Text == "" )
                {
                    MessageBox.Show("Falta ingresar un dato del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
 
          

                EProducto prod = new EProducto();
                prod.Id_producto = txtHilo.Text;
                prod.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                

                 EProducto productoGen = new EProducto();
                 productoGen = BTejido.mListarTejido2(prod);

                 if (productoGen.Id_producto.ToString() != "")
                 {

                         txtHilo.Text = productoGen.Id_producto.ToString();
                         lblds_producto.Text = productoGen.Ds_producto.ToString();
                 }
                 else
                 {
                     MessageBox.Show("Producto no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                 }

                }

                txttipfibra.Focus();
            }
        }

        private void txtcaracHilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                txttitulo.Focus();
            }
        }

        private void txtlustre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                if (cblustre.Text == "")
                {
                    MessageBox.Show("Codigo no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtlustre.Clear();
                    txtlustre.Focus();
                }
                else
                {
                    txtlustre.Text = txtlustre.Text.PadLeft(3, '0');
                    cblustre.SelectedValue = txtlustre.Text;
                    txttorsion.Focus();
                }
            }
        }

        private void btn_idProv_Click(object sender, EventArgs e)
        {
            frmcoproveedor_qry frmp = new frmcoproveedor_qry();
            frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
            frmp.ShowDialog();
            txtidprov.Focus();
        }
        public void ejecutarProv(EProveedor prov)
        {
            txtidprov.Text = prov.Id_clipro;
            lblprov.Text = prov.Ds_raznombre;
        }



        private void cblustre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtlustre.Text = Convert.ToString(cblustre.SelectedValue);
        }

        private void btnCancelar_pop_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public int EstadoDet = 0; // esto define si se añade un nuevo Item o solo va a ser modificado el item  // 1 --> para añadir un nuevo item , 2 --> para modificar un item

        public void LlenarGrillaLM2(ETejeduria_DetMall OBJTJLM, object form)
        {

            string str = Convert.ToString(dgDetalleMall.Rows.Count + 1);



            string[] row = { OBJTJLM.Nu_secuen,
                             OBJTJLM.Nu_item,
                             OBJTJLM.Nu_longmalla.ToString(),
                             OBJTJLM.St_anulado,
                           };

            dgDetalleMall.Rows.Add(row);


        }

 


        


        private void btnAceptar_pop_Click(object sender, EventArgs e)
        {
               
                ETejeduriaDet oTJD = new ETejeduriaDet();

                oTJD.Nu_secuen = txtAlimenta.Text;
                oTJD.Id_numalim = txtAlimenta.Text;
                oTJD.Ds_distrib = txtDistribucion.Text;
                oTJD.Ds_estruct = txtEstructura.Text;
                oTJD.Id_prodhilo = txtHilo.Text;
                oTJD.ds_prodhilo = lblds_producto.Text;
                oTJD.Ds_tipfibra = txttipfibra.Text;
                oTJD.Ds_carachilo = txtcaracHilo.Text;
                oTJD.Ds_titulo = txttitulo.Text;
                oTJD.Id_vlustre = txtlustre.Text;
                oTJD.ds_lustre = cblustre.Text;
                oTJD.Nu_torsion = txttorsion.Text;
                oTJD.Id_clipro = txtidprov.Text;
                oTJD.ds_razsoc = lblprov.Text;
                oTJD.Nu_lote = txtlote.Text;
                oTJD.Mt_preuni = Convert.ToDecimal(txtpreuni.Text);
                oTJD.Ds_etiqueta = txtetiqueta.Text;
                oTJD.Nu_porhilo = Convert.ToDecimal(txtporcHiloCrudo.Text);
                oTJD.Nu_porhiloaca = Convert.ToDecimal(txtporcHiloAcabado.Text);
                oTJD.Nu_tension = Convert.ToDecimal(txttension.Text);
                oTJD.Nu_bobinas = Convert.ToInt16(txtNumBobinas.Text);
                oTJD.Nu_alimenta = Convert.ToInt16(txtnumAliment.Text);
                oTJD.Mt_subtotcon = Convert.ToDecimal("0.0000");



                ETejeduria_DetMall _dato = new ETejeduria_DetMall();

     


                if (EstadoDet == 1)
                {
                    if (txtidprov.Text != "")
                    {
                        FrmTejeduria_mnt frmFormularioAnterior = (FrmTejeduria_mnt)FormParent;

                        if (oTJD.Nu_secuen.ToString() != "")
                        {
                            frmFormularioAnterior.LlenarGrilla(oTJD, this);
                        }
                        else
                        {
                            MessageBox.Show("El usuario debe de ingresar el # Alimenta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                        for (int i = 0; dgDetalleMall.Rows.Count > i; i++)
                        {

                            
                            var nu_item = dgDetalleMall.Rows[i].Cells["nu_item"].Value;
                            var nu_longmalla = dgDetalleMall.Rows[i].Cells["nu_longmalla"].Value;

                            if (_nu_secu != null)
                            {
                                _dato.Nu_secuen = _nu_secu;
                            }
                            else
                            {
                                _dato.Nu_secuen = txtAlimenta.Text;
                            }
                            
                            _dato.Nu_item = nu_item.ToString();

                            if (nu_longmalla.ToString() !="")
                            {
                                _dato.Nu_longmalla = Convert.ToDecimal(nu_longmalla);
                            }
                            else
                            {
                                _dato.Nu_longmalla = 0;
                                MessageBox.Show("El usuario debe de ingresar la longitud de la malla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            _dato.St_anulado = "0";



                             frmFormularioAnterior.LlenarGrillaLI(_dato, this);
                              this.Close();
                        }

                      
                    }
                    else
                    {
                        MessageBox.Show("Falta Ingresar el proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else if(EstadoDet ==2)
                {


                    FrmTejeduria_mnt frmFormularioAnterior = (FrmTejeduria_mnt)FormParent;
                    frmFormularioAnterior.ModGuilla(oTJD, this);

                    

                    for (int i = 0; dgDetalleMall.Rows.Count > i; i++)
                    {
                       
                        var nu_item = dgDetalleMall.Rows[i].Cells["nu_item"].Value;
                        var nu_longmalla = dgDetalleMall.Rows[i].Cells["nu_longmalla"].Value;
                  


                        _dato.Nu_secuen = _nu_secu;
                        _dato.Nu_item = nu_item.ToString();
                        _dato.Nu_longmalla = Convert.ToDecimal(nu_longmalla);
                        _dato.St_anulado = "0";
                        frmFormularioAnterior.LlenarGrillaLM(_dato, this);

                    }

                    this.Close();

                }
        }

        public object FormParent { get; set; }

        string _nu_secu;

        public void LLenarCampos(ETejeduriaDet oTD)
        {
            string idProducto = oTD.Id_producto.ToString();
            string nuFicha = oTD.Nu_correficha.ToString();

             _nu_secu = oTD.Nu_secuen;
            txtAlimenta.Text = oTD.Id_numalim;
            txtDistribucion.Text = oTD.Ds_distrib;

            txtEstructura.Text = oTD.Ds_estruct;
            txtHilo.Text = oTD.Id_prodhilo.ToString();

            lblds_producto.Text = oTD.ds_prodhilo.ToString();
            txttipfibra.Text = oTD.Ds_tipfibra.ToString();
            txtcaracHilo.Text = oTD.Ds_carachilo.ToString();
            txttitulo.Text = oTD.Ds_titulo.ToString();
            txtlustre.Text = oTD.Id_vlustre.ToString();
            cblustre.SelectedValue = txtlustre.Text;
            txttorsion.Text = oTD.Nu_torsion.ToString();
            txtidprov.Text = oTD.Id_clipro.ToString();
            lblprov.Text = oTD.ds_razsoc.ToString();
            txtlote.Text = oTD.Nu_lote.ToString();
            txtpreuni.Text = oTD.Mt_preuni.ToString();
            txtetiqueta.Text = oTD.Ds_etiqueta.ToString();
            txtporcHiloCrudo.Text = oTD.Nu_porhilo.ToString();
            txtporcHiloAcabado.Text = oTD.Nu_porhiloaca.ToString();
            txttension.Text = oTD.Nu_tension.ToString();
            txtNumBobinas.Text = oTD.Nu_bobinas.ToString();
            txtnumAliment.Text = oTD.Nu_alimenta.ToString();
     
        }

        private void txtpreuni_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtporcHiloCrudo_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtporcHiloAcabado_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txttersion_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0:##,##0.0000}", numero);
        }

        private void txtNumBobinas_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }

        private void txtnumAliment_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            tb.Tag = numero;
            tb.Text = string.Format("{0}", numero);
        }



        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            
            NuevoItem();



        }
        List<ETejeduria_DetMall> SalvarDatos = new List<ETejeduria_DetMall>();

        private void mSalvarDatosGrilla()
        {
            try
            {
                //recorre la cantidad de items, por cada item la entidad oAsigHorario va almacenando , 
                //esto para que data que se va ingresando en la grilla no se pierda

                List<ETejeduria_DetMall> lstSalvarDatos = new List<ETejeduria_DetMall>();

                for (int i = 0; dgDetalleMall.Rows.Count > i; i++)
                {
                    // la entidad almacena los items de la grilla 

                    ETejeduria_DetMall oTJ = new ETejeduria_DetMall();

                    // verificar si los valores ingresados en la grilla estan en label o texbox como tambien en un dropdowlinst

                    oTJ.Nu_secuen = dgDetalleMall.Rows[i].Cells["nu_secuen"].Value.ToString();
                    oTJ.Nu_item = dgDetalleMall.Rows[i].Cells["nu_item"].Value.ToString();
                    oTJ.Nu_longmalla = Convert.ToDecimal(dgDetalleMall.Rows[i].Cells["nu_longmalla"].Value.ToString());

                    //añade los valores de la entidad a la lista de la entidad

                    lstSalvarDatos.Add(oTJ);

                }
                // se crea una sesion para almacenar la lista que contiene los  datos.

                SalvarDatos = lstSalvarDatos;
            }

            catch (Exception ex)
            {

                ex.ToString();

            }

        }


        string valorCelda;

        private void NuevoItem()
        {
            int countRows = dgDetalleMall.Rows.Count - 1;
            if (countRows >=0)
            {
              valorCelda  = dgDetalleMall.Rows[countRows].Cells["nu_item"].Value.ToString();
            }
            else
            {
                valorCelda = "0";
 
            }
                

                string item = (Convert.ToInt16(valorCelda) + 1).ToString();

                dgDetalleMall.Rows.Add("", item.PadLeft(2, '0').ToString(), "");

                dgDetalleMall.CurrentCell = dgDetalleMall.Rows[dgDetalleMall.Rows.Count - 1].Cells["nu_longmalla"];
                dgDetalleMall.Focus();
          
           
        }

        private void txtnumAliment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

                btnAceptar_pop.Focus();
            }
        }

        private void txtHilo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmTejido_qry frmp = new FrmTejido_qry();
                frmp.pasard += new FrmTejido_qry.pasar(ejecutarProd);
                frmp.ShowDialog();
                txtHilo.Focus();
                
            }
        }

        private void txtidprov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmcoproveedor_qry frmp = new frmcoproveedor_qry();
                frmp.pasard += new frmcoproveedor_qry.pasar(ejecutarProv);
                frmp.ShowDialog();
                txtidprov.Focus();

            }
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEliminarRow_Click(object sender, EventArgs e)
        {
            if (dgDetalleMall.RowCount > 0)
            {
                ETejeduria_DetMall oTJDM = new ETejeduria_DetMall();
                oTJDM.Nu_secuen = dgDetalleMall.CurrentRow.Cells["nu_secuen"].Value.ToString();
                oTJDM.Nu_item = dgDetalleMall.CurrentRow.Cells["nu_item"].Value.ToString();
                var nuLongMalla = dgDetalleMall.CurrentRow.Cells["nu_longmalla"].Value;

                if (nuLongMalla.ToString() != "")
                {
                    oTJDM.Nu_longmalla = Convert.ToDecimal(nuLongMalla);
                }
                else
                {
                    oTJDM.Nu_longmalla = 0;
                }
                oTJDM.St_anulado = "1";

                FrmTejeduria_mnt frmFormularioAnterior = (FrmTejeduria_mnt)FormParent;
                frmFormularioAnterior.ElimiItemMall(oTJDM, this);
                try
                {
                    dgDetalleMall.Rows.Remove(dgDetalleMall.CurrentRow);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }

            }
            else
            { 

            }
        }

        //private void btnAddRow_Click(object sender, EventArgs e)
        //{
        //    ETejeduria_DetMall oTJDM = new ETejeduria_DetMall();
        //    if (EstadoDet.ToString()== "1")
        //    {
        //        oTJDM.Nu_secuen = txtAlimenta.Text;
        //    }
        //    else
        //    {
        //        oTJDM.Nu_secuen = _nu_secu.ToString();
        //    }            
        //    oTJDM.Nu_item = dgDetalleMall.CurrentRow.Cells["nu_item"].Value.ToString();
        //    oTJDM.Nu_longmalla = Convert.ToDecimal(dgDetalleMall.CurrentRow.Cells["nu_longmalla"].Value);
        //    oTJDM.St_anulado = "0";
        //    FrmTejeduria_mnt frmFormularioAnterior = (FrmTejeduria_mnt)FormParent;
        //    frmFormularioAnterior.AddMall(oTJDM, this);           
        //}
    }
}
