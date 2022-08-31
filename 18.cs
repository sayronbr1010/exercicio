using System;

class Programa
{
	public static void Main(string[] args)
	{
        double n1,n2,n3;

        Console.WriteLine("digite todos os lados de um triangulo");
        n1=double.Parse( Console.ReadLine());
        n2=double.Parse( Console.ReadLine());
        n3=double.Parse( Console.ReadLine());

        if(n1<n2+n3 && n2<n1+n3 && n3<n2+n1){
         if(n1==n2 && n2==n3){
                Console.WriteLine("ele é EQUILÁTERO");
         }if(n1==n2 && n2!=n3||(n2==n3 && n3!=n1)||(n3==n1&&n1!=n2)){
                Console.WriteLine("ele é ISÓSCELES");
         } if(n1!=n2 && n2!=n3 && n3!=n1){
             Console.WriteLine("ele é ESCALENO");
         }
        }else{
            Console.WriteLine("nao é um triangulo");
        }
	}
}