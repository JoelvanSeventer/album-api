using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Api.Services
{
    public class GreetingService
    {
        public static string checkParameter(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Hello World";
            return $"Hello {name}";
        }
    }
}
