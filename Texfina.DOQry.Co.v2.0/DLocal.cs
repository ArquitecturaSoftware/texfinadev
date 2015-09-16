using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
    public class DLocal
    {
        public static IDataReader Local_qry01()
        {
            DBAccess db = new DBAccess();
            return db.ExecuteReader("MG_Local_query");
        }
    }
}
