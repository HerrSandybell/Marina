using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
  public class CustomersManager
  {
    public static CustomerDTO Authenticate(string firstName, string lastName)
    {
      CustomerDTO dto = null;

      var db = new MarinaEntities();
      var cust = db.Customers
        .SingleOrDefault(c => c.FirstName == firstName && c.LastName == lastName);

      if (cust != null) // if customer is found
      {
        dto = new CustomerDTO
        {
          ID = cust.ID,
          FullName = $"{cust.FirstName} {cust.LastName}"
        };
      }

      return dto; // else return null
    }

    // find a customer based on ID.
    public static Customer Find(int id)
    {
      var db = new MarinaEntities();
      var cust = db.Customers.SingleOrDefault(c => c.ID == id);
      return cust;
    }

    // Add a newly registered customer to DB
    public static void Add(Customer cust)
    {
      var db = new MarinaEntities();
      db.Customers.Add(cust);
      db.SaveChanges();
    }

    // update customer in db.
    public static void Update(Customer cust)
    {
      var db = new MarinaEntities();
      var custFromContext = db.Customers
        .SingleOrDefault(c => c.ID == cust.ID);
      custFromContext.FirstName = cust.FirstName;
      custFromContext.LastName = cust.LastName;
      custFromContext.City = cust.City;
      custFromContext.Phone = cust.Phone;
      db.SaveChanges();
    }
  }
}
