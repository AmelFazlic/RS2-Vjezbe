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
    public class DraftProductState : BaseState
    {
        public DraftProductState(IMapper mapper, IServiceProvider serviceProvider, eProdajaContext context) : base(mapper, serviceProvider, context)
        {
        }

        public override void Update(ProizvodiUpdateRequest request)
        {
            var set = _context.Set<Database.Proizvodi>();

            _mapper.Map(request, set);

            _context.SaveChanges();
            CurrentEntity.StateMachine = "draft";
        }
        public override void Activate()
        {
            CurrentEntity.StateMachine = "active";
            _context.SaveChanges();
        }
        public override List<string> AllowedActions()
        {
            var list = base.AllowedActions();

            list.Add("update");
            list.Add("activate");
            list.Add("hide");

            return list;
        }
    }
}
