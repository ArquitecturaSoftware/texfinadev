using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Texfina.BOQry.Co;
using Texfina.Entity.Co;

namespace Sist_Compras
{
    public partial class FrmInconsistencia : Form
    {
        public FrmInconsistencia()
        {
            InitializeComponent();
        }

        public string idmesini, idmesfin, st_aprueba;

        private void FrmInconsistencia_Load(object sender, EventArgs e)
        {

            if (st_aprueba == "P")
            {
                EParOCFillrpt objE = new EParOCFillrpt();

                objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;// llenar con sesion
                objE.IdAnio = wfChgEmpPer.datos.idperiodo;
                objE.IdMesIni = idmesini;
                objE.IdMesfin = idmesfin;
                objE.st_aprueba = st_aprueba;

                BOrdenCompra objOC = new BOrdenCompra();

                BOrdenCompra.CO_OrdenCompra_qry07_rpt(objE);

                dgOrdenCompra.DataSource = objOC.CO_OrdenCompra_qry06_rpt(objE);
            }
            else
            {
                EParOCFillrpt objE = new EParOCFillrpt();

                objE.IdEmpresa = wfChgEmpPer.datos.idEmpresa;
                objE.IdAnio = wfChgEmpPer.datos.idperiodo;
                objE.IdMesIni = idmesini;
                objE.IdMesfin = idmesfin;
                objE.st_aprueba = st_aprueba;

                BOrdenCompra objOC = new BOrdenCompra();
                dgOrdenCompra.DataSource = objOC.CO_OrdenCompra_qry08_rpt(objE);
            }
        

        }

      



    }
}
