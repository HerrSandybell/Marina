using CPRG214.Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG.Marina.App.Controls
{
  public partial class Registration1 : System.Web.UI.UserControl
  {
    public bool IsUpdate { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
      if (IsUpdate)
      {
        if (Session["CustomerID"] != null)
        {
          var id = Convert.ToInt32(Session["CustomerID"]);

          var cust = CustomersManager.Find(id);

          if (cust != null)
          {
            uxFirstName.Text = cust.FirstName;
            uxLastName.Text = cust.LastName;
            uxCity.Text = cust.City;
            uxPhone.Text = cust.Phone;
          }
        }
      }
    }

    protected void uxSubmit_Click(object sender, EventArgs e)
    {
      if (IsUpdate)
      {
        if (Session["StudentID"] != null)
        {
          var id = Convert.ToInt32(Session["StudentID"]);
          var cust = CustomersManager.Find(id);
          cust.FirstName = uxFirstName.Text;
          cust.LastName = uxLastName.Text;
          cust.City = uxCity.Text;
          cust.Phone = uxPhone.Text;

          CustomersManager.Update(cust);
          FormsAuthentication.SignOut();
          Session.Clear();
          Response.Redirect("/Login");
        }
      }
      else
      {
        var cust = new Customer
        {
          FirstName = uxFirstName.Text,
          LastName = uxLastName.Text,
          City = uxCity.Text,
          Phone = uxPhone.Text
        };
        CustomersManager.Add(cust);
        Response.Redirect("/Login");
      }
    }
  }
}