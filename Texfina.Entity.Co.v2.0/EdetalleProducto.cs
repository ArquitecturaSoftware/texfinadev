using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EdetalleProducto
    {

        #region Campos
            
            private string Idproducto;
            private string IdPres;
            private string DsProducto;
            private string Presentacion;
            private string Descrip;
            private string UM;
            private decimal PesoBruto;
            private string OP;
            private decimal Cantidad;
            private string Pneto;
            private decimal PorDesc;
            private string TG;
            private string idUn;
            private string dsUn;
            private string Idccostos;
            private string dsCosto;
            private decimal Dscto;
            private decimal IGV;
            private decimal SubTotal;

        #endregion 

        #region Campos

            public string _Idproducto
            {
                get { return Idproducto; }
                set { Idproducto = value; }
            }

            public string _IdPres
            {
                get { return IdPres; }
                set { IdPres = value; }
            }

            public string _DsProducto
            {
                get { return DsProducto; }
                set { DsProducto = value; }
            }

            public string _Presentacion
            {
                get { return Presentacion; }
                set { Presentacion = value; }
            }

            public string _Descrip
            {
                get { return Descrip; }
                set { Descrip = value; }
            }

            public string _UM
            {
                get { return UM; }
                set { UM = value; }
            }


            public decimal _PesoBruto
            {
                get { return PesoBruto; }
                set { PesoBruto = value; }
            }

            public string _OP
            {
                get { return OP; }
                set { OP = value; }
            }

            public decimal _Cantidad
            {
                get { return Cantidad; }
                set { Cantidad = value; }
            }

            public string _Pneto
            {
                get { return Pneto; }
                set { Pneto = value; }
            }

            public decimal _PorDesc
            {
                get { return PorDesc; }
                set { PorDesc = value; }
            }

            public string _TG
            {
                get { return TG; }
                set { TG = value; }
            }

            public string _idUn
            {
                get { return idUn; }
                set { idUn = value; }
            }

            public string _dsUn
            {
                get { return dsUn; }
                set { dsUn = value; }
            }

            public string _Idccostos
            {
                get { return Idccostos; }
                set { Idccostos = value; }
            }

            public string _dsCosto
            {
                get { return dsCosto; }
                set { dsCosto = value; }
            }

            public decimal _Dscto
            {
                get { return Dscto; }
                set { Dscto = value; }
            }

            public decimal _IGV
            {
                get { return IGV; }
                set { IGV = value; }
            }

            public decimal _SubTotal
            {
                get { return SubTotal; }
                set { SubTotal = value; }
            }

        #endregion

        

    }
}
