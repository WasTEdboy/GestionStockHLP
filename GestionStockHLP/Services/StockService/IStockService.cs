using GestionStockHLP.Repository.Models;

namespace GestionStockHLP.Services.StockService
{
    public interface IStockService
    {
        Stock GetStockbyid(string code);
        void SetStock(Stock stock);
    }
}
