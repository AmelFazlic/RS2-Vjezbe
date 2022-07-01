using AutoMapper;
using eProdaja.Model.Request;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.ProductStateMachine
{
    public class InitialProductState : BaseState
    {
        public InitialProductState(IMapper mapper, IServiceProvider serviceProvider, eProdajaContext context) 
            : base(mapper, serviceProvider, context)
        {
        }

        public override Model.Proizvodi Insert (ProizvodiInsertRequest request)
        {
            var set = _context.Set<Database.Proizvodi>();

            Database.Proizvodi entity = _mapper.Map<Database.Proizvodi>(request);
            CurrentEntity = entity;
            CurrentEntity.StateMachine = "draft";

            set.Add(entity);

            _context.SaveChanges();

             
            return _mapper.Map<Model.Proizvodi>(entity);
        }
    }
}
