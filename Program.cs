int precoPocao = 15;
Console.WriteLine("Quantas moedas você possui? ");
int moedas = 
int.Parse(Console.ReadLine());

Console.WriteLine("Quantas poções dejesa comprar? ");
int quantidade = int.Parse(Console.ReadLine());

int total = quantidade * precoPocao;
Console.WriteLine("Valor total: " + total + " moedas.");

if (moedas >= total)
{
    int saldoRestante = moedas - total;
    Console.WriteLine("Compra realizada com sucesso!");
    Console.WriteLine("Saldo restante: " + saldoRestante + " moedas.");
}
else
{
    Console.WriteLine("Saldo insuficiente para realizar a compra!");
}