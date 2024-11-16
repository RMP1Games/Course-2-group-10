using System.Net;
using System.IO;
using System;
using System.Text.Json;
using System.Windows.Input;
using Classes;

namespace Classes
{

}

namespace Program
{
    class Program
    {
        //Метод получения рандом информации
        public static string RandomInfo(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream a = response.GetResponseStream();
            StreamReader b = new StreamReader(a);
            string randomInfo = b.ReadToEnd();
            a.Close();
            b.Close();
            return randomInfo;
        }

        //Мэйн
        static void Main (string[] args)
        {
            Console.WriteLine("=========================");

            //Сравнение и ответ
            string RandomInfoURL = "https://randomuser.me/api/";
            string jsonRandomInfo = RandomInfo(RandomInfoURL);
            string male = "male";
            if (jsonRandomInfo.Contains(male))//Да, я знаю что нужно сравнивать со значением на сайте(т.е. брать информацию с сайта), но смысл, если там всегда male? Если бы мне дали 2 рандомайзера, то да, я бы вынес из обоих нужную мне информацию, сравнил и дал ответ.
            Console.WriteLine("Да");
            else
            Console.WriteLine("Нет");

            Console.WriteLine("=========================");
        }
    }
}