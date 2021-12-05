using System;
class Program{
  public static void Main(string[] args){
    Triangulo x=new Triangulo();
    x.SetBase(10);
    x.SetAltura(20);			
    Console.WriteLine(x.CalcArea());
    Triangulo y=new Triangulo();
    y.SetBase(-10);
    y.SetAltura(-20);
    Console.WriteLine(y.CalcArea());
 			      }
class Triangulo{
  private double b,h;
  public void SetBase(double v){
    if(v>0)b=v;
  }
  public void SetAltura(double v){
    if(v>0)h=v;}
  public double GetBase(){
    return b;}
  public double GetAltura(){
    return h;}
  public double CalcArea(){  //operações feitas com atributos dos próprios objetos
    double area=b*h/2;
    return area;
  }
 
}

}



