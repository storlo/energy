using Microsoft.AspNetCore.Mvc;
using Model;

namespace EnergyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnergyController : ControllerBase
    {
        private readonly ILogger<EnergyController> _logger;

        public EnergyController(ILogger<EnergyController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTransfomers")]
        public ActionResult<IEnumerable<Transformer>> GetTransfomers()
        {
            return Ok(new List<Transformer>());
        }
    }
}