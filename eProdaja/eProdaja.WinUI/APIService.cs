using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.WinUI.Properties;
using Flurl.Http;

namespace eProdaja.WinUI
{
    public class APIService
    {
        private string _resource;
        public string endpoint = $"{Resources.ApiUrl}";
        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> GetAll<T>(object searchRequest = null)
        {
            var query = await searchRequest?.ToQueryString();

            var list = await $"{endpoint}{_resource}?{query}"
               .GetJsonAsync<T>();

            return list;
        }
    }
}
