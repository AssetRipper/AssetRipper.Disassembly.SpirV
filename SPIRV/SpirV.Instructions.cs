using System;
using System.Collections.Generic;

namespace SpirV;

public enum OpCode
{
	OpNop = 0,
	OpUndef = 1,
	OpSourceContinued = 2,
	OpSource = 3,
	OpSourceExtension = 4,
	OpName = 5,
	OpMemberName = 6,
	OpString = 7,
	OpLine = 8,
	OpExtension = 10,
	OpExtInstImport = 11,
	OpExtInst = 12,
	OpMemoryModel = 14,
	OpEntryPoint = 15,
	OpExecutionMode = 16,
	OpCapability = 17,
	OpTypeVoid = 19,
	OpTypeBool = 20,
	OpTypeInt = 21,
	OpTypeFloat = 22,
	OpTypeVector = 23,
	OpTypeMatrix = 24,
	OpTypeImage = 25,
	OpTypeSampler = 26,
	OpTypeSampledImage = 27,
	OpTypeArray = 28,
	OpTypeRuntimeArray = 29,
	OpTypeStruct = 30,
	OpTypeOpaque = 31,
	OpTypePointer = 32,
	OpTypeFunction = 33,
	OpTypeEvent = 34,
	OpTypeDeviceEvent = 35,
	OpTypeReserveId = 36,
	OpTypeQueue = 37,
	OpTypePipe = 38,
	OpTypeForwardPointer = 39,
	OpConstantTrue = 41,
	OpConstantFalse = 42,
	OpConstant = 43,
	OpConstantComposite = 44,
	OpConstantSampler = 45,
	OpConstantNull = 46,
	OpSpecConstantTrue = 48,
	OpSpecConstantFalse = 49,
	OpSpecConstant = 50,
	OpSpecConstantComposite = 51,
	OpSpecConstantOp = 52,
	OpFunction = 54,
	OpFunctionParameter = 55,
	OpFunctionEnd = 56,
	OpFunctionCall = 57,
	OpVariable = 59,
	OpImageTexelPointer = 60,
	OpLoad = 61,
	OpStore = 62,
	OpCopyMemory = 63,
	OpCopyMemorySized = 64,
	OpAccessChain = 65,
	OpInBoundsAccessChain = 66,
	OpPtrAccessChain = 67,
	OpArrayLength = 68,
	OpGenericPtrMemSemantics = 69,
	OpInBoundsPtrAccessChain = 70,
	OpDecorate = 71,
	OpMemberDecorate = 72,
	OpDecorationGroup = 73,
	OpGroupDecorate = 74,
	OpGroupMemberDecorate = 75,
	OpVectorExtractDynamic = 77,
	OpVectorInsertDynamic = 78,
	OpVectorShuffle = 79,
	OpCompositeConstruct = 80,
	OpCompositeExtract = 81,
	OpCompositeInsert = 82,
	OpCopyObject = 83,
	OpTranspose = 84,
	OpSampledImage = 86,
	OpImageSampleImplicitLod = 87,
	OpImageSampleExplicitLod = 88,
	OpImageSampleDrefImplicitLod = 89,
	OpImageSampleDrefExplicitLod = 90,
	OpImageSampleProjImplicitLod = 91,
	OpImageSampleProjExplicitLod = 92,
	OpImageSampleProjDrefImplicitLod = 93,
	OpImageSampleProjDrefExplicitLod = 94,
	OpImageFetch = 95,
	OpImageGather = 96,
	OpImageDrefGather = 97,
	OpImageRead = 98,
	OpImageWrite = 99,
	OpImage = 100,
	OpImageQueryFormat = 101,
	OpImageQueryOrder = 102,
	OpImageQuerySizeLod = 103,
	OpImageQuerySize = 104,
	OpImageQueryLod = 105,
	OpImageQueryLevels = 106,
	OpImageQuerySamples = 107,
	OpConvertFToU = 109,
	OpConvertFToS = 110,
	OpConvertSToF = 111,
	OpConvertUToF = 112,
	OpUConvert = 113,
	OpSConvert = 114,
	OpFConvert = 115,
	OpQuantizeToF16 = 116,
	OpConvertPtrToU = 117,
	OpSatConvertSToU = 118,
	OpSatConvertUToS = 119,
	OpConvertUToPtr = 120,
	OpPtrCastToGeneric = 121,
	OpGenericCastToPtr = 122,
	OpGenericCastToPtrExplicit = 123,
	OpBitcast = 124,
	OpSNegate = 126,
	OpFNegate = 127,
	OpIAdd = 128,
	OpFAdd = 129,
	OpISub = 130,
	OpFSub = 131,
	OpIMul = 132,
	OpFMul = 133,
	OpUDiv = 134,
	OpSDiv = 135,
	OpFDiv = 136,
	OpUMod = 137,
	OpSRem = 138,
	OpSMod = 139,
	OpFRem = 140,
	OpFMod = 141,
	OpVectorTimesScalar = 142,
	OpMatrixTimesScalar = 143,
	OpVectorTimesMatrix = 144,
	OpMatrixTimesVector = 145,
	OpMatrixTimesMatrix = 146,
	OpOuterProduct = 147,
	OpDot = 148,
	OpIAddCarry = 149,
	OpISubBorrow = 150,
	OpUMulExtended = 151,
	OpSMulExtended = 152,
	OpAny = 154,
	OpAll = 155,
	OpIsNan = 156,
	OpIsInf = 157,
	OpIsFinite = 158,
	OpIsNormal = 159,
	OpSignBitSet = 160,
	OpLessOrGreater = 161,
	OpOrdered = 162,
	OpUnordered = 163,
	OpLogicalEqual = 164,
	OpLogicalNotEqual = 165,
	OpLogicalOr = 166,
	OpLogicalAnd = 167,
	OpLogicalNot = 168,
	OpSelect = 169,
	OpIEqual = 170,
	OpINotEqual = 171,
	OpUGreaterThan = 172,
	OpSGreaterThan = 173,
	OpUGreaterThanEqual = 174,
	OpSGreaterThanEqual = 175,
	OpULessThan = 176,
	OpSLessThan = 177,
	OpULessThanEqual = 178,
	OpSLessThanEqual = 179,
	OpFOrdEqual = 180,
	OpFUnordEqual = 181,
	OpFOrdNotEqual = 182,
	OpFUnordNotEqual = 183,
	OpFOrdLessThan = 184,
	OpFUnordLessThan = 185,
	OpFOrdGreaterThan = 186,
	OpFUnordGreaterThan = 187,
	OpFOrdLessThanEqual = 188,
	OpFUnordLessThanEqual = 189,
	OpFOrdGreaterThanEqual = 190,
	OpFUnordGreaterThanEqual = 191,
	OpShiftRightLogical = 194,
	OpShiftRightArithmetic = 195,
	OpShiftLeftLogical = 196,
	OpBitwiseOr = 197,
	OpBitwiseXor = 198,
	OpBitwiseAnd = 199,
	OpNot = 200,
	OpBitFieldInsert = 201,
	OpBitFieldSExtract = 202,
	OpBitFieldUExtract = 203,
	OpBitReverse = 204,
	OpBitCount = 205,
	OpDPdx = 207,
	OpDPdy = 208,
	OpFwidth = 209,
	OpDPdxFine = 210,
	OpDPdyFine = 211,
	OpFwidthFine = 212,
	OpDPdxCoarse = 213,
	OpDPdyCoarse = 214,
	OpFwidthCoarse = 215,
	OpEmitVertex = 218,
	OpEndPrimitive = 219,
	OpEmitStreamVertex = 220,
	OpEndStreamPrimitive = 221,
	OpControlBarrier = 224,
	OpMemoryBarrier = 225,
	OpAtomicLoad = 227,
	OpAtomicStore = 228,
	OpAtomicExchange = 229,
	OpAtomicCompareExchange = 230,
	OpAtomicCompareExchangeWeak = 231,
	OpAtomicIIncrement = 232,
	OpAtomicIDecrement = 233,
	OpAtomicIAdd = 234,
	OpAtomicISub = 235,
	OpAtomicSMin = 236,
	OpAtomicUMin = 237,
	OpAtomicSMax = 238,
	OpAtomicUMax = 239,
	OpAtomicAnd = 240,
	OpAtomicOr = 241,
	OpAtomicXor = 242,
	OpPhi = 245,
	OpLoopMerge = 246,
	OpSelectionMerge = 247,
	OpLabel = 248,
	OpBranch = 249,
	OpBranchConditional = 250,
	OpSwitch = 251,
	OpKill = 252,
	OpReturn = 253,
	OpReturnValue = 254,
	OpUnreachable = 255,
	OpLifetimeStart = 256,
	OpLifetimeStop = 257,
	OpGroupAsyncCopy = 259,
	OpGroupWaitEvents = 260,
	OpGroupAll = 261,
	OpGroupAny = 262,
	OpGroupBroadcast = 263,
	OpGroupIAdd = 264,
	OpGroupFAdd = 265,
	OpGroupFMin = 266,
	OpGroupUMin = 267,
	OpGroupSMin = 268,
	OpGroupFMax = 269,
	OpGroupUMax = 270,
	OpGroupSMax = 271,
	OpReadPipe = 274,
	OpWritePipe = 275,
	OpReservedReadPipe = 276,
	OpReservedWritePipe = 277,
	OpReserveReadPipePackets = 278,
	OpReserveWritePipePackets = 279,
	OpCommitReadPipe = 280,
	OpCommitWritePipe = 281,
	OpIsValidReserveId = 282,
	OpGetNumPipePackets = 283,
	OpGetMaxPipePackets = 284,
	OpGroupReserveReadPipePackets = 285,
	OpGroupReserveWritePipePackets = 286,
	OpGroupCommitReadPipe = 287,
	OpGroupCommitWritePipe = 288,
	OpEnqueueMarker = 291,
	OpEnqueueKernel = 292,
	OpGetKernelNDrangeSubGroupCount = 293,
	OpGetKernelNDrangeMaxSubGroupSize = 294,
	OpGetKernelWorkGroupSize = 295,
	OpGetKernelPreferredWorkGroupSizeMultiple = 296,
	OpRetainEvent = 297,
	OpReleaseEvent = 298,
	OpCreateUserEvent = 299,
	OpIsValidEvent = 300,
	OpSetUserEventStatus = 301,
	OpCaptureEventProfilingInfo = 302,
	OpGetDefaultQueue = 303,
	OpBuildNDRange = 304,
	OpImageSparseSampleImplicitLod = 305,
	OpImageSparseSampleExplicitLod = 306,
	OpImageSparseSampleDrefImplicitLod = 307,
	OpImageSparseSampleDrefExplicitLod = 308,
	OpImageSparseSampleProjImplicitLod = 309,
	OpImageSparseSampleProjExplicitLod = 310,
	OpImageSparseSampleProjDrefImplicitLod = 311,
	OpImageSparseSampleProjDrefExplicitLod = 312,
	OpImageSparseFetch = 313,
	OpImageSparseGather = 314,
	OpImageSparseDrefGather = 315,
	OpImageSparseTexelsResident = 316,
	OpNoLine = 317,
	OpAtomicFlagTestAndSet = 318,
	OpAtomicFlagClear = 319,
	OpImageSparseRead = 320,
	OpSizeOf = 321,
	OpTypePipeStorage = 322,
	OpConstantPipeStorage = 323,
	OpCreatePipeFromPipeStorage = 324,
	OpGetKernelLocalSizeForSubgroupCount = 325,
	OpGetKernelMaxNumSubgroups = 326,
	OpTypeNamedBarrier = 327,
	OpNamedBarrierInitialize = 328,
	OpMemoryNamedBarrier = 329,
	OpModuleProcessed = 330,
	OpExecutionModeId = 331,
	OpDecorateId = 332,
	OpSubgroupBallotKHR = 4421,
	OpSubgroupFirstInvocationKHR = 4422,
	OpSubgroupAllKHR = 4428,
	OpSubgroupAnyKHR = 4429,
	OpSubgroupAllEqualKHR = 4430,
	OpSubgroupReadInvocationKHR = 4432,
	OpGroupIAddNonUniformAMD = 5000,
	OpGroupFAddNonUniformAMD = 5001,
	OpGroupFMinNonUniformAMD = 5002,
	OpGroupUMinNonUniformAMD = 5003,
	OpGroupSMinNonUniformAMD = 5004,
	OpGroupFMaxNonUniformAMD = 5005,
	OpGroupUMaxNonUniformAMD = 5006,
	OpGroupSMaxNonUniformAMD = 5007,
	OpFragmentMaskFetchAMD = 5011,
	OpFragmentFetchAMD = 5012,
	OpSubgroupShuffleINTEL = 5571,
	OpSubgroupShuffleDownINTEL = 5572,
	OpSubgroupShuffleUpINTEL = 5573,
	OpSubgroupShuffleXorINTEL = 5574,
	OpSubgroupBlockReadINTEL = 5575,
	OpSubgroupBlockWriteINTEL = 5576,
	OpSubgroupImageBlockReadINTEL = 5577,
	OpSubgroupImageBlockWriteINTEL = 5578,
	OpDecorateStringGOOGLE = 5632,
	OpMemberDecorateStringGOOGLE = 5633,
}
public static class Instructions
{
	public static Instruction ToInstruction(this OpCode code) => code switch
	{
		OpCode.OpNop => OpNop.Instance,
		OpCode.OpUndef => OpUndef.Instance,
		OpCode.OpSourceContinued => OpSourceContinued.Instance,
		OpCode.OpSource => OpSource.Instance,
		OpCode.OpSourceExtension => OpSourceExtension.Instance,
		OpCode.OpName => OpName.Instance,
		OpCode.OpMemberName => OpMemberName.Instance,
		OpCode.OpString => OpString.Instance,
		OpCode.OpLine => OpLine.Instance,
		OpCode.OpExtension => OpExtension.Instance,
		OpCode.OpExtInstImport => OpExtInstImport.Instance,
		OpCode.OpExtInst => OpExtInst.Instance,
		OpCode.OpMemoryModel => OpMemoryModel.Instance,
		OpCode.OpEntryPoint => OpEntryPoint.Instance,
		OpCode.OpExecutionMode => OpExecutionMode.Instance,
		OpCode.OpCapability => OpCapability.Instance,
		OpCode.OpTypeVoid => OpTypeVoid.Instance,
		OpCode.OpTypeBool => OpTypeBool.Instance,
		OpCode.OpTypeInt => OpTypeInt.Instance,
		OpCode.OpTypeFloat => OpTypeFloat.Instance,
		OpCode.OpTypeVector => OpTypeVector.Instance,
		OpCode.OpTypeMatrix => OpTypeMatrix.Instance,
		OpCode.OpTypeImage => OpTypeImage.Instance,
		OpCode.OpTypeSampler => OpTypeSampler.Instance,
		OpCode.OpTypeSampledImage => OpTypeSampledImage.Instance,
		OpCode.OpTypeArray => OpTypeArray.Instance,
		OpCode.OpTypeRuntimeArray => OpTypeRuntimeArray.Instance,
		OpCode.OpTypeStruct => OpTypeStruct.Instance,
		OpCode.OpTypeOpaque => OpTypeOpaque.Instance,
		OpCode.OpTypePointer => OpTypePointer.Instance,
		OpCode.OpTypeFunction => OpTypeFunction.Instance,
		OpCode.OpTypeEvent => OpTypeEvent.Instance,
		OpCode.OpTypeDeviceEvent => OpTypeDeviceEvent.Instance,
		OpCode.OpTypeReserveId => OpTypeReserveId.Instance,
		OpCode.OpTypeQueue => OpTypeQueue.Instance,
		OpCode.OpTypePipe => OpTypePipe.Instance,
		OpCode.OpTypeForwardPointer => OpTypeForwardPointer.Instance,
		OpCode.OpConstantTrue => OpConstantTrue.Instance,
		OpCode.OpConstantFalse => OpConstantFalse.Instance,
		OpCode.OpConstant => OpConstant.Instance,
		OpCode.OpConstantComposite => OpConstantComposite.Instance,
		OpCode.OpConstantSampler => OpConstantSampler.Instance,
		OpCode.OpConstantNull => OpConstantNull.Instance,
		OpCode.OpSpecConstantTrue => OpSpecConstantTrue.Instance,
		OpCode.OpSpecConstantFalse => OpSpecConstantFalse.Instance,
		OpCode.OpSpecConstant => OpSpecConstant.Instance,
		OpCode.OpSpecConstantComposite => OpSpecConstantComposite.Instance,
		OpCode.OpSpecConstantOp => OpSpecConstantOp.Instance,
		OpCode.OpFunction => OpFunction.Instance,
		OpCode.OpFunctionParameter => OpFunctionParameter.Instance,
		OpCode.OpFunctionEnd => OpFunctionEnd.Instance,
		OpCode.OpFunctionCall => OpFunctionCall.Instance,
		OpCode.OpVariable => OpVariable.Instance,
		OpCode.OpImageTexelPointer => OpImageTexelPointer.Instance,
		OpCode.OpLoad => OpLoad.Instance,
		OpCode.OpStore => OpStore.Instance,
		OpCode.OpCopyMemory => OpCopyMemory.Instance,
		OpCode.OpCopyMemorySized => OpCopyMemorySized.Instance,
		OpCode.OpAccessChain => OpAccessChain.Instance,
		OpCode.OpInBoundsAccessChain => OpInBoundsAccessChain.Instance,
		OpCode.OpPtrAccessChain => OpPtrAccessChain.Instance,
		OpCode.OpArrayLength => OpArrayLength.Instance,
		OpCode.OpGenericPtrMemSemantics => OpGenericPtrMemSemantics.Instance,
		OpCode.OpInBoundsPtrAccessChain => OpInBoundsPtrAccessChain.Instance,
		OpCode.OpDecorate => OpDecorate.Instance,
		OpCode.OpMemberDecorate => OpMemberDecorate.Instance,
		OpCode.OpDecorationGroup => OpDecorationGroup.Instance,
		OpCode.OpGroupDecorate => OpGroupDecorate.Instance,
		OpCode.OpGroupMemberDecorate => OpGroupMemberDecorate.Instance,
		OpCode.OpVectorExtractDynamic => OpVectorExtractDynamic.Instance,
		OpCode.OpVectorInsertDynamic => OpVectorInsertDynamic.Instance,
		OpCode.OpVectorShuffle => OpVectorShuffle.Instance,
		OpCode.OpCompositeConstruct => OpCompositeConstruct.Instance,
		OpCode.OpCompositeExtract => OpCompositeExtract.Instance,
		OpCode.OpCompositeInsert => OpCompositeInsert.Instance,
		OpCode.OpCopyObject => OpCopyObject.Instance,
		OpCode.OpTranspose => OpTranspose.Instance,
		OpCode.OpSampledImage => OpSampledImage.Instance,
		OpCode.OpImageSampleImplicitLod => OpImageSampleImplicitLod.Instance,
		OpCode.OpImageSampleExplicitLod => OpImageSampleExplicitLod.Instance,
		OpCode.OpImageSampleDrefImplicitLod => OpImageSampleDrefImplicitLod.Instance,
		OpCode.OpImageSampleDrefExplicitLod => OpImageSampleDrefExplicitLod.Instance,
		OpCode.OpImageSampleProjImplicitLod => OpImageSampleProjImplicitLod.Instance,
		OpCode.OpImageSampleProjExplicitLod => OpImageSampleProjExplicitLod.Instance,
		OpCode.OpImageSampleProjDrefImplicitLod => OpImageSampleProjDrefImplicitLod.Instance,
		OpCode.OpImageSampleProjDrefExplicitLod => OpImageSampleProjDrefExplicitLod.Instance,
		OpCode.OpImageFetch => OpImageFetch.Instance,
		OpCode.OpImageGather => OpImageGather.Instance,
		OpCode.OpImageDrefGather => OpImageDrefGather.Instance,
		OpCode.OpImageRead => OpImageRead.Instance,
		OpCode.OpImageWrite => OpImageWrite.Instance,
		OpCode.OpImage => OpImage.Instance,
		OpCode.OpImageQueryFormat => OpImageQueryFormat.Instance,
		OpCode.OpImageQueryOrder => OpImageQueryOrder.Instance,
		OpCode.OpImageQuerySizeLod => OpImageQuerySizeLod.Instance,
		OpCode.OpImageQuerySize => OpImageQuerySize.Instance,
		OpCode.OpImageQueryLod => OpImageQueryLod.Instance,
		OpCode.OpImageQueryLevels => OpImageQueryLevels.Instance,
		OpCode.OpImageQuerySamples => OpImageQuerySamples.Instance,
		OpCode.OpConvertFToU => OpConvertFToU.Instance,
		OpCode.OpConvertFToS => OpConvertFToS.Instance,
		OpCode.OpConvertSToF => OpConvertSToF.Instance,
		OpCode.OpConvertUToF => OpConvertUToF.Instance,
		OpCode.OpUConvert => OpUConvert.Instance,
		OpCode.OpSConvert => OpSConvert.Instance,
		OpCode.OpFConvert => OpFConvert.Instance,
		OpCode.OpQuantizeToF16 => OpQuantizeToF16.Instance,
		OpCode.OpConvertPtrToU => OpConvertPtrToU.Instance,
		OpCode.OpSatConvertSToU => OpSatConvertSToU.Instance,
		OpCode.OpSatConvertUToS => OpSatConvertUToS.Instance,
		OpCode.OpConvertUToPtr => OpConvertUToPtr.Instance,
		OpCode.OpPtrCastToGeneric => OpPtrCastToGeneric.Instance,
		OpCode.OpGenericCastToPtr => OpGenericCastToPtr.Instance,
		OpCode.OpGenericCastToPtrExplicit => OpGenericCastToPtrExplicit.Instance,
		OpCode.OpBitcast => OpBitcast.Instance,
		OpCode.OpSNegate => OpSNegate.Instance,
		OpCode.OpFNegate => OpFNegate.Instance,
		OpCode.OpIAdd => OpIAdd.Instance,
		OpCode.OpFAdd => OpFAdd.Instance,
		OpCode.OpISub => OpISub.Instance,
		OpCode.OpFSub => OpFSub.Instance,
		OpCode.OpIMul => OpIMul.Instance,
		OpCode.OpFMul => OpFMul.Instance,
		OpCode.OpUDiv => OpUDiv.Instance,
		OpCode.OpSDiv => OpSDiv.Instance,
		OpCode.OpFDiv => OpFDiv.Instance,
		OpCode.OpUMod => OpUMod.Instance,
		OpCode.OpSRem => OpSRem.Instance,
		OpCode.OpSMod => OpSMod.Instance,
		OpCode.OpFRem => OpFRem.Instance,
		OpCode.OpFMod => OpFMod.Instance,
		OpCode.OpVectorTimesScalar => OpVectorTimesScalar.Instance,
		OpCode.OpMatrixTimesScalar => OpMatrixTimesScalar.Instance,
		OpCode.OpVectorTimesMatrix => OpVectorTimesMatrix.Instance,
		OpCode.OpMatrixTimesVector => OpMatrixTimesVector.Instance,
		OpCode.OpMatrixTimesMatrix => OpMatrixTimesMatrix.Instance,
		OpCode.OpOuterProduct => OpOuterProduct.Instance,
		OpCode.OpDot => OpDot.Instance,
		OpCode.OpIAddCarry => OpIAddCarry.Instance,
		OpCode.OpISubBorrow => OpISubBorrow.Instance,
		OpCode.OpUMulExtended => OpUMulExtended.Instance,
		OpCode.OpSMulExtended => OpSMulExtended.Instance,
		OpCode.OpAny => OpAny.Instance,
		OpCode.OpAll => OpAll.Instance,
		OpCode.OpIsNan => OpIsNan.Instance,
		OpCode.OpIsInf => OpIsInf.Instance,
		OpCode.OpIsFinite => OpIsFinite.Instance,
		OpCode.OpIsNormal => OpIsNormal.Instance,
		OpCode.OpSignBitSet => OpSignBitSet.Instance,
		OpCode.OpLessOrGreater => OpLessOrGreater.Instance,
		OpCode.OpOrdered => OpOrdered.Instance,
		OpCode.OpUnordered => OpUnordered.Instance,
		OpCode.OpLogicalEqual => OpLogicalEqual.Instance,
		OpCode.OpLogicalNotEqual => OpLogicalNotEqual.Instance,
		OpCode.OpLogicalOr => OpLogicalOr.Instance,
		OpCode.OpLogicalAnd => OpLogicalAnd.Instance,
		OpCode.OpLogicalNot => OpLogicalNot.Instance,
		OpCode.OpSelect => OpSelect.Instance,
		OpCode.OpIEqual => OpIEqual.Instance,
		OpCode.OpINotEqual => OpINotEqual.Instance,
		OpCode.OpUGreaterThan => OpUGreaterThan.Instance,
		OpCode.OpSGreaterThan => OpSGreaterThan.Instance,
		OpCode.OpUGreaterThanEqual => OpUGreaterThanEqual.Instance,
		OpCode.OpSGreaterThanEqual => OpSGreaterThanEqual.Instance,
		OpCode.OpULessThan => OpULessThan.Instance,
		OpCode.OpSLessThan => OpSLessThan.Instance,
		OpCode.OpULessThanEqual => OpULessThanEqual.Instance,
		OpCode.OpSLessThanEqual => OpSLessThanEqual.Instance,
		OpCode.OpFOrdEqual => OpFOrdEqual.Instance,
		OpCode.OpFUnordEqual => OpFUnordEqual.Instance,
		OpCode.OpFOrdNotEqual => OpFOrdNotEqual.Instance,
		OpCode.OpFUnordNotEqual => OpFUnordNotEqual.Instance,
		OpCode.OpFOrdLessThan => OpFOrdLessThan.Instance,
		OpCode.OpFUnordLessThan => OpFUnordLessThan.Instance,
		OpCode.OpFOrdGreaterThan => OpFOrdGreaterThan.Instance,
		OpCode.OpFUnordGreaterThan => OpFUnordGreaterThan.Instance,
		OpCode.OpFOrdLessThanEqual => OpFOrdLessThanEqual.Instance,
		OpCode.OpFUnordLessThanEqual => OpFUnordLessThanEqual.Instance,
		OpCode.OpFOrdGreaterThanEqual => OpFOrdGreaterThanEqual.Instance,
		OpCode.OpFUnordGreaterThanEqual => OpFUnordGreaterThanEqual.Instance,
		OpCode.OpShiftRightLogical => OpShiftRightLogical.Instance,
		OpCode.OpShiftRightArithmetic => OpShiftRightArithmetic.Instance,
		OpCode.OpShiftLeftLogical => OpShiftLeftLogical.Instance,
		OpCode.OpBitwiseOr => OpBitwiseOr.Instance,
		OpCode.OpBitwiseXor => OpBitwiseXor.Instance,
		OpCode.OpBitwiseAnd => OpBitwiseAnd.Instance,
		OpCode.OpNot => OpNot.Instance,
		OpCode.OpBitFieldInsert => OpBitFieldInsert.Instance,
		OpCode.OpBitFieldSExtract => OpBitFieldSExtract.Instance,
		OpCode.OpBitFieldUExtract => OpBitFieldUExtract.Instance,
		OpCode.OpBitReverse => OpBitReverse.Instance,
		OpCode.OpBitCount => OpBitCount.Instance,
		OpCode.OpDPdx => OpDPdx.Instance,
		OpCode.OpDPdy => OpDPdy.Instance,
		OpCode.OpFwidth => OpFwidth.Instance,
		OpCode.OpDPdxFine => OpDPdxFine.Instance,
		OpCode.OpDPdyFine => OpDPdyFine.Instance,
		OpCode.OpFwidthFine => OpFwidthFine.Instance,
		OpCode.OpDPdxCoarse => OpDPdxCoarse.Instance,
		OpCode.OpDPdyCoarse => OpDPdyCoarse.Instance,
		OpCode.OpFwidthCoarse => OpFwidthCoarse.Instance,
		OpCode.OpEmitVertex => OpEmitVertex.Instance,
		OpCode.OpEndPrimitive => OpEndPrimitive.Instance,
		OpCode.OpEmitStreamVertex => OpEmitStreamVertex.Instance,
		OpCode.OpEndStreamPrimitive => OpEndStreamPrimitive.Instance,
		OpCode.OpControlBarrier => OpControlBarrier.Instance,
		OpCode.OpMemoryBarrier => OpMemoryBarrier.Instance,
		OpCode.OpAtomicLoad => OpAtomicLoad.Instance,
		OpCode.OpAtomicStore => OpAtomicStore.Instance,
		OpCode.OpAtomicExchange => OpAtomicExchange.Instance,
		OpCode.OpAtomicCompareExchange => OpAtomicCompareExchange.Instance,
		OpCode.OpAtomicCompareExchangeWeak => OpAtomicCompareExchangeWeak.Instance,
		OpCode.OpAtomicIIncrement => OpAtomicIIncrement.Instance,
		OpCode.OpAtomicIDecrement => OpAtomicIDecrement.Instance,
		OpCode.OpAtomicIAdd => OpAtomicIAdd.Instance,
		OpCode.OpAtomicISub => OpAtomicISub.Instance,
		OpCode.OpAtomicSMin => OpAtomicSMin.Instance,
		OpCode.OpAtomicUMin => OpAtomicUMin.Instance,
		OpCode.OpAtomicSMax => OpAtomicSMax.Instance,
		OpCode.OpAtomicUMax => OpAtomicUMax.Instance,
		OpCode.OpAtomicAnd => OpAtomicAnd.Instance,
		OpCode.OpAtomicOr => OpAtomicOr.Instance,
		OpCode.OpAtomicXor => OpAtomicXor.Instance,
		OpCode.OpPhi => OpPhi.Instance,
		OpCode.OpLoopMerge => OpLoopMerge.Instance,
		OpCode.OpSelectionMerge => OpSelectionMerge.Instance,
		OpCode.OpLabel => OpLabel.Instance,
		OpCode.OpBranch => OpBranch.Instance,
		OpCode.OpBranchConditional => OpBranchConditional.Instance,
		OpCode.OpSwitch => OpSwitch.Instance,
		OpCode.OpKill => OpKill.Instance,
		OpCode.OpReturn => OpReturn.Instance,
		OpCode.OpReturnValue => OpReturnValue.Instance,
		OpCode.OpUnreachable => OpUnreachable.Instance,
		OpCode.OpLifetimeStart => OpLifetimeStart.Instance,
		OpCode.OpLifetimeStop => OpLifetimeStop.Instance,
		OpCode.OpGroupAsyncCopy => OpGroupAsyncCopy.Instance,
		OpCode.OpGroupWaitEvents => OpGroupWaitEvents.Instance,
		OpCode.OpGroupAll => OpGroupAll.Instance,
		OpCode.OpGroupAny => OpGroupAny.Instance,
		OpCode.OpGroupBroadcast => OpGroupBroadcast.Instance,
		OpCode.OpGroupIAdd => OpGroupIAdd.Instance,
		OpCode.OpGroupFAdd => OpGroupFAdd.Instance,
		OpCode.OpGroupFMin => OpGroupFMin.Instance,
		OpCode.OpGroupUMin => OpGroupUMin.Instance,
		OpCode.OpGroupSMin => OpGroupSMin.Instance,
		OpCode.OpGroupFMax => OpGroupFMax.Instance,
		OpCode.OpGroupUMax => OpGroupUMax.Instance,
		OpCode.OpGroupSMax => OpGroupSMax.Instance,
		OpCode.OpReadPipe => OpReadPipe.Instance,
		OpCode.OpWritePipe => OpWritePipe.Instance,
		OpCode.OpReservedReadPipe => OpReservedReadPipe.Instance,
		OpCode.OpReservedWritePipe => OpReservedWritePipe.Instance,
		OpCode.OpReserveReadPipePackets => OpReserveReadPipePackets.Instance,
		OpCode.OpReserveWritePipePackets => OpReserveWritePipePackets.Instance,
		OpCode.OpCommitReadPipe => OpCommitReadPipe.Instance,
		OpCode.OpCommitWritePipe => OpCommitWritePipe.Instance,
		OpCode.OpIsValidReserveId => OpIsValidReserveId.Instance,
		OpCode.OpGetNumPipePackets => OpGetNumPipePackets.Instance,
		OpCode.OpGetMaxPipePackets => OpGetMaxPipePackets.Instance,
		OpCode.OpGroupReserveReadPipePackets => OpGroupReserveReadPipePackets.Instance,
		OpCode.OpGroupReserveWritePipePackets => OpGroupReserveWritePipePackets.Instance,
		OpCode.OpGroupCommitReadPipe => OpGroupCommitReadPipe.Instance,
		OpCode.OpGroupCommitWritePipe => OpGroupCommitWritePipe.Instance,
		OpCode.OpEnqueueMarker => OpEnqueueMarker.Instance,
		OpCode.OpEnqueueKernel => OpEnqueueKernel.Instance,
		OpCode.OpGetKernelNDrangeSubGroupCount => OpGetKernelNDrangeSubGroupCount.Instance,
		OpCode.OpGetKernelNDrangeMaxSubGroupSize => OpGetKernelNDrangeMaxSubGroupSize.Instance,
		OpCode.OpGetKernelWorkGroupSize => OpGetKernelWorkGroupSize.Instance,
		OpCode.OpGetKernelPreferredWorkGroupSizeMultiple => OpGetKernelPreferredWorkGroupSizeMultiple.Instance,
		OpCode.OpRetainEvent => OpRetainEvent.Instance,
		OpCode.OpReleaseEvent => OpReleaseEvent.Instance,
		OpCode.OpCreateUserEvent => OpCreateUserEvent.Instance,
		OpCode.OpIsValidEvent => OpIsValidEvent.Instance,
		OpCode.OpSetUserEventStatus => OpSetUserEventStatus.Instance,
		OpCode.OpCaptureEventProfilingInfo => OpCaptureEventProfilingInfo.Instance,
		OpCode.OpGetDefaultQueue => OpGetDefaultQueue.Instance,
		OpCode.OpBuildNDRange => OpBuildNDRange.Instance,
		OpCode.OpImageSparseSampleImplicitLod => OpImageSparseSampleImplicitLod.Instance,
		OpCode.OpImageSparseSampleExplicitLod => OpImageSparseSampleExplicitLod.Instance,
		OpCode.OpImageSparseSampleDrefImplicitLod => OpImageSparseSampleDrefImplicitLod.Instance,
		OpCode.OpImageSparseSampleDrefExplicitLod => OpImageSparseSampleDrefExplicitLod.Instance,
		OpCode.OpImageSparseSampleProjImplicitLod => OpImageSparseSampleProjImplicitLod.Instance,
		OpCode.OpImageSparseSampleProjExplicitLod => OpImageSparseSampleProjExplicitLod.Instance,
		OpCode.OpImageSparseSampleProjDrefImplicitLod => OpImageSparseSampleProjDrefImplicitLod.Instance,
		OpCode.OpImageSparseSampleProjDrefExplicitLod => OpImageSparseSampleProjDrefExplicitLod.Instance,
		OpCode.OpImageSparseFetch => OpImageSparseFetch.Instance,
		OpCode.OpImageSparseGather => OpImageSparseGather.Instance,
		OpCode.OpImageSparseDrefGather => OpImageSparseDrefGather.Instance,
		OpCode.OpImageSparseTexelsResident => OpImageSparseTexelsResident.Instance,
		OpCode.OpNoLine => OpNoLine.Instance,
		OpCode.OpAtomicFlagTestAndSet => OpAtomicFlagTestAndSet.Instance,
		OpCode.OpAtomicFlagClear => OpAtomicFlagClear.Instance,
		OpCode.OpImageSparseRead => OpImageSparseRead.Instance,
		OpCode.OpSizeOf => OpSizeOf.Instance,
		OpCode.OpTypePipeStorage => OpTypePipeStorage.Instance,
		OpCode.OpConstantPipeStorage => OpConstantPipeStorage.Instance,
		OpCode.OpCreatePipeFromPipeStorage => OpCreatePipeFromPipeStorage.Instance,
		OpCode.OpGetKernelLocalSizeForSubgroupCount => OpGetKernelLocalSizeForSubgroupCount.Instance,
		OpCode.OpGetKernelMaxNumSubgroups => OpGetKernelMaxNumSubgroups.Instance,
		OpCode.OpTypeNamedBarrier => OpTypeNamedBarrier.Instance,
		OpCode.OpNamedBarrierInitialize => OpNamedBarrierInitialize.Instance,
		OpCode.OpMemoryNamedBarrier => OpMemoryNamedBarrier.Instance,
		OpCode.OpModuleProcessed => OpModuleProcessed.Instance,
		OpCode.OpExecutionModeId => OpExecutionModeId.Instance,
		OpCode.OpDecorateId => OpDecorateId.Instance,
		OpCode.OpSubgroupBallotKHR => OpSubgroupBallotKHR.Instance,
		OpCode.OpSubgroupFirstInvocationKHR => OpSubgroupFirstInvocationKHR.Instance,
		OpCode.OpSubgroupAllKHR => OpSubgroupAllKHR.Instance,
		OpCode.OpSubgroupAnyKHR => OpSubgroupAnyKHR.Instance,
		OpCode.OpSubgroupAllEqualKHR => OpSubgroupAllEqualKHR.Instance,
		OpCode.OpSubgroupReadInvocationKHR => OpSubgroupReadInvocationKHR.Instance,
		OpCode.OpGroupIAddNonUniformAMD => OpGroupIAddNonUniformAMD.Instance,
		OpCode.OpGroupFAddNonUniformAMD => OpGroupFAddNonUniformAMD.Instance,
		OpCode.OpGroupFMinNonUniformAMD => OpGroupFMinNonUniformAMD.Instance,
		OpCode.OpGroupUMinNonUniformAMD => OpGroupUMinNonUniformAMD.Instance,
		OpCode.OpGroupSMinNonUniformAMD => OpGroupSMinNonUniformAMD.Instance,
		OpCode.OpGroupFMaxNonUniformAMD => OpGroupFMaxNonUniformAMD.Instance,
		OpCode.OpGroupUMaxNonUniformAMD => OpGroupUMaxNonUniformAMD.Instance,
		OpCode.OpGroupSMaxNonUniformAMD => OpGroupSMaxNonUniformAMD.Instance,
		OpCode.OpFragmentMaskFetchAMD => OpFragmentMaskFetchAMD.Instance,
		OpCode.OpFragmentFetchAMD => OpFragmentFetchAMD.Instance,
		OpCode.OpSubgroupShuffleINTEL => OpSubgroupShuffleINTEL.Instance,
		OpCode.OpSubgroupShuffleDownINTEL => OpSubgroupShuffleDownINTEL.Instance,
		OpCode.OpSubgroupShuffleUpINTEL => OpSubgroupShuffleUpINTEL.Instance,
		OpCode.OpSubgroupShuffleXorINTEL => OpSubgroupShuffleXorINTEL.Instance,
		OpCode.OpSubgroupBlockReadINTEL => OpSubgroupBlockReadINTEL.Instance,
		OpCode.OpSubgroupBlockWriteINTEL => OpSubgroupBlockWriteINTEL.Instance,
		OpCode.OpSubgroupImageBlockReadINTEL => OpSubgroupImageBlockReadINTEL.Instance,
		OpCode.OpSubgroupImageBlockWriteINTEL => OpSubgroupImageBlockWriteINTEL.Instance,
		OpCode.OpDecorateStringGOOGLE => OpDecorateStringGOOGLE.Instance,
		OpCode.OpMemberDecorateStringGOOGLE => OpMemberDecorateStringGOOGLE.Instance,
		_ => throw new ArgumentOutOfRangeException(nameof(code)),
	};
}
public sealed class OpNop : Instruction
{
	public static OpNop Instance { get; } = new();

