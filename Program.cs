using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numerador....: ");
            Int32.TryParse(Console
            .ReadLine()
            .ToString(), out Int32 _numerador);

            Console.Write("Digite o denominador..: ");
            Int32.TryParse(Console
            .ReadLine()
            .ToString(), out Int32 _denominador);

            try
            {
                Int32 _resultado = _numerador / _denominador;
                Console.WriteLine($"{_numerador} dividido por {_denominador} é igual à {_resultado}.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine($"Não é possível dividir por zero.");
            }
        }
    }
}
