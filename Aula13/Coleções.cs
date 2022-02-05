using System;
using System.Collections;
using System.Collections.Generic;
  class MainClass{
    public static void Main(string [] args){
      string [] v = new string[5];
      v[0]="Coleções";
      v[1]="Em";
      v[2]="C#";
      v[3]="11";
      v[4]="2022";
      foreach (string s in v){
        Console.WriteLine(s);

      }
      //ArrayList
      ArrayList a= new ArrayList(); //Vetor que vai crescendo dinâmicamente á medida que vamos inserindo elementos nele.
      a.Add("Coleções");  //Add é o Método de inserção.
      a.Add("Em");
      a.Add("C#");
      a.Add(11);  //Não é necessário deixar como string
      a.Add(2022);
      foreach(object s in a){
        Console.WriteLine(s); //Percorrendo o ArrayList
      }
      //A classe de lista tem a mesma funcionalidade, mas é um vetor dinâmico gênerico, é necessário incluir System.Collections.Generic.
      
      //List
      List<string> a2=new List<string>();
      a2.Add("Coleções"); 
      a2.Add("Em");
      a2.Add("C#");
      a2.Add("11");  //Nesse caso, não é possível incluir elementos inteiros
      a2.Add("2022");  //Nesse caso, não é possível incluir elementos inteiros.
      foreach(string  s in a2){
        Console.WriteLine(s);
      }
      //Queue: a fila implementa um algoritmo onde o primeiro elemento que entra é o primeiro que sai, queue é  parecido com o list.
    Queue<string> f=new Queue<string>();
    f.Enqueue("Coleções");
    f.Enqueue("Em");
    f.Enqueue("C#");
    f.Enqueue("11");
    f.Enqueue("2022");
    while(f.Count > 0){  //Count diz quantos elementos temos na estrutura
      Console.WriteLine(f.Dequeue()); // Desenfileira
    }
    //Pilha: O último elemento que entra é o primeiro que sai
   Stack<string> p=new Stack<string>();
   p.Push("Coleções");
   p.Push("Em");
   p.Push("C#");
   p.Push("11");
   p.Push("2022");
   while(p.Count>0){
     Console.WriteLine(p.Pop()); //Pop remove um elemento da pilha.
   }



    }
  }