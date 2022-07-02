using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public class APIService
    {
        public string _resource = null;
        public string _endpoint = "https://localhost:44396/";
        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> Get<T>()
        {
            var list = await $"{_endpoint}{_resource}".GetJsonAsync<T>();
            return list;
        }
        public async Task<T> GetById<T>(int Id)
        {
            var result = await $"{_endpoint}{_resource}/{Id}".GetJsonAsync<T>();
            return result;
        }
        public async Task<T> Post<T>(object request)
        {
            var result = await $"{_endpoint}{_resource}".PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }
        public async Task<T> Put<T>(object Id, object request)
        {
            var result = await $"{_endpoint}{_resource}/{Id}".PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }
    }
}
