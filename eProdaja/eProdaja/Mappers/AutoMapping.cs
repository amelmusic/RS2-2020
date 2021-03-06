﻿using AutoMapper;
using eProdaja.Database;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace eProdaja.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Korisnici, Model.Korisnici>(); // means you want to map from User to UserDTO
            CreateMap<KorisniciInsertRequest, Korisnici>(); // means you want to map from User to UserDTO
            CreateMap<KorisniciUpdateRequest, Korisnici>(); // means you want to map from User to UserDTO

            CreateMap<Uloge, Model.Uloge>();
            CreateMap<VrsteProizvoda, Model.VrsteProizvoda>();
            CreateMap<JediniceMjere, Model.JediniceMjere>();
            CreateMap<Proizvodi, Model.Proizvodi>();
            CreateMap<ProizvodiInsertRequest, Proizvodi>();
            CreateMap<ProizvodUpdateRequest, Proizvodi>();
        }
    }
}
