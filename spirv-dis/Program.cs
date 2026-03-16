using AssetRipper.Disassembly.SpirV;
using Ookii.CommandLine;
using System;
using System.ComponentModel;

namespace SpirV;

[GeneratedParser]
[ParseOptions(IsPosix = true)]
partial class Options
{
	[CommandLineArgument(ShortName = 't')]
	[Description("Show types")]
	public bool ShowTypes { get; set; } = false;

	[CommandLineArgument(ShortName = 'n')]
	[Description("Show object names if possible")]
	public bool ShowNames { get; set; } = false;

	[CommandLineArgument("input", IsPositional = true, IsRequired = true)]
	[Description("Binary SPIR-V file to disassemble")]
	public string InputFile { get; set; } = "";
}

static class Program
{
	static void Main(string[] args)
	{
		Options? options = Options.Parse(args);
		if (options is null)
		{
			return;
		}

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
	}
}
