Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <=11)
{
    Console.WriteLine("Voçê é uma criança!");
}
else if(idade >=11 && idade <=17)
{
    Console.WriteLine("Você é um adolecente!");
}
else if(idade >=17 && idade <=60)
{
    Console.WriteLine("Voçê é um adulto!");
}
else
{
   Console.WriteLine("Voçê é um idoso!") ;
}



Console.ReadLine();