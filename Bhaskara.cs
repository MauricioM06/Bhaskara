using System;

namespace Bhaskara
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double A;
			double B;
			double C;
			double Delta;
			double X1;
			double X2;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Bhaskara");
			Console.ResetColor();
			Console.WriteLine();
			
			Console.Write("Insira o valor de A: ");
			A = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira o valor de B: ");
			B = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira o valor de C: ");
			C = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine();
			
			if (A == 0)
			{
				Console.WriteLine("Não é uma equação de segundo grau.");
			}
			else
			{
				Delta = Math.Pow(B, 2) - (4*A*C);
				
				if (Delta < 0)
				{
					Console.WriteLine($"Como delta é igual a {Delta}, a equação não possui raízes reais.");
				}
				else
				{
					X1 = (-(B) + Math.Sqrt(Delta)) / (2*A);
					X2 = (-(B) - Math.Sqrt(Delta)) / (2*A);
					
					Console.WriteLine($"Delta = {Delta} \nX1 = {X1:N2} \nX2 = {X2:N2}");
				}
			}
        }
    }
}