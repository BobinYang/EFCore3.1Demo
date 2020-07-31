using Demo.Data;
using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Demo.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var context = new ContextDemo();//C#8语法，当前方法结束后释放资源

            //添加一条数据
            var league1 = new League
            {
                Name = "LeagueA"
            };
            context.Leagues.Add(league1);

            var count = context.SaveChanges();//返回修改的记录数

            var a = "e";
            var league = context.Leagues.AsNoTracking().First();
            foreach (var item in context.Leagues
                 .Where(x => x.Country.Contains(a)))
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(count);
        }
    }
}