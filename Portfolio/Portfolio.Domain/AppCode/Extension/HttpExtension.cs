using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.AppCode.Extension
{
    public static partial class HttpExtension
    {
        public static Dictionary<string, object> AddFromHeader(this Dictionary<string, object> items,
          HttpRequest request, string key)
        {
            if (request.Headers.TryGetValue(key, out StringValues values))
            {
                items.Add(key, values.FirstOrDefault());
            }

            return items;
        }


        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request.Headers != null)
            {
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            }

            return false;
        }
    }
}
