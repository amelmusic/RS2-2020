using eProdaja.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja
{
    public class SetupService
    {
        public static void Init(eProdajaContext context)
        {
            context.Database.Migrate();

        }
    }
}
