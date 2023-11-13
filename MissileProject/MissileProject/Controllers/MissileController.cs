using Microsoft.AspNetCore.Mvc;
using MissileModel.Model;
using MissileService;

namespace MissileProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissileController : ControllerBase
    {
        readonly MissileService.MissileService _service;

        public MissileController(MissileService.MissileService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Missile> Get()
        {
            return _service.GetMissilesList();
        }

        [HttpPost]
        public void post(Missile missile)
        {
            if (!(_service.GetMissilesList().Contains(missile)))
                _service.Add(missile);
        }

        [HttpGet]
        [Route("GetLocations")]
        public IEnumerable<Location> GetLocations()
        {
            return _service.GetLocations();
        }

        [HttpGet]
        [Route("GetByCity")]
        public IEnumerable<Missile> GetByCity(string city)
        {
            if (_service.GetMissilesList().Select(t => t.location.city == city).ToList().Any())
                return _service.GetByCity(city);
            return null;
        }

        [HttpGet]
        [Route("GetById")]
        public Missile GetById(string id)
        {
            if (_service.GetMissilesList().Select(t => t.id == id).ToList().Any())
                return _service.GetById(id);
            return null;
        }
    }
}
