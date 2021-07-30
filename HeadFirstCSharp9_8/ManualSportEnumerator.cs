using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp9_08
{
    public class ManualSportEnumerator : IEnumerator<Sport>
    {
        int current = -1;

        public Sport Current { get => (Sport)current; }
        public void Dispose() { return; }
        object System.Collections.IEnumerator.Current { get => Current; }

        public bool MoveNext()
        {
            var maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
            if (current >= maxEnumValue - 1)
                return false;
            current++;
            return true;
        }

        public void Reset() { current = 0; }
    }   

    public enum Sport
    {
        Football, Baseball, Basketball, Hockey, Boxing, Rugby, Fencing,
    }
}
