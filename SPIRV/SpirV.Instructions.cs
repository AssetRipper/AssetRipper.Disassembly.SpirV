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
	private OpNop()
	{
	}

	public override string Name => nameof(OpNop);
	public override OpCode Code => OpCode.OpNop;
	public static OpNop Instance { get; } = new();
}
public sealed class OpUndef : Instruction
{
	private OpUndef()
	{
	}

	public override string Name => nameof(OpUndef);
	public override OpCode Code => OpCode.OpUndef;
	public static OpUndef Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSourceContinued : Instruction
{
	private OpSourceContinued()
	{
	}

	public override string Name => nameof(OpSourceContinued);
	public override OpCode Code => OpCode.OpSourceContinued;
	public static OpSourceContinued Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Continued Source", OperandQuantifier.Default),];
}
public sealed class OpSource : Instruction
{
	private OpSource()
	{
	}

	public override string Name => nameof(OpSource);
	public override OpCode Code => OpCode.OpSource;
	public static OpSource Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<SourceLanguage, SourceLanguageParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Version", OperandQuantifier.Default), new Operand(new IdRef(), "File", OperandQuantifier.Optional), new Operand(new LiteralString(), "Source", OperandQuantifier.Optional),];
}
public sealed class OpSourceExtension : Instruction
{
	private OpSourceExtension()
	{
	}

	public override string Name => nameof(OpSourceExtension);
	public override OpCode Code => OpCode.OpSourceExtension;
	public static OpSourceExtension Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Extension", OperandQuantifier.Default),];
}
public sealed class OpName : Instruction
{
	private OpName()
	{
	}

	public override string Name => nameof(OpName);
	public override OpCode Code => OpCode.OpName;
	public static OpName Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpMemberName : Instruction
{
	private OpMemberName()
	{
	}

	public override string Name => nameof(OpMemberName);
	public override OpCode Code => OpCode.OpMemberName;
	public static OpMemberName Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpString : Instruction
{
	private OpString()
	{
	}

	public override string Name => nameof(OpString);
	public override OpCode Code => OpCode.OpString;
	public static OpString Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "String", OperandQuantifier.Default),];
}
public sealed class OpLine : Instruction
{
	private OpLine()
	{
	}

	public override string Name => nameof(OpLine);
	public override OpCode Code => OpCode.OpLine;
	public static OpLine Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "File", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Line", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column", OperandQuantifier.Default),];
}
public sealed class OpExtension : Instruction
{
	private OpExtension()
	{
	}

	public override string Name => nameof(OpExtension);
	public override OpCode Code => OpCode.OpExtension;
	public static OpExtension Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpExtInstImport : Instruction
{
	private OpExtInstImport()
	{
	}

	public override string Name => nameof(OpExtInstImport);
	public override OpCode Code => OpCode.OpExtInstImport;
	public static OpExtInstImport Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpExtInst : Instruction
{
	private OpExtInst()
	{
	}

	public override string Name => nameof(OpExtInst);
	public override OpCode Code => OpCode.OpExtInst;
	public static OpExtInst Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Set", OperandQuantifier.Default), new Operand(new LiteralExtInstInteger(), "Instruction", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1, +Operand 2, +...", OperandQuantifier.Varying),];
}
public sealed class OpMemoryModel : Instruction
{
	private OpMemoryModel()
	{
	}

	public override string Name => nameof(OpMemoryModel);
	public override OpCode Code => OpCode.OpMemoryModel;
	public static OpMemoryModel Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<AddressingModel, AddressingModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<MemoryModel, MemoryModelParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpEntryPoint : Instruction
{
	private OpEntryPoint()
	{
	}

	public override string Name => nameof(OpEntryPoint);
	public override OpCode Code => OpCode.OpEntryPoint;
	public static OpEntryPoint Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<ExecutionModel, ExecutionModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default), new Operand(new IdRef(), "Interface", OperandQuantifier.Varying),];
}
public sealed class OpExecutionMode : Instruction
{
	private OpExecutionMode()
	{
	}

	public override string Name => nameof(OpExecutionMode);
	public override OpCode Code => OpCode.OpExecutionMode;
	public static OpExecutionMode Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),];
}
public sealed class OpCapability : Instruction
{
	private OpCapability()
	{
	}

	public override string Name => nameof(OpCapability);
	public override OpCode Code => OpCode.OpCapability;
	public static OpCapability Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new EnumType<Capability, CapabilityParameterFactory>(), "Capability", OperandQuantifier.Default),];
}
public sealed class OpTypeVoid : Instruction
{
	private OpTypeVoid()
	{
	}

	public override string Name => nameof(OpTypeVoid);
	public override OpCode Code => OpCode.OpTypeVoid;
	public static OpTypeVoid Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeBool : Instruction
{
	private OpTypeBool()
	{
	}

	public override string Name => nameof(OpTypeBool);
	public override OpCode Code => OpCode.OpTypeBool;
	public static OpTypeBool Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeInt : Instruction
{
	private OpTypeInt()
	{
	}

	public override string Name => nameof(OpTypeInt);
	public override OpCode Code => OpCode.OpTypeInt;
	public static OpTypeInt Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Signedness", OperandQuantifier.Default),];
}
public sealed class OpTypeFloat : Instruction
{
	private OpTypeFloat()
	{
	}

	public override string Name => nameof(OpTypeFloat);
	public override OpCode Code => OpCode.OpTypeFloat;
	public static OpTypeFloat Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default),];
}
public sealed class OpTypeVector : Instruction
{
	private OpTypeVector()
	{
	}

	public override string Name => nameof(OpTypeVector);
	public override OpCode Code => OpCode.OpTypeVector;
	public static OpTypeVector Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Component Count", OperandQuantifier.Default),];
}
public sealed class OpTypeMatrix : Instruction
{
	private OpTypeMatrix()
	{
	}

	public override string Name => nameof(OpTypeMatrix);
	public override OpCode Code => OpCode.OpTypeMatrix;
	public static OpTypeMatrix Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Column Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Column Count", OperandQuantifier.Default),];
}
public sealed class OpTypeImage : Instruction
{
	private OpTypeImage()
	{
	}

	public override string Name => nameof(OpTypeImage);
	public override OpCode Code => OpCode.OpTypeImage;
	public static OpTypeImage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Type", OperandQuantifier.Default), new Operand(new EnumType<Dim, DimParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Depth", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Arrayed", OperandQuantifier.Default), new Operand(new LiteralInteger(), "MS", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Sampled", OperandQuantifier.Default), new Operand(new EnumType<ImageFormat, ImageFormatParameterFactory>(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpTypeSampler : Instruction
{
	private OpTypeSampler()
	{
	}

	public override string Name => nameof(OpTypeSampler);
	public override OpCode Code => OpCode.OpTypeSampler;
	public static OpTypeSampler Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeSampledImage : Instruction
{
	private OpTypeSampledImage()
	{
	}

	public override string Name => nameof(OpTypeSampledImage);
	public override OpCode Code => OpCode.OpTypeSampledImage;
	public static OpTypeSampledImage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Type", OperandQuantifier.Default),];
}
public sealed class OpTypeArray : Instruction
{
	private OpTypeArray()
	{
	}

	public override string Name => nameof(OpTypeArray);
	public override OpCode Code => OpCode.OpTypeArray;
	public static OpTypeArray Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default), new Operand(new IdRef(), "Length", OperandQuantifier.Default),];
}
public sealed class OpTypeRuntimeArray : Instruction
{
	private OpTypeRuntimeArray()
	{
	}

	public override string Name => nameof(OpTypeRuntimeArray);
	public override OpCode Code => OpCode.OpTypeRuntimeArray;
	public static OpTypeRuntimeArray Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default),];
}
public sealed class OpTypeStruct : Instruction
{
	private OpTypeStruct()
	{
	}

	public override string Name => nameof(OpTypeStruct);
	public override OpCode Code => OpCode.OpTypeStruct;
	public static OpTypeStruct Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Member 0 type, +member 1 type, +...", OperandQuantifier.Varying),];
}
public sealed class OpTypeOpaque : Instruction
{
	private OpTypeOpaque()
	{
	}

	public override string Name => nameof(OpTypeOpaque);
	public override OpCode Code => OpCode.OpTypeOpaque;
	public static OpTypeOpaque Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "The name of the opaque type.", OperandQuantifier.Default),];
}
public sealed class OpTypePointer : Instruction
{
	private OpTypePointer()
	{
	}

	public override string Name => nameof(OpTypePointer);
	public override OpCode Code => OpCode.OpTypePointer;
	public static OpTypePointer Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),];
}
public sealed class OpTypeFunction : Instruction
{
	private OpTypeFunction()
	{
	}

	public override string Name => nameof(OpTypeFunction);
	public override OpCode Code => OpCode.OpTypeFunction;
	public static OpTypeFunction Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Return Type", OperandQuantifier.Default), new Operand(new IdRef(), "Parameter 0 Type, +Parameter 1 Type, +...", OperandQuantifier.Varying),];
}
public sealed class OpTypeEvent : Instruction
{
	private OpTypeEvent()
	{
	}

	public override string Name => nameof(OpTypeEvent);
	public override OpCode Code => OpCode.OpTypeEvent;
	public static OpTypeEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeDeviceEvent : Instruction
{
	private OpTypeDeviceEvent()
	{
	}

	public override string Name => nameof(OpTypeDeviceEvent);
	public override OpCode Code => OpCode.OpTypeDeviceEvent;
	public static OpTypeDeviceEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeReserveId : Instruction
{
	private OpTypeReserveId()
	{
	}

	public override string Name => nameof(OpTypeReserveId);
	public override OpCode Code => OpCode.OpTypeReserveId;
	public static OpTypeReserveId Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeQueue : Instruction
{
	private OpTypeQueue()
	{
	}

	public override string Name => nameof(OpTypeQueue);
	public override OpCode Code => OpCode.OpTypeQueue;
	public static OpTypeQueue Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypePipe : Instruction
{
	private OpTypePipe()
	{
	}

	public override string Name => nameof(OpTypePipe);
	public override OpCode Code => OpCode.OpTypePipe;
	public static OpTypePipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), "Qualifier", OperandQuantifier.Default),];
}
public sealed class OpTypeForwardPointer : Instruction
{
	private OpTypeForwardPointer()
	{
	}

