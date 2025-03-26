int idade = 10;
string nomeCliente = "Leonardo Silva";
decimal preco = 20M;
char letra = 'a';
var nomecompleto = "Leonardo da Silva Schneider";
var altura = 175;

Console.Write("Digite seu nome");
nomecompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo" + nomecompleto);
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade Informada" + idade);
if (idade < 18)
    Console.WriteLine("Voce não pode estar aqui");
Console.ReadKey();

