using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Texfina.DOQry.Sy;
using Texfina.Entity.Sy;

namespace Texfina.BOQry.Sy
{
    public class Usuarioco
    {
        public static EUsuario UsuarioFill(EUsuario u)
        {
            
            return _Usuario.UsuarioFill(u);
        }

        public static DataSet GetListUsuario(EUsuario u)
        {
            return _Usuario.GetListUsuario(u);
        }

        public static DataSet SY_UsuarioControl_qry01(EUsuario u)
        {
            return _Usuario.SY_UsuarioControl_qry01(u);
        }

    }
}
