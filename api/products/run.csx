#r "Newtonsoft.Json"
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;
using Newtonsoft.Json;


public static async Task<IActionResult> Run(HttpRequest req, ILogger log)
{
    Product data = new Product(); // just a sample object
    data.id = 10;
    data.name = "Apples";
    data.description = "Delicious gala apples";
    data.quantity = 36;

    Product data2 = new Product(); // just a sample object
    data.id = 10;
    data.name = "Oranges";
    data.description = "Blood oranges";
    data.quantity = 10;

    var arr = new Product[] { data, data2 };
 
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

