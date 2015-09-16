using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BUndNegocio
    {
        public static IDataReader MG_UNegocio_qry04(EUnidadNegocio EUndNego)
        {
            return DUndNegocio.UndNegocio_qry01(EUndNego);
        }


        public static IDataReader MG_UNegocio_qry03(EUnidadNegocio EUndNego)
        {
            return DUndNegocio.UndNegocio_qry02(EUndNego);
        }

        //cargar la unidad de negocio
        public static List<Dato> ObtenerDatoUN(EUnidadNegocio idtabla)
        {
            return DUndNegocio.ObtenerDatoUN("MG_UNegocio_qry05", "idUNegocio", "dsUNegocio", idtabla);
        }

        //CENTRO DE COSTOS
        public static List<Dato> ObtenerDatoCC(EUnidadNegocio idtabla)
        {
            return DUndNegocio.ObtenerDatoCC("MG_UNegocio_qry12", "idCCosto", "dsCCosto", idtabla);
        }

        public static IDataReader MG_UNegocio_qry(EUnidadNegocio EUndNego)
        {
            return DUndNegocio.MG_UNegocio_qry10(EUndNego);
        }

        public static List<EUnidadNegocio> MG_Unegocio_qry06(EUnidadNegocio Un)
        {
            return DUndNegocio.MG_Unegocio_qry06(Un);
        }

    }
}
