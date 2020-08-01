using System;
using mercer_api.DAL.Models;

namespace mercer_api.DAL
{
    public class PlayerRepository : Repository<Player, MercerdbContext>
    {

        public PlayerRepository(MercerdbContext mercerContext) : base(mercerContext)
        {

        }
    }
}
