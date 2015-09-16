using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BImportacion
    {
        public static DataSet GetListFill(EImportacion imp)
        {
            return DImportacion.GetList(imp);
        }

        public static List<Dato> ObtenerDatoImportacion(EImportacion imp)
        {
            return DImportacion.ObtenerDatoImport(imp);
        }

        public static IDataReader GetListFill02(EImportacion imp)
        {
            return DImportacion.GetList02(imp);
        }

        public static void Importacion_mnt01(EImportacion prod)
        {
            DImportacion.Importacion_mnt01(prod);

        }

        public static void ImportacionEliminar_mnt01(EImportacion imp)
        {
            DImportacion.ImportacionEliminar_mnt01(imp);

        }
        /// <summary>
        /// web  Importacion_qry01
        /// </summary>
        /// <param name="idPeriodo"></param>
        /// <param name="idEmpresa"></param>
        /// <returns></returns>
        public static IDataReader Importacion_qry01(string idPeriodo, string idEmpresa)
        {
            return DImportacion.Importacion_qry01(idPeriodo,idEmpresa);
        }

        /// desktop Importacion_qry01_ para generar codigo de importacion 

        public static List<Dato> Importacion_qry01_(string idperiodo, string idEmpresa)
        {

            return DImportacion.Importacion_qry01_(idperiodo, idEmpresa);
        }


    }
}
