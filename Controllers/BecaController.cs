using Api_Becas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api_Becas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BecaController : Controller
    {
        private readonly IBecaService _service;

        public BecaController(IBecaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _service.GetById(id);
            if (data == null) return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] BecaModel beca)
        {
            var id = _service.InsertBeca(beca);
            return Ok(new { id });
        }

        [HttpPut]
        public IActionResult Update([FromBody] BecaModel beca)
        {
            _service.UpdateBeca(beca);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteBeca(id);
            return Ok();
        }
    }
}
