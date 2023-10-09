using System;

namespace KirieshkaPianino
{
    internal class Program
    {
        static int[] firstOctave = new int[] { 261, 293, 329, 349, 392, 440, 493 };
        static int[] secondOctave = new int[] { 523, 587, 659, 698, 784, 880, 988 };
        static int[] thirdOctave = new int[] { 1047, 1175, 1319, 1397, 1568, 1760, 1976 };
        static int[] currentOctave;

        static void Main()
        {
            Console.WriteLine("здрасте в пианино");
            Console.WriteLine("f1,f2,f3 переключают оставы");
            Console.WriteLine("эскейп выходит.");

            currentOctave = firstOctave; 

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.F1)
                {
                    currentOctave = firstOctave;
                }
                else if (keyInfo.Key == ConsoleKey.F2)
                {
                    currentOctave = secondOctave;
                }
                else if (keyInfo.Key == ConsoleKey.F3)
                {
                    currentOctave = thirdOctave;
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    PlayPianinka(keyInfo.Key);
                }
            }
        }

        static void PlayPianinka(ConsoleKey key)
        {
            int i = (int)key - (int)ConsoleKey.Q;
            if (i >= 0 && i < currentOctave.Length)
            {
                int z = currentOctave[i];
                Console.Beep(z, 100);
            }
        }
    }
}