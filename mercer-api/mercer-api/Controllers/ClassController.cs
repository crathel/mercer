using System;
using mercer_api.DAL;
using mercer_api.DAL.Models;
namespace mercer_api.Controllers
{
    public class ClassController : BaseController<Class, ClassRepository>
    {
        public ClassController(ClassRepository repo) : base(repo)
        {
        }
    }
}
