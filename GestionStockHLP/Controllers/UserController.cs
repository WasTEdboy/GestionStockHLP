using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;
using GestionStockHLP.Services.InventaireService;
using GestionStockHLP.Services.MagasinierService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMagasinier _context;

        public UserController(IMagasinier context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = _context.GetMagasiniers();
            return Ok(result);


        }
        [HttpGet]
        [Route("getbyid")]
        public async Task<IActionResult> getbyid(int id)
        {
            var p = _context.GetMagasiniersbyid(id);
            return Ok(p);

        }
        

    }
}
