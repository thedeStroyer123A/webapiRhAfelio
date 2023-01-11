using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class Training_SectionController : ControllerBase
    {
        private readonly ITraining_SectionService _training_service;

        public Training_SectionController(ITraining_SectionService training_section)
        {
            _training_service = training_section;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_training_service.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_training_service.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Training_Section_C training)
        {
            return Ok(_training_service.Insert(training.ClienttoTrainingSecBL()));
        }
        
        [HttpPut]
        public IActionResult Update(Training_Section_C training)
        {
            return Ok(_training_service.Update(training.ClienttoTrainingSecBL()));
        }

        
    }
}
