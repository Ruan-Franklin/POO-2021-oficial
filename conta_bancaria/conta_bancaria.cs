using System;
 class conta_bancaria{
   private string titular,numero;
   private double saldo; //o ideal para o saldo é usar um decimal //
   public conta_bancaria (string titular, string numero){
     this.titular=titular;
     this.numero=numero;
   }
   public void SetTitular(string titular){
    this.titular=titular;}
   public void SetNumero(string numero){
   this.numero=numero;
   }
   public string GetTitular(){
     return titular;}
   public string GetNumero(){
     return numero;}
   public double GetSaldo(){
     return saldo;}
   public void Depositar(double valor){  // É uma função
    saldo +=valor;} 
   public bool Saque(double valor){   //É uma função
     if(saldo>=valor){
       saldo-=valor;
       return true;}
     return false;
   }
   
   public override string ToString(){
     return $"Titular = {titular}, numero = {numero}, saldo = {saldo:0.00}"; 
   }

 class Program{
 public static void Main (){
   conta_bancaria y=new conta_bancaria("Ruan","1234-k");
   conta_bancaria x=new conta_bancaria("Athirson","4321-l");
   Console.WriteLine(x);
   x.Depositar(1000);
   x.Saque(300);
   Console.WriteLine(y);
   Console.WriteLine(x);
   
 }

 }



}


 
