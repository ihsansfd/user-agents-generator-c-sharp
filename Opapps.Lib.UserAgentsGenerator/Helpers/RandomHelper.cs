using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opapps.Lib.UserAgentsGenerator.Helpers
{
    internal class RandomHelper<T>
    {
        private readonly Random _random = new Random();

        public T Generate(List<T> list)
        {
            var randomIndex = _random.Next(list.Count - 1);

            return list[randomIndex];
        }

        public List<T> GenerateMany(List<T> list, int num)
        {
            HashSet<int> indexNumbers = new();
            List<T> res = new();

            while(indexNumbers.Count < num)
            {
                int randomIndex = _random.Next(list.Count - 1);
                indexNumbers.Add(randomIndex);
            }

            foreach(var index in indexNumbers) res.Add(list[index]);

            return res;
            
        }
    }
}
