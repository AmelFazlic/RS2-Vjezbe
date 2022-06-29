using AutoMapper;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        public IMapper _mapper { get; set; }
        public eProdajaContext _context { get; set; }
        public KorisniciService(eProdajaContext eProdajaContext, IMapper mapper)
        {
            _context = eProdajaContext;
            _mapper = mapper;
        }
        public IEnumerable<Model.Korisnici> Get()
        {
            var korisnicis = _context.Korisnicis.ToList();
            
            return _mapper.Map<List<Model.Korisnici>>(korisnicis);
        }
    }
}
