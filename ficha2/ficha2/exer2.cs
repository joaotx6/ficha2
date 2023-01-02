using System;
namespace ficha2
{
	public class exer2
	{
        static void Main(string[] args)
        {

            double tempC = 0;

            Console.WriteLine("Insira o valor da temp");
            tempC = double.Parse(Console.ReadLine());

            Console.WriteLine($"A temperatura {tempC}ºF convertida para Celsius são: {Math.Round(convertCelc(tempC), 1)}");
            Console.ReadLine();
        }

        static double convertCelc(double num1) {

            num1 = (num1 - 32) * 5 / 9;
            return num1;
        } 
	}
}

