using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  private static List<Fabricante> fs;
  private static List<Veiculo> vs;
  
  public static void Main (string[] args) {
    IniciarObjetos();
    //ExemploSelect();
    //ExemploWhere();
    //ExemploOrderBy();
    //ExemploThenBy();
    //ExemploCount();
    //ExemploDistinct();
    ExemploJoin();
  }

  public static void ExemploSelect() {
    Console.WriteLine("----- Select -----");
    IEnumerable<string> x = fs.Select(f => f.Descricao);
    IEnumerable<string> y = from f in fs select f.Descricao;
    foreach (string s in x) Console.WriteLine(s);
    Console.WriteLine();
    foreach (string s in y) Console.WriteLine(s);
    Console.WriteLine();
  }

  public static void ExemploWhere() {
    Console.WriteLine("----- Where -----");
    var x = vs.Where(v => v.Preco < 50000);
    var y = from v in vs where v.Preco < 50000 select v;
    foreach (Veiculo v in x) Console.WriteLine(v);
    Console.WriteLine();
    foreach (Veiculo v in y) Console.WriteLine(v);
    Console.WriteLine();
  }

  public static void ExemploOrderBy() {
    Console.WriteLine("----- Order By -----");
    var x = vs.OrderBy(v => v.Preco);
    var y = from v in vs orderby v.Preco select v;
    foreach (Veiculo v in x) Console.WriteLine(v);
    Console.WriteLine();
    foreach (Veiculo v in y) Console.WriteLine(v);
    Console.WriteLine();
  }

  public static void ExemploThenBy() {
    Console.WriteLine("----- Then By -----");
    var x = vs.OrderByDescending(v=>v.Ano).ThenBy(v=>v.Preco);
    var y = from v in vs orderby v.Ano descending, v.Preco select v;
    foreach (Veiculo v in x) Console.WriteLine(v);
    Console.WriteLine();
    foreach (Veiculo v in y) Console.WriteLine(v);
    Console.WriteLine();
  }

  public static void ExemploCount() {
    Console.WriteLine("----- Count -----");
    int c1 = vs.Count();
    int c2 = vs.Count(v => v.Preco < 50000);
    Console.WriteLine(c1);
    Console.WriteLine(c2);
    Console.WriteLine();
  }

  public static void ExemploDistinct() {
    Console.WriteLine("----- Distinct -----");
    int[] w = { 1, 1, 2, 2, 3, 4, 5, 5, 6 };
    IEnumerable<int> x = w.Distinct();
    IEnumerable<int> y = vs.Select(v => v.Ano).Distinct();
    foreach (int i in x) Console.WriteLine(i);
    Console.WriteLine();
    foreach (int i in y) Console.WriteLine(i);
    Console.WriteLine();
  }

  public static void ExemploJoin() {
    Console.WriteLine("----- Join -----");
    var x = vs.Join(fs, v => v.IdFabr, f => f.Id,
      (v, f) => new { f.Descricao, v.Modelo, v.Ano, v.Preco });
    var y = from v in vs join f in fs on v.IdFabr equals f.Id 
      select new { f.Descricao, v.Modelo, v.Ano, v.Preco };
    foreach (var i in x) Console.WriteLine(i);
    Console.WriteLine();
    foreach (var i in y) Console.WriteLine(i);
    Console.WriteLine();
  }     

  public static void IniciarObjetos() {
    fs = new List<Fabricante> { 
      new Fabricante { Id = 1, Descricao = "Honda" },
      new Fabricante { Id = 2, Descricao = "VW" },
      new Fabricante { Id = 3, Descricao = "Fiat" },
      new Fabricante { Id = 4, Descricao = "GM" } 
    };

    vs = new List<Veiculo> { 
      new Veiculo { Id = 1, Modelo = "Punto", Ano = 2010, Preco = 55000, IdFabr = 3 },
      new Veiculo { Id = 2, Modelo = "Gol", Ano = 2015, Preco = 40000, IdFabr = 2 },
      new Veiculo { Id = 3, Modelo = "Corsa", Ano = 2015, Preco = 38000, IdFabr = 4 },
      new Veiculo { Id = 4, Modelo = "Civic", Ano = 2019, Preco = 100000, IdFabr = 1 }
    };
  }
}

class Fabricante {
  public int Id { get; set; }
  public string Descricao { get; set; }
}

class Veiculo {
  public int Id { get; set; }
  public string Modelo { get; set; }
  public int Ano { get; set; }
  public double Preco { get; set; }
  public int IdFabr { get; set; }
  public override string ToString() {
    return $"{Id} {Modelo} {Ano} {Preco} {IdFabr}";
  }
}