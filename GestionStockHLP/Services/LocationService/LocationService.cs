using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Services.LocationService
{
    public class LocationService : ILocationService
    {
        public Location GetLocations(int id)
        {
            var db = new GestionStockDbContext();
            Location l = db.Locations.FirstOrDefault(x => x.LocationId == id);
            return l;
        }

        public void setLocation(Locationfinder location)
        {
            Stock stock;
            var db = new GestionStockDbContext();
            if (db.Stocks.FirstOrDefault(x => x.Us == location.Us) != null)
            {
                stock = db.Stocks.FirstOrDefault(s => s.Us == location.Us);
            }
            else if (db.Stocks.FirstOrDefault(x => x.CodeArticle == location.CodeArticle) != null)
            {
                stock = db.Stocks.FirstOrDefault(s => s.CodeArticle == location.CodeArticle);
            }
            else
            {
                throw new Exception("invalid values");
            }
            
            var magasinier = db.Magasiniers.FirstOrDefault(m => m.MatMagasinier == location.MatMagasinier);
            var emplacement = db.Emplacements.FirstOrDefault(e => e.Nom == location.Nom);
            var inventaire = db.Inventaires.FirstOrDefault(g => g.MariculeInventaire == location.MariculeInventaire);
            var locationx = new Location
            {
                IdMagasinier = magasinier?.IdMagasinier ?? 0,
                IdMagazin = emplacement?.IdMagasin ?? 0,
                IdEmplacement = emplacement?.IdEmplacement ?? 0,
                IdInventaire = inventaire.IdInventaire,
                CodeArticle = stock.CodeArticle,
                Quantity = stock.Quantity,
                Us = stock.Us,
                Date = DateTime.Now
            };

            db.Add(locationx);
            db.SaveChanges();
        }

    }
}
