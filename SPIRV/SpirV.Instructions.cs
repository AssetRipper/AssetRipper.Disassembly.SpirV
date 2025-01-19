using System.Collections.Generic;

namespace SpirV;

public class OpNop : Instruction
{
	public OpNop() : base(nameof(OpNop))
	{
	}
}
public class OpUndef : Instruction
{
	public OpUndef() : base(nameof(OpUndef), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSourceContinued : Instruction
{
	public OpSourceContinued() : base(nameof(OpSourceContinued), [new Operand(new LiteralString(), "Continued Source", OperandQuantifier.Default),])
	{
	}
}
public class OpSource : Instruction
{
	public OpSource() : base(nameof(OpSource), [new Operand(new EnumType<SourceLanguage, SourceLanguageParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Version", OperandQuantifier.Default), new Operand(new IdRef(), "File", OperandQuantifier.Optional), new Operand(new LiteralString(), "Source", OperandQuantifier.Optional),])
	{
	}
}
public class OpSourceExtension : Instruction
{
	public OpSourceExtension() : base(nameof(OpSourceExtension), [new Operand(new LiteralString(), "Extension", OperandQuantifier.Default),])
	{
	}
}
public class OpName : Instruction
{
	public OpName() : base(nameof(OpName), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),])
	{
	}
}
public class OpMemberName : Instruction
{
	public OpMemberName() : base(nameof(OpMemberName), [new Operand(new IdRef(), "Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),])
	{
	}
}
public class OpString : Instruction
{
	public OpString() : base(nameof(OpString), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "String", OperandQuantifier.Default),])
	{
	}
}
public class OpLine : Instruction
{
	public OpLine() : base(nameof(OpLine), [new Operand(new IdRef(), "File", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Line", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column", OperandQuantifier.Default),])
	{
	}
}
public class OpExtension : Instruction
{
	public OpExtension() : base(nameof(OpExtension), [new Operand(new LiteralString(), "Name", OperandQuantifier.Default),])
	{
	}
}
public class OpExtInstImport : Instruction
{
	public OpExtInstImport() : base(nameof(OpExtInstImport), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),])
	{
	}
}
public class OpExtInst : Instruction
{
	public OpExtInst() : base(nameof(OpExtInst), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Set", OperandQuantifier.Default), new Operand(new LiteralExtInstInteger(), "Instruction", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1, +Operand 2, +...", OperandQuantifier.Varying),])
	{
	}
}
public class OpMemoryModel : Instruction
{
	public OpMemoryModel() : base(nameof(OpMemoryModel), [new Operand(new EnumType<AddressingModel, AddressingModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<MemoryModel, MemoryModelParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpEntryPoint : Instruction
{
	public OpEntryPoint() : base(nameof(OpEntryPoint), [new Operand(new EnumType<ExecutionModel, ExecutionModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default), new Operand(new IdRef(), "Interface", OperandQuantifier.Varying),])
	{
	}
}
public class OpExecutionMode : Instruction
{
	public OpExecutionMode() : base(nameof(OpExecutionMode), [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),])
	{
	}
}
public class OpCapability : Instruction
{
	public OpCapability() : base(nameof(OpCapability), [new Operand(new EnumType<Capability, CapabilityParameterFactory>(), "Capability", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeVoid : Instruction
{
	public OpTypeVoid() : base(nameof(OpTypeVoid), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeBool : Instruction
{
	public OpTypeBool() : base(nameof(OpTypeBool), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeInt : Instruction
{
	public OpTypeInt() : base(nameof(OpTypeInt), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Signedness", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeFloat : Instruction
{
	public OpTypeFloat() : base(nameof(OpTypeFloat), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeVector : Instruction
{
	public OpTypeVector() : base(nameof(OpTypeVector), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Component Count", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeMatrix : Instruction
{
	public OpTypeMatrix() : base(nameof(OpTypeMatrix), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Column Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column Count", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeImage : Instruction
{
	public OpTypeImage() : base(nameof(OpTypeImage), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Type", OperandQuantifier.Default), new Operand(new EnumType<Dim, DimParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Depth", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Arrayed", OperandQuantifier.Default), new Operand(new LiteralInteger(), "MS", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Sampled", OperandQuantifier.Default), new Operand(new EnumType<ImageFormat, ImageFormatParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpTypeSampler : Instruction
{
	public OpTypeSampler() : base(nameof(OpTypeSampler), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeSampledImage : Instruction
{
	public OpTypeSampledImage() : base(nameof(OpTypeSampledImage), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Type", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeArray : Instruction
{
	public OpTypeArray() : base(nameof(OpTypeArray), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default), new Operand(new IdRef(), "Length", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeRuntimeArray : Instruction
{
	public OpTypeRuntimeArray() : base(nameof(OpTypeRuntimeArray), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeStruct : Instruction
{
	public OpTypeStruct() : base(nameof(OpTypeStruct), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Member 0 type, +member 1 type, +...", OperandQuantifier.Varying),])
	{
	}
}
public class OpTypeOpaque : Instruction
{
	public OpTypeOpaque() : base(nameof(OpTypeOpaque), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "The name of the opaque type.", OperandQuantifier.Default),])
	{
	}
}
public class OpTypePointer : Instruction
{
	public OpTypePointer() : base(nameof(OpTypePointer), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeFunction : Instruction
{
	public OpTypeFunction() : base(nameof(OpTypeFunction), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Return Type", OperandQuantifier.Default), new Operand(new IdRef(), "Parameter 0 Type, +Parameter 1 Type, +...", OperandQuantifier.Varying),])
	{
	}
}
public class OpTypeEvent : Instruction
{
	public OpTypeEvent() : base(nameof(OpTypeEvent), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeDeviceEvent : Instruction
{
	public OpTypeDeviceEvent() : base(nameof(OpTypeDeviceEvent), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeReserveId : Instruction
{
	public OpTypeReserveId() : base(nameof(OpTypeReserveId), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypeQueue : Instruction
{
	public OpTypeQueue() : base(nameof(OpTypeQueue), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpTypePipe : Instruction
{
	public OpTypePipe() : base(nameof(OpTypePipe), [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), "Qualifier", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeForwardPointer : Instruction
{
	public OpTypeForwardPointer() : base(nameof(OpTypeForwardPointer), [new Operand(new IdRef(), "Pointer Type", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpConstantTrue : Instruction
{
	public OpConstantTrue() : base(nameof(OpConstantTrue), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpConstantFalse : Instruction
{
	public OpConstantFalse() : base(nameof(OpConstantFalse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpConstant : Instruction
{
	public OpConstant() : base(nameof(OpConstant), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConstantComposite : Instruction
{
	public OpConstantComposite() : base(nameof(OpConstantComposite), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),])
	{
	}
}
public class OpConstantSampler : Instruction
{
	public OpConstantSampler() : base(nameof(OpConstantSampler), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<SamplerAddressingMode, SamplerAddressingModeParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Param", OperandQuantifier.Default), new Operand(new EnumType<SamplerFilterMode, SamplerFilterModeParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpConstantNull : Instruction
{
	public OpConstantNull() : base(nameof(OpConstantNull), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSpecConstantTrue : Instruction
{
	public OpSpecConstantTrue() : base(nameof(OpSpecConstantTrue), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSpecConstantFalse : Instruction
{
	public OpSpecConstantFalse() : base(nameof(OpSpecConstantFalse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSpecConstant : Instruction
{
	public OpSpecConstant() : base(nameof(OpSpecConstant), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpSpecConstantComposite : Instruction
{
	public OpSpecConstantComposite() : base(nameof(OpSpecConstantComposite), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),])
	{
	}
}
public class OpSpecConstantOp : Instruction
{
	public OpSpecConstantOp() : base(nameof(OpSpecConstantOp), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralSpecConstantOpInteger(), "Opcode", OperandQuantifier.Default),])
	{
	}
}
public class OpFunction : Instruction
{
	public OpFunction() : base(nameof(OpFunction), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<FunctionControl, FunctionControlParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function Type", OperandQuantifier.Default),])
	{
	}
}
public class OpFunctionParameter : Instruction
{
	public OpFunctionParameter() : base(nameof(OpFunctionParameter), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpFunctionEnd : Instruction
{
	public OpFunctionEnd() : base(nameof(OpFunctionEnd))
	{
	}
}
public class OpFunctionCall : Instruction
{
	public OpFunctionCall() : base(nameof(OpFunctionCall), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default), new Operand(new IdRef(), "Argument 0, +Argument 1, +...", OperandQuantifier.Varying),])
	{
	}
}
public class OpVariable : Instruction
{
	public OpVariable() : base(nameof(OpVariable), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Initializer", OperandQuantifier.Optional),])
	{
	}
}
public class OpImageTexelPointer : Instruction
{
	public OpImageTexelPointer() : base(nameof(OpImageTexelPointer), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Default),])
	{
	}
}
public class OpLoad : Instruction
{
	public OpLoad() : base(nameof(OpLoad), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpStore : Instruction
{
	public OpStore() : base(nameof(OpStore), [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpCopyMemory : Instruction
{
	public OpCopyMemory() : base(nameof(OpCopyMemory), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpCopyMemorySized : Instruction
{
	public OpCopyMemorySized() : base(nameof(OpCopyMemorySized), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Size", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpAccessChain : Instruction
{
	public OpAccessChain() : base(nameof(OpAccessChain), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpInBoundsAccessChain : Instruction
{
	public OpInBoundsAccessChain() : base(nameof(OpInBoundsAccessChain), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpPtrAccessChain : Instruction
{
	public OpPtrAccessChain() : base(nameof(OpPtrAccessChain), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpArrayLength : Instruction
{
	public OpArrayLength() : base(nameof(OpArrayLength), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Structure", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Array member", OperandQuantifier.Default),])
	{
	}
}
public class OpGenericPtrMemSemantics : Instruction
{
	public OpGenericPtrMemSemantics() : base(nameof(OpGenericPtrMemSemantics), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),])
	{
	}
}
public class OpInBoundsPtrAccessChain : Instruction
{
	public OpInBoundsPtrAccessChain() : base(nameof(OpInBoundsPtrAccessChain), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpDecorate : Instruction
{
	public OpDecorate() : base(nameof(OpDecorate), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpMemberDecorate : Instruction
{
	public OpMemberDecorate() : base(nameof(OpMemberDecorate), [new Operand(new IdRef(), "Structure Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpDecorationGroup : Instruction
{
	public OpDecorationGroup() : base(nameof(OpDecorationGroup), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpGroupDecorate : Instruction
{
	public OpGroupDecorate() : base(nameof(OpGroupDecorate), [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new IdRef(), "Targets", OperandQuantifier.Varying),])
	{
	}
}
public class OpGroupMemberDecorate : Instruction
{
	public OpGroupMemberDecorate() : base(nameof(OpGroupMemberDecorate), [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new PairIdRefLiteralInteger(), "Targets", OperandQuantifier.Varying),])
	{
	}
}
public class OpVectorExtractDynamic : Instruction
{
	public OpVectorExtractDynamic() : base(nameof(OpVectorExtractDynamic), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),])
	{
	}
}
public class OpVectorInsertDynamic : Instruction
{
	public OpVectorInsertDynamic() : base(nameof(OpVectorInsertDynamic), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),])
	{
	}
}
public class OpVectorShuffle : Instruction
{
	public OpVectorShuffle() : base(nameof(OpVectorShuffle), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Components", OperandQuantifier.Varying),])
	{
	}
}
public class OpCompositeConstruct : Instruction
{
	public OpCompositeConstruct() : base(nameof(OpCompositeConstruct), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),])
	{
	}
}
public class OpCompositeExtract : Instruction
{
	public OpCompositeExtract() : base(nameof(OpCompositeExtract), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpCompositeInsert : Instruction
{
	public OpCompositeInsert() : base(nameof(OpCompositeInsert), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),])
	{
	}
}
public class OpCopyObject : Instruction
{
	public OpCopyObject() : base(nameof(OpCopyObject), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpTranspose : Instruction
{
	public OpTranspose() : base(nameof(OpTranspose), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),])
	{
	}
}
public class OpSampledImage : Instruction
{
	public OpSampledImage() : base(nameof(OpSampledImage), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Sampler", OperandQuantifier.Default),])
	{
	}
}
public class OpImageSampleImplicitLod : Instruction
{
	public OpImageSampleImplicitLod() : base(nameof(OpImageSampleImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSampleExplicitLod : Instruction
{
	public OpImageSampleExplicitLod() : base(nameof(OpImageSampleExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSampleDrefImplicitLod : Instruction
{
	public OpImageSampleDrefImplicitLod() : base(nameof(OpImageSampleDrefImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSampleDrefExplicitLod : Instruction
{
	public OpImageSampleDrefExplicitLod() : base(nameof(OpImageSampleDrefExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSampleProjImplicitLod : Instruction
{
	public OpImageSampleProjImplicitLod() : base(nameof(OpImageSampleProjImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSampleProjExplicitLod : Instruction
{
	public OpImageSampleProjExplicitLod() : base(nameof(OpImageSampleProjExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSampleProjDrefImplicitLod : Instruction
{
	public OpImageSampleProjDrefImplicitLod() : base(nameof(OpImageSampleProjDrefImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSampleProjDrefExplicitLod : Instruction
{
	public OpImageSampleProjDrefExplicitLod() : base(nameof(OpImageSampleProjDrefExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageFetch : Instruction
{
	public OpImageFetch() : base(nameof(OpImageFetch), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageGather : Instruction
{
	public OpImageGather() : base(nameof(OpImageGather), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageDrefGather : Instruction
{
	public OpImageDrefGather() : base(nameof(OpImageDrefGather), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageRead : Instruction
{
	public OpImageRead() : base(nameof(OpImageRead), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageWrite : Instruction
{
	public OpImageWrite() : base(nameof(OpImageWrite), [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Texel", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImage : Instruction
{
	public OpImage() : base(nameof(OpImage), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQueryFormat : Instruction
{
	public OpImageQueryFormat() : base(nameof(OpImageQueryFormat), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQueryOrder : Instruction
{
	public OpImageQueryOrder() : base(nameof(OpImageQueryOrder), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQuerySizeLod : Instruction
{
	public OpImageQuerySizeLod() : base(nameof(OpImageQuerySizeLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Level of Detail", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQuerySize : Instruction
{
	public OpImageQuerySize() : base(nameof(OpImageQuerySize), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQueryLod : Instruction
{
	public OpImageQueryLod() : base(nameof(OpImageQueryLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQueryLevels : Instruction
{
	public OpImageQueryLevels() : base(nameof(OpImageQueryLevels), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),])
	{
	}
}
public class OpImageQuerySamples : Instruction
{
	public OpImageQuerySamples() : base(nameof(OpImageQuerySamples), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertFToU : Instruction
{
	public OpConvertFToU() : base(nameof(OpConvertFToU), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertFToS : Instruction
{
	public OpConvertFToS() : base(nameof(OpConvertFToS), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertSToF : Instruction
{
	public OpConvertSToF() : base(nameof(OpConvertSToF), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertUToF : Instruction
{
	public OpConvertUToF() : base(nameof(OpConvertUToF), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),])
	{
	}
}
public class OpUConvert : Instruction
{
	public OpUConvert() : base(nameof(OpUConvert), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),])
	{
	}
}
public class OpSConvert : Instruction
{
	public OpSConvert() : base(nameof(OpSConvert), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),])
	{
	}
}
public class OpFConvert : Instruction
{
	public OpFConvert() : base(nameof(OpFConvert), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),])
	{
	}
}
public class OpQuantizeToF16 : Instruction
{
	public OpQuantizeToF16() : base(nameof(OpQuantizeToF16), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertPtrToU : Instruction
{
	public OpConvertPtrToU() : base(nameof(OpConvertPtrToU), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),])
	{
	}
}
public class OpSatConvertSToU : Instruction
{
	public OpSatConvertSToU() : base(nameof(OpSatConvertSToU), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),])
	{
	}
}
public class OpSatConvertUToS : Instruction
{
	public OpSatConvertUToS() : base(nameof(OpSatConvertUToS), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),])
	{
	}
}
public class OpConvertUToPtr : Instruction
{
	public OpConvertUToPtr() : base(nameof(OpConvertUToPtr), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Integer Value", OperandQuantifier.Default),])
	{
	}
}
public class OpPtrCastToGeneric : Instruction
{
	public OpPtrCastToGeneric() : base(nameof(OpPtrCastToGeneric), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),])
	{
	}
}
public class OpGenericCastToPtr : Instruction
{
	public OpGenericCastToPtr() : base(nameof(OpGenericCastToPtr), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),])
	{
	}
}
public class OpGenericCastToPtrExplicit : Instruction
{
	public OpGenericCastToPtrExplicit() : base(nameof(OpGenericCastToPtrExplicit), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), "Storage", OperandQuantifier.Default),])
	{
	}
}
public class OpBitcast : Instruction
{
	public OpBitcast() : base(nameof(OpBitcast), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpSNegate : Instruction
{
	public OpSNegate() : base(nameof(OpSNegate), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpFNegate : Instruction
{
	public OpFNegate() : base(nameof(OpFNegate), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpIAdd : Instruction
{
	public OpIAdd() : base(nameof(OpIAdd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFAdd : Instruction
{
	public OpFAdd() : base(nameof(OpFAdd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpISub : Instruction
{
	public OpISub() : base(nameof(OpISub), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFSub : Instruction
{
	public OpFSub() : base(nameof(OpFSub), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpIMul : Instruction
{
	public OpIMul() : base(nameof(OpIMul), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFMul : Instruction
{
	public OpFMul() : base(nameof(OpFMul), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpUDiv : Instruction
{
	public OpUDiv() : base(nameof(OpUDiv), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSDiv : Instruction
{
	public OpSDiv() : base(nameof(OpSDiv), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFDiv : Instruction
{
	public OpFDiv() : base(nameof(OpFDiv), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpUMod : Instruction
{
	public OpUMod() : base(nameof(OpUMod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSRem : Instruction
{
	public OpSRem() : base(nameof(OpSRem), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSMod : Instruction
{
	public OpSMod() : base(nameof(OpSMod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFRem : Instruction
{
	public OpFRem() : base(nameof(OpFRem), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFMod : Instruction
{
	public OpFMod() : base(nameof(OpFMod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpVectorTimesScalar : Instruction
{
	public OpVectorTimesScalar() : base(nameof(OpVectorTimesScalar), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),])
	{
	}
}
public class OpMatrixTimesScalar : Instruction
{
	public OpMatrixTimesScalar() : base(nameof(OpMatrixTimesScalar), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),])
	{
	}
}
public class OpVectorTimesMatrix : Instruction
{
	public OpVectorTimesMatrix() : base(nameof(OpVectorTimesMatrix), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),])
	{
	}
}
public class OpMatrixTimesVector : Instruction
{
	public OpMatrixTimesVector() : base(nameof(OpMatrixTimesVector), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),])
	{
	}
}
public class OpMatrixTimesMatrix : Instruction
{
	public OpMatrixTimesMatrix() : base(nameof(OpMatrixTimesMatrix), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "LeftMatrix", OperandQuantifier.Default), new Operand(new IdRef(), "RightMatrix", OperandQuantifier.Default),])
	{
	}
}
public class OpOuterProduct : Instruction
{
	public OpOuterProduct() : base(nameof(OpOuterProduct), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),])
	{
	}
}
public class OpDot : Instruction
{
	public OpDot() : base(nameof(OpDot), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),])
	{
	}
}
public class OpIAddCarry : Instruction
{
	public OpIAddCarry() : base(nameof(OpIAddCarry), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpISubBorrow : Instruction
{
	public OpISubBorrow() : base(nameof(OpISubBorrow), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpUMulExtended : Instruction
{
	public OpUMulExtended() : base(nameof(OpUMulExtended), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSMulExtended : Instruction
{
	public OpSMulExtended() : base(nameof(OpSMulExtended), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpAny : Instruction
{
	public OpAny() : base(nameof(OpAny), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),])
	{
	}
}
public class OpAll : Instruction
{
	public OpAll() : base(nameof(OpAll), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),])
	{
	}
}
public class OpIsNan : Instruction
{
	public OpIsNan() : base(nameof(OpIsNan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),])
	{
	}
}
public class OpIsInf : Instruction
{
	public OpIsInf() : base(nameof(OpIsInf), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),])
	{
	}
}
public class OpIsFinite : Instruction
{
	public OpIsFinite() : base(nameof(OpIsFinite), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),])
	{
	}
}
public class OpIsNormal : Instruction
{
	public OpIsNormal() : base(nameof(OpIsNormal), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),])
	{
	}
}
public class OpSignBitSet : Instruction
{
	public OpSignBitSet() : base(nameof(OpSignBitSet), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),])
	{
	}
}
public class OpLessOrGreater : Instruction
{
	public OpLessOrGreater() : base(nameof(OpLessOrGreater), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),])
	{
	}
}
public class OpOrdered : Instruction
{
	public OpOrdered() : base(nameof(OpOrdered), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),])
	{
	}
}
public class OpUnordered : Instruction
{
	public OpUnordered() : base(nameof(OpUnordered), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),])
	{
	}
}
public class OpLogicalEqual : Instruction
{
	public OpLogicalEqual() : base(nameof(OpLogicalEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpLogicalNotEqual : Instruction
{
	public OpLogicalNotEqual() : base(nameof(OpLogicalNotEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpLogicalOr : Instruction
{
	public OpLogicalOr() : base(nameof(OpLogicalOr), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpLogicalAnd : Instruction
{
	public OpLogicalAnd() : base(nameof(OpLogicalAnd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpLogicalNot : Instruction
{
	public OpLogicalNot() : base(nameof(OpLogicalNot), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpSelect : Instruction
{
	public OpSelect() : base(nameof(OpSelect), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "Object 1", OperandQuantifier.Default), new Operand(new IdRef(), "Object 2", OperandQuantifier.Default),])
	{
	}
}
public class OpIEqual : Instruction
{
	public OpIEqual() : base(nameof(OpIEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpINotEqual : Instruction
{
	public OpINotEqual() : base(nameof(OpINotEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpUGreaterThan : Instruction
{
	public OpUGreaterThan() : base(nameof(OpUGreaterThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSGreaterThan : Instruction
{
	public OpSGreaterThan() : base(nameof(OpSGreaterThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpUGreaterThanEqual : Instruction
{
	public OpUGreaterThanEqual() : base(nameof(OpUGreaterThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSGreaterThanEqual : Instruction
{
	public OpSGreaterThanEqual() : base(nameof(OpSGreaterThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpULessThan : Instruction
{
	public OpULessThan() : base(nameof(OpULessThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSLessThan : Instruction
{
	public OpSLessThan() : base(nameof(OpSLessThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpULessThanEqual : Instruction
{
	public OpULessThanEqual() : base(nameof(OpULessThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpSLessThanEqual : Instruction
{
	public OpSLessThanEqual() : base(nameof(OpSLessThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdEqual : Instruction
{
	public OpFOrdEqual() : base(nameof(OpFOrdEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordEqual : Instruction
{
	public OpFUnordEqual() : base(nameof(OpFUnordEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdNotEqual : Instruction
{
	public OpFOrdNotEqual() : base(nameof(OpFOrdNotEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordNotEqual : Instruction
{
	public OpFUnordNotEqual() : base(nameof(OpFUnordNotEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdLessThan : Instruction
{
	public OpFOrdLessThan() : base(nameof(OpFOrdLessThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordLessThan : Instruction
{
	public OpFUnordLessThan() : base(nameof(OpFUnordLessThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdGreaterThan : Instruction
{
	public OpFOrdGreaterThan() : base(nameof(OpFOrdGreaterThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordGreaterThan : Instruction
{
	public OpFUnordGreaterThan() : base(nameof(OpFUnordGreaterThan), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdLessThanEqual : Instruction
{
	public OpFOrdLessThanEqual() : base(nameof(OpFOrdLessThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordLessThanEqual : Instruction
{
	public OpFUnordLessThanEqual() : base(nameof(OpFUnordLessThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFOrdGreaterThanEqual : Instruction
{
	public OpFOrdGreaterThanEqual() : base(nameof(OpFOrdGreaterThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpFUnordGreaterThanEqual : Instruction
{
	public OpFUnordGreaterThanEqual() : base(nameof(OpFUnordGreaterThanEqual), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpShiftRightLogical : Instruction
{
	public OpShiftRightLogical() : base(nameof(OpShiftRightLogical), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),])
	{
	}
}
public class OpShiftRightArithmetic : Instruction
{
	public OpShiftRightArithmetic() : base(nameof(OpShiftRightArithmetic), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),])
	{
	}
}
public class OpShiftLeftLogical : Instruction
{
	public OpShiftLeftLogical() : base(nameof(OpShiftLeftLogical), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),])
	{
	}
}
public class OpBitwiseOr : Instruction
{
	public OpBitwiseOr() : base(nameof(OpBitwiseOr), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpBitwiseXor : Instruction
{
	public OpBitwiseXor() : base(nameof(OpBitwiseXor), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpBitwiseAnd : Instruction
{
	public OpBitwiseAnd() : base(nameof(OpBitwiseAnd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),])
	{
	}
}
public class OpNot : Instruction
{
	public OpNot() : base(nameof(OpNot), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),])
	{
	}
}
public class OpBitFieldInsert : Instruction
{
	public OpBitFieldInsert() : base(nameof(OpBitFieldInsert), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Insert", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),])
	{
	}
}
public class OpBitFieldSExtract : Instruction
{
	public OpBitFieldSExtract() : base(nameof(OpBitFieldSExtract), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),])
	{
	}
}
public class OpBitFieldUExtract : Instruction
{
	public OpBitFieldUExtract() : base(nameof(OpBitFieldUExtract), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),])
	{
	}
}
public class OpBitReverse : Instruction
{
	public OpBitReverse() : base(nameof(OpBitReverse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),])
	{
	}
}
public class OpBitCount : Instruction
{
	public OpBitCount() : base(nameof(OpBitCount), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdx : Instruction
{
	public OpDPdx() : base(nameof(OpDPdx), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdy : Instruction
{
	public OpDPdy() : base(nameof(OpDPdy), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpFwidth : Instruction
{
	public OpFwidth() : base(nameof(OpFwidth), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdxFine : Instruction
{
	public OpDPdxFine() : base(nameof(OpDPdxFine), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdyFine : Instruction
{
	public OpDPdyFine() : base(nameof(OpDPdyFine), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpFwidthFine : Instruction
{
	public OpFwidthFine() : base(nameof(OpFwidthFine), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdxCoarse : Instruction
{
	public OpDPdxCoarse() : base(nameof(OpDPdxCoarse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpDPdyCoarse : Instruction
{
	public OpDPdyCoarse() : base(nameof(OpDPdyCoarse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpFwidthCoarse : Instruction
{
	public OpFwidthCoarse() : base(nameof(OpFwidthCoarse), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),])
	{
	}
}
public class OpEmitVertex : Instruction
{
	public OpEmitVertex() : base(nameof(OpEmitVertex))
	{
	}
}
public class OpEndPrimitive : Instruction
{
	public OpEndPrimitive() : base(nameof(OpEndPrimitive))
	{
	}
}
public class OpEmitStreamVertex : Instruction
{
	public OpEmitStreamVertex() : base(nameof(OpEmitStreamVertex), [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),])
	{
	}
}
public class OpEndStreamPrimitive : Instruction
{
	public OpEndStreamPrimitive() : base(nameof(OpEndStreamPrimitive), [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),])
	{
	}
}
public class OpControlBarrier : Instruction
{
	public OpControlBarrier() : base(nameof(OpControlBarrier), [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpMemoryBarrier : Instruction
{
	public OpMemoryBarrier() : base(nameof(OpMemoryBarrier), [new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicLoad : Instruction
{
	public OpAtomicLoad() : base(nameof(OpAtomicLoad), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicStore : Instruction
{
	public OpAtomicStore() : base(nameof(OpAtomicStore), [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicExchange : Instruction
{
	public OpAtomicExchange() : base(nameof(OpAtomicExchange), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicCompareExchange : Instruction
{
	public OpAtomicCompareExchange() : base(nameof(OpAtomicCompareExchange), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicCompareExchangeWeak : Instruction
{
	public OpAtomicCompareExchangeWeak() : base(nameof(OpAtomicCompareExchangeWeak), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicIIncrement : Instruction
{
	public OpAtomicIIncrement() : base(nameof(OpAtomicIIncrement), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicIDecrement : Instruction
{
	public OpAtomicIDecrement() : base(nameof(OpAtomicIDecrement), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicIAdd : Instruction
{
	public OpAtomicIAdd() : base(nameof(OpAtomicIAdd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicISub : Instruction
{
	public OpAtomicISub() : base(nameof(OpAtomicISub), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicSMin : Instruction
{
	public OpAtomicSMin() : base(nameof(OpAtomicSMin), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicUMin : Instruction
{
	public OpAtomicUMin() : base(nameof(OpAtomicUMin), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicSMax : Instruction
{
	public OpAtomicSMax() : base(nameof(OpAtomicSMax), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicUMax : Instruction
{
	public OpAtomicUMax() : base(nameof(OpAtomicUMax), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicAnd : Instruction
{
	public OpAtomicAnd() : base(nameof(OpAtomicAnd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicOr : Instruction
{
	public OpAtomicOr() : base(nameof(OpAtomicOr), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicXor : Instruction
{
	public OpAtomicXor() : base(nameof(OpAtomicXor), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpPhi : Instruction
{
	public OpPhi() : base(nameof(OpPhi), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new PairIdRefIdRef(), "Variable, Parent, ...", OperandQuantifier.Varying),])
	{
	}
}
public class OpLoopMerge : Instruction
{
	public OpLoopMerge() : base(nameof(OpLoopMerge), [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new IdRef(), "Continue Target", OperandQuantifier.Default), new Operand(new EnumType<LoopControl, LoopControlParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSelectionMerge : Instruction
{
	public OpSelectionMerge() : base(nameof(OpSelectionMerge), [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new EnumType<SelectionControl, SelectionControlParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpLabel : Instruction
{
	public OpLabel() : base(nameof(OpLabel), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpBranch : Instruction
{
	public OpBranch() : base(nameof(OpBranch), [new Operand(new IdRef(), "Target Label", OperandQuantifier.Default),])
	{
	}
}
public class OpBranchConditional : Instruction
{
	public OpBranchConditional() : base(nameof(OpBranchConditional), [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "True Label", OperandQuantifier.Default), new Operand(new IdRef(), "False Label", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Branch weights", OperandQuantifier.Varying),])
	{
	}
}
public class OpSwitch : Instruction
{
	public OpSwitch() : base(nameof(OpSwitch), [new Operand(new IdRef(), "Selector", OperandQuantifier.Default), new Operand(new IdRef(), "Default", OperandQuantifier.Default), new Operand(new PairLiteralIntegerIdRef(), "Target", OperandQuantifier.Varying),])
	{
	}
}
public class OpKill : Instruction
{
	public OpKill() : base(nameof(OpKill))
	{
	}
}
public class OpReturn : Instruction
{
	public OpReturn() : base(nameof(OpReturn))
	{
	}
}
public class OpReturnValue : Instruction
{
	public OpReturnValue() : base(nameof(OpReturnValue), [new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpUnreachable : Instruction
{
	public OpUnreachable() : base(nameof(OpUnreachable))
	{
	}
}
public class OpLifetimeStart : Instruction
{
	public OpLifetimeStart() : base(nameof(OpLifetimeStart), [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),])
	{
	}
}
public class OpLifetimeStop : Instruction
{
	public OpLifetimeStop() : base(nameof(OpLifetimeStop), [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupAsyncCopy : Instruction
{
	public OpGroupAsyncCopy() : base(nameof(OpGroupAsyncCopy), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Destination", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Num Elements", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupWaitEvents : Instruction
{
	public OpGroupWaitEvents() : base(nameof(OpGroupWaitEvents), [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Events List", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupAll : Instruction
{
	public OpGroupAll() : base(nameof(OpGroupAll), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupAny : Instruction
{
	public OpGroupAny() : base(nameof(OpGroupAny), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupBroadcast : Instruction
{
	public OpGroupBroadcast() : base(nameof(OpGroupBroadcast), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "LocalId", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupIAdd : Instruction
{
	public OpGroupIAdd() : base(nameof(OpGroupIAdd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFAdd : Instruction
{
	public OpGroupFAdd() : base(nameof(OpGroupFAdd), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFMin : Instruction
{
	public OpGroupFMin() : base(nameof(OpGroupFMin), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupUMin : Instruction
{
	public OpGroupUMin() : base(nameof(OpGroupUMin), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupSMin : Instruction
{
	public OpGroupSMin() : base(nameof(OpGroupSMin), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFMax : Instruction
{
	public OpGroupFMax() : base(nameof(OpGroupFMax), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupUMax : Instruction
{
	public OpGroupUMax() : base(nameof(OpGroupUMax), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupSMax : Instruction
{
	public OpGroupSMax() : base(nameof(OpGroupSMax), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpReadPipe : Instruction
{
	public OpReadPipe() : base(nameof(OpReadPipe), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpWritePipe : Instruction
{
	public OpWritePipe() : base(nameof(OpWritePipe), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpReservedReadPipe : Instruction
{
	public OpReservedReadPipe() : base(nameof(OpReservedReadPipe), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpReservedWritePipe : Instruction
{
	public OpReservedWritePipe() : base(nameof(OpReservedWritePipe), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpReserveReadPipePackets : Instruction
{
	public OpReserveReadPipePackets() : base(nameof(OpReserveReadPipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpReserveWritePipePackets : Instruction
{
	public OpReserveWritePipePackets() : base(nameof(OpReserveWritePipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpCommitReadPipe : Instruction
{
	public OpCommitReadPipe() : base(nameof(OpCommitReadPipe), [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpCommitWritePipe : Instruction
{
	public OpCommitWritePipe() : base(nameof(OpCommitWritePipe), [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpIsValidReserveId : Instruction
{
	public OpIsValidReserveId() : base(nameof(OpIsValidReserveId), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default),])
	{
	}
}
public class OpGetNumPipePackets : Instruction
{
	public OpGetNumPipePackets() : base(nameof(OpGetNumPipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpGetMaxPipePackets : Instruction
{
	public OpGetMaxPipePackets() : base(nameof(OpGetMaxPipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupReserveReadPipePackets : Instruction
{
	public OpGroupReserveReadPipePackets() : base(nameof(OpGroupReserveReadPipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupReserveWritePipePackets : Instruction
{
	public OpGroupReserveWritePipePackets() : base(nameof(OpGroupReserveWritePipePackets), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupCommitReadPipe : Instruction
{
	public OpGroupCommitReadPipe() : base(nameof(OpGroupCommitReadPipe), [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupCommitWritePipe : Instruction
{
	public OpGroupCommitWritePipe() : base(nameof(OpGroupCommitWritePipe), [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),])
	{
	}
}
public class OpEnqueueMarker : Instruction
{
	public OpEnqueueMarker() : base(nameof(OpEnqueueMarker), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default),])
	{
	}
}
public class OpEnqueueKernel : Instruction
{
	public OpEnqueueKernel() : base(nameof(OpEnqueueKernel), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Flags", OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default), new Operand(new IdRef(), "Local Size", OperandQuantifier.Varying),])
	{
	}
}
public class OpGetKernelNDrangeSubGroupCount : Instruction
{
	public OpGetKernelNDrangeSubGroupCount() : base(nameof(OpGetKernelNDrangeSubGroupCount), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpGetKernelNDrangeMaxSubGroupSize : Instruction
{
	public OpGetKernelNDrangeMaxSubGroupSize() : base(nameof(OpGetKernelNDrangeMaxSubGroupSize), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpGetKernelWorkGroupSize : Instruction
{
	public OpGetKernelWorkGroupSize() : base(nameof(OpGetKernelWorkGroupSize), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpGetKernelPreferredWorkGroupSizeMultiple : Instruction
{
	public OpGetKernelPreferredWorkGroupSizeMultiple() : base(nameof(OpGetKernelPreferredWorkGroupSizeMultiple), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpRetainEvent : Instruction
{
	public OpRetainEvent() : base(nameof(OpRetainEvent), [new Operand(new IdRef(), "Event", OperandQuantifier.Default),])
	{
	}
}
public class OpReleaseEvent : Instruction
{
	public OpReleaseEvent() : base(nameof(OpReleaseEvent), [new Operand(new IdRef(), "Event", OperandQuantifier.Default),])
	{
	}
}
public class OpCreateUserEvent : Instruction
{
	public OpCreateUserEvent() : base(nameof(OpCreateUserEvent), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpIsValidEvent : Instruction
{
	public OpIsValidEvent() : base(nameof(OpIsValidEvent), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),])
	{
	}
}
public class OpSetUserEventStatus : Instruction
{
	public OpSetUserEventStatus() : base(nameof(OpSetUserEventStatus), [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Status", OperandQuantifier.Default),])
	{
	}
}
public class OpCaptureEventProfilingInfo : Instruction
{
	public OpCaptureEventProfilingInfo() : base(nameof(OpCaptureEventProfilingInfo), [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Profiling Info", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpGetDefaultQueue : Instruction
{
	public OpGetDefaultQueue() : base(nameof(OpGetDefaultQueue), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpBuildNDRange : Instruction
{
	public OpBuildNDRange() : base(nameof(OpBuildNDRange), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "LocalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkOffset", OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseSampleImplicitLod : Instruction
{
	public OpImageSparseSampleImplicitLod() : base(nameof(OpImageSparseSampleImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseSampleExplicitLod : Instruction
{
	public OpImageSparseSampleExplicitLod() : base(nameof(OpImageSparseSampleExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseSampleDrefImplicitLod : Instruction
{
	public OpImageSparseSampleDrefImplicitLod() : base(nameof(OpImageSparseSampleDrefImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseSampleDrefExplicitLod : Instruction
{
	public OpImageSparseSampleDrefExplicitLod() : base(nameof(OpImageSparseSampleDrefExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseSampleProjImplicitLod : Instruction
{
	public OpImageSparseSampleProjImplicitLod() : base(nameof(OpImageSparseSampleProjImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseSampleProjExplicitLod : Instruction
{
	public OpImageSparseSampleProjExplicitLod() : base(nameof(OpImageSparseSampleProjExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseSampleProjDrefImplicitLod : Instruction
{
	public OpImageSparseSampleProjDrefImplicitLod() : base(nameof(OpImageSparseSampleProjDrefImplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseSampleProjDrefExplicitLod : Instruction
{
	public OpImageSparseSampleProjDrefExplicitLod() : base(nameof(OpImageSparseSampleProjDrefExplicitLod), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseFetch : Instruction
{
	public OpImageSparseFetch() : base(nameof(OpImageSparseFetch), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseGather : Instruction
{
	public OpImageSparseGather() : base(nameof(OpImageSparseGather), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseDrefGather : Instruction
{
	public OpImageSparseDrefGather() : base(nameof(OpImageSparseDrefGather), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpImageSparseTexelsResident : Instruction
{
	public OpImageSparseTexelsResident() : base(nameof(OpImageSparseTexelsResident), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Resident Code", OperandQuantifier.Default),])
	{
	}
}
public class OpNoLine : Instruction
{
	public OpNoLine() : base(nameof(OpNoLine))
	{
	}
}
public class OpAtomicFlagTestAndSet : Instruction
{
	public OpAtomicFlagTestAndSet() : base(nameof(OpAtomicFlagTestAndSet), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpAtomicFlagClear : Instruction
{
	public OpAtomicFlagClear() : base(nameof(OpAtomicFlagClear), [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpImageSparseRead : Instruction
{
	public OpImageSparseRead() : base(nameof(OpImageSparseRead), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),])
	{
	}
}
public class OpSizeOf : Instruction
{
	public OpSizeOf() : base(nameof(OpSizeOf), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),])
	{
	}
}
public class OpTypePipeStorage : Instruction
{
	public OpTypePipeStorage() : base(nameof(OpTypePipeStorage), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpConstantPipeStorage : Instruction
{
	public OpConstantPipeStorage() : base(nameof(OpConstantPipeStorage), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Size", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Alignment", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Capacity", OperandQuantifier.Default),])
	{
	}
}
public class OpCreatePipeFromPipeStorage : Instruction
{
	public OpCreatePipeFromPipeStorage() : base(nameof(OpCreatePipeFromPipeStorage), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe Storage", OperandQuantifier.Default),])
	{
	}
}
public class OpGetKernelLocalSizeForSubgroupCount : Instruction
{
	public OpGetKernelLocalSizeForSubgroupCount() : base(nameof(OpGetKernelLocalSizeForSubgroupCount), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpGetKernelMaxNumSubgroups : Instruction
{
	public OpGetKernelMaxNumSubgroups() : base(nameof(OpGetKernelMaxNumSubgroups), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),])
	{
	}
}
public class OpTypeNamedBarrier : Instruction
{
	public OpTypeNamedBarrier() : base(nameof(OpTypeNamedBarrier), [new Operand(new IdResult(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpNamedBarrierInitialize : Instruction
{
	public OpNamedBarrierInitialize() : base(nameof(OpNamedBarrierInitialize), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default),])
	{
	}
}
public class OpMemoryNamedBarrier : Instruction
{
	public OpMemoryNamedBarrier() : base(nameof(OpMemoryNamedBarrier), [new Operand(new IdRef(), "Named Barrier", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),])
	{
	}
}
public class OpModuleProcessed : Instruction
{
	public OpModuleProcessed() : base(nameof(OpModuleProcessed), [new Operand(new LiteralString(), "Process", OperandQuantifier.Default),])
	{
	}
}
public class OpExecutionModeId : Instruction
{
	public OpExecutionModeId() : base(nameof(OpExecutionModeId), [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),])
	{
	}
}
public class OpDecorateId : Instruction
{
	public OpDecorateId() : base(nameof(OpDecorateId), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupBallotKHR : Instruction
{
	public OpSubgroupBallotKHR() : base(nameof(OpSubgroupBallotKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupFirstInvocationKHR : Instruction
{
	public OpSubgroupFirstInvocationKHR() : base(nameof(OpSubgroupFirstInvocationKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupAllKHR : Instruction
{
	public OpSubgroupAllKHR() : base(nameof(OpSubgroupAllKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupAnyKHR : Instruction
{
	public OpSubgroupAnyKHR() : base(nameof(OpSubgroupAnyKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupAllEqualKHR : Instruction
{
	public OpSubgroupAllEqualKHR() : base(nameof(OpSubgroupAllEqualKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupReadInvocationKHR : Instruction
{
	public OpSubgroupReadInvocationKHR() : base(nameof(OpSubgroupReadInvocationKHR), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupIAddNonUniformAMD : Instruction
{
	public OpGroupIAddNonUniformAMD() : base(nameof(OpGroupIAddNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFAddNonUniformAMD : Instruction
{
	public OpGroupFAddNonUniformAMD() : base(nameof(OpGroupFAddNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFMinNonUniformAMD : Instruction
{
	public OpGroupFMinNonUniformAMD() : base(nameof(OpGroupFMinNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupUMinNonUniformAMD : Instruction
{
	public OpGroupUMinNonUniformAMD() : base(nameof(OpGroupUMinNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupSMinNonUniformAMD : Instruction
{
	public OpGroupSMinNonUniformAMD() : base(nameof(OpGroupSMinNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupFMaxNonUniformAMD : Instruction
{
	public OpGroupFMaxNonUniformAMD() : base(nameof(OpGroupFMaxNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupUMaxNonUniformAMD : Instruction
{
	public OpGroupUMaxNonUniformAMD() : base(nameof(OpGroupUMaxNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpGroupSMaxNonUniformAMD : Instruction
{
	public OpGroupSMaxNonUniformAMD() : base(nameof(OpGroupSMaxNonUniformAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),])
	{
	}
}
public class OpFragmentMaskFetchAMD : Instruction
{
	public OpFragmentMaskFetchAMD() : base(nameof(OpFragmentMaskFetchAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),])
	{
	}
}
public class OpFragmentFetchAMD : Instruction
{
	public OpFragmentFetchAMD() : base(nameof(OpFragmentFetchAMD), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Fragment Index", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupShuffleINTEL : Instruction
{
	public OpSubgroupShuffleINTEL() : base(nameof(OpSubgroupShuffleINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "InvocationId", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupShuffleDownINTEL : Instruction
{
	public OpSubgroupShuffleDownINTEL() : base(nameof(OpSubgroupShuffleDownINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Next", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupShuffleUpINTEL : Instruction
{
	public OpSubgroupShuffleUpINTEL() : base(nameof(OpSubgroupShuffleUpINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Previous", OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupShuffleXorINTEL : Instruction
{
	public OpSubgroupShuffleXorINTEL() : base(nameof(OpSubgroupShuffleXorINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupBlockReadINTEL : Instruction
{
	public OpSubgroupBlockReadINTEL() : base(nameof(OpSubgroupBlockReadINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Ptr", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupBlockWriteINTEL : Instruction
{
	public OpSubgroupBlockWriteINTEL() : base(nameof(OpSubgroupBlockWriteINTEL), [new Operand(new IdRef(), "Ptr", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupImageBlockReadINTEL : Instruction
{
	public OpSubgroupImageBlockReadINTEL() : base(nameof(OpSubgroupImageBlockReadINTEL), [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),])
	{
	}
}
public class OpSubgroupImageBlockWriteINTEL : Instruction
{
	public OpSubgroupImageBlockWriteINTEL() : base(nameof(OpSubgroupImageBlockWriteINTEL), [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),])
	{
	}
}
public class OpDecorateStringGOOGLE : Instruction
{
	public OpDecorateStringGOOGLE() : base(nameof(OpDecorateStringGOOGLE), [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public class OpMemberDecorateStringGOOGLE : Instruction
{
	public OpMemberDecorateStringGOOGLE() : base(nameof(OpMemberDecorateStringGOOGLE), [new Operand(new IdRef(), "Struct Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),])
	{
	}
}
public static class Instructions
{
	public static IReadOnlyDictionary<int, Instruction> OpcodeToInstruction { get; } = new Dictionary<int, Instruction>()
	{
		{
			0,
			new OpNop()
		},
		{
			1,
			new OpUndef()
		},
		{
			2,
			new OpSourceContinued()
		},
		{
			3,
			new OpSource()
		},
		{
			4,
			new OpSourceExtension()
		},
		{
			5,
			new OpName()
		},
		{
			6,
			new OpMemberName()
		},
		{
			7,
			new OpString()
		},
		{
			8,
			new OpLine()
		},
		{
			10,
			new OpExtension()
		},
		{
			11,
			new OpExtInstImport()
		},
		{
			12,
			new OpExtInst()
		},
		{
			14,
			new OpMemoryModel()
		},
		{
			15,
			new OpEntryPoint()
		},
		{
			16,
			new OpExecutionMode()
		},
		{
			17,
			new OpCapability()
		},
		{
			19,
			new OpTypeVoid()
		},
		{
			20,
			new OpTypeBool()
		},
		{
			21,
			new OpTypeInt()
		},
		{
			22,
			new OpTypeFloat()
		},
		{
			23,
			new OpTypeVector()
		},
		{
			24,
			new OpTypeMatrix()
		},
		{
			25,
			new OpTypeImage()
		},
		{
			26,
			new OpTypeSampler()
		},
		{
			27,
			new OpTypeSampledImage()
		},
		{
			28,
			new OpTypeArray()
		},
		{
			29,
			new OpTypeRuntimeArray()
		},
		{
			30,
			new OpTypeStruct()
		},
		{
			31,
			new OpTypeOpaque()
		},
		{
			32,
			new OpTypePointer()
		},
		{
			33,
			new OpTypeFunction()
		},
		{
			34,
			new OpTypeEvent()
		},
		{
			35,
			new OpTypeDeviceEvent()
		},
		{
			36,
			new OpTypeReserveId()
		},
		{
			37,
			new OpTypeQueue()
		},
		{
			38,
			new OpTypePipe()
		},
		{
			39,
			new OpTypeForwardPointer()
		},
		{
			41,
			new OpConstantTrue()
		},
		{
			42,
			new OpConstantFalse()
		},
		{
			43,
			new OpConstant()
		},
		{
			44,
			new OpConstantComposite()
		},
		{
			45,
			new OpConstantSampler()
		},
		{
			46,
			new OpConstantNull()
		},
		{
			48,
			new OpSpecConstantTrue()
		},
		{
			49,
			new OpSpecConstantFalse()
		},
		{
			50,
			new OpSpecConstant()
		},
		{
			51,
			new OpSpecConstantComposite()
		},
		{
			52,
			new OpSpecConstantOp()
		},
		{
			54,
			new OpFunction()
		},
		{
			55,
			new OpFunctionParameter()
		},
		{
			56,
			new OpFunctionEnd()
		},
		{
			57,
			new OpFunctionCall()
		},
		{
			59,
			new OpVariable()
		},
		{
			60,
			new OpImageTexelPointer()
		},
		{
			61,
			new OpLoad()
		},
		{
			62,
			new OpStore()
		},
		{
			63,
			new OpCopyMemory()
		},
		{
			64,
			new OpCopyMemorySized()
		},
		{
			65,
			new OpAccessChain()
		},
		{
			66,
			new OpInBoundsAccessChain()
		},
		{
			67,
			new OpPtrAccessChain()
		},
		{
			68,
			new OpArrayLength()
		},
		{
			69,
			new OpGenericPtrMemSemantics()
		},
		{
			70,
			new OpInBoundsPtrAccessChain()
		},
		{
			71,
			new OpDecorate()
		},
		{
			72,
			new OpMemberDecorate()
		},
		{
			73,
			new OpDecorationGroup()
		},
		{
			74,
			new OpGroupDecorate()
		},
		{
			75,
			new OpGroupMemberDecorate()
		},
		{
			77,
			new OpVectorExtractDynamic()
		},
		{
			78,
			new OpVectorInsertDynamic()
		},
		{
			79,
			new OpVectorShuffle()
		},
		{
			80,
			new OpCompositeConstruct()
		},
		{
			81,
			new OpCompositeExtract()
		},
		{
			82,
			new OpCompositeInsert()
		},
		{
			83,
			new OpCopyObject()
		},
		{
			84,
			new OpTranspose()
		},
		{
			86,
			new OpSampledImage()
		},
		{
			87,
			new OpImageSampleImplicitLod()
		},
		{
			88,
			new OpImageSampleExplicitLod()
		},
		{
			89,
			new OpImageSampleDrefImplicitLod()
		},
		{
			90,
			new OpImageSampleDrefExplicitLod()
		},
		{
			91,
			new OpImageSampleProjImplicitLod()
		},
		{
			92,
			new OpImageSampleProjExplicitLod()
		},
		{
			93,
			new OpImageSampleProjDrefImplicitLod()
		},
		{
			94,
			new OpImageSampleProjDrefExplicitLod()
		},
		{
			95,
			new OpImageFetch()
		},
		{
			96,
			new OpImageGather()
		},
		{
			97,
			new OpImageDrefGather()
		},
		{
			98,
			new OpImageRead()
		},
		{
			99,
			new OpImageWrite()
		},
		{
			100,
			new OpImage()
		},
		{
			101,
			new OpImageQueryFormat()
		},
		{
			102,
			new OpImageQueryOrder()
		},
		{
			103,
			new OpImageQuerySizeLod()
		},
		{
			104,
			new OpImageQuerySize()
		},
		{
			105,
			new OpImageQueryLod()
		},
		{
			106,
			new OpImageQueryLevels()
		},
		{
			107,
			new OpImageQuerySamples()
		},
		{
			109,
			new OpConvertFToU()
		},
		{
			110,
			new OpConvertFToS()
		},
		{
			111,
			new OpConvertSToF()
		},
		{
			112,
			new OpConvertUToF()
		},
		{
			113,
			new OpUConvert()
		},
		{
			114,
			new OpSConvert()
		},
		{
			115,
			new OpFConvert()
		},
		{
			116,
			new OpQuantizeToF16()
		},
		{
			117,
			new OpConvertPtrToU()
		},
		{
			118,
			new OpSatConvertSToU()
		},
		{
			119,
			new OpSatConvertUToS()
		},
		{
			120,
			new OpConvertUToPtr()
		},
		{
			121,
			new OpPtrCastToGeneric()
		},
		{
			122,
			new OpGenericCastToPtr()
		},
		{
			123,
			new OpGenericCastToPtrExplicit()
		},
		{
			124,
			new OpBitcast()
		},
		{
			126,
			new OpSNegate()
		},
		{
			127,
			new OpFNegate()
		},
		{
			128,
			new OpIAdd()
		},
		{
			129,
			new OpFAdd()
		},
		{
			130,
			new OpISub()
		},
		{
			131,
			new OpFSub()
		},
		{
			132,
			new OpIMul()
		},
		{
			133,
			new OpFMul()
		},
		{
			134,
			new OpUDiv()
		},
		{
			135,
			new OpSDiv()
		},
		{
			136,
			new OpFDiv()
		},
		{
			137,
			new OpUMod()
		},
		{
			138,
			new OpSRem()
		},
		{
			139,
			new OpSMod()
		},
		{
			140,
			new OpFRem()
		},
		{
			141,
			new OpFMod()
		},
		{
			142,
			new OpVectorTimesScalar()
		},
		{
			143,
			new OpMatrixTimesScalar()
		},
		{
			144,
			new OpVectorTimesMatrix()
		},
		{
			145,
			new OpMatrixTimesVector()
		},
		{
			146,
			new OpMatrixTimesMatrix()
		},
		{
			147,
			new OpOuterProduct()
		},
		{
			148,
			new OpDot()
		},
		{
			149,
			new OpIAddCarry()
		},
		{
			150,
			new OpISubBorrow()
		},
		{
			151,
			new OpUMulExtended()
		},
		{
			152,
			new OpSMulExtended()
		},
		{
			154,
			new OpAny()
		},
		{
			155,
			new OpAll()
		},
		{
			156,
			new OpIsNan()
		},
		{
			157,
			new OpIsInf()
		},
		{
			158,
			new OpIsFinite()
		},
		{
			159,
			new OpIsNormal()
		},
		{
			160,
			new OpSignBitSet()
		},
		{
			161,
			new OpLessOrGreater()
		},
		{
			162,
			new OpOrdered()
		},
		{
			163,
			new OpUnordered()
		},
		{
			164,
			new OpLogicalEqual()
		},
		{
			165,
			new OpLogicalNotEqual()
		},
		{
			166,
			new OpLogicalOr()
		},
		{
			167,
			new OpLogicalAnd()
		},
		{
			168,
			new OpLogicalNot()
		},
		{
			169,
			new OpSelect()
		},
		{
			170,
			new OpIEqual()
		},
		{
			171,
			new OpINotEqual()
		},
		{
			172,
			new OpUGreaterThan()
		},
		{
			173,
			new OpSGreaterThan()
		},
		{
			174,
			new OpUGreaterThanEqual()
		},
		{
			175,
			new OpSGreaterThanEqual()
		},
		{
			176,
			new OpULessThan()
		},
		{
			177,
			new OpSLessThan()
		},
		{
			178,
			new OpULessThanEqual()
		},
		{
			179,
			new OpSLessThanEqual()
		},
		{
			180,
			new OpFOrdEqual()
		},
		{
			181,
			new OpFUnordEqual()
		},
		{
			182,
			new OpFOrdNotEqual()
		},
		{
			183,
			new OpFUnordNotEqual()
		},
		{
			184,
			new OpFOrdLessThan()
		},
		{
			185,
			new OpFUnordLessThan()
		},
		{
			186,
			new OpFOrdGreaterThan()
		},
		{
			187,
			new OpFUnordGreaterThan()
		},
		{
			188,
			new OpFOrdLessThanEqual()
		},
		{
			189,
			new OpFUnordLessThanEqual()
		},
		{
			190,
			new OpFOrdGreaterThanEqual()
		},
		{
			191,
			new OpFUnordGreaterThanEqual()
		},
		{
			194,
			new OpShiftRightLogical()
		},
		{
			195,
			new OpShiftRightArithmetic()
		},
		{
			196,
			new OpShiftLeftLogical()
		},
		{
			197,
			new OpBitwiseOr()
		},
		{
			198,
			new OpBitwiseXor()
		},
		{
			199,
			new OpBitwiseAnd()
		},
		{
			200,
			new OpNot()
		},
		{
			201,
			new OpBitFieldInsert()
		},
		{
			202,
			new OpBitFieldSExtract()
		},
		{
			203,
			new OpBitFieldUExtract()
		},
		{
			204,
			new OpBitReverse()
		},
		{
			205,
			new OpBitCount()
		},
		{
			207,
			new OpDPdx()
		},
		{
			208,
			new OpDPdy()
		},
		{
			209,
			new OpFwidth()
		},
		{
			210,
			new OpDPdxFine()
		},
		{
			211,
			new OpDPdyFine()
		},
		{
			212,
			new OpFwidthFine()
		},
		{
			213,
			new OpDPdxCoarse()
		},
		{
			214,
			new OpDPdyCoarse()
		},
		{
			215,
			new OpFwidthCoarse()
		},
		{
			218,
			new OpEmitVertex()
		},
		{
			219,
			new OpEndPrimitive()
		},
		{
			220,
			new OpEmitStreamVertex()
		},
		{
			221,
			new OpEndStreamPrimitive()
		},
		{
			224,
			new OpControlBarrier()
		},
		{
			225,
			new OpMemoryBarrier()
		},
		{
			227,
			new OpAtomicLoad()
		},
		{
			228,
			new OpAtomicStore()
		},
		{
			229,
			new OpAtomicExchange()
		},
		{
			230,
			new OpAtomicCompareExchange()
		},
		{
			231,
			new OpAtomicCompareExchangeWeak()
		},
		{
			232,
			new OpAtomicIIncrement()
		},
		{
			233,
			new OpAtomicIDecrement()
		},
		{
			234,
			new OpAtomicIAdd()
		},
		{
			235,
			new OpAtomicISub()
		},
		{
			236,
			new OpAtomicSMin()
		},
		{
			237,
			new OpAtomicUMin()
		},
		{
			238,
			new OpAtomicSMax()
		},
		{
			239,
			new OpAtomicUMax()
		},
		{
			240,
			new OpAtomicAnd()
		},
		{
			241,
			new OpAtomicOr()
		},
		{
			242,
			new OpAtomicXor()
		},
		{
			245,
			new OpPhi()
		},
		{
			246,
			new OpLoopMerge()
		},
		{
			247,
			new OpSelectionMerge()
		},
		{
			248,
			new OpLabel()
		},
		{
			249,
			new OpBranch()
		},
		{
			250,
			new OpBranchConditional()
		},
		{
			251,
			new OpSwitch()
		},
		{
			252,
			new OpKill()
		},
		{
			253,
			new OpReturn()
		},
		{
			254,
			new OpReturnValue()
		},
		{
			255,
			new OpUnreachable()
		},
		{
			256,
			new OpLifetimeStart()
		},
		{
			257,
			new OpLifetimeStop()
		},
		{
			259,
			new OpGroupAsyncCopy()
		},
		{
			260,
			new OpGroupWaitEvents()
		},
		{
			261,
			new OpGroupAll()
		},
		{
			262,
			new OpGroupAny()
		},
		{
			263,
			new OpGroupBroadcast()
		},
		{
			264,
			new OpGroupIAdd()
		},
		{
			265,
			new OpGroupFAdd()
		},
		{
			266,
			new OpGroupFMin()
		},
		{
			267,
			new OpGroupUMin()
		},
		{
			268,
			new OpGroupSMin()
		},
		{
			269,
			new OpGroupFMax()
		},
		{
			270,
			new OpGroupUMax()
		},
		{
			271,
			new OpGroupSMax()
		},
		{
			274,
			new OpReadPipe()
		},
		{
			275,
			new OpWritePipe()
		},
		{
			276,
			new OpReservedReadPipe()
		},
		{
			277,
			new OpReservedWritePipe()
		},
		{
			278,
			new OpReserveReadPipePackets()
		},
		{
			279,
			new OpReserveWritePipePackets()
		},
		{
			280,
			new OpCommitReadPipe()
		},
		{
			281,
			new OpCommitWritePipe()
		},
		{
			282,
			new OpIsValidReserveId()
		},
		{
			283,
			new OpGetNumPipePackets()
		},
		{
			284,
			new OpGetMaxPipePackets()
		},
		{
			285,
			new OpGroupReserveReadPipePackets()
		},
		{
			286,
			new OpGroupReserveWritePipePackets()
		},
		{
			287,
			new OpGroupCommitReadPipe()
		},
		{
			288,
			new OpGroupCommitWritePipe()
		},
		{
			291,
			new OpEnqueueMarker()
		},
		{
			292,
			new OpEnqueueKernel()
		},
		{
			293,
			new OpGetKernelNDrangeSubGroupCount()
		},
		{
			294,
			new OpGetKernelNDrangeMaxSubGroupSize()
		},
		{
			295,
			new OpGetKernelWorkGroupSize()
		},
		{
			296,
			new OpGetKernelPreferredWorkGroupSizeMultiple()
		},
		{
			297,
			new OpRetainEvent()
		},
		{
			298,
			new OpReleaseEvent()
		},
		{
			299,
			new OpCreateUserEvent()
		},
		{
			300,
			new OpIsValidEvent()
		},
		{
			301,
			new OpSetUserEventStatus()
		},
		{
			302,
			new OpCaptureEventProfilingInfo()
		},
		{
			303,
			new OpGetDefaultQueue()
		},
		{
			304,
			new OpBuildNDRange()
		},
		{
			305,
			new OpImageSparseSampleImplicitLod()
		},
		{
			306,
			new OpImageSparseSampleExplicitLod()
		},
		{
			307,
			new OpImageSparseSampleDrefImplicitLod()
		},
		{
			308,
			new OpImageSparseSampleDrefExplicitLod()
		},
		{
			309,
			new OpImageSparseSampleProjImplicitLod()
		},
		{
			310,
			new OpImageSparseSampleProjExplicitLod()
		},
		{
			311,
			new OpImageSparseSampleProjDrefImplicitLod()
		},
		{
			312,
			new OpImageSparseSampleProjDrefExplicitLod()
		},
		{
			313,
			new OpImageSparseFetch()
		},
		{
			314,
			new OpImageSparseGather()
		},
		{
			315,
			new OpImageSparseDrefGather()
		},
		{
			316,
			new OpImageSparseTexelsResident()
		},
		{
			317,
			new OpNoLine()
		},
		{
			318,
			new OpAtomicFlagTestAndSet()
		},
		{
			319,
			new OpAtomicFlagClear()
		},
		{
			320,
			new OpImageSparseRead()
		},
		{
			321,
			new OpSizeOf()
		},
		{
			322,
			new OpTypePipeStorage()
		},
		{
			323,
			new OpConstantPipeStorage()
		},
		{
			324,
			new OpCreatePipeFromPipeStorage()
		},
		{
			325,
			new OpGetKernelLocalSizeForSubgroupCount()
		},
		{
			326,
			new OpGetKernelMaxNumSubgroups()
		},
		{
			327,
			new OpTypeNamedBarrier()
		},
		{
			328,
			new OpNamedBarrierInitialize()
		},
		{
			329,
			new OpMemoryNamedBarrier()
		},
		{
			330,
			new OpModuleProcessed()
		},
		{
			331,
			new OpExecutionModeId()
		},
		{
			332,
			new OpDecorateId()
		},
		{
			4421,
			new OpSubgroupBallotKHR()
		},
		{
			4422,
			new OpSubgroupFirstInvocationKHR()
		},
		{
			4428,
			new OpSubgroupAllKHR()
		},
		{
			4429,
			new OpSubgroupAnyKHR()
		},
		{
			4430,
			new OpSubgroupAllEqualKHR()
		},
		{
			4432,
			new OpSubgroupReadInvocationKHR()
		},
		{
			5000,
			new OpGroupIAddNonUniformAMD()
		},
		{
			5001,
			new OpGroupFAddNonUniformAMD()
		},
		{
			5002,
			new OpGroupFMinNonUniformAMD()
		},
		{
			5003,
			new OpGroupUMinNonUniformAMD()
		},
		{
			5004,
			new OpGroupSMinNonUniformAMD()
		},
		{
			5005,
			new OpGroupFMaxNonUniformAMD()
		},
		{
			5006,
			new OpGroupUMaxNonUniformAMD()
		},
		{
			5007,
			new OpGroupSMaxNonUniformAMD()
		},
		{
			5011,
			new OpFragmentMaskFetchAMD()
		},
		{
			5012,
			new OpFragmentFetchAMD()
		},
		{
			5571,
			new OpSubgroupShuffleINTEL()
		},
		{
			5572,
			new OpSubgroupShuffleDownINTEL()
		},
		{
			5573,
			new OpSubgroupShuffleUpINTEL()
		},
		{
			5574,
			new OpSubgroupShuffleXorINTEL()
		},
		{
			5575,
			new OpSubgroupBlockReadINTEL()
		},
		{
			5576,
			new OpSubgroupBlockWriteINTEL()
		},
		{
			5577,
			new OpSubgroupImageBlockReadINTEL()
		},
		{
			5578,
			new OpSubgroupImageBlockWriteINTEL()
		},
		{
			5632,
			new OpDecorateStringGOOGLE()
		},
		{
			5633,
			new OpMemberDecorateStringGOOGLE()
		},
	};
}