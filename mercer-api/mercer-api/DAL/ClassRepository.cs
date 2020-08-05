using System;
using mercer_api.DAL.Models;
namespace mercer_api.DAL
{
    public class ClassRepository : Repository<Class, mercerdbContext>
    {
        public ClassRepository(mercerdbContext mercerdbContext) : base (mercerdbContext)
        {
        }
    }
}
