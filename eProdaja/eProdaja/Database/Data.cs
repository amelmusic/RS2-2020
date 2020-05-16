using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Database
{
    public class Data
    {
        public static void Seed(eProdajaContext context)
        {
            context.Database.Migrate();

            //add init
            
        }
    }
}
