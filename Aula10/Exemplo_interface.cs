using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    Aluno a = new Aluno("Pedro", DateTime.Parse("01/01/1992"));
    Aluno b = new Aluno("Maria", DateTime.Parse("01/01/1993"));
    Aluno c = new Aluno("Paulo", DateTime.Parse("01/01/1991"));
    Aluno[] v = { a, b, c };
    //Array.Sort(v);
    AlunoNascComp x = new AlunoNascComp();
    Array.Sort(v, x);
    foreach(Aluno i in v) Console.WriteLine(i);
  }
}

class Aluno : IComparable {
  private string nome;
  private DateTime nasc;
  public Aluno(string n, DateTime d) {
    this.nome = n;
    this.nasc = d;
  }
  public override string ToString() {
    return $"{nome} {nasc:dd/MM/yyyy}";
  }
  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj;
    return this.nome.CompareTo(x.nome);
  }
  public DateTime GetNascimento() {
    return nasc;
  }
}

class AlunoNascComp : IComparer {
  public int Compare(object x, object y) {
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.GetNascimento().CompareTo(
      b.GetNascimento());
  }
}
