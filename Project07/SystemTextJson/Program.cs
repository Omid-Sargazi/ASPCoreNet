using System.Text.Json;

var product = new {
    Id=1,
    Name="Laptop",
    Price=120m
};

string json= JsonSerializer.Serialize(product);

Console.WriteLine(json);