using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Ve;
using Texfina.DOQry.Ve;
namespace Texfina.BOQry.Ve
{
    public class BAnticipos
    {
        //Llenar la grilla
        public static DataSet FillDatoAnticipos(EAnticipos Anticipos)
        {
            return DAnticipos.GetList(Anticipos);
        }


        public static List<Dato> GetDatoAnticipos(EAnticipos Anticipos)
        {
            return DAnticipos.GetDatoAnticipos("VE_Anticipos_qry01", "IdAnticipo", "mtDeposito", Anticipos);
        }

    }
}
