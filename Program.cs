using System;
using System.Linq;
using efCode.DbContexts;
using efCode.Models;
using Microsoft.EntityFrameworkCore;

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

            using (var db = new EpgContext())
            {
                string[] epgNames = {"1055e", "130e", "192e", "50w", "6875c", "70w", "75w", "80w"};
                foreach (var epgTableName in epgNames)
                {
                    long startTime = DateTime.Now.Millisecond;
                    var sql = $"select * from epg.{epgTableName}";
                    // var epgList = db.Epgs.FromSql(sql).ToList();
                    var epgList = db.Epg
                        .FromSql(sql)
                        .GroupBy(e => new
                        {
                            e.StartTime.Date,
                            Satellite = $"{epgTableName}:{e.Frequency / 1000}:{e.ServiceId}"
                        })
                        .ToList();
                    foreach (var epg in epgList)
                    {
                        Console.WriteLine($"date:{epg.Key.Date}, satellite:{epg.Key.Satellite}");
                    }
                    long endTime = DateTime.Now.Millisecond;
                    Console.WriteLine($"{epgTableName}  持续时间：{endTime - startTime}");
                }
            }
        }
    }
}
