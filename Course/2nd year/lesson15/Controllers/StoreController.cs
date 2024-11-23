using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class Product
{
    public string Name {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public Product (string name, string description, int price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}
public class StoreController : ControllerBase
{
    //"Массив" Список продуктов
    List<Product> ListOfProducts = new List<Product>();

    //Метод добавления элемента
    [HttpPost]
    [Route("store/add/")]
    public IActionResult AddToList(string ProductName, string ProductDescription, int ProductPrice)
    {
        Product NewProduct = new Product (ProductName, ProductDescription, ProductPrice);
        ListOfProducts.Add(NewProduct);
        return Ok($"Add a product to list.");
    }

    //Метод для удаления элемента
    [HttpDelete]
    [Route("store/delete/")]
    public IActionResult DeleteFromList(string ProductToDelete)
    {
        foreach (Product product in ListOfProducts)
        {
            if (product.Name == ProductToDelete)
            return Ok();
        }
        return NotFound();
    }
}