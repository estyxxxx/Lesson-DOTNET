using MissileModel.Model;

namespace MissileService
{
    public class MissileService
    {
        public MissileService()
        {

        }
        public bool Add(Missile missile)
        {
            Data.dataService.Add(missile);
            return true;
        }
        public IEnumerable<Missile> GetMissilesList()
        {
            return Data.dataService;
        }
        public IEnumerable<Location> GetLocations()
        {
            List<Location> locations = new List<Location>();
            Data.dataService.ForEach(t => locations.Add(t.location));
            return locations;
        }
        public IEnumerable<Missile> GetByCity(string city)
        {

            return Data.dataService.Where(t => t.location.city == city).ToList();
        }
        public Missile GetById(string id)
        {
            return Data.dataService.Where(t => t.id == id).First();
        }
    }
}