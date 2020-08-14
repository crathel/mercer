using System;
using mercer_api.DAL.Models;
using mercer_api.DAL.Repositories;

namespace mercer_api.Controllers
{
    public class CharacterController : BaseController<Character, CharacterRepository>
    {
        public CharacterController(CharacterRepository repo) : base (repo)
        {
        }
    }
}
