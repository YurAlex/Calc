using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int x = GetNumber("Введите первое число:");
                int y = GetNumber("Введите второе число:");

                Console.WriteLine("Выберите команду: *, /, +, -, min, max");
                string cmd = Console.ReadLine();
                int result = GetResult(x, y, cmd);
                Console.WriteLine(result);
                
                                
            } while (Ask());
            

        }

        private static bool Ask()
        {
            while (true)
            {
                Console.WriteLine("Продолжить? Выберите Y или N");
                var status = Console.ReadLine();

                if (status == "Y" || status == "y")
                    return true;
                else if (status == "N" || status == "n")
                    return false;
                else
                    Console.WriteLine("Операция не распознана");
            }
        }

        private static int GetMin(int x, int y)
        {
            int res;
            if (x < y)
            {
                res = x;
            }
            else
                res = y;
            return res;
        }

        private static int GetMax(int x, int y)
        {
            int res;
            if (x > y)
            {
                res = x;
            }
            else
                res = y;
            return res;
        }

        private static int GetResult(int x, int y, string cmd)
        {
            int result = 0;
            switch (cmd)
            {
                case "*": result = x * y; break;
                case "/": result = x / y; break;
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "min": result = GetMin(x, y); break;
                case "max": result = GetMax(x, y); break;
            }
            return result;
        }

        private static int GetNumber(string text)
        {
            Console.WriteLine(text);
            while (true)
            {
                string val = Console.ReadLine();
                int result;
                if (int.TryParse(val, out result))
                    return result;
                else Console.WriteLine("Неправильный формат числа. Повторите ввод");
            }
            
        }
    }
}
