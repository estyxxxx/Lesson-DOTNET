using Missile_EstyElaluf.Model;

namespace Missile_EstyElaluf.Serivce
{
    public class MissileService
    {
        public MissileService() { }
        public bool add(Missile missile)
        {
            DB.data.Add(missile);
            return true;
        }

        public IEnumerable<Missile> GetData()
        {
            return DB.data;
        }

        public IEnumerable<Missile> GetDataByLocation(string location)
        {
            return DB.data.Where(d => d.Location == location).ToList();
        }
        public IEnumerable<Missile> GetDataByCity(string city)
        {
            return DB.data.Where(d => d.City == city).ToList();
        }
        public IEnumerable<string> GetCities()
        {
            return DB.data.Select(x => x.City).ToList();

        }
    }
}
