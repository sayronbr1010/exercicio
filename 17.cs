using System;

class Programa
{
	public static void Main(string[] args)
	{
        string nome;
        double salario;
        int idade;
        double sn;

        Console.WriteLine("digite seu nome,seu salario e a quantos anos esta na empresa:");
        nome = Console.ReadLine();
        salario =double.Parse( Console.ReadLine());
        idade =int.Parse( Console.ReadLine());

        if(idade<=3){
            Console.WriteLine("seu novo salario é "+(salario+((salario/100)*3)));
        }if(idade>3 && idade<=10){
            sn =(salario+((salario/100)*12.5));
            Console.WriteLine("seu novo salario é "+sn);
        }
        if(idade>=11){
            sn =(salario+((salario/100)*20));
            Console.WriteLine("seu novo salario é "+sn);
        }
	}
}