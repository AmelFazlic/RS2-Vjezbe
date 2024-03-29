﻿using AutoMapper;
using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<KorisniciUpdateRequest, Database.Korisnici>();

            CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
            CreateMap<JediniceMjereUpsertRequest, Database.JediniceMjere>();

            CreateMap<Database.Proizvodi, Model.Proizvodi>();
            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();

            CreateMap<Database.VrsteProizvodum, Model.VrsteProizvodum>();
            CreateMap<VrsteProizvodumUpsertRequest, Database.VrsteProizvodum>();

            CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();

            CreateMap<Database.Uloge, Model.Uloge>();
        }
    }
}
