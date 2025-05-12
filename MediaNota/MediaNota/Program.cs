using System.Globalization;

Console.WriteLine("******************************************************************");
Console.WriteLine("******* Bem vindo ao Sistema de Notas da Escola C# ***************");
Console.WriteLine("******************************************************************");

Console.WriteLine("Digite o nome do aluno:");
string nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota:");
double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a segunda nota:");
double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite a terceira nota:");
double nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double media = (nota1 + nota2 + nota3) / 3.00;
Console.WriteLine($"A média do aluno(a) {nome} é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
if (media >= 60.00)
{
    Console.WriteLine($"{nome} atingiu a média e foi aprovado(a)");
}
else 
{
    Console.WriteLine($"{nome} não atingiu a média e foi reprovado(a)");
}
