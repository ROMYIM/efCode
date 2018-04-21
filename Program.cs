using System;
using System.Linq;
using efCode.Models;

namespace efCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new EfContext())
            {
                var user = new User("sam", Gender.MALE, DateTime.Now);
                db.User.Add(user);
                db.SaveChanges();
                var userList = db.User.ToList();
                foreach (var item in userList)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}
