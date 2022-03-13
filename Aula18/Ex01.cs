using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    //TipagemImplicita();
    //TiposAnonimos();
    //InicializadorObjetos();
    //InicializadorColecoes();
    //InicializadorColecoesTiposAnonimos();
    //Delegado01();
    //Delegado02();
    //Delegado03();
    //Delegado04();
    //Delegado05();
    Delegado06();
  }

  public static void TipagemImplicita() {
    var i = 10;
    var s = "TADS";
    var v = new[] { 10, 10, 2000 };
    
    Console.WriteLine("----- Tipagem Implícita -----");
    Console.WriteLine(i.GetType());
    Console.WriteLine(s.GetType());
    Console.WriteLine(v.GetType());
    Console.WriteLine();
  }

  public static void TiposAnonimos() {
    var v1 = new { modelo="Gol", marca="VW", ano=2010, preco=30000.0 };
    var v2 = new { modelo="Corsa", marca="GM", ano=2010, preco=35000.0 };
    var c1 = new { nome="a", email="a@email.com", fone="1234-5678" };
    
    Console.WriteLine("----- Tipos Anônimos -----");
    Console.WriteLine(v1);
    Console.WriteLine(v2);
    Console.WriteLine(c1);
    Console.WriteLine(v1.GetType());
    Console.WriteLine(v2.GetType());
    Console.WriteLine(c1.GetType());
    Console.WriteLine();
  }

  public static void InicializadorObjetos() {
    Contato c1 = new Contato { Nome = "Nome1", Email = "nome1@email.com" };
    Contato c2 = new Contato { Nome = "Nome2", Fone = "1234-5678",
      Nascimento = DateTime.Parse("10/10/2000") };

    Console.WriteLine("----- Inicializador de Objetos -----");
    Console.WriteLine(c1.Nome);
    Console.WriteLine(c2.Nome);
    Console.WriteLine(c1.GetType());
    Console.WriteLine(c2.GetType());
    Console.WriteLine();
  }

  public static void InicializadorColecoes() {
    List<string> l1 = new List<string> { "Tecnologia", "Análise e Desenvolvimento", "Sistemas" };
    
    Console.WriteLine("----- Inicializador de Coleções -----");
    Console.WriteLine(l1[0]);
    Console.WriteLine(l1[1]);
    Console.WriteLine(l1[2]);
    Console.WriteLine();
  }

  public static void InicializadorColecoesTiposAnonimos() {
    var l2 = new[] { 
      new { modelo = "Gol", marca = "VW", ano = 2010, preco = 30000.0 },
      new { modelo = "Corsa", marca = "GM", ano = 2010, preco = 35000.0 },
      new { modelo = "Punto", marca = "Fiat", ano = 2010, preco = 42000.0 }
    };

    Console.WriteLine("----- Coleções de Tipos Anônimos -----");
    Console.WriteLine(l2[0]);
    Console.WriteLine(l2[1]);
    Console.WriteLine(l2[2]);
    Console.WriteLine();
  }

  public static void Delegado01() {
    Calculo m = Math.Sqrt;
    double v = m(16);

    Console.WriteLine("----- Delegados com Métodos Estáticos -----");
    Console.WriteLine(v);
    Console.WriteLine();
  }

  public static void Delegado02() {
    Calculo m = (new Funcoes()).Quadrado;
    double v = m(16);

    Console.WriteLine("----- Delegados com Métodos de Instância -----");
    Console.WriteLine(v);
    Console.WriteLine();
  }

  public static void Delegado03() {
    Dobro<double> m1 = DobroNumero;
    Dobro<string> m2 = DobroTexto;

    Console.WriteLine("----- Delegados com Genéricos -----");
    m1(16);
    m2("Delegates em C#.... ");
    Console.WriteLine();
  }

  public static void Delegado04() {
    // Expressão Lambda
    Calculo m1 = x => x * x * x;
    // Instrução Lambda
    Calculo m2 = x => { 
      double t = 0;
      for (int i = 1; i <= x; i++) t += i;
      return t;
    };
    double v1 = m1(10);
    double v2 = m2(10);

    Console.WriteLine("----- Delegados com Expressões Lambda -----");
    Console.WriteLine(v1);
    Console.WriteLine(v2);
    Console.WriteLine();
  }

  public static void Delegado05() {
    Action<double> m1 = DobroNumero;
    Func<double, double> m2 = Math.Sqrt;
    Predicate<double> m3 = x => x < 40000;

    Console.WriteLine("----- Action, Func, Predicate -----");
    m1(100);
    double v1 = m2(100);
    bool v2 = m3(100);

    Console.WriteLine(v1);
    Console.WriteLine(v2);
    Console.WriteLine();
  }

  public static void Delegado06() {
    Console.WriteLine("----- Métodos como Argumentos -----");
    double[] v = { 1, 2, 3, 4, 5 };
    Array.ForEach<double>(v, DobroNumero);
    Array.ForEach<double>(v, x => Console.WriteLine(x*x*x));
  }

  public static void DobroNumero(double d) {
    Console.WriteLine(2 * d);
  }
  
  public static void DobroTexto(string s) {
    Console.WriteLine(s + s);
  }
}

delegate double Calculo (double d);

delegate void Dobro<T> (T x);

class Contato {
  public string Nome { get; set; }
  public string Email { get; set; }
  public string Fone { get; set; }
  public DateTime Nascimento { get; set; }
}

class Funcoes {
  public double Quadrado(double d) {
    return d * d;
  }
}