using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace HeadFirstCSharp9_08

{
    class ManualSportSequence : IEnumerable<Sport>
    {
        public IEnumerator<Sport> GetEnumerator()
        {
            return new ManualSportEnumerator();
        }
        
        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
