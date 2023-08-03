using GestionStockHLP.Repository.Models;
using GestionStockHLP.Repository;

namespace GestionStockHLP.Services.InventaireService
{
    public class InventaireService : IInventaireService
    {
        public List<Inventaire> Getallinventaire()
        {
            var db = new GestionStockDbContext();
            return db.Inventaires.ToList();
        }
    }
}
