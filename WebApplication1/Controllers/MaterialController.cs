
using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Models;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialservice;

        public MaterialController(IMaterialService materialservice)
        {
            _materialservice= materialservice;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_materialservice.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_materialservice.GetAll());
        }
        
        [HttpPost]
        public IActionResult Insert(Material_C Mat)
        {
            return Ok(_materialservice.Insert(Mat.ClientToMaterialBl()));
        }

        [HttpPut]
        public IActionResult Update(Material_C Mat)
        {
            return Ok(_materialservice.Update(Mat.ClientToMaterialBl()));
        }
    }   

        
        
}
