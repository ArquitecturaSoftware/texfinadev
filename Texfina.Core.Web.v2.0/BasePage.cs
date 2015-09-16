using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Reflection;
using System.IO;
using System.Globalization;
using System.Threading;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Collections;
using System.Net.Mail;

/// <summary>
/// Chio, esto te servirá para que realices los callbacks. No lo modifiques, 
/// a menos que quieras agregar algo nuevo.
/// </summary>

namespace Texfina.Core.Web
{
  public class BasePage : Page, ICallbackEventHandler
  {
    private String m_ViewStateID;
    private Boolean m_sendViewStateOnCallBack = true;
    private List<string> _ResultCallback = new List<string>();

   

    protected override void OnInit(EventArgs e)
    {    
      base.OnInit(e);


      String mScript = ClientScript.GetCallbackEventReference("", "", "", "", "", false);
      if (this.EnableViewState && this.SendViewStateOnCallBack)
      {
        ClientScript.RegisterHiddenField("__VIEWSTATEID", this.ViewStateID);
      }
      else
      {
        ClientScript.RegisterHiddenField("__VIEWSTATEID", "");
      }

      if (this.Page.IsCallback)
      {
        if (System.Web.HttpContext.Current.Request.Form["__FORMCALLBACK"] == "")
        {
          try
          {
            this.Controls.Clear();
          }
          catch
          {
            throw;
          }
        }
      }

    }
  
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
    }
    public Boolean SendViewStateOnCallBack { get { return m_sendViewStateOnCallBack; } set { m_sendViewStateOnCallBack = value; } }
    public String ViewStateID
    {
      get
      {
        if (this.EnableViewState)
        {
          m_ViewStateID = "__VSTATE";
        }
        else
        {
          m_ViewStateID = "__VIEWSTATE";
        }
        return m_ViewStateID;
      }
    }
    public string GetCallbackResult()
    {
      String mReturnValue = "";
      mReturnValue = String.Join(":::", _ResultCallback.ToArray());
      return mReturnValue;
    }
    public void RaiseCallbackEvent(string eventArgument)
    {
      String[] mArguments = eventArgument.Split(new char[] { '|' });
      MethodInfo mMethodInfo;
      String[] mParameters;

      if (mArguments.Length > 1)
      {
        if (mArguments[1] == "")
        {
          mParameters = null;
        }
        else
        {
          mParameters = mArguments[1].Split(new char[] { ':' });

          for (int i = 0; i < mParameters.Length - 1; i++)
          {
            mParameters[i] = HttpUtility.UrlDecode(mParameters[i]);
          }
        }
      }
      else
      {
        mParameters = null;
      }

      mMethodInfo = this.GetType().GetMethod(mArguments[0]);
      try
      {
        mMethodInfo.Invoke(this, mParameters);
      }
      catch (Exception)
      {
        throw;
      }
    }

   
    public void AddCallbackValue(String value)
    {
      if (IsCallback)
      {
        _ResultCallback.Add(value);
      }
    }
    public void AddCallbackControl(Control control)
    {
      if (IsCallback)
      {
        _ResultCallback.Add(GetHtmlControl(control));
      }
    }
    public void RemoveCallBackValueAt(Int32 index)
    {
      _ResultCallback.RemoveAt(index);
    }
    public void ClearCallBackValues(Int32 index)
    {
      _ResultCallback.Clear();
    }

    public static string GetHtmlControl(Control Control)
    {
      string output = "";
      if (Control == null) return output;
      using (StringWriter swControl = new StringWriter())
      {
        using (HtmlTextWriter htwControl = new HtmlTextWriter(swControl))
        {
          Control.RenderControl(htwControl);
        }
        output = swControl.ToString();
      }
      return output;
    }


    public FormEditAction FormEditAction
    {
        get { return (FormEditAction)this.ViewState["_formEditAc"]; }
        set { this.ViewState["_formEditAc"] = value; }
    }

  }
}
