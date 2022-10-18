using System.Data;
using System.Diagnostics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Приветствую тебя,людишка");
                Console.WriteLine("Для того, чтобы использовать белые клавиши используй: C, D, E, F, G, A, B");
                Console.WriteLine("Непосредственно для вида black юзай: R, T, Y, U, I");
                Console.WriteLine("Выбери октаву");
                Console.WriteLine("F1 - первая октава");
                Console.WriteLine("F2 - вторая октава");
                Console.WriteLine("Нажми F3, чтобы выйти из программы");
                List<int[]> list = new List<int[]>
                {
                    new int[] { 261, 294, 330, 349, 392, 440, 494, 277, 311, 367, 415, 466 },
                    new int[] { 523, 587, 659, 699, 784, 880, 988, 554, 622, 740, 831, 932 }
                };
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.F1)
                {
                    OctavaNumberOne(list[0]);
                }
                if (key.Key == ConsoleKey.F2)
                {
                    OctavaNumberTwo(list[1]);
                }
                if (key.Key == ConsoleKey.F3)
                {
                    Process.GetCurrentProcess().Kill();
                }
            }
            static void OctavaNumberOne(int[] opapa)
            {
                while (true)
                {
                    Console.WriteLine("Твоё сознание прибывает в первой октаве");
                    Console.WriteLine("Для того, чтобы использовать белые клавиши используй: C, D, E, F, G, A, B");
                    Console.WriteLine("Непосредственно для вида black юзай: R, T, Y, U, I");
                    Console.WriteLine("Для перехода ко второй октаве нажми F2 ");
                    Console.WriteLine("Для выхода твоего мозга нажми F3");
                    List<int[]> list = new List<int[]>
                    {
                        new int[] { 523, 587, 659, 699, 784, 880, 988, 554, 622, 740, 831, 932 }
                    };
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.F2)
                    {
                        OctavaNumberTwo(list[0]);
                    }
                    if (key.Key == ConsoleKey.F3)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.C)
                        {
                            Console.Beep(opapa[0], 100);
                        }
                        if (key.Key == ConsoleKey.D)
                        {
                            Console.Beep(opapa[1], 100);
                        }
                        if (key.Key == ConsoleKey.E)
                        {
                            Console.Beep(opapa[2], 100);
                        }
                        if (key.Key == ConsoleKey.F)
                        {
                            Console.Beep(opapa[3], 100);
                        }
                        if (key.Key == ConsoleKey.G)
                        {
                            Console.Beep(opapa[4], 100);
                        }
                        if (key.Key == ConsoleKey.A)
                        {
                            Console.Beep(opapa[5], 100);
                        }
                        if (key.Key == ConsoleKey.B)
                        {
                            Console.Beep(opapa[6], 100);
                        }
                        if (key.Key == ConsoleKey.R)
                        {
                            Console.Beep(opapa[7], 100);
                        }
                        if (key.Key == ConsoleKey.T)
                        {
                            Console.Beep(opapa[8], 100);
                        }
                        if (key.Key == ConsoleKey.Y)
                        {
                            Console.Beep(opapa[9], 100);
                        }
                        if (key.Key == ConsoleKey.U)
                        {
                            Console.Beep(opapa[10], 100);
                        }
                        if (key.Key == ConsoleKey.I)
                        {
                            Console.Beep(opapa[11], 100);
                        }
                    }
                }
            }
            static void OctavaNumberTwo(int[] pepe)
            {
                while (true)
                {
                    Console.WriteLine("Твоё сознание прибывает во второй октаве");
                    Console.WriteLine("Для того, чтобы использовать белые клавиши используй: C, D, E, F, G, A, B");
                    Console.WriteLine("Непосредственно для вида black юзай: R, T, Y, U, I");
                    Console.WriteLine("Для перехода к первой октаве нажми F1 ");
                    Console.WriteLine("Для выхода твоего мозга нажми F2");
                    List<int[]> list = new List<int[]>
                    {
                        new int[] { 261, 294, 330, 349, 392, 440, 494, 277, 311, 367, 415, 466 }
                    };
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.F1)
                    {
                        OctavaNumberOne(list[0]);
                    }
                    if (key.Key == ConsoleKey.F2)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.C)
                        {
                            Console.Beep(pepe[0], 100);
                        }
                        if (key.Key == ConsoleKey.D)
                        {
                            Console.Beep(pepe[1], 100);
                        }
                        if (key.Key == ConsoleKey.E)
                        {
                            Console.Beep(pepe[2], 100);
                        }
                        if (key.Key == ConsoleKey.F)
                        {
                            Console.Beep(pepe[3], 100);
                        }
                        if (key.Key == ConsoleKey.G)
                        {
                            Console.Beep(pepe[4], 100);
                        }
                        if (key.Key == ConsoleKey.A)
                        {
                            Console.Beep(pepe[5], 100);
                        }
                        if (key.Key == ConsoleKey.B)
                        {
                            Console.Beep(pepe[6], 100);
                        }
                        if (key.Key == ConsoleKey.R)
                        {
                            Console.Beep(pepe[7], 100);
                        }
                        if (key.Key == ConsoleKey.T)
                        {
                            Console.Beep(pepe[8], 100);
                        }
                        if (key.Key == ConsoleKey.Y)
                        {
                            Console.Beep(pepe[9], 100);
                        }
                        if (key.Key == ConsoleKey.U)
                        {
                            Console.Beep(pepe[10], 100);
                        }
                        if (key.Key == ConsoleKey.I)
                        {
                            Console.Beep(pepe[11], 100);
                        }
                    }
                }
            }
        }
    }
}
