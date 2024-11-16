using System.Net;
using System.IO;
using System;
using System.Text.Json;
using DontChange;
using System.Windows.Input;

namespace DontChange
{
// Основной класс для десериализации данных API Coindesk
public class CoindeskResponse
{
public Time time { get; set; }
public string disclaimer { get; set; }
public string chartName { get; set; }
public Bpi bpi { get; set; }
}

// Классы для вложенных данных
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

//2 Класс для рандомных фактов про котов
public class RandomFactAboutCats
{   
public string fact {get; set;}
public int length {get; set;}
}

//3 Класс рандомных шутеечек
public class RandomJoke
{
public string type {get; set;}
public string setup {get; set;}
public string punchline {get; set;}
public int id {get; set;}
}

//4 Класс info об университетах
public class UniversitieInfo
{
    public string name {get; set;}
    public string alpha_two_code {get; set;}
    public string domain {get; set;}
    public string stateprovince {get; set;}
    public string country {get; set;}
    public string webpage {get; set;}

}
}

namespace Program1
{
class Program
{
//1 Метод для получения информации о биткоине
public static string GetBitcoinInfo(string url)
{
WebRequest request = WebRequest.Create(url);
WebResponse response = request.GetResponse();
Stream dataStream = response.GetResponseStream();
StreamReader streamReader = new StreamReader(dataStream);
string jsonResponse = streamReader.ReadToEnd();
streamReader.Close();
response.Close();
return jsonResponse;
}

//2 Метод для получения случайного факта
public static string RandomFact(string url)
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

//3 Метод для получения случайной шутки
public static string RandomJoke(string url)
{
    WebRequest request = WebRequest.Create(url);
    WebResponse response = request.GetResponse();
    Stream a = response.GetResponseStream();
    StreamReader b = new StreamReader(a);
    string joke = b.ReadToEnd();
    a.Close();
    b.Close();
    return joke;
}

//4 Метод для получения списка университетов
public static string GetUniversities(string url)
{
WebRequest request = WebRequest.Create(url);
WebResponse response = request.GetResponse();
Stream a = response.GetResponseStream();
StreamReader b = new StreamReader(a);
string listUniversities = b.ReadToEnd();
a.Close();
b.Close();
return listUniversities;
}

// Главный метод программы
static void Main(string[] args)
{
Console.WriteLine("=========================");

//1 Получение данных о цене биткоина
string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json";
string jsonFromCoindesk = GetBitcoinInfo(coindeskURL);
CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk);
double bitcoinPrice = response.bpi.USD.rate_float;
Console.WriteLine("Bitcoin price: " + (bitcoinPrice * 100));
Console.WriteLine("=========================");

//2 Получение случайного факта
string randomFactsURL = "https://catfact.ninja/fact";
string jsonRandomFact = RandomFact(randomFactsURL);
RandomFactAboutCats newFact = JsonSerializer.Deserialize<RandomFactAboutCats>(jsonRandomFact);
Console.WriteLine($"Random fact: {newFact.fact}");
Console.WriteLine("=========================");

//3 Получение случайной шутки и её дальнейшая запись в файл
string randomJokeURL = "https://official-joke-api.appspot.com/random_joke";
string jsonRandomJoke = RandomJoke(randomJokeURL);
RandomJoke newJoke = JsonSerializer.Deserialize<RandomJoke>(jsonRandomJoke);
StreamWriter writer = new StreamWriter("Jokes.txt");
writer.WriteLine($"{newJoke.setup} {newJoke.punchline}");   //Точно не помню, как правильнее записать
writer.Close();
Console.WriteLine("Add a joke to Jokes.txt ");
Console.WriteLine("=========================");

//4 Топ3 уника
string countryURL = "http://universities.hipolabs.com/search?country=Kazakhstan";
string jsonUniversities = GetUniversities(countryURL);
List<UniversitieInfo> allUni = JsonSerializer.Deserialize<List<UniversitieInfo>>(jsonUniversities);
Console.WriteLine("TOP-3 Universities of Kazakhtan:");
Console.WriteLine($"1: {allUni[0].name}");
Console.WriteLine($"2: {allUni[1].name}");
Console.WriteLine($"3: {allUni[2].name}");
Console.WriteLine("=========================");
}
}
}