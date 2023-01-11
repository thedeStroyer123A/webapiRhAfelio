using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Models;
using ProjectRh_BLL.Services;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployesController :ControllerBase
    {
        private readonly IEmployesService _employés_service;

        public EmployesController(IEmployesService employes_service)
        {
            _employés_service = employes_service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employés_service.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employés_service.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Employes_C employe)
        {
            return Ok(_employés_service.Insert(employe.ClientToEmployésBL()));
        }

        [HttpPut]
        public IActionResult Update(Employes_C employe)
        {
            return Ok(_employés_service.Update(employe.ClientToEmployésBL()));
        }



    }
}
