using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Texfina.BOQry.Sy;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;

namespace TX_Sistema
{
    public partial class frmPermiso : Form
    {


        public frmPermiso()
        {
            InitializeComponent();


           
            //cbModulo.DataSource = BControlUsuario.ObtenerModulo();
            //cbModulo.DisplayMember = "desc";
            //cbModulo.ValueMember = "id";


            List<Dato> lstIG = new List<Dato>();
            lstIG = BControlUsuario.ObtenerModulo();

            foreach (Dato _objID in lstIG)
            {
                string[] row =
                        
                                {   
                                _objID.chkActivo.ToString(),
                                    _objID.id,
                                    _objID.desc,
                                                                             
                                };
                dgvModulo.Rows.Add(row);
            }


            //dgvModulo.DataSource = BControlUsuario.ObtenerModulo();
          
          
        }

        private void btnBuscarUusuario_Click(object sender, EventArgs e)
        {
            FrmUsuario_qry frm = new FrmUsuario_qry();
            frm.pasard += new FrmUsuario_qry.pasar(_ejecutarUsuario);
            frm.ShowDialog();
        }


        public void ejecutarUsuario(EUsuario u)
        {
            txtIdUsuario.Text = u.IdUser;
            txtBuscar.Text = u.IdUser;
            lbldsUusuario.Text = u.DsNombres;
            mCargarDatos();
        }


        public void _ejecutarUsuario(EUsuario u)
        {
            txtIdUsuario.Text = u.IdUser;
            txtBuscar.Text = u.IdUser;
            lbldsUusuario.Text = u.DsNombres;
        }

        private void frmPermiso_Load(object sender, EventArgs e)
        {

        }

        private void mSalvarDatosGrilla()
        {
            try
            {
                //recorre la cantidad de items, por cada item la entidad oAsigHorario va almacenando , 
                //esto para que data que se va ingresando en la grilla no se pierda

                List<EControlUsuario> lstSalvarDatos = new List<EControlUsuario>();

                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {
                    // la entidad almacena los items de la grilla 

                    EControlUsuario ctrl = new EControlUsuario();

                    // verificar si los valores ingresados en la grilla estan en label o texbox como tambien en un dropdowlinst
                    ctrl.IdUser = dgvDetalle.Rows[i].Cells["idUser"].Value.ToString();
                    ctrl.IdModulo = dgvDetalle.Rows[i].Cells["idModulo"].Value.ToString();
                    ctrl.dsModulo = dgvDetalle.Rows[i].Cells["dsModulo"].Value.ToString();
                    ctrl.Id_formulario = dgvDetalle.Rows[i].Cells["id_formulario"].Value.ToString();
                    ctrl.ds_formulario = dgvDetalle.Rows[i].Cells["ds_formulario"].Value.ToString();
                    ctrl.BtnNuevo = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["BtnNuevo"].Value);
                    ctrl.BtnCopiar = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnCopiar"].Value);
                    ctrl.BtnEditar = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnEditar"].Value);
                    ctrl.BtnGrabar = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnGrabar"].Value);
                    ctrl.BtnImprimir = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnImprimir"].Value);
                    ctrl.BtnBuscar = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnBuscar"].Value);
                    ctrl.BtnVistaPrevia = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["btnVistaPrevia"].Value);
                    ctrl.BtnForm = Convert.ToBoolean(dgvDetalle.Rows[i].Cells["Form"].Value);
                    //añade los valores de la entidad a la lista de la entidad

                    lstSalvarDatos.Add(ctrl);

                }
                // se crea una sesion para almacenar la lista que contiene los  datos.

                SalvarDatos = lstSalvarDatos;
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
          
        private void btnNuevoRow_Click(object sender, EventArgs e)
        {
            //Nuevo();
        }

        List<EControlUsuario> SalvarDatos = new List<EControlUsuario>();
        //private void Nuevo()
        //{
        //    if (cbFormulario.Text != "")
        //    {
        //        List<EControlUsuario> lstcrt = new List<EControlUsuario>();

        //        EControlUsuario crt = new EControlUsuario();

        //        //llega a ingresar siempre en cuando ya se tenga un registro en la grilla
        //        string str = Convert.ToString(dgvDetalle.Rows.Count + 1);
        //        if (dgvDetalle.Rows.Count > 0)
        //        {
        //            //almacena en la entidad la informacion ingresada en la grilla
        //            //salva los datos, hace que cuando se de agregar no se pierda la informacion ya ingresada

        //            mSalvarDatosGrilla();
        //            lstcrt = (List<EControlUsuario>)SalvarDatos;

        //            //lstAsigHorario = (List<AsignacionHorarioEnt>)(Session["SeslstSalvaDatos"]);
        //            //añade un registro mas en blaco

