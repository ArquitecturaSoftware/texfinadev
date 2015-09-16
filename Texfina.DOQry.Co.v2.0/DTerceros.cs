using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using System.Data;

namespace Texfina.DOQry.Co
{
    public class DTerceros
    {

        public static void Proveedor_mnt01(ETerceros prov)
        {
            DBAccess db = new DBAccess();
            
            db.AddParameter("@pchr_idclipro", prov.Id_clipro);
            db.AddParameter("@pchr_idempresa", prov.Id_empresa);
            db.AddParameter("@pchr_idvpersjuri", prov.Id_vpersjuri);
            db.AddParameter("@pchr_idvtipsocie", prov.Id_vtipsocie);
            db.AddParameter("@pvch_dsraznombre", prov.Ds_raznombre);
            db.AddParameter("@pvch_dsapellido", prov.Ds_apellido);
            db.AddParameter("@pchr_nuruc", prov.Nu_ruc);
            db.AddParameter("@pchr_idvtipdoc", prov.Id_vtipdoc);
            db.AddParameter("@pvch_nudociden", prov.Nu_dociden);
            db.AddParameter("@pvch_dsnomcomer", prov.Ds_nomcomer);
            db.AddParameter("@pchr_idgrupo", prov.Id_grupo);
            db.AddParameter("@pchr_st_activo", prov.St_activo);
            db.AddParameter("@pvch_dsdireccion", prov.Ds_direccion);
            db.AddParameter("@pvch_dsurbaniza", prov.Ds_urbaniza);
            db.AddParameter("@pchr_idpais", prov.Id_pais);
            db.AddParameter("@pchr_iddepto", prov.Id_depto);
            db.AddParameter("@pchr_idprov", prov.Id_prov);
            db.AddParameter("@pchr_iddist", prov.Id_dist);
            db.AddParameter("@pvch_dspobox", prov.Ds_pobox);
            db.AddParameter("@pvch_nutelf1", prov.Nu_telf1);
            db.AddParameter("@pvch_nutelf2", prov.Nu_telf2);
            db.AddParameter("@pvch_nutelf3", prov.Nu_telf3);
            db.AddParameter("@pvch_nufax1", prov.Nu_fax1);
            db.AddParameter("@pvch_nufax2", prov.Nu_fax2);
            db.AddParameter("@pvch_dsemailco", prov.Ds_emailco);
            db.AddParameter("@pvch_dsurl", prov.Ds_url);
            db.AddParameter("@pvch_dsnomreleg", prov.Ds_nomreleg);
            db.AddParameter("@pvch_dsappreleg", prov.Ds_appreleg);
            db.AddParameter("@pvch_dsapmreleg", prov.Ds_apmreleg);
            db.AddParameter("@pvch_nutlfreleg", prov.Nu_tlfreleg);
            db.AddParameter("@pvch_nuanxreleg", prov.Nu_anxreleg);
            db.AddParameter("@pvch_nunxtreleg", prov.Nu_nxtreleg);
            db.AddParameter("@pvch_dsemareleg", prov.Ds_emareleg);
            db.AddParameter("@pchr_idvtipcalle", prov.Id_vtipcalle);
            db.AddParameter("@pchr_idvendedor", prov.Id_vendedor);
            db.AddParameter("@pdec_mtvalorprod", prov.Mt_valorprod);
            db.AddParameter("@pint_numaquinas", prov.Nu_maquinas);
            db.AddParameter("@pint_nutrabaja", prov.Nu_trabaja);
            db.AddParameter("@pchr_idcpago", prov.Id_cpago);
            db.AddParameter("@pdec_nulcredit", prov.Nu_lcredit);
            db.AddParameter("@pint_nuplacredit", prov.Nu_placredit);
            db.AddParameter("@pchr_nudiapag1", prov.Nu_diapag1);
            db.AddParameter("@pchr_nudiapag2", prov.Nu_diapag2);
            db.AddParameter("@pchr_nudiapag3", prov.Nu_diapag3);
            db.AddParameter("@pchr_nudiapag4", prov.Nu_diapag4);
            db.AddParameter("@pchr_nudiapag5", prov.Nu_diapag5);
            db.AddParameter("@pchr_nudiapag6", prov.Nu_diapag6);
            db.AddParameter("@pchr_nudiapag7", prov.Nu_diapag7);
            db.AddParameter("@pchr_hodiapag1_1", prov.Ho_diapag1_1);
            db.AddParameter("@pchr_hodiapag1_2", prov.Ho_diapag1_2);
            db.AddParameter("@pchr_hodiapag2_1", prov.Ho_diapag2_1);
            db.AddParameter("@pchr_hodiapag2_2", prov.Ho_diapag2_2);
            db.AddParameter("@pchr_hodiapag3_1", prov.Ho_diapag3_1);
            db.AddParameter("@pchr_hodiapag3_2", prov.Ho_diapag3_2);
            db.AddParameter("@pchr_hodiapag4_1", prov.Ho_diapag4_1);
            db.AddParameter("@pchr_hodiapag4_2", prov.Ho_diapag4_2);
            db.AddParameter("@pchr_hodiapag5_1", prov.Ho_diapag5_1);
            db.AddParameter("@pchr_hodiapag5_2", prov.Ho_diapag5_2);
            db.AddParameter("@pchr_hodiapag6_1", prov.Ho_diapag6_1);
            db.AddParameter("@pchr_hodiapag6_2", prov.Ho_diapag6_2);
            db.AddParameter("@pchr_hodiapag7_1", prov.Ho_diapag7_1);
            db.AddParameter("@pchr_hodiapag7_2", prov.Ho_diapag7_2);
            db.AddParameter("@pchr_stvtipcli", prov.St_vtipcli);
            db.AddParameter("@pchr_stvtippro", prov.St_vtippro);
            db.AddParameter("@pchr_st_prospecto", prov.St_prospecto);
            db.AddParameter("@id_ucrearec", prov.Id_ucrearec);
            db.ExecuteNonQuery("MG_clienprove_mmt01");

        }


        public static IDataReader Terceros_qry02(string id)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idEmpresa", id);

            return db.ExecuteReader("MG_GencodigoTercero");
        }

        public static List<Dato> Terceros_qry02_(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", Codigo);

            IDataReader reader = db.ExecuteReader("MG_GencodigoTercero");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_clipro"].ToString();
                _dato.desc = reader["id_clipro"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

    }
}
