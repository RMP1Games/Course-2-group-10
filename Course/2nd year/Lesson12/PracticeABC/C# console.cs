using System;
public class Program
{
    class Product
    {
        public string name;
        public int price;
        public string description;
    }
    class CategoryAndProducts
    {
        public string Category;
        public string[] Products;
    }

    class Order
    {
        public int id;
        public string[] items;
        public int total; 
    }

    class User
    {
        public string name;
        public string email;
        public int purchases;
    }
    
    class Cart
    {
        public string cart;
    }

    class Shipping
    {
        public string method;
        public int price;
        public int estimated_days;
    }

    class Payment
    {
        public string method;
        public string status;
    }

    class Reviews
    {
        public string product;
        public int rating;
        public string comment;
    }

    class Discounts
    {
        public string product;
        public string discount;
    }
    
    class Addresses
    {
        public string type;
        public string address;
    }
}
