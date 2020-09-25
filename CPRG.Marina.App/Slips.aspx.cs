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
      if (!IsPostBack)
      {
        uxDocks.DataSource = mgr.GetDocks();
        uxDocks.DataTextField = "Name";
        uxDocks.DataValueField = "ID";
        uxDocks.DataBind();
        uxDocks.SelectedIndex = 0;
        uxDocks_SelectedIndexChanged(sender, e);
      }
    }

    protected void uxDocks_SelectedIndexChanged(object sender, EventArgs e)
    {
      var dock = mgr.GetSingleDock(Convert.ToInt32(uxDocks.SelectedValue));
      var slips = mgr.GetNonleasedSlipsByDock(dock.ID);

      if (dock.WaterService)
        uxWater.Text = "Available";
      else
        uxWater.Text = "Unavailable";
      if (dock.ElectricalService)
        uxElectric.Text = "Available";
      else
        uxElectric.Text = "Unavailable";
      uxSlipCount.Text = slips.Count().ToString();
      uxSlips.DataSource = slips;
      uxSlips.DataTextField = "Summary";
      uxSlips.DataValueField = "ID";
      DataBind();
    }
  }
}