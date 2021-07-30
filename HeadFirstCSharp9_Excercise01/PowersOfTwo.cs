using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp9_Excercise01
{
    class PowersOfTwo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            double maxPower = Math.Round(Math.Log(int.MaxValue, 2));
            for (int power = 0; power < maxPower; power++)
                yield return (int)Math.Pow(2, power);
                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
