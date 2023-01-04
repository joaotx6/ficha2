using System;
namespace ficha2
{
    public class exer3
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            Console.WriteLine("Insira um nr inteiro para verificarmos se é par ou impar:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O nr que introduziu foi {num1}, e {verificaPar(num1)}");
            Console.ReadLine();
        }

        static string verificaPar(int num1) {

            if (num1 % 2 == 0)
            {
                return "é par.";
            }
            else {
                return "é impar.";
            }
           
        }
	}
}

