using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_service
{
    internal class dataStack : data
    {
        List<Missile> list = new List<Missile>();
        public string[] print()
        {
            return list.Select(x => x.Title).ToArray();
        }
    }
}
