using System;
using System.Runtime.Serialization;
using Texfina.Core.Data;

namespace Texfina.Entity.Pd
{
   /// <summary>
   /// Entidad para la Tabla: Personal (RH_Personal)
   /// </summary>
   [DataContract()]
   public class EMaquinas : IEntityBase
   {

       #region Campos
       
       private EntityState _intState = EntityState.Unchanged;
       private string _strIdEmpresa = "";
       private string _strIdMaquina = "";
       private string _strDsMaquina = "";
       private string _strIdMaqFabrica = "";
       private string _strNuVolMax = "";
       private string _strNuVolMin = "";
       private string _strNuVolMed = "";
       private string _strNuTempMax = "";
       private string _strStChp = "";
       private string _strIdTipoTinta = "";
       private decimal _decNuCapacidad = 0;
       private decimal _decMtCostoMin = 0;
       private string _strNuHoraProductiva = "";
       private string _strMtMinProduccion = "";
       private string _strIdTipoMaquina = "";
       private string _strStMaquina = "";
       private Nullable<DateTime> _datFeRegistro = null;
       private decimal _decMtResiduoDia = 0;
       private decimal _decMtHorasAsis = 0;
       private string _strNuOrdenSeq = "";
       private string _strStUltimaLinea = "";
       private string _strStFaseUnica = "";
       private string _strDsConUltima = "";
       private string _strDsMadUltima = "";
       private string _strNuMicro = "";
       private string _strNuVolResiduo = "";
       private string _strNuVolTope = "";
       private decimal _decMtCapacidad = 0;
       private string _strStPrincipal = "";
       private string _strIdNhd = "";
       private string _strNuTubosMaq = "";
       private string _strIdRelBan = "";
       private string _strNuVolBal = "";
       private string _strStTipoMaq = "";
       private string _strIdTipoMaq = "";
       private decimal _decMtCostoGeneral = 0;
       private string _strStFormula = "";
       private decimal _decMtPesoMin = 0;
       private decimal _decMtPesoMed = 0;
       private decimal _decMtPesoMax = 0;
       private decimal _decMtProdMin = 0;
       private decimal _decMtProdMed = 0;
       private decimal _decMtProdMax = 0;
       private string _strIdCCosto = "";
       private string _strIdBan = "";
       private string _strStSalm = "";
       private decimal _decMtSalMKI = 0;
       private decimal _decMtSalMKF = 0;
       private decimal _decMtCantCor = 0;
       private string _strIdTipoCentro = "";
       private string _strStDosificaProd = "";
       private string _strDsDetalleCol = "";
       private decimal _decMtFacAbs = 0;
       private decimal _decMtKgsId = 0;
       private string _strStPlaneamiento = "";
       private string _strStVisiblePlan = "";
       private string _strIdMaquinaAux = "";
       private string _strStEstado = "";
       private string _strStAnulado = "";

       #endregion

       #region Atributos

       [DataMember()]
       public EntityState EntityState
       {
           get { return _intState; }
           set { _intState = value; }
       }

       [DataMember()]
       public string IdEmpresa
       {
           get { return _strIdEmpresa; }
           set { _strIdEmpresa = value; }
       }

       [DataMember()]
       public string IdMaquina
       {
           get { return _strIdMaquina; }
           set { _strIdMaquina = value; }
       }

       [DataMember()]
       public string DsMaquina
       {
           get { return _strDsMaquina; }
           set { _strDsMaquina = value; }
       }

       [DataMember()]
       public string IdMaqFabrica
       {
           get { return _strIdMaqFabrica; }
           set { _strIdMaqFabrica = value; }
       }

       [DataMember()]
       public string NuVolMax
       {
           get { return _strNuVolMax; }
           set { _strNuVolMax = value; }
       }

       [DataMember()]
       public string NuVolMin
       {
           get { return _strNuVolMin; }
           set { _strNuVolMin = value; }
       }

