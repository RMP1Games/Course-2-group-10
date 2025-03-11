using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PracticeABC.Server.Models.PracticeA
{
class DBtoJsonConverter
{
    public string ConvertDBtoJson(List<string> list)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(list, options);
        return json;
    }
}
}