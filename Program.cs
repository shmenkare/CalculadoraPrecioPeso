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
			float precioDollar = 1.0f;
			//float bolivar = 1.0f;
			float peso = 1.0f;
			float precio = 1.0f;
			float resultadoD = 0.0f;
			float resultadoB = 0.0f;

			Console.WriteLine("BIENVENIDO A LA CALCULADORA DE PRECIO POR PESO");

			Console.WriteLine("Ingrese el valor del $ BCV");
			precioDollar = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Ingrese el PRECIO del PRODUCTO A PESAR");
			precio = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Ingrese el PESO OBTENIDO");
			peso = Convert.ToSingle(Console.ReadLine());

			resultadoD = ValorPeso(precio, peso);
			resultadoB = Conversion(precioDollar, resultadoD);

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