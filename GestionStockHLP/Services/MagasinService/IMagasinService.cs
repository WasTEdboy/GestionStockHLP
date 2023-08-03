using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace GestionStockHLP.Services.MagasinService
{
    public interface IMagasinService
    {
        List<Magasin> GetMagasins();
    }
}
