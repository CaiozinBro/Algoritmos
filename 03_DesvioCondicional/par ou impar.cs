using System;

class ParouImpar
{
	static void main()
	{
		int numero;
		Console.Write("Digite um número: ");
		numero = int.Parse(Console.ReadLine());
		
		if(numero%2 == 0)		
			Console.WriteLine("O número é par.")		
		else
			Console.WriteLine("O número é impar.")
	}
}