using api_model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using api_model;

namespace api_service
{
    public class dataList : data
    {

        public List<Missile> list = new List<Missile>();
        public dataList()
        {
            List<Missile> list = new List<Missile>();
        }
        IEnumerable<Missile> data.list();
        public string[] print()
        {
            return list.Select(m => m.Title).ToArray<string>();
        }
    }
}
