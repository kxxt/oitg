using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
namespace oitg
{
	class Program
	{
		static void NotParsed(IEnumerable<Error> errs)
		{

		}
		static void Edit(EditOptions opts)
		{

		}
		static void Gen(GenOptions opts)
		{

		}
		static void Main(string[] args)
		{
			var result = Parser.Default.ParseArguments<GenOptions, EditOptions>(args)
						.WithParsed<GenOptions>(opts => Gen(opts))
						.WithParsed<EditOptions>(opts => Edit(opts))
						.WithNotParsed(errs => NotParsed(errs));

		}
	}
}
