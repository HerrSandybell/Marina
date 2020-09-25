using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App
{
  public partial class AvailableSlips : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      DockSelector.DockSelect += DockSelector_DockSelect;
    }

    private void DockSelector_DockSelect(object sender, Controls.DockEventArgs e)
    {
      // When the event is fired, the object data source Selects the data, which fires
      uxSlipSource.Select();
      DataBind();
    }

    // invoking this event sets the parameter for the objectdatasource method.wwwwww
    protected void uxSlipSource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
      e.InputParameters["DockID"] = DockSelector.Dock.ID;
    }
  }
}