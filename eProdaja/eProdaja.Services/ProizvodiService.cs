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
        public BaseState _baseState { get; set; }
        public ProizvodiService(IMapper mapper, eProdajaContext context, BaseState baseState)   
        :base(mapper, context){
            _baseState = baseState;
        }

        public override Model.Proizvodi Insert(ProizvodiInsertRequest obj)
        {
            var state = _baseState.CreateState("initial");

            return state.Insert(obj);
        }

        public override Model.Proizvodi Update(int Id, ProizvodiUpdateRequest obj)
        {
            var product = _context.Proizvodis.Find(Id);

            var state = _baseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;

            state.Update(obj);

            return GetById(Id);
        }

        public Model.Proizvodi Activate(int Id)
        {
            var product = _context.Proizvodis.Find(Id);

            var state = _baseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;

            state.Activate();

            return GetById(Id);
        }

        public Model.Proizvodi Hide(int Id)
        {
            var product = _context.Proizvodis.Find(Id);

            var state = _baseState.CreateState(product.StateMachine);

            state.CurrentEntity = product;

            state.Hide();
            
            return GetById(Id);
        }
        public List<string> AllowedActions(int Id)
        {
            var product = GetById(Id);

            var state = _baseState.CreateState(product.StateMachine);

            return state.AllowedActions();
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
