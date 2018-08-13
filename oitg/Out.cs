using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oitg
{
	public static class Out
	{
		public static void Put(string s)
		{
			Console.Write(s);
		}
		public static void PutLn(string s)
		{
			Console.WriteLine(s);
		}
		public static void PutLn(string s, ConsoleColor back, ConsoleColor fore)
		{
			Console.WriteLine(s);
		}
	}
}
