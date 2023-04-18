static void Loading(string texto, int pontos, int tempo)
{
    Console.Write(texto);

    for(var i = 0; i < pontos; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($".");
        Thread.Sleep(tempo);
    }
    
    Console.ResetColor();
}

Loading("Carregando", 3, 100);