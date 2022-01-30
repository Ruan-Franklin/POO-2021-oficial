using System;
using System.Collections;

class Aluno : IComparable, IComparer{
  public string Nome {get; set;}
  public string Matricula {get; set;}
  public DateTime Nascimento {get; set;}
  public int Idade {get; set;}
  public override string ToString() {
    return $"{Idade} {Nome} {Matricula} {Nascimento:dd/MM/yyyy}";
  }
  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj;
    //if (this.Idade < x.Idade) return -1;
    //if (this.Idade > x.Idade) return 1;
    //return 0; 
    return -this.Idade.CompareTo(x.Idade);
    //return Nome.CompareTo(x.Nome);
  } 
  public int Compare(object x, object y) {
    Aluno xx = (Aluno) x;
    Aluno yy = (Aluno) y;
    return xx.Nome.CompareTo(yy.Nome);
  }
}

class Teste : IComparer {
  public int Compare(object x, object y) {
    Aluno xx = (Aluno) x;
    Aluno yy = (Aluno) y;
    return xx.Nome.CompareTo(yy.Nome);
  }
}

class MainClass {
  public static void Main (string[] args) {

    Aluno a1 = new Aluno { Idade=17, Nome= "ZZZZZ", Matricula="11111", Nascimento=
      DateTime.Parse("2017-10-01") };
    Aluno a2 = new Aluno { Idade=15, Nome= "BBBBB", Matricula="55555", Nascimento=
      DateTime.Parse("2019-10-01") };
    Aluno a3 = new Aluno { Idade=20, Nome= "DDDDD", Matricula="22222", Nascimento=
      DateTime.Parse("2015-10-01") };

    int[] v = { 2, 5, 7, 9, 0, 1 };
    Ordenar(v);
    foreach(int i in v) Console.WriteLine(i);

    Aluno[] w = {a1, a2, a3};
    Ordenar(w);
    foreach(Aluno i in w) Console.WriteLine(i);

    Array.Sort(w); // Aluno -> CompareTo

    Teste t = new Teste();

    Console.WriteLine(t.Compare(a1, a2));
    Console.WriteLine(a1.Compare(a2, a3));

    Array.Sort(w, a1); // Aluno -> Compare
    Array.Sort(w, t);  // Teste -> Compare

    Console.WriteLine(a1.CompareTo(a2));
    Console.WriteLine(a1.CompareTo(a3));
    Console.WriteLine(a2.CompareTo(a3));

    foreach(Aluno x in w)  Console.WriteLine(x);
/*
    foreach(int x in v) Console.WriteLine(x);
    int a = 5; 
    IComparable b = 15;
    object c = 10;
    string e = "Java";
    IComparable f = "C#";
    Console.WriteLine(a.CompareTo(b)); 
    Console.WriteLine(a.CompareTo(a)); 
    Console.WriteLine(b.CompareTo(a)); 
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(a + a);
    Console.WriteLine(b.CompareTo(30));
    Console.WriteLine(c.ToString());
    Console.WriteLine(e[0]);
    Console.WriteLine(e.Substring(0,2));
    //Console.WriteLine(f[0]);
    //Console.WriteLine(f.Substring(0,2));
    Console.WriteLine(f.CompareTo("Teste"));
    */

  }

  public static void Ordenar(Array v) {
    for(int i = 0; i < v.Length - 1; i++)
      for(int j = i + 1; j < v.Length; j++) {
        
        IComparable x = (IComparable) v.GetValue(i);
        IComparable y = (IComparable) v.GetValue(j);

        if (x.CompareTo(y) == 1) {
          v.SetValue(y, i);
          v.SetValue(x, j);
        }
      }
  }
}
