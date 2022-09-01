using System;

class Programa
{
	public static void Main(string[] args)
	{
       string nome;
       double vi;
       double salario;
       double parcela;
       int tempo;

        Console.WriteLine("fale o valor do imprestimo");
        vi=double.Parse( Console.ReadLine());
        Console.WriteLine("fale o valor do seu salario");
        salario=double.Parse( Console.ReadLine());
        Console.WriteLine("fale o seu nome");
        nome=Console.ReadLine();
        Console.WriteLine("em quantos anos vai ser parcelado");
        tempo=int.Parse(Console.ReadLine());

        parcela = vi/(tempo*12);

        if(parcela <= ((salario/100)*30)){
            Console.WriteLine("aprovado");
        }else{
            Console.WriteLine("negado");
        }


	}
}