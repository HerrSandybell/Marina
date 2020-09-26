using CPRG214.Marina.Data;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App.Controls
{
  public partial class DockSelector : System.Web.UI.UserControl
  {
    // declare event
    public event DockSelectionHandler DockSelect;
    public DockDTO Dock { get; set; }
    // Bolean property to set AutoPostBack
    public bool AllowPostBack
    {
      get { return uxDocks.AutoPostBack; }
      set { uxDocks.AutoPostBack = value; }
    }
    public string SelectedDockID
    {
      get { return uxDocks.SelectedValue; }
      set { uxDocks.SelectedValue = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        var mgr = new MarinaManager();
        uxDocks.DataSource = mgr.GetDocks();
        uxDocks.DataTextField = "Name";
        uxDocks.DataValueField = "ID";
        uxDocks.DataBind();
        uxDocks.SelectedIndex = 0;
        uxDocks_SelectedIndexChanged(this, e);
      }
    }

    protected void uxDocks_SelectedIndexChanged(object sender, EventArgs e)
    {
      // event fires
      if (DockSelect != null)
      {
        // get id from list
        var dockID = Convert.ToInt32(uxDocks.SelectedValue);

        // call manager
        var mgr = new MarinaManager();
        // get course object
        var dock = mgr.GetSingleDock(dockID);
        Dock = dock;

        // instantiate event args
        var arg = new DockEventArgs
        {
          ID = dock.ID,
          eService = dock.ElectricalService,
          wService = dock.WaterService
        };

        // pass args to event and invoke
        DockSelect.Invoke(this, arg);
      }
    }

    internal class SelectedValue
    {
    }
  }
}