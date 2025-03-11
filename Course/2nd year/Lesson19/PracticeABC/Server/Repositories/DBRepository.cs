using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.IO; 
using System.Net.Http;
using System.Text; 
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DBRepository
{
    public class product
    {
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Name { get; set; }

    [Range(0.01, 10000)]
    public double Price { get; set; }

    [Range(0, 10000)]
    public int Stock { get; set; }

        public product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    public class RepositoryDB
    {
    public List<product> ConvertTextDBToList(string json)
    {
        return JsonSerializer.Deserialize<List<product>>(json);
    }

    public string ReadDB(string _jsonFilePath)
    {
        return System.IO.File.ReadAllText(_jsonFilePath);
    }

    public bool DBExist(string _jsonFilePath)
    {
        return System.IO.File.Exists(_jsonFilePath);
    }

    public void ReadDataFromFile(string _jsonFilePath, List<product> Items)
    {
        if (DBExist(_jsonFilePath))
        { 
            Items =  ConvertTextDBToList(ReadDB(_jsonFilePath));
        }
    }

    //#endregion
 

    public string ConvertDBtoJson(List<product> Items)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        return JsonSerializer.Serialize(Items, options);
    }

    public void WriteTiDB(string _jsonFilePath, string json)
    {
        System.IO.File.WriteAllText(_jsonFilePath, json);
    }

    public void WriteDataToFile(string _jsonFilePath, List<product> Items)
    { 
        WriteTiDB(_jsonFilePath, ConvertDBtoJson(Items));
    }

    public void BackupDB(string _jsonFilePath, string _jsonBackupPath)
    {
        File.Copy(_jsonFilePath, _jsonBackupPath, true);
    }
    }
}