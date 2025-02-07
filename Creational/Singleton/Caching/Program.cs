using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
    public class Program
    {
        public static void Main()
        {
            var cache = SardorCache.Instance;
            cache.Set("name", "Sardor");
            cache.Set("age", "25");
            Console.WriteLine(cache.Get("name"));
            Console.WriteLine(cache.Get("age"));
        }
    }
}
