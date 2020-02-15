namespace Panda.Services
{
    using Panda.Data;
    using Panda.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    public class UsersService : IUsersService
    {
        private readonly PandaDbContext pandaDbContext;

        public UsersService(PandaDbContext pandaDbContext)
        {
            this.pandaDbContext = pandaDbContext;
        }

        public string CreateUser(string username, string email, string password)
        {
            var user = new User
            {
                Username = username,
                Email = email,
                Password = this.HashPassword(password)
            };

            this.pandaDbContext.Users.Add(user);
            this.pandaDbContext.SaveChanges();

            return user.Id.ToString();
        }

        public IEnumerable<string> GetUsernames()
        {
            var listOfUsernames = this.pandaDbContext.Users.Select(x => x.Username).ToList();

            return listOfUsernames;
        }

        public User GetUserOrNull(string username, string password)
        {
            var passHash = this.HashPassword(password);

            var user = this.pandaDbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == passHash);

            return user;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return Encoding.UTF8.GetString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}
