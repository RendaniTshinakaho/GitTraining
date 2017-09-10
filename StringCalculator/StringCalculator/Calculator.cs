using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator : ICalculator
    {
        List<char> Delimeter = new List<char> { ',', '\n' };
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            var sum = numbers.Split(Delimeter.ToArray()).Select(x => int.Parse(x)).Sum();
            return sum;
        }
    }
}
