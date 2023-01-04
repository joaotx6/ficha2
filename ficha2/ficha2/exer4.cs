using System;
namespace ficha2
{
    public class exer4
    {
        static void Main(string[] args)
        {
            int year = 0;

            Console.WriteLine("Introduza o ano a verificar:");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine($"O ano introduzido {year} é: {IsLeapYear(year)}");
            Console.ReadLine();

            static bool IsLeapYear(int year)
            {
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}