// See https://aka.ms/new-console-template for more information

using System;
class MainClass {
  public static void Main (string[] args) {
   
//E aí pessoal! Segue um programinha que faz a Sequência Fibonacci.
// Um abraço!!!
    
int numeroAnterior = 0;
int numeroAtual = 1;
int novoNumero;
int fibonacci;

   
   for (int i = 0; i <100;  i++ )
 {  
       fibonacci = numeroAnterior + numeroAtual; 
       Console.WriteLine  (fibonacci);
       numeroAnterior = numeroAtual; 
       numeroAtual = fibonacci;   
  }
  
    
    
  }
}