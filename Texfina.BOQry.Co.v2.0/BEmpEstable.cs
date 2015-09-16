using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
namespace Texfina.BOQry.Co
{
    public class BEmpEstable
    {
        public static IDataReader EmpEstableFill(EEmpEstable Est)
        {
            return DEmpEstable.EmpEstableFill(Est);
        }
    }
}
