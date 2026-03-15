
int contador = 0;

while(contador<10)// "While" em quanto for verdade faça/loop infinito!
{
    Console.WriteLine(contador);
    Console.WriteLine("Rodando While");
  // cada vez que executar vai somar 1 quando chega da decima ele vai dar falsa pq vai ser maior que 10.
  //contador= contador + 1;
  //contador++
  
  contador +=10;
}
Console.WriteLine("FIM DA LINHA");
Console.ReadLine();


