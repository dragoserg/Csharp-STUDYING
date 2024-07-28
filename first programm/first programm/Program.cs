using System;
using System.Globalization;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex;
            Console.WriteLine("Для выхода напишите exit");

            while (true)
            {
                bool aftersign = false, divByZero = false, toManySigns = false;
                char op = '+';
                float inum1 = 0, inum2 = 0, res = 0;
                string snum1 = "", snum2 = "";
                Console.Write("Введите логическое выражение со знаками +, -, *, /: \t");
                ex = Console.ReadLine();

                if (ex.ToLower() == "exit")
                    break;

                foreach (char i in ex)
                {
                    switch (i)
                    {
                        case '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9' or '0':
                            switch (aftersign)
                            {
                                case false:
                                    snum1 += i;
                                    break;
                                case true:
                                    snum2 += i;
                                    break;
                            }
                            break;
                        case '+':
                            if (aftersign)
                            {
                                Console.WriteLine("Знаков больше чем 1, повторите ввод");
                                toManySigns = true;
                                break;
                            }
                            op = '+';
                            aftersign = true;
                            break;
                        case '-':
                            if (aftersign)
                            {
                                Console.WriteLine("Знаков больше чем 1, повторите ввод");
                                toManySigns = true;
                                break;
                            }
                            op = '-';
                            aftersign = true;
                            break;
                        case '*':
                            if (aftersign)
                            {
                                Console.WriteLine("Знаков больше чем 1, повторите ввод");
                                toManySigns = true;
                                break;
                            }
                            op = '*';
                            aftersign = true;
                            break;
                        case '/':
                            if (aftersign)
                            {
                                Console.WriteLine("Знаков больше чем 1, повторите ввод");
                                toManySigns = true;
                                break;
                            }
                            op = '/';
                            aftersign = true;
                            break;
                    }
                }

                if (toManySigns)
                    continue;

                if (!float.TryParse(snum1, out inum1))
                {
                    Console.WriteLine("Данные введены не верно, повторите ввод");
                    continue;
                }

                if (!float.TryParse(snum2, out inum2))
                {
                    Console.WriteLine("Данные введены не верно, повторите ввод");
                    continue;
                }

                switch (op)
                {
                    case '+':
                        res = inum1 + inum2;
                        break;
                    case '-':
                        res = inum1 - inum2;
                        break;
                    case '*':
                        res = inum1 * inum2;
                        break;
                    case '/':
                        if (inum2 == 0)
                        {
                            divByZero = true;
                            break;
                        }
                        res = inum1 / inum2;
                        break;
                }

                if (divByZero)
                {
                    Console.WriteLine("Деление на 0 не допустимо, введите другие значения!");
                    continue;
                }

                Console.WriteLine(res);
            }

        }
    }
}