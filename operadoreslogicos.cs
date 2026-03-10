
//&&(E ou and) e || (OU/OR)
//SER MULHER E TER >=25 (TRUE)\
//MULHER(V) && 45 ANOS(V) (TRUE)

//MULHER(V) && 18 anos(f) (false)


Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 0 && idade <=11)//&& "e"
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