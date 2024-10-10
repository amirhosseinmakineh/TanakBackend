using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TanakBackend_ApplicationsService.Contract.IServices;

namespace Tanak_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;

        public CategoryController(ICategoryService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll(int? parentId)
        {
            var result = service.GetAll(parentId);
            return Ok(result);
        }
    }
}
