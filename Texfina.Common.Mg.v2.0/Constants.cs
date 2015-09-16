using System;

namespace Texfina.Common.Mg
{
   public class ConstMultitabla
   {
      public static readonly String TIPO_DOCUMENTO = "001";
      public static readonly String TIPO_VIA = "002";
      public static readonly String TIPO_ZONA = "003";
      public static readonly String SEXO = "004";
      public static readonly String TIPO_COLABORADOR = "005";
      public static readonly String TIPO_CUENTA_BANCARIA = "006";
      public static readonly String CATEGORIA_OCUPACIONAL = "007";
      public static readonly String REGIMEN_LABORAL = "008";
      public static readonly String NIVEL_EDUCATIVO = "009";
      public static readonly String REGIME_PENSIONARIO = "010";
      public static readonly String REGIMEN_SALUD = "011";
      public static readonly String SEGURO_PENSION = "012";
      public static readonly String TIPO_CONTRATO = "013";
      public static readonly String PERIODO_REMUNERACION = "014";
      public static readonly String SEGURO_MEDICO = "015";
      public static readonly String EMPRESA_PRESTADORA_EPS = "016";
      public static readonly String MOTIVO_CESE = "017";
      public static readonly String TIPO_MODALIDAD_FORMATIVA = "018";
      public static readonly String VINCULO_FAMILIAR = "019";
      public static readonly String MOTIVO_BAJA_DH = "020";
      public static readonly String SITUACION_TRABAJADOR = "021";
      public static readonly String TIPO_REMUNERACION = "022";
      public static readonly String ESTADO_CIVIL = "023";
      public static readonly String CATEGORIA_TRABAJADOR = "024";
      public static readonly String CENTRO_FORMACION = "025";
      public static readonly String ESTADO_REG_PERSONAL = "026";
      public static readonly String DOC_VINCULO_FAMILIAR = "027";
      public static readonly String GRUPO_OCUPACIONES = "028";
      public static readonly String TIPO_REMUNERACION_VARIABLE = "029";
      public static readonly String TIPO_MONEDA = "030";
      public static readonly String TIPO_CONCEPTO_PLANILLA = "032";
      public static readonly String ESTADO_CUOTA_PRESTA = "033";
      public static readonly String TIPO_PRESTAMO = "034";
      public static readonly String FORMA_PAGO = "035";
      public static readonly String MES = "036";
      public static readonly String ESTADO_PROCESO_PLANILA = "037";
      public static readonly String TIPO_CANCEL_PRESTAMO = "038";
      public static readonly String TIPO_COMISION_AFP = "039";
      public static readonly String FACTOR_CALCULO_PLANILLA = "040";
      public static readonly String TIPO_SANGRE = "041";
      public static readonly String GRADO_DE_INSTRUCCION= "042";
      public static readonly String CARGO_PERSONAL = "043";
      public static readonly String FUNCION_PERSONAL = "044";
      public static readonly String TIPO_REMUNERACION_BASICA = "045";
      public static readonly String TIPO_REMUN_FIJA_VARIABLE = "047";
      public static readonly String TIPO_GASTO = "048";
      public static readonly String ESTADO_VACACIONES = "049";
      public static readonly String TIPO_SUBSIDIO = "052";
       //Probando el combo
      public static readonly String TIPO_MAQUINA = "053";
   }
   public class ConstMultitablaPE
   {
      public static readonly String TIPO_ACTIVIDAD = "001";
      public static readonly String OCUPACION_SECTOR_PRIVADO = "002";
   }
   public class ConstFormaPago
   {
      public static readonly String OFICIAL = "001";
      public static readonly String PAGO = "002";
   }
   public class ConstTipoCliProv
   {
      public static readonly String CLIENTE = "001";
      public static readonly String PROVEEDOR = "002";
   }
   public class ConstTipoPersona
   {
      public static readonly String NATURAL = "001";
      public static readonly String JURIDICA = "002";
      public static readonly String CONSORCIO_SIN_RUC = "003";
   }
   public class ConstCategoriaTrab
   {
       public const string TRABAJADOR = "001";
       public const string PENSIONISTA = "002";
       public const string PRESTADOR_4ta_CAT = "003";
       public const string PRESTADOR_MOD_FORMATIVA = "004";
       public const string PERSONAL_TERCEROS = "005";
   }
   public class ConstTipoTrabajador
   {
       public const string EJECUTIVO = "019";
       public const string OBRERO = "020";
       public const string EMPLEADO = "021";
   }
   public class ConstEstadoRegPersonal
   {
       public static readonly String PENDIENTE = "001";
       public static readonly String VERIFICADO = "002";
       public static readonly String OBSERVADO = "003";
       public static readonly String ANULADO = "999";
   }
   public class ConstVinculoFamiliar
   {
      public static readonly String CONYUGE = "002";
      public static readonly String CONCUBINA = "003";
      public static readonly String GESTANTE = "004";
      public static readonly String HIJO_MENOR_EDAD = "005";
      public static readonly String HIJO_MAYOR_INCAPACITADO = "006";
   }
   public class ConstDirecReferEsSalud
   {
      public static readonly String DIRECCION_UNO = "1";
      public static readonly String DIRECCION_DOS = "2";
   }
   public class ConstTipoContrato
   {
      public static readonly String INICIO = "001";
      public static readonly String RENOVACION = "002";
   }
   public class ConstEstadoCuotaPresta
   {
      public static readonly String PENDIENTE = "001";
      public static readonly String PAGADO = "002";
      public static readonly String ANULADO = "999";
   }
   public class ConstEstadoProcePlani
   {
      public static readonly String ABIERTA = "001";
      public static readonly String CERRADA = "002";
   }
   public class ConstTipoCancelPrestamo
   {
      public static readonly String DESCUENTO = "001";
      public static readonly String EFECTIVO = "002";
   }
   public class ConstTipoPrestamo
   {
      public static readonly String ADELANTO = "001";
      public static readonly String PRESTAMO = "002";
   }
   public class ConstTipoConcepPlanilla
   {
      public static readonly String REMUNERACION = "001";
      public static readonly String APORTACION = "002";
      public static readonly String RETENCION = "004";
   }
   public class ConstTipoRegularizacion
   {
      public static readonly String NINGUNO = "000";
      public static readonly String REGULARIZACION = "001";
      public static readonly String BONIFICACION = "002";
   }
   public class ConstTipoMigracion
   {
      public const string HORAS = "001";
      public const string REGULARIZACION = "002";
      public const string BONIFICACION = "003";
   }
   public class ConstMotivoCese
   {
      public const string TERMINO = "007";
   }
   public class ConstConceptoRemu
   {
      public const string VACACIONES = "107";
      public const string HNOCTURO = "041";
   }
   public class ConstEstadoVacaciones
   {
       public static readonly String PENDIENTE = "001";
       public static readonly String PAGADO = "002";
   }
   public class ConstPlanilla
   {
       public const string VACACIONES_OBRERO = "005";
       public const string VACACIONES_EMPLEADO = "006";
       public const string VACACIONES_FLJ = "007";
       public const string GRATIFICACION_EMPLEADO = "009";
       public const string GRATIFICACION_OBRERO = "008";
       public const string SUBSIDIO_EMPLEADO = "014";
       public const string SUBSIDIO_OBRERO = "015";

   }
   public class ConstSituacionEmpleado
   {
       public const string BAJA = "000";
       public const string ACTIVO_SUBSIDIADO = "001";
       public const string SIN_VINCULO = "002";
       public const string SUSPENCION = "003";
   }

   public class ConstTipoMaquina
   {
       public const string GENERICA = "G";
       public const string ESPECIFICA = "E";

   }
}
