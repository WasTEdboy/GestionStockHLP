using GestionStockHLP.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionStockHLP.Services.EmplacementService
{
    public interface IEmplacementService
    {
        List<Emplacement> Getallemplacement();
        Magasin Findmagasin(int id);
    }
}
