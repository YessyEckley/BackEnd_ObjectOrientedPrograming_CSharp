using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.AnonymousMethod
{
	public class AnonymousMethod
    {
		delegate int Calculate(int x);
		static void Show5(Calculate calc)
		{
			for (int i = 1; i <= 5; i++)
				Console.WriteLine("{0}   {1}", i, calc(i));
		}
		static void DisplayTest()
		{
			Calculate dlgSquare = delegate(int x)
			{
				return x * x;
			};
			Show5(dlgSquare);
		}
	}
}