	private OpNop()
	{
	}

	public override string Name => nameof(OpNop);
	public override OpCode Code => OpCode.OpNop;
}
public sealed class OpUndef : Instruction
{
	public static OpUndef Instance { get; } = new();

	private OpUndef()
	{
	}

	public override string Name => nameof(OpUndef);
	public override OpCode Code => OpCode.OpUndef;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSourceContinued : Instruction
{
	public static OpSourceContinued Instance { get; } = new();

	private OpSourceContinued()
	{
	}

	public override string Name => nameof(OpSourceContinued);
	public override OpCode Code => OpCode.OpSourceContinued;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Continued Source", OperandQuantifier.Default),];
}
public sealed class OpSource : Instruction
{
	public static OpSource Instance { get; } = new();

	private OpSource()
	{
	}

	public override string Name => nameof(OpSource);
	public override OpCode Code => OpCode.OpSource;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<SourceLanguage, SourceLanguageParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Version", OperandQuantifier.Default), new Operand(new IdRef(), "File", OperandQuantifier.Optional), new Operand(new LiteralString(), "Source", OperandQuantifier.Optional),];
}
public sealed class OpSourceExtension : Instruction
{
	public static OpSourceExtension Instance { get; } = new();

	private OpSourceExtension()
	{
	}

