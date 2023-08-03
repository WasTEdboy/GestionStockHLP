using GestionStockHLP.Repository.Models;

namespace GestionStockHLP.Services.LocationService
{
    public interface ILocationService
    {
        public void setLocation(Locationfinder location);
        Location GetLocations(int id);
    }
}
