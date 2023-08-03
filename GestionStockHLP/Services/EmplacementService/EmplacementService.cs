using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionStockHLP.Services.EmplacementService
{
    public class EmplacementService : IEmplacementService
    {
        public Magasin Findmagasin(int id)
        {
            var db = new GestionStockDbContext();
            var emplacement = db.Emplacements.FirstOrDefault(x => x.IdMagasin == id);
            if (emplacement == null)
            {
                return null;
            }

            var magasin = db.Magasins.FirstOrDefault(x => x.IdMagasin == emplacement.IdMagasin);
            return magasin;
        }


        public List<Emplacement> Getallemplacement()
        {
            var db = new GestionStockDbContext();
            return db.Emplacements.ToList();
        }
    }
}
