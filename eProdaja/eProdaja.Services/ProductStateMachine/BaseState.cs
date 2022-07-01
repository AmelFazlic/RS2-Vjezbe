using AutoMapper;
using eProdaja.Model.Request;
using eProdaja.Services.Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.ProductStateMachine
{
    public class BaseState
    {
        public Database.Proizvodi CurrentEntity { get; set; }
        public string CurrentState { get; set; }
        public eProdajaContext _context { get; set; }

        public IMapper _mapper { get; set; }
        public IServiceProvider _serviceProvider { get; set; }
        public BaseState(IMapper mapper, IServiceProvider serviceProvider, eProdajaContext context)
        {
            _mapper = mapper;
            _serviceProvider = serviceProvider;
            _context = context;
        }

        public virtual Model.Proizvodi Insert(ProizvodiInsertRequest request)
        {
            throw new Exception("Not allowed");
        }
        public virtual void Update(ProizvodiUpdateRequest request)
        {
            throw new Exception("Not allowed");
        }
        public virtual void Activate()
        {
            throw new Exception("Not allowed");
        }
        public virtual void Hide()
        {
            throw new Exception("Not allowed");
        }
        public virtual void Delete()
        {
            throw new Exception("Not allowed");
        }
        public BaseState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return _serviceProvider.GetService<InitialProductState>();
                    break;
                case "draft":
                    return _serviceProvider.GetService<DraftProductState>();
                    break;
                case "active":
                    return _serviceProvider.GetService<ActiveProductState>();
                    break;
                default:
                    throw new Exception("Not supported");
                    break;
            }
        }
        public virtual List<string> AllowedActions()
        {
            return new List<string>();
        }
    }
}
