using System;

class Programa
{
	public static void Main(string[] args)
	{
     int par=0,impar=0,x;

     for(int i=1;i<=7;i++){
        Console.WriteLine("digite um numero");
        x=int.Parse(Console.ReadLine());
        if(x%2 == 0){
            par++;
        }else{
            impar++;
        }
        
     }
    Console.WriteLine("inpar "+impar);
    Console.WriteLine("  par "+par);
	}
}