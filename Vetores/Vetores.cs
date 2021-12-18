using System;
 class Mainclass{
 public static void Main(string [] args){
   /*int [] v= new int[10]; */
   /*Console.WriteLine(v[1]); */
   /*Console.WriteLine(v.Length); /* recuperando a quantidade de elementos do vetor */
    int [] w= {1,2,3,4,5,6,7,8,9,10, 0};
   /* Console.WriteLine(w[0]); */
   /*for( int i=0 ; i<w.Length ; i++){
  /*    Console.WriteLine(w[i]);} */
    Array.Sort(w);
    Array.Reverse(w);
   /*foreach(int x in w){
     Console.WriteLine(x);
   } /* Depois pesquisar o que é uma cópia superficial */
   int [] z=(int[]) w.Clone();
   z[0]=20;
   z[9]=40;
   foreach(int x in w){
     Console.WriteLine(x);
   }
   foreach(int x in z){
     Console.WriteLine(x);}
 }
 }
