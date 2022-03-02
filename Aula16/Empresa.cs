using System;
class MainClass{
  public static void Main (string [] args){
   Funcionario a= new Funcionario("A", 1000);
   Funcionario b= new Funcionario("B",2000);
   Funcionario c= new Funcionario("C",3000);
   Gerente d = new Gerente("D",1000,1000);
   Console.WriteLine(a);
   Console.WriteLine(b);
   Console.WriteLine(c);
   Console.WriteLine(d);
  }
class Funcionario{
  private string nome;
  private decimal salarioBase;
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
  private gratificação;
  //É necessário definir um construtor para um gerente onde recebemos o nome dele, um salário base e um valor de gratificação.
  //O construtor só pode ser chamado fora do corpo de gerente, usando Base.
  : base (n,s);
  public Gerente(string n, decimal s, decimal g){
    gratificação=g;
  }
  public override decimal GetSalario(){
    return base.GetSalario()+gratificação;
  }
} 
}