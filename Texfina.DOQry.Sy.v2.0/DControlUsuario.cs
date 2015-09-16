using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using Texfina.Entity.Sy;

namespace Texfina.DOQry.Sy
{
    public class DControlUsuario
    {
        public static List<Dato> ObteneModulo()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("SY_Modulo_qry");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idModulo"].ToString();
                _dato.desc = reader["ds_modulo"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static List<Dato> ObtenerFormulario( string modulo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idModulo", modulo);
            
            IDataReader reader = db.ExecuteReader("SY_Formulario_qry");
            _lista.Clear();
            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_formulario"].ToString();
                _dato.desc = reader["ds_formulario"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static void SY_ControlUsuario_mnt01(EControlUsuario u)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pidUser", u.IdUser);
            db.AddParameter("@pbtnNuevo", u._btnNuevo);
            db.AddParameter("@pbtnCopiar", u._btnCopiar);
            db.AddParameter("@pbtnEditar", u._btnEditar);
            db.AddParameter("@pbtnGrabar", u._btnGrabar);
            db.AddParameter("@pbtnImprimir", u._btnImprimir);
            db.AddParameter("@pbtnBuscar", u._btnBuscar);
            db.AddParameter("@pbtnVistaPrevia", u._btnVistaPrevia);
            db.AddParameter("@pbtnForm", u._btnForm);
            db.AddParameter("@pid_formulario", u.Id_formulario);
            db.AddParameter("@pidModulo", u.IdModulo);


            db.ExecuteNonQuery("SY_ControlUsuario_mnt01");
        }





        private static EControlUsuario mCargarControlUsuario(IDataReader rdr)
        {
            EControlUsuario o = new EControlUsuario();

            o.IdUser = rdr.IsDBNull(rdr.GetOrdinal("idUser")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idUser"));
            o.IdModulo = rdr.IsDBNull(rdr.GetOrdinal("idModulo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idModulo"));
            o.Id_formulario = rdr.IsDBNull(rdr.GetOrdinal("id_formulario")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_formulario"));
            o.btnNuevo_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnNuevo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnNuevo")));
            o.btnCopiar_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnCopiar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnCopiar")));
            o.btnEditar_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnEditar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnEditar")));
            o.btnGrabar_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnGrabar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnGrabar")));
            o.btnImprimir_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnImprimir")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnImprimir")));
            o.btnBuscar_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnBuscar")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnBuscar")));
            o.btnVistaPrevia_ =Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnVistaPrevia")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnVistaPrevia")));
            o.btnForm_ = Convert.ToBoolean(rdr.IsDBNull(rdr.GetOrdinal("btnForm")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("btnForm")));
          

           
            return o;
        }


        public static List<EControlUsuario> mListarControlUsuario(EControlUsuario oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pidUser", oc.IdUser);
     

            List<EControlUsuario> result = new List<EControlUsuario>();

            using (IDataReader rdr = db.ExecuteReader("SY_ControlUsuario_qry02"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarControlForm(rdr));
                }
            }
            return result;
        }



        private static EControlUsuario LeerReader(IDataReader reader)
        {

            EControlUsuario usu = new EControlUsuario();

          
            usu._btnNuevo = reader["btnNuevo"].ToString();
            usu._btnCopiar = reader["btnCopiar"].ToString();
            usu._btnEditar = reader["btnEditar"].ToString();
            usu._btnGrabar = reader["btnGrabar"].ToString();
            usu._btnImprimir = reader["btnImprimir"].ToString();
            usu._btnBuscar = reader["btnBuscar"].ToString();
            usu._btnVistaPrevia = reader["btnVistaPrevia"].ToString();
            usu._btnForm = reader["btnForm"].ToString();

            return usu;
        }


        public static EControlUsuario UsuarioFill(EControlUsuario u)
        {
            DBAccess db = new DBAccess();



            db.AddParameter("@idUser", u.IdUser);
            db.AddParameter("@idModulo", u.IdModulo);
            db.AddParameter("@idFormulario", u.Id_formulario);


            EControlUsuario usu = new EControlUsuario();



            using (IDataReader reader = db.ExecuteReader("SY_ControlUsuario_qry03"))
            {
                while (reader.Read())
                {
                    return LeerReader(reader);

                }

            }
            return u;

        }


        public static List<EControlUsuario> SY_ControlFormulario_qry01(EControlUsuario obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idModulo", obj.IdModulo);



            List<EControlUsuario> result = new List<EControlUsuario>();
            using (IDataReader rd = db.ExecuteReader("SY_ControlFormulario_qry01"))
            {
                while (rd.Read())
                {
                    result.Add(mCargarControlForm(rd));
                }
            }

            return result;
        }


        private static EControlUsuario mCargarControlForm(IDataReader rdr)
        {
            EControlUsuario obj = new EControlUsuario();

            obj.IdModulo = rdr.IsDBNull(rdr.GetOrdinal("idModulo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idModulo"));
            obj.dsModulo = rdr.IsDBNull(rdr.GetOrdinal("ds_modulo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_modulo"));


            obj.Id_formulario = rdr.IsDBNull(rdr.GetOrdinal("id_formulario")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_formulario"));
            obj.ds_formulario = rdr.IsDBNull(rdr.GetOrdinal("ds_formulario")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_formulario"));


            bool st_btnNuevo = rdr.GetBoolean(rdr.GetOrdinal("btnNuevo"));
            obj.btnNuevo_ = st_btnNuevo;

            bool st_btnCopiar = rdr.GetBoolean(rdr.GetOrdinal("btnCopiar"));
            obj.btnCopiar_ = st_btnCopiar;

            bool st_btnEditar = rdr.GetBoolean(rdr.GetOrdinal("btnEditar"));
            obj.btnEditar_ = st_btnEditar;

            bool st_btnGrabar = rdr.GetBoolean(rdr.GetOrdinal("btnGrabar"));
            obj.btnGrabar_ = st_btnGrabar;

            bool st_btnImprimir = rdr.GetBoolean(rdr.GetOrdinal("btnImprimir"));
            obj.btnImprimir_ = st_btnImprimir;

            bool st_btnBuscar = rdr.GetBoolean(rdr.GetOrdinal("btnBuscar"));
            obj.btnBuscar_ = st_btnBuscar;

            bool st_btnVistaPrevia = rdr.GetBoolean(rdr.GetOrdinal("btnVistaPrevia"));
            obj.btnVistaPrevia_ = st_btnVistaPrevia;

            bool st_btnForm = rdr.GetBoolean(rdr.GetOrdinal("btnForm"));
            obj.btnForm_ = st_btnForm;

            //bool st_igv = rdr.GetBoolean(rdr.GetOrdinal("st_igv"));
            //objID._igvActivo = st_igv;

            return obj;

        }


    }
}
