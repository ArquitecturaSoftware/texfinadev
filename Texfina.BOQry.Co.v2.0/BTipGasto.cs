using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BTipGasto
    {
        public static DataSet TipoGasto_qry01(ETipGasto etg)
        {

            return DTipGasto.TipoGasto_Qry1(etg);
        }


        ///// <summary>
        ///// codigo para desktop TipoGasto_qry01_
        ///// 
        ///// </summary>

        ///// <returns></returns>
        ///// 

        //public static List<ETipGasto> TipoGasto_qry01_(ETipGasto etg)
        //{
        //    return DTipGasto.TipoGasto_Qry1_(etg);
        //}


        public static IDataReader clase_qry01(String idEmpresa, String idUnegocio, String idCCostos ) // clase 91,94,95
        {
            return DTipGasto.MG_Clase_qry01(idEmpresa,idUnegocio,idCCostos);
        }



        public static List<Dato> ObtenerDatotg(ETipGasto idtabla)
        {
            return DTipGasto.ObtenerDatoTg("MG_CLASE_Qry01_prueba", "idtipGasto", "dsDescrip", idtabla);
        }


        public static ETipGasto TipoGasto_qry02(ETipGasto etg)
        {
            return DTipGasto.mListarTipoGasto(etg);
        }

    }
}
