using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BExportacion
    {
        public static DataSet GetListFill(Eexportacion imp)
        {
            return DExportacion.GetList(imp);
        }


        public static List<Dato> ObtenerDatoExport(Eexportacion ex)
        {
            return DExportacion.ObtenerDatoExport(ex);

        }

        public static IDataReader GetListFill02(Eexportacion imp)
        {
            return DExportacion.GetList02(imp);
        }

        public static void Exportacion_mnt01(Eexportacion prod)
        {
            DExportacion.Exportacion_mnt01(prod);

        }


        //codigo web
        public static IDataReader Exportacion_qry01(string idPeriodo, string idEmpresa)
        {
            return DExportacion.Exportacion_qry01(idPeriodo, idEmpresa);
        }
        //codigo desktop

        public static List<Dato> Exportacion_qry01_(string idperiodo, string idEmpresa)
        {

            return DExportacion.Exportacion_qry01_(idperiodo, idEmpresa);
        }


        public static void ExportacionEliminar_mnt01(Eexportacion imp)
        {
            DExportacion.ExportacionEliminar_mnt01(imp);
        }

       
    }
}
