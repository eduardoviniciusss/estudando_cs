 /*
GerarPreco(28);
GerarPreco(11);
GerarPreco(48);
GerarPreco(60);
 */
 
 int soma1 = Somar(1,2,3);
 int soma2 = Somar(10,20,30);
 int soma3 = Somar(100,200,300);

 Console.WriteLine(soma1);
 Console.WriteLine(soma2);
 Console.WriteLine(soma3);


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

//Retorno de Função

static int Somar(int a ,int b, int c)
{
    int resuntadoFinal = a + b + c;
    return resuntadoFinal;
}

