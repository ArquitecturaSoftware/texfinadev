using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOMnt.Ve;
using Texfina.Entity.Ve;


namespace Texfina.BOMnt.Ve
{
    public class BAnticipos
    {

        public static List<Dato> GenCodeAnticiposMnt(String codigo)
        {
            
            return DAnticipos.GenCodeAnticipoMnt(codigo);
        }


    }
}
