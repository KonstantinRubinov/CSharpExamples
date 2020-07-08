using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_Use_Case
{
    // delegate void PercentHandler(int percent);

    class NasaCalculator
    {
        public long LongCalculation(Action<int> funcAddress)
        {
            long sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum += i * i;

                funcAddress?.Invoke(i);
            }

            return sum;
        }
    }
}
