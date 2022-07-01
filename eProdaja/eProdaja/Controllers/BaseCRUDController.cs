using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> 
        : BaseController<T,TSearch> where T : class where TSearch 
        : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service)
        :base(service)
        {
        }

        [HttpPost]
        public T Insert ([FromBody] TInsert insert)
        {
            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)this._service).Insert(insert);
            return result;
        }
        [HttpPut("{Id}")]
        public T Update(int Id,[FromBody] TUpdate update)
        {
            var result = ((ICRUDService<T, TSearch, TInsert, TUpdate>)this._service).Update(Id,update);
            return result; 
        }
    }
}
