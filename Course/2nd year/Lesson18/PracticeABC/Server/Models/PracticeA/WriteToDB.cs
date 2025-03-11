using System;
using System.IO;

namespace PracticeABC.Server.Models.PracticeA
{
class ToDBWriter
{
    public void WriteToDB(string json)
    {
        System.IO.File.WriteAllText("DataBase.json", json);
    }
}
}