using Medallion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opapps.Lib.UserAgentsGenerator.Helpers
{
    internal class RandomHelper<T>
    {

        public T Generate(List<T> list)
        {
            var randomIndex = Rand.Next(0, list.Count);

            return list[randomIndex];
        }

        public List<T> GenerateMany(List<T> list, int num)
        {
            list.Shuffle();

            return list.GetRange(0, num);
            
        }
    }
}
