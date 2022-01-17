using Localiza_Frotas_Infra.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Localiza_Frotas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        public SingletonController(SingletonContainer singletonContainer)
        {
            SingletonContainer = singletonContainer;
        }

        public SingletonContainer SingletonContainer { get; }

        // GET api/v1/<VeiculosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return id switch
            {
                1 => Ok(SingletonContainer),
                _ => Ok(Singleton.Instance)
            };
        }
    }
}
