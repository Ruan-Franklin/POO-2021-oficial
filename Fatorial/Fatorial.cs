using System;
class Program{
  public static void Main(string[] args){
     int f=1; //produtório inicia em 1;
     Console.WriteLine("Digite um número"); //mensagem;
     int n=int.Parse(Console.ReadLine()); //leitura de dados

     for(int i=1; i<=n; i++) //Enquanto o contador for menor ou igual a n, o contador recebe +1
     f=f*i; //multiplica cada fator pelo resultado final do contador
     Console.WriteLine($"Fatorial={f}");
  }
}