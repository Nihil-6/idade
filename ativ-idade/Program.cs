Console.Write("digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine()); 

if (idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("voce é maior de idade");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("voce é menor de idade");
}
Console.ResetColor();
Console.WriteLine("obrigado");