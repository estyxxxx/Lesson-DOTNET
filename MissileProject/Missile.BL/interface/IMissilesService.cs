using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missile.BL
{
    public interface IMissilesService
    {
        List<Missile> getAll();
    }
}
