using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgroSeller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsAppService _productsAppService;

        public ProductsController(IProductsAppService productsAppService)
        {
            _productsAppService = productsAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var result = await _productsAppService.Create();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            var result = await _productsAppService.Update();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _productsAppService.Get();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _productsAppService.GetList();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            var result = await _productsAppService.Delete();
            return Ok();
        }
    }
}
