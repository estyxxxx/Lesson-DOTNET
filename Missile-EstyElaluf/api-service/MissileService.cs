using api_model;

namespace api_service
{
    public class MissileService
    {
        readonly data _DB;
        public MissileService(data data) 
        {
            _DB = data;
        }
        public bool add(Missile missile)
        {
            ((List<Missile>)_DB.list).Add(missile);
            return true;
        }

        public IEnumerable<Missile> GetData()
        {
            return ((List<Missile>)_DB.list);
        }

        public IEnumerable<Missile> GetDataByLocation(string location)
        {
            return ((List<Missile>)_DB.list).Where(d => d.Location == location).ToList();
        }
        public IEnumerable<Missile> GetDataByCity(string city)
        {
            return ((List<Missile>)_DB.list).Where(d => d.City == city).ToList();
        }
        public IEnumerable<string> GetCities()
        {
            return ((List<Missile>)_DB.list).Select(x => x.City).ToList();

        }
    }
}
