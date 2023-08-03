using GestionStockHLP.Services.InventaireService;
using GestionStockHLP.Services.MagasinService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagasinController : ControllerBase
    {
        private readonly IMagasinService _context;

        public MagasinController(IMagasinService context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetMagasin()
        {
            var result = _context.GetMagasins();
            return Ok(result);

        }
    }
}
