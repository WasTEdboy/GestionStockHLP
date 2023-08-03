using GestionStockHLP.Repository;
using GestionStockHLP.Repository.Models;

namespace GestionStockHLP.Services.StockService
{
    public class StockService : IStockService
    {
        public Stock GetStockbyid(string code)
        {
            var db = new GestionStockDbContext();
            Stock p = db.Stocks.FirstOrDefault(x => (x.CodeArticle == code || x.Us == code));
            return p;
        }

        public void SetStock(Stock stock)
        {
            var db = new GestionStockDbContext();
            db.Add(stock);
            db.SaveChanges();
        }
    }
}
