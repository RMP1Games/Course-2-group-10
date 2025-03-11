using System;

namespace PracticeABC.Server.Models.PracticeB
{
    class IsDBexist
    {
        public string DBExist(string toJson)
        {
            if (toJson == "DataBase.json")
            return "Ok";
            else
            return null;
        }
    }
}