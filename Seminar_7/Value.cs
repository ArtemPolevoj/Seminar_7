using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_7
{
	internal class Value
	{
		public static int getInt(string str)
		{
			int number = 0;
		checkNumber:
			Console.WriteLine(str);
			string strNumber = Console.ReadLine();
			try
			{
				number = int.Parse(strNumber);
			}
			catch (FormatException fe)
			{
				Console.WriteLine("Ввели не целое число или не верный формат числа.");
				goto checkNumber;
			}
			catch (OverflowException ofe)
			{
				Console.WriteLine("Ввели большое число.");
				goto checkNumber;
			}

			return number;
		}
	}
}