	public override string Name => nameof(OpSourceExtension);
	public override OpCode Code => OpCode.OpSourceExtension;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Extension", OperandQuantifier.Default),];
}
public sealed class OpName : Instruction
{
	public static OpName Instance { get; } = new();

	private OpName()
	{
	}

	public override string Name => nameof(OpName);
	public override OpCode Code => OpCode.OpName;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpMemberName : Instruction
{
	public static OpMemberName Instance { get; } = new();

	private OpMemberName()
	{
	}

	public override string Name => nameof(OpMemberName);
	public override OpCode Code => OpCode.OpMemberName;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpString : Instruction
{
	public static OpString Instance { get; } = new();

	private OpString()
	{
	}

	public override string Name => nameof(OpString);
	public override OpCode Code => OpCode.OpString;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "String", OperandQuantifier.Default),];
}
public sealed class OpLine : Instruction
{
	public static OpLine Instance { get; } = new();

	private OpLine()
	{
	}

	public override string Name => nameof(OpLine);
	public override OpCode Code => OpCode.OpLine;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "File", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Line", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column", OperandQuantifier.Default),];
}
public sealed class OpExtension : Instruction
{
	public static OpExtension Instance { get; } = new();

	private OpExtension()
	{
	}

	public override string Name => nameof(OpExtension);
	public override OpCode Code => OpCode.OpExtension;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpExtInstImport : Instruction
{
	public static OpExtInstImport Instance { get; } = new();

	private OpExtInstImport()
	{
	}

	public override string Name => nameof(OpExtInstImport);
	public override OpCode Code => OpCode.OpExtInstImport;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpExtInst : Instruction
{
	public static OpExtInst Instance { get; } = new();

	private OpExtInst()
	{
	}

	public override string Name => nameof(OpExtInst);
	public override OpCode Code => OpCode.OpExtInst;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Set", OperandQuantifier.Default), new Operand(new LiteralExtInstInteger(), "Instruction", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1, +Operand 2, +...", OperandQuantifier.Varying),];
}
public sealed class OpMemoryModel : Instruction
{
	public static OpMemoryModel Instance { get; } = new();

	private OpMemoryModel()
	{
	}

	public override string Name => nameof(OpMemoryModel);
	public override OpCode Code => OpCode.OpMemoryModel;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<AddressingModel, AddressingModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<MemoryModel, MemoryModelParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpEntryPoint : Instruction
{
	public static OpEntryPoint Instance { get; } = new();

	private OpEntryPoint()
	{
	}

	public override string Name => nameof(OpEntryPoint);
	public override OpCode Code => OpCode.OpEntryPoint;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<ExecutionModel, ExecutionModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default), new Operand(new IdRef(), "Interface", OperandQuantifier.Varying),];
}
public sealed class OpExecutionMode : Instruction
{
	public static OpExecutionMode Instance { get; } = new();

	private OpExecutionMode()
	{
	}

	public override string Name => nameof(OpExecutionMode);
	public override OpCode Code => OpCode.OpExecutionMode;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),];
}
public sealed class OpCapability : Instruction
{
	public static OpCapability Instance { get; } = new();

	private OpCapability()
	{
	}

	public override string Name => nameof(OpCapability);
	public override OpCode Code => OpCode.OpCapability;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<Capability, CapabilityParameterFactory>(), "Capability", OperandQuantifier.Default),];
}
public sealed class OpTypeVoid : Instruction
{
	public static OpTypeVoid Instance { get; } = new();

	private OpTypeVoid()
	{
	}

	public override string Name => nameof(OpTypeVoid);
	public override OpCode Code => OpCode.OpTypeVoid;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeBool : Instruction
{
	public static OpTypeBool Instance { get; } = new();

	private OpTypeBool()
	{
	}

	public override string Name => nameof(OpTypeBool);
	public override OpCode Code => OpCode.OpTypeBool;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeInt : Instruction
{
	public static OpTypeInt Instance { get; } = new();

	private OpTypeInt()
	{
	}

	public override string Name => nameof(OpTypeInt);
	public override OpCode Code => OpCode.OpTypeInt;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Signedness", OperandQuantifier.Default),];
}
public sealed class OpTypeFloat : Instruction
{
	public static OpTypeFloat Instance { get; } = new();

	private OpTypeFloat()
	{
	}

	public override string Name => nameof(OpTypeFloat);
	public override OpCode Code => OpCode.OpTypeFloat;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default),];
}
public sealed class OpTypeVector : Instruction
{
	public static OpTypeVector Instance { get; } = new();

	private OpTypeVector()
	{
	}

	public override string Name => nameof(OpTypeVector);
	public override OpCode Code => OpCode.OpTypeVector;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Component Count", OperandQuantifier.Default),];
}
public sealed class OpTypeMatrix : Instruction
{
	public static OpTypeMatrix Instance { get; } = new();

	private OpTypeMatrix()
	{
	}

	public override string Name => nameof(OpTypeMatrix);
	public override OpCode Code => OpCode.OpTypeMatrix;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Column Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column Count", OperandQuantifier.Default),];
}
public sealed class OpTypeImage : Instruction
{
	public static OpTypeImage Instance { get; } = new();

	private OpTypeImage()
	{
	}

	public override string Name => nameof(OpTypeImage);
	public override OpCode Code => OpCode.OpTypeImage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Type", OperandQuantifier.Default), new Operand(new EnumType<Dim, DimParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Depth", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Arrayed", OperandQuantifier.Default), new Operand(new LiteralInteger(), "MS", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Sampled", OperandQuantifier.Default), new Operand(new EnumType<ImageFormat, ImageFormatParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpTypeSampler : Instruction
{
	public static OpTypeSampler Instance { get; } = new();

	private OpTypeSampler()
	{
	}

	public override string Name => nameof(OpTypeSampler);
	public override OpCode Code => OpCode.OpTypeSampler;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeSampledImage : Instruction
{
	public static OpTypeSampledImage Instance { get; } = new();

	private OpTypeSampledImage()
	{
	}

	public override string Name => nameof(OpTypeSampledImage);
	public override OpCode Code => OpCode.OpTypeSampledImage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Type", OperandQuantifier.Default),];
}
public sealed class OpTypeArray : Instruction
{
	public static OpTypeArray Instance { get; } = new();

	private OpTypeArray()
	{
	}

	public override string Name => nameof(OpTypeArray);
	public override OpCode Code => OpCode.OpTypeArray;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default), new Operand(new IdRef(), "Length", OperandQuantifier.Default),];
}
public sealed class OpTypeRuntimeArray : Instruction
{
	public static OpTypeRuntimeArray Instance { get; } = new();

	private OpTypeRuntimeArray()
	{
	}

	public override string Name => nameof(OpTypeRuntimeArray);
	public override OpCode Code => OpCode.OpTypeRuntimeArray;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default),];
}
public sealed class OpTypeStruct : Instruction
{
	public static OpTypeStruct Instance { get; } = new();

