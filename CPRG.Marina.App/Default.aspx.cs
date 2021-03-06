﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Context.User.Identity.IsAuthenticated)
      {
        uxPrimary.HRef = "/Secure/LeaseSlips";
        uxPrimary.InnerHtml = "Lease Slips!";
      }
      else
      {
        uxPrimary.HRef = "Registration";
        uxPrimary.InnerHtml = "Register Now!";
      }
    }
  }
}