using System;

class Programa
{
	public static void Main(string[] args)
	{
    bool carro;
    double d;
    int dia;

    Console.WriteLine("true/false");
    Console.WriteLine("é um carro popular");
    carro =bool.Parse (Console.ReadLine());
    Console.WriteLine("quantos dias voce ficou com o carro");
    dia =int.Parse( Console.ReadLine());
    Console.WriteLine("quanto foi andado (em km)");
    d =double.Parse( Console.ReadLine());

    if(carro){
        if(d<100){
             Console.WriteLine("o total é "+((90*dia)+(d*0.2)));
        }else{
            Console.WriteLine("o total é "+((90*dia)+(d*0.1)));
        }
	}else{
        if(d<200){
             Console.WriteLine("o total é "+((150*dia)+(d*0.3)));
        }else{
            Console.WriteLine("o total é "+((150*dia)+(d*0.25)));
        }
    }
}}