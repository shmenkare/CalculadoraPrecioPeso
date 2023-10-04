using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
namespace CalculadoraPrecioPeso
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("BIENVENIDO A LA CALCULADORA DE PRECIO POR PESO");

			Console.WriteLine("Ingrese el valor del $ BCV");
			float precioDollar = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Ingrese el PRECIO del PRODUCTO A PESAR");
			float precio = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Ingrese el PESO OBTENIDO");
			
			float peso = Convert.ToSingle(Console.ReadLine());
			float resultadoD = ValorPeso(precio, peso);
			float resultadoB = Conversion(precioDollar, resultadoD);

			Console.WriteLine("El TOTAL A PAGAR ES {0}$ ó {1} Bs. ", resultadoD, resultadoB);

			Console.ReadKey();

		}
		static float Conversion(float MonedaE, float MonedaN)
		{
			float res = MonedaE * MonedaN;
			return res;
		}
		static float ValorPeso(float prec, float val)
		{
			float tot = prec * val;
			return tot;
		}


	}
}