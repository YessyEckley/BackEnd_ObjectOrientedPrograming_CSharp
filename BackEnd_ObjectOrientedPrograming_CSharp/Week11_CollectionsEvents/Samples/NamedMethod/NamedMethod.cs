using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.NamedMethod
{
	public class NamedMethod
	{
		delegate int Calculate(int x);
		static void Show5(Calculate calc)
		{
			for (int i = 1; i <= 5; i++)
				Console.WriteLine("{0}   {1}", i, calc(i));
		}
		static int Square(int x)
		{
			return x * x;
		}
		static void DisplayTest()
		{
			Calculate dlgSquare = new Calculate(Square);
			Show5(dlgSquare);
		}
	}
}
