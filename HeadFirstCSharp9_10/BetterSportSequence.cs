using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HeadFirstCSharp9_08;

namespace HeadFirstCSharp9_10
{
    class BetterSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            // Enums don't have a Length property, so we use a method to get it.
            int maxEnumValue = Enum.GetValues(typeof(Sport)).Length - 1; 
            for (int i = 0; i <= maxEnumValue; i++  )
                yield return (Sport)i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
