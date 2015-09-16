using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
   public class BUbigeo
    {

       /// <summary>
        /// codigo para web Pais_qry01
       /// </summary>
       /// <returns></returns>
       public static IDataReader Pais_qry01()
       {
           return DUbigeo.MG_Pais_qry01();
       }


       /// <summary>
       /// codigo para desktop del procedimiento Pais_qry01
       /// </summary>
   
       /// <returns></returns>
       /// 

       public static List<Dato> Pais_qry01_()
       {
           return DUbigeo.MG_Pais_qry01_();
       }

       public static IDataReader Departamento_qry01(String pais)
       {
           return DUbigeo.MG_Departamento_qry01(pais);
       }
       /// <summary>
       /// codigo para desktop del procedimiento Departamento_qry01
       /// procedimiento  Departamento_qry01_
       /// </summary>

       /// <returns></returns>
       public static List<Dato> Departamento_qry01_(String pais)
       {
           return DUbigeo.MG_Departamento_qry01_(pais);
       }


       public static IDataReader Provincia_qry01(String pais, String depa)
       {
           return DUbigeo.MG_Provincia_qry01(pais, depa);
       }
       /// <summary>
       /// codigo para desktop 
       /// </summary>
       /// <returns></returns>

       public static List<Dato> Provincia_qry01_(String pais, String depa)
       {
           return DUbigeo.MG_Provincia_qry01_(pais,depa);
       }


       public static IDataReader Distrito_qry01(String pais, String depa, String prov)
       {
           return DUbigeo.MG_Distrito_qry01(pais,depa,prov);

       }
       /// <summary>
       /// codigo para desktop Distrito_qry01_
       /// </summary>
       /// <param name="codigo"></param>
       /// <returns></returns>

       public static List<Dato> Distrito_qry01_(String pais, String depa, String prov)
       {
           return DUbigeo.MG_Distrito_qry01_(pais, depa, prov);
       }

      
    }
}
