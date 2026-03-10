using System.Runtime.Serialization;

int a = 234;
int b = 50;
int c = 35;

//&&(E ou and) e || (OU/OR)
//SER MULHER E TER >=25 (TRUE)
//MULHER(V) && 45 ANOS(V) (TRUE)

//MULHER(V) && 18 anos(f) (false)


if(a>b || a!=a)//SE
{
    Console.WriteLine("é verdade");
}
else //SE NÃO
{
  Console.WriteLine("é mentira");  
}


if(c>b)
{
    Console.WriteLine("é verdade");
}
else
{
    Console.WriteLine("é mentira");
}

if(a<b)
{
    Console.WriteLine("é verdade");
}
else if(a==a)// se o de cima for falsa vai executar o Elseif se ele for falso tb é que executa o else
{
    Console.WriteLine("executou Elseif");
}
else
{
    Console.WriteLine("é falso");
}


Console.ReadLine();