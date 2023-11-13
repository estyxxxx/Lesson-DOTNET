using Microsoft.EntityFrameworkCore;
using MissileModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissileModel
{
    public class MissileContext : DbContext
    {
        public MissileContext(DbContextOptions<MissileContext> options)
            : base(options)
        {

        }
        public DbSet<Missile> Missiles { get; set; }
    }
}
