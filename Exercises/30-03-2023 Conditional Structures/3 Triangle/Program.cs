//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou  Escaleno. 
//Sendo    que:    
//− Triângulo    Equilátero:    possui    os    3    lados    iguais.
//− Triângulo    Isóscele:    possui    2    lados    iguais.
//− Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.WriteLine($"Informe as medidas de cada cateto do triângulo a ser analisado, um cateto por vez:");
double lado1 = double.Parse(Console.ReadLine());
double lado2 = double.Parse(Console.ReadLine());
double lado3 = double.Parse(Console.ReadLine());

if(lado1 == lado2 && lado2 == lado3)
{
 Console.WriteLine($"O triângulo e caracterizado com um Triângulo Equilátero");
}

else if(lado1 == lado2 | lado1 == lado3 |lado2 == lado3)
{
 Console.WriteLine($"O triângulo e caracterizado com um Triângulo Isóscele");
}

else if(lado1 != lado2 && lado2 != lado3)
{
 Console.WriteLine($"O triângulo e caracterizado com um Triângulo Escaleno");
}

