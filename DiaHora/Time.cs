using System;
using System.Globalization;  /* Exigido pelo CultereInfo */
using System.Threading; /* Exigido para fazer a modificação */
 class MainClass{
   public static void Main(string [] args){
     CultureInfo ci=new CultureInfo("pt-BR");
     Thread.CurrentThread.CurrentCulture=ci;
     DateTime x = DateTime.Now;
     Console.WriteLine(x);
     Console.WriteLine(x.Day);
     Console.WriteLine(x.Month);
     Console.WriteLine(x.Year);
     Console.WriteLine(x.DayOfYear);
     Console.WriteLine(x.ToString("dd//mm/yy"));
   }

 } 

