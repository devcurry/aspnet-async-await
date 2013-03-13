using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomersService" in code, svc and config file together.
public class CustomersService : ICustomersService
{

    public List<Customer> FetchAllCustomers()
    {
        NorthwindEntities dataContext = new NorthwindEntities();
        dataContext.Configuration.ProxyCreationEnabled = false;
        var query = from cust in dataContext.Customers
                    select cust;
        Thread.Sleep(3000);
        return query.ToList();
    }
}
