namespace Coin
{
    public static class Cambio
    {
        public static float CotacaoDolar {get; private set;} = 5.01f;

        public static float DolarParaReal()
        {
            Console.WriteLine($"Para fazer a conversao, por-favor informe o valor a ser convertido");
            float valorDolar = float.Parse(Console.ReadLine());

            float resultado = valorDolar * CotacaoDolar;

            Console.WriteLine($"Valor final -> R$:{resultado}");
            

            return resultado;
        }
        public static float RealParaDolar()
        {
            Console.WriteLine($"Para fazer a conversao, por-favor informe o valor a ser convertido");
            float valorReal = float.Parse(Console.ReadLine());

            float resultado = valorReal / CotacaoDolar;

            Console.WriteLine($"Valor final -> ${resultado}");
            
            return resultado;

        }
    }
}