using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Affectation_MaterialController : ControllerBase
    {
        private readonly IAffectation_MaterialService _affectation_materialservice;
        public Affectation_MaterialController(IAffectation_MaterialService affectation_materialservice)
        {
            _affectation_materialservice = affectation_materialservice;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_affectation_materialservice.Get(id));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_affectation_materialservice.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Affectation_Material_C affectationmaterial)
        {
            return Ok(_affectation_materialservice.Insert(affectationmaterial.ClientToMaterialBL()));

        }
        [HttpPut]
        public IActionResult Update(Affectation_Material_C affectationmaterial)
        {
            return Ok(_affectation_materialservice.Update(affectationmaterial.ClientToMaterialBL()));
        }


    }   
}