        //            crt.IdUser = "";
        //            //crt.IdModulo = cbModulo.SelectedValue.ToString();
        //            //crt.dsModulo = cbModulo.Text;
        //            //crt.Id_formulario = cbFormulario.SelectedValue.ToString();
        //            //crt.ds_formulario = cbFormulario.Text;
        //            crt.BtnNuevo = true;
        //            crt.BtnCopiar = true;
        //            crt.BtnEditar = true;
        //            crt.BtnGrabar = true;
        //            crt.BtnImprimir = true;
        //            crt.BtnBuscar = true;
        //            crt.BtnVistaPrevia = true;
        //            crt.BtnForm = true;

        //            // muestra el item en blanco

        //            lstcrt.Add(crt);

        //            dgvDetalle.DataSource = lstcrt;

        //        }
        //        else
        //        {
        //            // Añande el primer item en blando de la grilla
        //            crt.IdUser = "";
        //            //crt.IdModulo = cbModulo.SelectedValue.ToString();
        //            //crt.dsModulo = cbModulo.Text;
        //            //crt.Id_formulario = cbFormulario.SelectedValue.ToString();
        //            //crt.ds_formulario = cbFormulario.Text;
        //            crt.BtnNuevo = true;
        //            crt.BtnCopiar = true;
        //            crt.BtnEditar = true;
        //            crt.BtnGrabar = true;
        //            crt.BtnImprimir = true;
        //            crt.BtnBuscar = true;
        //            crt.BtnVistaPrevia = true;
        //            crt.BtnForm = true;
        //            lstcrt.Add(crt);

        //            //Muestra la grilla con un fila en blanco 

        //            dgvDetalle.DataSource = lstcrt;

        //            //dgProducto.DataBind();


        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Seleccione el formulario", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
        //    }

        //}



        private void dgvDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.Context == DataGridViewDataErrorContexts.Commit)
        
