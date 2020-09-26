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
    // instntiate manager class as its used in multiple functions
    readonly MarinaManager mgr = new MarinaManager();
    protected void Page_Load(object sender, EventArgs e)
    {
      DockSelector.DockSelect += DockSelector_DockSelect;
      uxLeaseSource.Select();
      uxLeaseGrid.DataBind();
    }

    // When a dock is selected, populate table and slip dropdown menu
    private void DockSelector_DockSelect(object sender, DockEventArgs e)
    {
      if (e.wService)
        uxWater.Text = "Available";
      else
        uxWater.Text = "Unavailable";
      if (e.eService)
        uxElectric.Text = "Available";
      else
        uxElectric.Text = "Unavailable";

      GetAvailableSlips(e.ID);
    }

    // populate drop down menu based on dock ID
    private void GetAvailableSlips(int dockID)
    {
      var slips = mgr.GetNonleasedSlipsByDock(dockID);
      uxSlipCount.Text = slips.Count().ToString();
      uxSlips.DataSource = slips;
      uxSlips.DataTextField = "Summary";
      uxSlips.DataValueField = "ID";
      DataBind();
    }

    // get customer from custID, then set parameter of available list data source.
    protected void uxLeaseSource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
    {
      int custID;
      if (Request.Cookies["CustomerID"] != null)
        custID = Convert.ToInt32(Request.Cookies["CustomerID"].Value);
      else if (Session["customerID"] != null)
        // Get customer ID from session.
        custID = (int)Session["customerID"];
      else // display message if cookies are disabled and session custID doesn't exist.
      {
        uxMessage.Text = "Please sign in again to display leased slips.";
        return;
      }

      // find customer from ID.
      Customer cust = CustomersManager.Find(custID);

      if (cust != null) // if customer exists, set input parameter as ID
      {
        e.InputParameters["custID"] = cust.ID;
      }
      else // if customer somehow doesn't exist (how did they get past authentication?)
      {
        uxMessage.Text = "No leased slips present for this account. Lease your slip above.";
      }
    }

    // When lease is clicked, get slip and cust ID, instantiate new lease, add it to DB and refresh view.
    protected void uxLease_Click(object sender, EventArgs e)
    {
      int slipID = Convert.ToInt32(uxSlips.SelectedValue);
      int custID;
      if (Request.Cookies["CustomerID"] != null)
        custID = Convert.ToInt32(Request.Cookies["CustomerID"].Value);
      else if (Session["customerID"] != null)
        // Get customer ID from session.
        custID = (int)Session["customerID"];
      else // display message if cookies are disabled and session custID doesn't exist.
      {
        uxMessage.Text = "Something went wrong, please log out and log in again.";
        return;
      }

      // instantiate new lease and add it to DB, then bind.
      Lease newLease = new Lease
      {
        CustomerID = custID,
        SlipID = slipID
      };
      mgr.LeaseSlip(newLease);

      GetAvailableSlips(Convert.ToInt32(DockSelector.SelectedDockID));
    }
  }
}