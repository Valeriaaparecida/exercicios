Console.WriteLine("**************************************************************");
Console.WriteLine("**************************************************************");
Console.WriteLine("***************Bem vindo(a) ao Sacolão Pacheco****************");
Console.WriteLine("**************************************************************");
Console.WriteLine("**************************************************************");

Console.WriteLine("Digite o dia da semana para saber das promoções:");    
switch(Console.ReadLine().ToLower())
{
    case "segunda":
        Console.WriteLine("Bem vindo a Segunda do Abacaxi!!");
        break;
    case "terça":
        Console.WriteLine("Venha aproveitar a Terça do Mamão e da Laranja!");
        break;
    case "quarta":
        Console.WriteLine("Hoje temos 20% de desconto em todas as legumes!");
        break;
    case "quinta":
        Console.WriteLine("Hoje temos 25% de desconto em todas as VERDURAS!");
        break;
    case "sexta":
        Console.WriteLine("Hoje temos 30% de desconto em todas as especiarias!");
        break;
    case "sábado":
        Console.WriteLine("Hoje temos 35% de desconto em todas as frutas secas!");
        break;
    case "domingo":
        Console.WriteLine("Hoje temos 40% de desconto em todas as nozes!");
        break;
    default:
        Console.WriteLine("Dia inválido! Tente novamente.");
        break;
}