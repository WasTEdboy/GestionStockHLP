using GestionStockHLP.Repository;
using GestionStockHLP.Services.InventaireService;
using GestionStockHLP.Services.MagasinierService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventaireController : ControllerBase
    {
        private readonly IInventaireService _context;

        public InventaireController(IInventaireService context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetInventaire()
        {
            var result = _context.Getallinventaire();
            return Ok(result);

        }
    }
}
