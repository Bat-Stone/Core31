using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCX1.Models
{
    public interface GetScore
    {
        Players getCard(string name);

        IEnumerable<Players> getAllPlayers();

        Players AddPl(Players player);
    }
}
