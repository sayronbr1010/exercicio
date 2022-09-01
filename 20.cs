using System;

class Programa
{
	public static void Main(string[] args)
	{
        double peso, altura, imc;

        Console.WriteLine("digite seu peso");
        peso=double.Parse( Console.ReadLine());
        Console.WriteLine("digite sua altura(em metros)");
        altura=double.Parse( Console.ReadLine());

        imc =peso/(altura*altura);

        if(imc<18.5){
            Console.WriteLine("Abaixo do peso");
        }if(imc>18.6&&imc<25){
             Console.WriteLine("Peso ideal");
        }if(imc>25.1&&imc<30){
             Console.WriteLine("Sobrepeso");
        }if(imc>30.1&&imc<40){
             Console.WriteLine(" Obesidade");
        }if(imc>40){
             Console.WriteLine("Obesidade mórbida");
        }
	}
}