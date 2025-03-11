using System;
using System.Data.SQLite; 
using System.Collections.Generic; 


namespace PracticeABC;

public interface IProductRepository
{
    //private readonly string _connectionString;
    public List<Product> GetAllProducts(string _connectionString)
    {
        List<Product> products = new List<Product>();
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Products";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"])); 
                        products.Add(product);
                    }
                }
            }
        }
        return products;
    }


    public Product GetProductByName(string name, string _connectionString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Products WHERE Name = @Name";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        Product product = new Product(reader["Name"].ToString(),Convert.ToDouble(reader["Price"]),Convert.ToInt32(reader["Stock"]));
                        return  product;
                    }
                    return null;
                }
            }
        }
    }


    public void AddProduct(Product product, string _connectionString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock)";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.ExecuteNonQuery();
            }
        }
    }


    public void UpdateProduct(Product product, string _connectionString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "UPDATE Products SET Price = @Price, Stock = @Stock WHERE Name = @Name";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteProduct(string name, string _connectionString)
    {
        using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string query = "DELETE FROM Products WHERE Name = @Name";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }
    }
}
