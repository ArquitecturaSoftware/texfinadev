using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Texfina.Core.Data;
using Texfina.Entity.Sy;

namespace Texfina.DOQry.Sy
{
    public class _Usuario
    {
        private static EUsuario LeerReader(IDataReader reader)
        {
            EUsuario usu = new EUsuario();

            usu.IdUser = reader["idUser"].ToString();
            usu.IdLogon = reader["idLogon"].ToString();
            usu.DsNombres = reader["dsNombres"].ToString();
            usu.StAnulado = reader["stAnulado"].ToString();
            return usu;
        }

        public static EUsuario UsuarioFill(EUsuario u)
        {
            DBAccess db = new DBAccess();
            //lee los parametros del login

            db.AddParameter("@vc_usuario", u.IdLogon);

            db.AddParameter("@vc_clave", u.ds_password);

            EUsuario usu = new EUsuario();

            //valida y ejecuta el procedimiento almacenado

            using (IDataReader reader = db.ExecuteReader("SY_Usuario_qry07"))
            {
                while (reader.Read())
                {
                    return LeerReader(reader);

                }

            }
            return u;

        }


        public static DataSet GetListUsuario(EUsuario u)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@dsNombre", u.DsNombres);


            return db.ExecuteDataSet("SY_Usuario_qry08");
        }


        public static DataSet SY_UsuarioControl_qry01(EUsuario u)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@dsNombres", u.DsNombres);

            return db.ExecuteDataSet("SY_UsuarioControl_qry01");
        }


    }
}
