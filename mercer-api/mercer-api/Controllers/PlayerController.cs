using mercer_api.DAL.Repositories;
using mercer_api.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace mercer_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : BaseController<Player, PlayerRepository>
    {
        public PlayerController(PlayerRepository repo) : base(repo)
        {
        }
    }
}
