using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Core.Common
{
    public class Constants2
    {

        public class ConstSistema
        {
            public static readonly string CONFIGDATA = "Config\\ConfigData.xml";
            //public static readonly string LOGO_WEBPAGE = "wfLogo.aspx?Filter=1";
            public static readonly string ROOT_FOLDER_PATH = "~/Reporte";
            ////public static readonly string ROOT_FOLDER_PATH_ = "~/Report";
            //public static readonly string ROOT_IMAGES_PATH = "~/Images";
            //public static readonly string OTHERFILES_PATH = "~/OtherFiles";
            //public static readonly string ROOT_ENA_ICONS_PATH = ROOT_IMAGES_PATH + "/Icons/Enabled";
            //public static readonly string ROOT_DIS_ICONS_PATH = ROOT_IMAGES_PATH + "/Icons/Disabled";
            //public static readonly string SYS_NAME = "TEXFINA.NET";
            //public static readonly string APSET_AD_DOMAIN = "ActiveDirectoryDomain";
            //public static readonly string APSET_AD_LDAP = "ActiveDirectoryLDAP";
            //public static readonly string ROOT_UPLOADFOLDER_PATH = "~/UploadFiles";
        }

        public class ConstAuthenticationType
        {
            public static readonly string LDAP = "LdapAuthentication";
            public static readonly string FORM = "Forms";
        }

        public class ConstSeguridadGrupo
        {
            public static readonly string ADMINS = "G0001";
        }

        public class ConstMenuToolbarValue
        {
            public const string BUTTON_NEW = "_BTTNEW";
            public const string BUTTON_COPY = "_BTTCOPY";
            public const string BUTTON_EDIT = "_BTTEDIT";
            public const string BUTTON_DELETE = "_BTTDEL";
            public const string BUTTON_PREVIEW = "_BTTPREVI";
            public const string BUTTON_PRINT = "_BTTPRN";
            public const string BUTTON_SAVE = "_BTTSAVE";
            public const string BUTTON_SAVENEW = "_BTTSAVNEW";
            public const string BUTTON_SAVEOK = "_BTTSAVOK";
            public const string BUTTON_SAVEOBS = "_BTTSAVOBS";
            public const string BUTTON_EXIT = "_BTTEXIT";
            public const string BUTTON_NEXT = "_BTNEXT";
            public const string BUTTON_EXPORT = "_BTTEXPO";
            public const string BUTTON_CALCULAR = "_BTTCALC";
            public const string BUTTON_BUSCAR = "_BUSCAR";
        }

        public class ConstMenuControlValue
        {
            public static readonly string BUTTON_FIND = "~/Images/Controls/calendar.gif";
            public static readonly string BUTTON_NEW = "~/Images/Icons/Enabled/NEW.png";
            public static readonly string BUTTON_DELETE = "~/Images/Icons/Enabled/Delete.png";
            public static readonly string BUTTON_SAVENEW = "~/Images/Icons/Enabled/SAVENEW.png";
            public static readonly string BUTTON_BUSCAR = "~/Images/Icons/Enabled/bt_buscar.gif";
            public static readonly string BUTTON_EDIT = "~/Images/Icons/Enabled/EditFile.png";
            public static readonly string BUTTON_COPY = "~/Images/Icons/Enabled/Copy.png";

            public static readonly string BUTTON_EXIT = "~/Images/Icons/Enabled/BACK.png";

        }

        public class ConstSessionVar
        {
            //obtener la sesion del proveedor desde un popup

            public static readonly string SESION_PROV;
            public static readonly string SESION_FORMPAGO;
            public static readonly string SESION_PEDIDOPOR;
            public static readonly string SESION_EMITIDOPOR;
            public static readonly string SESION_IMPORTACION;
            public static readonly string SESION_EXPORTACION;
            public static readonly string SESION_PRODUCTO;
            public static readonly string SESION_PRODUCTO_; // sesion usada en wfProductoBnd.aspx para la OC
            public static readonly string SESION_TIPOGASTO;

            public static readonly string SESION_ODFIND;


            public static readonly string LAST_ERR = "_LASTERR";
            public static readonly string EMPRESA = "_EMP";
            public static readonly string PERIODO = "_PERIODO";
            public static readonly string USERLOGON = "_USERLOG";
            public static readonly string USERID = "_USERID";
            public static readonly string ISADM = "_ISADM";
            public static readonly string HOST_NAME = "REMOTE_HOST";
            public static readonly string REPORT_SOURCE = "_RPTSRC";
            public static readonly string UFILTER = "_FILTER";
            public static readonly string MESSAGE = "_MSG";
            public static readonly string ROWGRID = "rowGrid";
        }

        public class ConstGridRowCommand
        {
            public const string GRIDNEW = "CmdNew";
            public const string GRIDCOPY = "CmdCopy";
            public const string GRIDPASTE = "CmdPaste";
            public const string GRIDEDIT = "CmdEdit";

            public const string GRIDDELETE = "CmdDel";
            public const string GRIDDELETEALL = "CmdDelALL";

            public const string GRIDPREVIEW = "CmdPrev";
            public const string GRIDCHECK = "CmdCheck";
            public const string GRIDDOWLOAD = "CmdDow";
            public const string GRIDMST = "CmdMst";
            public const string GRIDCALC = "CmdCalc";
            public const string GRIDACTIVO = "Cmdactivo";
            public const string GRIDINACTIVO = "Cmdinactivo";


        }

        public class ConstFlagEstado
        {
            public static readonly string ACTIVADO = "1";
            public static readonly string DESACTIVADO = "0";
        }

        public class ConstEstadoOC
        {
            public static readonly string Pendiente = "T";
            public static readonly string nPendiente = "C";
            public static readonly string Autorizado = "P";

      
        }


    
    }
}
