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
            modelBuilder.Entity<JediniceMjere>().HasData(new eProdaja.Database.JediniceMjere()
            {
                JedinicaMjereId = 1,
                Naziv = "Test"
            });
        }
    }
}
