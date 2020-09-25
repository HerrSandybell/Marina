using CPRG.Marina.App.Controls;
using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App
{
  public partial class Slips : System.Web.UI.Page
  {
    readonly MarinaManager mgr = new MarinaManager();
    protected void Page_Load(object sender, EventArgs e)
    {
      DockSelector.DockSelect += DockSelector_DockSelect;
    }

    private void DockSelector_DockSelect(object sender, DockEventArgs e)
    {
      //var dock = mgr.GetSingleDock(Convert.ToInt32(DockSelector1.SelectedValue));
      if (e.wService)
        uxWater.Text = "Available";
      else
        uxWater.Text = "Unavailable";
      if (e.eService)
        uxElectric.Text = "Available";
      else
        uxElectric.Text = "Unavailable";

      var slips = mgr.GetNonleasedSlipsByDock(e.ID);
      uxSlipCount.Text = slips.Count().ToString();
      uxSlips.DataSource = slips;
      uxSlips.DataTextField = "Summary";
      uxSlips.DataValueField = "ID";
      uxSlips.DataBind();
    }
  }
}