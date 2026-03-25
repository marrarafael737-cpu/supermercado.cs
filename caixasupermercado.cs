using System.Collections.Specialized;
using System.Numerics;

{
string nome;
double preco , quantidade , compra;
string opcao; 
double totalCompra = 0;


    Console.WriteLine("==================================================");
                         Console.WriteLine("CAIXA DE SUPERMERCADO");
    Console.WriteLine("==================================================");

Console.WriteLine("Você gostaria de comprar ? Sim/Não");
opcao = Console.ReadLine();


while(opcao=="Sim")
{
Console.Write("Qual o nome do produto? : ");
nome = (Console.ReadLine());
Console.Write("Qual o preço do produto? : ");
preco = double.Parse(Console.ReadLine());
Console.Write("Qual a quantidade do produto? : ");
quantidade = double.Parse(Console.ReadLine());

compra = preco*quantidade;
totalCompra = totalCompra + compra;
Console.WriteLine($"O valor total da suas compras foi R$:{totalCompra}");

Console.WriteLine("Você gostaria de adicionar outro produto ? Sim/Nao");
opcao = Console.ReadLine();

}
   Console.WriteLine($"O valor total da compra foi: {totalCompra} reais ");
   Console.WriteLine("Obrigado por comprar conosco, volte sempre!");     



}