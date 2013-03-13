using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductsService" in code, svc and config file together.
public class ProductsService : IProductsService
{
    public int TotalProducts()
    {
        NorthwindEntities dataContext = new NorthwindEntities();
        dataContext.Configuration.ProxyCreationEnabled = false;
        var query = from prod in dataContext.Products
                    select prod;
        Thread.Sleep(3000);
        return query.Count();
    }
}
