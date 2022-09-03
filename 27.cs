using System;

class Programa
{
	public static void Main(string[] args)
	{
    double preco;
   
    double maior=0,menor=9999999;

    

    for(int i=1; i<=8;i++){
        Console.WriteLine("fale o preço de um produto");
        preco=double.Parse(Console.ReadLine());
        if(maior<preco){
            maior=preco;
        }if(menor>preco){
            menor=preco;
        }

	}
    
    Console.WriteLine("maior:" +maior);
    Console.WriteLine("menor:" +menor);
}
}