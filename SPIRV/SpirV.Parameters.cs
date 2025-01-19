using System.Collections.Generic;

namespace SpirV;

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

	public override Parameter? CreateParameter(object value) => (LoopControl)value switch
	{
		LoopControl.DependencyLength => new DependencyLengthParameter(),
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

	public override Parameter? CreateParameter(object value) => (MemoryAccess)value switch
	{
		MemoryAccess.Aligned => new AlignedParameter(),
		_ => null,
	};
}
public class KernelProfilingInfoParameterFactory : ParameterFactory
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

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
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
public class LinkageTypeParameterFactory : ParameterFactory
{
}
public class AccessQualifierParameterFactory : ParameterFactory
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

	public class SecondaryViewportRelativeNVParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralInteger(),];
	}

	public class HlslCounterBufferGOOGLEParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new IdRef(),];
	}

	public class HlslSemanticGOOGLEParameter : Parameter
	{
		public override IReadOnlyList<OperandType> OperandTypes { get => operandTypes_; }

		private static readonly OperandType[] operandTypes_ = [new LiteralString(),];
	}

	public override Parameter? CreateParameter(object value) => (Decoration)value switch
	{
		Decoration.SpecId => new SpecIdParameter(),
		Decoration.ArrayStride => new ArrayStrideParameter(),
		Decoration.MatrixStride => new MatrixStrideParameter(),
		Decoration.BuiltIn => new BuiltInParameter(),
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
		Decoration.SecondaryViewportRelativeNV => new SecondaryViewportRelativeNVParameter(),
		Decoration.HlslCounterBufferGOOGLE => new HlslCounterBufferGOOGLEParameter(),
		Decoration.HlslSemanticGOOGLE => new HlslSemanticGOOGLEParameter(),
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