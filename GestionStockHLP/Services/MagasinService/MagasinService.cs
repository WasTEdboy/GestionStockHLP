using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Services.MagasinService
{
    public class MagasinService : IMagasinService
    {
        public List<Magasin> GetMagasins()
        {

            var db = new GestionStockDbContext();
            return db.Magasins.ToList();
        }
    }
}
