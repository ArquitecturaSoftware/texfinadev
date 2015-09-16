using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
   public class DGrupo
    {
       /// <summary>
       /// codigo para web
       /// </summary>
       /// <returns></returns>
       public static IDataReader MG_TablaGrupo_qry01()
       {
           DBAccess db = new DBAccess();

           return db.ExecuteReader("MG_grupo_qry01");
       }
       /// <summary>
       /// codigo para desktop
       /// </summary>
       /// <param name="Codigo"></param>
       /// <returns></returns>
       public static List<Dato> MG_TablaGrupo_qry01_()
       {
           List<Dato> _lista = new List<Dato>();

           DBAccess db = new DBAccess();
           IDataReader reader = db.ExecuteReader("MG_grupo_qry01");

           while (reader.Read())
           {
               Dato _dato = new Dato();

               _dato.id = reader["id_grupo"].ToString();
               _dato.desc = reader["ds_grupo"].ToString();
               _lista.Add(_dato);
           }
           return _lista;
       }
    }
}
