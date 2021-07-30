using System;
using System.Collections.Generic;
using System.Text;

namespace HeadFirstCSharp9_5
{
    class TallGuy : IClown
    {
        public string FunnyThingIHave => " red big shoes"; 
        public string Name;
        public int Height;

        public void TalkAboutYourself()
         =>
            Console.WriteLine($"My name is {Name} and I am {Height} inches tall.");

        

        public void Honk() => Console.WriteLine("Honk honk!");
    }
}
    