	public override string Name => nameof(OpTypeForwardPointer);
	public override OpCode Code => OpCode.OpTypeForwardPointer;
	public static OpTypeForwardPointer Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer Type", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantTrue : Instruction
{
	private OpConstantTrue()
	{
	}

	public override string Name => nameof(OpConstantTrue);
	public override OpCode Code => OpCode.OpConstantTrue;
	public static OpConstantTrue Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantFalse : Instruction
{
	private OpConstantFalse()
	{
	}

	public override string Name => nameof(OpConstantFalse);
	public override OpCode Code => OpCode.OpConstantFalse;
	public static OpConstantFalse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstant : Instruction
{
	private OpConstant()
	{
	}

	public override string Name => nameof(OpConstant);
	public override OpCode Code => OpCode.OpConstant;
	public static OpConstant Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),];
}
public sealed class OpConstantComposite : Instruction
{
	private OpConstantComposite()
	{
	}

	public override string Name => nameof(OpConstantComposite);
	public override OpCode Code => OpCode.OpConstantComposite;
	public static OpConstantComposite Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpConstantSampler : Instruction
{
	private OpConstantSampler()
	{
	}

	public override string Name => nameof(OpConstantSampler);
	public override OpCode Code => OpCode.OpConstantSampler;
	public static OpConstantSampler Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<SamplerAddressingMode, SamplerAddressingModeParameterFactory>(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Param", OperandQuantifier.Default), new Operand(new EnumType<SamplerFilterMode, SamplerFilterModeParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantNull : Instruction
{
	private OpConstantNull()
	{
	}

	public override string Name => nameof(OpConstantNull);
	public override OpCode Code => OpCode.OpConstantNull;
	public static OpConstantNull Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstantTrue : Instruction
{
	private OpSpecConstantTrue()
	{
	}

	public override string Name => nameof(OpSpecConstantTrue);
	public override OpCode Code => OpCode.OpSpecConstantTrue;
	public static OpSpecConstantTrue Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstantFalse : Instruction
{
	private OpSpecConstantFalse()
	{
	}

	public override string Name => nameof(OpSpecConstantFalse);
	public override OpCode Code => OpCode.OpSpecConstantFalse;
	public static OpSpecConstantFalse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSpecConstant : Instruction
{
	private OpSpecConstant()
	{
	}

	public override string Name => nameof(OpSpecConstant);
	public override OpCode Code => OpCode.OpSpecConstant;
	public static OpSpecConstant Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralContextDependentNumber(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantComposite : Instruction
{
	private OpSpecConstantComposite()
	{
	}

	public override string Name => nameof(OpSpecConstantComposite);
	public override OpCode Code => OpCode.OpSpecConstantComposite;
	public static OpSpecConstantComposite Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpSpecConstantOp : Instruction
{
	private OpSpecConstantOp()
	{
	}

	public override string Name => nameof(OpSpecConstantOp);
	public override OpCode Code => OpCode.OpSpecConstantOp;
	public static OpSpecConstantOp Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralSpecConstantOpInteger(), "Opcode", OperandQuantifier.Default),];
}
public sealed class OpFunction : Instruction
{
	private OpFunction()
	{
	}

	public override string Name => nameof(OpFunction);
	public override OpCode Code => OpCode.OpFunction;
	public static OpFunction Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<FunctionControl, FunctionControlParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function Type", OperandQuantifier.Default),];
}
public sealed class OpFunctionParameter : Instruction
{
	private OpFunctionParameter()
	{
	}

	public override string Name => nameof(OpFunctionParameter);
	public override OpCode Code => OpCode.OpFunctionParameter;
	public static OpFunctionParameter Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpFunctionEnd : Instruction
{
	private OpFunctionEnd()
	{
	}

	public override string Name => nameof(OpFunctionEnd);
	public override OpCode Code => OpCode.OpFunctionEnd;
	public static OpFunctionEnd Instance { get; } = new();
}
public sealed class OpFunctionCall : Instruction
{
	private OpFunctionCall()
	{
	}

	public override string Name => nameof(OpFunctionCall);
	public override OpCode Code => OpCode.OpFunctionCall;
	public static OpFunctionCall Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default), new Operand(new IdRef(), "Argument 0, +Argument 1, +...", OperandQuantifier.Varying),];
}
public sealed class OpVariable : Instruction
{
	private OpVariable()
	{
	}

	public override string Name => nameof(OpVariable);
	public override OpCode Code => OpCode.OpVariable;
	public static OpVariable Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Initializer", OperandQuantifier.Optional),];
}
public sealed class OpImageTexelPointer : Instruction
{
	private OpImageTexelPointer()
	{
	}

	public override string Name => nameof(OpImageTexelPointer);
	public override OpCode Code => OpCode.OpImageTexelPointer;
	public static OpImageTexelPointer Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Default),];
}
public sealed class OpLoad : Instruction
{
	private OpLoad()
	{
	}

	public override string Name => nameof(OpLoad);
	public override OpCode Code => OpCode.OpLoad;
	public static OpLoad Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpStore : Instruction
{
	private OpStore()
	{
	}

	public override string Name => nameof(OpStore);
	public override OpCode Code => OpCode.OpStore;
	public static OpStore Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCopyMemory : Instruction
{
	private OpCopyMemory()
	{
	}

	public override string Name => nameof(OpCopyMemory);
	public override OpCode Code => OpCode.OpCopyMemory;
	public static OpCopyMemory Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCopyMemorySized : Instruction
{
	private OpCopyMemorySized()
	{
	}

	public override string Name => nameof(OpCopyMemorySized);
	public override OpCode Code => OpCode.OpCopyMemorySized;
	public static OpCopyMemorySized Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Size", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpAccessChain : Instruction
{
	private OpAccessChain()
	{
	}

	public override string Name => nameof(OpAccessChain);
	public override OpCode Code => OpCode.OpAccessChain;
	public static OpAccessChain Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpInBoundsAccessChain : Instruction
{
	private OpInBoundsAccessChain()
	{
	}

	public override string Name => nameof(OpInBoundsAccessChain);
	public override OpCode Code => OpCode.OpInBoundsAccessChain;
	public static OpInBoundsAccessChain Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpPtrAccessChain : Instruction
{
	private OpPtrAccessChain()
	{
	}

	public override string Name => nameof(OpPtrAccessChain);
	public override OpCode Code => OpCode.OpPtrAccessChain;
	public static OpPtrAccessChain Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpArrayLength : Instruction
{
	private OpArrayLength()
	{
	}

	public override string Name => nameof(OpArrayLength);
	public override OpCode Code => OpCode.OpArrayLength;
	public static OpArrayLength Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Structure", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Array member", OperandQuantifier.Default),];
}
public sealed class OpGenericPtrMemSemantics : Instruction
{
	private OpGenericPtrMemSemantics()
	{
	}

	public override string Name => nameof(OpGenericPtrMemSemantics);
	public override OpCode Code => OpCode.OpGenericPtrMemSemantics;
	public static OpGenericPtrMemSemantics Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpInBoundsPtrAccessChain : Instruction
{
	private OpInBoundsPtrAccessChain()
	{
	}

	public override string Name => nameof(OpInBoundsPtrAccessChain);
	public override OpCode Code => OpCode.OpInBoundsPtrAccessChain;
	public static OpInBoundsPtrAccessChain Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpDecorate : Instruction
{
	private OpDecorate()
	{
	}

	public override string Name => nameof(OpDecorate);
	public override OpCode Code => OpCode.OpDecorate;
	public static OpDecorate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpMemberDecorate : Instruction
{
	private OpMemberDecorate()
	{
	}

	public override string Name => nameof(OpMemberDecorate);
	public override OpCode Code => OpCode.OpMemberDecorate;
	public static OpMemberDecorate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Structure Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpDecorationGroup : Instruction
{
	private OpDecorationGroup()
	{
	}

	public override string Name => nameof(OpDecorationGroup);
	public override OpCode Code => OpCode.OpDecorationGroup;
	public static OpDecorationGroup Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpGroupDecorate : Instruction
{
	private OpGroupDecorate()
	{
	}

	public override string Name => nameof(OpGroupDecorate);
	public override OpCode Code => OpCode.OpGroupDecorate;
	public static OpGroupDecorate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new IdRef(), "Targets", OperandQuantifier.Varying),];
}
public sealed class OpGroupMemberDecorate : Instruction
{
	private OpGroupMemberDecorate()
	{
	}

	public override string Name => nameof(OpGroupMemberDecorate);
	public override OpCode Code => OpCode.OpGroupMemberDecorate;
	public static OpGroupMemberDecorate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Decoration Group", OperandQuantifier.Default), new Operand(new PairIdRefLiteralInteger(), "Targets", OperandQuantifier.Varying),];
}
public sealed class OpVectorExtractDynamic : Instruction
{
	private OpVectorExtractDynamic()
	{
	}

	public override string Name => nameof(OpVectorExtractDynamic);
	public override OpCode Code => OpCode.OpVectorExtractDynamic;
	public static OpVectorExtractDynamic Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpVectorInsertDynamic : Instruction
{
	private OpVectorInsertDynamic()
	{
	}

	public override string Name => nameof(OpVectorInsertDynamic);
	public override OpCode Code => OpCode.OpVectorInsertDynamic;
	public static OpVectorInsertDynamic Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpVectorShuffle : Instruction
{
	private OpVectorShuffle()
	{
	}

	public override string Name => nameof(OpVectorShuffle);
	public override OpCode Code => OpCode.OpVectorShuffle;
	public static OpVectorShuffle Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Components", OperandQuantifier.Varying),];
}
public sealed class OpCompositeConstruct : Instruction
{
	private OpCompositeConstruct()
	{
	}

	public override string Name => nameof(OpCompositeConstruct);
	public override OpCode Code => OpCode.OpCompositeConstruct;
	public static OpCompositeConstruct Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpCompositeExtract : Instruction
{
	private OpCompositeExtract()
	{
	}

	public override string Name => nameof(OpCompositeExtract);
	public override OpCode Code => OpCode.OpCompositeExtract;
	public static OpCompositeExtract Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpCompositeInsert : Instruction
{
	private OpCompositeInsert()
	{
	}

	public override string Name => nameof(OpCompositeInsert);
	public override OpCode Code => OpCode.OpCompositeInsert;
	public static OpCompositeInsert Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "Composite", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpCopyObject : Instruction
{
	private OpCopyObject()
	{
	}

	public override string Name => nameof(OpCopyObject);
	public override OpCode Code => OpCode.OpCopyObject;
	public static OpCopyObject Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpTranspose : Instruction
{
	private OpTranspose()
	{
	}

	public override string Name => nameof(OpTranspose);
	public override OpCode Code => OpCode.OpTranspose;
	public static OpTranspose Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpSampledImage : Instruction
{
	private OpSampledImage()
	{
	}

	public override string Name => nameof(OpSampledImage);
	public override OpCode Code => OpCode.OpSampledImage;
	public static OpSampledImage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Sampler", OperandQuantifier.Default),];
}
public sealed class OpImageSampleImplicitLod : Instruction
{
	private OpImageSampleImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleImplicitLod;
	public static OpImageSampleImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleExplicitLod : Instruction
{
	private OpImageSampleExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleExplicitLod;
	public static OpImageSampleExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleDrefImplicitLod : Instruction
{
	private OpImageSampleDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleDrefImplicitLod;
	public static OpImageSampleDrefImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleDrefExplicitLod : Instruction
{
	private OpImageSampleDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleDrefExplicitLod;
	public static OpImageSampleDrefExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleProjImplicitLod : Instruction
{
	private OpImageSampleProjImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjImplicitLod;
	public static OpImageSampleProjImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleProjExplicitLod : Instruction
{
	private OpImageSampleProjExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjExplicitLod;
	public static OpImageSampleProjExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleProjDrefImplicitLod : Instruction
{
	private OpImageSampleProjDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjDrefImplicitLod;
	public static OpImageSampleProjDrefImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSampleProjDrefExplicitLod : Instruction
{
	private OpImageSampleProjDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSampleProjDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSampleProjDrefExplicitLod;
	public static OpImageSampleProjDrefExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageFetch : Instruction
{
	private OpImageFetch()
	{
	}

	public override string Name => nameof(OpImageFetch);
	public override OpCode Code => OpCode.OpImageFetch;
	public static OpImageFetch Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageGather : Instruction
{
	private OpImageGather()
	{
	}

	public override string Name => nameof(OpImageGather);
	public override OpCode Code => OpCode.OpImageGather;
	public static OpImageGather Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageDrefGather : Instruction
{
	private OpImageDrefGather()
	{
	}

	public override string Name => nameof(OpImageDrefGather);
	public override OpCode Code => OpCode.OpImageDrefGather;
	public static OpImageDrefGather Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageRead : Instruction
{
	private OpImageRead()
	{
	}

	public override string Name => nameof(OpImageRead);
	public override OpCode Code => OpCode.OpImageRead;
	public static OpImageRead Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageWrite : Instruction
{
	private OpImageWrite()
	{
	}

	public override string Name => nameof(OpImageWrite);
	public override OpCode Code => OpCode.OpImageWrite;
	public static OpImageWrite Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Texel", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImage : Instruction
{
	private OpImage()
	{
	}

	public override string Name => nameof(OpImage);
	public override OpCode Code => OpCode.OpImage;
	public static OpImage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryFormat : Instruction
{
	private OpImageQueryFormat()
	{
	}

	public override string Name => nameof(OpImageQueryFormat);
	public override OpCode Code => OpCode.OpImageQueryFormat;
	public static OpImageQueryFormat Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryOrder : Instruction
{
	private OpImageQueryOrder()
	{
	}

	public override string Name => nameof(OpImageQueryOrder);
	public override OpCode Code => OpCode.OpImageQueryOrder;
	public static OpImageQueryOrder Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySizeLod : Instruction
{
	private OpImageQuerySizeLod()
	{
	}

	public override string Name => nameof(OpImageQuerySizeLod);
	public override OpCode Code => OpCode.OpImageQuerySizeLod;
	public static OpImageQuerySizeLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Level of Detail", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySize : Instruction
{
	private OpImageQuerySize()
	{
	}

	public override string Name => nameof(OpImageQuerySize);
	public override OpCode Code => OpCode.OpImageQuerySize;
	public static OpImageQuerySize Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQueryLod : Instruction
{
	private OpImageQueryLod()
	{
	}

	public override string Name => nameof(OpImageQueryLod);
	public override OpCode Code => OpCode.OpImageQueryLod;
	public static OpImageQueryLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpImageQueryLevels : Instruction
{
	private OpImageQueryLevels()
	{
	}

	public override string Name => nameof(OpImageQueryLevels);
	public override OpCode Code => OpCode.OpImageQueryLevels;
	public static OpImageQueryLevels Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpImageQuerySamples : Instruction
{
	private OpImageQuerySamples()
	{
	}

	public override string Name => nameof(OpImageQuerySamples);
	public override OpCode Code => OpCode.OpImageQuerySamples;
	public static OpImageQuerySamples Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default),];
}
public sealed class OpConvertFToU : Instruction
{
	private OpConvertFToU()
	{
	}

	public override string Name => nameof(OpConvertFToU);
	public override OpCode Code => OpCode.OpConvertFToU;
	public static OpConvertFToU Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpConvertFToS : Instruction
{
	private OpConvertFToS()
	{
	}

	public override string Name => nameof(OpConvertFToS);
	public override OpCode Code => OpCode.OpConvertFToS;
	public static OpConvertFToS Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpConvertSToF : Instruction
{
	private OpConvertSToF()
	{
	}

	public override string Name => nameof(OpConvertSToF);
	public override OpCode Code => OpCode.OpConvertSToF;
	public static OpConvertSToF Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpConvertUToF : Instruction
{
	private OpConvertUToF()
	{
	}

	public override string Name => nameof(OpConvertUToF);
	public override OpCode Code => OpCode.OpConvertUToF;
	public static OpConvertUToF Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpUConvert : Instruction
{
	private OpUConvert()
	{
	}

	public override string Name => nameof(OpUConvert);
	public override OpCode Code => OpCode.OpUConvert;
	public static OpUConvert Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpSConvert : Instruction
{
	private OpSConvert()
	{
	}

	public override string Name => nameof(OpSConvert);
	public override OpCode Code => OpCode.OpSConvert;
	public static OpSConvert Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpFConvert : Instruction
{
	private OpFConvert()
	{
	}

	public override string Name => nameof(OpFConvert);
	public override OpCode Code => OpCode.OpFConvert;
	public static OpFConvert Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpQuantizeToF16 : Instruction
{
	private OpQuantizeToF16()
	{
	}

	public override string Name => nameof(OpQuantizeToF16);
	public override OpCode Code => OpCode.OpQuantizeToF16;
	public static OpQuantizeToF16 Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpConvertPtrToU : Instruction
{
	private OpConvertPtrToU()
	{
	}

	public override string Name => nameof(OpConvertPtrToU);
	public override OpCode Code => OpCode.OpConvertPtrToU;
	public static OpConvertPtrToU Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpSatConvertSToU : Instruction
{
	private OpSatConvertSToU()
	{
	}

	public override string Name => nameof(OpSatConvertSToU);
	public override OpCode Code => OpCode.OpSatConvertSToU;
	public static OpSatConvertSToU Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Signed Value", OperandQuantifier.Default),];
}
public sealed class OpSatConvertUToS : Instruction
{
	private OpSatConvertUToS()
	{
	}

	public override string Name => nameof(OpSatConvertUToS);
	public override OpCode Code => OpCode.OpSatConvertUToS;
	public static OpSatConvertUToS Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Unsigned Value", OperandQuantifier.Default),];
}
public sealed class OpConvertUToPtr : Instruction
{
	private OpConvertUToPtr()
	{
	}

	public override string Name => nameof(OpConvertUToPtr);
	public override OpCode Code => OpCode.OpConvertUToPtr;
	public static OpConvertUToPtr Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Integer Value", OperandQuantifier.Default),];
}
public sealed class OpPtrCastToGeneric : Instruction
{
	private OpPtrCastToGeneric()
	{
	}

	public override string Name => nameof(OpPtrCastToGeneric);
	public override OpCode Code => OpCode.OpPtrCastToGeneric;
	public static OpPtrCastToGeneric Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpGenericCastToPtr : Instruction
{
	private OpGenericCastToPtr()
	{
	}

	public override string Name => nameof(OpGenericCastToPtr);
	public override OpCode Code => OpCode.OpGenericCastToPtr;
	public static OpGenericCastToPtr Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpGenericCastToPtrExplicit : Instruction
{
	private OpGenericCastToPtrExplicit()
	{
	}

	public override string Name => nameof(OpGenericCastToPtrExplicit);
	public override OpCode Code => OpCode.OpGenericCastToPtrExplicit;
	public static OpGenericCastToPtrExplicit Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), "Storage", OperandQuantifier.Default),];
}
public sealed class OpBitcast : Instruction
{
	private OpBitcast()
	{
	}

	public override string Name => nameof(OpBitcast);
	public override OpCode Code => OpCode.OpBitcast;
	public static OpBitcast Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpSNegate : Instruction
{
	private OpSNegate()
	{
	}

	public override string Name => nameof(OpSNegate);
	public override OpCode Code => OpCode.OpSNegate;
	public static OpSNegate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpFNegate : Instruction
{
	private OpFNegate()
	{
	}

	public override string Name => nameof(OpFNegate);
	public override OpCode Code => OpCode.OpFNegate;
	public static OpFNegate Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpIAdd : Instruction
{
	private OpIAdd()
	{
	}

	public override string Name => nameof(OpIAdd);
	public override OpCode Code => OpCode.OpIAdd;
	public static OpIAdd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFAdd : Instruction
{
	private OpFAdd()
	{
	}

	public override string Name => nameof(OpFAdd);
	public override OpCode Code => OpCode.OpFAdd;
	public static OpFAdd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpISub : Instruction
{
	private OpISub()
	{
	}

	public override string Name => nameof(OpISub);
	public override OpCode Code => OpCode.OpISub;
	public static OpISub Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFSub : Instruction
{
	private OpFSub()
	{
	}

	public override string Name => nameof(OpFSub);
	public override OpCode Code => OpCode.OpFSub;
	public static OpFSub Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIMul : Instruction
{
	private OpIMul()
	{
	}

	public override string Name => nameof(OpIMul);
	public override OpCode Code => OpCode.OpIMul;
	public static OpIMul Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFMul : Instruction
{
	private OpFMul()
	{
	}

	public override string Name => nameof(OpFMul);
	public override OpCode Code => OpCode.OpFMul;
	public static OpFMul Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUDiv : Instruction
{
	private OpUDiv()
	{
	}

	public override string Name => nameof(OpUDiv);
	public override OpCode Code => OpCode.OpUDiv;
	public static OpUDiv Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSDiv : Instruction
{
	private OpSDiv()
	{
	}

	public override string Name => nameof(OpSDiv);
	public override OpCode Code => OpCode.OpSDiv;
	public static OpSDiv Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFDiv : Instruction
{
	private OpFDiv()
	{
	}

	public override string Name => nameof(OpFDiv);
	public override OpCode Code => OpCode.OpFDiv;
	public static OpFDiv Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUMod : Instruction
{
	private OpUMod()
	{
	}

	public override string Name => nameof(OpUMod);
	public override OpCode Code => OpCode.OpUMod;
	public static OpUMod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSRem : Instruction
{
	private OpSRem()
	{
	}

	public override string Name => nameof(OpSRem);
	public override OpCode Code => OpCode.OpSRem;
	public static OpSRem Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSMod : Instruction
{
	private OpSMod()
	{
	}

	public override string Name => nameof(OpSMod);
	public override OpCode Code => OpCode.OpSMod;
	public static OpSMod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFRem : Instruction
{
	private OpFRem()
	{
	}

	public override string Name => nameof(OpFRem);
	public override OpCode Code => OpCode.OpFRem;
	public static OpFRem Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFMod : Instruction
{
	private OpFMod()
	{
	}

	public override string Name => nameof(OpFMod);
	public override OpCode Code => OpCode.OpFMod;
	public static OpFMod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpVectorTimesScalar : Instruction
{
	private OpVectorTimesScalar()
	{
	}

	public override string Name => nameof(OpVectorTimesScalar);
	public override OpCode Code => OpCode.OpVectorTimesScalar;
	public static OpVectorTimesScalar Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesScalar : Instruction
{
	private OpMatrixTimesScalar()
	{
	}

	public override string Name => nameof(OpMatrixTimesScalar);
	public override OpCode Code => OpCode.OpMatrixTimesScalar;
	public static OpMatrixTimesScalar Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Scalar", OperandQuantifier.Default),];
}
public sealed class OpVectorTimesMatrix : Instruction
{
	private OpVectorTimesMatrix()
	{
	}

	public override string Name => nameof(OpVectorTimesMatrix);
	public override OpCode Code => OpCode.OpVectorTimesMatrix;
	public static OpVectorTimesMatrix Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesVector : Instruction
{
	private OpMatrixTimesVector()
	{
	}

	public override string Name => nameof(OpMatrixTimesVector);
	public override OpCode Code => OpCode.OpMatrixTimesVector;
	public static OpMatrixTimesVector Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpMatrixTimesMatrix : Instruction
{
	private OpMatrixTimesMatrix()
	{
	}

	public override string Name => nameof(OpMatrixTimesMatrix);
	public override OpCode Code => OpCode.OpMatrixTimesMatrix;
	public static OpMatrixTimesMatrix Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "LeftMatrix", OperandQuantifier.Default), new Operand(new IdRef(), "RightMatrix", OperandQuantifier.Default),];
}
public sealed class OpOuterProduct : Instruction
{
	private OpOuterProduct()
	{
	}

	public override string Name => nameof(OpOuterProduct);
	public override OpCode Code => OpCode.OpOuterProduct;
	public static OpOuterProduct Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),];
}
public sealed class OpDot : Instruction
{
	private OpDot()
	{
	}

	public override string Name => nameof(OpDot);
	public override OpCode Code => OpCode.OpDot;
	public static OpDot Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default),];
}
public sealed class OpIAddCarry : Instruction
{
	private OpIAddCarry()
	{
	}

	public override string Name => nameof(OpIAddCarry);
	public override OpCode Code => OpCode.OpIAddCarry;
	public static OpIAddCarry Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpISubBorrow : Instruction
{
	private OpISubBorrow()
	{
	}

	public override string Name => nameof(OpISubBorrow);
	public override OpCode Code => OpCode.OpISubBorrow;
	public static OpISubBorrow Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUMulExtended : Instruction
{
	private OpUMulExtended()
	{
	}

	public override string Name => nameof(OpUMulExtended);
	public override OpCode Code => OpCode.OpUMulExtended;
	public static OpUMulExtended Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSMulExtended : Instruction
{
	private OpSMulExtended()
	{
	}

	public override string Name => nameof(OpSMulExtended);
	public override OpCode Code => OpCode.OpSMulExtended;
	public static OpSMulExtended Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpAny : Instruction
{
	private OpAny()
	{
	}

	public override string Name => nameof(OpAny);
	public override OpCode Code => OpCode.OpAny;
	public static OpAny Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpAll : Instruction
{
	private OpAll()
	{
	}

	public override string Name => nameof(OpAll);
	public override OpCode Code => OpCode.OpAll;
	public static OpAll Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector", OperandQuantifier.Default),];
}
public sealed class OpIsNan : Instruction
{
	private OpIsNan()
	{
	}

	public override string Name => nameof(OpIsNan);
	public override OpCode Code => OpCode.OpIsNan;
	public static OpIsNan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsInf : Instruction
{
	private OpIsInf()
	{
	}

	public override string Name => nameof(OpIsInf);
	public override OpCode Code => OpCode.OpIsInf;
	public static OpIsInf Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsFinite : Instruction
{
	private OpIsFinite()
	{
	}

	public override string Name => nameof(OpIsFinite);
	public override OpCode Code => OpCode.OpIsFinite;
	public static OpIsFinite Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpIsNormal : Instruction
{
	private OpIsNormal()
	{
	}

	public override string Name => nameof(OpIsNormal);
	public override OpCode Code => OpCode.OpIsNormal;
	public static OpIsNormal Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpSignBitSet : Instruction
{
	private OpSignBitSet()
	{
	}

	public override string Name => nameof(OpSignBitSet);
	public override OpCode Code => OpCode.OpSignBitSet;
	public static OpSignBitSet Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default),];
}
public sealed class OpLessOrGreater : Instruction
{
	private OpLessOrGreater()
	{
	}

	public override string Name => nameof(OpLessOrGreater);
	public override OpCode Code => OpCode.OpLessOrGreater;
	public static OpLessOrGreater Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpOrdered : Instruction
{
	private OpOrdered()
	{
	}

	public override string Name => nameof(OpOrdered);
	public override OpCode Code => OpCode.OpOrdered;
	public static OpOrdered Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpUnordered : Instruction
{
	private OpUnordered()
	{
	}

	public override string Name => nameof(OpUnordered);
	public override OpCode Code => OpCode.OpUnordered;
	public static OpUnordered Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "x", OperandQuantifier.Default), new Operand(new IdRef(), "y", OperandQuantifier.Default),];
}
public sealed class OpLogicalEqual : Instruction
{
	private OpLogicalEqual()
	{
	}

	public override string Name => nameof(OpLogicalEqual);
	public override OpCode Code => OpCode.OpLogicalEqual;
	public static OpLogicalEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalNotEqual : Instruction
{
	private OpLogicalNotEqual()
	{
	}

	public override string Name => nameof(OpLogicalNotEqual);
	public override OpCode Code => OpCode.OpLogicalNotEqual;
	public static OpLogicalNotEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalOr : Instruction
{
	private OpLogicalOr()
	{
	}

	public override string Name => nameof(OpLogicalOr);
	public override OpCode Code => OpCode.OpLogicalOr;
	public static OpLogicalOr Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalAnd : Instruction
{
	private OpLogicalAnd()
	{
	}

	public override string Name => nameof(OpLogicalAnd);
	public override OpCode Code => OpCode.OpLogicalAnd;
	public static OpLogicalAnd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpLogicalNot : Instruction
{
	private OpLogicalNot()
	{
	}

	public override string Name => nameof(OpLogicalNot);
	public override OpCode Code => OpCode.OpLogicalNot;
	public static OpLogicalNot Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpSelect : Instruction
{
	private OpSelect()
	{
	}

	public override string Name => nameof(OpSelect);
	public override OpCode Code => OpCode.OpSelect;
	public static OpSelect Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "Object 1", OperandQuantifier.Default), new Operand(new IdRef(), "Object 2", OperandQuantifier.Default),];
}
public sealed class OpIEqual : Instruction
{
	private OpIEqual()
	{
	}

	public override string Name => nameof(OpIEqual);
	public override OpCode Code => OpCode.OpIEqual;
	public static OpIEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpINotEqual : Instruction
{
	private OpINotEqual()
	{
	}

	public override string Name => nameof(OpINotEqual);
	public override OpCode Code => OpCode.OpINotEqual;
	public static OpINotEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUGreaterThan : Instruction
{
	private OpUGreaterThan()
	{
	}

	public override string Name => nameof(OpUGreaterThan);
	public override OpCode Code => OpCode.OpUGreaterThan;
	public static OpUGreaterThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSGreaterThan : Instruction
{
	private OpSGreaterThan()
	{
	}

	public override string Name => nameof(OpSGreaterThan);
	public override OpCode Code => OpCode.OpSGreaterThan;
	public static OpSGreaterThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUGreaterThanEqual : Instruction
{
	private OpUGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpUGreaterThanEqual);
	public override OpCode Code => OpCode.OpUGreaterThanEqual;
	public static OpUGreaterThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSGreaterThanEqual : Instruction
{
	private OpSGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpSGreaterThanEqual);
	public override OpCode Code => OpCode.OpSGreaterThanEqual;
	public static OpSGreaterThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpULessThan : Instruction
{
	private OpULessThan()
	{
	}

	public override string Name => nameof(OpULessThan);
	public override OpCode Code => OpCode.OpULessThan;
	public static OpULessThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSLessThan : Instruction
{
	private OpSLessThan()
	{
	}

	public override string Name => nameof(OpSLessThan);
	public override OpCode Code => OpCode.OpSLessThan;
	public static OpSLessThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpULessThanEqual : Instruction
{
	private OpULessThanEqual()
	{
	}

	public override string Name => nameof(OpULessThanEqual);
	public override OpCode Code => OpCode.OpULessThanEqual;
	public static OpULessThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpSLessThanEqual : Instruction
{
	private OpSLessThanEqual()
	{
	}

	public override string Name => nameof(OpSLessThanEqual);
	public override OpCode Code => OpCode.OpSLessThanEqual;
	public static OpSLessThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdEqual : Instruction
{
	private OpFOrdEqual()
	{
	}

	public override string Name => nameof(OpFOrdEqual);
	public override OpCode Code => OpCode.OpFOrdEqual;
	public static OpFOrdEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordEqual : Instruction
{
	private OpFUnordEqual()
	{
	}

	public override string Name => nameof(OpFUnordEqual);
	public override OpCode Code => OpCode.OpFUnordEqual;
	public static OpFUnordEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdNotEqual : Instruction
{
	private OpFOrdNotEqual()
	{
	}

	public override string Name => nameof(OpFOrdNotEqual);
	public override OpCode Code => OpCode.OpFOrdNotEqual;
	public static OpFOrdNotEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordNotEqual : Instruction
{
	private OpFUnordNotEqual()
	{
	}

	public override string Name => nameof(OpFUnordNotEqual);
	public override OpCode Code => OpCode.OpFUnordNotEqual;
	public static OpFUnordNotEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdLessThan : Instruction
{
	private OpFOrdLessThan()
	{
	}

	public override string Name => nameof(OpFOrdLessThan);
	public override OpCode Code => OpCode.OpFOrdLessThan;
	public static OpFOrdLessThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordLessThan : Instruction
{
	private OpFUnordLessThan()
	{
	}

	public override string Name => nameof(OpFUnordLessThan);
	public override OpCode Code => OpCode.OpFUnordLessThan;
	public static OpFUnordLessThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdGreaterThan : Instruction
{
	private OpFOrdGreaterThan()
	{
	}

	public override string Name => nameof(OpFOrdGreaterThan);
	public override OpCode Code => OpCode.OpFOrdGreaterThan;
	public static OpFOrdGreaterThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordGreaterThan : Instruction
{
	private OpFUnordGreaterThan()
	{
	}

	public override string Name => nameof(OpFUnordGreaterThan);
	public override OpCode Code => OpCode.OpFUnordGreaterThan;
	public static OpFUnordGreaterThan Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdLessThanEqual : Instruction
{
	private OpFOrdLessThanEqual()
	{
	}

	public override string Name => nameof(OpFOrdLessThanEqual);
	public override OpCode Code => OpCode.OpFOrdLessThanEqual;
	public static OpFOrdLessThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordLessThanEqual : Instruction
{
	private OpFUnordLessThanEqual()
	{
	}

	public override string Name => nameof(OpFUnordLessThanEqual);
	public override OpCode Code => OpCode.OpFUnordLessThanEqual;
	public static OpFUnordLessThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFOrdGreaterThanEqual : Instruction
{
	private OpFOrdGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpFOrdGreaterThanEqual);
	public override OpCode Code => OpCode.OpFOrdGreaterThanEqual;
	public static OpFOrdGreaterThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpFUnordGreaterThanEqual : Instruction
{
	private OpFUnordGreaterThanEqual()
	{
	}

	public override string Name => nameof(OpFUnordGreaterThanEqual);
	public override OpCode Code => OpCode.OpFUnordGreaterThanEqual;
	public static OpFUnordGreaterThanEqual Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpShiftRightLogical : Instruction
{
	private OpShiftRightLogical()
	{
	}

	public override string Name => nameof(OpShiftRightLogical);
	public override OpCode Code => OpCode.OpShiftRightLogical;
	public static OpShiftRightLogical Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpShiftRightArithmetic : Instruction
{
	private OpShiftRightArithmetic()
	{
	}

	public override string Name => nameof(OpShiftRightArithmetic);
	public override OpCode Code => OpCode.OpShiftRightArithmetic;
	public static OpShiftRightArithmetic Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpShiftLeftLogical : Instruction
{
	private OpShiftLeftLogical()
	{
	}

	public override string Name => nameof(OpShiftLeftLogical);
	public override OpCode Code => OpCode.OpShiftLeftLogical;
	public static OpShiftLeftLogical Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Shift", OperandQuantifier.Default),];
}
public sealed class OpBitwiseOr : Instruction
{
	private OpBitwiseOr()
	{
	}

	public override string Name => nameof(OpBitwiseOr);
	public override OpCode Code => OpCode.OpBitwiseOr;
	public static OpBitwiseOr Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpBitwiseXor : Instruction
{
	private OpBitwiseXor()
	{
	}

	public override string Name => nameof(OpBitwiseXor);
	public override OpCode Code => OpCode.OpBitwiseXor;
	public static OpBitwiseXor Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpBitwiseAnd : Instruction
{
	private OpBitwiseAnd()
	{
	}

	public override string Name => nameof(OpBitwiseAnd);
	public override OpCode Code => OpCode.OpBitwiseAnd;
	public static OpBitwiseAnd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpNot : Instruction
{
	private OpNot()
	{
	}

	public override string Name => nameof(OpNot);
	public override OpCode Code => OpCode.OpNot;
	public static OpNot Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpBitFieldInsert : Instruction
{
	private OpBitFieldInsert()
	{
	}

	public override string Name => nameof(OpBitFieldInsert);
	public override OpCode Code => OpCode.OpBitFieldInsert;
	public static OpBitFieldInsert Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Insert", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitFieldSExtract : Instruction
{
	private OpBitFieldSExtract()
	{
	}

	public override string Name => nameof(OpBitFieldSExtract);
	public override OpCode Code => OpCode.OpBitFieldSExtract;
	public static OpBitFieldSExtract Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitFieldUExtract : Instruction
{
	private OpBitFieldUExtract()
	{
	}

	public override string Name => nameof(OpBitFieldUExtract);
	public override OpCode Code => OpCode.OpBitFieldUExtract;
	public static OpBitFieldUExtract Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Count", OperandQuantifier.Default),];
}
public sealed class OpBitReverse : Instruction
{
	private OpBitReverse()
	{
	}

	public override string Name => nameof(OpBitReverse);
	public override OpCode Code => OpCode.OpBitReverse;
	public static OpBitReverse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),];
}
public sealed class OpBitCount : Instruction
{
	private OpBitCount()
	{
	}

	public override string Name => nameof(OpBitCount);
	public override OpCode Code => OpCode.OpBitCount;
	public static OpBitCount Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default),];
}
public sealed class OpDPdx : Instruction
{
	private OpDPdx()
	{
	}

	public override string Name => nameof(OpDPdx);
	public override OpCode Code => OpCode.OpDPdx;
	public static OpDPdx Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdy : Instruction
{
	private OpDPdy()
	{
	}

	public override string Name => nameof(OpDPdy);
	public override OpCode Code => OpCode.OpDPdy;
	public static OpDPdy Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidth : Instruction
{
	private OpFwidth()
	{
	}

	public override string Name => nameof(OpFwidth);
	public override OpCode Code => OpCode.OpFwidth;
	public static OpFwidth Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdxFine : Instruction
{
	private OpDPdxFine()
	{
	}

	public override string Name => nameof(OpDPdxFine);
	public override OpCode Code => OpCode.OpDPdxFine;
	public static OpDPdxFine Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdyFine : Instruction
{
	private OpDPdyFine()
	{
	}

	public override string Name => nameof(OpDPdyFine);
	public override OpCode Code => OpCode.OpDPdyFine;
	public static OpDPdyFine Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidthFine : Instruction
{
	private OpFwidthFine()
	{
	}

	public override string Name => nameof(OpFwidthFine);
	public override OpCode Code => OpCode.OpFwidthFine;
	public static OpFwidthFine Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdxCoarse : Instruction
{
	private OpDPdxCoarse()
	{
	}

	public override string Name => nameof(OpDPdxCoarse);
	public override OpCode Code => OpCode.OpDPdxCoarse;
	public static OpDPdxCoarse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpDPdyCoarse : Instruction
{
	private OpDPdyCoarse()
	{
	}

	public override string Name => nameof(OpDPdyCoarse);
	public override OpCode Code => OpCode.OpDPdyCoarse;
	public static OpDPdyCoarse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpFwidthCoarse : Instruction
{
	private OpFwidthCoarse()
	{
	}

	public override string Name => nameof(OpFwidthCoarse);
	public override OpCode Code => OpCode.OpFwidthCoarse;
	public static OpFwidthCoarse Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "P", OperandQuantifier.Default),];
}
public sealed class OpEmitVertex : Instruction
{
	private OpEmitVertex()
	{
	}

	public override string Name => nameof(OpEmitVertex);
	public override OpCode Code => OpCode.OpEmitVertex;
	public static OpEmitVertex Instance { get; } = new();
}
public sealed class OpEndPrimitive : Instruction
{
	private OpEndPrimitive()
	{
	}

	public override string Name => nameof(OpEndPrimitive);
	public override OpCode Code => OpCode.OpEndPrimitive;
	public static OpEndPrimitive Instance { get; } = new();
}
public sealed class OpEmitStreamVertex : Instruction
{
	private OpEmitStreamVertex()
	{
	}

	public override string Name => nameof(OpEmitStreamVertex);
	public override OpCode Code => OpCode.OpEmitStreamVertex;
	public static OpEmitStreamVertex Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),];
}
public sealed class OpEndStreamPrimitive : Instruction
{
	private OpEndStreamPrimitive()
	{
	}

	public override string Name => nameof(OpEndStreamPrimitive);
	public override OpCode Code => OpCode.OpEndStreamPrimitive;
	public static OpEndStreamPrimitive Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Stream", OperandQuantifier.Default),];
}
public sealed class OpControlBarrier : Instruction
{
	private OpControlBarrier()
	{
	}

	public override string Name => nameof(OpControlBarrier);
	public override OpCode Code => OpCode.OpControlBarrier;
	public static OpControlBarrier Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpMemoryBarrier : Instruction
{
	private OpMemoryBarrier()
	{
	}

	public override string Name => nameof(OpMemoryBarrier);
	public override OpCode Code => OpCode.OpMemoryBarrier;
	public static OpMemoryBarrier Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicLoad : Instruction
{
	private OpAtomicLoad()
	{
	}

	public override string Name => nameof(OpAtomicLoad);
	public override OpCode Code => OpCode.OpAtomicLoad;
	public static OpAtomicLoad Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicStore : Instruction
{
	private OpAtomicStore()
	{
	}

	public override string Name => nameof(OpAtomicStore);
	public override OpCode Code => OpCode.OpAtomicStore;
	public static OpAtomicStore Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicExchange : Instruction
{
	private OpAtomicExchange()
	{
	}

	public override string Name => nameof(OpAtomicExchange);
	public override OpCode Code => OpCode.OpAtomicExchange;
	public static OpAtomicExchange Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicCompareExchange : Instruction
{
	private OpAtomicCompareExchange()
	{
	}

	public override string Name => nameof(OpAtomicCompareExchange);
	public override OpCode Code => OpCode.OpAtomicCompareExchange;
	public static OpAtomicCompareExchange Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
}
public sealed class OpAtomicCompareExchangeWeak : Instruction
{
	private OpAtomicCompareExchangeWeak()
	{
	}

	public override string Name => nameof(OpAtomicCompareExchangeWeak);
	public override OpCode Code => OpCode.OpAtomicCompareExchangeWeak;
	public static OpAtomicCompareExchangeWeak Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
}
public sealed class OpAtomicIIncrement : Instruction
{
	private OpAtomicIIncrement()
	{
	}

	public override string Name => nameof(OpAtomicIIncrement);
	public override OpCode Code => OpCode.OpAtomicIIncrement;
	public static OpAtomicIIncrement Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicIDecrement : Instruction
{
	private OpAtomicIDecrement()
	{
	}

	public override string Name => nameof(OpAtomicIDecrement);
	public override OpCode Code => OpCode.OpAtomicIDecrement;
	public static OpAtomicIDecrement Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicIAdd : Instruction
{
	private OpAtomicIAdd()
	{
	}

	public override string Name => nameof(OpAtomicIAdd);
	public override OpCode Code => OpCode.OpAtomicIAdd;
	public static OpAtomicIAdd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicISub : Instruction
{
	private OpAtomicISub()
	{
	}

	public override string Name => nameof(OpAtomicISub);
	public override OpCode Code => OpCode.OpAtomicISub;
	public static OpAtomicISub Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicSMin : Instruction
{
	private OpAtomicSMin()
	{
	}

	public override string Name => nameof(OpAtomicSMin);
	public override OpCode Code => OpCode.OpAtomicSMin;
	public static OpAtomicSMin Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicUMin : Instruction
{
	private OpAtomicUMin()
	{
	}

	public override string Name => nameof(OpAtomicUMin);
	public override OpCode Code => OpCode.OpAtomicUMin;
	public static OpAtomicUMin Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicSMax : Instruction
{
	private OpAtomicSMax()
	{
	}

	public override string Name => nameof(OpAtomicSMax);
	public override OpCode Code => OpCode.OpAtomicSMax;
	public static OpAtomicSMax Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicUMax : Instruction
{
	private OpAtomicUMax()
	{
	}

	public override string Name => nameof(OpAtomicUMax);
	public override OpCode Code => OpCode.OpAtomicUMax;
	public static OpAtomicUMax Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicAnd : Instruction
{
	private OpAtomicAnd()
	{
	}

	public override string Name => nameof(OpAtomicAnd);
	public override OpCode Code => OpCode.OpAtomicAnd;
	public static OpAtomicAnd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicOr : Instruction
{
	private OpAtomicOr()
	{
	}

	public override string Name => nameof(OpAtomicOr);
	public override OpCode Code => OpCode.OpAtomicOr;
	public static OpAtomicOr Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicXor : Instruction
{
	private OpAtomicXor()
	{
	}

	public override string Name => nameof(OpAtomicXor);
	public override OpCode Code => OpCode.OpAtomicXor;
	public static OpAtomicXor Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpPhi : Instruction
{
	private OpPhi()
	{
	}

	public override string Name => nameof(OpPhi);
	public override OpCode Code => OpCode.OpPhi;
	public static OpPhi Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new PairIdRefIdRef(), "Variable, Parent, ...", OperandQuantifier.Varying),];
}
public sealed class OpLoopMerge : Instruction
{
	private OpLoopMerge()
	{
	}

	public override string Name => nameof(OpLoopMerge);
	public override OpCode Code => OpCode.OpLoopMerge;
	public static OpLoopMerge Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new IdRef(), "Continue Target", OperandQuantifier.Default), new Operand(new EnumType<LoopControl, LoopControlParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpSelectionMerge : Instruction
{
	private OpSelectionMerge()
	{
	}

	public override string Name => nameof(OpSelectionMerge);
	public override OpCode Code => OpCode.OpSelectionMerge;
	public static OpSelectionMerge Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Merge Block", OperandQuantifier.Default), new Operand(new EnumType<SelectionControl, SelectionControlParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpLabel : Instruction
{
	private OpLabel()
	{
	}

	public override string Name => nameof(OpLabel);
	public override OpCode Code => OpCode.OpLabel;
	public static OpLabel Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpBranch : Instruction
{
	private OpBranch()
	{
	}

	public override string Name => nameof(OpBranch);
	public override OpCode Code => OpCode.OpBranch;
	public static OpBranch Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target Label", OperandQuantifier.Default),];
}
public sealed class OpBranchConditional : Instruction
{
	private OpBranchConditional()
	{
	}

	public override string Name => nameof(OpBranchConditional);
	public override OpCode Code => OpCode.OpBranchConditional;
	public static OpBranchConditional Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new IdRef(), "True Label", OperandQuantifier.Default), new Operand(new IdRef(), "False Label", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Branch weights", OperandQuantifier.Varying),];
}
public sealed class OpSwitch : Instruction
{
	private OpSwitch()
	{
	}

	public override string Name => nameof(OpSwitch);
	public override OpCode Code => OpCode.OpSwitch;
	public static OpSwitch Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Selector", OperandQuantifier.Default), new Operand(new IdRef(), "Default", OperandQuantifier.Default), new Operand(new PairLiteralIntegerIdRef(), "Target", OperandQuantifier.Varying),];
}
public sealed class OpKill : Instruction
{
	private OpKill()
	{
	}

	public override string Name => nameof(OpKill);
	public override OpCode Code => OpCode.OpKill;
	public static OpKill Instance { get; } = new();
}
public sealed class OpReturn : Instruction
{
	private OpReturn()
	{
	}

	public override string Name => nameof(OpReturn);
	public override OpCode Code => OpCode.OpReturn;
	public static OpReturn Instance { get; } = new();
}
public sealed class OpReturnValue : Instruction
{
	private OpReturnValue()
	{
	}

	public override string Name => nameof(OpReturnValue);
	public override OpCode Code => OpCode.OpReturnValue;
	public static OpReturnValue Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpUnreachable : Instruction
{
	private OpUnreachable()
	{
	}

	public override string Name => nameof(OpUnreachable);
	public override OpCode Code => OpCode.OpUnreachable;
	public static OpUnreachable Instance { get; } = new();
}
public sealed class OpLifetimeStart : Instruction
{
	private OpLifetimeStart()
	{
	}

	public override string Name => nameof(OpLifetimeStart);
	public override OpCode Code => OpCode.OpLifetimeStart;
	public static OpLifetimeStart Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),];
}
public sealed class OpLifetimeStop : Instruction
{
	private OpLifetimeStop()
	{
	}

	public override string Name => nameof(OpLifetimeStop);
	public override OpCode Code => OpCode.OpLifetimeStop;
	public static OpLifetimeStop Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Size", OperandQuantifier.Default),];
}
public sealed class OpGroupAsyncCopy : Instruction
{
	private OpGroupAsyncCopy()
	{
	}

	public override string Name => nameof(OpGroupAsyncCopy);
	public override OpCode Code => OpCode.OpGroupAsyncCopy;
	public static OpGroupAsyncCopy Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Destination", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Num Elements", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpGroupWaitEvents : Instruction
{
	private OpGroupWaitEvents()
	{
	}

	public override string Name => nameof(OpGroupWaitEvents);
	public override OpCode Code => OpCode.OpGroupWaitEvents;
	public static OpGroupWaitEvents Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Events List", OperandQuantifier.Default),];
}
public sealed class OpGroupAll : Instruction
{
	private OpGroupAll()
	{
	}

	public override string Name => nameof(OpGroupAll);
	public override OpCode Code => OpCode.OpGroupAll;
	public static OpGroupAll Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupAny : Instruction
{
	private OpGroupAny()
	{
	}

	public override string Name => nameof(OpGroupAny);
	public override OpCode Code => OpCode.OpGroupAny;
	public static OpGroupAny Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupBroadcast : Instruction
{
	private OpGroupBroadcast()
	{
	}

	public override string Name => nameof(OpGroupBroadcast);
	public override OpCode Code => OpCode.OpGroupBroadcast;
	public static OpGroupBroadcast Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "LocalId", OperandQuantifier.Default),];
}
public sealed class OpGroupIAdd : Instruction
{
	private OpGroupIAdd()
	{
	}

	public override string Name => nameof(OpGroupIAdd);
	public override OpCode Code => OpCode.OpGroupIAdd;
	public static OpGroupIAdd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFAdd : Instruction
{
	private OpGroupFAdd()
	{
	}

	public override string Name => nameof(OpGroupFAdd);
	public override OpCode Code => OpCode.OpGroupFAdd;
	public static OpGroupFAdd Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMin : Instruction
{
	private OpGroupFMin()
	{
	}

	public override string Name => nameof(OpGroupFMin);
	public override OpCode Code => OpCode.OpGroupFMin;
	public static OpGroupFMin Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMin : Instruction
{
	private OpGroupUMin()
	{
	}

	public override string Name => nameof(OpGroupUMin);
	public override OpCode Code => OpCode.OpGroupUMin;
	public static OpGroupUMin Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMin : Instruction
{
	private OpGroupSMin()
	{
	}

	public override string Name => nameof(OpGroupSMin);
	public override OpCode Code => OpCode.OpGroupSMin;
	public static OpGroupSMin Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMax : Instruction
{
	private OpGroupFMax()
	{
	}

	public override string Name => nameof(OpGroupFMax);
	public override OpCode Code => OpCode.OpGroupFMax;
	public static OpGroupFMax Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMax : Instruction
{
	private OpGroupUMax()
	{
	}

	public override string Name => nameof(OpGroupUMax);
	public override OpCode Code => OpCode.OpGroupUMax;
	public static OpGroupUMax Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMax : Instruction
{
	private OpGroupSMax()
	{
	}

	public override string Name => nameof(OpGroupSMax);
	public override OpCode Code => OpCode.OpGroupSMax;
	public static OpGroupSMax Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpReadPipe : Instruction
{
	private OpReadPipe()
	{
	}

	public override string Name => nameof(OpReadPipe);
	public override OpCode Code => OpCode.OpReadPipe;
	public static OpReadPipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpWritePipe : Instruction
{
	private OpWritePipe()
	{
	}

	public override string Name => nameof(OpWritePipe);
	public override OpCode Code => OpCode.OpWritePipe;
	public static OpWritePipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReservedReadPipe : Instruction
{
	private OpReservedReadPipe()
	{
	}

	public override string Name => nameof(OpReservedReadPipe);
	public override OpCode Code => OpCode.OpReservedReadPipe;
	public static OpReservedReadPipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReservedWritePipe : Instruction
{
	private OpReservedWritePipe()
	{
	}

	public override string Name => nameof(OpReservedWritePipe);
	public override OpCode Code => OpCode.OpReservedWritePipe;
	public static OpReservedWritePipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReserveReadPipePackets : Instruction
{
	private OpReserveReadPipePackets()
	{
	}

	public override string Name => nameof(OpReserveReadPipePackets);
	public override OpCode Code => OpCode.OpReserveReadPipePackets;
	public static OpReserveReadPipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpReserveWritePipePackets : Instruction
{
	private OpReserveWritePipePackets()
	{
	}

	public override string Name => nameof(OpReserveWritePipePackets);
	public override OpCode Code => OpCode.OpReserveWritePipePackets;
	public static OpReserveWritePipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpCommitReadPipe : Instruction
{
	private OpCommitReadPipe()
	{
	}

	public override string Name => nameof(OpCommitReadPipe);
	public override OpCode Code => OpCode.OpCommitReadPipe;
	public static OpCommitReadPipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpCommitWritePipe : Instruction
{
	private OpCommitWritePipe()
	{
	}

	public override string Name => nameof(OpCommitWritePipe);
	public override OpCode Code => OpCode.OpCommitWritePipe;
	public static OpCommitWritePipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpIsValidReserveId : Instruction
{
	private OpIsValidReserveId()
	{
	}

	public override string Name => nameof(OpIsValidReserveId);
	public override OpCode Code => OpCode.OpIsValidReserveId;
	public static OpIsValidReserveId Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default),];
}
public sealed class OpGetNumPipePackets : Instruction
{
	private OpGetNumPipePackets()
	{
	}

	public override string Name => nameof(OpGetNumPipePackets);
	public override OpCode Code => OpCode.OpGetNumPipePackets;
	public static OpGetNumPipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGetMaxPipePackets : Instruction
{
	private OpGetMaxPipePackets()
	{
	}

	public override string Name => nameof(OpGetMaxPipePackets);
	public override OpCode Code => OpCode.OpGetMaxPipePackets;
	public static OpGetMaxPipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupReserveReadPipePackets : Instruction
{
	private OpGroupReserveReadPipePackets()
	{
	}

	public override string Name => nameof(OpGroupReserveReadPipePackets);
	public override OpCode Code => OpCode.OpGroupReserveReadPipePackets;
	public static OpGroupReserveReadPipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupReserveWritePipePackets : Instruction
{
	private OpGroupReserveWritePipePackets()
	{
	}

	public override string Name => nameof(OpGroupReserveWritePipePackets);
	public override OpCode Code => OpCode.OpGroupReserveWritePipePackets;
	public static OpGroupReserveWritePipePackets Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Num Packets", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupCommitReadPipe : Instruction
{
	private OpGroupCommitReadPipe()
	{
	}

	public override string Name => nameof(OpGroupCommitReadPipe);
	public override OpCode Code => OpCode.OpGroupCommitReadPipe;
	public static OpGroupCommitReadPipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpGroupCommitWritePipe : Instruction
{
	private OpGroupCommitWritePipe()
	{
	}

	public override string Name => nameof(OpGroupCommitWritePipe);
	public override OpCode Code => OpCode.OpGroupCommitWritePipe;
	public static OpGroupCommitWritePipe Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Pipe", OperandQuantifier.Default), new Operand(new IdRef(), "Reserve Id", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpEnqueueMarker : Instruction
{
	private OpEnqueueMarker()
	{
	}

	public override string Name => nameof(OpEnqueueMarker);
	public override OpCode Code => OpCode.OpEnqueueMarker;
	public static OpEnqueueMarker Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default),];
}
public sealed class OpEnqueueKernel : Instruction
{
	private OpEnqueueKernel()
	{
	}

	public override string Name => nameof(OpEnqueueKernel);
	public override OpCode Code => OpCode.OpEnqueueKernel;
	public static OpEnqueueKernel Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Queue", OperandQuantifier.Default), new Operand(new IdRef(), "Flags", OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Num Events", OperandQuantifier.Default), new Operand(new IdRef(), "Wait Events", OperandQuantifier.Default), new Operand(new IdRef(), "Ret Event", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default), new Operand(new IdRef(), "Local Size", OperandQuantifier.Varying),];
}
public sealed class OpGetKernelNDrangeSubGroupCount : Instruction
{
	private OpGetKernelNDrangeSubGroupCount()
	{
	}

	public override string Name => nameof(OpGetKernelNDrangeSubGroupCount);
	public override OpCode Code => OpCode.OpGetKernelNDrangeSubGroupCount;
	public static OpGetKernelNDrangeSubGroupCount Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelNDrangeMaxSubGroupSize : Instruction
{
	private OpGetKernelNDrangeMaxSubGroupSize()
	{
	}

	public override string Name => nameof(OpGetKernelNDrangeMaxSubGroupSize);
	public override OpCode Code => OpCode.OpGetKernelNDrangeMaxSubGroupSize;
	public static OpGetKernelNDrangeMaxSubGroupSize Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ND Range", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelWorkGroupSize : Instruction
{
	private OpGetKernelWorkGroupSize()
	{
	}

	public override string Name => nameof(OpGetKernelWorkGroupSize);
	public override OpCode Code => OpCode.OpGetKernelWorkGroupSize;
	public static OpGetKernelWorkGroupSize Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelPreferredWorkGroupSizeMultiple : Instruction
{
	private OpGetKernelPreferredWorkGroupSizeMultiple()
	{
	}

	public override string Name => nameof(OpGetKernelPreferredWorkGroupSizeMultiple);
	public override OpCode Code => OpCode.OpGetKernelPreferredWorkGroupSizeMultiple;
	public static OpGetKernelPreferredWorkGroupSizeMultiple Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpRetainEvent : Instruction
{
	private OpRetainEvent()
	{
	}

	public override string Name => nameof(OpRetainEvent);
	public override OpCode Code => OpCode.OpRetainEvent;
	public static OpRetainEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpReleaseEvent : Instruction
{
	private OpReleaseEvent()
	{
	}

	public override string Name => nameof(OpReleaseEvent);
	public override OpCode Code => OpCode.OpReleaseEvent;
	public static OpReleaseEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpCreateUserEvent : Instruction
{
	private OpCreateUserEvent()
	{
	}

	public override string Name => nameof(OpCreateUserEvent);
	public override OpCode Code => OpCode.OpCreateUserEvent;
	public static OpCreateUserEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpIsValidEvent : Instruction
{
	private OpIsValidEvent()
	{
	}

	public override string Name => nameof(OpIsValidEvent);
	public override OpCode Code => OpCode.OpIsValidEvent;
	public static OpIsValidEvent Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default),];
}
public sealed class OpSetUserEventStatus : Instruction
{
	private OpSetUserEventStatus()
	{
	}

	public override string Name => nameof(OpSetUserEventStatus);
	public override OpCode Code => OpCode.OpSetUserEventStatus;
	public static OpSetUserEventStatus Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Status", OperandQuantifier.Default),];
}
public sealed class OpCaptureEventProfilingInfo : Instruction
{
	private OpCaptureEventProfilingInfo()
	{
	}

	public override string Name => nameof(OpCaptureEventProfilingInfo);
	public override OpCode Code => OpCode.OpCaptureEventProfilingInfo;
	public static OpCaptureEventProfilingInfo Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new IdRef(), "Profiling Info", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGetDefaultQueue : Instruction
{
	private OpGetDefaultQueue()
	{
	}

	public override string Name => nameof(OpGetDefaultQueue);
	public override OpCode Code => OpCode.OpGetDefaultQueue;
	public static OpGetDefaultQueue Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpBuildNDRange : Instruction
{
	private OpBuildNDRange()
	{
	}

	public override string Name => nameof(OpBuildNDRange);
	public override OpCode Code => OpCode.OpBuildNDRange;
	public static OpBuildNDRange Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "LocalWorkSize", OperandQuantifier.Default), new Operand(new IdRef(), "GlobalWorkOffset", OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleImplicitLod : Instruction
{
	private OpImageSparseSampleImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleImplicitLod;
	public static OpImageSparseSampleImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleExplicitLod : Instruction
{
	private OpImageSparseSampleExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleExplicitLod;
	public static OpImageSparseSampleExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleDrefImplicitLod : Instruction
{
	private OpImageSparseSampleDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleDrefImplicitLod;
	public static OpImageSparseSampleDrefImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleDrefExplicitLod : Instruction
{
	private OpImageSparseSampleDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleDrefExplicitLod;
	public static OpImageSparseSampleDrefExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleProjImplicitLod : Instruction
{
	private OpImageSparseSampleProjImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjImplicitLod;
	public static OpImageSparseSampleProjImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleProjExplicitLod : Instruction
{
	private OpImageSparseSampleProjExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjExplicitLod;
	public static OpImageSparseSampleProjExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseSampleProjDrefImplicitLod : Instruction
{
	private OpImageSparseSampleProjDrefImplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjDrefImplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjDrefImplicitLod;
	public static OpImageSparseSampleProjDrefImplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseSampleProjDrefExplicitLod : Instruction
{
	private OpImageSparseSampleProjDrefExplicitLod()
	{
	}

	public override string Name => nameof(OpImageSparseSampleProjDrefExplicitLod);
	public override OpCode Code => OpCode.OpImageSparseSampleProjDrefExplicitLod;
	public static OpImageSparseSampleProjDrefExplicitLod Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSparseFetch : Instruction
{
	private OpImageSparseFetch()
	{
	}

	public override string Name => nameof(OpImageSparseFetch);
	public override OpCode Code => OpCode.OpImageSparseFetch;
	public static OpImageSparseFetch Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseGather : Instruction
{
	private OpImageSparseGather()
	{
	}

	public override string Name => nameof(OpImageSparseGather);
	public override OpCode Code => OpCode.OpImageSparseGather;
	public static OpImageSparseGather Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Component", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseDrefGather : Instruction
{
	private OpImageSparseDrefGather()
	{
	}

	public override string Name => nameof(OpImageSparseDrefGather);
	public override OpCode Code => OpCode.OpImageSparseDrefGather;
	public static OpImageSparseDrefGather Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "D~ref~", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpImageSparseTexelsResident : Instruction
{
	private OpImageSparseTexelsResident()
	{
	}

	public override string Name => nameof(OpImageSparseTexelsResident);
	public override OpCode Code => OpCode.OpImageSparseTexelsResident;
	public static OpImageSparseTexelsResident Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Resident Code", OperandQuantifier.Default),];
}
public sealed class OpNoLine : Instruction
{
	private OpNoLine()
	{
	}

	public override string Name => nameof(OpNoLine);
	public override OpCode Code => OpCode.OpNoLine;
	public static OpNoLine Instance { get; } = new();
}
public sealed class OpAtomicFlagTestAndSet : Instruction
{
	private OpAtomicFlagTestAndSet()
	{
	}

	public override string Name => nameof(OpAtomicFlagTestAndSet);
	public override OpCode Code => OpCode.OpAtomicFlagTestAndSet;
	public static OpAtomicFlagTestAndSet Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpAtomicFlagClear : Instruction
{
	private OpAtomicFlagClear()
	{
	}

	public override string Name => nameof(OpAtomicFlagClear);
	public override OpCode Code => OpCode.OpAtomicFlagClear;
	public static OpAtomicFlagClear Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpImageSparseRead : Instruction
{
	private OpImageSparseRead()
	{
	}

	public override string Name => nameof(OpImageSparseRead);
	public override OpCode Code => OpCode.OpImageSparseRead;
	public static OpImageSparseRead Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpSizeOf : Instruction
{
	private OpSizeOf()
	{
	}

	public override string Name => nameof(OpSizeOf);
	public override OpCode Code => OpCode.OpSizeOf;
	public static OpSizeOf Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpTypePipeStorage : Instruction
{
	private OpTypePipeStorage()
	{
	}

	public override string Name => nameof(OpTypePipeStorage);
	public override OpCode Code => OpCode.OpTypePipeStorage;
	public static OpTypePipeStorage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantPipeStorage : Instruction
{
	private OpConstantPipeStorage()
	{
	}

	public override string Name => nameof(OpConstantPipeStorage);
	public override OpCode Code => OpCode.OpConstantPipeStorage;
	public static OpConstantPipeStorage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Size", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Packet Alignment", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Capacity", OperandQuantifier.Default),];
}
public sealed class OpCreatePipeFromPipeStorage : Instruction
{
	private OpCreatePipeFromPipeStorage()
	{
	}

	public override string Name => nameof(OpCreatePipeFromPipeStorage);
	public override OpCode Code => OpCode.OpCreatePipeFromPipeStorage;
	public static OpCreatePipeFromPipeStorage Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pipe Storage", OperandQuantifier.Default),];
}
public sealed class OpGetKernelLocalSizeForSubgroupCount : Instruction
{
	private OpGetKernelLocalSizeForSubgroupCount()
	{
	}

	public override string Name => nameof(OpGetKernelLocalSizeForSubgroupCount);
	public override OpCode Code => OpCode.OpGetKernelLocalSizeForSubgroupCount;
	public static OpGetKernelLocalSizeForSubgroupCount Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpGetKernelMaxNumSubgroups : Instruction
{
	private OpGetKernelMaxNumSubgroups()
	{
	}

	public override string Name => nameof(OpGetKernelMaxNumSubgroups);
	public override OpCode Code => OpCode.OpGetKernelMaxNumSubgroups;
	public static OpGetKernelMaxNumSubgroups Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Invoke", OperandQuantifier.Default), new Operand(new IdRef(), "Param", OperandQuantifier.Default), new Operand(new IdRef(), "Param Size", OperandQuantifier.Default), new Operand(new IdRef(), "Param Align", OperandQuantifier.Default),];
}
public sealed class OpTypeNamedBarrier : Instruction
{
	private OpTypeNamedBarrier()
	{
	}

	public override string Name => nameof(OpTypeNamedBarrier);
	public override OpCode Code => OpCode.OpTypeNamedBarrier;
	public static OpTypeNamedBarrier Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpNamedBarrierInitialize : Instruction
{
	private OpNamedBarrierInitialize()
	{
	}

	public override string Name => nameof(OpNamedBarrierInitialize);
	public override OpCode Code => OpCode.OpNamedBarrierInitialize;
	public static OpNamedBarrierInitialize Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Subgroup Count", OperandQuantifier.Default),];
}
public sealed class OpMemoryNamedBarrier : Instruction
{
	private OpMemoryNamedBarrier()
	{
	}

	public override string Name => nameof(OpMemoryNamedBarrier);
	public override OpCode Code => OpCode.OpMemoryNamedBarrier;
	public static OpMemoryNamedBarrier Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Named Barrier", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpModuleProcessed : Instruction
{
	private OpModuleProcessed()
	{
	}

	public override string Name => nameof(OpModuleProcessed);
	public override OpCode Code => OpCode.OpModuleProcessed;
	public static OpModuleProcessed Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralString(), "Process", OperandQuantifier.Default),];
}
public sealed class OpExecutionModeId : Instruction
{
	private OpExecutionModeId()
	{
	}

	public override string Name => nameof(OpExecutionModeId);
	public override OpCode Code => OpCode.OpExecutionModeId;
	public static OpExecutionModeId Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new EnumType<ExecutionMode, ExecutionModeParameterFactory>(), "Mode", OperandQuantifier.Default),];
}
public sealed class OpDecorateId : Instruction
{
	private OpDecorateId()
	{
	}

	public override string Name => nameof(OpDecorateId);
	public override OpCode Code => OpCode.OpDecorateId;
	public static OpDecorateId Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupBallotKHR : Instruction
{
	private OpSubgroupBallotKHR()
	{
	}

	public override string Name => nameof(OpSubgroupBallotKHR);
	public override OpCode Code => OpCode.OpSubgroupBallotKHR;
	public static OpSubgroupBallotKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupFirstInvocationKHR : Instruction
{
	private OpSubgroupFirstInvocationKHR()
	{
	}

	public override string Name => nameof(OpSubgroupFirstInvocationKHR);
	public override OpCode Code => OpCode.OpSubgroupFirstInvocationKHR;
	public static OpSubgroupFirstInvocationKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAllKHR : Instruction
{
	private OpSubgroupAllKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAllKHR);
	public override OpCode Code => OpCode.OpSubgroupAllKHR;
	public static OpSubgroupAllKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAnyKHR : Instruction
{
	private OpSubgroupAnyKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAnyKHR);
	public override OpCode Code => OpCode.OpSubgroupAnyKHR;
	public static OpSubgroupAnyKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAllEqualKHR : Instruction
{
	private OpSubgroupAllEqualKHR()
	{
	}

	public override string Name => nameof(OpSubgroupAllEqualKHR);
	public override OpCode Code => OpCode.OpSubgroupAllEqualKHR;
	public static OpSubgroupAllEqualKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupReadInvocationKHR : Instruction
{
	private OpSubgroupReadInvocationKHR()
	{
	}

	public override string Name => nameof(OpSubgroupReadInvocationKHR);
	public override OpCode Code => OpCode.OpSubgroupReadInvocationKHR;
	public static OpSubgroupReadInvocationKHR Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpGroupIAddNonUniformAMD : Instruction
{
	private OpGroupIAddNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupIAddNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupIAddNonUniformAMD;
	public static OpGroupIAddNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFAddNonUniformAMD : Instruction
{
	private OpGroupFAddNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFAddNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFAddNonUniformAMD;
	public static OpGroupFAddNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMinNonUniformAMD : Instruction
{
	private OpGroupFMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFMinNonUniformAMD;
	public static OpGroupFMinNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMinNonUniformAMD : Instruction
{
	private OpGroupUMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupUMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupUMinNonUniformAMD;
	public static OpGroupUMinNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMinNonUniformAMD : Instruction
{
	private OpGroupSMinNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupSMinNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupSMinNonUniformAMD;
	public static OpGroupSMinNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMaxNonUniformAMD : Instruction
{
	private OpGroupFMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupFMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupFMaxNonUniformAMD;
	public static OpGroupFMaxNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupUMaxNonUniformAMD : Instruction
{
	private OpGroupUMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupUMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupUMaxNonUniformAMD;
	public static OpGroupUMaxNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupSMaxNonUniformAMD : Instruction
{
	private OpGroupSMaxNonUniformAMD()
	{
	}

	public override string Name => nameof(OpGroupSMaxNonUniformAMD);
	public override OpCode Code => OpCode.OpGroupSMaxNonUniformAMD;
	public static OpGroupSMaxNonUniformAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpFragmentMaskFetchAMD : Instruction
{
	private OpFragmentMaskFetchAMD()
	{
	}

	public override string Name => nameof(OpFragmentMaskFetchAMD);
	public override OpCode Code => OpCode.OpFragmentMaskFetchAMD;
	public static OpFragmentMaskFetchAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpFragmentFetchAMD : Instruction
{
	private OpFragmentFetchAMD()
	{
	}

	public override string Name => nameof(OpFragmentFetchAMD);
	public override OpCode Code => OpCode.OpFragmentFetchAMD;
	public static OpFragmentFetchAMD Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Fragment Index", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleINTEL : Instruction
{
	private OpSubgroupShuffleINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleINTEL;
	public static OpSubgroupShuffleINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "InvocationId", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleDownINTEL : Instruction
{
	private OpSubgroupShuffleDownINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleDownINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleDownINTEL;
	public static OpSubgroupShuffleDownINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Next", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleUpINTEL : Instruction
{
	private OpSubgroupShuffleUpINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleUpINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleUpINTEL;
	public static OpSubgroupShuffleUpINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Previous", OperandQuantifier.Default), new Operand(new IdRef(), "Current", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpSubgroupShuffleXorINTEL : Instruction
{
	private OpSubgroupShuffleXorINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupShuffleXorINTEL);
	public override OpCode Code => OpCode.OpSubgroupShuffleXorINTEL;
	public static OpSubgroupShuffleXorINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSubgroupBlockReadINTEL : Instruction
{
	private OpSubgroupBlockReadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupBlockReadINTEL);
	public override OpCode Code => OpCode.OpSubgroupBlockReadINTEL;
	public static OpSubgroupBlockReadINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Ptr", OperandQuantifier.Default),];
}
public sealed class OpSubgroupBlockWriteINTEL : Instruction
{
	private OpSubgroupBlockWriteINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupBlockWriteINTEL);
	public override OpCode Code => OpCode.OpSubgroupBlockWriteINTEL;
	public static OpSubgroupBlockWriteINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Ptr", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),];
}
public sealed class OpSubgroupImageBlockReadINTEL : Instruction
{
	private OpSubgroupImageBlockReadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageBlockReadINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageBlockReadINTEL;
	public static OpSubgroupImageBlockReadINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupImageBlockWriteINTEL : Instruction
{
	private OpSubgroupImageBlockWriteINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageBlockWriteINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageBlockWriteINTEL;
	public static OpSubgroupImageBlockWriteINTEL Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),];
}
public sealed class OpDecorateStringGOOGLE : Instruction
{
	private OpDecorateStringGOOGLE()
	{
	}

	public override string Name => nameof(OpDecorateStringGOOGLE);
	public override OpCode Code => OpCode.OpDecorateStringGOOGLE;
	public static OpDecorateStringGOOGLE Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpMemberDecorateStringGOOGLE : Instruction
{
	private OpMemberDecorateStringGOOGLE()
	{
	}

	public override string Name => nameof(OpMemberDecorateStringGOOGLE);
	public override OpCode Code => OpCode.OpMemberDecorateStringGOOGLE;
	public static OpMemberDecorateStringGOOGLE Instance { get; } = new();
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Struct Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}