namespace PracticeA;

using PracticeB;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

[ApiController]
public class StoreController : ControllerBase
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }

    private static readonly List<Product> Items = new List<Product>();
    private static readonly List<User> Users = new List<User>();

    [HttpPost]
    [Route("/store/updateprice")]
    public IActionResult UpdatePrice(string name, double newPrice)
    {
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            product.Price = newPrice;
            return Ok($"{name} обновлен с новой ценой: {newPrice}");
        }
        else
        {
            return NotFound($"Продукт {name} не найден");
        }
    }

    [HttpPost]
    [Route("/store/updatename")]
    public IActionResult UpdateName(string currentName, string newName)
    {
        var product = Items.FirstOrDefault(p => p.Name == currentName);
        if (product != null)
        {
            product.Name = newName;
            return Ok($"Имя продукта изменено с {currentName} на {newName}");
        }
        else
        {
            return NotFound($"Продукт {currentName} не найден");
        }
    }


    [HttpGet]
    [Route("/store/outofstock")]
    public IActionResult OutOfStock()
    {
        var outOfStockItems = Items.Where(p => p.Stock == 0).ToList();
        if (outOfStockItems.Any())
        {
            return Ok(outOfStockItems);
        }
        else
        {
            return Ok("Все продукты в наличии");
        }
    }






    [HttpPost]
    [Route("/store/add")]
    public IActionResult Add(string name, double price, int stock)
    {
        var product = new Product(name, price, stock);
        Items.Add(product);
        return Ok(Items);
    }


    [HttpPost]
    [Route("/store/delete")]
    public IActionResult Delete(string name)
    {
        var product = Items.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            Items.Remove(product);
            return Ok($"{name} удален");
        }
        else
        {
            return NotFound($"{name} не найден");
        }
    }


    [HttpGet]
    [Route("/store/show")]
    public IActionResult Show()
    {
        return Ok(Items);
    }

    //Практика B.Добавление пользователя
    [HttpPost]
    [Route("/store/addUser")]
    public IActionResult AddUser(string name, string password)
    {
        var newuser = new User(name, password);
        Users.Add(newuser);
        return Ok(Users);
    }

    //Практика B.Аунтефикатор
    [HttpPost]
    [Route("/store/auth")]
    public IActionResult Auth(string name, string password)
    {
        User user = Users.FirstOrDefault(p => p.Name == name);
        if (user != null)
        {
            if (user.Name == name)
            {
                if (user.Password == password)
                return Ok($"User {user.Name} is authorized.");
                else
                return NotFound($"User {name} authorized, but you write wrong password.");
            }
            else
            return NotFound($"User {name} not found");
        }
        else
        return NotFound($"User {name} not found");
    }
}