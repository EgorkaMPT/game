namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Угадай число \n2.Таблица умножений \n3.Вывод делителей числа");
            Console.Write("Выберите действие: ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Game();
                    Main(args);
                break;
                case 2:
                    Tables();
                    Main(args);
                    break;
                case 3:
                    Divs();
                    Main(args);
                    break;
                default:
                    Console.WriteLine("Вы ввели некоректное действие");
                    Main(args);
                    break;
            }

        }

        private static void Game()
        {
            Random random = new Random();
            int rnum = 0;
            rnum = random.Next(0,101);
            Console.WriteLine("Введите число");
            int ynum = int.Parse(Console.ReadLine());
            while (rnum != ynum)
            {
                if (ynum > rnum)
                {
                    Console.WriteLine("Введите число меньше");
                }
                if (ynum < rnum)
                {
                    Console.WriteLine("Введите число больше");
                }
            ynum = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Поздравляю, вы выиграли");
        }

        private static void Tables()
        {
            int[,] table = new int[10, 10];
            int tab = 2;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = j * i; 
                }
                
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void Divs()
        {
            int ynum = int.Parse(Console.ReadLine());
            for (int i = 1; i < ynum; i++)
            {
                if (ynum % i == 0)
                {
                    Console.Write("\t" + i);
                }
            }
            Console.WriteLine();
        }
    }
}