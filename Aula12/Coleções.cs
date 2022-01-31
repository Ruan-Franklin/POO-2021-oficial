using System;

class MainClass {
  public static void Main (string[] args) {
    Compromisso c1 = new Compromisso {
      Assunto = "assunto 1",
      Local = "local 1",
      Data = DateTime.Now
    };
    Compromisso c2 = new Compromisso {
      Assunto = "assunto 2",
      Local = "local 2",
      Data = DateTime.Now
    };

    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    foreach(Compromisso c in a.Listar())
      Console.WriteLine(c);

    Colecoes<Compromisso> a2 = new Colecoes<Compromisso>();
    a2.Inserir(c1);
    a2.Inserir(c2);
    foreach(Compromisso c in a2.Listar())
      Console.WriteLine(c);
      
    Aplicativo app1 = new Aplicativo {
      Nome = "nome 1",
      Categoria = "categoria 1",
      Preco = 100
    };
    Aplicativo app2 = new Aplicativo {
      Nome = "nome 2",
      Categoria = "categoria 2",
      Preco = 100
    };

    Loja l = new Loja();
    l.Inserir(app1);
    l.Inserir(app2);
    foreach(Aplicativo app in l.Listar())
      Console.WriteLine(app);

    Colecoes<Aplicativo> l2 = new Colecoes<Aplicativo>();
    l2.Inserir(app1);
    l2.Inserir(app2);
    foreach(Aplicativo app in l2.Listar())
      Console.WriteLine(app);
 
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Assunto} {Local} {Data}";
  }
}

class Aplicativo {
  public string Nome { get; set; }
  public string Categoria { get; set; }
  public decimal Preco { get; set; }
  public override string ToString() {
    return $"{Nome} {Categoria} {Preco}";
  }
}

class Agenda {
  private Compromisso[] comps = new Compromisso[50];
  private int k;
  public void Inserir(Compromisso c) {
    if (k < 50) comps[k++] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] r = new Compromisso[k];
    Array.Copy(comps, r, k);
    return r;
  }
}

class Loja {
  private Aplicativo[] apps = new Aplicativo[50];
  private int k;
  public void Inserir(Aplicativo app) {
    if (k < 50) apps[k++] = app;
  }
  public Aplicativo[] Listar() {
    Aplicativo[] r = new Aplicativo[k];
    Array.Copy(apps, r, k);
    return r;
  }
}

class Colecoes<T> {
  private T[] apps = new T[50];
  private int k;
  public void Inserir(T app) {
    if (k < 50) apps[k++] = app;
  }
  public T[] Listar() {
    T[] r = new T[k];
    Array.Copy(apps, r, k);
    return r;
  }
}