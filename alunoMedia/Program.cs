// faça um programa que leia dois números possiveis para nota, calcule média e informe o aluno:
// média <= 3 - reprovado;
// média > 3 e <= 5 - exame;
// Se a média for diferente disso - aprovado;

double nota1;
double nota2;
double media;

do
{
    Console.WriteLine("Digite a primeira (nota que seja valida)");
    nota1 = double.Parse(Console.ReadLine());
} while (nota1 > 10 || nota1 < 0);

do
{
    Console.WriteLine("Digite a segunda nota (que seja valida)");
    nota2 = double.Parse(Console.ReadLine());
} while (nota2 > 10 || nota2 < 0);

media = (nota1 + nota2) / 2;

if (media <= 3)
{
    Console.WriteLine("Você está reprovado! :(");
}
else
{
    if (media > 3 && media <= 5)
    {
        Console.WriteLine("Você está de exame!");
    }
    else
    {
        Console.WriteLine("Parabens, você está aprovado! :)");
    }
}