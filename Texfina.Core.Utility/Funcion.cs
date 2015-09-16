using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texfina.Core.Utility
{
    public class Funcion
    {


        
            public static bool validarCampoDecimal (TextBox CajadeTexto)
            {
                    try
                    {
	                    decimal d= Convert.ToDecimal(CajadeTexto.Text);
                        return true;
                    }
                    catch( Exception ex)
                    {
	                     CajadeTexto.Text ="0.0000";
                         CajadeTexto.Select(0,CajadeTexto.Text.Length);
                        return false;
                    }

            }


            public static bool ValidarCampoEntero(TextBox CajadeTexto)
            {
                try
                {
                    decimal d = Convert.ToInt64(CajadeTexto.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    CajadeTexto.Text = "0";
                    CajadeTexto.Select(0, CajadeTexto.Text.Length);
                    return false;
                }

            }

    }
}
