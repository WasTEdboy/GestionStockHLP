using GestionStockHLP.Repository.Models;
using GestionStockHLP.Services.StockService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _context;
        public StockController(IStockService stock)
        {
            _context = stock;
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<IActionResult> GetStock(string code)
        {
            var result = _context.GetStockbyid(code);
            return Ok(result);

        }
        [HttpPost]
        [Route("InsertStock")]
        public void PostStock([FromBody] Stock stock)
        {
            _context.SetStock(stock);
        }
    }
}
