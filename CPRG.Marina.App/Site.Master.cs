using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
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
        uxLogin.InnerHtml = "Sign Out";
        uxRegistration.InnerText = "View Profile";
        uxRegistration.HRef = "/Secure/UpdateCustomer";
        uxLeaseSlip.Attributes["class"] = "nav-link";
        uxLeaseSlip.Attributes["aria-disabled"] = "false";
      }
      else
      {
        uxWelcome.InnerText = string.Empty;
        uxLogin.InnerHtml = "Sign In";
        uxRegistration.InnerText = "Registration";
        uxRegistration.HRef = "/Registration";
        uxLeaseSlip.Attributes["class"] = "nav-link disabled";
        uxLeaseSlip.Attributes["aria-disabled"] = "true";

        // empty cookie
        HttpCookie httpcookieCustID = new HttpCookie("CustomerID");
        httpcookieCustID.Expires = DateTime.Now.AddSeconds(-1);
        Response.Cookies.Add(httpcookieCustID);
      }
    }
    protected void HandleLoginClick(object sender, EventArgs e)
    {
      //check if Context.User.Identity.IsAuthenticated (signout auth ticket, clear session, redirect)
      if (Context.User.Identity.IsAuthenticated)
      {
        FormsAuthentication.SignOut(); // removes forms authentication ticket from the browser
        Session.Clear();
        Response.Redirect("/");
      }
      else
      {
        Response.Redirect("/Login");
      }
      //Response.Write("<script>alert('Login Clicked');</script>");
    }
  }
}