            {
                MessageBox.Show("CustomerID value must be unique.");
            }
        }

        private void btnEliminarRow_Click(object sender, EventArgs e)
        {
            //mSalvarDatosGrilla(); 

            //int u = dgvDetalle.CurrentCell.RowIndex;
            //List<EControlUsuario> lsListadoActual = (List<EControlUsuario>)SalvarDatos;

            //lsListadoActual.RemoveAt(u);
            //SalvarDatos = lsListadoActual;
           
            //dgvDetalle.DataSource = lsListadoActual;

            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
        }



        private void dgvDetalle_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDetalle.IsCurrentRowDirty)
            {
                dgvDetalle.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

   

        private void cbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbFormulario.DataSource = BControlUsuario.ObtenerFormulario(cbModulo.SelectedValue.ToString());
            //cbFormulario.DisplayMember = "desc";
            //cbFormulario.ValueMember = "id";
        }

        private void _btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                EControlUsuario u = new EControlUsuario();

                //------------------------Detalle de compra Factura----------------------------------------------------    

                string btnNuevo_, btnCopiar_, btnEditar_, btnGrabar_, btnImprimir_, btnBuscar_, btnVistaPrevia_, btnForm_;

                for (int i = 0; dgvDetalle.Rows.Count > i; i++)
                {

                    var btnNuevo = dgvDetalle.Rows[i].Cells["BtnNuevo"].Value;
                    var btnCopiar = dgvDetalle.Rows[i].Cells["btnCopiar"].Value;
                    var btnEditar = dgvDetalle.Rows[i].Cells["btnEditar"].Value;
                    var btnGrabar = dgvDetalle.Rows[i].Cells["btnGrabar"].Value;
                    var btnImprimir = dgvDetalle.Rows[i].Cells["btnImprimir"].Value;
                    var btnBuscar = dgvDetalle.Rows[i].Cells["btnBuscar"].Value;
                    var btnVistaPrevia = dgvDetalle.Rows[i].Cells["btnVistaPrevia"].Value;
                    var btnForm = dgvDetalle.Rows[i].Cells["Form"].Value;
                    var id_formulario = dgvDetalle.Rows[i].Cells["id_formulario"].Value;
                    var idModulo = dgvDetalle.Rows[i].Cells["idModulo"].Value;

                    //MessageBox.Show(btnNuevo.ToString());

                    if (btnNuevo.ToString() == "True") { btnNuevo_ = "1"; } else { btnNuevo_ = "0"; }
                    if (btnCopiar.ToString() == "True") { btnCopiar_ = "1"; } else { btnCopiar_ = "0"; }
                    if (btnEditar.ToString() == "True") { btnEditar_ = "1"; } else { btnEditar_ = "0"; }
                    if (btnGrabar.ToString() == "True") { btnGrabar_ = "1"; } else { btnGrabar_ = "0"; }
                    if (btnImprimir.ToString() == "True") { btnImprimir_ = "1"; } else { btnImprimir_ = "0"; }
                    if (btnBuscar.ToString() == "True") { btnBuscar_ = "1"; } else { btnBuscar_ = "0"; }
                    if (btnVistaPrevia.ToString() == "True") { btnVistaPrevia_ = "1"; } else { btnVistaPrevia_ = "0"; }
                    if (btnForm.ToString() == "True") { btnForm_ = "1"; } else { btnForm_ = "0"; }


                    u.IdUser = txtIdUsuario.Text;
                    u._btnNuevo = (btnNuevo_ .ToString());
                    u._btnCopiar = (btnCopiar_.ToString());
                    u._btnEditar = (btnEditar_.ToString());
                    u._btnGrabar = (btnGrabar_.ToString());
                    u._btnImprimir = (btnImprimir_.ToString());
                    u._btnBuscar = (btnBuscar_.ToString());
                    u._btnVistaPrevia = (btnVistaPrevia_.ToString());
                    u._btnForm = (btnForm_.ToString());
                    u.Id_formulario = id_formulario.ToString();
                    u.IdModulo = idModulo.ToString();

                    BControlUsuario.SY_ControlUsuario_mnt01(u);
                    
               }
                MessageBox.Show("Datos grabados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //getCalculo();
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Error de ingreso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void mCargarDatos()
        {

            dgvDetalle.Rows.Clear();
            //try
            //{

                //if (!string.IsNullOrEmpty(txtBuscar.Text))
                //{
                //    EControlUsuario u = new EControlUsuario();

                //    u.IdUser = txtBuscar.Text; //llenar con sesion


                //    List<EControlUsuario> oListDato = BControlUsuario.mListarControlUsuario(u);



                //        List<EControlUsuario> lstoc = new List<EControlUsuario>();

                //        //lstoc = BOrdenCompraFactura.mListarOcompraFactura2(oCompraF);

                //        dgvDetalle.DataSource = BControlUsuario.mListarControlUsuario(u);




                //}


            //-------------------------------------------------------------
                if (!string.IsNullOrEmpty(txtBuscar.Text))
                {

                    EControlUsuario obj = new EControlUsuario();

                    obj.IdUser = txtBuscar.Text; //llenar con sesion




                    List<EControlUsuario> lstOP = new List<EControlUsuario>();
                    lstOP = BControlUsuario.mListarControlUsuario(obj);

                    foreach (EControlUsuario _objOP in lstOP)
                    {
                        string[] row =
                        
                                {    _objOP.IdModulo,
                                     _objOP.dsModulo,
                                     _objOP.Id_formulario,
                                     _objOP.ds_formulario,
                                     _objOP.btnNuevo_.ToString(),
                                     _objOP.btnCopiar_.ToString(),
                                     _objOP.btnEditar_.ToString(),
                                     _objOP.btnGrabar_.ToString(),
                                     _objOP.btnImprimir_.ToString(),
                                     _objOP.btnBuscar_.ToString(),
                                     _objOP.btnVistaPrevia_.ToString(),
                                     _objOP.btnForm_.ToString(),                
                                };
                        dgvDetalle.Rows.Add(row);
                    }
                }


    
        }


        private void _btnBuscar_Click(object sender, EventArgs e)
        {

            FrmUsuarioControl_qry01 frm = new FrmUsuarioControl_qry01();
            frm.pasard += new FrmUsuarioControl_qry01.pasar(ejecutarUsuario);
            frm.ShowDialog();

            //mCargarDatos();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            dgvDetalle.Rows.Clear();


            String Cadena = "";
            String cadenaModulo;
            for (int i = 0; dgvModulo.Rows.Count > i; i++)
            {
                string chkactivo = dgvModulo.Rows[i].Cells["chkestado"].Value.ToString();

                //MessageBox.Show(chkactivo);
                if (chkactivo == "True")
                {
                    cadenaModulo = dgvModulo.Rows[i].Cells["_idModulo"].Value + ",";

                    Cadena = Cadena + "" + cadenaModulo;

                }
                else
                { 

                }

            }

            String _cadena = Cadena.Substring(0, Cadena.Length - 1);


            EControlUsuario obj = new EControlUsuario();

            obj.IdModulo = _cadena;
        

        

            List<EControlUsuario> lstOP = new List<EControlUsuario>();
            lstOP = BControlUsuario.SY_ControlFormulario_qry01(obj);

            foreach (EControlUsuario _objOP in lstOP)
            {
                string[] row =
                        
                                {    _objOP.IdModulo,
                                     _objOP.dsModulo,
                                     _objOP.Id_formulario,
                                     _objOP.ds_formulario,
                                     _objOP.btnNuevo_.ToString(),
                                     _objOP.btnCopiar_.ToString(),
                                     _objOP.btnEditar_.ToString(),
                                     _objOP.btnGrabar_.ToString(),
                                     _objOP.btnImprimir_.ToString(),
                                     _objOP.btnBuscar_.ToString(),
                                     _objOP.btnVistaPrevia_.ToString(),
                                     _objOP.btnForm_.ToString(),                
                                };
                dgvDetalle.Rows.Add(row);
            }


            

        }

        private void btnNuevo__Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtIdUsuario.Clear();
            dgvDetalle.Rows.Clear();

        }




    }
}
