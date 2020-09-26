using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void uxAuthenticate_Click(object sender, EventArgs e)
    {
      var customer = CustomersManager.Authenticate(uxFirstname.Text, uxLastName.Text);
      if (customer == null)
      {
        uxMessage.Text = "Customer not present";
        uxFirstname.Text = string.Empty;
        uxLastName.Text = string.Empty;
        uxFirstname.Focus();
        return;
      }

      // Add customer ID to session
      Session.Add("CustomerID", customer.ID);

      // instatiate cookie and add customer ID to cookie
      HttpCookie cookieCustID = new HttpCookie("CustomerID");
      cookieCustID.Value = Convert.ToString(customer.ID);
      cookieCustID.Expires = DateTime.Now.AddMonths(1); // cookie expires after 1 month
      Response.Cookies.Add(cookieCustID);

      FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
    }
  }
}