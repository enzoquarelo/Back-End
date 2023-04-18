//Faça um programa que leia três números e mostre o maior e o menor deles.
        double n1 = 0;
        double n2 = 0;
        double n3 = 0;

        Console.WriteLine($"Insira os numeros a serem analisados um por vez!");
        
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());

        double menor = 0;
        double maior = 0;

        if (n1 > n2 && n1 > n3){
            maior = maior + n1;
        }

        else if (n1 < n2 && n1 < n3){
            menor = menor + n1;
        }
            
        else if (n2 > n1 && n2 > n3){
            maior = maior + n2;
        }

        else if (n2 < n1 && n2 < n3) {
            menor = menor + n2;
        }

        else if (n3 > n1 && n3 > n2) {
            maior = maior + n3;
        } 

        else if (n3 < n1 && n3 < n2) {
            menor = menor +   n3;
        }

        Console.WriteLine($"O maior numero e : {maior}, e o menor numero e o {menor}!");