using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace YODA.Web
{
    public class HTMLUtil
    {
        public HTMLUtil()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static string MinificarHTML(string htmlCadena)
        {

            Regex regEspaciosEntreTags = new Regex(@">(?! )\s+", RegexOptions.Singleline);
            Regex regSaltoDeLinea = new Regex(@"([\n\s])+?(?<= {2,})<", RegexOptions.Singleline);
            Regex regSaltoDeLinea2 = new Regex(@"\r\n", RegexOptions.Singleline);
            Regex regTabs = new Regex(@"\t", RegexOptions.Singleline);
            Regex regEspaciosEnBlanco = new Regex(@"\s{2,}", RegexOptions.Singleline);


            htmlCadena = regEspaciosEntreTags.Replace(htmlCadena, ">");
            htmlCadena = regSaltoDeLinea.Replace(htmlCadena, "<");
            htmlCadena = regSaltoDeLinea2.Replace(htmlCadena, string.Empty);
            htmlCadena = regTabs.Replace(htmlCadena, string.Empty);
            htmlCadena = regEspaciosEnBlanco.Replace(htmlCadena, string.Empty);

            return htmlCadena.ToString();
        }

         public static string MinificarHTML2(string htmlCadena)
        {

            return Regex.Replace(Regex.Replace(htmlCadena, @"\s*\n\s*", "\n", RegexOptions.Multiline), @"\s{2,}", " ", RegexOptions.Multiline);

        }

         public static string MinificarHTML3(string htmlCadena)
         {

             Regex tabsRe = new Regex(@"\t", RegexOptions.Compiled | RegexOptions.Multiline);
             Regex carriageReturnRe = new Regex(@">\r\n<", RegexOptions.Compiled | RegexOptions.Multiline);
             Regex carriageReturnSafeRe = new Regex(@"\r\n", RegexOptions.Compiled | RegexOptions.Multiline);
             Regex multipleSpaces = new Regex("  ", RegexOptions.Compiled | RegexOptions.Multiline);
             Regex spaceBetweenTags = new Regex(@">\s<", RegexOptions.Compiled | RegexOptions.Multiline);


             htmlCadena = tabsRe.Replace(htmlCadena, string.Empty);
             htmlCadena = carriageReturnRe.Replace(htmlCadena, "><");
             htmlCadena = carriageReturnSafeRe.Replace(htmlCadena, " ");

             while (multipleSpaces.IsMatch(htmlCadena))
                 htmlCadena = multipleSpaces.Replace(htmlCadena, " ");

             htmlCadena = spaceBetweenTags.Replace(htmlCadena, "><");

             return htmlCadena;
         }

        

    }  
}
