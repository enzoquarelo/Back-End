//Crie uma classe Aluno com as seguintes propriedades:

//Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
//Também teremos os métodos: 

//VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

//obs:
//bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
//bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
//outros casos a mensalidade será integral
//Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

namespace Students
{
    public class Aluno
    {
        public string Nome ;
        public string Curso;
        public int RG;
        public bool Bolsista;
        public float MediaFinal;
        public float Mensalidade;

        public void VerMediaFinal()
        {
            Console.WriteLine($"A media final de {Nome} e de {MediaFinal}.");
              
        }
        public float VerMensalidade()
        {
            float MensalidadeFinal;

            if(Bolsista == true && MediaFinal >= 8)
            {

                MensalidadeFinal = Mensalidade - (0.5F * Mensalidade);
                Console.WriteLine($"A mensalidade de {Nome} a ser paga e de: R$ {MensalidadeFinal}");
                
                    
            }
            else if(Bolsista == true && MediaFinal > 6 && MediaFinal < 8)
            {

                MensalidadeFinal = Mensalidade - (0.3F * Mensalidade);
                Console.WriteLine($"A mensalidade de {Nome} a ser paga e de: R$ {MensalidadeFinal}");
                    
            }
            else
            {
                MensalidadeFinal = Mensalidade;
                Console.WriteLine($"A mensalidade de {Nome} a ser paga e de: R$ {MensalidadeFinal}");
            }
            return MensalidadeFinal;
        }

        public void VizualizarDados()
        {
            Console.Write($"Nome de Usuario :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Nome}");
            Console.ResetColor();
            Console.Write($"Curso :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Curso}");
            Console.ResetColor();
            Console.Write($"RG do Usuario :");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{RG}");
            Console.ResetColor();
              
        }
    }
}