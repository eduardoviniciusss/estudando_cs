int a = 234;
int b = 50;
int c = 35;

if(a>b) //SE
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