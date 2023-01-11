using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Affectation_PersonnelController : ControllerBase
    {
        private readonly IAffectation_PersonnelService _affectation_PersonnelService;
        public Affectation_PersonnelController(IAffectation_PersonnelService affectation_PersonnelService)
        {
            _affectation_PersonnelService = affectation_PersonnelService;
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            return Ok(_affectation_PersonnelService.Get(id));
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_affectation_PersonnelService.GetAll());
        }

        [HttpPost]

        public IActionResult Insert(Affectation_Personnel_C aff)
        {
            return Ok(_affectation_PersonnelService.Insert(aff.ClientToAffectationEBL()));

        }

        [HttpPut]
        public IActionResult Update(Affectation_Personnel_C aff)
        {
            return Ok(_affectation_PersonnelService.Update(aff.ClientToAffectationEBL()));
            
        }

        
    }
}
