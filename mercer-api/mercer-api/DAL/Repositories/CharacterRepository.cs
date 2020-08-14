using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using mercer_api.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace mercer_api.DAL.Repositories
{
    public class CharacterRepository : Repository<Character, mercerdbContext>
    {
        private mercerdbContext _mercerdbContext;

        public CharacterRepository(mercerdbContext context) : base(context)
        {
            _mercerdbContext = context;
        }

        public override Task<Character> Get(int id)
        {
            return _mercerdbContext.Character
                .Include(c => c.Alignment)
                .Include(c => c.Class)
                .Include(c => c.SubClass)
                .Include(c => c.Race)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public override Task<List<Character>> GetAll()
        {
            return _mercerdbContext.Character
                .Include(c => c.Alignment)
                .Include(c => c.Class)
                .Include(c => c.SubClass)
                .Include(c => c.Race)
                .ToListAsync();
        }



    }
}
