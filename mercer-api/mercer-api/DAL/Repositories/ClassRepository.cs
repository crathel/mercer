using mercer_api.DAL.Models;
namespace mercer_api.DAL.Repositories
{
    public class ClassRepository : Repository<Class, mercerdbContext>
    {
        public ClassRepository(mercerdbContext mercerdbContext) : base (mercerdbContext)
        {
        }
    }
}
