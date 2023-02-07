using System;
using System.Diagnostics;
using Hash.FNV.Fnv;

namespace Hash.FNV
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice, text;
            Fnv1A hashFunction = null;
            while(true)
            {
                Console.Write("Введите текст: ");
                text = Console.ReadLine();
                while (true)
                {
                    Console.Write("Выберите вариант алгоритма Fnv\n" +
                                  "1.x32\n" +
                                  "2.x64\n" +
                                  "Ваш выбор: ");
                    if (CheckInputChoice(choice = Console.ReadLine(),1,5))
                    {
                        switch (choice)
                        {
                            case "1":
                            {
                                hashFunction = new Fnv1Ax32(text);
                                break;
                            }
                            case "2":
                            {
                                hashFunction = new Fnv1Ax64(text);
                                break;
                            }
                        }

                        break;
                    }
                    Console.WriteLine("Некорректный ввод!");
                    
                }

                if (hashFunction != null)
                {
                    Console.WriteLine($"Введённый текст: {text}\nРезультат хеширования: {hashFunction.GetHash()}");
                }
                

                while (true)
                {
                    Console.Write("Желаете продолжить?\n" +
                                      "1.Да\n" +
                                      "2.Нет\n" +
                                      "Ваш выбор: ");
                    if (CheckInputChoice(choice = Console.ReadLine(), 1,2))
                    {
                        switch (choice)
                        {
                            case "1": break;
                            case "2": Process.GetCurrentProcess().Kill();
                                break;
                        }

                        break;
                    }
                    Console.WriteLine("Некорректный ввод!");
                    
                }
            }
        }

        private static bool CheckInputChoice(string choice, byte leftBorder, byte rightBorder)
        {
            bool check = true;
            
            try
            {
                var digit = byte.Parse(choice);
                if (digit < leftBorder || digit > rightBorder)
                {
                    check = false;
                }
            }
            catch
            {
                check = false;
            }

            return check;
        }
    }
}