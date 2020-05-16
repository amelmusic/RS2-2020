using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public partial class eProdajaContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VrsteProizvoda>().HasData(new eProdaja.Database.VrsteProizvoda()
            {
                VrstaId = 100,
                Naziv = "Vjezbe"
            });
        }
    }
}
