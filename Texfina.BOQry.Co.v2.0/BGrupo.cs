using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;
using Texfina.Entity.Co;

namespace Texfina.BOQry.Co
{
    public class BGrupo
    {
        public static IDataReader TablaGrupo_qry02()
        {
            return DGrupo.MG_TablaGrupo_qry01();
                
        }

        public static List<Dato> TablaGrupo_qry02_()
        {
            return DGrupo.MG_TablaGrupo_qry01_();
        }
    }
}