	private OpTypeStruct()
	{
	}

	public override string Name => nameof(OpTypeStruct);
	public override OpCode Code => OpCode.OpTypeStruct;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Member 0 type, +member 1 type, +...", OperandQuantifier.Varying),];
}
public sealed class OpTypeOpaque : Instruction
{
	public static OpTypeOpaque Instance { get; } = new();

	private OpTypeOpaque()
	{
	}

	public override string Name => nameof(OpTypeOpaque);
	public override OpCode Code => OpCode.OpTypeOpaque;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "The name of the opaque type.", OperandQuantifier.Default),];
}
public sealed class OpTypePointer : Instruction
{
	public static OpTypePointer Instance { get; } = new();

	private OpTypePointer()
	{
	}

	public override string Name => nameof(OpTypePointer);
	public override OpCode Code => OpCode.OpTypePointer;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),];
}
public sealed class OpTypeFunction : Instruction
{
	public static OpTypeFunction Instance { get; } = new();

	private OpTypeFunction()
	{
	}

	public override string Name => nameof(OpTypeFunction);
	public override OpCode Code => OpCode.OpTypeFunction;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Return Type", OperandQuantifier.Default), new Operand(new IdRef(), "Parameter 0 Type, +Parameter 1 Type, +...", OperandQuantifier.Varying),];
}
public sealed class OpTypeEvent : Instruction
{
	public static OpTypeEvent Instance { get; } = new();

	private OpTypeEvent()
	{
	}

	public override string Name => nameof(OpTypeEvent);
	public override OpCode Code => OpCode.OpTypeEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeDeviceEvent : Instruction
{
	public static OpTypeDeviceEvent Instance { get; } = new();

	private OpTypeDeviceEvent()
	{
	}

	public override string Name => nameof(OpTypeDeviceEvent);
	public override OpCode Code => OpCode.OpTypeDeviceEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeReserveId : Instruction
{
	public static OpTypeReserveId Instance { get; } = new();

	private OpTypeReserveId()
	{
	}

	public override string Name => nameof(OpTypeReserveId);
	public override OpCode Code => OpCode.OpTypeReserveId;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeQueue : Instruction
{
	public static OpTypeQueue Instance { get; } = new();

	private OpTypeQueue()
	{
	}

	public override string Name => nameof(OpTypeQueue);
	public override OpCode Code => OpCode.OpTypeQueue;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypePipe : Instruction
{
	public static OpTypePipe Instance { get; } = new();

	private OpTypePipe()
	{
	}

	public override string Name => nameof(OpTypePipe);
	public override OpCode Code => OpCode.OpTypePipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), "Qualifier", OperandQuantifier.Default),];
}
public sealed class OpTypeForwardPointer : Instruction
{
	public static OpTypeForwardPointer Instance { get; } = new();

	private OpTypeForwardPointer()
	{
	}

	public override string Name => nameof(OpTypeForwardPointer);
	public override OpCode Code => OpCode.OpTypeForwardPointer;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer Type", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantTrue : Instruction
{
	public static OpConstantTrue Instance { get; } = new();

	private OpConstantTrue()
	{
	}

	public override string Name => nameof(OpConstantTrue);
	public override OpCode Code => OpCode.OpConstantTrue;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantFalse : Instruction
{
	public static OpConstantFalse Instance { get; } = new();

	private OpConstantFalse()
	{
	}

	public override string Name => nameof(OpConstantFalse);
	public override OpCode Code => OpCode.OpConstantFalse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstant : Instruction
{
	public static OpConstant Instance { get; } = new();

	private OpConstant()
	{
	}

	public override string Name => nameof(OpConstant);
	public override OpCode Code => OpCode.OpConstant;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),];
}
public sealed class OpConstantComposite : Instruction
{
	public static OpConstantComposite Instance { get; } = new();

	private OpConstantComposite()
	{
	}

