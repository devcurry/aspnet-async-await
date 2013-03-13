using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    CustomersProxy.CustomersServiceClient clientCustomers = new CustomersProxy.CustomersServiceClient();
    OrdersProxy.OrdersServiceClient clientOrders = new OrdersProxy.OrdersServiceClient();
    ProductsProxy.ProductsServiceClient clientProducts = new ProductsProxy.ProductsServiceClient();
    protected async void Page_Load(object sender, EventArgs e)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        
        var customerResult = clientCustomers.FetchAllCustomersAsync();
        var ordersCount = clientOrders.TotalOrdersAsync();
        var productsCount = clientProducts.TotalProductsAsync();
        await Task.WhenAll(customerResult, ordersCount, productsCount);
        sw.Stop();
        long executionTime=sw.ElapsedMilliseconds;
        Repeater1.DataSource = customerResult.Result;
        Repeater1.DataBind();
        lblTotalOrders.Text = ordersCount.Result.ToString();
        lblTotalProducts.Text = productsCount.Result.ToString();
        lblTotalExecutionTime.Text = executionTime.ToString();
    }
}