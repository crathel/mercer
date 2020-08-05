using System;
using System.Threading.Tasks;
using mercer_api.DAL.Models;

namespace mercer_api.DAL
{
    public class PlayerRepository : Repository<Player, mercerdbContext>
    {

        public PlayerRepository(mercerdbContext mercerContext) : base(mercerContext)
        {

        }

        public override Task<Player> Add(Player entity)
        {
            entity.Created = DateTime.Now;
            return base.Add(entity);
        }
    }
}
