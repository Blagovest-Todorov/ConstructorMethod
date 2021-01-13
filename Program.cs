using System;

namespace ObjectsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice6 = new Dice(6);
            Dice diceDnD = new Dice(20);
            
            for (int i = 0; i < 15 ; i++)
            {
                Console.WriteLine(dice6.Roll());

            }
        }
    }
}
