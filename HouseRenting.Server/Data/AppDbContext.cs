

using Microsoft.EntityFrameworkCore;
using HouseRenting.Share.Entities;

namespace HouseRenting.Server.Data{

public class AppDbContext:DbContext
{


        public AppDbContext (DbContextOptions<AppDbContext>options ):base(options)

        {


        }
         DbSet<House> Houses { get; set; }
    }

}