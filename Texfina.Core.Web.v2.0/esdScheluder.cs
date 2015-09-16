using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;

namespace Texfina.Core.Web
{
    [ToolboxData("<{0}:esdScheluder Runat=server></{0}:esdScheluder>")]
    public class esdScheluder : WebControl
    {

        #region Propiedades

        [DefaultValue("TITULO")]
        public string SCTitulo
        {
            get;
            set;
        }

        public string SCListItemValue
        {
            get;
            set;
        }

        public string SCListItemText
        {
            get;
            set;
        }

        public string SCDataSecuen
        {
            get;
            set;
        }

        public string SCDataFeIni
        {
            get;
            set;
        }

        public string SCDataFeFin
        {
            get;
            set;
        }

        public string SCDataStAnulaLog
        {
            get;
            set;
        }

        public DataTable SCDataList
        {
            get;
            set;
        }

        public DataTable SCDataSchuleder
        {
            get;
            set;
        }

        public DateTime SCFechaInicio
        {
            get;
            set;
        }

        public DateTime SCFechaFin
        {
            get;
            set;
        }

        #endregion

        public esdScheluder()
            : base(HtmlTextWriterTag.Div)
        { }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "Scheduler");
            if (this.Height.ToString() != "")
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Style, "max-height:" + this.Height.ToString());
                writer.AddAttribute(HtmlTextWriterAttribute.Style, "width:" + this.Width.ToString());
            }
            base.AddAttributesToRender(writer);
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void RenderContents(HtmlTextWriter writer)
        {
            string strwitdh = this.Width.ToString();
            string strheight = this.Height.ToString();

            this.Width = 0;
            this.Height = 0;
                       
            TextWriter textwr = new StringWriter();
            if (strwitdh != "")
                textwr.Write("   <div class='ScDivRigh' id='ScDivRigh' style='max-height:" + (int.Parse(strheight.Replace("px", "")) - 1).ToString() + "px;' >");
            else
                textwr.Write("   <div class='ScDivRigh' id='ScDivRigh'>");

            textwr.Write("      <div class='BkgHeader' style='height:18px;width:230px;font-weight:bold;padding:2px;'>");

            if (SCFechaFin.Year == SCFechaInicio.Year)
                textwr.Write(SCFechaFin.Year);
            else
                textwr.Write(SCFechaInicio.Year + " - " + SCFechaFin.Year);

            textwr.Write("      </div>");
            textwr.Write("      <div class='BkgHeader' style='height:17px;width:230px;font-weight:bold;padding:8px;border-top:1px solid #666;'>");
            textwr.Write(SCTitulo == null ? "TITULO" : SCTitulo);
            textwr.Write("      </div>");

            if (strwitdh != "")
                textwr.Write("      <div id='List' class='ScDivRighBody'" + " style='max-height:" + (int.Parse(strheight.Replace("px", "")) - 58).ToString() + "px;' >");
            else
                textwr.Write("      <div id='List' class='ScDivRighBody' >");

            textwr.Write("         <table border='0' cellSpacing='0' cellPadding='0'>");

            if (SCDataList != null)
            {
                if (SCDataList.Rows.Count > 0)
                {
                    foreach (DataRow dr in SCDataList.Rows)
                    {
                        textwr.Write("<tr>");
                        textwr.Write("   <td>");
                        textwr.Write("      <div class='BkgHeader' style='border-bottom:1px solid #666;padding:1px;'>");
                        if (dr[SCDataStAnulaLog].ToString() == "0")
                            textwr.Write("          <input type='button' class='ScBt' onClick='ShowPopupScheluder(0,\"" + dr[SCListItemValue].ToString() + "\",\"" + dr[SCListItemText].ToString() + "\",\"\",\"\",\"\");' />");
                        else
                            textwr.Write("          <input type='button' class='ScBtD' onClick='return false;' />");
                        
                        textwr.Write("      </div>");
                        textwr.Write("   </td>");
                        textwr.Write("   <td>");
                        textwr.Write("      <div class='BkgHeader' style='font-size: 11px;text-align:left; width:230px;height:16px;border-bottom:1px solid #666;'>");
                        
                        textwr.Write(dr[SCListItemText].ToString());
                        
                        textwr.Write("      </div>");
                        textwr.Write("   </td>");
                        textwr.Write("</tr>");
                    }

                    textwr.Write("<tr>");
                    textwr.Write("   <td colspan='2'>");
                    textwr.Write("      <div class='BkgHeader' style='width:230px;height:16px;'>");
                    textwr.Write("      </div>");
                    textwr.Write("   </td>");
                    textwr.Write("</tr>");
                }
                else
                {
                    textwr.Write("<tr>");
                    textwr.Write("   <td colspan='2'>");
                    textwr.Write("      <div class='BkgHeader' style='width:230px;height:41px;'>");
                    textwr.Write("      </div>");
                    textwr.Write("   </td>");
                    textwr.Write("</tr>");
                }
            }
            else
            {
                textwr.Write("<tr>");
                textwr.Write("   <td colspan='2'>");
                textwr.Write("      <div class='BkgHeader' style='width:230px;height:41px;'>");
                textwr.Write("      </div>");
                textwr.Write("   </td>");
                textwr.Write("</tr>");
            }


            textwr.Write("         </table>");
            textwr.Write("      </div>");
            textwr.Write("   </div>");
            textwr.Write("   <div class='ScDivLeft'>");

            #region header
            /*HEADER*/
            textwr.Write("<div id='Header' class='ScDivLeftHeader'>");
            textwr.Write("<table border='0' cellSpacing='0' cellPadding='0'>");

            int intMesIni = 1;
            int intMesFin = 1;

            for (int a = SCFechaInicio.Year; a <= SCFechaFin.Year; a++)
            {

               if (a == SCFechaInicio.Year)
                    intMesIni = SCFechaInicio.Month;
               else
                    intMesIni = 1;

               if (a == SCFechaFin.Year)
                  intMesFin = SCFechaFin.Month;
               else
                  intMesFin = 12;


               for (int mes = intMesIni; mes <= intMesFin; mes++)
                {
                    textwr.Write("<td class='BkgHeader' style='border-right:1px solid #666;' colspan='" + DateTime.DaysInMonth(a, mes).ToString() + "'>");
                    textwr.Write("  <div>");
                    textwr.Write(MonthText(mes) + " - " + (a));
                    textwr.Write("  </div>");
                    textwr.Write("</td>");
                }
            }
                      
            textwr.Write("<td><div style='width:16px;height:22px;' class='BkgHeader' ></div></td>");
            textwr.Write("</tr>");

            textwr.Write("<tr>");

           intMesIni = 1;
           intMesFin = 1;
           
           for (int a = SCFechaInicio.Year; a <= SCFechaFin.Year; a++)
           {
              if (a == SCFechaInicio.Year)
                 intMesIni = SCFechaInicio.Month;
              else
                 intMesIni = 1;

              if (a == SCFechaFin.Year)
                 intMesFin = SCFechaFin.Month;
              else
                 intMesFin = 12;


              for (int mes = intMesIni; mes <= intMesFin; mes++)
              {
                 for (int dia = 1; dia <= DateTime.DaysInMonth(a, mes); dia++)
                    {
                        textwr.Write("<td>");
                        textwr.Write("<div class='BkgHeader ScDay'>");
                        textwr.Write(dia.ToString());
                        textwr.Write("</div>");
                        textwr.Write("</td>");
                    }
                }

            }

            textwr.Write("<td><div class='BkgHeader Sc16x16'></div></td>");
            textwr.Write("</tr>");
            textwr.Write("<tr>");

            intMesIni = 1;
            intMesFin = 1;

            for(int a = SCFechaInicio.Year; a <= SCFechaFin.Year; a++)
            {
               if (a == SCFechaInicio.Year)
                  intMesIni = SCFechaInicio.Month;
               else
                  intMesIni = 1;

               if (a == SCFechaFin.Year)
                  intMesFin = SCFechaFin.Month;
               else
                  intMesFin = 12;


               for (int mes = intMesIni; mes <= intMesFin; mes++)
               {
                  for (int dia = 1; dia <= DateTime.DaysInMonth(a, mes); dia++)
                    {
                        CultureInfo ci = new CultureInfo("Es-PE");
                        DateTime dtm = new DateTime(a, mes, dia);
                        textwr.Write("<td>");
                        textwr.Write("<div class='BkgHeader ScDay'>");
                        textwr.Write(ci.DateTimeFormat.GetDayName(dtm.DayOfWeek).ToUpper().Substring(0, 1));
                        textwr.Write("</div>");
                        textwr.Write("</td>");
                    }
                }

            }

            textwr.Write("<td><div class='BkgHeader Sc16x16' ></div></td>");
            textwr.Write("</tr>");
            textwr.Write("</table>");
            textwr.Write("</div>");
            /*END HEADER*/
            #endregion
            #region body
            /*BODY*/
            if (strwitdh != "")
               textwr.Write("<div id='Body' class='ScDivLeftBody' onscroll=\"document.getElementById('Header').scrollLeft = document.getElementById('Body').scrollLeft;document.getElementById('List').scrollTop = document.getElementById('Body').scrollTop;\" style='max-height:" + (int.Parse(strheight.Replace("px", "")) - 58).ToString() + "px;' >");
            else
               textwr.Write("<div id='Body' class='ScDivLeftBody' onscroll=\"document.getElementById('Header').scrollLeft = document.getElementById('Body').scrollLeft;document.getElementById('List').scrollTop = document.getElementById('Body').scrollTop;\" >");

            textwr.Write("<div class=\"dT\">");

            if (SCDataList != null)
            {

               //string textwrBody = "";
               StringBuilder sb = new StringBuilder();

               foreach (DataRow dr in SCDataList.Rows)
               {
                  sb.AppendLine("<div class=\"dTr\">");

                  intMesIni = 1;
                  intMesFin = 1;

                  int intDayIni = 1;
                  int intDayFin = 1;

                  for (int a = SCFechaInicio.Year; a <= SCFechaFin.Year; a++)
                  {
                     if (a == SCFechaInicio.Year)
                        intMesIni = SCFechaInicio.Month;
                     else
                        intMesIni = 1;

                     if (a == SCFechaFin.Year)
                        intMesFin = SCFechaFin.Month;
                     else
                        intMesFin = 12;

                     for (int mes = intMesIni; mes <= intMesFin; mes++)
                     {
                        string bgkColor = "";
                        if ((mes % 2) == 0)
                        {
                           bgkColor = "dTd";
                        }
                        else
                        {
                           bgkColor = "dTdA";
                        }

                        if (a == SCFechaInicio.Year)
                           if (mes == intMesIni)
                              intDayIni = SCFechaInicio.Day;
                           else
                              intDayIni = 1;
                        else
                           intDayIni = 1;

                        if (a == SCFechaFin.Year)
                           if (mes == intMesFin)
                              intDayFin = SCFechaFin.Day;
                           else
                              intDayFin = DateTime.DaysInMonth(a, mes);
                        else
                           intDayFin = DateTime.DaysInMonth(a, mes);

                        if (mes == intMesIni && a == SCFechaInicio.Year)
                        {
                            if (SCFechaInicio.Day != 1)
                            {
                                sb.AppendLine("<div class=\"dTdE\"><div style=\"height: 16px;width:" + (((SCFechaInicio.Day - 1) * 16) + SCFechaInicio.Day - 2).ToString() + "px;\"></div>");
                                sb.AppendLine("</div>");
                            }
                        }

                        for (int dia = intDayIni; dia <= intDayFin; dia++)
                        {
                           sb.AppendLine("<div class=\"" + bgkColor + "\"><div class=\"Sc16x16\" id=\"" + int.Parse(dr[SCListItemValue].ToString()).ToString() + a.ToString().Remove(0, 2) + mes + dia.ToString("00") + "\"></div>");
                           sb.AppendLine("</div>");
                        }

                        if (mes == intMesFin && a == SCFechaFin.Year)
                        {
                            if (DateTime.DaysInMonth(a, mes) != SCFechaFin.Day)
                            {
                                sb.AppendLine("<div class=\"dTdE\"><div style=\"height: 16px;width:" + (((DateTime.DaysInMonth(a, mes) - SCFechaFin.Day) * 17) - 1) + "px;\"></div>");
                                sb.AppendLine("</div>");
                            }
                        }

                     }

                  }

                  sb.AppendLine("</div>");
               }


               foreach (DataRow drData in SCDataSchuleder.Rows)
               {
                  if (drData[SCDataStAnulaLog].ToString() == "0")
                  {
                     DateTime DateIni = DateTime.Parse(drData[SCDataFeIni].ToString());
                     DateTime DateFin = DateTime.Parse(drData[SCDataFeFin].ToString());
                     TimeSpan DateVar = DateFin - DateIni;
                     sb.Replace("id=\"" + int.Parse(drData[SCListItemValue].ToString()).ToString() + DateIni.Year.ToString().Remove(0, 2) + DateIni.Month + DateIni.Day.ToString("00") + "\">", "><div title=\"" + (DateVar.Days + 1).ToString() + " Dias\" class=\"ScBaEs\" style=\"width:" + (((DateVar.Days + 1) * 16) + DateVar.Days - 1).ToString() + "px;\" onClick='ShowPopupScheluder(\"" + drData[SCDataSecuen].ToString() + "\",\"" + drData[SCListItemValue].ToString() + "\",\"" + drData[SCListItemText].ToString() + "\",\"" + DateTime.Parse(drData[SCDataFeIni].ToString()).ToString("dd/MM/yyyy") + "\",\"" + DateTime.Parse(drData[SCDataFeFin].ToString()).ToString("dd/MM/yyyy") + "\",\"" + drData[SCDataStAnulaLog].ToString() + "\");'></div>");
                  }
               }

               textwr.Write(sb.ToString());
            }
            else
            {
               textwr.Write("<div style='width:100%; padding:6px;background:#FFF4BC;'>No se encontraron Datos.");
               textwr.Write("</div>");
            }
            textwr.Write("</div>");
            textwr.Write("</div>");

            #endregion
            textwr.Write("</div>");

            //string htmlResultante = textwr.ToString();
            //string htmlMin = YODA.Web.HTMLUtil.MinificarHTML(htmlResultante);
            //htmlMin = YODA.Web.HTMLUtil.MinificarHTML2(htmlMin);
            //htmlMin = YODA.Web.HTMLUtil.MinificarHTML3(htmlMin);
            writer.Write(textwr.ToString());

        }

        public string MonthText(int intmonth)
        {
            string strMonth = "";
            switch (intmonth)
            {
                case 1:
                    strMonth = "Enero"; break;
                case 2:
                    strMonth = "Febrero"; break;
                case 3:
                    strMonth = "Marzo"; break;
                case 4:
                    strMonth = "Abril"; break;
                case 5:
                    strMonth = "Mayo"; break;
                case 6:
                    strMonth = "Junio"; break;
                case 7:
                    strMonth = "Julio"; break;
                case 8:
                    strMonth = "Agosto"; break;
                case 9:
                    strMonth = "Septiembre"; break;
                case 10:
                    strMonth = "Octubre"; break;
                case 11:
                    strMonth = "Noviembre"; break;
                case 12:
                    strMonth = "Diciembre"; break;
                default:
                    strMonth = "NO FOUND"; break;
            }

            return strMonth;
        }

    }
}
