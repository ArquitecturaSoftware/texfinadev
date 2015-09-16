using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Sy
{
   public class EControlUsuario
    {

    

            #region Campos
            private string _strIdUser = "";
            private string _strIdModulo = "";
            private string _strdsModulo = "";
            private string _strId_formulario = "";
            private string _strds_formulario = "";  
            private bool _strBtnNuevo ;
            private bool _strBtnCopiar ;
            private bool _strBtnEditar ;
            private bool _strBtnGrabar ;
            private bool _strBtnImprimir ;
            private bool _strBtnBuscar ;
            private bool _strBtnVistaPrevia ;
            private bool _strForm;
           
            //private string _strStAnulado = "";

            #endregion

            #region Atributos


            public string IdUser
            {
                get { return _strIdUser; }
                set { _strIdUser = value; }
            }


            public string IdModulo
            {
                get { return _strIdModulo; }
                set { _strIdModulo = value; }
            }


            public string dsModulo
            {
                get { return _strdsModulo; }
                set { _strdsModulo = value; }
            }


            public string Id_formulario
            {
                get { return _strId_formulario; }
                set { _strId_formulario = value; }
            }

         public string ds_formulario
            {
                get { return _strds_formulario; }
                set { _strds_formulario = value; }
            }
        

            public bool BtnNuevo
            {
                get { return _strBtnNuevo; }
                set { _strBtnNuevo = value; }
            }

           
            public bool BtnCopiar
            {
                get { return _strBtnCopiar; }
                set { _strBtnCopiar = value; }
            }


            public bool BtnEditar
            {
                get { return _strBtnEditar; }
                set { _strBtnEditar = value; }
            }


            public bool BtnGrabar
            {
                get { return _strBtnGrabar; }
                set { _strBtnGrabar = value; }
            }


            public bool BtnImprimir
            {
                get { return _strBtnImprimir; }
                set { _strBtnImprimir = value; }
            }


            public bool BtnBuscar
            {
                get { return _strBtnBuscar; }
                set { _strBtnBuscar = value; }
            }


            public bool BtnVistaPrevia
            {
                get { return _strBtnVistaPrevia; }
                set { _strBtnVistaPrevia = value; }
            }

            public bool BtnForm
            {
                get { return _strForm; }
                set { _strForm = value; }
            }


            public string _btnNuevo { get; set; }
            public string _btnCopiar { get; set; }
            public string _btnEditar { get; set; }
            public string _btnGrabar { get; set; }
            public string _btnImprimir { get; set; }
            public string _btnBuscar { get; set; }
            public string _btnVistaPrevia { get; set; }
            public string _btnForm { get; set; }
       //---------------------------------------------
            public bool btnNuevo_ { get; set; }
            public bool btnCopiar_ { get; set; }
            public bool btnEditar_ { get; set; }
            public bool btnGrabar_ { get; set; }
            public bool btnImprimir_ { get; set; }
            public bool btnBuscar_ { get; set; }
            public bool btnVistaPrevia_ { get; set; }
            public bool btnForm_ { get; set; }



            /// <summary>
            /// Estado Anulado
            /// </summary>
            /// <value></value>
            /// <returns></returns>
     
            //public string StAnulado
            //{
            //    get { return _strStAnulado; }
            //    set { _strStAnulado = value; }
            //}

            #endregion

        

    }
}
