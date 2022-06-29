﻿using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public eProdajaContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public ProizvodiService(IMapper mapper, eProdajaContext context)   
        {
            _mapper = mapper;
            _context = context;
        }
        //public List<Model.Proizvodi> ProizvodiList = new List<Model.Proizvodi> { new Model.Proizvodi { ProizvodId = 1, Naziv = "Televizor" }, new Model.Proizvodi { ProizvodId = 2, Naziv = "Frizider" } };
        public IEnumerable<Model.Proizvodi> Get()
        {
            var lista = _context.Proizvodis.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(lista);
        }

        public Model.Proizvodi GetById(int ProizvodId)
        {
            Proizvodi proizvodi = _context.Proizvodis.Find(ProizvodId);
            return _mapper.Map<Model.Proizvodi>(proizvodi);
        }
    }
}
