using GestionStockHLP.Repository.Models;
using GestionStockHLP.Services.EmplacementService;
using GestionStockHLP.Services.InventaireService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmplacementController : ControllerBase
    {
        private readonly IEmplacementService _context;

        public EmplacementController(IEmplacementService context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmplacement()
        {
            var result = _context.Getallemplacement();
            return Ok(result);


        }
        [HttpGet]
        [Route("findmagbyemplacement")]
        public Magasin GetMagasin(int id)
        {
            var result = _context.Findmagasin(id);
            return result;

        } 
    }
}
