using System;

namespace KirieshkaPianino
{
    internal class Program
    {
        static int[] firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        static int[] secondOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 988 };
        static int[] thirdOctave = new int[] { 1047, 1109, 1175, 1254, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
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
            int i;
            if (key >= ConsoleKey.A && key <= ConsoleKey.Backspace)
            {
                i = (int)key - (int)ConsoleKey.A;
            }
            else
            { 
                return;
            }
            if (i >= 0 && i<currentOctave.Length)
            {
                int z = currentOctave[i];
            Console.Beep(z, 200);
            }
        }
    }
}
