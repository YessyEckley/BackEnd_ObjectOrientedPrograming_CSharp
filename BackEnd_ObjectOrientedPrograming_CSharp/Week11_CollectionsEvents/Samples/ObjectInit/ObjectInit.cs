using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd_ObjectOrientedPrograming_CSharp.Week11_CollectionsEvents.Samples.ObjectInit
{
	public class ObjectInit
	{
		static void DisplayTest()
		{
			Account acc = new Account { AccountId = 101, Balance = 150m };
			Console.WriteLine(acc);
		}
	}
	public class Account
	{
		public int AccountId { get; set; }
		public decimal Balance { get; set; }
		public override string ToString()
		{
			return string.Format("Id: {0}, Balance: {1:C}",
				AccountId, Balance);
		}
	}
}
