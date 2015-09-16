using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Al;
using Texfina.Entity.Al;

namespace Texfina.BOMnt.Al
{
    public class BIngreso
    {
        public static void Ingreso_mnt01(EIngreso obj)
        {
            DIngreso.Ingreso_mnt01(obj);
        }

        public static List<Texfina.Entity.Co.Dato> IngresoGenCod(string idperiodo, string idEmpresa)
        {
            return DIngreso.IngresoGenCod_qry01_(idperiodo, idEmpresa);
            
        }


        public static EIngreso AL_Ingreso_qry02(EIngreso oTJ)
        {

            return DIngreso.AL_Ingreso_qry02(oTJ);
        }



    

        public static List<EIngreso> AL_Ingreso_qry05(EIngreso oTJ)
        {
            return DIngreso.AL_Ingreso_qry05(oTJ);
        }



        //------- Reporte de etiqueta

        public DataTable AL_Ingreso_etiqueta_rpt(EIngreso obj)
        {

            //return DOrdenCompra.OrdenCompra_rpt01(oc);
            DIngreso objTJ = new DIngreso();

            DataTable dt = objTJ.AL_Ingreso_etiqueta_rpt(obj);
            return dt;
        }


    }
}
