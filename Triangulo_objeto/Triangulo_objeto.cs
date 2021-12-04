using System;
class Program{
  public static void Main(string[] args){
     Triangulo x=new Triangulo(); //define um objeto
      x.b=10;
      x.h=20;
      Console.WriteLine(x.CalcArea());
     
     }
    
class Triangulo{
   public double b,h;
   public double CalcArea(){  //operações feitas com atributos dos próprios objetos
     double area=b*h/2;
     return area;}


}

}
