using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BGeneral
    {

        public static List<Dato> ObtenerDatoLocal()
        {
            return DGeneral.ObtenerDato("MG_Local_query", "id_local", "ds_local");
        }


        public static List<Dato> ObtenerDatoidTabla(string idtabla)
        {
            return DGeneral.ObtenerDatoParameter("MG_TablaGeneral_qry01", "id_item", "ds_item",idtabla);
        }

        public static List<Dato> ObtenerDatoEmpresa(string idtabla)
        {
            return DGeneral.ObtenerDatEmpresa("SY_Empresa_qry04", "idEmpresa", "dsEmpresa", idtabla);
        }

        public static List<Dato> ObtenerDatoEmpresaPeriodo(Dato d)
        {
            return DGeneral.ObtenerDatEmpresaPeriodo(d);
        }

        public static List<Dato> ObtenerDatoMenu(Dato d)
        {
            return DGeneral.ObtenerDatoMenu(d);
        }

        public static List<Dato> ObtenerDatoMenuPrincipal()
        {
            return DGeneral.ObtenerDatoMenuPrincipal();
        }



        public static List<Dato> ObtenerModulo(Dato d)
        {
            return DGeneral.ObtenerModulo(d);
        }
    }
}
