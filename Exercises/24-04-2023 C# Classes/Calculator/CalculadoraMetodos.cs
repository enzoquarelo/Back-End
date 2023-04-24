namespace Calculator
{
    public class CalculadoraMetodos
    {
        public void Soma(float n1, float n2)
        {
            float SomaCalculo = n1 + n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{n1} + {n2} = {SomaCalculo}");
            Console.ResetColor();
        }
        public void Subtracao(float n1, float n2)
        {
            float SubtracaoCalculo = n1 - n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{n1} - {n2} = {SubtracaoCalculo}");
            Console.ResetColor();
        }
        public void Divisao(float n1, float n2)
        {
            float DivisaoCalculo = n1 / n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{n1} / {n2} = {DivisaoCalculo}");
            Console.ResetColor();
        }
        public void Multiplicar(float n1, float n2)
        {
            float MultiplicacaoCalculo = n1 * n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{n1} * {n2} = {MultiplicacaoCalculo}");
            Console.ResetColor();
        }
    }
}