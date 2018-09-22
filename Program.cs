using System;

namespace Laboratory_work_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal deposit, deposit1, profit, z = 0, z1 = 0, percent = 0.08m, effect, balance;
            int years = 10;
            Console.WriteLine("Срок инвестиции 10 лет под 8% годовых.");
            Console.Write("Введите значение первоначального взноса(>=5000):");
            deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            deposit1 = deposit;
            if (deposit >= 5000)
            {
                for (int i = 1; i <= years; i++)		
                {
                    deposit = (deposit * percent) + deposit;
                    profit = deposit - deposit1;
                    Console.WriteLine("{0,2} год Прибыль {1,8:F3}$ Состояние счета: {2,9:F3} $", i, profit, deposit);
                }
                effect = ((deposit - deposit1) * 100) / deposit1;
                Console.WriteLine("Эффективная процентная ставка вклада за {0,2} лет - {1:F3} %", years, effect);
                Console.WriteLine();
                for (int j = 1; j <= 12; j++)       
                {
                    z = (0.1m + 0.02m * (decimal)Math.Pow(j, 2) + 0.5m * (decimal)Math.Sin(2 * j) + (decimal)Math.Cos(3 * j));
                    balance = deposit + (deposit * z);

                    Console.WriteLine("Остаток капитала за {0,2} месяц: {1,10:F3} Норма прибыли за {2,2} месяц: {3,3:F0} % ", j, balance, j, (z * 100));
                    z1 += z / 12;
                }
                Console.WriteLine("Среднее значение нормы прибыли за период 12 месяцев - {0,3:F0} %", z1 * 100);

            }
            else
            {
                Console.WriteLine("Размер значения первоначального взноса не верен");
            }
            Console.ReadKey();
        }
    }
}
