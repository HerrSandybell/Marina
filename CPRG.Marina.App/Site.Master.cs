﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App
{
  public partial class SiteMaster : MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Context.User.Identity.IsAuthenticated)
      {
        uxWelcome.InnerText = $"Welcome {Context.User.Identity.Name}";
        //uxLogin.InnerHtml = "<span class='fa fa-sign-out-alt'>";
      }
      else
      {
        uxWelcome.InnerText = string.Empty;
        //uxLogin.InnerHtml = "<span class='fa fa-sign-in-alt'>";
      }
    }
  }
}