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

      Session.Add("CustomerID", customer.ID);
      FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
    }
  }
}