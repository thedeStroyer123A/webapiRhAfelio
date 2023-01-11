using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class HumanRessourceDepController : ControllerBase
    {
        private readonly IHumanRessourceDepService _humansessourceDepservice;

        public HumanRessourceDepController(IHumanRessourceDepService humanressourceDepservice)
        {

            _humansessourceDepservice= humanressourceDepservice;
        }

        
            
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_humansessourceDepservice.Get(id));
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_humansessourceDepservice.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(HumanRessourceDep_C humanres )
        {
            return Ok(_humansessourceDepservice.Insert(humanres.ClientToHumanRBL()));

        }

        [HttpPut]
        public IActionResult Update(HumanRessourceDep_C humanres)
        {
            return Ok(_humansessourceDepservice.Update(humanres.ClientToHumanRBL()));
        }
    }
}
