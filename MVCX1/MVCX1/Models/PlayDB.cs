using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCX1.Models
{
    public class PlayDB:DbContext
    {
        public PlayDB(DbContextOptions<PlayDB> options) : base(options)
        {
            
        }

        public DbSet<Players> UserX { get; set; }

        //插入种子数据
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Bar();
            //modelBuilder.Entity<Players>().HasData
            //(
            //    new Players
            //    {
            //        ID = 1,
            //        Name = "Alves",
            //        Shoot = 90,
            //        Dribble = 96,
            //        Passing = 98,
            //        Defence = 99,
            //    },
            //    new Players
            //    {
            //        ID = 2,
            //        Name = "Messi",
            //        Shoot = 99,
            //        Dribble = 99,
            //        Passing = 97,
            //        Defence = 60,
            //    },
            //    new Players
            //    {
            //        ID = 3,
            //        Name = "XAVI",
            //        Shoot = 92,
            //        Dribble = 96,
            //        Passing = 99,
            //        Defence = 93,
            //    },
            //    new Players
            //    {
            //        ID = 4,
            //        Name = "Iniesta",
            //        Shoot = 99,
            //        Dribble = 98,
            //        Passing = 98,
            //        Defence = 85,
            //    }
            //);
        }
    }
}
