using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmailxID
{
    public int id {get; set;}
    public string name {get; set;}
    public string email {get; set;}
    public bool isVerified {get; set;}
}

public class Pokupki
{
    public string orderId {get; set;}
    public string customerName {get; set;}
    public int totalPrice {get; set;}
    public string[] items {get; set;}
}

class Program
{
    static void Main()
    {
        string firstJson = File.ReadAllText("1.json");
        string secondJson = File.ReadAllText("2.json");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true, // Игнорировать регистр
            WriteIndented = true, // Читаемая структура JSON
        };

        EmailxID textJson = JsonSerializer.Deserialize<EmailxID> (firstJson, options);
        Console.WriteLine($"ID и Email пользователя Иванов Иван: {textJson.id} | {textJson.email}");

        Console.WriteLine($"==========================================================");

        Pokupki spisok = JsonSerializer.Deserialize<Pokupki> (secondJson, options);
        Console.WriteLine($"Список товаров пользователя {spisok.customerName} (ID заказа:{spisok.orderId}):");
        foreach (var item in spisok.items)
        Console.WriteLine(item);

        Console.WriteLine($"==========================================================");

    }
}