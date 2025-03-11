using System;

namespace PracticeABC.Server.Models.PracticeB
{
    class TextDBToListConverter
    {
        public string ConvertTextDBToList(string result, string toJson)
        {
            if (result == "Ok")
            {
            string json = System.IO.File.ReadAllText(toJson);
            return json;
            }
            else
            return null;
        }
    }
}