namespace TP2Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = EhNumeroPrimo(numero);

            if (ehPrimo)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} não é um número primo.");
            }

            static bool EhNumeroPrimo(int num)
            {
                
                if (num <= 1)
                {
                    return false;
                }

                
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false; 
                    }
                }

               
                return true;
            }
        }
    }
}