       [DataMember()]
       public string NuVolMed
       {
           get { return _strNuVolMed; }
           set { _strNuVolMed = value; }
       }

       [DataMember()]
       public string NuTempMax
       {
           get { return _strNuTempMax; }
           set { _strNuTempMax = value; }
       }

       [DataMember()]
       public string StChp
       {
           get { return _strStChp; }
           set { _strStChp = value; }
       }

       [DataMember()]
       public string IdTipoTinta
       {
           get { return _strIdTipoTinta; }
           set { _strIdTipoTinta = value; }
       }

       [DataMember()]
       public decimal NuCapacidad
       {
           get { return _decNuCapacidad; }
           set { _decNuCapacidad = value; }
       }

       [DataMember()]
       public decimal MtCostoMin
       {
           get { return _decMtCostoMin; }
           set { _decMtCostoMin = value; }
       }

       [DataMember()]
       public string NuHoraProductiva
       {
           get { return _strNuHoraProductiva; }
           set { _strNuHoraProductiva = value; }
       }

       [DataMember()]
       public string MtMinProduccion
       {
           get { return _strMtMinProduccion; }
           set { _strMtMinProduccion = value; }
       }

       [DataMember()]
       public string IdTipoMaquina
       {
           get { return _strIdTipoMaquina; }
           set { _strIdTipoMaquina = value; }
       }

       [DataMember()]
       public string StMaquina
       {
           get { return _strStMaquina; }
           set { _strStMaquina = value; }
       }

       [DataMember()]
       public Nullable<DateTime> FeRegistro
       {
           get { return _datFeRegistro; }
           set { _datFeRegistro = value; }
       }

       [DataMember()]
       public decimal MtResiduoDia
       {
           get { return _decMtResiduoDia; }
           set { _decMtResiduoDia = value; }
       }

       [DataMember()]
       public decimal MtHorasAsis
       {
           get { return _decMtHorasAsis; }
           set { _decMtHorasAsis = value; }
       }

       [DataMember()]
       public string NuOrdenSeq
       {
           get { return _strNuOrdenSeq; }
           set { _strNuOrdenSeq = value; }
       }

       [DataMember()]
       public string StUltimaLinea
       {
           get { return _strStUltimaLinea; }
           set { _strStUltimaLinea = value; }
       }

       [DataMember()]
       public string StFaseUnica
       {
           get { return _strStFaseUnica; }
           set { _strStFaseUnica = value; }
       }

       [DataMember()]
       public string DsConUltima
       {
           get { return _strDsConUltima; }
           set { _strDsConUltima = value; }
       }

       [DataMember()]
       public string DsMadUltima
       {
           get { return _strDsMadUltima; }
           set { _strDsMadUltima = value; }
       }

       [DataMember()]
       public string NuMicro
       {
           get { return _strNuMicro; }
           set { _strNuMicro = value; }
       }

       [DataMember()]
       public string NuVolResiduo
       {
           get { return _strNuVolResiduo; }
           set { _strNuVolResiduo = value; }
       }

       [DataMember()]
       public string NuVolTope
       {
           get { return _strNuVolTope; }
           set { _strNuVolTope = value; }
       }

       [DataMember()]
       public decimal MtCapacidad
       {
           get { return _decMtCapacidad; }
           set { _decMtCapacidad = value; }
       }

       [DataMember()]
       public string StPrincipal
       {
           get { return _strStPrincipal; }
           set { _strStPrincipal = value; }
       }

       [DataMember()]
       public string IdNhd
       {
           get { return _strIdNhd; }
           set { _strIdNhd = value; }
       }

       [DataMember()]
       public string NuTubosMaq
       {
           get { return _strNuTubosMaq; }
           set { _strNuTubosMaq = value; }
       }

       [DataMember()]
       public string IdRelBan
       {
           get { return _strIdRelBan; }
           set { _strIdRelBan = value; }
       }

       [DataMember()]
       public string NuVolBal
       {
           get { return _strNuVolBal; }
           set { _strNuVolBal = value; }
       }

