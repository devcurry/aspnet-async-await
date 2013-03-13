using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrdersService" in code, svc and config file together.
public class OrdersService : IOrdersService
{

    public int TotalOrders()
    {
        NorthwindEntities dataContext = new NorthwindEntities();
        dataContext.Configuration.ProxyCreationEnabled = false;
        var query = from ord in dataContext.Orders
                    select ord;
        Thread.Sleep(3000);
        return query.Count();
    }
}
