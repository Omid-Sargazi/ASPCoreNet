using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using SystemTextJson.models;

var product = new {
    Id=1,
    Name="Laptop",
    Price=120m
};

string json= JsonSerializer.Serialize(product);

Console.WriteLine(json);


//Basic Deserialization

string json2 = "{\"Id\":1,\"Name\":\"Laptop\",\"Price\":1200.99}";
var product2 = JsonSerializer.Deserialize<Product>(json2);

Console.WriteLine(product2.Name);
////////////////////////////////////////

var options = new JsonSerializerOptions {WriteIndented =true};
string json03 = JsonSerializer.Serialize(product2,options);

Console.WriteLine(json03);



