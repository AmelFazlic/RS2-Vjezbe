using eProdaja.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.ProductStateMachine
{
    public class DraftProductState : BaseState
    {
        public override void Update(ProizvodiUpdateRequest request)
        {
            CurrentEntity.StateMachine = "draft";
        }
        public override void Activate()
        {
            CurrentEntity.StateMachine = "active";
        }
    }
}
