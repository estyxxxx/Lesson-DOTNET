using MissileModel;
namespace Missile.DAL
{
    public class MissileRepository
    {
        readonly MissileContext _MissileContext;
        public MissileRepository(MissileContext missileContext)
        {
            _MissileContext = missileContext;

        }
        public List<Missile> GetAll()
        {
            return _MissileContext.Missiles.ToList();
        }
    }
}