using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.DOQry.Co;

namespace Texfina.BOQry.Co
{
    public class BLocal
    {
        public static IDataReader Local_qry01()
        {
            return DLocal.Local_qry01();
        }
    }
}
