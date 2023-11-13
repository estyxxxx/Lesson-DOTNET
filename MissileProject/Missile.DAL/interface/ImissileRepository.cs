using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile.DAL
{
    public interface ImissileRepository
    {
        List<Missile> GetAll();
    }
}
