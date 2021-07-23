using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// 将种子数据汇总，不用在dbcontext中添加
/// </summary>
namespace MVCX1.Models
{
    public static class SeedCollection
    {
        public static void Bar(this ModelBuilder builder)
        {
            builder.Entity<Players>().HasData
             (
                 new Players
                 {
                     ID = 1,
                     Name = "Alves",
                     Shoot = 90,
                     Dribble = 96,
                     Passing = 98,
                     Defence = 99,
                 },
                 new Players
                 {
                     ID = 2,
                     Name = "Messi",
                     Shoot = 99,
                     Dribble = 99,
                     Passing = 97,
                     Defence = 60,
                 },
                 new Players
                 {
                     ID = 3,
                     Name = "XAVI",
                     Shoot = 92,
                     Dribble = 96,
                     Passing = 99,
                     Defence = 93,
                 },
                 new Players
                 {
                     ID = 4,
                     Name = "Iniesta",
                     Shoot = 99,
                     Dribble = 98,
                     Passing = 98,
                     Defence = 85,
                 },
                 new Players
                 {
                     ID = 5,
                     Name = "Suarez",
                     Shoot = 99,
                     Dribble = 97,
                     Passing = 90,
                     Defence = 75,
                 }
             );
        }
    }
}
