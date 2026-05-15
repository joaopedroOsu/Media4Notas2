double nota1, nota2, nota3, nota4, media;
string resultado;
Console.WriteLine("-- Média --");

Console.Write("Nota 1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
nota4 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3 + nota4) / 4;

if (nota1 < 0 || nota1 > 10
|| nota2 < 0 || nota2 > 10
|| nota3 < 0 || nota3 > 10
|| nota4 < 0 || nota4 > 10)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
}
else
{
if (media < 5)
{
   resultado = "Reprovado";
}
else if (media > 6)
{
   resultado = "Aprovado";
}
else
{
   resultado = "em recupercacao";
}
Console.WriteLine($"Você ficou com média {media} Resultado: {resultado}");
}
