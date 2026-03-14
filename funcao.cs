
GerarPreco(28);
GerarPreco(11);
GerarPreco(48);
GerarPreco(60);

Console.ReadLine();

static void ExibidorDeMsg()
{
   Console.WriteLine("Testando função");
   Console.WriteLine("Eduardo Vinicius José");
   
}

static void GerarPreco(int preco)
{
    int valorFinal = preco + (2 * preco);
    Console.WriteLine("Valor Final:"+valorFinal);
}