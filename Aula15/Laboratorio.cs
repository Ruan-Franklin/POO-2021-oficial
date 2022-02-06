using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Laboratorio {
  public int Id { get; set; }
  public string Descricao { get; set; }
  public override string ToString() {
    return $"{Id} - {Descricao}";
  }
}

class MainClass {
  public static void Main (string[] args) {
    List<Laboratorio> labs = new List<Laboratorio>();
    int op = Menu();
    while (op != 0) {
      if (op == 1) IniciarLabs(labs);
      if (op == 2) MostrarLabs(labs);
      if (op == 3) ToCSV(labs);
      if (op == 4) labs = FromCSV();
      if (op == 5) ToXML(labs);
      if (op == 6) labs = FromXML();
      op = Menu();
    }
  }

  public static int Menu() {
    Console.WriteLine("\n----------------------------------");
    Console.WriteLine("1 - Iniciar Labs, 2 - Mostrar Labs");
    Console.WriteLine("3 - Salvar CSV,   4 - Abrir CSV");
    Console.WriteLine("5 - Salvar XML,   6 - Abrir XML");
    Console.WriteLine("0 - Fim");
    Console.WriteLine("----------------------------------\n");
    return int.Parse(Console.ReadLine());
  }

  public static void IniciarLabs(List<Laboratorio> labs) {
    labs.Add(new Laboratorio {Id = 1, Descricao = "Lab01"});
    labs.Add(new Laboratorio {Id = 2, Descricao = "Lab02"});
  }

  public static void MostrarLabs(List<Laboratorio> labs) {
    foreach(Laboratorio lab in labs) Console.WriteLine(lab);
  }

  public static void ToCSV(List<Laboratorio> labs) {
    StreamWriter f = new StreamWriter("Laboratorio.csv");
    foreach(Laboratorio lab in labs)
      f.WriteLine($"{lab.Id};{lab.Descricao}");
    f.Close();
  }

  public static List<Laboratorio> FromCSV() {
    List<Laboratorio> labs = new List<Laboratorio>();
    StreamReader f = new StreamReader("Laboratorio.csv");
    string s = f.ReadLine();
    while (s != null) {
      string[] v = s.Split(';');
      labs.Add(new Laboratorio {Id = int.Parse(v[0]), Descricao=v[1]});
      s = f.ReadLine();
    }
    f.Close();
    return labs;
  }

  public static void ToXML(List<Laboratorio> labs) {
    XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
    StreamWriter f = new StreamWriter("Laboratorio.xml");
    xml.Serialize(f, labs);
    f.Close();
  }

  public static List<Laboratorio> FromXML() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Laboratorio>));
    StreamReader f = new StreamReader("Laboratorio.xml");
    List<Laboratorio> labs = (List<Laboratorio>)xml.Deserialize(f);
    f.Close();
    return labs;
  }

}