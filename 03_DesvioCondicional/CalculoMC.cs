using System;

class CalculoMC
{
	static void main ()
	{
		double peso, altura, imc;
		Console.WriteLine("Digite seu peso (kg):");
		//Console.ReadLine() é equivalenteao Leia do Portugol
		peso = Double.Parse( Console.ReadLine());
		
		Console.WriteLine("Digite sua altura (m)");
		//Double.parse = converte o texto em número decimal
		altura = Double.Parse(Console.ReadLine() );
		
		imc = peso / (altura * altura);
		Console.WriteLine ("Seu IMC é {0:F3}", imc);
	}
}