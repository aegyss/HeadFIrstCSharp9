using System;

namespace HeadFirstCSharp9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy();
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}.");
            tallGuy.Honk();
        }
    }
}