       [DataMember()]
       public string StTipoMaq
       {
           get { return _strStTipoMaq; }
           set { _strStTipoMaq = value; }
       }

       [DataMember()]
       public string IdTipoMaq
       {
           get { return _strIdTipoMaq; }
           set { _strIdTipoMaq = value; }
       }

       [DataMember()]
       public decimal MtCostoGeneral
       {
           get { return _decMtCostoGeneral; }
           set { _decMtCostoGeneral = value; }
       }

       [DataMember()]
       public string StFormula
       {
           get { return _strStFormula; }
           set { _strStFormula = value; }
       }

       [DataMember()]
       public decimal MtPesoMin
       {
           get { return _decMtPesoMin; }
           set { _decMtPesoMin = value; }
       }

       [DataMember()]
       public decimal MtPesoMed
       {
           get { return _decMtPesoMed; }
           set { _decMtPesoMed = value; }
       }

       [DataMember()]
       public decimal MtPesoMax
       {
           get { return _decMtPesoMax; }
           set { _decMtPesoMax = value; }
       }

       [DataMember()]
       public decimal MtProdMin
       {
           get { return _decMtProdMin; }
           set { _decMtProdMin = value; }
       }

       [DataMember()]
       public decimal MtProdMed
       {
           get { return _decMtProdMed; }
           set { _decMtProdMed = value; }
       }

       [DataMember()]
       public decimal MtProdMax
       {
           get { return _decMtProdMax; }
           set { _decMtProdMax = value; }
       }

       [DataMember()]
       public string IdCCosto
       {
           get { return _strIdCCosto; }
           set { _strIdCCosto = value; }
       }

       [DataMember()]
       public string IdBan
       {
           get { return _strIdBan; }
           set { _strIdBan = value; }
       }

       [DataMember()]
       public string StSalm
       {
           get { return _strStSalm; }
           set { _strStSalm = value; }
       }

       [DataMember()]
       public decimal MtSalMKI
       {
           get { return _decMtSalMKI; }
           set { _decMtSalMKI = value; }
       }

       [DataMember()]
       public decimal MtSalMKF
       {
           get { return _decMtSalMKF; }
           set { _decMtSalMKF = value; }
       }

       [DataMember()]
       public decimal MtCantCor
       {
           get { return _decMtCantCor; }
           set { _decMtCantCor = value; }
       }

       [DataMember()]
       public string IdTipoCentro
       {
           get { return _strIdTipoCentro; }
           set { _strIdTipoCentro = value; }
       }

       [DataMember()]
       public string StDosificaProd
       {
           get { return _strStDosificaProd; }
           set { _strStDosificaProd = value; }
       }

       [DataMember()]
       public string DsDetalleCol
       {
           get { return _strDsDetalleCol; }
           set { _strDsDetalleCol = value; }
       }

       [DataMember()]
       public decimal MtFacAbs
       {
           get { return _decMtFacAbs; }
           set { _decMtFacAbs = value; }
       }

       [DataMember()]
       public decimal MtKgsId
       {
           get { return _decMtKgsId; }
           set { _decMtKgsId = value; }
       }

       [DataMember()]
       public string StPlaneamiento
       {
           get { return _strStPlaneamiento; }
           set { _strStPlaneamiento = value; }
       }

       [DataMember()]
       public string StVisiblePlan
       {
           get { return _strStVisiblePlan; }
           set { _strStVisiblePlan = value; }
       }

       [DataMember()]
       public string IdMaquinaAux
       {
           get { return _strIdMaquinaAux; }
           set { _strIdMaquinaAux = value; }
       }

       [DataMember()]
       public string StEstado
       {
           get { return _strStEstado; }
           set { _strStEstado = value; }
       }

       [DataMember()]
       public string StAnulado
       {
           get { return _strStAnulado; }
           set { _strStAnulado = value; }
       }

       #endregion


   }
}
