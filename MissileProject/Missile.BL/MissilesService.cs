using Missile;
namespace Missile.BL
{
    public class MissilesService
    {
        readonly DAL.ImissileRepository _imissileRepository;
        public MissilesService(DAL.ImissileRepository imissileRepository)
        {
            _imissileRepository = imissileRepository;
        }
        public List<Missile> getAll()
        {
            return _imissileRepository.GetAll();
        }
    }
}