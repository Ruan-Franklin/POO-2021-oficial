using System;
using System.Collections.Generic;
class MainClass{
  public static void Main (string [] args){
   Funcionario a= new Funcionario("A", 1000);
   Funcionario b= new Funcionario("B",2000);
   Funcionario c= new Funcionario("C",3000);
   Gerente d = new Gerente("D",1000,1000);
    //Também conseguimos instanciar um funcionario e referênciá-lo com object.
   Object e = new Funcionario("E",3000);
   Object f = new Gerente("F",1500, 600);
   Object g = new Gerente("G",1200, 600);
 /*  Console.WriteLine(a);
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
  x.Inserir(e as Funcionario); // Não tem como descobrir que esse object é um funcionário, então modifica para o tipo funcionário
  x.Inserir(f as Funcionario);
  x.Inserir(g as Funcionario);
  foreach(Funcionario w in x.Funcs){
    Console.WriteLine(w);
  }
  Console.WriteLine("Gerentes: ")
  foreach (Gerente w in x.Gerentes){
    Console.WriteLine(w);
  }
  
  }
class Empresa{
  private List <Funcionario> funcs = new List <Funcionario>();
  public void Inserir(Funcionario f){
    funcs.Add(f);
  }
  public List <Funcionario> Funcs{get => funcs;}
  public List <Gerente> Gerentes{
    List <Gerente> gs = new List <Gerente>();
    foreach(Funcionario f in funcs){
      if(f is Gerente) gs.Add(f as Gerente);
      return gs;
      }
    }
    
  }
    
}
class Funcionario{
  private string nome;
  protected decimal salarioBase;
  public Funcionario(string n, decimal s){
    nome=n;
    salarioBase=s;
 }
  public string GetNome(){ // Método para retornar o nome.
    return nome; 
  }
 public virtual decimal GetSalario(){
   return salarioBase;
 }
 public override string ToString(){
   return $"{nome} {GetSalario()} "; 
}
}
 //Extensão da classe de funcionário:
class Gerente : Funcionario { //Fazendo uma herança
  //Vamos herdar todos os membros da classe funcionário, com exceção dos construtores.
  private decimal gratificação;
  //É necessário definir um construtor para um gerente onde recebemos o nome dele, um salário base e um valor de gratificação.
  //O construtor só pode ser chamado fora do corpo de gerente, usando Base.
  public Gerente(string n, decimal s, decimal g)
  :base (n,s)
  {
    gratificação=g;
  }
  public void Premiar(decimal reajuste){
    salarioBase+=reajuste;
  }
  public override decimal GetSalario(){
    return base.GetSalario() + gratificação;
  }

} 
}