	public override string Name => nameof(OpConstantComposite);
	public override OpCode Code => OpCode.OpConstantComposite;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpConstantSampler : Instruction
{
	public static OpConstantSampler Instance { get; } = new();

	private OpConstantSampler()
	{
	}

	public override string Name => nameof(OpConstantSampler);
	public override OpCode Code => OpCode.OpConstantSampler;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<SamplerAddressingMode, SamplerAddressingModeParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Param", OperandQuantifier.Default), new Operand(new EnumType<SamplerFilterMode, SamplerFilterModeParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantNull : Instruction
{
	public static OpConstantNull Instance { get; } = new();

	private OpConstantNull()
	{
	}

	public override string Name => nameof(OpConstantNull);
	public override OpCode Code => OpCode.OpConstantNull;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstantTrue : Instruction
{
	public static OpSpecConstantTrue Instance { get; } = new();

	private OpSpecConstantTrue()
	{
	}

	public override string Name => nameof(OpSpecConstantTrue);
	public override OpCode Code => OpCode.OpSpecConstantTrue;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstantFalse : Instruction
{
	public static OpSpecConstantFalse Instance { get; } = new();

	private OpSpecConstantFalse()
	{
	}

	public override string Name => nameof(OpSpecConstantFalse);
	public override OpCode Code => OpCode.OpSpecConstantFalse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstant : Instruction
{
	public static OpSpecConstant Instance { get; } = new();

	private OpSpecConstant()
	{
	}

	public override string Name => nameof(OpSpecConstant);
	public override OpCode Code => OpCode.OpSpecConstant;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantComposite : Instruction
{
	public static OpSpecConstantComposite Instance { get; } = new();

	private OpSpecConstantComposite()
	{
	}

	public override string Name => nameof(OpSpecConstantComposite);
	public override OpCode Code => OpCode.OpSpecConstantComposite;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpSpecConstantOp : Instruction
{
	public static OpSpecConstantOp Instance { get; } = new();

	private OpSpecConstantOp()
	{
	}

	public override string Name => nameof(OpSpecConstantOp);
	public override OpCode Code => OpCode.OpSpecConstantOp;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralSpecConstantOpInteger(), "Opcode", OperandQuantifier.Default),];
}
public sealed class OpFunction : Instruction
{
	public static OpFunction Instance { get; } = new();

	private OpFunction()
	{
	}

	public override string Name => nameof(OpFunction);
	public override OpCode Code => OpCode.OpFunction;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<FunctionControl, FunctionControlParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function Type", OperandQuantifier.Default),];
}
public sealed class OpFunctionParameter : Instruction
{
	public static OpFunctionParameter Instance { get; } = new();

	private OpFunctionParameter()
	{
	}

	public override string Name => nameof(OpFunctionParameter);
	public override OpCode Code => OpCode.OpFunctionParameter;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpFunctionEnd : Instruction
{
	public static OpFunctionEnd Instance { get; } = new();

	private OpFunctionEnd()
	{
	}

	public override string Name => nameof(OpFunctionEnd);
	public override OpCode Code => OpCode.OpFunctionEnd;
}
public sealed class OpFunctionCall : Instruction
{
	public static OpFunctionCall Instance { get; } = new();

	private OpFunctionCall()
	{
	}

	public override string Name => nameof(OpFunctionCall);
	public override OpCode Code => OpCode.OpFunctionCall;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default), new Operand(new IdRef(), "Argument 0, +Argument 1, +...", OperandQuantifier.Varying),];
}
public sealed class OpVariable : Instruction
{
	public static OpVariable Instance { get; } = new();

	private OpVariable()
	{
	}

	public override string Name => nameof(OpVariable);
	public override OpCode Code => OpCode.OpVariable;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Initializer", OperandQuantifier.Optional),];
}
public sealed class OpImageTexelPointer : Instruction
{
	public static OpImageTexelPointer Instance { get; } = new();

	private OpImageTexelPointer()
	{
	}

	public override string Name => nameof(OpImageTexelPointer);
	public override OpCode Code => OpCode.OpImageTexelPointer;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Default),];
}
public sealed class OpLoad : Instruction
{
	public static OpLoad Instance { get; } = new();

	private OpLoad()
	{
	}

	public override string Name => nameof(OpLoad);
	public override OpCode Code => OpCode.OpLoad;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpStore : Instruction
{
	public static OpStore Instance { get; } = new();

	private OpStore()
	{
	}

	public override string Name => nameof(OpStore);
	public override OpCode Code => OpCode.OpStore;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCopyMemory : Instruction
{
	public static OpCopyMemory Instance { get; } = new();

	private OpCopyMemory()
	{
	}

	public override string Name => nameof(OpCopyMemory);
	public override OpCode Code => OpCode.OpCopyMemory;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCopyMemorySized : Instruction
{
	public static OpCopyMemorySized Instance { get; } = new();

	private OpCopyMemorySized()
	{
	}

	public override string Name => nameof(OpCopyMemorySized);
	public override OpCode Code => OpCode.OpCopyMemorySized;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Size", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpAccessChain : Instruction
{
	public static OpAccessChain Instance { get; } = new();

	private OpAccessChain()
	{
	}

	public override string Name => nameof(OpAccessChain);
	public override OpCode Code => OpCode.OpAccessChain;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpInBoundsAccessChain : Instruction
{
	public static OpInBoundsAccessChain Instance { get; } = new();

	private OpInBoundsAccessChain()
	{
	}

	public override string Name => nameof(OpInBoundsAccessChain);
	public override OpCode Code => OpCode.OpInBoundsAccessChain;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpPtrAccessChain : Instruction
{
	public static OpPtrAccessChain Instance { get; } = new();

	private OpPtrAccessChain()
	{
	}

	public override string Name => nameof(OpPtrAccessChain);
	public override OpCode Code => OpCode.OpPtrAccessChain;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpArrayLength : Instruction
{
	public static OpArrayLength Instance { get; } = new();

	private OpArrayLength()
	{
	}

	public override string Name => nameof(OpArrayLength);
	public override OpCode Code => OpCode.OpArrayLength;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Structure", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Array member", OperandQuantifier.Default),];
}
public sealed class OpGenericPtrMemSemantics : Instruction
{
	public static OpGenericPtrMemSemantics Instance { get; } = new();

	private OpGenericPtrMemSemantics()
	{
	}

	public override string Name => nameof(OpGenericPtrMemSemantics);
	public override OpCode Code => OpCode.OpGenericPtrMemSemantics;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpInBoundsPtrAccessChain : Instruction
{
	public static OpInBoundsPtrAccessChain Instance { get; } = new();

	private OpInBoundsPtrAccessChain()
	{
	}

	public override string Name => nameof(OpInBoundsPtrAccessChain);
	public override OpCode Code => OpCode.OpInBoundsPtrAccessChain;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpDecorate : Instruction
{
	public static OpDecorate Instance { get; } = new();

	private OpDecorate()
	{
	}

	public override string Name => nameof(OpDecorate);
	public override OpCode Code => OpCode.OpDecorate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpMemberDecorate : Instruction
{
	public static OpMemberDecorate Instance { get; } = new();

	private OpMemberDecorate()
	{
	}

	public override string Name => nameof(OpMemberDecorate);
	public override OpCode Code => OpCode.OpMemberDecorate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Structure Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpDecorationGroup : Instruction
{
	public static OpDecorationGroup Instance { get; } = new();

	private OpDecorationGroup()
	{
	}

	public override string Name => nameof(OpDecorationGroup);
	public override OpCode Code => OpCode.OpDecorationGroup;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpGroupDecorate : Instruction
{
	public static OpGroupDecorate Instance { get; } = new();

	private OpGroupDecorate()
	{
	}

	public override string Name => nameof(OpGroupDecorate);
	public override OpCode Code => OpCode.OpGroupDecorate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new IdRef(), "Targets", OperandQuantifier.Varying),];
}
public sealed class OpGroupMemberDecorate : Instruction
{
	public static OpGroupMemberDecorate Instance { get; } = new();

	private OpGroupMemberDecorate()
	{
	}

	public override string Name => nameof(OpGroupMemberDecorate);
	public override OpCode Code => OpCode.OpGroupMemberDecorate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new PairIdRefLiteralInteger(), "Targets", OperandQuantifier.Varying),];
}
public sealed class OpVectorExtractDynamic : Instruction
{
	public static OpVectorExtractDynamic Instance { get; } = new();

	private OpVectorExtractDynamic()
	{
	}

	public override string Name => nameof(OpVectorExtractDynamic);
	public override OpCode Code => OpCode.OpVectorExtractDynamic;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpVectorInsertDynamic : Instruction
{
	public static OpVectorInsertDynamic Instance { get; } = new();

	private OpVectorInsertDynamic()
	{
	}

	public override string Name => nameof(OpVectorInsertDynamic);
	public override OpCode Code => OpCode.OpVectorInsertDynamic;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpVectorShuffle : Instruction
{
	public static OpVectorShuffle Instance { get; } = new();

	private OpVectorShuffle()
	{
	}

	public override string Name => nameof(OpVectorShuffle);
	public override OpCode Code => OpCode.OpVectorShuffle;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Components", OperandQuantifier.Varying),];
}
public sealed class OpCompositeConstruct : Instruction
{
	public static OpCompositeConstruct Instance { get; } = new();

	private OpCompositeConstruct()
	{
	}

	public override string Name => nameof(OpCompositeConstruct);
	public override OpCode Code => OpCode.OpCompositeConstruct;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpCompositeExtract : Instruction
{
	public static OpCompositeExtract Instance { get; } = new();

	private OpCompositeExtract()
	{
	}

	public override string Name => nameof(OpCompositeExtract);
	public override OpCode Code => OpCode.OpCompositeExtract;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpCompositeInsert : Instruction
{
	public static OpCompositeInsert Instance { get; } = new();

	private OpCompositeInsert()
	{
	}

	public override string Name => nameof(OpCompositeInsert);
	public override OpCode Code => OpCode.OpCompositeInsert;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpCopyObject : Instruction
{
	public static OpCopyObject Instance { get; } = new();

	private OpCopyObject()
	{
	}

	public override string Name => nameof(OpCopyObject);
	public override OpCode Code => OpCode.OpCopyObject;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpTranspose : Instruction
{
	public static OpTranspose Instance { get; } = new();

	private OpTranspose()
	{
	}

	public override string Name => nameof(OpTranspose);
	public override OpCode Code => OpCode.OpTranspose;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpSampledImage : Instruction
{
	public static OpSampledImage Instance { get; } = new();

	private OpSampledImage()
	{
	}

	public override string Name => nameof(OpSampledImage);
	public override OpCode Code => OpCode.OpSampledImage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Sampler", OperandQuantifier.Default),];
}
public sealed class OpImageSampleImplicitLod : Instruction
{
	public static OpImageSampleImplicitLod Instance { get; } = new();

	private OpImageSampleImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleExplicitLod : Instruction
{
	public static OpImageSampleExplicitLod Instance { get; } = new();

	private OpImageSampleExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleDrefImplicitLod : Instruction
{
	public static OpImageSampleDrefImplicitLod Instance { get; } = new();

	private OpImageSampleDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleDrefImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleDrefExplicitLod : Instruction
{
	public static OpImageSampleDrefExplicitLod Instance { get; } = new();

	private OpImageSampleDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleDrefExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleProjImplicitLod : Instruction
{
	public static OpImageSampleProjImplicitLod Instance { get; } = new();

	private OpImageSampleProjImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleProjExplicitLod : Instruction
{
	public static OpImageSampleProjExplicitLod Instance { get; } = new();

	private OpImageSampleProjExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleProjDrefImplicitLod : Instruction
{
	public static OpImageSampleProjDrefImplicitLod Instance { get; } = new();

	private OpImageSampleProjDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjDrefImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleProjDrefExplicitLod : Instruction
{
	public static OpImageSampleProjDrefExplicitLod Instance { get; } = new();

	private OpImageSampleProjDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjDrefExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageFetch : Instruction
{
	public static OpImageFetch Instance { get; } = new();

	private OpImageFetch()
	{
	}

	public override string Name => nameof(OpImageFetch);
	public override OpCode Code => OpCode.OpImageFetch;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageGather : Instruction
{
	public static OpImageGather Instance { get; } = new();

	private OpImageGather()
	{
	}

	public override string Name => nameof(OpImageGather);
	public override OpCode Code => OpCode.OpImageGather;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageDrefGather : Instruction
{
	public static OpImageDrefGather Instance { get; } = new();

	private OpImageDrefGather()
	{
	}

	public override string Name => nameof(OpImageDrefGather);
	public override OpCode Code => OpCode.OpImageDrefGather;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageRead : Instruction
{
	public static OpImageRead Instance { get; } = new();

	private OpImageRead()
	{
	}

	public override string Name => nameof(OpImageRead);
	public override OpCode Code => OpCode.OpImageRead;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageWrite : Instruction
{
	public static OpImageWrite Instance { get; } = new();

	private OpImageWrite()
	{
	}

	public override string Name => nameof(OpImageWrite);
	public override OpCode Code => OpCode.OpImageWrite;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Texel", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImage : Instruction
{
	public static OpImage Instance { get; } = new();

	private OpImage()
	{
	}

	public override string Name => nameof(OpImage);
	public override OpCode Code => OpCode.OpImage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryFormat : Instruction
{
	public static OpImageQueryFormat Instance { get; } = new();

	private OpImageQueryFormat()
	{
	}

	public override string Name => nameof(OpImageQueryFormat);
	public override OpCode Code => OpCode.OpImageQueryFormat;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryOrder : Instruction
{
	public static OpImageQueryOrder Instance { get; } = new();

	private OpImageQueryOrder()
	{
	}

	public override string Name => nameof(OpImageQueryOrder);
	public override OpCode Code => OpCode.OpImageQueryOrder;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySizeLod : Instruction
{
	public static OpImageQuerySizeLod Instance { get; } = new();

	private OpImageQuerySizeLod()
	{
	}

	public override string Name => nameof(OpImageQuerySizeLod);
	public override OpCode Code => OpCode.OpImageQuerySizeLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Level of Detail", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySize : Instruction
{
	public static OpImageQuerySize Instance { get; } = new();

	private OpImageQuerySize()
	{
	}

	public override string Name => nameof(OpImageQuerySize);
	public override OpCode Code => OpCode.OpImageQuerySize;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryLod : Instruction
{
	public static OpImageQueryLod Instance { get; } = new();

	private OpImageQueryLod()
	{
	}

	public override string Name => nameof(OpImageQueryLod);
	public override OpCode Code => OpCode.OpImageQueryLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpImageQueryLevels : Instruction
{
	public static OpImageQueryLevels Instance { get; } = new();

	private OpImageQueryLevels()
	{
	}

	public override string Name => nameof(OpImageQueryLevels);
	public override OpCode Code => OpCode.OpImageQueryLevels;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySamples : Instruction
{
	public static OpImageQuerySamples Instance { get; } = new();

	private OpImageQuerySamples()
	{
	}

	public override string Name => nameof(OpImageQuerySamples);
	public override OpCode Code => OpCode.OpImageQuerySamples;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpConvertFToU : Instruction
{
	public static OpConvertFToU Instance { get; } = new();

	private OpConvertFToU()
	{
	}

	public override string Name => nameof(OpConvertFToU);
	public override OpCode Code => OpCode.OpConvertFToU;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpConvertFToS : Instruction
{
	public static OpConvertFToS Instance { get; } = new();

	private OpConvertFToS()
	{
	}

	public override string Name => nameof(OpConvertFToS);
	public override OpCode Code => OpCode.OpConvertFToS;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpConvertSToF : Instruction
{
	public static OpConvertSToF Instance { get; } = new();

	private OpConvertSToF()
	{
	}

	public override string Name => nameof(OpConvertSToF);
	public override OpCode Code => OpCode.OpConvertSToF;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpConvertUToF : Instruction
{
	public static OpConvertUToF Instance { get; } = new();

	private OpConvertUToF()
	{
	}

	public override string Name => nameof(OpConvertUToF);
	public override OpCode Code => OpCode.OpConvertUToF;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpUConvert : Instruction
{
	public static OpUConvert Instance { get; } = new();

	private OpUConvert()
	{
	}

	public override string Name => nameof(OpUConvert);
	public override OpCode Code => OpCode.OpUConvert;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpSConvert : Instruction
{
	public static OpSConvert Instance { get; } = new();

	private OpSConvert()
	{
	}

	public override string Name => nameof(OpSConvert);
	public override OpCode Code => OpCode.OpSConvert;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpFConvert : Instruction
{
	public static OpFConvert Instance { get; } = new();

	private OpFConvert()
	{
	}

	public override string Name => nameof(OpFConvert);
	public override OpCode Code => OpCode.OpFConvert;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpQuantizeToF16 : Instruction
{
	public static OpQuantizeToF16 Instance { get; } = new();

	private OpQuantizeToF16()
	{
	}

	public override string Name => nameof(OpQuantizeToF16);
	public override OpCode Code => OpCode.OpQuantizeToF16;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpConvertPtrToU : Instruction
{
	public static OpConvertPtrToU Instance { get; } = new();

	private OpConvertPtrToU()
	{
	}

	public override string Name => nameof(OpConvertPtrToU);
	public override OpCode Code => OpCode.OpConvertPtrToU;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpSatConvertSToU : Instruction
{
	public static OpSatConvertSToU Instance { get; } = new();

	private OpSatConvertSToU()
	{
	}

	public override string Name => nameof(OpSatConvertSToU);
	public override OpCode Code => OpCode.OpSatConvertSToU;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpSatConvertUToS : Instruction
{
	public static OpSatConvertUToS Instance { get; } = new();

	private OpSatConvertUToS()
	{
	}

	public override string Name => nameof(OpSatConvertUToS);
	public override OpCode Code => OpCode.OpSatConvertUToS;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpConvertUToPtr : Instruction
{
	public static OpConvertUToPtr Instance { get; } = new();

	private OpConvertUToPtr()
	{
	}

	public override string Name => nameof(OpConvertUToPtr);
	public override OpCode Code => OpCode.OpConvertUToPtr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Integer Value", OperandQuantifier.Default),];
}
public sealed class OpPtrCastToGeneric : Instruction
{
	public static OpPtrCastToGeneric Instance { get; } = new();

	private OpPtrCastToGeneric()
	{
	}

	public override string Name => nameof(OpPtrCastToGeneric);
	public override OpCode Code => OpCode.OpPtrCastToGeneric;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpGenericCastToPtr : Instruction
{
	public static OpGenericCastToPtr Instance { get; } = new();

	private OpGenericCastToPtr()
	{
	}

	public override string Name => nameof(OpGenericCastToPtr);
	public override OpCode Code => OpCode.OpGenericCastToPtr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpGenericCastToPtrExplicit : Instruction
{
	public static OpGenericCastToPtrExplicit Instance { get; } = new();

	private OpGenericCastToPtrExplicit()
	{
	}

	public override string Name => nameof(OpGenericCastToPtrExplicit);
	public override OpCode Code => OpCode.OpGenericCastToPtrExplicit;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), "Storage", OperandQuantifier.Default),];
}
public sealed class OpBitcast : Instruction
{
	public static OpBitcast Instance { get; } = new();

	private OpBitcast()
	{
	}

	public override string Name => nameof(OpBitcast);
	public override OpCode Code => OpCode.OpBitcast;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpSNegate : Instruction
{
	public static OpSNegate Instance { get; } = new();

	private OpSNegate()
	{
	}

	public override string Name => nameof(OpSNegate);
	public override OpCode Code => OpCode.OpSNegate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpFNegate : Instruction
{
	public static OpFNegate Instance { get; } = new();

	private OpFNegate()
	{
	}

	public override string Name => nameof(OpFNegate);
	public override OpCode Code => OpCode.OpFNegate;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpIAdd : Instruction
{
	public static OpIAdd Instance { get; } = new();

	private OpIAdd()
	{
	}

	public override string Name => nameof(OpIAdd);
	public override OpCode Code => OpCode.OpIAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFAdd : Instruction
{
	public static OpFAdd Instance { get; } = new();

	private OpFAdd()
	{
	}

	public override string Name => nameof(OpFAdd);
	public override OpCode Code => OpCode.OpFAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpISub : Instruction
{
	public static OpISub Instance { get; } = new();

	private OpISub()
	{
	}

	public override string Name => nameof(OpISub);
	public override OpCode Code => OpCode.OpISub;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFSub : Instruction
{
	public static OpFSub Instance { get; } = new();

	private OpFSub()
	{
	}

	public override string Name => nameof(OpFSub);
	public override OpCode Code => OpCode.OpFSub;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIMul : Instruction
{
	public static OpIMul Instance { get; } = new();

	private OpIMul()
	{
	}

	public override string Name => nameof(OpIMul);
	public override OpCode Code => OpCode.OpIMul;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFMul : Instruction
{
	public static OpFMul Instance { get; } = new();

	private OpFMul()
	{
	}

	public override string Name => nameof(OpFMul);
	public override OpCode Code => OpCode.OpFMul;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUDiv : Instruction
{
	public static OpUDiv Instance { get; } = new();

	private OpUDiv()
	{
	}

	public override string Name => nameof(OpUDiv);
	public override OpCode Code => OpCode.OpUDiv;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSDiv : Instruction
{
	public static OpSDiv Instance { get; } = new();

	private OpSDiv()
	{
	}

	public override string Name => nameof(OpSDiv);
	public override OpCode Code => OpCode.OpSDiv;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFDiv : Instruction
{
	public static OpFDiv Instance { get; } = new();

	private OpFDiv()
	{
	}

	public override string Name => nameof(OpFDiv);
	public override OpCode Code => OpCode.OpFDiv;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUMod : Instruction
{
	public static OpUMod Instance { get; } = new();

	private OpUMod()
	{
	}

	public override string Name => nameof(OpUMod);
	public override OpCode Code => OpCode.OpUMod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSRem : Instruction
{
	public static OpSRem Instance { get; } = new();

	private OpSRem()
	{
	}

	public override string Name => nameof(OpSRem);
	public override OpCode Code => OpCode.OpSRem;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSMod : Instruction
{
	public static OpSMod Instance { get; } = new();

	private OpSMod()
	{
	}

	public override string Name => nameof(OpSMod);
	public override OpCode Code => OpCode.OpSMod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFRem : Instruction
{
	public static OpFRem Instance { get; } = new();

	private OpFRem()
	{
	}

	public override string Name => nameof(OpFRem);
	public override OpCode Code => OpCode.OpFRem;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFMod : Instruction
{
	public static OpFMod Instance { get; } = new();

	private OpFMod()
	{
	}

	public override string Name => nameof(OpFMod);
	public override OpCode Code => OpCode.OpFMod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpVectorTimesScalar : Instruction
{
	public static OpVectorTimesScalar Instance { get; } = new();

	private OpVectorTimesScalar()
	{
	}

	public override string Name => nameof(OpVectorTimesScalar);
	public override OpCode Code => OpCode.OpVectorTimesScalar;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesScalar : Instruction
{
	public static OpMatrixTimesScalar Instance { get; } = new();

	private OpMatrixTimesScalar()
	{
	}

	public override string Name => nameof(OpMatrixTimesScalar);
	public override OpCode Code => OpCode.OpMatrixTimesScalar;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),];
}
public sealed class OpVectorTimesMatrix : Instruction
{
	public static OpVectorTimesMatrix Instance { get; } = new();

	private OpVectorTimesMatrix()
	{
	}

	public override string Name => nameof(OpVectorTimesMatrix);
	public override OpCode Code => OpCode.OpVectorTimesMatrix;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesVector : Instruction
{
	public static OpMatrixTimesVector Instance { get; } = new();

	private OpMatrixTimesVector()
	{
	}

	public override string Name => nameof(OpMatrixTimesVector);
	public override OpCode Code => OpCode.OpMatrixTimesVector;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesMatrix : Instruction
{
	public static OpMatrixTimesMatrix Instance { get; } = new();

	private OpMatrixTimesMatrix()
	{
	}

	public override string Name => nameof(OpMatrixTimesMatrix);
	public override OpCode Code => OpCode.OpMatrixTimesMatrix;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "LeftMatrix", OperandQuantifier.Default), new Operand(new IdRef(), "RightMatrix", OperandQuantifier.Default),];
}
public sealed class OpOuterProduct : Instruction
{
	public static OpOuterProduct Instance { get; } = new();

	private OpOuterProduct()
	{
	}

	public override string Name => nameof(OpOuterProduct);
	public override OpCode Code => OpCode.OpOuterProduct;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),];
}
public sealed class OpDot : Instruction
{
	public static OpDot Instance { get; } = new();

	private OpDot()
	{
	}

	public override string Name => nameof(OpDot);
	public override OpCode Code => OpCode.OpDot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),];
}
public sealed class OpIAddCarry : Instruction
{
	public static OpIAddCarry Instance { get; } = new();

	private OpIAddCarry()
	{
	}

	public override string Name => nameof(OpIAddCarry);
	public override OpCode Code => OpCode.OpIAddCarry;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpISubBorrow : Instruction
{
	public static OpISubBorrow Instance { get; } = new();

	private OpISubBorrow()
	{
	}

	public override string Name => nameof(OpISubBorrow);
	public override OpCode Code => OpCode.OpISubBorrow;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUMulExtended : Instruction
{
	public static OpUMulExtended Instance { get; } = new();

	private OpUMulExtended()
	{
	}

	public override string Name => nameof(OpUMulExtended);
	public override OpCode Code => OpCode.OpUMulExtended;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSMulExtended : Instruction
{
	public static OpSMulExtended Instance { get; } = new();

	private OpSMulExtended()
	{
	}

	public override string Name => nameof(OpSMulExtended);
	public override OpCode Code => OpCode.OpSMulExtended;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpAny : Instruction
{
	public static OpAny Instance { get; } = new();

	private OpAny()
	{
	}

	public override string Name => nameof(OpAny);
	public override OpCode Code => OpCode.OpAny;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpAll : Instruction
{
	public static OpAll Instance { get; } = new();

	private OpAll()
	{
	}

	public override string Name => nameof(OpAll);
	public override OpCode Code => OpCode.OpAll;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpIsNan : Instruction
{
	public static OpIsNan Instance { get; } = new();

	private OpIsNan()
	{
	}

	public override string Name => nameof(OpIsNan);
	public override OpCode Code => OpCode.OpIsNan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsInf : Instruction
{
	public static OpIsInf Instance { get; } = new();

	private OpIsInf()
	{
	}

	public override string Name => nameof(OpIsInf);
	public override OpCode Code => OpCode.OpIsInf;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsFinite : Instruction
{
	public static OpIsFinite Instance { get; } = new();

	private OpIsFinite()
	{
	}

	public override string Name => nameof(OpIsFinite);
	public override OpCode Code => OpCode.OpIsFinite;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsNormal : Instruction
{
	public static OpIsNormal Instance { get; } = new();

	private OpIsNormal()
	{
	}

	public override string Name => nameof(OpIsNormal);
	public override OpCode Code => OpCode.OpIsNormal;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpSignBitSet : Instruction
{
	public static OpSignBitSet Instance { get; } = new();

	private OpSignBitSet()
	{
	}

	public override string Name => nameof(OpSignBitSet);
	public override OpCode Code => OpCode.OpSignBitSet;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpLessOrGreater : Instruction
{
	public static OpLessOrGreater Instance { get; } = new();

	private OpLessOrGreater()
	{
	}

	public override string Name => nameof(OpLessOrGreater);
	public override OpCode Code => OpCode.OpLessOrGreater;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpOrdered : Instruction
{
	public static OpOrdered Instance { get; } = new();

	private OpOrdered()
	{
	}

	public override string Name => nameof(OpOrdered);
	public override OpCode Code => OpCode.OpOrdered;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpUnordered : Instruction
{
	public static OpUnordered Instance { get; } = new();

	private OpUnordered()
	{
	}

	public override string Name => nameof(OpUnordered);
	public override OpCode Code => OpCode.OpUnordered;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpLogicalEqual : Instruction
{
	public static OpLogicalEqual Instance { get; } = new();

	private OpLogicalEqual()
	{
	}

	public override string Name => nameof(OpLogicalEqual);
	public override OpCode Code => OpCode.OpLogicalEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalNotEqual : Instruction
{
	public static OpLogicalNotEqual Instance { get; } = new();

	private OpLogicalNotEqual()
	{
	}

	public override string Name => nameof(OpLogicalNotEqual);
	public override OpCode Code => OpCode.OpLogicalNotEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalOr : Instruction
{
	public static OpLogicalOr Instance { get; } = new();

	private OpLogicalOr()
	{
	}

	public override string Name => nameof(OpLogicalOr);
	public override OpCode Code => OpCode.OpLogicalOr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalAnd : Instruction
{
	public static OpLogicalAnd Instance { get; } = new();

	private OpLogicalAnd()
	{
	}

	public override string Name => nameof(OpLogicalAnd);
	public override OpCode Code => OpCode.OpLogicalAnd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalNot : Instruction
{
	public static OpLogicalNot Instance { get; } = new();

	private OpLogicalNot()
	{
	}

	public override string Name => nameof(OpLogicalNot);
	public override OpCode Code => OpCode.OpLogicalNot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpSelect : Instruction
{
	public static OpSelect Instance { get; } = new();

	private OpSelect()
	{
	}

	public override string Name => nameof(OpSelect);
	public override OpCode Code => OpCode.OpSelect;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "Object 1", OperandQuantifier.Default), new Operand(new IdRef(), "Object 2", OperandQuantifier.Default),];
}
public sealed class OpIEqual : Instruction
{
	public static OpIEqual Instance { get; } = new();

	private OpIEqual()
	{
	}

	public override string Name => nameof(OpIEqual);
	public override OpCode Code => OpCode.OpIEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpINotEqual : Instruction
{
	public static OpINotEqual Instance { get; } = new();

	private OpINotEqual()
	{
	}

	public override string Name => nameof(OpINotEqual);
	public override OpCode Code => OpCode.OpINotEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUGreaterThan : Instruction
{
	public static OpUGreaterThan Instance { get; } = new();

	private OpUGreaterThan()
	{
	}

	public override string Name => nameof(OpUGreaterThan);
	public override OpCode Code => OpCode.OpUGreaterThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSGreaterThan : Instruction
{
	public static OpSGreaterThan Instance { get; } = new();

	private OpSGreaterThan()
	{
	}

	public override string Name => nameof(OpSGreaterThan);
	public override OpCode Code => OpCode.OpSGreaterThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUGreaterThanEqual : Instruction
{
	public static OpUGreaterThanEqual Instance { get; } = new();

	private OpUGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpUGreaterThanEqual);
	public override OpCode Code => OpCode.OpUGreaterThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSGreaterThanEqual : Instruction
{
	public static OpSGreaterThanEqual Instance { get; } = new();

	private OpSGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpSGreaterThanEqual);
	public override OpCode Code => OpCode.OpSGreaterThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpULessThan : Instruction
{
	public static OpULessThan Instance { get; } = new();

	private OpULessThan()
	{
	}

	public override string Name => nameof(OpULessThan);
	public override OpCode Code => OpCode.OpULessThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSLessThan : Instruction
{
	public static OpSLessThan Instance { get; } = new();

	private OpSLessThan()
	{
	}

	public override string Name => nameof(OpSLessThan);
	public override OpCode Code => OpCode.OpSLessThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpULessThanEqual : Instruction
{
	public static OpULessThanEqual Instance { get; } = new();

	private OpULessThanEqual()
	{
	}

	public override string Name => nameof(OpULessThanEqual);
	public override OpCode Code => OpCode.OpULessThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSLessThanEqual : Instruction
{
	public static OpSLessThanEqual Instance { get; } = new();

	private OpSLessThanEqual()
	{
	}

	public override string Name => nameof(OpSLessThanEqual);
	public override OpCode Code => OpCode.OpSLessThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdEqual : Instruction
{
	public static OpFOrdEqual Instance { get; } = new();

	private OpFOrdEqual()
	{
	}

	public override string Name => nameof(OpFOrdEqual);
	public override OpCode Code => OpCode.OpFOrdEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordEqual : Instruction
{
	public static OpFUnordEqual Instance { get; } = new();

	private OpFUnordEqual()
	{
	}

	public override string Name => nameof(OpFUnordEqual);
	public override OpCode Code => OpCode.OpFUnordEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdNotEqual : Instruction
{
	public static OpFOrdNotEqual Instance { get; } = new();

	private OpFOrdNotEqual()
	{
	}

	public override string Name => nameof(OpFOrdNotEqual);
	public override OpCode Code => OpCode.OpFOrdNotEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordNotEqual : Instruction
{
	public static OpFUnordNotEqual Instance { get; } = new();

	private OpFUnordNotEqual()
	{
	}

	public override string Name => nameof(OpFUnordNotEqual);
	public override OpCode Code => OpCode.OpFUnordNotEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdLessThan : Instruction
{
	public static OpFOrdLessThan Instance { get; } = new();

	private OpFOrdLessThan()
	{
	}

	public override string Name => nameof(OpFOrdLessThan);
	public override OpCode Code => OpCode.OpFOrdLessThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordLessThan : Instruction
{
	public static OpFUnordLessThan Instance { get; } = new();

	private OpFUnordLessThan()
	{
	}

	public override string Name => nameof(OpFUnordLessThan);
	public override OpCode Code => OpCode.OpFUnordLessThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdGreaterThan : Instruction
{
	public static OpFOrdGreaterThan Instance { get; } = new();

	private OpFOrdGreaterThan()
	{
	}

	public override string Name => nameof(OpFOrdGreaterThan);
	public override OpCode Code => OpCode.OpFOrdGreaterThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordGreaterThan : Instruction
{
	public static OpFUnordGreaterThan Instance { get; } = new();

	private OpFUnordGreaterThan()
	{
	}

	public override string Name => nameof(OpFUnordGreaterThan);
	public override OpCode Code => OpCode.OpFUnordGreaterThan;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdLessThanEqual : Instruction
{
	public static OpFOrdLessThanEqual Instance { get; } = new();

	private OpFOrdLessThanEqual()
	{
	}

	public override string Name => nameof(OpFOrdLessThanEqual);
	public override OpCode Code => OpCode.OpFOrdLessThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordLessThanEqual : Instruction
{
	public static OpFUnordLessThanEqual Instance { get; } = new();

	private OpFUnordLessThanEqual()
	{
	}

	public override string Name => nameof(OpFUnordLessThanEqual);
	public override OpCode Code => OpCode.OpFUnordLessThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdGreaterThanEqual : Instruction
{
	public static OpFOrdGreaterThanEqual Instance { get; } = new();

	private OpFOrdGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpFOrdGreaterThanEqual);
	public override OpCode Code => OpCode.OpFOrdGreaterThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordGreaterThanEqual : Instruction
{
	public static OpFUnordGreaterThanEqual Instance { get; } = new();

	private OpFUnordGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpFUnordGreaterThanEqual);
	public override OpCode Code => OpCode.OpFUnordGreaterThanEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpShiftRightLogical : Instruction
{
	public static OpShiftRightLogical Instance { get; } = new();

	private OpShiftRightLogical()
	{
	}

	public override string Name => nameof(OpShiftRightLogical);
	public override OpCode Code => OpCode.OpShiftRightLogical;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpShiftRightArithmetic : Instruction
{
	public static OpShiftRightArithmetic Instance { get; } = new();

	private OpShiftRightArithmetic()
	{
	}

	public override string Name => nameof(OpShiftRightArithmetic);
	public override OpCode Code => OpCode.OpShiftRightArithmetic;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpShiftLeftLogical : Instruction
{
	public static OpShiftLeftLogical Instance { get; } = new();

	private OpShiftLeftLogical()
	{
	}

	public override string Name => nameof(OpShiftLeftLogical);
	public override OpCode Code => OpCode.OpShiftLeftLogical;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpBitwiseOr : Instruction
{
	public static OpBitwiseOr Instance { get; } = new();

	private OpBitwiseOr()
	{
	}

	public override string Name => nameof(OpBitwiseOr);
	public override OpCode Code => OpCode.OpBitwiseOr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpBitwiseXor : Instruction
{
	public static OpBitwiseXor Instance { get; } = new();

	private OpBitwiseXor()
	{
	}

	public override string Name => nameof(OpBitwiseXor);
	public override OpCode Code => OpCode.OpBitwiseXor;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpBitwiseAnd : Instruction
{
	public static OpBitwiseAnd Instance { get; } = new();

	private OpBitwiseAnd()
	{
	}

	public override string Name => nameof(OpBitwiseAnd);
	public override OpCode Code => OpCode.OpBitwiseAnd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpNot : Instruction
{
	public static OpNot Instance { get; } = new();

	private OpNot()
	{
	}

	public override string Name => nameof(OpNot);
	public override OpCode Code => OpCode.OpNot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpBitFieldInsert : Instruction
{
	public static OpBitFieldInsert Instance { get; } = new();

	private OpBitFieldInsert()
	{
	}

	public override string Name => nameof(OpBitFieldInsert);
	public override OpCode Code => OpCode.OpBitFieldInsert;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Insert", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitFieldSExtract : Instruction
{
	public static OpBitFieldSExtract Instance { get; } = new();

	private OpBitFieldSExtract()
	{
	}

	public override string Name => nameof(OpBitFieldSExtract);
	public override OpCode Code => OpCode.OpBitFieldSExtract;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitFieldUExtract : Instruction
{
	public static OpBitFieldUExtract Instance { get; } = new();

	private OpBitFieldUExtract()
	{
	}

	public override string Name => nameof(OpBitFieldUExtract);
	public override OpCode Code => OpCode.OpBitFieldUExtract;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitReverse : Instruction
{
	public static OpBitReverse Instance { get; } = new();

	private OpBitReverse()
	{
	}

	public override string Name => nameof(OpBitReverse);
	public override OpCode Code => OpCode.OpBitReverse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),];
}
public sealed class OpBitCount : Instruction
{
	public static OpBitCount Instance { get; } = new();

	private OpBitCount()
	{
	}

	public override string Name => nameof(OpBitCount);
	public override OpCode Code => OpCode.OpBitCount;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),];
}
public sealed class OpDPdx : Instruction
{
	public static OpDPdx Instance { get; } = new();

	private OpDPdx()
	{
	}

	public override string Name => nameof(OpDPdx);
	public override OpCode Code => OpCode.OpDPdx;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdy : Instruction
{
	public static OpDPdy Instance { get; } = new();

	private OpDPdy()
	{
	}

	public override string Name => nameof(OpDPdy);
	public override OpCode Code => OpCode.OpDPdy;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidth : Instruction
{
	public static OpFwidth Instance { get; } = new();

	private OpFwidth()
	{
	}

	public override string Name => nameof(OpFwidth);
	public override OpCode Code => OpCode.OpFwidth;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdxFine : Instruction
{
	public static OpDPdxFine Instance { get; } = new();

	private OpDPdxFine()
	{
	}

	public override string Name => nameof(OpDPdxFine);
	public override OpCode Code => OpCode.OpDPdxFine;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdyFine : Instruction
{
	public static OpDPdyFine Instance { get; } = new();

	private OpDPdyFine()
	{
	}

	public override string Name => nameof(OpDPdyFine);
	public override OpCode Code => OpCode.OpDPdyFine;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidthFine : Instruction
{
	public static OpFwidthFine Instance { get; } = new();

	private OpFwidthFine()
	{
	}

	public override string Name => nameof(OpFwidthFine);
	public override OpCode Code => OpCode.OpFwidthFine;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdxCoarse : Instruction
{
	public static OpDPdxCoarse Instance { get; } = new();

	private OpDPdxCoarse()
	{
	}

	public override string Name => nameof(OpDPdxCoarse);
	public override OpCode Code => OpCode.OpDPdxCoarse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdyCoarse : Instruction
{
	public static OpDPdyCoarse Instance { get; } = new();

	private OpDPdyCoarse()
	{
	}

	public override string Name => nameof(OpDPdyCoarse);
	public override OpCode Code => OpCode.OpDPdyCoarse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidthCoarse : Instruction
{
	public static OpFwidthCoarse Instance { get; } = new();

	private OpFwidthCoarse()
	{
	}

	public override string Name => nameof(OpFwidthCoarse);
	public override OpCode Code => OpCode.OpFwidthCoarse;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpEmitVertex : Instruction
{
	public static OpEmitVertex Instance { get; } = new();

	private OpEmitVertex()
	{
	}

	public override string Name => nameof(OpEmitVertex);
	public override OpCode Code => OpCode.OpEmitVertex;
}
public sealed class OpEndPrimitive : Instruction
{
	public static OpEndPrimitive Instance { get; } = new();

	private OpEndPrimitive()
	{
	}

	public override string Name => nameof(OpEndPrimitive);
	public override OpCode Code => OpCode.OpEndPrimitive;
}
public sealed class OpEmitStreamVertex : Instruction
{
	public static OpEmitStreamVertex Instance { get; } = new();

	private OpEmitStreamVertex()
	{
	}

	public override string Name => nameof(OpEmitStreamVertex);
	public override OpCode Code => OpCode.OpEmitStreamVertex;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),];
}
public sealed class OpEndStreamPrimitive : Instruction
{
	public static OpEndStreamPrimitive Instance { get; } = new();

	private OpEndStreamPrimitive()
	{
	}

	public override string Name => nameof(OpEndStreamPrimitive);
	public override OpCode Code => OpCode.OpEndStreamPrimitive;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),];
}
public sealed class OpControlBarrier : Instruction
{
	public static OpControlBarrier Instance { get; } = new();

	private OpControlBarrier()
	{
	}

	public override string Name => nameof(OpControlBarrier);
	public override OpCode Code => OpCode.OpControlBarrier;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpMemoryBarrier : Instruction
{
	public static OpMemoryBarrier Instance { get; } = new();

	private OpMemoryBarrier()
	{
	}

	public override string Name => nameof(OpMemoryBarrier);
	public override OpCode Code => OpCode.OpMemoryBarrier;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicLoad : Instruction
{
	public static OpAtomicLoad Instance { get; } = new();

	private OpAtomicLoad()
	{
	}

	public override string Name => nameof(OpAtomicLoad);
	public override OpCode Code => OpCode.OpAtomicLoad;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicStore : Instruction
{
	public static OpAtomicStore Instance { get; } = new();

	private OpAtomicStore()
	{
	}

	public override string Name => nameof(OpAtomicStore);
	public override OpCode Code => OpCode.OpAtomicStore;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicExchange : Instruction
{
	public static OpAtomicExchange Instance { get; } = new();

	private OpAtomicExchange()
	{
	}

	public override string Name => nameof(OpAtomicExchange);
	public override OpCode Code => OpCode.OpAtomicExchange;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicCompareExchange : Instruction
{
	public static OpAtomicCompareExchange Instance { get; } = new();

	private OpAtomicCompareExchange()
	{
	}

	public override string Name => nameof(OpAtomicCompareExchange);
	public override OpCode Code => OpCode.OpAtomicCompareExchange;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
}
public sealed class OpAtomicCompareExchangeWeak : Instruction
{
	public static OpAtomicCompareExchangeWeak Instance { get; } = new();

	private OpAtomicCompareExchangeWeak()
	{
	}

	public override string Name => nameof(OpAtomicCompareExchangeWeak);
	public override OpCode Code => OpCode.OpAtomicCompareExchangeWeak;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
}
public sealed class OpAtomicIIncrement : Instruction
{
	public static OpAtomicIIncrement Instance { get; } = new();

	private OpAtomicIIncrement()
	{
	}

	public override string Name => nameof(OpAtomicIIncrement);
	public override OpCode Code => OpCode.OpAtomicIIncrement;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicIDecrement : Instruction
{
	public static OpAtomicIDecrement Instance { get; } = new();

	private OpAtomicIDecrement()
	{
	}

	public override string Name => nameof(OpAtomicIDecrement);
	public override OpCode Code => OpCode.OpAtomicIDecrement;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicIAdd : Instruction
{
	public static OpAtomicIAdd Instance { get; } = new();

	private OpAtomicIAdd()
	{
	}

	public override string Name => nameof(OpAtomicIAdd);
	public override OpCode Code => OpCode.OpAtomicIAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicISub : Instruction
{
	public static OpAtomicISub Instance { get; } = new();

	private OpAtomicISub()
	{
	}

	public override string Name => nameof(OpAtomicISub);
	public override OpCode Code => OpCode.OpAtomicISub;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicSMin : Instruction
{
	public static OpAtomicSMin Instance { get; } = new();

	private OpAtomicSMin()
	{
	}

	public override string Name => nameof(OpAtomicSMin);
	public override OpCode Code => OpCode.OpAtomicSMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicUMin : Instruction
{
	public static OpAtomicUMin Instance { get; } = new();

	private OpAtomicUMin()
	{
	}

	public override string Name => nameof(OpAtomicUMin);
	public override OpCode Code => OpCode.OpAtomicUMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicSMax : Instruction
{
	public static OpAtomicSMax Instance { get; } = new();

	private OpAtomicSMax()
	{
	}

	public override string Name => nameof(OpAtomicSMax);
	public override OpCode Code => OpCode.OpAtomicSMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicUMax : Instruction
{
	public static OpAtomicUMax Instance { get; } = new();

	private OpAtomicUMax()
	{
	}

	public override string Name => nameof(OpAtomicUMax);
	public override OpCode Code => OpCode.OpAtomicUMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicAnd : Instruction
{
	public static OpAtomicAnd Instance { get; } = new();

	private OpAtomicAnd()
	{
	}

	public override string Name => nameof(OpAtomicAnd);
	public override OpCode Code => OpCode.OpAtomicAnd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicOr : Instruction
{
	public static OpAtomicOr Instance { get; } = new();

	private OpAtomicOr()
	{
	}

	public override string Name => nameof(OpAtomicOr);
	public override OpCode Code => OpCode.OpAtomicOr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicXor : Instruction
{
	public static OpAtomicXor Instance { get; } = new();

	private OpAtomicXor()
	{
	}

	public override string Name => nameof(OpAtomicXor);
	public override OpCode Code => OpCode.OpAtomicXor;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpPhi : Instruction
{
	public static OpPhi Instance { get; } = new();

	private OpPhi()
	{
	}

	public override string Name => nameof(OpPhi);
	public override OpCode Code => OpCode.OpPhi;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new PairIdRefIdRef(), "Variable, Parent, ...", OperandQuantifier.Varying),];
}
public sealed class OpLoopMerge : Instruction
{
	public static OpLoopMerge Instance { get; } = new();

	private OpLoopMerge()
	{
	}

	public override string Name => nameof(OpLoopMerge);
	public override OpCode Code => OpCode.OpLoopMerge;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new IdRef(), "Continue Target", OperandQuantifier.Default), new Operand(new EnumType<LoopControl, LoopControlParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpSelectionMerge : Instruction
{
	public static OpSelectionMerge Instance { get; } = new();

	private OpSelectionMerge()
	{
	}

	public override string Name => nameof(OpSelectionMerge);
	public override OpCode Code => OpCode.OpSelectionMerge;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new EnumType<SelectionControl, SelectionControlParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpLabel : Instruction
{
	public static OpLabel Instance { get; } = new();

	private OpLabel()
	{
	}

	public override string Name => nameof(OpLabel);
	public override OpCode Code => OpCode.OpLabel;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpBranch : Instruction
{
	public static OpBranch Instance { get; } = new();

	private OpBranch()
	{
	}

	public override string Name => nameof(OpBranch);
	public override OpCode Code => OpCode.OpBranch;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target Label", OperandQuantifier.Default),];
}
public sealed class OpBranchConditional : Instruction
{
	public static OpBranchConditional Instance { get; } = new();

	private OpBranchConditional()
	{
	}

	public override string Name => nameof(OpBranchConditional);
	public override OpCode Code => OpCode.OpBranchConditional;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "True Label", OperandQuantifier.Default), new Operand(new IdRef(), "False Label", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Branch weights", OperandQuantifier.Varying),];
}
public sealed class OpSwitch : Instruction
{
	public static OpSwitch Instance { get; } = new();

	private OpSwitch()
	{
	}

	public override string Name => nameof(OpSwitch);
	public override OpCode Code => OpCode.OpSwitch;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Selector", OperandQuantifier.Default), new Operand(new IdRef(), "Default", OperandQuantifier.Default), new Operand(new PairLiteralIntegerIdRef(), "Target", OperandQuantifier.Varying),];
}
public sealed class OpKill : Instruction
{
	public static OpKill Instance { get; } = new();

	private OpKill()
	{
	}

	public override string Name => nameof(OpKill);
	public override OpCode Code => OpCode.OpKill;
}
public sealed class OpReturn : Instruction
{
	public static OpReturn Instance { get; } = new();

	private OpReturn()
	{
	}

	public override string Name => nameof(OpReturn);
	public override OpCode Code => OpCode.OpReturn;
}
public sealed class OpReturnValue : Instruction
{
	public static OpReturnValue Instance { get; } = new();

	private OpReturnValue()
	{
	}

	public override string Name => nameof(OpReturnValue);
	public override OpCode Code => OpCode.OpReturnValue;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpUnreachable : Instruction
{
	public static OpUnreachable Instance { get; } = new();

	private OpUnreachable()
	{
	}

	public override string Name => nameof(OpUnreachable);
	public override OpCode Code => OpCode.OpUnreachable;
}
public sealed class OpLifetimeStart : Instruction
{
	public static OpLifetimeStart Instance { get; } = new();

	private OpLifetimeStart()
	{
	}

	public override string Name => nameof(OpLifetimeStart);
	public override OpCode Code => OpCode.OpLifetimeStart;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),];
}
public sealed class OpLifetimeStop : Instruction
{
	public static OpLifetimeStop Instance { get; } = new();

	private OpLifetimeStop()
	{
	}

	public override string Name => nameof(OpLifetimeStop);
	public override OpCode Code => OpCode.OpLifetimeStop;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),];
}
public sealed class OpGroupAsyncCopy : Instruction
{
	public static OpGroupAsyncCopy Instance { get; } = new();

	private OpGroupAsyncCopy()
	{
	}

	public override string Name => nameof(OpGroupAsyncCopy);
	public override OpCode Code => OpCode.OpGroupAsyncCopy;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Destination", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Num Elements", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpGroupWaitEvents : Instruction
{
	public static OpGroupWaitEvents Instance { get; } = new();

	private OpGroupWaitEvents()
	{
	}

	public override string Name => nameof(OpGroupWaitEvents);
	public override OpCode Code => OpCode.OpGroupWaitEvents;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Events List", OperandQuantifier.Default),];
}
public sealed class OpGroupAll : Instruction
{
	public static OpGroupAll Instance { get; } = new();

	private OpGroupAll()
	{
	}

	public override string Name => nameof(OpGroupAll);
	public override OpCode Code => OpCode.OpGroupAll;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupAny : Instruction
{
	public static OpGroupAny Instance { get; } = new();

	private OpGroupAny()
	{
	}

	public override string Name => nameof(OpGroupAny);
	public override OpCode Code => OpCode.OpGroupAny;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupBroadcast : Instruction
{
	public static OpGroupBroadcast Instance { get; } = new();

	private OpGroupBroadcast()
	{
	}

	public override string Name => nameof(OpGroupBroadcast);
	public override OpCode Code => OpCode.OpGroupBroadcast;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "LocalId", OperandQuantifier.Default),];
}
public sealed class OpGroupIAdd : Instruction
{
	public static OpGroupIAdd Instance { get; } = new();

	private OpGroupIAdd()
	{
	}

	public override string Name => nameof(OpGroupIAdd);
	public override OpCode Code => OpCode.OpGroupIAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFAdd : Instruction
{
	public static OpGroupFAdd Instance { get; } = new();

	private OpGroupFAdd()
	{
	}

	public override string Name => nameof(OpGroupFAdd);
	public override OpCode Code => OpCode.OpGroupFAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMin : Instruction
{
	public static OpGroupFMin Instance { get; } = new();

	private OpGroupFMin()
	{
	}

	public override string Name => nameof(OpGroupFMin);
	public override OpCode Code => OpCode.OpGroupFMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMin : Instruction
{
	public static OpGroupUMin Instance { get; } = new();

	private OpGroupUMin()
	{
	}

	public override string Name => nameof(OpGroupUMin);
	public override OpCode Code => OpCode.OpGroupUMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMin : Instruction
{
	public static OpGroupSMin Instance { get; } = new();

	private OpGroupSMin()
	{
	}

	public override string Name => nameof(OpGroupSMin);
	public override OpCode Code => OpCode.OpGroupSMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMax : Instruction
{
	public static OpGroupFMax Instance { get; } = new();

	private OpGroupFMax()
	{
	}

	public override string Name => nameof(OpGroupFMax);
	public override OpCode Code => OpCode.OpGroupFMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMax : Instruction
{
	public static OpGroupUMax Instance { get; } = new();

	private OpGroupUMax()
	{
	}

	public override string Name => nameof(OpGroupUMax);
	public override OpCode Code => OpCode.OpGroupUMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMax : Instruction
{
	public static OpGroupSMax Instance { get; } = new();

	private OpGroupSMax()
	{
	}

	public override string Name => nameof(OpGroupSMax);
	public override OpCode Code => OpCode.OpGroupSMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpReadPipe : Instruction
{
	public static OpReadPipe Instance { get; } = new();

	private OpReadPipe()
	{
	}

	public override string Name => nameof(OpReadPipe);
	public override OpCode Code => OpCode.OpReadPipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpWritePipe : Instruction
{
	public static OpWritePipe Instance { get; } = new();

	private OpWritePipe()
	{
	}

	public override string Name => nameof(OpWritePipe);
	public override OpCode Code => OpCode.OpWritePipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReservedReadPipe : Instruction
{
	public static OpReservedReadPipe Instance { get; } = new();

	private OpReservedReadPipe()
	{
	}

	public override string Name => nameof(OpReservedReadPipe);
	public override OpCode Code => OpCode.OpReservedReadPipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReservedWritePipe : Instruction
{
	public static OpReservedWritePipe Instance { get; } = new();

	private OpReservedWritePipe()
	{
	}

	public override string Name => nameof(OpReservedWritePipe);
	public override OpCode Code => OpCode.OpReservedWritePipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReserveReadPipePackets : Instruction
{
	public static OpReserveReadPipePackets Instance { get; } = new();

	private OpReserveReadPipePackets()
	{
	}

	public override string Name => nameof(OpReserveReadPipePackets);
	public override OpCode Code => OpCode.OpReserveReadPipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReserveWritePipePackets : Instruction
{
	public static OpReserveWritePipePackets Instance { get; } = new();

	private OpReserveWritePipePackets()
	{
	}

	public override string Name => nameof(OpReserveWritePipePackets);
	public override OpCode Code => OpCode.OpReserveWritePipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpCommitReadPipe : Instruction
{
	public static OpCommitReadPipe Instance { get; } = new();

	private OpCommitReadPipe()
	{
	}

	public override string Name => nameof(OpCommitReadPipe);
	public override OpCode Code => OpCode.OpCommitReadPipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpCommitWritePipe : Instruction
{
	public static OpCommitWritePipe Instance { get; } = new();

	private OpCommitWritePipe()
	{
	}

	public override string Name => nameof(OpCommitWritePipe);
	public override OpCode Code => OpCode.OpCommitWritePipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpIsValidReserveId : Instruction
{
	public static OpIsValidReserveId Instance { get; } = new();

	private OpIsValidReserveId()
	{
	}

	public override string Name => nameof(OpIsValidReserveId);
	public override OpCode Code => OpCode.OpIsValidReserveId;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default),];
}
public sealed class OpGetNumPipePackets : Instruction
{
	public static OpGetNumPipePackets Instance { get; } = new();

	private OpGetNumPipePackets()
	{
	}

	public override string Name => nameof(OpGetNumPipePackets);
	public override OpCode Code => OpCode.OpGetNumPipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGetMaxPipePackets : Instruction
{
	public static OpGetMaxPipePackets Instance { get; } = new();

	private OpGetMaxPipePackets()
	{
	}

	public override string Name => nameof(OpGetMaxPipePackets);
	public override OpCode Code => OpCode.OpGetMaxPipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupReserveReadPipePackets : Instruction
{
	public static OpGroupReserveReadPipePackets Instance { get; } = new();

	private OpGroupReserveReadPipePackets()
	{
	}

	public override string Name => nameof(OpGroupReserveReadPipePackets);
	public override OpCode Code => OpCode.OpGroupReserveReadPipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupReserveWritePipePackets : Instruction
{
	public static OpGroupReserveWritePipePackets Instance { get; } = new();

	private OpGroupReserveWritePipePackets()
	{
	}

	public override string Name => nameof(OpGroupReserveWritePipePackets);
	public override OpCode Code => OpCode.OpGroupReserveWritePipePackets;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupCommitReadPipe : Instruction
{
	public static OpGroupCommitReadPipe Instance { get; } = new();

	private OpGroupCommitReadPipe()
	{
	}

	public override string Name => nameof(OpGroupCommitReadPipe);
	public override OpCode Code => OpCode.OpGroupCommitReadPipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupCommitWritePipe : Instruction
{
	public static OpGroupCommitWritePipe Instance { get; } = new();

	private OpGroupCommitWritePipe()
	{
	}

	public override string Name => nameof(OpGroupCommitWritePipe);
	public override OpCode Code => OpCode.OpGroupCommitWritePipe;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpEnqueueMarker : Instruction
{
	public static OpEnqueueMarker Instance { get; } = new();

	private OpEnqueueMarker()
	{
	}

	public override string Name => nameof(OpEnqueueMarker);
	public override OpCode Code => OpCode.OpEnqueueMarker;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default),];
}
public sealed class OpEnqueueKernel : Instruction
{
	public static OpEnqueueKernel Instance { get; } = new();

	private OpEnqueueKernel()
	{
	}

	public override string Name => nameof(OpEnqueueKernel);
	public override OpCode Code => OpCode.OpEnqueueKernel;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Flags", OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default), new Operand(new IdRef(), "Local Size", OperandQuantifier.Varying),];
}
public sealed class OpGetKernelNDrangeSubGroupCount : Instruction
{
	public static OpGetKernelNDrangeSubGroupCount Instance { get; } = new();

	private OpGetKernelNDrangeSubGroupCount()
	{
	}

	public override string Name => nameof(OpGetKernelNDrangeSubGroupCount);
	public override OpCode Code => OpCode.OpGetKernelNDrangeSubGroupCount;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelNDrangeMaxSubGroupSize : Instruction
{
	public static OpGetKernelNDrangeMaxSubGroupSize Instance { get; } = new();

	private OpGetKernelNDrangeMaxSubGroupSize()
	{
	}

	public override string Name => nameof(OpGetKernelNDrangeMaxSubGroupSize);
	public override OpCode Code => OpCode.OpGetKernelNDrangeMaxSubGroupSize;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelWorkGroupSize : Instruction
{
	public static OpGetKernelWorkGroupSize Instance { get; } = new();

	private OpGetKernelWorkGroupSize()
	{
	}

	public override string Name => nameof(OpGetKernelWorkGroupSize);
	public override OpCode Code => OpCode.OpGetKernelWorkGroupSize;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelPreferredWorkGroupSizeMultiple : Instruction
{
	public static OpGetKernelPreferredWorkGroupSizeMultiple Instance { get; } = new();

	private OpGetKernelPreferredWorkGroupSizeMultiple()
	{
	}

	public override string Name => nameof(OpGetKernelPreferredWorkGroupSizeMultiple);
	public override OpCode Code => OpCode.OpGetKernelPreferredWorkGroupSizeMultiple;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpRetainEvent : Instruction
{
	public static OpRetainEvent Instance { get; } = new();

	private OpRetainEvent()
	{
	}

	public override string Name => nameof(OpRetainEvent);
	public override OpCode Code => OpCode.OpRetainEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpReleaseEvent : Instruction
{
	public static OpReleaseEvent Instance { get; } = new();

	private OpReleaseEvent()
	{
	}

	public override string Name => nameof(OpReleaseEvent);
	public override OpCode Code => OpCode.OpReleaseEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpCreateUserEvent : Instruction
{
	public static OpCreateUserEvent Instance { get; } = new();

	private OpCreateUserEvent()
	{
	}

	public override string Name => nameof(OpCreateUserEvent);
	public override OpCode Code => OpCode.OpCreateUserEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpIsValidEvent : Instruction
{
	public static OpIsValidEvent Instance { get; } = new();

	private OpIsValidEvent()
	{
	}

	public override string Name => nameof(OpIsValidEvent);
	public override OpCode Code => OpCode.OpIsValidEvent;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpSetUserEventStatus : Instruction
{
	public static OpSetUserEventStatus Instance { get; } = new();

	private OpSetUserEventStatus()
	{
	}

	public override string Name => nameof(OpSetUserEventStatus);
	public override OpCode Code => OpCode.OpSetUserEventStatus;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Status", OperandQuantifier.Default),];
}
public sealed class OpCaptureEventProfilingInfo : Instruction
{
	public static OpCaptureEventProfilingInfo Instance { get; } = new();

	private OpCaptureEventProfilingInfo()
	{
	}

	public override string Name => nameof(OpCaptureEventProfilingInfo);
	public override OpCode Code => OpCode.OpCaptureEventProfilingInfo;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Profiling Info", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGetDefaultQueue : Instruction
{
	public static OpGetDefaultQueue Instance { get; } = new();

	private OpGetDefaultQueue()
	{
	}

	public override string Name => nameof(OpGetDefaultQueue);
	public override OpCode Code => OpCode.OpGetDefaultQueue;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpBuildNDRange : Instruction
{
	public static OpBuildNDRange Instance { get; } = new();

	private OpBuildNDRange()
	{
	}

	public override string Name => nameof(OpBuildNDRange);
	public override OpCode Code => OpCode.OpBuildNDRange;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "LocalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkOffset", OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleImplicitLod : Instruction
{
	public static OpImageSparseSampleImplicitLod Instance { get; } = new();

	private OpImageSparseSampleImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleExplicitLod : Instruction
{
	public static OpImageSparseSampleExplicitLod Instance { get; } = new();

	private OpImageSparseSampleExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleDrefImplicitLod : Instruction
{
	public static OpImageSparseSampleDrefImplicitLod Instance { get; } = new();

	private OpImageSparseSampleDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleDrefImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleDrefExplicitLod : Instruction
{
	public static OpImageSparseSampleDrefExplicitLod Instance { get; } = new();

	private OpImageSparseSampleDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleDrefExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleProjImplicitLod : Instruction
{
	public static OpImageSparseSampleProjImplicitLod Instance { get; } = new();

	private OpImageSparseSampleProjImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleProjExplicitLod : Instruction
{
	public static OpImageSparseSampleProjExplicitLod Instance { get; } = new();

	private OpImageSparseSampleProjExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleProjDrefImplicitLod : Instruction
{
	public static OpImageSparseSampleProjDrefImplicitLod Instance { get; } = new();

	private OpImageSparseSampleProjDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjDrefImplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleProjDrefExplicitLod : Instruction
{
	public static OpImageSparseSampleProjDrefExplicitLod Instance { get; } = new();

	private OpImageSparseSampleProjDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjDrefExplicitLod;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseFetch : Instruction
{
	public static OpImageSparseFetch Instance { get; } = new();

	private OpImageSparseFetch()
	{
	}

	public override string Name => nameof(OpImageSparseFetch);
	public override OpCode Code => OpCode.OpImageSparseFetch;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseGather : Instruction
{
	public static OpImageSparseGather Instance { get; } = new();

	private OpImageSparseGather()
	{
	}

	public override string Name => nameof(OpImageSparseGather);
	public override OpCode Code => OpCode.OpImageSparseGather;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseDrefGather : Instruction
{
	public static OpImageSparseDrefGather Instance { get; } = new();

	private OpImageSparseDrefGather()
	{
	}

	public override string Name => nameof(OpImageSparseDrefGather);
	public override OpCode Code => OpCode.OpImageSparseDrefGather;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseTexelsResident : Instruction
{
	public static OpImageSparseTexelsResident Instance { get; } = new();

	private OpImageSparseTexelsResident()
	{
	}

	public override string Name => nameof(OpImageSparseTexelsResident);
	public override OpCode Code => OpCode.OpImageSparseTexelsResident;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Resident Code", OperandQuantifier.Default),];
}
public sealed class OpNoLine : Instruction
{
	public static OpNoLine Instance { get; } = new();

	private OpNoLine()
	{
	}

	public override string Name => nameof(OpNoLine);
	public override OpCode Code => OpCode.OpNoLine;
}
public sealed class OpAtomicFlagTestAndSet : Instruction
{
	public static OpAtomicFlagTestAndSet Instance { get; } = new();

	private OpAtomicFlagTestAndSet()
	{
	}

	public override string Name => nameof(OpAtomicFlagTestAndSet);
	public override OpCode Code => OpCode.OpAtomicFlagTestAndSet;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicFlagClear : Instruction
{
	public static OpAtomicFlagClear Instance { get; } = new();

	private OpAtomicFlagClear()
	{
	}

	public override string Name => nameof(OpAtomicFlagClear);
	public override OpCode Code => OpCode.OpAtomicFlagClear;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpImageSparseRead : Instruction
{
	public static OpImageSparseRead Instance { get; } = new();

	private OpImageSparseRead()
	{
	}

	public override string Name => nameof(OpImageSparseRead);
	public override OpCode Code => OpCode.OpImageSparseRead;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpSizeOf : Instruction
{
	public static OpSizeOf Instance { get; } = new();

	private OpSizeOf()
	{
	}

	public override string Name => nameof(OpSizeOf);
	public override OpCode Code => OpCode.OpSizeOf;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpTypePipeStorage : Instruction
{
	public static OpTypePipeStorage Instance { get; } = new();

	private OpTypePipeStorage()
	{
	}

	public override string Name => nameof(OpTypePipeStorage);
	public override OpCode Code => OpCode.OpTypePipeStorage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantPipeStorage : Instruction
{
	public static OpConstantPipeStorage Instance { get; } = new();

	private OpConstantPipeStorage()
	{
	}

	public override string Name => nameof(OpConstantPipeStorage);
	public override OpCode Code => OpCode.OpConstantPipeStorage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Size", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Alignment", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Capacity", OperandQuantifier.Default),];
}
public sealed class OpCreatePipeFromPipeStorage : Instruction
{
	public static OpCreatePipeFromPipeStorage Instance { get; } = new();

	private OpCreatePipeFromPipeStorage()
	{
	}

	public override string Name => nameof(OpCreatePipeFromPipeStorage);
	public override OpCode Code => OpCode.OpCreatePipeFromPipeStorage;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe Storage", OperandQuantifier.Default),];
}
public sealed class OpGetKernelLocalSizeForSubgroupCount : Instruction
{
	public static OpGetKernelLocalSizeForSubgroupCount Instance { get; } = new();

	private OpGetKernelLocalSizeForSubgroupCount()
	{
	}

	public override string Name => nameof(OpGetKernelLocalSizeForSubgroupCount);
	public override OpCode Code => OpCode.OpGetKernelLocalSizeForSubgroupCount;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelMaxNumSubgroups : Instruction
{
	public static OpGetKernelMaxNumSubgroups Instance { get; } = new();

	private OpGetKernelMaxNumSubgroups()
	{
	}

	public override string Name => nameof(OpGetKernelMaxNumSubgroups);
	public override OpCode Code => OpCode.OpGetKernelMaxNumSubgroups;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpTypeNamedBarrier : Instruction
{
	public static OpTypeNamedBarrier Instance { get; } = new();

	private OpTypeNamedBarrier()
	{
	}

	public override string Name => nameof(OpTypeNamedBarrier);
	public override OpCode Code => OpCode.OpTypeNamedBarrier;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpNamedBarrierInitialize : Instruction
{
	public static OpNamedBarrierInitialize Instance { get; } = new();

	private OpNamedBarrierInitialize()
	{
	}

	public override string Name => nameof(OpNamedBarrierInitialize);
	public override OpCode Code => OpCode.OpNamedBarrierInitialize;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default),];
}
public sealed class OpMemoryNamedBarrier : Instruction
{
	public static OpMemoryNamedBarrier Instance { get; } = new();

	private OpMemoryNamedBarrier()
	{
	}

	public override string Name => nameof(OpMemoryNamedBarrier);
	public override OpCode Code => OpCode.OpMemoryNamedBarrier;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Named Barrier", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpModuleProcessed : Instruction
{
	public static OpModuleProcessed Instance { get; } = new();

	private OpModuleProcessed()
	{
	}

	public override string Name => nameof(OpModuleProcessed);
	public override OpCode Code => OpCode.OpModuleProcessed;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Process", OperandQuantifier.Default),];
}
public sealed class OpExecutionModeId : Instruction
{
	public static OpExecutionModeId Instance { get; } = new();

	private OpExecutionModeId()
	{
	}

	public override string Name => nameof(OpExecutionModeId);
	public override OpCode Code => OpCode.OpExecutionModeId;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),];
}
public sealed class OpDecorateId : Instruction
{
	public static OpDecorateId Instance { get; } = new();

	private OpDecorateId()
	{
	}

	public override string Name => nameof(OpDecorateId);
	public override OpCode Code => OpCode.OpDecorateId;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupBallotKHR : Instruction
{
	public static OpSubgroupBallotKHR Instance { get; } = new();

	private OpSubgroupBallotKHR()
	{
	}

	public override string Name => nameof(OpSubgroupBallotKHR);
	public override OpCode Code => OpCode.OpSubgroupBallotKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupFirstInvocationKHR : Instruction
{
	public static OpSubgroupFirstInvocationKHR Instance { get; } = new();

	private OpSubgroupFirstInvocationKHR()
	{
	}

	public override string Name => nameof(OpSubgroupFirstInvocationKHR);
	public override OpCode Code => OpCode.OpSubgroupFirstInvocationKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAllKHR : Instruction
{
	public static OpSubgroupAllKHR Instance { get; } = new();

	private OpSubgroupAllKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAllKHR);
	public override OpCode Code => OpCode.OpSubgroupAllKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAnyKHR : Instruction
{
	public static OpSubgroupAnyKHR Instance { get; } = new();

	private OpSubgroupAnyKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAnyKHR);
	public override OpCode Code => OpCode.OpSubgroupAnyKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAllEqualKHR : Instruction
{
	public static OpSubgroupAllEqualKHR Instance { get; } = new();

	private OpSubgroupAllEqualKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAllEqualKHR);
	public override OpCode Code => OpCode.OpSubgroupAllEqualKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupReadInvocationKHR : Instruction
{
	public static OpSubgroupReadInvocationKHR Instance { get; } = new();

	private OpSubgroupReadInvocationKHR()
	{
	}

	public override string Name => nameof(OpSubgroupReadInvocationKHR);
	public override OpCode Code => OpCode.OpSubgroupReadInvocationKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpGroupIAddNonUniformAMD : Instruction
{
	public static OpGroupIAddNonUniformAMD Instance { get; } = new();

	private OpGroupIAddNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupIAddNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupIAddNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFAddNonUniformAMD : Instruction
{
	public static OpGroupFAddNonUniformAMD Instance { get; } = new();

	private OpGroupFAddNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFAddNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFAddNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMinNonUniformAMD : Instruction
{
	public static OpGroupFMinNonUniformAMD Instance { get; } = new();

	private OpGroupFMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFMinNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMinNonUniformAMD : Instruction
{
	public static OpGroupUMinNonUniformAMD Instance { get; } = new();

	private OpGroupUMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupUMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupUMinNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMinNonUniformAMD : Instruction
{
	public static OpGroupSMinNonUniformAMD Instance { get; } = new();

	private OpGroupSMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupSMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupSMinNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMaxNonUniformAMD : Instruction
{
	public static OpGroupFMaxNonUniformAMD Instance { get; } = new();

	private OpGroupFMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFMaxNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMaxNonUniformAMD : Instruction
{
	public static OpGroupUMaxNonUniformAMD Instance { get; } = new();

	private OpGroupUMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupUMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupUMaxNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMaxNonUniformAMD : Instruction
{
	public static OpGroupSMaxNonUniformAMD Instance { get; } = new();

	private OpGroupSMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupSMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupSMaxNonUniformAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpFragmentMaskFetchAMD : Instruction
{
	public static OpFragmentMaskFetchAMD Instance { get; } = new();

	private OpFragmentMaskFetchAMD()
	{
	}

	public override string Name => nameof(OpFragmentMaskFetchAMD);
	public override OpCode Code => OpCode.OpFragmentMaskFetchAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpFragmentFetchAMD : Instruction
{
	public static OpFragmentFetchAMD Instance { get; } = new();

	private OpFragmentFetchAMD()
	{
	}

	public override string Name => nameof(OpFragmentFetchAMD);
	public override OpCode Code => OpCode.OpFragmentFetchAMD;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Fragment Index", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleINTEL : Instruction
{
	public static OpSubgroupShuffleINTEL Instance { get; } = new();

	private OpSubgroupShuffleINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "InvocationId", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleDownINTEL : Instruction
{
	public static OpSubgroupShuffleDownINTEL Instance { get; } = new();

	private OpSubgroupShuffleDownINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleDownINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleDownINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Next", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleUpINTEL : Instruction
{
	public static OpSubgroupShuffleUpINTEL Instance { get; } = new();

	private OpSubgroupShuffleUpINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleUpINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleUpINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Previous", OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleXorINTEL : Instruction
{
	public static OpSubgroupShuffleXorINTEL Instance { get; } = new();

	private OpSubgroupShuffleXorINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleXorINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleXorINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSubgroupBlockReadINTEL : Instruction
{
	public static OpSubgroupBlockReadINTEL Instance { get; } = new();

	private OpSubgroupBlockReadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupBlockReadINTEL);
	public override OpCode Code => OpCode.OpSubgroupBlockReadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Ptr", OperandQuantifier.Default),];
}
public sealed class OpSubgroupBlockWriteINTEL : Instruction
{
	public static OpSubgroupBlockWriteINTEL Instance { get; } = new();

	private OpSubgroupBlockWriteINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupBlockWriteINTEL);
	public override OpCode Code => OpCode.OpSubgroupBlockWriteINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Ptr", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),];
}
public sealed class OpSubgroupImageBlockReadINTEL : Instruction
{
	public static OpSubgroupImageBlockReadINTEL Instance { get; } = new();

	private OpSubgroupImageBlockReadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageBlockReadINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageBlockReadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupImageBlockWriteINTEL : Instruction
{
	public static OpSubgroupImageBlockWriteINTEL Instance { get; } = new();

	private OpSubgroupImageBlockWriteINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageBlockWriteINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageBlockWriteINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),];
}
public sealed class OpDecorateStringGOOGLE : Instruction
{
	public static OpDecorateStringGOOGLE Instance { get; } = new();

	private OpDecorateStringGOOGLE()
	{
	}

	public override string Name => nameof(OpDecorateStringGOOGLE);
	public override OpCode Code => OpCode.OpDecorateStringGOOGLE;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpMemberDecorateStringGOOGLE : Instruction
{
	public static OpMemberDecorateStringGOOGLE Instance { get; } = new();

	private OpMemberDecorateStringGOOGLE()
	{
	}

	public override string Name => nameof(OpMemberDecorateStringGOOGLE);
	public override OpCode Code => OpCode.OpMemberDecorateStringGOOGLE;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Struct Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}