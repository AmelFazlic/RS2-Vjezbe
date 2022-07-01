using AutoMapper;
using eProdaja.Model.Request;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.ProductStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService 
        : BaseCRUDService<Model.Proizvodi, Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, 
        IProizvodiService
    {

        public ProizvodiService(IMapper mapper, eProdajaContext context)   
        :base(mapper, context){

        }

        public override Model.Proizvodi Insert(ProizvodiInsertRequest obj)
        {
            var state = BaseState.CreateState("initial");
            state.Context = _context;
            return base.Insert(obj);
        }

        public override Model.Proizvodi Update(int Id, ProizvodiUpdateRequest obj)
        {
            var product = _context.Proizvodis.Find(Id);

            var state = BaseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;
            state.Context = _context;
            state.Update(obj);

            return GetById(Id);
        }

        public Model.Proizvodi Activate(int Id)
        {
            var product = _context.Proizvodis.Find(Id);

            var state = BaseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;
            state.Context = _context;

            state.Activate();

            return GetById(Id);
        }

        public override IQueryable<Proizvodi> AddFilter(IQueryable<Proizvodi> query, ProizvodiSearchObject search)
        {
            var filterQuery = base.AddFilter(query, search);
            if (!string.IsNullOrWhiteSpace(search?.Sifra))
            {
                filterQuery = filterQuery.Where(x=> x.Sifra == search.Sifra);
            }
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                filterQuery = filterQuery.Where(x => x.Naziv.Contains(search.Naziv));
            }

            return filterQuery;
        }


    }
}
