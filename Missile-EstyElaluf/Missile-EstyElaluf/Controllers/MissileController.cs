using Microsoft.AspNetCore.Mvc;
using Missile_EstyElaluf.Model;
using Missile_EstyElaluf.Serivce;

namespace Missile_EstyElaluf.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissileController : ControllerBase
    {
        public MissileController()
        {

        }
        MissileService service = new MissileService();
        [HttpPost]
        public bool post(Missile missile)
        {
            return service.add(missile);
        }
        [HttpGet]
        public IEnumerable<Missile> GetData()
        {
            return service.GetData();
        }
        [HttpGet]
        [Route("Get Data By City")]
        public IEnumerable<Missile> GetDataByCity(string city)
        {
            return service.GetDataByCity(city);
        }
        [HttpGet]
        [Route("Get Data By Location")]
        public IEnumerable<Missile> GetDataByLocation(string location)
        {
            return service.GetDataByLocation(location);
        }
        [HttpGet]
        [Route("Get List Of Cities")]
        public IEnumerable<string> GetCities()
        {
            return service.GetCities();
        }
    }
}
