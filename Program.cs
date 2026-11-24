int precoPocao = 15;
Console.WriteLine("Quantas moedas você possui? ");
int moedas = 
int.Parse(Console.ReadLine());

Console.WriteLine("Quantas poções dejesa comprar? ");
int quantidade = int.Parse(Console.ReadLine());

int total = quantidade * precoPocao;
Console.WriteLine("Valor total: " + total + " moedas.");
