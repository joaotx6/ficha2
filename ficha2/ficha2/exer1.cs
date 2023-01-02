namespace ficha2;

 class exer1
{
    static void Main(string[] args)
    {
        int num1 = 0, num2 = 0;

        Console.WriteLine("Euclides; Insira o 1o nr:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Euclides; Insira o 2o nr:");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("O máx divisor comum dos 2 nrs inteiros, é: " + MDC(num1, num2));
        Console.ReadLine();
    }

    static int MDC(int A, int B)
    {
        if (B != 0) {
            int R = B;
            B = A % B;
            A = R;
            return B;

        } else {

            return A;
        }
    
    }
}



