using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BFamilia
    {
        public static IDataReader GetListFill_Qry01(int psintypesel, string idEmpresa)
            
        {
            return DFamilia.Familia_qry01(psintypesel,idEmpresa);
        }

        /// <summary>
        /// codigo para desktop GetListFill_Qry01_
        /// </summary>

        /// <returns></returns>
        public static List<Dato> GetListFill_Qry01_(int codigo, string idEmpresa)
        {
            return DFamilia.Familia_qry01_(codigo, idEmpresa);
        }


        public static IDataReader GetListFill_Qry02(int psintypesel, string pchr_idgrupo, string idEmpresa)
        {
            return DFamilia.Familia_qry02(psintypesel,pchr_idgrupo,idEmpresa);
        }


        /// <summary>
        /// codigo desktop GetListFill_Qry02_
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="idEmpresa"></param>
        /// <returns></returns>
        public static List<Dato> GetListFill_Qry02_(int psintypesel, string pchr_idgrupo, string idEmpresa)
        {
            return DFamilia.Familia_qry02_(psintypesel, pchr_idgrupo, idEmpresa);
        }

        public static IDataReader GetListFill_Qry03(int psintypesel, string pchr_idgrupo, string pchr_idfamilia,string idEmpresa)
        {
            return DFamilia.Familia_qry03(psintypesel, pchr_idgrupo, pchr_idfamilia,idEmpresa);
        }

        /// <summary>
        /// codigo desktop GetListFill_Qry03_
        /// </summary>
    
        /// <returns></returns>
        public static List<Dato> GetListFill_Qry03_(int psintypesel, string pchr_idgrupo, string pchr_idfamilia, string idEmpresa)
        {
            return DFamilia.Familia_qry03_(psintypesel, pchr_idgrupo, pchr_idfamilia, idEmpresa);
        }

        public static DataSet GetFamilia(EFamilia fm)
        {
            return DFamilia.GetFamilia(fm);
        }



        public static void Familia_mnt01(EFamilia fm)
        {
            DFamilia.Familia_mnt01(fm);

        }

    }
}
