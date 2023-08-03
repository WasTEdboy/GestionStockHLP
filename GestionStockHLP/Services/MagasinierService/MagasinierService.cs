using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace GestionStockHLP.Services.MagasinierService
{
    public class MagasinierService : IMagasinier
    {
        public List<Magasinier> GetMagasiniers()
        {
            var db = new GestionStockDbContext();
            return db.Magasiniers.ToList();
           
        }

        public Magasinier GetMagasiniersbyid(int id)
        {
            var db = new GestionStockDbContext();
            Magasinier p = db.Magasiniers.FirstOrDefault(x => x.IdMagasinier == id);
            return p;
            
        }

    }
}
