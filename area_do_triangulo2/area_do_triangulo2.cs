using System;
class Program{
  public static void Main(string[] args){
    double n=AreaTriangulo(10, 20);
    double x=AreaTriangulo(5,8);
    Console.WriteLine(n);
    Console.WriteLine(x);


     }
  public static double AreaTriangulo(double b, double h){
    double area=b*h/2;
    return area;
    }
    }