using CommandLine;
using System;
using System.Collections.Generic;

namespace SpirV;

class Options
{
	[Option('t', HelpText = "Show types")]
	public bool ShowTypes { get; set; } = false;

	[Option('n', HelpText = "Show object names if possible")]
	public bool ShowNames { get; set; } = false;

	[Value(0, MetaName = "Input", HelpText = "Binary SPIR-V file to disassemble", Required = true)]
	public string InputFile { get; set; } = "";
}

class Program
{
	static int Run(Options options)
	{
		Module module = Module.ReadFrom(System.IO.File.OpenRead(options.InputFile));

		DisassemblyOptions settings = DisassemblyOptions.None;

		if (options.ShowNames)
		{
			settings |= DisassemblyOptions.ShowNames;
		}

		if (options.ShowTypes)
		{
			settings |= DisassemblyOptions.ShowTypes;
		}

		Console.Write(Disassembler.Disassemble(module, settings));

		return 0;
	}

	private static int HandleError(IEnumerable<Error> errs)
	{
		return 1;
	}

	static void Main(string[] args)
	{
		Parser.Default.ParseArguments<Options>(args)
			.WithParsed(opts => Run(opts))
			.WithNotParsed((errs) => HandleError(errs));
	}
}
