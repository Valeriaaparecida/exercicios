Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());
if (numero > 0)
{
    Console.WriteLine($"O número {numero} é positivo.");
}
else if (numero < 0)
{
    Console.WriteLine($"O número {numero} é negativo.");
}
else
{
    Console.WriteLine($"O número é zero.");
}