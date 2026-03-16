using System.Collections.Generic;

namespace AssetRipper.Disassembly.SpirV;

public class ImageOperandsParameterFactory : ParameterFactory
{
	public class BiasParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class LodParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class GradParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(),];
	}

	public class ConstOffsetParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class OffsetParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class ConstOffsetsParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class SampleParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MinLodParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MakeTexelAvailableParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdScope(),];
	}

	public class MakeTexelVisibleParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdScope(),];
	}

	public class OffsetsParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public override Parameter? CreateParameter(object value) => (ImageOperands)value switch
	{
		ImageOperands.Bias => new BiasParameter(),
		ImageOperands.Lod => new LodParameter(),
		ImageOperands.Grad => new GradParameter(),
		ImageOperands.ConstOffset => new ConstOffsetParameter(),
		ImageOperands.Offset => new OffsetParameter(),
		ImageOperands.ConstOffsets => new ConstOffsetsParameter(),
		ImageOperands.Sample => new SampleParameter(),
		ImageOperands.MinLod => new MinLodParameter(),
		ImageOperands.MakeTexelAvailable => new MakeTexelAvailableParameter(),
		ImageOperands.MakeTexelVisible => new MakeTexelVisibleParameter(),
		ImageOperands.Offsets => new OffsetsParameter(),
		_ => null,
	};
}
public class FPFastMathModeParameterFactory : ParameterFactory
{
}
public class SelectionControlParameterFactory : ParameterFactory
{
}
public class LoopControlParameterFactory : ParameterFactory
{
	public class DependencyLengthParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MinIterationsParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxIterationsParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class IterationMultipleParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class PeelCountParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class PartialCountParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class InitiationIntervalALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxConcurrencyALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class DependencyArrayALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class PipelineEnableALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class LoopCoalesceALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxInterleavingALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SpeculatedIterationsALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class LoopCountALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxReinvocationDelayALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public override Parameter? CreateParameter(object value) => (LoopControl)value switch
	{
		LoopControl.DependencyLength => new DependencyLengthParameter(),
		LoopControl.MinIterations => new MinIterationsParameter(),
		LoopControl.MaxIterations => new MaxIterationsParameter(),
		LoopControl.IterationMultiple => new IterationMultipleParameter(),
		LoopControl.PeelCount => new PeelCountParameter(),
		LoopControl.PartialCount => new PartialCountParameter(),
		LoopControl.InitiationIntervalALTERA => new InitiationIntervalALTERAParameter(),
		LoopControl.MaxConcurrencyALTERA => new MaxConcurrencyALTERAParameter(),
		LoopControl.DependencyArrayALTERA => new DependencyArrayALTERAParameter(),
		LoopControl.PipelineEnableALTERA => new PipelineEnableALTERAParameter(),
		LoopControl.LoopCoalesceALTERA => new LoopCoalesceALTERAParameter(),
		LoopControl.MaxInterleavingALTERA => new MaxInterleavingALTERAParameter(),
		LoopControl.SpeculatedIterationsALTERA => new SpeculatedIterationsALTERAParameter(),
		LoopControl.LoopCountALTERA => new LoopCountALTERAParameter(),
		LoopControl.MaxReinvocationDelayALTERA => new MaxReinvocationDelayALTERAParameter(),
		_ => null,
	};
}
public class FunctionControlParameterFactory : ParameterFactory
{
}
public class MemorySemanticsParameterFactory : ParameterFactory
{
}
public class MemoryAccessParameterFactory : ParameterFactory
{
	public class AlignedParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MakePointerAvailableParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdScope(),];
	}

	public class MakePointerVisibleParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdScope(),];
	}

	public class AliasScopeINTELMaskParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class NoAliasINTELMaskParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public override Parameter? CreateParameter(object value) => (MemoryAccess)value switch
	{
		MemoryAccess.Aligned => new AlignedParameter(),
		MemoryAccess.MakePointerAvailable => new MakePointerAvailableParameter(),
		MemoryAccess.MakePointerVisible => new MakePointerVisibleParameter(),
		MemoryAccess.AliasScopeINTELMask => new AliasScopeINTELMaskParameter(),
		MemoryAccess.NoAliasINTELMask => new NoAliasINTELMaskParameter(),
		_ => null,
	};
}
public class KernelProfilingInfoParameterFactory : ParameterFactory
{
}
public class RayFlagsParameterFactory : ParameterFactory
{
}
public class FragmentShadingRateParameterFactory : ParameterFactory
{
}
public class RawAccessChainOperandsParameterFactory : ParameterFactory
{
}
public class SourceLanguageParameterFactory : ParameterFactory
{
}
public class ExecutionModelParameterFactory : ParameterFactory
{
}
public class AddressingModelParameterFactory : ParameterFactory
{
}
public class MemoryModelParameterFactory : ParameterFactory
{
}
public class ExecutionModeParameterFactory : ParameterFactory
{
	public class InvocationsParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class LocalSizeParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(), new LiteralInteger(),];
	}

	public class LocalSizeHintParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(), new LiteralInteger(),];
	}

	public class OutputVerticesParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class VecTypeHintParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SubgroupSizeParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SubgroupsPerWorkgroupParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SubgroupsPerWorkgroupIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class LocalSizeIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(), new IdRef(),];
	}

	public class LocalSizeHintIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(), new IdRef(),];
	}

	public class DenormPreserveParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class DenormFlushToZeroParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SignedZeroInfNanPreserveParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class RoundingModeRTEParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class RoundingModeRTZParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class TileShadingRateQCOMParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(), new LiteralInteger(),];
	}

	public class IsApiEntryAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MaxNodeRecursionAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class StaticNumWorkgroupsAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(), new IdRef(),];
	}

	public class ShaderIndexAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MaxNumWorkgroupsAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(), new IdRef(),];
	}

	public class SharesInputWithAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(),];
	}

	public class OutputPrimitivesEXTParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SharedLocalMemorySizeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class RoundingModeRTPINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class RoundingModeRTNINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class FloatingPointModeALTINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class FloatingPointModeIEEEINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxWorkgroupSizeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(), new LiteralInteger(),];
	}

	public class MaxWorkDimINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class NumSIMDWorkitemsINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SchedulerTargetFmaxMhzINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class FPFastMathDefaultParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(), new IdRef(),];
	}

	public class StreamingInterfaceINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class RegisterMapInterfaceINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class NamedBarrierCountINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaximumRegistersINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaximumRegistersIdINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class NamedMaximumRegistersINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<NamedMaximumNumberOfRegisters>(),];
	}

	public override Parameter? CreateParameter(object value) => (ExecutionMode)value switch
	{
		ExecutionMode.Invocations => new InvocationsParameter(),
		ExecutionMode.LocalSize => new LocalSizeParameter(),
		ExecutionMode.LocalSizeHint => new LocalSizeHintParameter(),
		ExecutionMode.OutputVertices => new OutputVerticesParameter(),
		ExecutionMode.VecTypeHint => new VecTypeHintParameter(),
		ExecutionMode.SubgroupSize => new SubgroupSizeParameter(),
		ExecutionMode.SubgroupsPerWorkgroup => new SubgroupsPerWorkgroupParameter(),
		ExecutionMode.SubgroupsPerWorkgroupId => new SubgroupsPerWorkgroupIdParameter(),
		ExecutionMode.LocalSizeId => new LocalSizeIdParameter(),
		ExecutionMode.LocalSizeHintId => new LocalSizeHintIdParameter(),
		ExecutionMode.DenormPreserve => new DenormPreserveParameter(),
		ExecutionMode.DenormFlushToZero => new DenormFlushToZeroParameter(),
		ExecutionMode.SignedZeroInfNanPreserve => new SignedZeroInfNanPreserveParameter(),
		ExecutionMode.RoundingModeRTE => new RoundingModeRTEParameter(),
		ExecutionMode.RoundingModeRTZ => new RoundingModeRTZParameter(),
		ExecutionMode.TileShadingRateQCOM => new TileShadingRateQCOMParameter(),
		ExecutionMode.IsApiEntryAMDX => new IsApiEntryAMDXParameter(),
		ExecutionMode.MaxNodeRecursionAMDX => new MaxNodeRecursionAMDXParameter(),
		ExecutionMode.StaticNumWorkgroupsAMDX => new StaticNumWorkgroupsAMDXParameter(),
		ExecutionMode.ShaderIndexAMDX => new ShaderIndexAMDXParameter(),
		ExecutionMode.MaxNumWorkgroupsAMDX => new MaxNumWorkgroupsAMDXParameter(),
		ExecutionMode.SharesInputWithAMDX => new SharesInputWithAMDXParameter(),
		ExecutionMode.OutputPrimitivesEXT => new OutputPrimitivesEXTParameter(),
		ExecutionMode.SharedLocalMemorySizeINTEL => new SharedLocalMemorySizeINTELParameter(),
		ExecutionMode.RoundingModeRTPINTEL => new RoundingModeRTPINTELParameter(),
		ExecutionMode.RoundingModeRTNINTEL => new RoundingModeRTNINTELParameter(),
		ExecutionMode.FloatingPointModeALTINTEL => new FloatingPointModeALTINTELParameter(),
		ExecutionMode.FloatingPointModeIEEEINTEL => new FloatingPointModeIEEEINTELParameter(),
		ExecutionMode.MaxWorkgroupSizeINTEL => new MaxWorkgroupSizeINTELParameter(),
		ExecutionMode.MaxWorkDimINTEL => new MaxWorkDimINTELParameter(),
		ExecutionMode.NumSIMDWorkitemsINTEL => new NumSIMDWorkitemsINTELParameter(),
		ExecutionMode.SchedulerTargetFmaxMhzINTEL => new SchedulerTargetFmaxMhzINTELParameter(),
		ExecutionMode.FPFastMathDefault => new FPFastMathDefaultParameter(),
		ExecutionMode.StreamingInterfaceINTEL => new StreamingInterfaceINTELParameter(),
		ExecutionMode.RegisterMapInterfaceINTEL => new RegisterMapInterfaceINTELParameter(),
		ExecutionMode.NamedBarrierCountINTEL => new NamedBarrierCountINTELParameter(),
		ExecutionMode.MaximumRegistersINTEL => new MaximumRegistersINTELParameter(),
		ExecutionMode.MaximumRegistersIdINTEL => new MaximumRegistersIdINTELParameter(),
		ExecutionMode.NamedMaximumRegistersINTEL => new NamedMaximumRegistersINTELParameter(),
		_ => null,
	};
}
public class StorageClassParameterFactory : ParameterFactory
{
}
public class DimParameterFactory : ParameterFactory
{
}
public class SamplerAddressingModeParameterFactory : ParameterFactory
{
}
public class SamplerFilterModeParameterFactory : ParameterFactory
{
}
public class ImageFormatParameterFactory : ParameterFactory
{
}
public class ImageChannelOrderParameterFactory : ParameterFactory
{
}
public class ImageChannelDataTypeParameterFactory : ParameterFactory
{
}
public class FPRoundingModeParameterFactory : ParameterFactory
{
}
public class FPDenormModeParameterFactory : ParameterFactory
{
}
public class QuantizationModesParameterFactory : ParameterFactory
{
}
public class FPOperationModeParameterFactory : ParameterFactory
{
}
public class OverflowModesParameterFactory : ParameterFactory
{
}
public class LinkageTypeParameterFactory : ParameterFactory
{
}
public class AccessQualifierParameterFactory : ParameterFactory
{
}
public class HostAccessQualifierParameterFactory : ParameterFactory
{
}
public class FunctionParameterAttributeParameterFactory : ParameterFactory
{
}
public class DecorationParameterFactory : ParameterFactory
{
	public class SpecIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class ArrayStrideParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MatrixStrideParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class BuiltInParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<BuiltIn>(),];
	}

	public class UniformIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdScope(),];
	}

	public class StreamParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class LocationParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class ComponentParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class IndexParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class BindingParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class DescriptorSetParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class OffsetParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class XfbBufferParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class XfbStrideParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class FuncParamAttrParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<FunctionParameterAttribute>(),];
	}

	public class FPRoundingModeParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<FPRoundingMode>(),];
	}

	public class FPFastMathModeParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<FPFastMathMode>(),];
	}

	public class LinkageAttributesParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(), new EnumType<LinkageType>(),];
	}

	public class InputAttachmentIndexParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class AlignmentParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxByteOffsetParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class AlignmentIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MaxByteOffsetIdParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class NodeSharesPayloadLimitsWithAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class NodeMaxPayloadsAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class PayloadNodeNameAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class PayloadNodeBaseIndexAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class PayloadNodeArraySizeAMDXParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class ArrayStrideIdEXTParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class OffsetIdEXTParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class SecondaryViewportRelativeNVParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MemberOffsetNVParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class BankNVParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class SIMTCallINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class ClobberINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(),];
	}

	public class FuncParamIOKindINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class GlobalVariableOffsetINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class CounterBufferParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class UserSemanticParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(),];
	}

	public class UserTypeGOOGLEParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(),];
	}

	public class FunctionRoundingModeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new EnumType<FPRoundingMode>(),];
	}

	public class FunctionDenormModeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new EnumType<FPDenormMode>(),];
	}

	public class MemoryALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(),];
	}

	public class NumbanksALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class BankwidthALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxPrivateCopiesALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxReplicatesALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MergeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(), new LiteralString(),];
	}

	public class BankBitsALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class ForcePow2DepthALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class StridesizeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class WordsizeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class CacheSizeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class PrefetchALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MathOpDSPModeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(),];
	}

	public class AliasScopeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class NoAliasINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class InitiationIntervalALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MaxConcurrencyALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class PipelineEnableALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class BufferLocationALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class IOPipeStorageALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class FunctionFloatingPointModeINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new EnumType<FPOperationMode>(),];
	}

	public class FPMaxErrorDecorationINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralFloat(),];
	}

	public class LatencyControlLabelALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class LatencyControlConstraintALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new LiteralInteger(), new LiteralInteger(),];
	}

	public class MMHostInterfaceAddressWidthALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MMHostInterfaceDataWidthALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MMHostInterfaceLatencyALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MMHostInterfaceReadWriteModeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<AccessQualifier>(),];
	}

	public class MMHostInterfaceMaxBurstALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class MMHostInterfaceWaitRequestALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class HostAccessINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<HostAccessQualifier>(), new LiteralString(),];
	}

	public class InitModeALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new EnumType<InitializationModeQualifier>(),];
	}

	public class ImplementInRegisterMapALTERAParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class ConditionalINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class CacheControlLoadINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new EnumType<LoadCacheControl>(),];
	}

	public class CacheControlStoreINTELParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(), new EnumType<StoreCacheControl>(),];
	}

	public override Parameter? CreateParameter(object value) => (Decoration)value switch
	{
		Decoration.SpecId => new SpecIdParameter(),
		Decoration.ArrayStride => new ArrayStrideParameter(),
		Decoration.MatrixStride => new MatrixStrideParameter(),
		Decoration.BuiltIn => new BuiltInParameter(),
		Decoration.UniformId => new UniformIdParameter(),
		Decoration.Stream => new StreamParameter(),
		Decoration.Location => new LocationParameter(),
		Decoration.Component => new ComponentParameter(),
		Decoration.Index => new IndexParameter(),
		Decoration.Binding => new BindingParameter(),
		Decoration.DescriptorSet => new DescriptorSetParameter(),
		Decoration.Offset => new OffsetParameter(),
		Decoration.XfbBuffer => new XfbBufferParameter(),
		Decoration.XfbStride => new XfbStrideParameter(),
		Decoration.FuncParamAttr => new FuncParamAttrParameter(),
		Decoration.FPRoundingMode => new FPRoundingModeParameter(),
		Decoration.FPFastMathMode => new FPFastMathModeParameter(),
		Decoration.LinkageAttributes => new LinkageAttributesParameter(),
		Decoration.InputAttachmentIndex => new InputAttachmentIndexParameter(),
		Decoration.Alignment => new AlignmentParameter(),
		Decoration.MaxByteOffset => new MaxByteOffsetParameter(),
		Decoration.AlignmentId => new AlignmentIdParameter(),
		Decoration.MaxByteOffsetId => new MaxByteOffsetIdParameter(),
		Decoration.NodeSharesPayloadLimitsWithAMDX => new NodeSharesPayloadLimitsWithAMDXParameter(),
		Decoration.NodeMaxPayloadsAMDX => new NodeMaxPayloadsAMDXParameter(),
		Decoration.PayloadNodeNameAMDX => new PayloadNodeNameAMDXParameter(),
		Decoration.PayloadNodeBaseIndexAMDX => new PayloadNodeBaseIndexAMDXParameter(),
		Decoration.PayloadNodeArraySizeAMDX => new PayloadNodeArraySizeAMDXParameter(),
		Decoration.ArrayStrideIdEXT => new ArrayStrideIdEXTParameter(),
		Decoration.OffsetIdEXT => new OffsetIdEXTParameter(),
		Decoration.SecondaryViewportRelativeNV => new SecondaryViewportRelativeNVParameter(),
		Decoration.MemberOffsetNV => new MemberOffsetNVParameter(),
		Decoration.BankNV => new BankNVParameter(),
		Decoration.SIMTCallINTEL => new SIMTCallINTELParameter(),
		Decoration.ClobberINTEL => new ClobberINTELParameter(),
		Decoration.FuncParamIOKindINTEL => new FuncParamIOKindINTELParameter(),
		Decoration.GlobalVariableOffsetINTEL => new GlobalVariableOffsetINTELParameter(),
		Decoration.CounterBuffer => new CounterBufferParameter(),
		Decoration.UserSemantic => new UserSemanticParameter(),
		Decoration.UserTypeGOOGLE => new UserTypeGOOGLEParameter(),
		Decoration.FunctionRoundingModeINTEL => new FunctionRoundingModeINTELParameter(),
		Decoration.FunctionDenormModeINTEL => new FunctionDenormModeINTELParameter(),
		Decoration.MemoryALTERA => new MemoryALTERAParameter(),
		Decoration.NumbanksALTERA => new NumbanksALTERAParameter(),
		Decoration.BankwidthALTERA => new BankwidthALTERAParameter(),
		Decoration.MaxPrivateCopiesALTERA => new MaxPrivateCopiesALTERAParameter(),
		Decoration.MaxReplicatesALTERA => new MaxReplicatesALTERAParameter(),
		Decoration.MergeALTERA => new MergeALTERAParameter(),
		Decoration.BankBitsALTERA => new BankBitsALTERAParameter(),
		Decoration.ForcePow2DepthALTERA => new ForcePow2DepthALTERAParameter(),
		Decoration.StridesizeALTERA => new StridesizeALTERAParameter(),
		Decoration.WordsizeALTERA => new WordsizeALTERAParameter(),
		Decoration.CacheSizeALTERA => new CacheSizeALTERAParameter(),
		Decoration.PrefetchALTERA => new PrefetchALTERAParameter(),
		Decoration.MathOpDSPModeALTERA => new MathOpDSPModeALTERAParameter(),
		Decoration.AliasScopeINTEL => new AliasScopeINTELParameter(),
		Decoration.NoAliasINTEL => new NoAliasINTELParameter(),
		Decoration.InitiationIntervalALTERA => new InitiationIntervalALTERAParameter(),
		Decoration.MaxConcurrencyALTERA => new MaxConcurrencyALTERAParameter(),
		Decoration.PipelineEnableALTERA => new PipelineEnableALTERAParameter(),
		Decoration.BufferLocationALTERA => new BufferLocationALTERAParameter(),
		Decoration.IOPipeStorageALTERA => new IOPipeStorageALTERAParameter(),
		Decoration.FunctionFloatingPointModeINTEL => new FunctionFloatingPointModeINTELParameter(),
		Decoration.FPMaxErrorDecorationINTEL => new FPMaxErrorDecorationINTELParameter(),
		Decoration.LatencyControlLabelALTERA => new LatencyControlLabelALTERAParameter(),
		Decoration.LatencyControlConstraintALTERA => new LatencyControlConstraintALTERAParameter(),
		Decoration.MMHostInterfaceAddressWidthALTERA => new MMHostInterfaceAddressWidthALTERAParameter(),
		Decoration.MMHostInterfaceDataWidthALTERA => new MMHostInterfaceDataWidthALTERAParameter(),
		Decoration.MMHostInterfaceLatencyALTERA => new MMHostInterfaceLatencyALTERAParameter(),
		Decoration.MMHostInterfaceReadWriteModeALTERA => new MMHostInterfaceReadWriteModeALTERAParameter(),
		Decoration.MMHostInterfaceMaxBurstALTERA => new MMHostInterfaceMaxBurstALTERAParameter(),
		Decoration.MMHostInterfaceWaitRequestALTERA => new MMHostInterfaceWaitRequestALTERAParameter(),
		Decoration.HostAccessINTEL => new HostAccessINTELParameter(),
		Decoration.InitModeALTERA => new InitModeALTERAParameter(),
		Decoration.ImplementInRegisterMapALTERA => new ImplementInRegisterMapALTERAParameter(),
		Decoration.ConditionalINTEL => new ConditionalINTELParameter(),
		Decoration.CacheControlLoadINTEL => new CacheControlLoadINTELParameter(),
		Decoration.CacheControlStoreINTEL => new CacheControlStoreINTELParameter(),
		_ => null,
	};
}
public class BuiltInParameterFactory : ParameterFactory
{
}
public class ScopeParameterFactory : ParameterFactory
{
}
public class GroupOperationParameterFactory : ParameterFactory
{
}
public class KernelEnqueueFlagsParameterFactory : ParameterFactory
{
}
public class CapabilityParameterFactory : ParameterFactory
{
}
public class RayQueryIntersectionParameterFactory : ParameterFactory
{
}
public class RayQueryCommittedIntersectionTypeParameterFactory : ParameterFactory
{
}
public class RayQueryCandidateIntersectionTypeParameterFactory : ParameterFactory
{
}
public class PackedVectorFormatParameterFactory : ParameterFactory
{
}
public class CooperativeMatrixOperandsParameterFactory : ParameterFactory
{
}
public class CooperativeMatrixLayoutParameterFactory : ParameterFactory
{
}
public class CooperativeMatrixUseParameterFactory : ParameterFactory
{
}
public class CooperativeMatrixReduceParameterFactory : ParameterFactory
{
}
public class TensorClampModeParameterFactory : ParameterFactory
{
}
public class TensorAddressingOperandsParameterFactory : ParameterFactory
{
	public class TensorViewParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class DecodeFuncParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public override Parameter? CreateParameter(object value) => (TensorAddressingOperands)value switch
	{
		TensorAddressingOperands.TensorView => new TensorViewParameter(),
		TensorAddressingOperands.DecodeFunc => new DecodeFuncParameter(),
		_ => null,
	};
}
public class InitializationModeQualifierParameterFactory : ParameterFactory
{
}
public class LoadCacheControlParameterFactory : ParameterFactory
{
}
public class StoreCacheControlParameterFactory : ParameterFactory
{
}
public class NamedMaximumNumberOfRegistersParameterFactory : ParameterFactory
{
}
public class MatrixMultiplyAccumulateOperandsParameterFactory : ParameterFactory
{
}
public class FPEncodingParameterFactory : ParameterFactory
{
}
public class CooperativeVectorMatrixLayoutParameterFactory : ParameterFactory
{
}
public class ComponentTypeParameterFactory : ParameterFactory
{
}
public class TensorOperandsParameterFactory : ParameterFactory
{
	public class OutOfBoundsValueARMParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MakeElementAvailableARMParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class MakeElementVisibleARMParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public override Parameter? CreateParameter(object value) => (TensorOperands)value switch
	{
		TensorOperands.OutOfBoundsValueARM => new OutOfBoundsValueARMParameter(),
		TensorOperands.MakeElementAvailableARM => new MakeElementAvailableARMParameter(),
		TensorOperands.MakeElementVisibleARM => new MakeElementVisibleARMParameter(),
		_ => null,
	};
}
