using System;

delegate void Metodo(string x);

class Program {
  public static void Mensagem(string s) {
    Console.WriteLine(s);
  }
  
  public static void Main() {
    Mensagem("olá");
    Metodo r = Mensagem;
    r("Blz?");
    Metodo s = z => { Console.WriteLine(z + z); };
    s("legal");
    
    
    Figura3D a = new Esfera("Azul", 10);
    Figura3D b = new Cubo("Verm", 10);
    object c = new Esfera("Amer", 5);
    object d = new Cubo("Roxo", 8);
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(a.GetVolume());
    Console.WriteLine(b.GetVolume());

    float x = 1.56F;
    Console.WriteLine(x);
    double y = 1.56;
    Console.WriteLine(y);
    
  }
}

abstract class Figura3D {
  private string cor = "Azul";
  public Figura3D(string cor) {
    this.cor = cor;
  }
  public string GetCor() {
    return cor;
  }
  public abstract double GetVolume();
  public override string ToString() {
    return base.ToString() + " " + cor;
  }
}

interface IFigura3D {
  double GetVolume();
}

class Esfera : Figura3D {
  private double raio;
  public Esfera(string cor, double r) : base(cor){
    raio = r;
  }
  public override double GetVolume() {
    return 4.0/3 * Math.PI * raio * raio * raio;
  }
}

class Cubo : Figura3D {
  private double lado;
  public Cubo(string cor, double l) : base(cor) {
    lado = l;
  }
  public override double GetVolume() {
    return lado * lado * lado;
  }
}
