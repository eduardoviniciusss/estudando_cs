/*
string produto1 = "Roda";
string produto3 = "Pneus";
string produto4 = "Cama de ar";
string Produto = "Carlota";
string Produto = "Borracha";
*/


//A vez de usar a maneira de cima, posso usar 'Array' que a meneira de baixo.

string[] produtos = new string[5]
{
 "Roda",// 0
 "Pneus",//1
 "Cama de ar",//2
 "Carlota",//3
 "Borracha"//4   
};

//Atualizando valor de intem específico.
produtos[1] = "Pneus Novos";

Console.WriteLine(produtos[1]);
Console.WriteLine(produtos[4]);

Console.ReadLine();

