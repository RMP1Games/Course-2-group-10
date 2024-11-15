using System.Net;
using System.IO;
using System;
using System.Text.Json;
using Example;


namespace DontChange
{
    // основной класс для десериализации
    public class CoindeskResponse
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public Bpi bpi { get; set; }
    }

    // ниже второстепенные классы, объекты которых вложенны в основной CoindeskResponse (а также друг в друга)
    public class Bpi
    {
        public USD USD { get; set; }
        public GBP GBP { get; set; }
        public EUR EUR { get; set; }
    }

    public class EUR
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

    public class GBP
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }

   

    public class Time
    {
        public string updated { get; set; }
        public DateTime updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    public class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public double rate_float { get; set; }
    }
}

namespace Program1
{
class Program
{
    public static string GetBitcoinInfo (string url) // 1
    {
        WebRequest request = WebRequest.Create(url);     // создаем запрос
        WebResponse response = request.GetResponse();    // отправляем команду на получение ответа
        Stream dataStream = response.GetResponseStream();   // открываем поток для чтения (это как File.Readline только для сети)
        StreamReader streamReader = new StreamReader(dataStream); // Открываем чтение потока
        string jsonResponse = streamReader.ReadToEnd(); // получаем текст
        streamReader.Close();   // закрываем за собой чтение потока
        response.Close();   //?Закрываю запрос на получение ответа
        return jsonResponse;  // возвращаем ответ
    }

    public static string RandomFact(string url) // 2
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream a = response.GetResponseStream();
            StreamReader b = new StreamReader(a);
            string fact = b.ReadToEnd();
            a.Close();
            b.Close();
            return fact;
        }

    static void Main(string[] args)
    {
        // 1
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetBitcoinInfo(coindeskURL);  // поулчение ответа в виде json файла        
        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация                
        double bitcoinPrice = response.bpi.USD.rate_float; // получение нужной инфы
        Console.Write("Bitcoin price : " +  bitcoinPrice); // вывод
        // 2
        string RandomFactsURL = "https://catfact.ninja/fact";
        Console.WriteLine(RandomFact(RandomFactsURL));
    }
}
}