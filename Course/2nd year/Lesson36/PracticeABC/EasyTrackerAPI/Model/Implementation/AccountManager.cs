using System.Security.Principal;
using EasyTrackerAPI.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using EasyTrackerAPI.Model.Users;
namespace EasyTrackerAPI.Model.Implementation

{
    public class AccountManager : IAccountManager
    {
        public void RegisterAccount(User account)//непонятно надо ли чтото возвращать
        {
            User newaccount = new User(account.Name);
            newaccount.ID = account.ID;
            newaccount.Name = account.Name;
            newaccount.Email = account.Email;
            newaccount.Password = account.Password;
        }
        public User GetAccount(string accountName)
        {
            if (EasyTrackerAPI.Model.Users.Any(u => u.Name == accountName))
                return (EasyTrackerAPI.Model.Users.Where(u => u.Name == accountName));
            else
                return null;
        }

        public List<User> GetAccounts()
        {
            return Users;
        }
        public bool VerifyAccount(User account)
        {
            if (EasyTrackerAPI.Model.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
            {
                User CurrentUser = account;
                Console.WriteLine("Account verified.");
                return true;
            }
            else
            {
                Console.WriteLine("Account not verified.");
                return false;
            }
        }
    }
}
