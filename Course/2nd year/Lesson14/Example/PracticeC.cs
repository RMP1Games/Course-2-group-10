using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Windows.Input;
using Classes;

namespace Classes
{
    //IPшник
    public class IP
    {
    public string ip;

    public IP(string ipp)
    {
        ip = ipp;
    }
    }
}

namespace Program
{
    class Program
    {
        //Получение IP
        public static string GetIP(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream a = response.GetResponseStream();
            StreamReader b = new StreamReader(a);
            string IP = b.ReadToEnd();
            b.Close();
            a.Close();
            return IP;
        }

        //Main
        static void Main(string[] args)//ААААА мейн крче потом доделай
        {
            Console.WriteLine("=========================");
            string IPurl = "https://api.ipify.org/?format=json";
            string jsonIP = GetIP(IPurl);
            string a = JsonSerializer.Deserialize<string>(jsonIP);
            Console.WriteLine(a);
            //IP ip = new IP(JsonSerializer.Deserialize<IP>(jsonIP));
        }
    }
}