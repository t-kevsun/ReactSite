#r "Newtonsoft.Json"
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;
using Newtonsoft.Json;


public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    Product data1 = new Product(); // just a sample object
    data1.id = 10;
    data1.name = "Kevin";
    data1.description = "testfunction.scm.tkevsunstamp.antares-test.windows-int.net (Managed, RUN_FROM_PACKAGE)";
    data1.quantity = 1;

    Product data2 = new Product(); // just a sample object
    data2.id = 20;
    data2.name = "Navy";
    data2.description = "testfunction.scm.tkevsunstamp.antares-test.windows-int.net (Managed, RUN_FROM_PACKAGE)";
    data2.quantity = 1;

    Product data3 = new Product(); // just a sample object
    data3.id = 30;
    data3.name = "Ruslan";
    data3.description = "testfunction.scm.tkevsunstamp.antares-test.windows-int.net (Managed, RUN_FROM_PACKAGE)";
    data3.quantity = 1;

    var arr = new Product[] { data1, data2, data3 };
 
    var json = JsonConvert.SerializeObject(arr, Formatting.Indented);
     
    var responseMessage = new HttpResponseMessage(HttpStatusCode.OK)
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json")
    };
    
    return new OkObjectResult(json);
}
 
public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int quantity { get; set; }
}

