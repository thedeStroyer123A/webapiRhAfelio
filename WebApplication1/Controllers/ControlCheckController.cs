using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlCheckController : ControllerBase
    {
        private readonly IControlCheckService  _controlcheckservice;
        public ControlCheckController(IControlCheckService controlcheckservice)
        {
            _controlcheckservice = controlcheckservice;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_controlcheckservice.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_controlcheckservice.GetAll());   
        }

        [HttpPost]
        public IActionResult Insert(ControlCheck_C controlcheck)
        {
            return Ok(_controlcheckservice.Insert(controlcheck.ClienttoControlCheckBL()));
        }

        [HttpPut]
        public IActionResult Update(ControlCheck_C controlcheck)
        {
            return Ok(_controlcheckservice.Update(controlcheck.ClienttoControlCheckBL()));
        }
    }
}
