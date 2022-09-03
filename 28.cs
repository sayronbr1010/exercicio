using System;

class Programa
{
	public static void Main(string[] args)
	{
    double idade,soma=0;
   int ano18=0,ano5=0;
    double maior=0;

    

    for(int i=1; i<=10;i++){
        Console.WriteLine("fale a idade");
        idade=double.Parse(Console.ReadLine());
        soma=soma+idade;
        if(maior<idade){
            maior=idade;
        }if(idade>18){
            ano18++;
        }if(idade<5){
            ano5++;
        }

	}
    Console.WriteLine("a media é :" +(soma/10));
    Console.WriteLine("a tem mais de 18 :" +ano18);
    Console.WriteLine("a tem menos de 5 :"  +ano5);
    Console.WriteLine("a maior idade é " +maior);
   
}
}