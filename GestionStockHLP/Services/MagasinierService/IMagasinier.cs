using GestionStockHLP.Repository.Models;

namespace GestionStockHLP.Services.MagasinierService
{
    public interface IMagasinier
    {
        List<Magasinier> GetMagasiniers();
        Magasinier GetMagasiniersbyid(int id);



    }
}
