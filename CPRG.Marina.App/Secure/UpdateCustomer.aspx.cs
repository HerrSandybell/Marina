﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App.Secure
{
  public partial class UpdateCustomer : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      uxRegistration.IsUpdate = true;
    }
  }
}