using System.Text;
using System.Text.Json;

namespace Client;

class Program
{
    static void Main(string[] args)
    {
        var url = "http://localhost:5087/store/auth";
        var account = new
        {
            User = "admin",
            Password = "12345"
        };

        HttpClient Client = new HttpClient();

        string json = JsonSerializer.Serialize(account);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = Client.PostAsync(url, content).Result;

        //Я потратил немало времени в попытках понять, как мне сравнивать данные от клиента с данными от сервера.
        //к сожалению, я не понял, так что написал работающие функции на добавление аккаунта и проверку на авторизацию
        if(response.IsSuccessStatusCode)
        {
            Console.WriteLine("Succesful. You are authorized.");
            //IsAuthorized = true; //Почему-то не видит (The name IsAuthoried does not exist in the current context)
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            //IsAuthorized = false; //Почему-то не видит (The name IsAuthoried does not exist in the current context)
        }
    }
}
