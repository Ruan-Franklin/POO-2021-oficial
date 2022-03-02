using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Funcionario a = new Funcionario("A", 1000);
    Funcionario b = new Funcionario("B", 2000);
    Funcionario c = new Funcionario("C", 3000);
    Gerente d = new Gerente("D", 1000, 1000);

    Object e = new Funcionario("E", 3000);
    Object f = new Gerente("F", 1000, 1000);
    Funcionario g = new Gerente("G", 1000, 1000);
/*
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    d.Premiar(1000);
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);
    Console.WriteLine(g);
*/
    Empresa x = new Empresa();
    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    x.Inserir(d);
    x.Inserir(e as Funcionario);
    x.Inserir(f as Funcionario);
    x.Inserir(g);

    foreach(Funcionario w in x.Funcs)
      Console.WriteLine(w);

    Console.WriteLine("Gerentes");

    foreach(Gerente w in x.Gerentes)
      Console.WriteLine(w);
  }
}


class Empresa {
  private List<Funcionario> funcs = new List<Funcionario>();
  public void Inserir(Funcionario f) {
    funcs.Add(f);
  }
  public List<Funcionario> Funcs { get => funcs; }
  public List<Gerente> Gerentes {
    get {
      List<Gerente> gs = new List<Gerente>();
      foreach(Funcionario f in funcs)
        if (f is Gerente) gs.Add(f as Gerente);
      return gs;  
    }
  }
}


class Funcionario : Object {
  private string nome;
  protected decimal salarioBase;
  public Funcionario(string n, decimal s) {
    nome = n;
    salarioBase = s;
  }
  public string GetNome() {
    return nome;
  }
  public virtual decimal GetSalario() {
    return salarioBase;
  }
  public override string ToString() {
    return $"{nome} {GetSalario()}";
  }
}

class Gerente : Funcionario {
  private decimal gratificacao;
  public Gerente(string n, decimal s, decimal g)
  : base(n, s)
  {
    gratificacao = g;
  }
  public void Premiar(decimal reajuste) {
    salarioBase += reajuste;
  }
  public override decimal GetSalario() {
    return base.GetSalario() + gratificacao;
  }
}