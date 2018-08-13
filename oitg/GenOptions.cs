using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
namespace oitg
{
	[Verb("gen", HelpText = "Generate Projects .")]
	public class GenOptions
	{
		[Option(Default = false,
				HelpText = "Include the \"bits\\stdc++.h\" for generated cpp files .",
				Required = false,
				SetName = "u" //u stands for universal
				)]
		public bool UseUniversalHeader { get; set; } = false;
		[Option(Default = false,
			HelpText = "Generate a toolkit to compare 2 applications' output .",
			Required = false,
			SetName = "c" //c stands for comparsion
			)]
		public bool GenerateComparsionTools { get; set; } = false;
		[Option(Default = false,
			HelpText = "Generate blank input files .",
			Required = false,
			SetName = "i" //i stands for input
			)]
		public bool GenerateBlankInputFiles { get; set; } = false;
		[Value(0,
			Default = "Project-Test",
			HelpText = "Your project names .",
			Max = 1000,
			MetaName = "project names",
			Min = 1,
			Required = true)]
		public List<string> Projects { get; set; } = new List<string>();
	}
}
