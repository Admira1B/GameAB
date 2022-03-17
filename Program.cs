using System;

namespace gameGTN
{

    class Program
    {
        static void Main(string[] args)
        {
            int powerr = 0; // cложность
            int k = 1; // номер попытки
            int num = -1; // введенное число
            int pow1 = 50; // правый ограничитель кол-ва чисел
            int pop = 0; // кол-во попыток
            bool select = true; 

            while (select)
            {
                Console.WriteLine("Выберите сложность:");
                Console.WriteLine("1. Easy");
                Console.WriteLine("2. Normal");
                Console.WriteLine("3. Hard");

                powerr = int.Parse(Console.ReadLine());

                switch (powerr)
                    {
                        case 1: //Легкий от 0 до 50 за неограниченное число попыток.
                            Console.WriteLine("Вы выбрали легкий уровень игры. Вы должны угадать число от 0 до {0}.", pow1);
                            select = false;
                            break;
                        case 2: //Средний от 0 до 50 за 15 попыток.
                            Console.WriteLine("Вы выбрали cредний уровень игры. Вы должны угадать число от 0 до {0}. Вам дано 15 попыток.", pow1);
                            pop = 15;
                            select = false;
                            break;
                        case 3: //Сложный от 0 до 100 за 10 попыток.
                            pow1 = 100;
                            pop = 10;
                            Console.WriteLine("Вы выбрали сложный уровень игры. Вы должны угадать число от 0 до {0}. Вам дано 10 попыток.", pow1);
                            select = false;
                            break;
                        default:
                            Console.WriteLine("Вы не выбрали ни один из уровней сложности!");
                            break;
                    }
            }

            int pop1 = pop; // кол-во оставшихся попыток

            Random rnd = new Random();
            int val = rnd.Next(0, pow1); //загаданное число
            
            while (val != num)
            {
                Console.WriteLine("Введите число:");
                num = int.Parse(Console.ReadLine());
                
                if (val < num)
                {
                    Console.WriteLine("Загаданное число меньше вашего.");
                }
                else if (val > num)
                {
                    Console.WriteLine("Загаданное число больше вашего.");
                }
                else
                {
                    if (k == 1)
                    {
                        Console.WriteLine("А ты хорош, угадал всего с 1 попытки! Ты реально талант!");
                    }
                    else
                    {
                        Console.WriteLine("А ты хорош, угадал всего с {0} попыток!", k);
                    }
                }

                k++;

                if (powerr == 2 || powerr == 3)
                    pop1--;

                    if (k != pop && val == num)
                    {
                        Console.WriteLine("Попыток осталось: {0}", pop1);
                    }

                    else if (k == pop)
                    {
                        Console.WriteLine("У вас осталось 0 попыток. Вы проиграли.");
                        Console.WriteLine("Загаданное число: {0}", val);
                        Console.WriteLine("Нажмите любую клавишу, чтоб закрыть прогрмму.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
            }
        }
    }
}
// made by Admira1B