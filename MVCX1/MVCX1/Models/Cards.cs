using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MVCX1.Models
{
    public class Cards : GetScore
    {
        //List<Players> _player;
        //数据库连接池
        private readonly PlayDB _context;

        public Cards(PlayDB context)
        {
            //模拟数据库数据，将实例数据存储在内存中
            //_player = new List<Players>
            //{
            //    new Players{Name = "Messi",Shoot = 99,Passing = 97,Dribble = 99,Defence = 50 },
            //    new Players{Name = "XAVI",Shoot = 90,Passing = 99,Dribble = 96,Defence = 90 },
            //    new Players{Name = "Iniesta",Shoot = 95,Passing = 98,Dribble = 98,Defence = 80 },
            //};
            _context = context;

            //var db = new PlayDB();
            //_player = 
            
        }

        public Players AddPl(Players player)
        {
            //_player.Add(player);
            _context.UserX.Add(player);
            _context.SaveChangesAsync();
            return player;
        }

        public IEnumerable<Players> getAllPlayers()
        {
            //IEnumerable<Players> allBarca = _player;
            //return allBarca;
            return _context.UserX;
        }

        public Players getCard(string name)
        {
            //return _player.FirstOrDefault(names => names.Name == name);
            return _context.UserX.Find(name);
             
        }
    }
}
