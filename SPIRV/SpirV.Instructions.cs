using System;
using System.Collections.Generic;

namespace AssetRipper.Disassembly.SpirV;

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
	OpGroupNonUniformElect = 333,
	OpGroupNonUniformAll = 334,
	OpGroupNonUniformAny = 335,
	OpGroupNonUniformAllEqual = 336,
	OpGroupNonUniformBroadcast = 337,
	OpGroupNonUniformBroadcastFirst = 338,
	OpGroupNonUniformBallot = 339,
	OpGroupNonUniformInverseBallot = 340,
	OpGroupNonUniformBallotBitExtract = 341,
	OpGroupNonUniformBallotBitCount = 342,
	OpGroupNonUniformBallotFindLSB = 343,
	OpGroupNonUniformBallotFindMSB = 344,
	OpGroupNonUniformShuffle = 345,
	OpGroupNonUniformShuffleXor = 346,
	OpGroupNonUniformShuffleUp = 347,
	OpGroupNonUniformShuffleDown = 348,
	OpGroupNonUniformIAdd = 349,
	OpGroupNonUniformFAdd = 350,
	OpGroupNonUniformIMul = 351,
	OpGroupNonUniformFMul = 352,
	OpGroupNonUniformSMin = 353,
	OpGroupNonUniformUMin = 354,
	OpGroupNonUniformFMin = 355,
	OpGroupNonUniformSMax = 356,
	OpGroupNonUniformUMax = 357,
	OpGroupNonUniformFMax = 358,
	OpGroupNonUniformBitwiseAnd = 359,
	OpGroupNonUniformBitwiseOr = 360,
	OpGroupNonUniformBitwiseXor = 361,
	OpGroupNonUniformLogicalAnd = 362,
	OpGroupNonUniformLogicalOr = 363,
	OpGroupNonUniformLogicalXor = 364,
	OpGroupNonUniformQuadBroadcast = 365,
	OpGroupNonUniformQuadSwap = 366,
	OpCopyLogical = 400,
	OpPtrEqual = 401,
	OpPtrNotEqual = 402,
	OpPtrDiff = 403,
	OpColorAttachmentReadEXT = 4160,
	OpDepthAttachmentReadEXT = 4161,
	OpStencilAttachmentReadEXT = 4162,
	OpTypeTensorARM = 4163,
	OpTensorReadARM = 4164,
	OpTensorWriteARM = 4165,
	OpTensorQuerySizeARM = 4166,
	OpGraphConstantARM = 4181,
	OpGraphEntryPointARM = 4182,
	OpGraphARM = 4183,
	OpGraphInputARM = 4184,
	OpGraphSetOutputARM = 4185,
	OpGraphEndARM = 4186,
	OpTypeGraphARM = 4190,
	OpTerminateInvocation = 4416,
	OpTypeUntypedPointerKHR = 4417,
	OpUntypedVariableKHR = 4418,
	OpUntypedAccessChainKHR = 4419,
	OpUntypedInBoundsAccessChainKHR = 4420,
	OpSubgroupBallotKHR = 4421,
	OpSubgroupFirstInvocationKHR = 4422,
	OpUntypedPtrAccessChainKHR = 4423,
	OpUntypedInBoundsPtrAccessChainKHR = 4424,
	OpUntypedArrayLengthKHR = 4425,
	OpUntypedPrefetchKHR = 4426,
	OpFmaKHR = 4427,
	OpSubgroupAllKHR = 4428,
	OpSubgroupAnyKHR = 4429,
	OpSubgroupAllEqualKHR = 4430,
	OpGroupNonUniformRotateKHR = 4431,
	OpSubgroupReadInvocationKHR = 4432,
	OpExtInstWithForwardRefsKHR = 4433,
	OpUntypedGroupAsyncCopyKHR = 4434,
	OpTraceRayKHR = 4445,
	OpExecuteCallableKHR = 4446,
	OpConvertUToAccelerationStructureKHR = 4447,
	OpIgnoreIntersectionKHR = 4448,
	OpTerminateRayKHR = 4449,
	OpSDot = 4450,
	OpUDot = 4451,
	OpSUDot = 4452,
	OpSDotAccSat = 4453,
	OpUDotAccSat = 4454,
	OpSUDotAccSat = 4455,
	OpTypeCooperativeMatrixKHR = 4456,
	OpCooperativeMatrixLoadKHR = 4457,
	OpCooperativeMatrixStoreKHR = 4458,
	OpCooperativeMatrixMulAddKHR = 4459,
	OpCooperativeMatrixLengthKHR = 4460,
	OpConstantCompositeReplicateEXT = 4461,
	OpSpecConstantCompositeReplicateEXT = 4462,
	OpCompositeConstructReplicateEXT = 4463,
	OpTypeRayQueryKHR = 4472,
	OpRayQueryInitializeKHR = 4473,
	OpRayQueryTerminateKHR = 4474,
	OpRayQueryGenerateIntersectionKHR = 4475,
	OpRayQueryConfirmIntersectionKHR = 4476,
	OpRayQueryProceedKHR = 4477,
	OpRayQueryGetIntersectionTypeKHR = 4479,
	OpImageSampleWeightedQCOM = 4480,
	OpImageBoxFilterQCOM = 4481,
	OpImageBlockMatchSSDQCOM = 4482,
	OpImageBlockMatchSADQCOM = 4483,
	OpBitCastArrayQCOM = 4497,
	OpImageBlockMatchWindowSSDQCOM = 4500,
	OpImageBlockMatchWindowSADQCOM = 4501,
	OpImageBlockMatchGatherSSDQCOM = 4502,
	OpImageBlockMatchGatherSADQCOM = 4503,
	OpCompositeConstructCoopMatQCOM = 4540,
	OpCompositeExtractCoopMatQCOM = 4541,
	OpExtractSubArrayQCOM = 4542,
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
	OpReadClockKHR = 5056,
	OpAllocateNodePayloadsAMDX = 5074,
	OpEnqueueNodePayloadsAMDX = 5075,
	OpTypeNodePayloadArrayAMDX = 5076,
	OpFinishWritingNodePayloadAMDX = 5078,
	OpNodePayloadArrayLengthAMDX = 5090,
	OpIsNodePayloadValidAMDX = 5101,
	OpConstantStringAMDX = 5103,
	OpSpecConstantStringAMDX = 5104,
	OpGroupNonUniformQuadAllKHR = 5110,
	OpGroupNonUniformQuadAnyKHR = 5111,
	OpTypeBufferEXT = 5115,
	OpBufferPointerEXT = 5119,
	OpUntypedImageTexelPointerEXT = 5126,
	OpMemberDecorateIdEXT = 5127,
	OpConstantSizeOfEXT = 5129,
	OpHitObjectRecordHitMotionNV = 5249,
	OpHitObjectRecordHitWithIndexMotionNV = 5250,
	OpHitObjectRecordMissMotionNV = 5251,
	OpHitObjectGetWorldToObjectNV = 5252,
	OpHitObjectGetObjectToWorldNV = 5253,
	OpHitObjectGetObjectRayDirectionNV = 5254,
	OpHitObjectGetObjectRayOriginNV = 5255,
	OpHitObjectTraceRayMotionNV = 5256,
	OpHitObjectGetShaderRecordBufferHandleNV = 5257,
	OpHitObjectGetShaderBindingTableRecordIndexNV = 5258,
	OpHitObjectRecordEmptyNV = 5259,
	OpHitObjectTraceRayNV = 5260,
	OpHitObjectRecordHitNV = 5261,
	OpHitObjectRecordHitWithIndexNV = 5262,
	OpHitObjectRecordMissNV = 5263,
	OpHitObjectExecuteShaderNV = 5264,
	OpHitObjectGetCurrentTimeNV = 5265,
	OpHitObjectGetAttributesNV = 5266,
	OpHitObjectGetHitKindNV = 5267,
	OpHitObjectGetPrimitiveIndexNV = 5268,
	OpHitObjectGetGeometryIndexNV = 5269,
	OpHitObjectGetInstanceIdNV = 5270,
	OpHitObjectGetInstanceCustomIndexNV = 5271,
	OpHitObjectGetWorldRayDirectionNV = 5272,
	OpHitObjectGetWorldRayOriginNV = 5273,
	OpHitObjectGetRayTMaxNV = 5274,
	OpHitObjectGetRayTMinNV = 5275,
	OpHitObjectIsEmptyNV = 5276,
	OpHitObjectIsHitNV = 5277,
	OpHitObjectIsMissNV = 5278,
	OpReorderThreadWithHitObjectNV = 5279,
	OpReorderThreadWithHintNV = 5280,
	OpTypeHitObjectNV = 5281,
	OpImageSampleFootprintNV = 5283,
	OpTypeVectorIdEXT = 5288,
	OpCooperativeVectorMatrixMulNV = 5289,
	OpCooperativeVectorOuterProductAccumulateNV = 5290,
	OpCooperativeVectorReduceSumAccumulateNV = 5291,
	OpCooperativeVectorMatrixMulAddNV = 5292,
	OpCooperativeMatrixConvertNV = 5293,
	OpEmitMeshTasksEXT = 5294,
	OpSetMeshOutputsEXT = 5295,
	OpGroupNonUniformPartitionEXT = 5296,
	OpWritePackedPrimitiveIndices4x8NV = 5299,
	OpFetchMicroTriangleVertexPositionNV = 5300,
	OpFetchMicroTriangleVertexBarycentricNV = 5301,
	OpCooperativeVectorLoadNV = 5302,
	OpCooperativeVectorStoreNV = 5303,
	OpHitObjectRecordFromQueryEXT = 5304,
	OpHitObjectRecordMissEXT = 5305,
	OpHitObjectRecordMissMotionEXT = 5306,
	OpHitObjectGetIntersectionTriangleVertexPositionsEXT = 5307,
	OpHitObjectGetRayFlagsEXT = 5308,
	OpHitObjectSetShaderBindingTableRecordIndexEXT = 5309,
	OpHitObjectReorderExecuteShaderEXT = 5310,
	OpHitObjectTraceReorderExecuteEXT = 5311,
	OpHitObjectTraceMotionReorderExecuteEXT = 5312,
	OpTypeHitObjectEXT = 5313,
	OpReorderThreadWithHintEXT = 5314,
	OpReorderThreadWithHitObjectEXT = 5315,
	OpHitObjectTraceRayEXT = 5316,
	OpHitObjectTraceRayMotionEXT = 5317,
	OpHitObjectRecordEmptyEXT = 5318,
	OpHitObjectExecuteShaderEXT = 5319,
	OpHitObjectGetCurrentTimeEXT = 5320,
	OpHitObjectGetAttributesEXT = 5321,
	OpHitObjectGetHitKindEXT = 5322,
	OpHitObjectGetPrimitiveIndexEXT = 5323,
	OpHitObjectGetGeometryIndexEXT = 5324,
	OpHitObjectGetInstanceIdEXT = 5325,
	OpHitObjectGetInstanceCustomIndexEXT = 5326,
	OpHitObjectGetObjectRayOriginEXT = 5327,
	OpHitObjectGetObjectRayDirectionEXT = 5328,
	OpHitObjectGetWorldRayDirectionEXT = 5329,
	OpHitObjectGetWorldRayOriginEXT = 5330,
	OpHitObjectGetObjectToWorldEXT = 5331,
	OpHitObjectGetWorldToObjectEXT = 5332,
	OpHitObjectGetRayTMaxEXT = 5333,
	OpReportIntersectionKHR = 5334,
	OpIgnoreIntersectionNV = 5335,
	OpTerminateRayNV = 5336,
	OpTraceNV = 5337,
	OpTraceMotionNV = 5338,
	OpTraceRayMotionNV = 5339,
	OpRayQueryGetIntersectionTriangleVertexPositionsKHR = 5340,
	OpTypeAccelerationStructureKHR = 5341,
	OpExecuteCallableNV = 5344,
	OpRayQueryGetIntersectionClusterIdNV = 5345,
	OpHitObjectGetClusterIdNV = 5346,
	OpHitObjectGetRayTMinEXT = 5347,
	OpHitObjectGetShaderBindingTableRecordIndexEXT = 5348,
	OpHitObjectGetShaderRecordBufferHandleEXT = 5349,
	OpHitObjectIsEmptyEXT = 5350,
	OpHitObjectIsHitEXT = 5351,
	OpHitObjectIsMissEXT = 5352,
	OpTypeCooperativeMatrixNV = 5358,
	OpCooperativeMatrixLoadNV = 5359,
	OpCooperativeMatrixStoreNV = 5360,
	OpCooperativeMatrixMulAddNV = 5361,
	OpCooperativeMatrixLengthNV = 5362,
	OpBeginInvocationInterlockEXT = 5364,
	OpEndInvocationInterlockEXT = 5365,
	OpCooperativeMatrixReduceNV = 5366,
	OpCooperativeMatrixLoadTensorNV = 5367,
	OpCooperativeMatrixStoreTensorNV = 5368,
	OpCooperativeMatrixPerElementOpNV = 5369,
	OpTypeTensorLayoutNV = 5370,
	OpTypeTensorViewNV = 5371,
	OpCreateTensorLayoutNV = 5372,
	OpTensorLayoutSetDimensionNV = 5373,
	OpTensorLayoutSetStrideNV = 5374,
	OpTensorLayoutSliceNV = 5375,
	OpTensorLayoutSetClampValueNV = 5376,
	OpCreateTensorViewNV = 5377,
	OpTensorViewSetDimensionNV = 5378,
	OpTensorViewSetStrideNV = 5379,
	OpDemoteToHelperInvocation = 5380,
	OpIsHelperInvocationEXT = 5381,
	OpTensorViewSetClipNV = 5382,
	OpTensorLayoutSetBlockSizeNV = 5384,
	OpCooperativeMatrixTransposeNV = 5390,
	OpConvertUToImageNV = 5391,
	OpConvertUToSamplerNV = 5392,
	OpConvertImageToUNV = 5393,
	OpConvertSamplerToUNV = 5394,
	OpConvertUToSampledImageNV = 5395,
	OpConvertSampledImageToUNV = 5396,
	OpSamplerImageAddressingModeNV = 5397,
	OpRawAccessChainNV = 5398,
	OpRayQueryGetIntersectionSpherePositionNV = 5427,
	OpRayQueryGetIntersectionSphereRadiusNV = 5428,
	OpRayQueryGetIntersectionLSSPositionsNV = 5429,
	OpRayQueryGetIntersectionLSSRadiiNV = 5430,
	OpRayQueryGetIntersectionLSSHitValueNV = 5431,
	OpHitObjectGetSpherePositionNV = 5432,
	OpHitObjectGetSphereRadiusNV = 5433,
	OpHitObjectGetLSSPositionsNV = 5434,
	OpHitObjectGetLSSRadiiNV = 5435,
	OpHitObjectIsSphereHitNV = 5436,
	OpHitObjectIsLSSHitNV = 5437,
	OpRayQueryIsSphereHitNV = 5438,
	OpRayQueryIsLSSHitNV = 5439,
	OpSubgroupShuffleINTEL = 5571,
	OpSubgroupShuffleDownINTEL = 5572,
	OpSubgroupShuffleUpINTEL = 5573,
	OpSubgroupShuffleXorINTEL = 5574,
	OpSubgroupBlockReadINTEL = 5575,
	OpSubgroupBlockWriteINTEL = 5576,
	OpSubgroupImageBlockReadINTEL = 5577,
	OpSubgroupImageBlockWriteINTEL = 5578,
	OpSubgroupImageMediaBlockReadINTEL = 5580,
	OpSubgroupImageMediaBlockWriteINTEL = 5581,
	OpUCountLeadingZerosINTEL = 5585,
	OpUCountTrailingZerosINTEL = 5586,
	OpAbsISubINTEL = 5587,
	OpAbsUSubINTEL = 5588,
	OpIAddSatINTEL = 5589,
	OpUAddSatINTEL = 5590,
	OpIAverageINTEL = 5591,
	OpUAverageINTEL = 5592,
	OpIAverageRoundedINTEL = 5593,
	OpUAverageRoundedINTEL = 5594,
	OpISubSatINTEL = 5595,
	OpUSubSatINTEL = 5596,
	OpIMul32x16INTEL = 5597,
	OpUMul32x16INTEL = 5598,
	OpConstantFunctionPointerINTEL = 5600,
	OpFunctionPointerCallINTEL = 5601,
	OpAsmTargetINTEL = 5609,
	OpAsmINTEL = 5610,
	OpAsmCallINTEL = 5611,
	OpAtomicFMinEXT = 5614,
	OpAtomicFMaxEXT = 5615,
	OpAssumeTrueKHR = 5630,
	OpExpectKHR = 5631,
	OpDecorateString = 5632,
	OpMemberDecorateString = 5633,
	OpVmeImageINTEL = 5699,
	OpTypeVmeImageINTEL = 5700,
	OpTypeAvcImePayloadINTEL = 5701,
	OpTypeAvcRefPayloadINTEL = 5702,
	OpTypeAvcSicPayloadINTEL = 5703,
	OpTypeAvcMcePayloadINTEL = 5704,
	OpTypeAvcMceResultINTEL = 5705,
	OpTypeAvcImeResultINTEL = 5706,
	OpTypeAvcImeResultSingleReferenceStreamoutINTEL = 5707,
	OpTypeAvcImeResultDualReferenceStreamoutINTEL = 5708,
	OpTypeAvcImeSingleReferenceStreaminINTEL = 5709,
	OpTypeAvcImeDualReferenceStreaminINTEL = 5710,
	OpTypeAvcRefResultINTEL = 5711,
	OpTypeAvcSicResultINTEL = 5712,
	OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL = 5713,
	OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL = 5714,
	OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL = 5715,
	OpSubgroupAvcMceSetInterShapePenaltyINTEL = 5716,
	OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL = 5717,
	OpSubgroupAvcMceSetInterDirectionPenaltyINTEL = 5718,
	OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL = 5719,
	OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL = 5720,
	OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL = 5721,
	OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL = 5722,
	OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL = 5723,
	OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL = 5724,
	OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL = 5725,
	OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL = 5726,
	OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL = 5727,
	OpSubgroupAvcMceSetAcOnlyHaarINTEL = 5728,
	OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL = 5729,
	OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL = 5730,
	OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL = 5731,
	OpSubgroupAvcMceConvertToImePayloadINTEL = 5732,
	OpSubgroupAvcMceConvertToImeResultINTEL = 5733,
	OpSubgroupAvcMceConvertToRefPayloadINTEL = 5734,
	OpSubgroupAvcMceConvertToRefResultINTEL = 5735,
	OpSubgroupAvcMceConvertToSicPayloadINTEL = 5736,
	OpSubgroupAvcMceConvertToSicResultINTEL = 5737,
	OpSubgroupAvcMceGetMotionVectorsINTEL = 5738,
	OpSubgroupAvcMceGetInterDistortionsINTEL = 5739,
	OpSubgroupAvcMceGetBestInterDistortionsINTEL = 5740,
	OpSubgroupAvcMceGetInterMajorShapeINTEL = 5741,
	OpSubgroupAvcMceGetInterMinorShapeINTEL = 5742,
	OpSubgroupAvcMceGetInterDirectionsINTEL = 5743,
	OpSubgroupAvcMceGetInterMotionVectorCountINTEL = 5744,
	OpSubgroupAvcMceGetInterReferenceIdsINTEL = 5745,
	OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL = 5746,
	OpSubgroupAvcImeInitializeINTEL = 5747,
	OpSubgroupAvcImeSetSingleReferenceINTEL = 5748,
	OpSubgroupAvcImeSetDualReferenceINTEL = 5749,
	OpSubgroupAvcImeRefWindowSizeINTEL = 5750,
	OpSubgroupAvcImeAdjustRefOffsetINTEL = 5751,
	OpSubgroupAvcImeConvertToMcePayloadINTEL = 5752,
	OpSubgroupAvcImeSetMaxMotionVectorCountINTEL = 5753,
	OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL = 5754,
	OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL = 5755,
	OpSubgroupAvcImeSetWeightedSadINTEL = 5756,
	OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL = 5757,
	OpSubgroupAvcImeEvaluateWithDualReferenceINTEL = 5758,
	OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL = 5759,
	OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL = 5760,
	OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL = 5761,
	OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL = 5762,
	OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL = 5763,
	OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL = 5764,
	OpSubgroupAvcImeConvertToMceResultINTEL = 5765,
	OpSubgroupAvcImeGetSingleReferenceStreaminINTEL = 5766,
	OpSubgroupAvcImeGetDualReferenceStreaminINTEL = 5767,
	OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL = 5768,
	OpSubgroupAvcImeStripDualReferenceStreamoutINTEL = 5769,
	OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL = 5770,
	OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL = 5771,
	OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL = 5772,
	OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL = 5773,
	OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL = 5774,
	OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL = 5775,
	OpSubgroupAvcImeGetBorderReachedINTEL = 5776,
	OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL = 5777,
	OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL = 5778,
	OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL = 5779,
	OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL = 5780,
	OpSubgroupAvcFmeInitializeINTEL = 5781,
	OpSubgroupAvcBmeInitializeINTEL = 5782,
	OpSubgroupAvcRefConvertToMcePayloadINTEL = 5783,
	OpSubgroupAvcRefSetBidirectionalMixDisableINTEL = 5784,
	OpSubgroupAvcRefSetBilinearFilterEnableINTEL = 5785,
	OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL = 5786,
	OpSubgroupAvcRefEvaluateWithDualReferenceINTEL = 5787,
	OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL = 5788,
	OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL = 5789,
	OpSubgroupAvcRefConvertToMceResultINTEL = 5790,
	OpSubgroupAvcSicInitializeINTEL = 5791,
	OpSubgroupAvcSicConfigureSkcINTEL = 5792,
	OpSubgroupAvcSicConfigureIpeLumaINTEL = 5793,
	OpSubgroupAvcSicConfigureIpeLumaChromaINTEL = 5794,
	OpSubgroupAvcSicGetMotionVectorMaskINTEL = 5795,
	OpSubgroupAvcSicConvertToMcePayloadINTEL = 5796,
	OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL = 5797,
	OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL = 5798,
	OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL = 5799,
	OpSubgroupAvcSicSetBilinearFilterEnableINTEL = 5800,
	OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL = 5801,
	OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL = 5802,
	OpSubgroupAvcSicEvaluateIpeINTEL = 5803,
	OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL = 5804,
	OpSubgroupAvcSicEvaluateWithDualReferenceINTEL = 5805,
	OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL = 5806,
	OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL = 5807,
	OpSubgroupAvcSicConvertToMceResultINTEL = 5808,
	OpSubgroupAvcSicGetIpeLumaShapeINTEL = 5809,
	OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL = 5810,
	OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL = 5811,
	OpSubgroupAvcSicGetPackedIpeLumaModesINTEL = 5812,
	OpSubgroupAvcSicGetIpeChromaModeINTEL = 5813,
	OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL = 5814,
	OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL = 5815,
	OpSubgroupAvcSicGetInterRawSadsINTEL = 5816,
	OpVariableLengthArrayINTEL = 5818,
	OpSaveMemoryINTEL = 5819,
	OpRestoreMemoryINTEL = 5820,
	OpArbitraryFloatSinCosPiALTERA = 5840,
	OpArbitraryFloatCastALTERA = 5841,
	OpArbitraryFloatCastFromIntALTERA = 5842,
	OpArbitraryFloatCastToIntALTERA = 5843,
	OpArbitraryFloatAddALTERA = 5846,
	OpArbitraryFloatSubALTERA = 5847,
	OpArbitraryFloatMulALTERA = 5848,
	OpArbitraryFloatDivALTERA = 5849,
	OpArbitraryFloatGTALTERA = 5850,
	OpArbitraryFloatGEALTERA = 5851,
	OpArbitraryFloatLTALTERA = 5852,
	OpArbitraryFloatLEALTERA = 5853,
	OpArbitraryFloatEQALTERA = 5854,
	OpArbitraryFloatRecipALTERA = 5855,
	OpArbitraryFloatRSqrtALTERA = 5856,
	OpArbitraryFloatCbrtALTERA = 5857,
	OpArbitraryFloatHypotALTERA = 5858,
	OpArbitraryFloatSqrtALTERA = 5859,
	OpArbitraryFloatLogINTEL = 5860,
	OpArbitraryFloatLog2INTEL = 5861,
	OpArbitraryFloatLog10INTEL = 5862,
	OpArbitraryFloatLog1pINTEL = 5863,
	OpArbitraryFloatExpINTEL = 5864,
	OpArbitraryFloatExp2INTEL = 5865,
	OpArbitraryFloatExp10INTEL = 5866,
	OpArbitraryFloatExpm1INTEL = 5867,
	OpArbitraryFloatSinINTEL = 5868,
	OpArbitraryFloatCosINTEL = 5869,
	OpArbitraryFloatSinCosINTEL = 5870,
	OpArbitraryFloatSinPiINTEL = 5871,
	OpArbitraryFloatCosPiINTEL = 5872,
	OpArbitraryFloatASinINTEL = 5873,
	OpArbitraryFloatASinPiINTEL = 5874,
	OpArbitraryFloatACosINTEL = 5875,
	OpArbitraryFloatACosPiINTEL = 5876,
	OpArbitraryFloatATanINTEL = 5877,
	OpArbitraryFloatATanPiINTEL = 5878,
	OpArbitraryFloatATan2INTEL = 5879,
	OpArbitraryFloatPowINTEL = 5880,
	OpArbitraryFloatPowRINTEL = 5881,
	OpArbitraryFloatPowNINTEL = 5882,
	OpLoopControlINTEL = 5887,
	OpAliasDomainDeclINTEL = 5911,
	OpAliasScopeDeclINTEL = 5912,
	OpAliasScopeListDeclINTEL = 5913,
	OpFixedSqrtALTERA = 5923,
	OpFixedRecipALTERA = 5924,
	OpFixedRsqrtALTERA = 5925,
	OpFixedSinALTERA = 5926,
	OpFixedCosALTERA = 5927,
	OpFixedSinCosALTERA = 5928,
	OpFixedSinPiALTERA = 5929,
	OpFixedCosPiALTERA = 5930,
	OpFixedSinCosPiALTERA = 5931,
	OpFixedLogALTERA = 5932,
	OpFixedExpALTERA = 5933,
	OpPtrCastToCrossWorkgroupALTERA = 5934,
	OpCrossWorkgroupCastToPtrALTERA = 5938,
	OpReadPipeBlockingALTERA = 5946,
	OpWritePipeBlockingALTERA = 5947,
	OpFPGARegALTERA = 5949,
	OpRayQueryGetRayTMinKHR = 6016,
	OpRayQueryGetRayFlagsKHR = 6017,
	OpRayQueryGetIntersectionTKHR = 6018,
	OpRayQueryGetIntersectionInstanceCustomIndexKHR = 6019,
	OpRayQueryGetIntersectionInstanceIdKHR = 6020,
	OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR = 6021,
	OpRayQueryGetIntersectionGeometryIndexKHR = 6022,
	OpRayQueryGetIntersectionPrimitiveIndexKHR = 6023,
	OpRayQueryGetIntersectionBarycentricsKHR = 6024,
	OpRayQueryGetIntersectionFrontFaceKHR = 6025,
	OpRayQueryGetIntersectionCandidateAABBOpaqueKHR = 6026,
	OpRayQueryGetIntersectionObjectRayDirectionKHR = 6027,
	OpRayQueryGetIntersectionObjectRayOriginKHR = 6028,
	OpRayQueryGetWorldRayDirectionKHR = 6029,
	OpRayQueryGetWorldRayOriginKHR = 6030,
	OpRayQueryGetIntersectionObjectToWorldKHR = 6031,
	OpRayQueryGetIntersectionWorldToObjectKHR = 6032,
	OpAtomicFAddEXT = 6035,
	OpTypeBufferSurfaceINTEL = 6086,
	OpTypeStructContinuedINTEL = 6090,
	OpConstantCompositeContinuedINTEL = 6091,
	OpSpecConstantCompositeContinuedINTEL = 6092,
	OpCompositeConstructContinuedINTEL = 6096,
	OpConvertFToBF16INTEL = 6116,
	OpConvertBF16ToFINTEL = 6117,
	OpControlBarrierArriveINTEL = 6142,
	OpControlBarrierWaitINTEL = 6143,
	OpArithmeticFenceEXT = 6145,
	OpTaskSequenceCreateALTERA = 6163,
	OpTaskSequenceAsyncALTERA = 6164,
	OpTaskSequenceGetALTERA = 6165,
	OpTaskSequenceReleaseALTERA = 6166,
	OpTypeTaskSequenceALTERA = 6199,
	OpSubgroupBlockPrefetchINTEL = 6221,
	OpSubgroup2DBlockLoadINTEL = 6231,
	OpSubgroup2DBlockLoadTransformINTEL = 6232,
	OpSubgroup2DBlockLoadTransposeINTEL = 6233,
	OpSubgroup2DBlockPrefetchINTEL = 6234,
	OpSubgroup2DBlockStoreINTEL = 6235,
	OpSubgroupMatrixMultiplyAccumulateINTEL = 6237,
	OpBitwiseFunctionINTEL = 6242,
	OpUntypedVariableLengthArrayINTEL = 6244,
	OpConditionalExtensionINTEL = 6248,
	OpConditionalEntryPointINTEL = 6249,
	OpConditionalCapabilityINTEL = 6250,
	OpSpecConstantTargetINTEL = 6251,
	OpSpecConstantArchitectureINTEL = 6252,
	OpSpecConstantCapabilitiesINTEL = 6253,
	OpConditionalCopyObjectINTEL = 6254,
	OpGroupIMulKHR = 6401,
	OpGroupFMulKHR = 6402,
	OpGroupBitwiseAndKHR = 6403,
	OpGroupBitwiseOrKHR = 6404,
	OpGroupBitwiseXorKHR = 6405,
	OpGroupLogicalAndKHR = 6406,
	OpGroupLogicalOrKHR = 6407,
	OpGroupLogicalXorKHR = 6408,
	OpRoundFToTF32INTEL = 6426,
	OpMaskedGatherINTEL = 6428,
	OpMaskedScatterINTEL = 6429,
	OpConvertHandleToImageINTEL = 6529,
	OpConvertHandleToSamplerINTEL = 6530,
	OpConvertHandleToSampledImageINTEL = 6531,
	OpFDot2MixAcc32VALVE = 6916,
	OpFDot2MixAcc16VALVE = 6917,
	OpFDot4MixAcc32VALVE = 6918,
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
		OpCode.OpGroupNonUniformElect => OpGroupNonUniformElect.Instance,
		OpCode.OpGroupNonUniformAll => OpGroupNonUniformAll.Instance,
		OpCode.OpGroupNonUniformAny => OpGroupNonUniformAny.Instance,
		OpCode.OpGroupNonUniformAllEqual => OpGroupNonUniformAllEqual.Instance,
		OpCode.OpGroupNonUniformBroadcast => OpGroupNonUniformBroadcast.Instance,
		OpCode.OpGroupNonUniformBroadcastFirst => OpGroupNonUniformBroadcastFirst.Instance,
		OpCode.OpGroupNonUniformBallot => OpGroupNonUniformBallot.Instance,
		OpCode.OpGroupNonUniformInverseBallot => OpGroupNonUniformInverseBallot.Instance,
		OpCode.OpGroupNonUniformBallotBitExtract => OpGroupNonUniformBallotBitExtract.Instance,
		OpCode.OpGroupNonUniformBallotBitCount => OpGroupNonUniformBallotBitCount.Instance,
		OpCode.OpGroupNonUniformBallotFindLSB => OpGroupNonUniformBallotFindLSB.Instance,
		OpCode.OpGroupNonUniformBallotFindMSB => OpGroupNonUniformBallotFindMSB.Instance,
		OpCode.OpGroupNonUniformShuffle => OpGroupNonUniformShuffle.Instance,
		OpCode.OpGroupNonUniformShuffleXor => OpGroupNonUniformShuffleXor.Instance,
		OpCode.OpGroupNonUniformShuffleUp => OpGroupNonUniformShuffleUp.Instance,
		OpCode.OpGroupNonUniformShuffleDown => OpGroupNonUniformShuffleDown.Instance,
		OpCode.OpGroupNonUniformIAdd => OpGroupNonUniformIAdd.Instance,
		OpCode.OpGroupNonUniformFAdd => OpGroupNonUniformFAdd.Instance,
		OpCode.OpGroupNonUniformIMul => OpGroupNonUniformIMul.Instance,
		OpCode.OpGroupNonUniformFMul => OpGroupNonUniformFMul.Instance,
		OpCode.OpGroupNonUniformSMin => OpGroupNonUniformSMin.Instance,
		OpCode.OpGroupNonUniformUMin => OpGroupNonUniformUMin.Instance,
		OpCode.OpGroupNonUniformFMin => OpGroupNonUniformFMin.Instance,
		OpCode.OpGroupNonUniformSMax => OpGroupNonUniformSMax.Instance,
		OpCode.OpGroupNonUniformUMax => OpGroupNonUniformUMax.Instance,
		OpCode.OpGroupNonUniformFMax => OpGroupNonUniformFMax.Instance,
		OpCode.OpGroupNonUniformBitwiseAnd => OpGroupNonUniformBitwiseAnd.Instance,
		OpCode.OpGroupNonUniformBitwiseOr => OpGroupNonUniformBitwiseOr.Instance,
		OpCode.OpGroupNonUniformBitwiseXor => OpGroupNonUniformBitwiseXor.Instance,
		OpCode.OpGroupNonUniformLogicalAnd => OpGroupNonUniformLogicalAnd.Instance,
		OpCode.OpGroupNonUniformLogicalOr => OpGroupNonUniformLogicalOr.Instance,
		OpCode.OpGroupNonUniformLogicalXor => OpGroupNonUniformLogicalXor.Instance,
		OpCode.OpGroupNonUniformQuadBroadcast => OpGroupNonUniformQuadBroadcast.Instance,
		OpCode.OpGroupNonUniformQuadSwap => OpGroupNonUniformQuadSwap.Instance,
		OpCode.OpCopyLogical => OpCopyLogical.Instance,
		OpCode.OpPtrEqual => OpPtrEqual.Instance,
		OpCode.OpPtrNotEqual => OpPtrNotEqual.Instance,
		OpCode.OpPtrDiff => OpPtrDiff.Instance,
		OpCode.OpColorAttachmentReadEXT => OpColorAttachmentReadEXT.Instance,
		OpCode.OpDepthAttachmentReadEXT => OpDepthAttachmentReadEXT.Instance,
		OpCode.OpStencilAttachmentReadEXT => OpStencilAttachmentReadEXT.Instance,
		OpCode.OpTypeTensorARM => OpTypeTensorARM.Instance,
		OpCode.OpTensorReadARM => OpTensorReadARM.Instance,
		OpCode.OpTensorWriteARM => OpTensorWriteARM.Instance,
		OpCode.OpTensorQuerySizeARM => OpTensorQuerySizeARM.Instance,
		OpCode.OpGraphConstantARM => OpGraphConstantARM.Instance,
		OpCode.OpGraphEntryPointARM => OpGraphEntryPointARM.Instance,
		OpCode.OpGraphARM => OpGraphARM.Instance,
		OpCode.OpGraphInputARM => OpGraphInputARM.Instance,
		OpCode.OpGraphSetOutputARM => OpGraphSetOutputARM.Instance,
		OpCode.OpGraphEndARM => OpGraphEndARM.Instance,
		OpCode.OpTypeGraphARM => OpTypeGraphARM.Instance,
		OpCode.OpTerminateInvocation => OpTerminateInvocation.Instance,
		OpCode.OpTypeUntypedPointerKHR => OpTypeUntypedPointerKHR.Instance,
		OpCode.OpUntypedVariableKHR => OpUntypedVariableKHR.Instance,
		OpCode.OpUntypedAccessChainKHR => OpUntypedAccessChainKHR.Instance,
		OpCode.OpUntypedInBoundsAccessChainKHR => OpUntypedInBoundsAccessChainKHR.Instance,
		OpCode.OpSubgroupBallotKHR => OpSubgroupBallotKHR.Instance,
		OpCode.OpSubgroupFirstInvocationKHR => OpSubgroupFirstInvocationKHR.Instance,
		OpCode.OpUntypedPtrAccessChainKHR => OpUntypedPtrAccessChainKHR.Instance,
		OpCode.OpUntypedInBoundsPtrAccessChainKHR => OpUntypedInBoundsPtrAccessChainKHR.Instance,
		OpCode.OpUntypedArrayLengthKHR => OpUntypedArrayLengthKHR.Instance,
		OpCode.OpUntypedPrefetchKHR => OpUntypedPrefetchKHR.Instance,
		OpCode.OpFmaKHR => OpFmaKHR.Instance,
		OpCode.OpSubgroupAllKHR => OpSubgroupAllKHR.Instance,
		OpCode.OpSubgroupAnyKHR => OpSubgroupAnyKHR.Instance,
		OpCode.OpSubgroupAllEqualKHR => OpSubgroupAllEqualKHR.Instance,
		OpCode.OpGroupNonUniformRotateKHR => OpGroupNonUniformRotateKHR.Instance,
		OpCode.OpSubgroupReadInvocationKHR => OpSubgroupReadInvocationKHR.Instance,
		OpCode.OpExtInstWithForwardRefsKHR => OpExtInstWithForwardRefsKHR.Instance,
		OpCode.OpUntypedGroupAsyncCopyKHR => OpUntypedGroupAsyncCopyKHR.Instance,
		OpCode.OpTraceRayKHR => OpTraceRayKHR.Instance,
		OpCode.OpExecuteCallableKHR => OpExecuteCallableKHR.Instance,
		OpCode.OpConvertUToAccelerationStructureKHR => OpConvertUToAccelerationStructureKHR.Instance,
		OpCode.OpIgnoreIntersectionKHR => OpIgnoreIntersectionKHR.Instance,
		OpCode.OpTerminateRayKHR => OpTerminateRayKHR.Instance,
		OpCode.OpSDot => OpSDot.Instance,
		OpCode.OpUDot => OpUDot.Instance,
		OpCode.OpSUDot => OpSUDot.Instance,
		OpCode.OpSDotAccSat => OpSDotAccSat.Instance,
		OpCode.OpUDotAccSat => OpUDotAccSat.Instance,
		OpCode.OpSUDotAccSat => OpSUDotAccSat.Instance,
		OpCode.OpTypeCooperativeMatrixKHR => OpTypeCooperativeMatrixKHR.Instance,
		OpCode.OpCooperativeMatrixLoadKHR => OpCooperativeMatrixLoadKHR.Instance,
		OpCode.OpCooperativeMatrixStoreKHR => OpCooperativeMatrixStoreKHR.Instance,
		OpCode.OpCooperativeMatrixMulAddKHR => OpCooperativeMatrixMulAddKHR.Instance,
		OpCode.OpCooperativeMatrixLengthKHR => OpCooperativeMatrixLengthKHR.Instance,
		OpCode.OpConstantCompositeReplicateEXT => OpConstantCompositeReplicateEXT.Instance,
		OpCode.OpSpecConstantCompositeReplicateEXT => OpSpecConstantCompositeReplicateEXT.Instance,
		OpCode.OpCompositeConstructReplicateEXT => OpCompositeConstructReplicateEXT.Instance,
		OpCode.OpTypeRayQueryKHR => OpTypeRayQueryKHR.Instance,
		OpCode.OpRayQueryInitializeKHR => OpRayQueryInitializeKHR.Instance,
		OpCode.OpRayQueryTerminateKHR => OpRayQueryTerminateKHR.Instance,
		OpCode.OpRayQueryGenerateIntersectionKHR => OpRayQueryGenerateIntersectionKHR.Instance,
		OpCode.OpRayQueryConfirmIntersectionKHR => OpRayQueryConfirmIntersectionKHR.Instance,
		OpCode.OpRayQueryProceedKHR => OpRayQueryProceedKHR.Instance,
		OpCode.OpRayQueryGetIntersectionTypeKHR => OpRayQueryGetIntersectionTypeKHR.Instance,
		OpCode.OpImageSampleWeightedQCOM => OpImageSampleWeightedQCOM.Instance,
		OpCode.OpImageBoxFilterQCOM => OpImageBoxFilterQCOM.Instance,
		OpCode.OpImageBlockMatchSSDQCOM => OpImageBlockMatchSSDQCOM.Instance,
		OpCode.OpImageBlockMatchSADQCOM => OpImageBlockMatchSADQCOM.Instance,
		OpCode.OpBitCastArrayQCOM => OpBitCastArrayQCOM.Instance,
		OpCode.OpImageBlockMatchWindowSSDQCOM => OpImageBlockMatchWindowSSDQCOM.Instance,
		OpCode.OpImageBlockMatchWindowSADQCOM => OpImageBlockMatchWindowSADQCOM.Instance,
		OpCode.OpImageBlockMatchGatherSSDQCOM => OpImageBlockMatchGatherSSDQCOM.Instance,
		OpCode.OpImageBlockMatchGatherSADQCOM => OpImageBlockMatchGatherSADQCOM.Instance,
		OpCode.OpCompositeConstructCoopMatQCOM => OpCompositeConstructCoopMatQCOM.Instance,
		OpCode.OpCompositeExtractCoopMatQCOM => OpCompositeExtractCoopMatQCOM.Instance,
		OpCode.OpExtractSubArrayQCOM => OpExtractSubArrayQCOM.Instance,
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
		OpCode.OpReadClockKHR => OpReadClockKHR.Instance,
		OpCode.OpAllocateNodePayloadsAMDX => OpAllocateNodePayloadsAMDX.Instance,
		OpCode.OpEnqueueNodePayloadsAMDX => OpEnqueueNodePayloadsAMDX.Instance,
		OpCode.OpTypeNodePayloadArrayAMDX => OpTypeNodePayloadArrayAMDX.Instance,
		OpCode.OpFinishWritingNodePayloadAMDX => OpFinishWritingNodePayloadAMDX.Instance,
		OpCode.OpNodePayloadArrayLengthAMDX => OpNodePayloadArrayLengthAMDX.Instance,
		OpCode.OpIsNodePayloadValidAMDX => OpIsNodePayloadValidAMDX.Instance,
		OpCode.OpConstantStringAMDX => OpConstantStringAMDX.Instance,
		OpCode.OpSpecConstantStringAMDX => OpSpecConstantStringAMDX.Instance,
		OpCode.OpGroupNonUniformQuadAllKHR => OpGroupNonUniformQuadAllKHR.Instance,
		OpCode.OpGroupNonUniformQuadAnyKHR => OpGroupNonUniformQuadAnyKHR.Instance,
		OpCode.OpTypeBufferEXT => OpTypeBufferEXT.Instance,
		OpCode.OpBufferPointerEXT => OpBufferPointerEXT.Instance,
		OpCode.OpUntypedImageTexelPointerEXT => OpUntypedImageTexelPointerEXT.Instance,
		OpCode.OpMemberDecorateIdEXT => OpMemberDecorateIdEXT.Instance,
		OpCode.OpConstantSizeOfEXT => OpConstantSizeOfEXT.Instance,
		OpCode.OpHitObjectRecordHitMotionNV => OpHitObjectRecordHitMotionNV.Instance,
		OpCode.OpHitObjectRecordHitWithIndexMotionNV => OpHitObjectRecordHitWithIndexMotionNV.Instance,
		OpCode.OpHitObjectRecordMissMotionNV => OpHitObjectRecordMissMotionNV.Instance,
		OpCode.OpHitObjectGetWorldToObjectNV => OpHitObjectGetWorldToObjectNV.Instance,
		OpCode.OpHitObjectGetObjectToWorldNV => OpHitObjectGetObjectToWorldNV.Instance,
		OpCode.OpHitObjectGetObjectRayDirectionNV => OpHitObjectGetObjectRayDirectionNV.Instance,
		OpCode.OpHitObjectGetObjectRayOriginNV => OpHitObjectGetObjectRayOriginNV.Instance,
		OpCode.OpHitObjectTraceRayMotionNV => OpHitObjectTraceRayMotionNV.Instance,
		OpCode.OpHitObjectGetShaderRecordBufferHandleNV => OpHitObjectGetShaderRecordBufferHandleNV.Instance,
		OpCode.OpHitObjectGetShaderBindingTableRecordIndexNV => OpHitObjectGetShaderBindingTableRecordIndexNV.Instance,
		OpCode.OpHitObjectRecordEmptyNV => OpHitObjectRecordEmptyNV.Instance,
		OpCode.OpHitObjectTraceRayNV => OpHitObjectTraceRayNV.Instance,
		OpCode.OpHitObjectRecordHitNV => OpHitObjectRecordHitNV.Instance,
		OpCode.OpHitObjectRecordHitWithIndexNV => OpHitObjectRecordHitWithIndexNV.Instance,
		OpCode.OpHitObjectRecordMissNV => OpHitObjectRecordMissNV.Instance,
		OpCode.OpHitObjectExecuteShaderNV => OpHitObjectExecuteShaderNV.Instance,
		OpCode.OpHitObjectGetCurrentTimeNV => OpHitObjectGetCurrentTimeNV.Instance,
		OpCode.OpHitObjectGetAttributesNV => OpHitObjectGetAttributesNV.Instance,
		OpCode.OpHitObjectGetHitKindNV => OpHitObjectGetHitKindNV.Instance,
		OpCode.OpHitObjectGetPrimitiveIndexNV => OpHitObjectGetPrimitiveIndexNV.Instance,
		OpCode.OpHitObjectGetGeometryIndexNV => OpHitObjectGetGeometryIndexNV.Instance,
		OpCode.OpHitObjectGetInstanceIdNV => OpHitObjectGetInstanceIdNV.Instance,
		OpCode.OpHitObjectGetInstanceCustomIndexNV => OpHitObjectGetInstanceCustomIndexNV.Instance,
		OpCode.OpHitObjectGetWorldRayDirectionNV => OpHitObjectGetWorldRayDirectionNV.Instance,
		OpCode.OpHitObjectGetWorldRayOriginNV => OpHitObjectGetWorldRayOriginNV.Instance,
		OpCode.OpHitObjectGetRayTMaxNV => OpHitObjectGetRayTMaxNV.Instance,
		OpCode.OpHitObjectGetRayTMinNV => OpHitObjectGetRayTMinNV.Instance,
		OpCode.OpHitObjectIsEmptyNV => OpHitObjectIsEmptyNV.Instance,
		OpCode.OpHitObjectIsHitNV => OpHitObjectIsHitNV.Instance,
		OpCode.OpHitObjectIsMissNV => OpHitObjectIsMissNV.Instance,
		OpCode.OpReorderThreadWithHitObjectNV => OpReorderThreadWithHitObjectNV.Instance,
		OpCode.OpReorderThreadWithHintNV => OpReorderThreadWithHintNV.Instance,
		OpCode.OpTypeHitObjectNV => OpTypeHitObjectNV.Instance,
		OpCode.OpImageSampleFootprintNV => OpImageSampleFootprintNV.Instance,
		OpCode.OpTypeVectorIdEXT => OpTypeVectorIdEXT.Instance,
		OpCode.OpCooperativeVectorMatrixMulNV => OpCooperativeVectorMatrixMulNV.Instance,
		OpCode.OpCooperativeVectorOuterProductAccumulateNV => OpCooperativeVectorOuterProductAccumulateNV.Instance,
		OpCode.OpCooperativeVectorReduceSumAccumulateNV => OpCooperativeVectorReduceSumAccumulateNV.Instance,
		OpCode.OpCooperativeVectorMatrixMulAddNV => OpCooperativeVectorMatrixMulAddNV.Instance,
		OpCode.OpCooperativeMatrixConvertNV => OpCooperativeMatrixConvertNV.Instance,
		OpCode.OpEmitMeshTasksEXT => OpEmitMeshTasksEXT.Instance,
		OpCode.OpSetMeshOutputsEXT => OpSetMeshOutputsEXT.Instance,
		OpCode.OpGroupNonUniformPartitionEXT => OpGroupNonUniformPartitionEXT.Instance,
		OpCode.OpWritePackedPrimitiveIndices4x8NV => OpWritePackedPrimitiveIndices4x8NV.Instance,
		OpCode.OpFetchMicroTriangleVertexPositionNV => OpFetchMicroTriangleVertexPositionNV.Instance,
		OpCode.OpFetchMicroTriangleVertexBarycentricNV => OpFetchMicroTriangleVertexBarycentricNV.Instance,
		OpCode.OpCooperativeVectorLoadNV => OpCooperativeVectorLoadNV.Instance,
		OpCode.OpCooperativeVectorStoreNV => OpCooperativeVectorStoreNV.Instance,
		OpCode.OpHitObjectRecordFromQueryEXT => OpHitObjectRecordFromQueryEXT.Instance,
		OpCode.OpHitObjectRecordMissEXT => OpHitObjectRecordMissEXT.Instance,
		OpCode.OpHitObjectRecordMissMotionEXT => OpHitObjectRecordMissMotionEXT.Instance,
		OpCode.OpHitObjectGetIntersectionTriangleVertexPositionsEXT => OpHitObjectGetIntersectionTriangleVertexPositionsEXT.Instance,
		OpCode.OpHitObjectGetRayFlagsEXT => OpHitObjectGetRayFlagsEXT.Instance,
		OpCode.OpHitObjectSetShaderBindingTableRecordIndexEXT => OpHitObjectSetShaderBindingTableRecordIndexEXT.Instance,
		OpCode.OpHitObjectReorderExecuteShaderEXT => OpHitObjectReorderExecuteShaderEXT.Instance,
		OpCode.OpHitObjectTraceReorderExecuteEXT => OpHitObjectTraceReorderExecuteEXT.Instance,
		OpCode.OpHitObjectTraceMotionReorderExecuteEXT => OpHitObjectTraceMotionReorderExecuteEXT.Instance,
		OpCode.OpTypeHitObjectEXT => OpTypeHitObjectEXT.Instance,
		OpCode.OpReorderThreadWithHintEXT => OpReorderThreadWithHintEXT.Instance,
		OpCode.OpReorderThreadWithHitObjectEXT => OpReorderThreadWithHitObjectEXT.Instance,
		OpCode.OpHitObjectTraceRayEXT => OpHitObjectTraceRayEXT.Instance,
		OpCode.OpHitObjectTraceRayMotionEXT => OpHitObjectTraceRayMotionEXT.Instance,
		OpCode.OpHitObjectRecordEmptyEXT => OpHitObjectRecordEmptyEXT.Instance,
		OpCode.OpHitObjectExecuteShaderEXT => OpHitObjectExecuteShaderEXT.Instance,
		OpCode.OpHitObjectGetCurrentTimeEXT => OpHitObjectGetCurrentTimeEXT.Instance,
		OpCode.OpHitObjectGetAttributesEXT => OpHitObjectGetAttributesEXT.Instance,
		OpCode.OpHitObjectGetHitKindEXT => OpHitObjectGetHitKindEXT.Instance,
		OpCode.OpHitObjectGetPrimitiveIndexEXT => OpHitObjectGetPrimitiveIndexEXT.Instance,
		OpCode.OpHitObjectGetGeometryIndexEXT => OpHitObjectGetGeometryIndexEXT.Instance,
		OpCode.OpHitObjectGetInstanceIdEXT => OpHitObjectGetInstanceIdEXT.Instance,
		OpCode.OpHitObjectGetInstanceCustomIndexEXT => OpHitObjectGetInstanceCustomIndexEXT.Instance,
		OpCode.OpHitObjectGetObjectRayOriginEXT => OpHitObjectGetObjectRayOriginEXT.Instance,
		OpCode.OpHitObjectGetObjectRayDirectionEXT => OpHitObjectGetObjectRayDirectionEXT.Instance,
		OpCode.OpHitObjectGetWorldRayDirectionEXT => OpHitObjectGetWorldRayDirectionEXT.Instance,
		OpCode.OpHitObjectGetWorldRayOriginEXT => OpHitObjectGetWorldRayOriginEXT.Instance,
		OpCode.OpHitObjectGetObjectToWorldEXT => OpHitObjectGetObjectToWorldEXT.Instance,
		OpCode.OpHitObjectGetWorldToObjectEXT => OpHitObjectGetWorldToObjectEXT.Instance,
		OpCode.OpHitObjectGetRayTMaxEXT => OpHitObjectGetRayTMaxEXT.Instance,
		OpCode.OpReportIntersectionKHR => OpReportIntersectionKHR.Instance,
		OpCode.OpIgnoreIntersectionNV => OpIgnoreIntersectionNV.Instance,
		OpCode.OpTerminateRayNV => OpTerminateRayNV.Instance,
		OpCode.OpTraceNV => OpTraceNV.Instance,
		OpCode.OpTraceMotionNV => OpTraceMotionNV.Instance,
		OpCode.OpTraceRayMotionNV => OpTraceRayMotionNV.Instance,
		OpCode.OpRayQueryGetIntersectionTriangleVertexPositionsKHR => OpRayQueryGetIntersectionTriangleVertexPositionsKHR.Instance,
		OpCode.OpTypeAccelerationStructureKHR => OpTypeAccelerationStructureKHR.Instance,
		OpCode.OpExecuteCallableNV => OpExecuteCallableNV.Instance,
		OpCode.OpRayQueryGetIntersectionClusterIdNV => OpRayQueryGetIntersectionClusterIdNV.Instance,
		OpCode.OpHitObjectGetClusterIdNV => OpHitObjectGetClusterIdNV.Instance,
		OpCode.OpHitObjectGetRayTMinEXT => OpHitObjectGetRayTMinEXT.Instance,
		OpCode.OpHitObjectGetShaderBindingTableRecordIndexEXT => OpHitObjectGetShaderBindingTableRecordIndexEXT.Instance,
		OpCode.OpHitObjectGetShaderRecordBufferHandleEXT => OpHitObjectGetShaderRecordBufferHandleEXT.Instance,
		OpCode.OpHitObjectIsEmptyEXT => OpHitObjectIsEmptyEXT.Instance,
		OpCode.OpHitObjectIsHitEXT => OpHitObjectIsHitEXT.Instance,
		OpCode.OpHitObjectIsMissEXT => OpHitObjectIsMissEXT.Instance,
		OpCode.OpTypeCooperativeMatrixNV => OpTypeCooperativeMatrixNV.Instance,
		OpCode.OpCooperativeMatrixLoadNV => OpCooperativeMatrixLoadNV.Instance,
		OpCode.OpCooperativeMatrixStoreNV => OpCooperativeMatrixStoreNV.Instance,
		OpCode.OpCooperativeMatrixMulAddNV => OpCooperativeMatrixMulAddNV.Instance,
		OpCode.OpCooperativeMatrixLengthNV => OpCooperativeMatrixLengthNV.Instance,
		OpCode.OpBeginInvocationInterlockEXT => OpBeginInvocationInterlockEXT.Instance,
		OpCode.OpEndInvocationInterlockEXT => OpEndInvocationInterlockEXT.Instance,
		OpCode.OpCooperativeMatrixReduceNV => OpCooperativeMatrixReduceNV.Instance,
		OpCode.OpCooperativeMatrixLoadTensorNV => OpCooperativeMatrixLoadTensorNV.Instance,
		OpCode.OpCooperativeMatrixStoreTensorNV => OpCooperativeMatrixStoreTensorNV.Instance,
		OpCode.OpCooperativeMatrixPerElementOpNV => OpCooperativeMatrixPerElementOpNV.Instance,
		OpCode.OpTypeTensorLayoutNV => OpTypeTensorLayoutNV.Instance,
		OpCode.OpTypeTensorViewNV => OpTypeTensorViewNV.Instance,
		OpCode.OpCreateTensorLayoutNV => OpCreateTensorLayoutNV.Instance,
		OpCode.OpTensorLayoutSetDimensionNV => OpTensorLayoutSetDimensionNV.Instance,
		OpCode.OpTensorLayoutSetStrideNV => OpTensorLayoutSetStrideNV.Instance,
		OpCode.OpTensorLayoutSliceNV => OpTensorLayoutSliceNV.Instance,
		OpCode.OpTensorLayoutSetClampValueNV => OpTensorLayoutSetClampValueNV.Instance,
		OpCode.OpCreateTensorViewNV => OpCreateTensorViewNV.Instance,
		OpCode.OpTensorViewSetDimensionNV => OpTensorViewSetDimensionNV.Instance,
		OpCode.OpTensorViewSetStrideNV => OpTensorViewSetStrideNV.Instance,
		OpCode.OpDemoteToHelperInvocation => OpDemoteToHelperInvocation.Instance,
		OpCode.OpIsHelperInvocationEXT => OpIsHelperInvocationEXT.Instance,
		OpCode.OpTensorViewSetClipNV => OpTensorViewSetClipNV.Instance,
		OpCode.OpTensorLayoutSetBlockSizeNV => OpTensorLayoutSetBlockSizeNV.Instance,
		OpCode.OpCooperativeMatrixTransposeNV => OpCooperativeMatrixTransposeNV.Instance,
		OpCode.OpConvertUToImageNV => OpConvertUToImageNV.Instance,
		OpCode.OpConvertUToSamplerNV => OpConvertUToSamplerNV.Instance,
		OpCode.OpConvertImageToUNV => OpConvertImageToUNV.Instance,
		OpCode.OpConvertSamplerToUNV => OpConvertSamplerToUNV.Instance,
		OpCode.OpConvertUToSampledImageNV => OpConvertUToSampledImageNV.Instance,
		OpCode.OpConvertSampledImageToUNV => OpConvertSampledImageToUNV.Instance,
		OpCode.OpSamplerImageAddressingModeNV => OpSamplerImageAddressingModeNV.Instance,
		OpCode.OpRawAccessChainNV => OpRawAccessChainNV.Instance,
		OpCode.OpRayQueryGetIntersectionSpherePositionNV => OpRayQueryGetIntersectionSpherePositionNV.Instance,
		OpCode.OpRayQueryGetIntersectionSphereRadiusNV => OpRayQueryGetIntersectionSphereRadiusNV.Instance,
		OpCode.OpRayQueryGetIntersectionLSSPositionsNV => OpRayQueryGetIntersectionLSSPositionsNV.Instance,
		OpCode.OpRayQueryGetIntersectionLSSRadiiNV => OpRayQueryGetIntersectionLSSRadiiNV.Instance,
		OpCode.OpRayQueryGetIntersectionLSSHitValueNV => OpRayQueryGetIntersectionLSSHitValueNV.Instance,
		OpCode.OpHitObjectGetSpherePositionNV => OpHitObjectGetSpherePositionNV.Instance,
		OpCode.OpHitObjectGetSphereRadiusNV => OpHitObjectGetSphereRadiusNV.Instance,
		OpCode.OpHitObjectGetLSSPositionsNV => OpHitObjectGetLSSPositionsNV.Instance,
		OpCode.OpHitObjectGetLSSRadiiNV => OpHitObjectGetLSSRadiiNV.Instance,
		OpCode.OpHitObjectIsSphereHitNV => OpHitObjectIsSphereHitNV.Instance,
		OpCode.OpHitObjectIsLSSHitNV => OpHitObjectIsLSSHitNV.Instance,
		OpCode.OpRayQueryIsSphereHitNV => OpRayQueryIsSphereHitNV.Instance,
		OpCode.OpRayQueryIsLSSHitNV => OpRayQueryIsLSSHitNV.Instance,
		OpCode.OpSubgroupShuffleINTEL => OpSubgroupShuffleINTEL.Instance,
		OpCode.OpSubgroupShuffleDownINTEL => OpSubgroupShuffleDownINTEL.Instance,
		OpCode.OpSubgroupShuffleUpINTEL => OpSubgroupShuffleUpINTEL.Instance,
		OpCode.OpSubgroupShuffleXorINTEL => OpSubgroupShuffleXorINTEL.Instance,
		OpCode.OpSubgroupBlockReadINTEL => OpSubgroupBlockReadINTEL.Instance,
		OpCode.OpSubgroupBlockWriteINTEL => OpSubgroupBlockWriteINTEL.Instance,
		OpCode.OpSubgroupImageBlockReadINTEL => OpSubgroupImageBlockReadINTEL.Instance,
		OpCode.OpSubgroupImageBlockWriteINTEL => OpSubgroupImageBlockWriteINTEL.Instance,
		OpCode.OpSubgroupImageMediaBlockReadINTEL => OpSubgroupImageMediaBlockReadINTEL.Instance,
		OpCode.OpSubgroupImageMediaBlockWriteINTEL => OpSubgroupImageMediaBlockWriteINTEL.Instance,
		OpCode.OpUCountLeadingZerosINTEL => OpUCountLeadingZerosINTEL.Instance,
		OpCode.OpUCountTrailingZerosINTEL => OpUCountTrailingZerosINTEL.Instance,
		OpCode.OpAbsISubINTEL => OpAbsISubINTEL.Instance,
		OpCode.OpAbsUSubINTEL => OpAbsUSubINTEL.Instance,
		OpCode.OpIAddSatINTEL => OpIAddSatINTEL.Instance,
		OpCode.OpUAddSatINTEL => OpUAddSatINTEL.Instance,
		OpCode.OpIAverageINTEL => OpIAverageINTEL.Instance,
		OpCode.OpUAverageINTEL => OpUAverageINTEL.Instance,
		OpCode.OpIAverageRoundedINTEL => OpIAverageRoundedINTEL.Instance,
		OpCode.OpUAverageRoundedINTEL => OpUAverageRoundedINTEL.Instance,
		OpCode.OpISubSatINTEL => OpISubSatINTEL.Instance,
		OpCode.OpUSubSatINTEL => OpUSubSatINTEL.Instance,
		OpCode.OpIMul32x16INTEL => OpIMul32x16INTEL.Instance,
		OpCode.OpUMul32x16INTEL => OpUMul32x16INTEL.Instance,
		OpCode.OpConstantFunctionPointerINTEL => OpConstantFunctionPointerINTEL.Instance,
		OpCode.OpFunctionPointerCallINTEL => OpFunctionPointerCallINTEL.Instance,
		OpCode.OpAsmTargetINTEL => OpAsmTargetINTEL.Instance,
		OpCode.OpAsmINTEL => OpAsmINTEL.Instance,
		OpCode.OpAsmCallINTEL => OpAsmCallINTEL.Instance,
		OpCode.OpAtomicFMinEXT => OpAtomicFMinEXT.Instance,
		OpCode.OpAtomicFMaxEXT => OpAtomicFMaxEXT.Instance,
		OpCode.OpAssumeTrueKHR => OpAssumeTrueKHR.Instance,
		OpCode.OpExpectKHR => OpExpectKHR.Instance,
		OpCode.OpDecorateString => OpDecorateString.Instance,
		OpCode.OpMemberDecorateString => OpMemberDecorateString.Instance,
		OpCode.OpVmeImageINTEL => OpVmeImageINTEL.Instance,
		OpCode.OpTypeVmeImageINTEL => OpTypeVmeImageINTEL.Instance,
		OpCode.OpTypeAvcImePayloadINTEL => OpTypeAvcImePayloadINTEL.Instance,
		OpCode.OpTypeAvcRefPayloadINTEL => OpTypeAvcRefPayloadINTEL.Instance,
		OpCode.OpTypeAvcSicPayloadINTEL => OpTypeAvcSicPayloadINTEL.Instance,
		OpCode.OpTypeAvcMcePayloadINTEL => OpTypeAvcMcePayloadINTEL.Instance,
		OpCode.OpTypeAvcMceResultINTEL => OpTypeAvcMceResultINTEL.Instance,
		OpCode.OpTypeAvcImeResultINTEL => OpTypeAvcImeResultINTEL.Instance,
		OpCode.OpTypeAvcImeResultSingleReferenceStreamoutINTEL => OpTypeAvcImeResultSingleReferenceStreamoutINTEL.Instance,
		OpCode.OpTypeAvcImeResultDualReferenceStreamoutINTEL => OpTypeAvcImeResultDualReferenceStreamoutINTEL.Instance,
		OpCode.OpTypeAvcImeSingleReferenceStreaminINTEL => OpTypeAvcImeSingleReferenceStreaminINTEL.Instance,
		OpCode.OpTypeAvcImeDualReferenceStreaminINTEL => OpTypeAvcImeDualReferenceStreaminINTEL.Instance,
		OpCode.OpTypeAvcRefResultINTEL => OpTypeAvcRefResultINTEL.Instance,
		OpCode.OpTypeAvcSicResultINTEL => OpTypeAvcSicResultINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL => OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL => OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL => OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetInterShapePenaltyINTEL => OpSubgroupAvcMceSetInterShapePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL => OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL => OpSubgroupAvcMceSetInterDirectionPenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL => OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL => OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL => OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL => OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL => OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL => OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL => OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL => OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL => OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetAcOnlyHaarINTEL => OpSubgroupAvcMceSetAcOnlyHaarINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL => OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL => OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL.Instance,
		OpCode.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL => OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToImePayloadINTEL => OpSubgroupAvcMceConvertToImePayloadINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToImeResultINTEL => OpSubgroupAvcMceConvertToImeResultINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToRefPayloadINTEL => OpSubgroupAvcMceConvertToRefPayloadINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToRefResultINTEL => OpSubgroupAvcMceConvertToRefResultINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToSicPayloadINTEL => OpSubgroupAvcMceConvertToSicPayloadINTEL.Instance,
		OpCode.OpSubgroupAvcMceConvertToSicResultINTEL => OpSubgroupAvcMceConvertToSicResultINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetMotionVectorsINTEL => OpSubgroupAvcMceGetMotionVectorsINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterDistortionsINTEL => OpSubgroupAvcMceGetInterDistortionsINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetBestInterDistortionsINTEL => OpSubgroupAvcMceGetBestInterDistortionsINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterMajorShapeINTEL => OpSubgroupAvcMceGetInterMajorShapeINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterMinorShapeINTEL => OpSubgroupAvcMceGetInterMinorShapeINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterDirectionsINTEL => OpSubgroupAvcMceGetInterDirectionsINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterMotionVectorCountINTEL => OpSubgroupAvcMceGetInterMotionVectorCountINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterReferenceIdsINTEL => OpSubgroupAvcMceGetInterReferenceIdsINTEL.Instance,
		OpCode.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL => OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL.Instance,
		OpCode.OpSubgroupAvcImeInitializeINTEL => OpSubgroupAvcImeInitializeINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetSingleReferenceINTEL => OpSubgroupAvcImeSetSingleReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetDualReferenceINTEL => OpSubgroupAvcImeSetDualReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcImeRefWindowSizeINTEL => OpSubgroupAvcImeRefWindowSizeINTEL.Instance,
		OpCode.OpSubgroupAvcImeAdjustRefOffsetINTEL => OpSubgroupAvcImeAdjustRefOffsetINTEL.Instance,
		OpCode.OpSubgroupAvcImeConvertToMcePayloadINTEL => OpSubgroupAvcImeConvertToMcePayloadINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL => OpSubgroupAvcImeSetMaxMotionVectorCountINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL => OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL => OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL.Instance,
		OpCode.OpSubgroupAvcImeSetWeightedSadINTEL => OpSubgroupAvcImeSetWeightedSadINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL => OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL => OpSubgroupAvcImeEvaluateWithDualReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL => OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL => OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL => OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL => OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL => OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL => OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeConvertToMceResultINTEL => OpSubgroupAvcImeConvertToMceResultINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL => OpSubgroupAvcImeGetSingleReferenceStreaminINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetDualReferenceStreaminINTEL => OpSubgroupAvcImeGetDualReferenceStreaminINTEL.Instance,
		OpCode.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL => OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL => OpSubgroupAvcImeStripDualReferenceStreamoutINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL => OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL => OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL => OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL => OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL => OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL => OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetBorderReachedINTEL => OpSubgroupAvcImeGetBorderReachedINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL => OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL => OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL => OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL.Instance,
		OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL => OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL.Instance,
		OpCode.OpSubgroupAvcFmeInitializeINTEL => OpSubgroupAvcFmeInitializeINTEL.Instance,
		OpCode.OpSubgroupAvcBmeInitializeINTEL => OpSubgroupAvcBmeInitializeINTEL.Instance,
		OpCode.OpSubgroupAvcRefConvertToMcePayloadINTEL => OpSubgroupAvcRefConvertToMcePayloadINTEL.Instance,
		OpCode.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL => OpSubgroupAvcRefSetBidirectionalMixDisableINTEL.Instance,
		OpCode.OpSubgroupAvcRefSetBilinearFilterEnableINTEL => OpSubgroupAvcRefSetBilinearFilterEnableINTEL.Instance,
		OpCode.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL => OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL => OpSubgroupAvcRefEvaluateWithDualReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL => OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL => OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL.Instance,
		OpCode.OpSubgroupAvcRefConvertToMceResultINTEL => OpSubgroupAvcRefConvertToMceResultINTEL.Instance,
		OpCode.OpSubgroupAvcSicInitializeINTEL => OpSubgroupAvcSicInitializeINTEL.Instance,
		OpCode.OpSubgroupAvcSicConfigureSkcINTEL => OpSubgroupAvcSicConfigureSkcINTEL.Instance,
		OpCode.OpSubgroupAvcSicConfigureIpeLumaINTEL => OpSubgroupAvcSicConfigureIpeLumaINTEL.Instance,
		OpCode.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL => OpSubgroupAvcSicConfigureIpeLumaChromaINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetMotionVectorMaskINTEL => OpSubgroupAvcSicGetMotionVectorMaskINTEL.Instance,
		OpCode.OpSubgroupAvcSicConvertToMcePayloadINTEL => OpSubgroupAvcSicConvertToMcePayloadINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL => OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL => OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL => OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetBilinearFilterEnableINTEL => OpSubgroupAvcSicSetBilinearFilterEnableINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL => OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL.Instance,
		OpCode.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL => OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL.Instance,
		OpCode.OpSubgroupAvcSicEvaluateIpeINTEL => OpSubgroupAvcSicEvaluateIpeINTEL.Instance,
		OpCode.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL => OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL => OpSubgroupAvcSicEvaluateWithDualReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL => OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL.Instance,
		OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL => OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL.Instance,
		OpCode.OpSubgroupAvcSicConvertToMceResultINTEL => OpSubgroupAvcSicConvertToMceResultINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetIpeLumaShapeINTEL => OpSubgroupAvcSicGetIpeLumaShapeINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL => OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL => OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL => OpSubgroupAvcSicGetPackedIpeLumaModesINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetIpeChromaModeINTEL => OpSubgroupAvcSicGetIpeChromaModeINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL => OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL => OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL.Instance,
		OpCode.OpSubgroupAvcSicGetInterRawSadsINTEL => OpSubgroupAvcSicGetInterRawSadsINTEL.Instance,
		OpCode.OpVariableLengthArrayINTEL => OpVariableLengthArrayINTEL.Instance,
		OpCode.OpSaveMemoryINTEL => OpSaveMemoryINTEL.Instance,
		OpCode.OpRestoreMemoryINTEL => OpRestoreMemoryINTEL.Instance,
		OpCode.OpArbitraryFloatSinCosPiALTERA => OpArbitraryFloatSinCosPiALTERA.Instance,
		OpCode.OpArbitraryFloatCastALTERA => OpArbitraryFloatCastALTERA.Instance,
		OpCode.OpArbitraryFloatCastFromIntALTERA => OpArbitraryFloatCastFromIntALTERA.Instance,
		OpCode.OpArbitraryFloatCastToIntALTERA => OpArbitraryFloatCastToIntALTERA.Instance,
		OpCode.OpArbitraryFloatAddALTERA => OpArbitraryFloatAddALTERA.Instance,
		OpCode.OpArbitraryFloatSubALTERA => OpArbitraryFloatSubALTERA.Instance,
		OpCode.OpArbitraryFloatMulALTERA => OpArbitraryFloatMulALTERA.Instance,
		OpCode.OpArbitraryFloatDivALTERA => OpArbitraryFloatDivALTERA.Instance,
		OpCode.OpArbitraryFloatGTALTERA => OpArbitraryFloatGTALTERA.Instance,
		OpCode.OpArbitraryFloatGEALTERA => OpArbitraryFloatGEALTERA.Instance,
		OpCode.OpArbitraryFloatLTALTERA => OpArbitraryFloatLTALTERA.Instance,
		OpCode.OpArbitraryFloatLEALTERA => OpArbitraryFloatLEALTERA.Instance,
		OpCode.OpArbitraryFloatEQALTERA => OpArbitraryFloatEQALTERA.Instance,
		OpCode.OpArbitraryFloatRecipALTERA => OpArbitraryFloatRecipALTERA.Instance,
		OpCode.OpArbitraryFloatRSqrtALTERA => OpArbitraryFloatRSqrtALTERA.Instance,
		OpCode.OpArbitraryFloatCbrtALTERA => OpArbitraryFloatCbrtALTERA.Instance,
		OpCode.OpArbitraryFloatHypotALTERA => OpArbitraryFloatHypotALTERA.Instance,
		OpCode.OpArbitraryFloatSqrtALTERA => OpArbitraryFloatSqrtALTERA.Instance,
		OpCode.OpArbitraryFloatLogINTEL => OpArbitraryFloatLogINTEL.Instance,
		OpCode.OpArbitraryFloatLog2INTEL => OpArbitraryFloatLog2INTEL.Instance,
		OpCode.OpArbitraryFloatLog10INTEL => OpArbitraryFloatLog10INTEL.Instance,
		OpCode.OpArbitraryFloatLog1pINTEL => OpArbitraryFloatLog1pINTEL.Instance,
		OpCode.OpArbitraryFloatExpINTEL => OpArbitraryFloatExpINTEL.Instance,
		OpCode.OpArbitraryFloatExp2INTEL => OpArbitraryFloatExp2INTEL.Instance,
		OpCode.OpArbitraryFloatExp10INTEL => OpArbitraryFloatExp10INTEL.Instance,
		OpCode.OpArbitraryFloatExpm1INTEL => OpArbitraryFloatExpm1INTEL.Instance,
		OpCode.OpArbitraryFloatSinINTEL => OpArbitraryFloatSinINTEL.Instance,
		OpCode.OpArbitraryFloatCosINTEL => OpArbitraryFloatCosINTEL.Instance,
		OpCode.OpArbitraryFloatSinCosINTEL => OpArbitraryFloatSinCosINTEL.Instance,
		OpCode.OpArbitraryFloatSinPiINTEL => OpArbitraryFloatSinPiINTEL.Instance,
		OpCode.OpArbitraryFloatCosPiINTEL => OpArbitraryFloatCosPiINTEL.Instance,
		OpCode.OpArbitraryFloatASinINTEL => OpArbitraryFloatASinINTEL.Instance,
		OpCode.OpArbitraryFloatASinPiINTEL => OpArbitraryFloatASinPiINTEL.Instance,
		OpCode.OpArbitraryFloatACosINTEL => OpArbitraryFloatACosINTEL.Instance,
		OpCode.OpArbitraryFloatACosPiINTEL => OpArbitraryFloatACosPiINTEL.Instance,
		OpCode.OpArbitraryFloatATanINTEL => OpArbitraryFloatATanINTEL.Instance,
		OpCode.OpArbitraryFloatATanPiINTEL => OpArbitraryFloatATanPiINTEL.Instance,
		OpCode.OpArbitraryFloatATan2INTEL => OpArbitraryFloatATan2INTEL.Instance,
		OpCode.OpArbitraryFloatPowINTEL => OpArbitraryFloatPowINTEL.Instance,
		OpCode.OpArbitraryFloatPowRINTEL => OpArbitraryFloatPowRINTEL.Instance,
		OpCode.OpArbitraryFloatPowNINTEL => OpArbitraryFloatPowNINTEL.Instance,
		OpCode.OpLoopControlINTEL => OpLoopControlINTEL.Instance,
		OpCode.OpAliasDomainDeclINTEL => OpAliasDomainDeclINTEL.Instance,
		OpCode.OpAliasScopeDeclINTEL => OpAliasScopeDeclINTEL.Instance,
		OpCode.OpAliasScopeListDeclINTEL => OpAliasScopeListDeclINTEL.Instance,
		OpCode.OpFixedSqrtALTERA => OpFixedSqrtALTERA.Instance,
		OpCode.OpFixedRecipALTERA => OpFixedRecipALTERA.Instance,
		OpCode.OpFixedRsqrtALTERA => OpFixedRsqrtALTERA.Instance,
		OpCode.OpFixedSinALTERA => OpFixedSinALTERA.Instance,
		OpCode.OpFixedCosALTERA => OpFixedCosALTERA.Instance,
		OpCode.OpFixedSinCosALTERA => OpFixedSinCosALTERA.Instance,
		OpCode.OpFixedSinPiALTERA => OpFixedSinPiALTERA.Instance,
		OpCode.OpFixedCosPiALTERA => OpFixedCosPiALTERA.Instance,
		OpCode.OpFixedSinCosPiALTERA => OpFixedSinCosPiALTERA.Instance,
		OpCode.OpFixedLogALTERA => OpFixedLogALTERA.Instance,
		OpCode.OpFixedExpALTERA => OpFixedExpALTERA.Instance,
		OpCode.OpPtrCastToCrossWorkgroupALTERA => OpPtrCastToCrossWorkgroupALTERA.Instance,
		OpCode.OpCrossWorkgroupCastToPtrALTERA => OpCrossWorkgroupCastToPtrALTERA.Instance,
		OpCode.OpReadPipeBlockingALTERA => OpReadPipeBlockingALTERA.Instance,
		OpCode.OpWritePipeBlockingALTERA => OpWritePipeBlockingALTERA.Instance,
		OpCode.OpFPGARegALTERA => OpFPGARegALTERA.Instance,
		OpCode.OpRayQueryGetRayTMinKHR => OpRayQueryGetRayTMinKHR.Instance,
		OpCode.OpRayQueryGetRayFlagsKHR => OpRayQueryGetRayFlagsKHR.Instance,
		OpCode.OpRayQueryGetIntersectionTKHR => OpRayQueryGetIntersectionTKHR.Instance,
		OpCode.OpRayQueryGetIntersectionInstanceCustomIndexKHR => OpRayQueryGetIntersectionInstanceCustomIndexKHR.Instance,
		OpCode.OpRayQueryGetIntersectionInstanceIdKHR => OpRayQueryGetIntersectionInstanceIdKHR.Instance,
		OpCode.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR => OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR.Instance,
		OpCode.OpRayQueryGetIntersectionGeometryIndexKHR => OpRayQueryGetIntersectionGeometryIndexKHR.Instance,
		OpCode.OpRayQueryGetIntersectionPrimitiveIndexKHR => OpRayQueryGetIntersectionPrimitiveIndexKHR.Instance,
		OpCode.OpRayQueryGetIntersectionBarycentricsKHR => OpRayQueryGetIntersectionBarycentricsKHR.Instance,
		OpCode.OpRayQueryGetIntersectionFrontFaceKHR => OpRayQueryGetIntersectionFrontFaceKHR.Instance,
		OpCode.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR => OpRayQueryGetIntersectionCandidateAABBOpaqueKHR.Instance,
		OpCode.OpRayQueryGetIntersectionObjectRayDirectionKHR => OpRayQueryGetIntersectionObjectRayDirectionKHR.Instance,
		OpCode.OpRayQueryGetIntersectionObjectRayOriginKHR => OpRayQueryGetIntersectionObjectRayOriginKHR.Instance,
		OpCode.OpRayQueryGetWorldRayDirectionKHR => OpRayQueryGetWorldRayDirectionKHR.Instance,
		OpCode.OpRayQueryGetWorldRayOriginKHR => OpRayQueryGetWorldRayOriginKHR.Instance,
		OpCode.OpRayQueryGetIntersectionObjectToWorldKHR => OpRayQueryGetIntersectionObjectToWorldKHR.Instance,
		OpCode.OpRayQueryGetIntersectionWorldToObjectKHR => OpRayQueryGetIntersectionWorldToObjectKHR.Instance,
		OpCode.OpAtomicFAddEXT => OpAtomicFAddEXT.Instance,
		OpCode.OpTypeBufferSurfaceINTEL => OpTypeBufferSurfaceINTEL.Instance,
		OpCode.OpTypeStructContinuedINTEL => OpTypeStructContinuedINTEL.Instance,
		OpCode.OpConstantCompositeContinuedINTEL => OpConstantCompositeContinuedINTEL.Instance,
		OpCode.OpSpecConstantCompositeContinuedINTEL => OpSpecConstantCompositeContinuedINTEL.Instance,
		OpCode.OpCompositeConstructContinuedINTEL => OpCompositeConstructContinuedINTEL.Instance,
		OpCode.OpConvertFToBF16INTEL => OpConvertFToBF16INTEL.Instance,
		OpCode.OpConvertBF16ToFINTEL => OpConvertBF16ToFINTEL.Instance,
		OpCode.OpControlBarrierArriveINTEL => OpControlBarrierArriveINTEL.Instance,
		OpCode.OpControlBarrierWaitINTEL => OpControlBarrierWaitINTEL.Instance,
		OpCode.OpArithmeticFenceEXT => OpArithmeticFenceEXT.Instance,
		OpCode.OpTaskSequenceCreateALTERA => OpTaskSequenceCreateALTERA.Instance,
		OpCode.OpTaskSequenceAsyncALTERA => OpTaskSequenceAsyncALTERA.Instance,
		OpCode.OpTaskSequenceGetALTERA => OpTaskSequenceGetALTERA.Instance,
		OpCode.OpTaskSequenceReleaseALTERA => OpTaskSequenceReleaseALTERA.Instance,
		OpCode.OpTypeTaskSequenceALTERA => OpTypeTaskSequenceALTERA.Instance,
		OpCode.OpSubgroupBlockPrefetchINTEL => OpSubgroupBlockPrefetchINTEL.Instance,
		OpCode.OpSubgroup2DBlockLoadINTEL => OpSubgroup2DBlockLoadINTEL.Instance,
		OpCode.OpSubgroup2DBlockLoadTransformINTEL => OpSubgroup2DBlockLoadTransformINTEL.Instance,
		OpCode.OpSubgroup2DBlockLoadTransposeINTEL => OpSubgroup2DBlockLoadTransposeINTEL.Instance,
		OpCode.OpSubgroup2DBlockPrefetchINTEL => OpSubgroup2DBlockPrefetchINTEL.Instance,
		OpCode.OpSubgroup2DBlockStoreINTEL => OpSubgroup2DBlockStoreINTEL.Instance,
		OpCode.OpSubgroupMatrixMultiplyAccumulateINTEL => OpSubgroupMatrixMultiplyAccumulateINTEL.Instance,
		OpCode.OpBitwiseFunctionINTEL => OpBitwiseFunctionINTEL.Instance,
		OpCode.OpUntypedVariableLengthArrayINTEL => OpUntypedVariableLengthArrayINTEL.Instance,
		OpCode.OpConditionalExtensionINTEL => OpConditionalExtensionINTEL.Instance,
		OpCode.OpConditionalEntryPointINTEL => OpConditionalEntryPointINTEL.Instance,
		OpCode.OpConditionalCapabilityINTEL => OpConditionalCapabilityINTEL.Instance,
		OpCode.OpSpecConstantTargetINTEL => OpSpecConstantTargetINTEL.Instance,
		OpCode.OpSpecConstantArchitectureINTEL => OpSpecConstantArchitectureINTEL.Instance,
		OpCode.OpSpecConstantCapabilitiesINTEL => OpSpecConstantCapabilitiesINTEL.Instance,
		OpCode.OpConditionalCopyObjectINTEL => OpConditionalCopyObjectINTEL.Instance,
		OpCode.OpGroupIMulKHR => OpGroupIMulKHR.Instance,
		OpCode.OpGroupFMulKHR => OpGroupFMulKHR.Instance,
		OpCode.OpGroupBitwiseAndKHR => OpGroupBitwiseAndKHR.Instance,
		OpCode.OpGroupBitwiseOrKHR => OpGroupBitwiseOrKHR.Instance,
		OpCode.OpGroupBitwiseXorKHR => OpGroupBitwiseXorKHR.Instance,
		OpCode.OpGroupLogicalAndKHR => OpGroupLogicalAndKHR.Instance,
		OpCode.OpGroupLogicalOrKHR => OpGroupLogicalOrKHR.Instance,
		OpCode.OpGroupLogicalXorKHR => OpGroupLogicalXorKHR.Instance,
		OpCode.OpRoundFToTF32INTEL => OpRoundFToTF32INTEL.Instance,
		OpCode.OpMaskedGatherINTEL => OpMaskedGatherINTEL.Instance,
		OpCode.OpMaskedScatterINTEL => OpMaskedScatterINTEL.Instance,
		OpCode.OpConvertHandleToImageINTEL => OpConvertHandleToImageINTEL.Instance,
		OpCode.OpConvertHandleToSamplerINTEL => OpConvertHandleToSamplerINTEL.Instance,
		OpCode.OpConvertHandleToSampledImageINTEL => OpConvertHandleToSampledImageINTEL.Instance,
		OpCode.OpFDot2MixAcc32VALVE => OpFDot2MixAcc32VALVE.Instance,
		OpCode.OpFDot2MixAcc16VALVE => OpFDot2MixAcc16VALVE.Instance,
		OpCode.OpFDot4MixAcc32VALVE => OpFDot4MixAcc32VALVE.Instance,
		_ => throw new ArgumentOutOfRangeException(nameof(code), code, null),
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Set", OperandQuantifier.Default), new Operand(new LiteralExtInstInteger(), "Instruction", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1, Operand 2, ...", OperandQuantifier.Varying),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Width", OperandQuantifier.Default), new Operand(new EnumType<FPEncoding, FPEncodingParameterFactory>(), "Floating Point Encoding", OperandQuantifier.Optional),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Member 0 type, member 1 type, ...", OperandQuantifier.Varying),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Return Type", OperandQuantifier.Default), new Operand(new IdRef(), "Parameter 0 Type, Parameter 1 Type, ...", OperandQuantifier.Varying),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default), new Operand(new IdRef(), "Argument 0, Argument 1, ...", OperandQuantifier.Varying),];
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

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
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

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Size", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Equal", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Unequal", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Comparator", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
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

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
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
public sealed class OpGroupNonUniformElect : Instruction
{
	public static OpGroupNonUniformElect Instance { get; } = new();

	private OpGroupNonUniformElect()
	{
	}

	public override string Name => nameof(OpGroupNonUniformElect);
	public override OpCode Code => OpCode.OpGroupNonUniformElect;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformAll : Instruction
{
	public static OpGroupNonUniformAll Instance { get; } = new();

	private OpGroupNonUniformAll()
	{
	}

	public override string Name => nameof(OpGroupNonUniformAll);
	public override OpCode Code => OpCode.OpGroupNonUniformAll;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformAny : Instruction
{
	public static OpGroupNonUniformAny Instance { get; } = new();

	private OpGroupNonUniformAny()
	{
	}

	public override string Name => nameof(OpGroupNonUniformAny);
	public override OpCode Code => OpCode.OpGroupNonUniformAny;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformAllEqual : Instruction
{
	public static OpGroupNonUniformAllEqual Instance { get; } = new();

	private OpGroupNonUniformAllEqual()
	{
	}

	public override string Name => nameof(OpGroupNonUniformAllEqual);
	public override OpCode Code => OpCode.OpGroupNonUniformAllEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBroadcast : Instruction
{
	public static OpGroupNonUniformBroadcast Instance { get; } = new();

	private OpGroupNonUniformBroadcast()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBroadcast);
	public override OpCode Code => OpCode.OpGroupNonUniformBroadcast;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Invocation Id", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBroadcastFirst : Instruction
{
	public static OpGroupNonUniformBroadcastFirst Instance { get; } = new();

	private OpGroupNonUniformBroadcastFirst()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBroadcastFirst);
	public override OpCode Code => OpCode.OpGroupNonUniformBroadcastFirst;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBallot : Instruction
{
	public static OpGroupNonUniformBallot Instance { get; } = new();

	private OpGroupNonUniformBallot()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBallot);
	public override OpCode Code => OpCode.OpGroupNonUniformBallot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformInverseBallot : Instruction
{
	public static OpGroupNonUniformInverseBallot Instance { get; } = new();

	private OpGroupNonUniformInverseBallot()
	{
	}

	public override string Name => nameof(OpGroupNonUniformInverseBallot);
	public override OpCode Code => OpCode.OpGroupNonUniformInverseBallot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBallotBitExtract : Instruction
{
	public static OpGroupNonUniformBallotBitExtract Instance { get; } = new();

	private OpGroupNonUniformBallotBitExtract()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBallotBitExtract);
	public override OpCode Code => OpCode.OpGroupNonUniformBallotBitExtract;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBallotBitCount : Instruction
{
	public static OpGroupNonUniformBallotBitCount Instance { get; } = new();

	private OpGroupNonUniformBallotBitCount()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBallotBitCount);
	public override OpCode Code => OpCode.OpGroupNonUniformBallotBitCount;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBallotFindLSB : Instruction
{
	public static OpGroupNonUniformBallotFindLSB Instance { get; } = new();

	private OpGroupNonUniformBallotFindLSB()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBallotFindLSB);
	public override OpCode Code => OpCode.OpGroupNonUniformBallotFindLSB;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformBallotFindMSB : Instruction
{
	public static OpGroupNonUniformBallotFindMSB Instance { get; } = new();

	private OpGroupNonUniformBallotFindMSB()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBallotFindMSB);
	public override OpCode Code => OpCode.OpGroupNonUniformBallotFindMSB;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformShuffle : Instruction
{
	public static OpGroupNonUniformShuffle Instance { get; } = new();

	private OpGroupNonUniformShuffle()
	{
	}

	public override string Name => nameof(OpGroupNonUniformShuffle);
	public override OpCode Code => OpCode.OpGroupNonUniformShuffle;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Invocation Id", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformShuffleXor : Instruction
{
	public static OpGroupNonUniformShuffleXor Instance { get; } = new();

	private OpGroupNonUniformShuffleXor()
	{
	}

	public override string Name => nameof(OpGroupNonUniformShuffleXor);
	public override OpCode Code => OpCode.OpGroupNonUniformShuffleXor;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Mask", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformShuffleUp : Instruction
{
	public static OpGroupNonUniformShuffleUp Instance { get; } = new();

	private OpGroupNonUniformShuffleUp()
	{
	}

	public override string Name => nameof(OpGroupNonUniformShuffleUp);
	public override OpCode Code => OpCode.OpGroupNonUniformShuffleUp;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformShuffleDown : Instruction
{
	public static OpGroupNonUniformShuffleDown Instance { get; } = new();

	private OpGroupNonUniformShuffleDown()
	{
	}

	public override string Name => nameof(OpGroupNonUniformShuffleDown);
	public override OpCode Code => OpCode.OpGroupNonUniformShuffleDown;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformIAdd : Instruction
{
	public static OpGroupNonUniformIAdd Instance { get; } = new();

	private OpGroupNonUniformIAdd()
	{
	}

	public override string Name => nameof(OpGroupNonUniformIAdd);
	public override OpCode Code => OpCode.OpGroupNonUniformIAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformFAdd : Instruction
{
	public static OpGroupNonUniformFAdd Instance { get; } = new();

	private OpGroupNonUniformFAdd()
	{
	}

	public override string Name => nameof(OpGroupNonUniformFAdd);
	public override OpCode Code => OpCode.OpGroupNonUniformFAdd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformIMul : Instruction
{
	public static OpGroupNonUniformIMul Instance { get; } = new();

	private OpGroupNonUniformIMul()
	{
	}

	public override string Name => nameof(OpGroupNonUniformIMul);
	public override OpCode Code => OpCode.OpGroupNonUniformIMul;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformFMul : Instruction
{
	public static OpGroupNonUniformFMul Instance { get; } = new();

	private OpGroupNonUniformFMul()
	{
	}

	public override string Name => nameof(OpGroupNonUniformFMul);
	public override OpCode Code => OpCode.OpGroupNonUniformFMul;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformSMin : Instruction
{
	public static OpGroupNonUniformSMin Instance { get; } = new();

	private OpGroupNonUniformSMin()
	{
	}

	public override string Name => nameof(OpGroupNonUniformSMin);
	public override OpCode Code => OpCode.OpGroupNonUniformSMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformUMin : Instruction
{
	public static OpGroupNonUniformUMin Instance { get; } = new();

	private OpGroupNonUniformUMin()
	{
	}

	public override string Name => nameof(OpGroupNonUniformUMin);
	public override OpCode Code => OpCode.OpGroupNonUniformUMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformFMin : Instruction
{
	public static OpGroupNonUniformFMin Instance { get; } = new();

	private OpGroupNonUniformFMin()
	{
	}

	public override string Name => nameof(OpGroupNonUniformFMin);
	public override OpCode Code => OpCode.OpGroupNonUniformFMin;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformSMax : Instruction
{
	public static OpGroupNonUniformSMax Instance { get; } = new();

	private OpGroupNonUniformSMax()
	{
	}

	public override string Name => nameof(OpGroupNonUniformSMax);
	public override OpCode Code => OpCode.OpGroupNonUniformSMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformUMax : Instruction
{
	public static OpGroupNonUniformUMax Instance { get; } = new();

	private OpGroupNonUniformUMax()
	{
	}

	public override string Name => nameof(OpGroupNonUniformUMax);
	public override OpCode Code => OpCode.OpGroupNonUniformUMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformFMax : Instruction
{
	public static OpGroupNonUniformFMax Instance { get; } = new();

	private OpGroupNonUniformFMax()
	{
	}

	public override string Name => nameof(OpGroupNonUniformFMax);
	public override OpCode Code => OpCode.OpGroupNonUniformFMax;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformBitwiseAnd : Instruction
{
	public static OpGroupNonUniformBitwiseAnd Instance { get; } = new();

	private OpGroupNonUniformBitwiseAnd()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBitwiseAnd);
	public override OpCode Code => OpCode.OpGroupNonUniformBitwiseAnd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformBitwiseOr : Instruction
{
	public static OpGroupNonUniformBitwiseOr Instance { get; } = new();

	private OpGroupNonUniformBitwiseOr()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBitwiseOr);
	public override OpCode Code => OpCode.OpGroupNonUniformBitwiseOr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformBitwiseXor : Instruction
{
	public static OpGroupNonUniformBitwiseXor Instance { get; } = new();

	private OpGroupNonUniformBitwiseXor()
	{
	}

	public override string Name => nameof(OpGroupNonUniformBitwiseXor);
	public override OpCode Code => OpCode.OpGroupNonUniformBitwiseXor;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformLogicalAnd : Instruction
{
	public static OpGroupNonUniformLogicalAnd Instance { get; } = new();

	private OpGroupNonUniformLogicalAnd()
	{
	}

	public override string Name => nameof(OpGroupNonUniformLogicalAnd);
	public override OpCode Code => OpCode.OpGroupNonUniformLogicalAnd;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformLogicalOr : Instruction
{
	public static OpGroupNonUniformLogicalOr Instance { get; } = new();

	private OpGroupNonUniformLogicalOr()
	{
	}

	public override string Name => nameof(OpGroupNonUniformLogicalOr);
	public override OpCode Code => OpCode.OpGroupNonUniformLogicalOr;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformLogicalXor : Instruction
{
	public static OpGroupNonUniformLogicalXor Instance { get; } = new();

	private OpGroupNonUniformLogicalXor()
	{
	}

	public override string Name => nameof(OpGroupNonUniformLogicalXor);
	public override OpCode Code => OpCode.OpGroupNonUniformLogicalXor;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
}
public sealed class OpGroupNonUniformQuadBroadcast : Instruction
{
	public static OpGroupNonUniformQuadBroadcast Instance { get; } = new();

	private OpGroupNonUniformQuadBroadcast()
	{
	}

	public override string Name => nameof(OpGroupNonUniformQuadBroadcast);
	public override OpCode Code => OpCode.OpGroupNonUniformQuadBroadcast;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Index", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformQuadSwap : Instruction
{
	public static OpGroupNonUniformQuadSwap Instance { get; } = new();

	private OpGroupNonUniformQuadSwap()
	{
	}

	public override string Name => nameof(OpGroupNonUniformQuadSwap);
	public override OpCode Code => OpCode.OpGroupNonUniformQuadSwap;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default),];
}
public sealed class OpCopyLogical : Instruction
{
	public static OpCopyLogical Instance { get; } = new();

	private OpCopyLogical()
	{
	}

	public override string Name => nameof(OpCopyLogical);
	public override OpCode Code => OpCode.OpCopyLogical;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpPtrEqual : Instruction
{
	public static OpPtrEqual Instance { get; } = new();

	private OpPtrEqual()
	{
	}

	public override string Name => nameof(OpPtrEqual);
	public override OpCode Code => OpCode.OpPtrEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpPtrNotEqual : Instruction
{
	public static OpPtrNotEqual Instance { get; } = new();

	private OpPtrNotEqual()
	{
	}

	public override string Name => nameof(OpPtrNotEqual);
	public override OpCode Code => OpCode.OpPtrNotEqual;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpPtrDiff : Instruction
{
	public static OpPtrDiff Instance { get; } = new();

	private OpPtrDiff()
	{
	}

	public override string Name => nameof(OpPtrDiff);
	public override OpCode Code => OpCode.OpPtrDiff;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpColorAttachmentReadEXT : Instruction
{
	public static OpColorAttachmentReadEXT Instance { get; } = new();

	private OpColorAttachmentReadEXT()
	{
	}

	public override string Name => nameof(OpColorAttachmentReadEXT);
	public override OpCode Code => OpCode.OpColorAttachmentReadEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Attachment", OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Optional),];
}
public sealed class OpDepthAttachmentReadEXT : Instruction
{
	public static OpDepthAttachmentReadEXT Instance { get; } = new();

	private OpDepthAttachmentReadEXT()
	{
	}

	public override string Name => nameof(OpDepthAttachmentReadEXT);
	public override OpCode Code => OpCode.OpDepthAttachmentReadEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Optional),];
}
public sealed class OpStencilAttachmentReadEXT : Instruction
{
	public static OpStencilAttachmentReadEXT Instance { get; } = new();

	private OpStencilAttachmentReadEXT()
	{
	}

	public override string Name => nameof(OpStencilAttachmentReadEXT);
	public override OpCode Code => OpCode.OpStencilAttachmentReadEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Optional),];
}
public sealed class OpTypeTensorARM : Instruction
{
	public static OpTypeTensorARM Instance { get; } = new();

	private OpTypeTensorARM()
	{
	}

	public override string Name => nameof(OpTypeTensorARM);
	public override OpCode Code => OpCode.OpTypeTensorARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default), new Operand(new IdRef(), "Rank", OperandQuantifier.Optional), new Operand(new IdRef(), "Shape", OperandQuantifier.Optional),];
}
public sealed class OpTensorReadARM : Instruction
{
	public static OpTensorReadARM Instance { get; } = new();

	private OpTensorReadARM()
	{
	}

	public override string Name => nameof(OpTensorReadARM);
	public override OpCode Code => OpCode.OpTensorReadARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Tensor", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinates", OperandQuantifier.Default), new Operand(new EnumType<TensorOperands, TensorOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpTensorWriteARM : Instruction
{
	public static OpTensorWriteARM Instance { get; } = new();

	private OpTensorWriteARM()
	{
	}

	public override string Name => nameof(OpTensorWriteARM);
	public override OpCode Code => OpCode.OpTensorWriteARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Tensor", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new EnumType<TensorOperands, TensorOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpTensorQuerySizeARM : Instruction
{
	public static OpTensorQuerySizeARM Instance { get; } = new();

	private OpTensorQuerySizeARM()
	{
	}

	public override string Name => nameof(OpTensorQuerySizeARM);
	public override OpCode Code => OpCode.OpTensorQuerySizeARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Tensor", OperandQuantifier.Default), new Operand(new IdRef(), "Dimension", OperandQuantifier.Default),];
}
public sealed class OpGraphConstantARM : Instruction
{
	public static OpGraphConstantARM Instance { get; } = new();

	private OpGraphConstantARM()
	{
	}

	public override string Name => nameof(OpGraphConstantARM);
	public override OpCode Code => OpCode.OpGraphConstantARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "GraphConstantID", OperandQuantifier.Default),];
}
public sealed class OpGraphEntryPointARM : Instruction
{
	public static OpGraphEntryPointARM Instance { get; } = new();

	private OpGraphEntryPointARM()
	{
	}

	public override string Name => nameof(OpGraphEntryPointARM);
	public override OpCode Code => OpCode.OpGraphEntryPointARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Graph", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default), new Operand(new IdRef(), "Interface", OperandQuantifier.Varying),];
}
public sealed class OpGraphARM : Instruction
{
	public static OpGraphARM Instance { get; } = new();

	private OpGraphARM()
	{
	}

	public override string Name => nameof(OpGraphARM);
	public override OpCode Code => OpCode.OpGraphARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpGraphInputARM : Instruction
{
	public static OpGraphInputARM Instance { get; } = new();

	private OpGraphInputARM()
	{
	}

	public override string Name => nameof(OpGraphInputARM);
	public override OpCode Code => OpCode.OpGraphInputARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "InputIndex", OperandQuantifier.Default), new Operand(new IdRef(), "ElementIndex", OperandQuantifier.Varying),];
}
public sealed class OpGraphSetOutputARM : Instruction
{
	public static OpGraphSetOutputARM Instance { get; } = new();

	private OpGraphSetOutputARM()
	{
	}

	public override string Name => nameof(OpGraphSetOutputARM);
	public override OpCode Code => OpCode.OpGraphSetOutputARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "OutputIndex", OperandQuantifier.Default), new Operand(new IdRef(), "ElementIndex", OperandQuantifier.Varying),];
}
public sealed class OpGraphEndARM : Instruction
{
	public static OpGraphEndARM Instance { get; } = new();

	private OpGraphEndARM()
	{
	}

	public override string Name => nameof(OpGraphEndARM);
	public override OpCode Code => OpCode.OpGraphEndARM;
}
public sealed class OpTypeGraphARM : Instruction
{
	public static OpTypeGraphARM Instance { get; } = new();

	private OpTypeGraphARM()
	{
	}

	public override string Name => nameof(OpTypeGraphARM);
	public override OpCode Code => OpCode.OpTypeGraphARM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "NumInputs", OperandQuantifier.Default), new Operand(new IdRef(), "InOutTypes", OperandQuantifier.Varying),];
}
public sealed class OpTerminateInvocation : Instruction
{
	public static OpTerminateInvocation Instance { get; } = new();

	private OpTerminateInvocation()
	{
	}

	public override string Name => nameof(OpTerminateInvocation);
	public override OpCode Code => OpCode.OpTerminateInvocation;
}
public sealed class OpTypeUntypedPointerKHR : Instruction
{
	public static OpTypeUntypedPointerKHR Instance { get; } = new();

	private OpTypeUntypedPointerKHR()
	{
	}

	public override string Name => nameof(OpTypeUntypedPointerKHR);
	public override OpCode Code => OpCode.OpTypeUntypedPointerKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpUntypedVariableKHR : Instruction
{
	public static OpUntypedVariableKHR Instance { get; } = new();

	private OpUntypedVariableKHR()
	{
	}

	public override string Name => nameof(OpUntypedVariableKHR);
	public override OpCode Code => OpCode.OpUntypedVariableKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Data Type", OperandQuantifier.Optional), new Operand(new IdRef(), "Initializer", OperandQuantifier.Optional),];
}
public sealed class OpUntypedAccessChainKHR : Instruction
{
	public static OpUntypedAccessChainKHR Instance { get; } = new();

	private OpUntypedAccessChainKHR()
	{
	}

	public override string Name => nameof(OpUntypedAccessChainKHR);
	public override OpCode Code => OpCode.OpUntypedAccessChainKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base Type", OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpUntypedInBoundsAccessChainKHR : Instruction
{
	public static OpUntypedInBoundsAccessChainKHR Instance { get; } = new();

	private OpUntypedInBoundsAccessChainKHR()
	{
	}

	public override string Name => nameof(OpUntypedInBoundsAccessChainKHR);
	public override OpCode Code => OpCode.OpUntypedInBoundsAccessChainKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base Type", OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
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
public sealed class OpUntypedPtrAccessChainKHR : Instruction
{
	public static OpUntypedPtrAccessChainKHR Instance { get; } = new();

	private OpUntypedPtrAccessChainKHR()
	{
	}

	public override string Name => nameof(OpUntypedPtrAccessChainKHR);
	public override OpCode Code => OpCode.OpUntypedPtrAccessChainKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base Type", OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpUntypedInBoundsPtrAccessChainKHR : Instruction
{
	public static OpUntypedInBoundsPtrAccessChainKHR Instance { get; } = new();

	private OpUntypedInBoundsPtrAccessChainKHR()
	{
	}

	public override string Name => nameof(OpUntypedInBoundsPtrAccessChainKHR);
	public override OpCode Code => OpCode.OpUntypedInBoundsPtrAccessChainKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base Type", OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Element", OperandQuantifier.Default), new Operand(new IdRef(), "Indexes", OperandQuantifier.Varying),];
}
public sealed class OpUntypedArrayLengthKHR : Instruction
{
	public static OpUntypedArrayLengthKHR Instance { get; } = new();

	private OpUntypedArrayLengthKHR()
	{
	}

	public override string Name => nameof(OpUntypedArrayLengthKHR);
	public override OpCode Code => OpCode.OpUntypedArrayLengthKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Structure", OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Array member", OperandQuantifier.Default),];
}
public sealed class OpUntypedPrefetchKHR : Instruction
{
	public static OpUntypedPrefetchKHR Instance { get; } = new();

	private OpUntypedPrefetchKHR()
	{
	}

	public override string Name => nameof(OpUntypedPrefetchKHR);
	public override OpCode Code => OpCode.OpUntypedPrefetchKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer Type", OperandQuantifier.Default), new Operand(new IdRef(), "Num Bytes", OperandQuantifier.Default), new Operand(new IdRef(), "RW", OperandQuantifier.Optional), new Operand(new IdRef(), "Locality", OperandQuantifier.Optional), new Operand(new IdRef(), "Cache Type", OperandQuantifier.Optional),];
}
public sealed class OpFmaKHR : Instruction
{
	public static OpFmaKHR Instance { get; } = new();

	private OpFmaKHR()
	{
	}

	public override string Name => nameof(OpFmaKHR);
	public override OpCode Code => OpCode.OpFmaKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 3", OperandQuantifier.Default),];
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
public sealed class OpGroupNonUniformRotateKHR : Instruction
{
	public static OpGroupNonUniformRotateKHR Instance { get; } = new();

	private OpGroupNonUniformRotateKHR()
	{
	}

	public override string Name => nameof(OpGroupNonUniformRotateKHR);
	public override OpCode Code => OpCode.OpGroupNonUniformRotateKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "Delta", OperandQuantifier.Default), new Operand(new IdRef(), "ClusterSize", OperandQuantifier.Optional),];
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
public sealed class OpExtInstWithForwardRefsKHR : Instruction
{
	public static OpExtInstWithForwardRefsKHR Instance { get; } = new();

	private OpExtInstWithForwardRefsKHR()
	{
	}

	public override string Name => nameof(OpExtInstWithForwardRefsKHR);
	public override OpCode Code => OpCode.OpExtInstWithForwardRefsKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Set", OperandQuantifier.Default), new Operand(new LiteralExtInstInteger(), "Instruction", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1, Operand 2, ...", OperandQuantifier.Varying),];
}
public sealed class OpUntypedGroupAsyncCopyKHR : Instruction
{
	public static OpUntypedGroupAsyncCopyKHR Instance { get; } = new();

	private OpUntypedGroupAsyncCopyKHR()
	{
	}

	public override string Name => nameof(OpUntypedGroupAsyncCopyKHR);
	public override OpCode Code => OpCode.OpUntypedGroupAsyncCopyKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Destination", OperandQuantifier.Default), new Operand(new IdRef(), "Source", OperandQuantifier.Default), new Operand(new IdRef(), "Element Num Bytes", OperandQuantifier.Default), new Operand(new IdRef(), "Num Elements", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Event", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Destination Memory Operands", OperandQuantifier.Optional), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Source Memory Operands", OperandQuantifier.Optional),];
}
public sealed class OpTraceRayKHR : Instruction
{
	public static OpTraceRayKHR Instance { get; } = new();

	private OpTraceRayKHR()
	{
	}

	public override string Name => nameof(OpTraceRayKHR);
	public override OpCode Code => OpCode.OpTraceRayKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpExecuteCallableKHR : Instruction
{
	public static OpExecuteCallableKHR Instance { get; } = new();

	private OpExecuteCallableKHR()
	{
	}

	public override string Name => nameof(OpExecuteCallableKHR);
	public override OpCode Code => OpCode.OpExecuteCallableKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "SBT Index", OperandQuantifier.Default), new Operand(new IdRef(), "Callable Data", OperandQuantifier.Default),];
}
public sealed class OpConvertUToAccelerationStructureKHR : Instruction
{
	public static OpConvertUToAccelerationStructureKHR Instance { get; } = new();

	private OpConvertUToAccelerationStructureKHR()
	{
	}

	public override string Name => nameof(OpConvertUToAccelerationStructureKHR);
	public override OpCode Code => OpCode.OpConvertUToAccelerationStructureKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Accel", OperandQuantifier.Default),];
}
public sealed class OpIgnoreIntersectionKHR : Instruction
{
	public static OpIgnoreIntersectionKHR Instance { get; } = new();

	private OpIgnoreIntersectionKHR()
	{
	}

	public override string Name => nameof(OpIgnoreIntersectionKHR);
	public override OpCode Code => OpCode.OpIgnoreIntersectionKHR;
}
public sealed class OpTerminateRayKHR : Instruction
{
	public static OpTerminateRayKHR Instance { get; } = new();

	private OpTerminateRayKHR()
	{
	}

	public override string Name => nameof(OpTerminateRayKHR);
	public override OpCode Code => OpCode.OpTerminateRayKHR;
}
public sealed class OpSDot : Instruction
{
	public static OpSDot Instance { get; } = new();

	private OpSDot()
	{
	}

	public override string Name => nameof(OpSDot);
	public override OpCode Code => OpCode.OpSDot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpUDot : Instruction
{
	public static OpUDot Instance { get; } = new();

	private OpUDot()
	{
	}

	public override string Name => nameof(OpUDot);
	public override OpCode Code => OpCode.OpUDot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpSUDot : Instruction
{
	public static OpSUDot Instance { get; } = new();

	private OpSUDot()
	{
	}

	public override string Name => nameof(OpSUDot);
	public override OpCode Code => OpCode.OpSUDot;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpSDotAccSat : Instruction
{
	public static OpSDotAccSat Instance { get; } = new();

	private OpSDotAccSat()
	{
	}

	public override string Name => nameof(OpSDotAccSat);
	public override OpCode Code => OpCode.OpSDotAccSat;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpUDotAccSat : Instruction
{
	public static OpUDotAccSat Instance { get; } = new();

	private OpUDotAccSat()
	{
	}

	public override string Name => nameof(OpUDotAccSat);
	public override OpCode Code => OpCode.OpUDotAccSat;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpSUDotAccSat : Instruction
{
	public static OpSUDotAccSat Instance { get; } = new();

	private OpSUDotAccSat()
	{
	}

	public override string Name => nameof(OpSUDotAccSat);
	public override OpCode Code => OpCode.OpSUDotAccSat;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default), new Operand(new EnumType<PackedVectorFormat, PackedVectorFormatParameterFactory>(), "Packed Vector Format", OperandQuantifier.Optional),];
}
public sealed class OpTypeCooperativeMatrixKHR : Instruction
{
	public static OpTypeCooperativeMatrixKHR Instance { get; } = new();

	private OpTypeCooperativeMatrixKHR()
	{
	}

	public override string Name => nameof(OpTypeCooperativeMatrixKHR);
	public override OpCode Code => OpCode.OpTypeCooperativeMatrixKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default), new Operand(new IdRef(), "Rows", OperandQuantifier.Default), new Operand(new IdRef(), "Columns", OperandQuantifier.Default), new Operand(new IdRef(), "Use", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixLoadKHR : Instruction
{
	public static OpCooperativeMatrixLoadKHR Instance { get; } = new();

	private OpCooperativeMatrixLoadKHR()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixLoadKHR);
	public override OpCode Code => OpCode.OpCooperativeMatrixLoadKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "MemoryLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Optional), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Memory Operand", OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixStoreKHR : Instruction
{
	public static OpCooperativeMatrixStoreKHR Instance { get; } = new();

	private OpCooperativeMatrixStoreKHR()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixStoreKHR);
	public override OpCode Code => OpCode.OpCooperativeMatrixStoreKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "MemoryLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Optional), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Memory Operand", OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixMulAddKHR : Instruction
{
	public static OpCooperativeMatrixMulAddKHR Instance { get; } = new();

	private OpCooperativeMatrixMulAddKHR()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixMulAddKHR);
	public override OpCode Code => OpCode.OpCooperativeMatrixMulAddKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new IdRef(), "C", OperandQuantifier.Default), new Operand(new EnumType<CooperativeMatrixOperands, CooperativeMatrixOperandsParameterFactory>(), "Cooperative Matrix Operands", OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixLengthKHR : Instruction
{
	public static OpCooperativeMatrixLengthKHR Instance { get; } = new();

	private OpCooperativeMatrixLengthKHR()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixLengthKHR);
	public override OpCode Code => OpCode.OpCooperativeMatrixLengthKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),];
}
public sealed class OpConstantCompositeReplicateEXT : Instruction
{
	public static OpConstantCompositeReplicateEXT Instance { get; } = new();

	private OpConstantCompositeReplicateEXT()
	{
	}

	public override string Name => nameof(OpConstantCompositeReplicateEXT);
	public override OpCode Code => OpCode.OpConstantCompositeReplicateEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantCompositeReplicateEXT : Instruction
{
	public static OpSpecConstantCompositeReplicateEXT Instance { get; } = new();

	private OpSpecConstantCompositeReplicateEXT()
	{
	}

	public override string Name => nameof(OpSpecConstantCompositeReplicateEXT);
	public override OpCode Code => OpCode.OpSpecConstantCompositeReplicateEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpCompositeConstructReplicateEXT : Instruction
{
	public static OpCompositeConstructReplicateEXT Instance { get; } = new();

	private OpCompositeConstructReplicateEXT()
	{
	}

	public override string Name => nameof(OpCompositeConstructReplicateEXT);
	public override OpCode Code => OpCode.OpCompositeConstructReplicateEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpTypeRayQueryKHR : Instruction
{
	public static OpTypeRayQueryKHR Instance { get; } = new();

	private OpTypeRayQueryKHR()
	{
	}

	public override string Name => nameof(OpTypeRayQueryKHR);
	public override OpCode Code => OpCode.OpTypeRayQueryKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpRayQueryInitializeKHR : Instruction
{
	public static OpRayQueryInitializeKHR Instance { get; } = new();

	private OpRayQueryInitializeKHR()
	{
	}

	public override string Name => nameof(OpRayQueryInitializeKHR);
	public override OpCode Code => OpCode.OpRayQueryInitializeKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "RayFlags", OperandQuantifier.Default), new Operand(new IdRef(), "CullMask", OperandQuantifier.Default), new Operand(new IdRef(), "RayOrigin", OperandQuantifier.Default), new Operand(new IdRef(), "RayTMin", OperandQuantifier.Default), new Operand(new IdRef(), "RayDirection", OperandQuantifier.Default), new Operand(new IdRef(), "RayTMax", OperandQuantifier.Default),];
}
public sealed class OpRayQueryTerminateKHR : Instruction
{
	public static OpRayQueryTerminateKHR Instance { get; } = new();

	private OpRayQueryTerminateKHR()
	{
	}

	public override string Name => nameof(OpRayQueryTerminateKHR);
	public override OpCode Code => OpCode.OpRayQueryTerminateKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGenerateIntersectionKHR : Instruction
{
	public static OpRayQueryGenerateIntersectionKHR Instance { get; } = new();

	private OpRayQueryGenerateIntersectionKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGenerateIntersectionKHR);
	public override OpCode Code => OpCode.OpRayQueryGenerateIntersectionKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "HitT", OperandQuantifier.Default),];
}
public sealed class OpRayQueryConfirmIntersectionKHR : Instruction
{
	public static OpRayQueryConfirmIntersectionKHR Instance { get; } = new();

	private OpRayQueryConfirmIntersectionKHR()
	{
	}

	public override string Name => nameof(OpRayQueryConfirmIntersectionKHR);
	public override OpCode Code => OpCode.OpRayQueryConfirmIntersectionKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryProceedKHR : Instruction
{
	public static OpRayQueryProceedKHR Instance { get; } = new();

	private OpRayQueryProceedKHR()
	{
	}

	public override string Name => nameof(OpRayQueryProceedKHR);
	public override OpCode Code => OpCode.OpRayQueryProceedKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionTypeKHR : Instruction
{
	public static OpRayQueryGetIntersectionTypeKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionTypeKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionTypeKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionTypeKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpImageSampleWeightedQCOM : Instruction
{
	public static OpImageSampleWeightedQCOM Instance { get; } = new();

	private OpImageSampleWeightedQCOM()
	{
	}

	public override string Name => nameof(OpImageSampleWeightedQCOM);
	public override OpCode Code => OpCode.OpImageSampleWeightedQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Texture", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Weights", OperandQuantifier.Default),];
}
public sealed class OpImageBoxFilterQCOM : Instruction
{
	public static OpImageBoxFilterQCOM Instance { get; } = new();

	private OpImageBoxFilterQCOM()
	{
	}

	public override string Name => nameof(OpImageBoxFilterQCOM);
	public override OpCode Code => OpCode.OpImageBoxFilterQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Texture", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Box Size", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchSSDQCOM : Instruction
{
	public static OpImageBlockMatchSSDQCOM Instance { get; } = new();

	private OpImageBlockMatchSSDQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchSSDQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchSSDQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchSADQCOM : Instruction
{
	public static OpImageBlockMatchSADQCOM Instance { get; } = new();

	private OpImageBlockMatchSADQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchSADQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchSADQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpBitCastArrayQCOM : Instruction
{
	public static OpBitCastArrayQCOM Instance { get; } = new();

	private OpBitCastArrayQCOM()
	{
	}

	public override string Name => nameof(OpBitCastArrayQCOM);
	public override OpCode Code => OpCode.OpBitCastArrayQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Source Array", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchWindowSSDQCOM : Instruction
{
	public static OpImageBlockMatchWindowSSDQCOM Instance { get; } = new();

	private OpImageBlockMatchWindowSSDQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchWindowSSDQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchWindowSSDQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchWindowSADQCOM : Instruction
{
	public static OpImageBlockMatchWindowSADQCOM Instance { get; } = new();

	private OpImageBlockMatchWindowSADQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchWindowSADQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchWindowSADQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchGatherSSDQCOM : Instruction
{
	public static OpImageBlockMatchGatherSSDQCOM Instance { get; } = new();

	private OpImageBlockMatchGatherSSDQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchGatherSSDQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchGatherSSDQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpImageBlockMatchGatherSADQCOM : Instruction
{
	public static OpImageBlockMatchGatherSADQCOM Instance { get; } = new();

	private OpImageBlockMatchGatherSADQCOM()
	{
	}

	public override string Name => nameof(OpImageBlockMatchGatherSADQCOM);
	public override OpCode Code => OpCode.OpImageBlockMatchGatherSADQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Target Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Reference Coordinates", OperandQuantifier.Default), new Operand(new IdRef(), "Block Size", OperandQuantifier.Default),];
}
public sealed class OpCompositeConstructCoopMatQCOM : Instruction
{
	public static OpCompositeConstructCoopMatQCOM Instance { get; } = new();

	private OpCompositeConstructCoopMatQCOM()
	{
	}

	public override string Name => nameof(OpCompositeConstructCoopMatQCOM);
	public override OpCode Code => OpCode.OpCompositeConstructCoopMatQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Source Array", OperandQuantifier.Default),];
}
public sealed class OpCompositeExtractCoopMatQCOM : Instruction
{
	public static OpCompositeExtractCoopMatQCOM Instance { get; } = new();

	private OpCompositeExtractCoopMatQCOM()
	{
	}

	public override string Name => nameof(OpCompositeExtractCoopMatQCOM);
	public override OpCode Code => OpCode.OpCompositeExtractCoopMatQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Source Cooperative Matrix", OperandQuantifier.Default),];
}
public sealed class OpExtractSubArrayQCOM : Instruction
{
	public static OpExtractSubArrayQCOM Instance { get; } = new();

	private OpExtractSubArrayQCOM()
	{
	}

	public override string Name => nameof(OpExtractSubArrayQCOM);
	public override OpCode Code => OpCode.OpExtractSubArrayQCOM;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Source Array", OperandQuantifier.Default), new Operand(new IdRef(), "index", OperandQuantifier.Default),];
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
public sealed class OpReadClockKHR : Instruction
{
	public static OpReadClockKHR Instance { get; } = new();

	private OpReadClockKHR()
	{
	}

	public override string Name => nameof(OpReadClockKHR);
	public override OpCode Code => OpCode.OpReadClockKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Scope", OperandQuantifier.Default),];
}
public sealed class OpAllocateNodePayloadsAMDX : Instruction
{
	public static OpAllocateNodePayloadsAMDX Instance { get; } = new();

	private OpAllocateNodePayloadsAMDX()
	{
	}

	public override string Name => nameof(OpAllocateNodePayloadsAMDX);
	public override OpCode Code => OpCode.OpAllocateNodePayloadsAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Visibility", OperandQuantifier.Default), new Operand(new IdRef(), "Payload Count", OperandQuantifier.Default), new Operand(new IdRef(), "Node Index", OperandQuantifier.Default),];
}
public sealed class OpEnqueueNodePayloadsAMDX : Instruction
{
	public static OpEnqueueNodePayloadsAMDX Instance { get; } = new();

	private OpEnqueueNodePayloadsAMDX()
	{
	}

	public override string Name => nameof(OpEnqueueNodePayloadsAMDX);
	public override OpCode Code => OpCode.OpEnqueueNodePayloadsAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Payload Array", OperandQuantifier.Default),];
}
public sealed class OpTypeNodePayloadArrayAMDX : Instruction
{
	public static OpTypeNodePayloadArrayAMDX Instance { get; } = new();

	private OpTypeNodePayloadArrayAMDX()
	{
	}

	public override string Name => nameof(OpTypeNodePayloadArrayAMDX);
	public override OpCode Code => OpCode.OpTypeNodePayloadArrayAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload Type", OperandQuantifier.Default),];
}
public sealed class OpFinishWritingNodePayloadAMDX : Instruction
{
	public static OpFinishWritingNodePayloadAMDX Instance { get; } = new();

	private OpFinishWritingNodePayloadAMDX()
	{
	}

	public override string Name => nameof(OpFinishWritingNodePayloadAMDX);
	public override OpCode Code => OpCode.OpFinishWritingNodePayloadAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpNodePayloadArrayLengthAMDX : Instruction
{
	public static OpNodePayloadArrayLengthAMDX Instance { get; } = new();

	private OpNodePayloadArrayLengthAMDX()
	{
	}

	public override string Name => nameof(OpNodePayloadArrayLengthAMDX);
	public override OpCode Code => OpCode.OpNodePayloadArrayLengthAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload Array", OperandQuantifier.Default),];
}
public sealed class OpIsNodePayloadValidAMDX : Instruction
{
	public static OpIsNodePayloadValidAMDX Instance { get; } = new();

	private OpIsNodePayloadValidAMDX()
	{
	}

	public override string Name => nameof(OpIsNodePayloadValidAMDX);
	public override OpCode Code => OpCode.OpIsNodePayloadValidAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload Type", OperandQuantifier.Default), new Operand(new IdRef(), "Node Index", OperandQuantifier.Default),];
}
public sealed class OpConstantStringAMDX : Instruction
{
	public static OpConstantStringAMDX Instance { get; } = new();

	private OpConstantStringAMDX()
	{
	}

	public override string Name => nameof(OpConstantStringAMDX);
	public override OpCode Code => OpCode.OpConstantStringAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Literal String", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantStringAMDX : Instruction
{
	public static OpSpecConstantStringAMDX Instance { get; } = new();

	private OpSpecConstantStringAMDX()
	{
	}

	public override string Name => nameof(OpSpecConstantStringAMDX);
	public override OpCode Code => OpCode.OpSpecConstantStringAMDX;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Literal String", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformQuadAllKHR : Instruction
{
	public static OpGroupNonUniformQuadAllKHR Instance { get; } = new();

	private OpGroupNonUniformQuadAllKHR()
	{
	}

	public override string Name => nameof(OpGroupNonUniformQuadAllKHR);
	public override OpCode Code => OpCode.OpGroupNonUniformQuadAllKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformQuadAnyKHR : Instruction
{
	public static OpGroupNonUniformQuadAnyKHR Instance { get; } = new();

	private OpGroupNonUniformQuadAnyKHR()
	{
	}

	public override string Name => nameof(OpGroupNonUniformQuadAnyKHR);
	public override OpCode Code => OpCode.OpGroupNonUniformQuadAnyKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Predicate", OperandQuantifier.Default),];
}
public sealed class OpTypeBufferEXT : Instruction
{
	public static OpTypeBufferEXT Instance { get; } = new();

	private OpTypeBufferEXT()
	{
	}

	public override string Name => nameof(OpTypeBufferEXT);
	public override OpCode Code => OpCode.OpTypeBufferEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<StorageClass, StorageClassParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpBufferPointerEXT : Instruction
{
	public static OpBufferPointerEXT Instance { get; } = new();

	private OpBufferPointerEXT()
	{
	}

	public override string Name => nameof(OpBufferPointerEXT);
	public override OpCode Code => OpCode.OpBufferPointerEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Buffer", OperandQuantifier.Default),];
}
public sealed class OpUntypedImageTexelPointerEXT : Instruction
{
	public static OpUntypedImageTexelPointerEXT Instance { get; } = new();

	private OpUntypedImageTexelPointerEXT()
	{
	}

	public override string Name => nameof(OpUntypedImageTexelPointerEXT);
	public override OpCode Code => OpCode.OpUntypedImageTexelPointerEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "ImageType", OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Sample", OperandQuantifier.Default),];
}
public sealed class OpMemberDecorateIdEXT : Instruction
{
	public static OpMemberDecorateIdEXT Instance { get; } = new();

	private OpMemberDecorateIdEXT()
	{
	}

	public override string Name => nameof(OpMemberDecorateIdEXT);
	public override OpCode Code => OpCode.OpMemberDecorateIdEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Structure Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpConstantSizeOfEXT : Instruction
{
	public static OpConstantSizeOfEXT Instance { get; } = new();

	private OpConstantSizeOfEXT()
	{
	}

	public override string Name => nameof(OpConstantSizeOfEXT);
	public override OpCode Code => OpCode.OpConstantSizeOfEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordHitMotionNV : Instruction
{
	public static OpHitObjectRecordHitMotionNV Instance { get; } = new();

	private OpHitObjectRecordHitMotionNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordHitMotionNV);
	public override OpCode Code => OpCode.OpHitObjectRecordHitMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "InstanceId", OperandQuantifier.Default), new Operand(new IdRef(), "PrimitiveId", OperandQuantifier.Default), new Operand(new IdRef(), "GeometryIndex", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Kind", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default), new Operand(new IdRef(), "HitObject Attributes", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordHitWithIndexMotionNV : Instruction
{
	public static OpHitObjectRecordHitWithIndexMotionNV Instance { get; } = new();

	private OpHitObjectRecordHitWithIndexMotionNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordHitWithIndexMotionNV);
	public override OpCode Code => OpCode.OpHitObjectRecordHitWithIndexMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "InstanceId", OperandQuantifier.Default), new Operand(new IdRef(), "PrimitiveId", OperandQuantifier.Default), new Operand(new IdRef(), "GeometryIndex", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Kind", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default), new Operand(new IdRef(), "HitObject Attributes", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordMissMotionNV : Instruction
{
	public static OpHitObjectRecordMissMotionNV Instance { get; } = new();

	private OpHitObjectRecordMissMotionNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordMissMotionNV);
	public override OpCode Code => OpCode.OpHitObjectRecordMissMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldToObjectNV : Instruction
{
	public static OpHitObjectGetWorldToObjectNV Instance { get; } = new();

	private OpHitObjectGetWorldToObjectNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldToObjectNV);
	public override OpCode Code => OpCode.OpHitObjectGetWorldToObjectNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectToWorldNV : Instruction
{
	public static OpHitObjectGetObjectToWorldNV Instance { get; } = new();

	private OpHitObjectGetObjectToWorldNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectToWorldNV);
	public override OpCode Code => OpCode.OpHitObjectGetObjectToWorldNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectRayDirectionNV : Instruction
{
	public static OpHitObjectGetObjectRayDirectionNV Instance { get; } = new();

	private OpHitObjectGetObjectRayDirectionNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectRayDirectionNV);
	public override OpCode Code => OpCode.OpHitObjectGetObjectRayDirectionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectRayOriginNV : Instruction
{
	public static OpHitObjectGetObjectRayOriginNV Instance { get; } = new();

	private OpHitObjectGetObjectRayOriginNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectRayOriginNV);
	public override OpCode Code => OpCode.OpHitObjectGetObjectRayOriginNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectTraceRayMotionNV : Instruction
{
	public static OpHitObjectTraceRayMotionNV Instance { get; } = new();

	private OpHitObjectTraceRayMotionNV()
	{
	}

	public override string Name => nameof(OpHitObjectTraceRayMotionNV);
	public override OpCode Code => OpCode.OpHitObjectTraceRayMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "RayFlags", OperandQuantifier.Default), new Operand(new IdRef(), "Cullmask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "Time", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetShaderRecordBufferHandleNV : Instruction
{
	public static OpHitObjectGetShaderRecordBufferHandleNV Instance { get; } = new();

	private OpHitObjectGetShaderRecordBufferHandleNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetShaderRecordBufferHandleNV);
	public override OpCode Code => OpCode.OpHitObjectGetShaderRecordBufferHandleNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetShaderBindingTableRecordIndexNV : Instruction
{
	public static OpHitObjectGetShaderBindingTableRecordIndexNV Instance { get; } = new();

	private OpHitObjectGetShaderBindingTableRecordIndexNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetShaderBindingTableRecordIndexNV);
	public override OpCode Code => OpCode.OpHitObjectGetShaderBindingTableRecordIndexNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordEmptyNV : Instruction
{
	public static OpHitObjectRecordEmptyNV Instance { get; } = new();

	private OpHitObjectRecordEmptyNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordEmptyNV);
	public override OpCode Code => OpCode.OpHitObjectRecordEmptyNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectTraceRayNV : Instruction
{
	public static OpHitObjectTraceRayNV Instance { get; } = new();

	private OpHitObjectTraceRayNV()
	{
	}

	public override string Name => nameof(OpHitObjectTraceRayNV);
	public override OpCode Code => OpCode.OpHitObjectTraceRayNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "RayFlags", OperandQuantifier.Default), new Operand(new IdRef(), "Cullmask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordHitNV : Instruction
{
	public static OpHitObjectRecordHitNV Instance { get; } = new();

	private OpHitObjectRecordHitNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordHitNV);
	public override OpCode Code => OpCode.OpHitObjectRecordHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "InstanceId", OperandQuantifier.Default), new Operand(new IdRef(), "PrimitiveId", OperandQuantifier.Default), new Operand(new IdRef(), "GeometryIndex", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Kind", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "HitObject Attributes", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordHitWithIndexNV : Instruction
{
	public static OpHitObjectRecordHitWithIndexNV Instance { get; } = new();

	private OpHitObjectRecordHitWithIndexNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordHitWithIndexNV);
	public override OpCode Code => OpCode.OpHitObjectRecordHitWithIndexNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "InstanceId", OperandQuantifier.Default), new Operand(new IdRef(), "PrimitiveId", OperandQuantifier.Default), new Operand(new IdRef(), "GeometryIndex", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Kind", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default), new Operand(new IdRef(), "HitObject Attributes", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordMissNV : Instruction
{
	public static OpHitObjectRecordMissNV Instance { get; } = new();

	private OpHitObjectRecordMissNV()
	{
	}

	public override string Name => nameof(OpHitObjectRecordMissNV);
	public override OpCode Code => OpCode.OpHitObjectRecordMissNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Index", OperandQuantifier.Default), new Operand(new IdRef(), "Origin", OperandQuantifier.Default), new Operand(new IdRef(), "TMin", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "TMax", OperandQuantifier.Default),];
}
public sealed class OpHitObjectExecuteShaderNV : Instruction
{
	public static OpHitObjectExecuteShaderNV Instance { get; } = new();

	private OpHitObjectExecuteShaderNV()
	{
	}

	public override string Name => nameof(OpHitObjectExecuteShaderNV);
	public override OpCode Code => OpCode.OpHitObjectExecuteShaderNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetCurrentTimeNV : Instruction
{
	public static OpHitObjectGetCurrentTimeNV Instance { get; } = new();

	private OpHitObjectGetCurrentTimeNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetCurrentTimeNV);
	public override OpCode Code => OpCode.OpHitObjectGetCurrentTimeNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetAttributesNV : Instruction
{
	public static OpHitObjectGetAttributesNV Instance { get; } = new();

	private OpHitObjectGetAttributesNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetAttributesNV);
	public override OpCode Code => OpCode.OpHitObjectGetAttributesNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object Attribute", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetHitKindNV : Instruction
{
	public static OpHitObjectGetHitKindNV Instance { get; } = new();

	private OpHitObjectGetHitKindNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetHitKindNV);
	public override OpCode Code => OpCode.OpHitObjectGetHitKindNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetPrimitiveIndexNV : Instruction
{
	public static OpHitObjectGetPrimitiveIndexNV Instance { get; } = new();

	private OpHitObjectGetPrimitiveIndexNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetPrimitiveIndexNV);
	public override OpCode Code => OpCode.OpHitObjectGetPrimitiveIndexNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetGeometryIndexNV : Instruction
{
	public static OpHitObjectGetGeometryIndexNV Instance { get; } = new();

	private OpHitObjectGetGeometryIndexNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetGeometryIndexNV);
	public override OpCode Code => OpCode.OpHitObjectGetGeometryIndexNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetInstanceIdNV : Instruction
{
	public static OpHitObjectGetInstanceIdNV Instance { get; } = new();

	private OpHitObjectGetInstanceIdNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetInstanceIdNV);
	public override OpCode Code => OpCode.OpHitObjectGetInstanceIdNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetInstanceCustomIndexNV : Instruction
{
	public static OpHitObjectGetInstanceCustomIndexNV Instance { get; } = new();

	private OpHitObjectGetInstanceCustomIndexNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetInstanceCustomIndexNV);
	public override OpCode Code => OpCode.OpHitObjectGetInstanceCustomIndexNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldRayDirectionNV : Instruction
{
	public static OpHitObjectGetWorldRayDirectionNV Instance { get; } = new();

	private OpHitObjectGetWorldRayDirectionNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldRayDirectionNV);
	public override OpCode Code => OpCode.OpHitObjectGetWorldRayDirectionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldRayOriginNV : Instruction
{
	public static OpHitObjectGetWorldRayOriginNV Instance { get; } = new();

	private OpHitObjectGetWorldRayOriginNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldRayOriginNV);
	public override OpCode Code => OpCode.OpHitObjectGetWorldRayOriginNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetRayTMaxNV : Instruction
{
	public static OpHitObjectGetRayTMaxNV Instance { get; } = new();

	private OpHitObjectGetRayTMaxNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetRayTMaxNV);
	public override OpCode Code => OpCode.OpHitObjectGetRayTMaxNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetRayTMinNV : Instruction
{
	public static OpHitObjectGetRayTMinNV Instance { get; } = new();

	private OpHitObjectGetRayTMinNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetRayTMinNV);
	public override OpCode Code => OpCode.OpHitObjectGetRayTMinNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsEmptyNV : Instruction
{
	public static OpHitObjectIsEmptyNV Instance { get; } = new();

	private OpHitObjectIsEmptyNV()
	{
	}

	public override string Name => nameof(OpHitObjectIsEmptyNV);
	public override OpCode Code => OpCode.OpHitObjectIsEmptyNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsHitNV : Instruction
{
	public static OpHitObjectIsHitNV Instance { get; } = new();

	private OpHitObjectIsHitNV()
	{
	}

	public override string Name => nameof(OpHitObjectIsHitNV);
	public override OpCode Code => OpCode.OpHitObjectIsHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsMissNV : Instruction
{
	public static OpHitObjectIsMissNV Instance { get; } = new();

	private OpHitObjectIsMissNV()
	{
	}

	public override string Name => nameof(OpHitObjectIsMissNV);
	public override OpCode Code => OpCode.OpHitObjectIsMissNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpReorderThreadWithHitObjectNV : Instruction
{
	public static OpReorderThreadWithHitObjectNV Instance { get; } = new();

	private OpReorderThreadWithHitObjectNV()
	{
	}

	public override string Name => nameof(OpReorderThreadWithHitObjectNV);
	public override OpCode Code => OpCode.OpReorderThreadWithHitObjectNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Hint", OperandQuantifier.Optional), new Operand(new IdRef(), "Bits", OperandQuantifier.Optional),];
}
public sealed class OpReorderThreadWithHintNV : Instruction
{
	public static OpReorderThreadWithHintNV Instance { get; } = new();

	private OpReorderThreadWithHintNV()
	{
	}

	public override string Name => nameof(OpReorderThreadWithHintNV);
	public override OpCode Code => OpCode.OpReorderThreadWithHintNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hint", OperandQuantifier.Default), new Operand(new IdRef(), "Bits", OperandQuantifier.Default),];
}
public sealed class OpTypeHitObjectNV : Instruction
{
	public static OpTypeHitObjectNV Instance { get; } = new();

	private OpTypeHitObjectNV()
	{
	}

	public override string Name => nameof(OpTypeHitObjectNV);
	public override OpCode Code => OpCode.OpTypeHitObjectNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpImageSampleFootprintNV : Instruction
{
	public static OpImageSampleFootprintNV Instance { get; } = new();

	private OpImageSampleFootprintNV()
	{
	}

	public override string Name => nameof(OpImageSampleFootprintNV);
	public override OpCode Code => OpCode.OpImageSampleFootprintNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sampled Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Granularity", OperandQuantifier.Default), new Operand(new IdRef(), "Coarse", OperandQuantifier.Default), new Operand(new EnumType<ImageOperands, ImageOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpTypeVectorIdEXT : Instruction
{
	public static OpTypeVectorIdEXT Instance { get; } = new();

	private OpTypeVectorIdEXT()
	{
	}

	public override string Name => nameof(OpTypeVectorIdEXT);
	public override OpCode Code => OpCode.OpTypeVectorIdEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new IdRef(), "Component Count", OperandQuantifier.Default),];
}
public sealed class OpCooperativeVectorMatrixMulNV : Instruction
{
	public static OpCooperativeVectorMatrixMulNV Instance { get; } = new();

	private OpCooperativeVectorMatrixMulNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorMatrixMulNV);
	public override OpCode Code => OpCode.OpCooperativeVectorMatrixMulNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new IdRef(), "InputInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixOffset", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "M", OperandQuantifier.Default), new Operand(new IdRef(), "K", OperandQuantifier.Default), new Operand(new IdRef(), "MemoryLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Transpose", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixStride", OperandQuantifier.Optional), new Operand(new EnumType<CooperativeMatrixOperands, CooperativeMatrixOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCooperativeVectorOuterProductAccumulateNV : Instruction
{
	public static OpCooperativeVectorOuterProductAccumulateNV Instance { get; } = new();

	private OpCooperativeVectorOuterProductAccumulateNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorOuterProductAccumulateNV);
	public override OpCode Code => OpCode.OpCooperativeVectorOuterProductAccumulateNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new IdRef(), "MemoryLayout", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixStride", OperandQuantifier.Optional),];
}
public sealed class OpCooperativeVectorReduceSumAccumulateNV : Instruction
{
	public static OpCooperativeVectorReduceSumAccumulateNV Instance { get; } = new();

	private OpCooperativeVectorReduceSumAccumulateNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorReduceSumAccumulateNV);
	public override OpCode Code => OpCode.OpCooperativeVectorReduceSumAccumulateNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "V", OperandQuantifier.Default),];
}
public sealed class OpCooperativeVectorMatrixMulAddNV : Instruction
{
	public static OpCooperativeVectorMatrixMulAddNV Instance { get; } = new();

	private OpCooperativeVectorMatrixMulAddNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorMatrixMulAddNV);
	public override OpCode Code => OpCode.OpCooperativeVectorMatrixMulAddNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new IdRef(), "InputInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixOffset", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "Bias", OperandQuantifier.Default), new Operand(new IdRef(), "BiasOffset", OperandQuantifier.Default), new Operand(new IdRef(), "BiasInterpretation", OperandQuantifier.Default), new Operand(new IdRef(), "M", OperandQuantifier.Default), new Operand(new IdRef(), "K", OperandQuantifier.Default), new Operand(new IdRef(), "MemoryLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Transpose", OperandQuantifier.Default), new Operand(new IdRef(), "MatrixStride", OperandQuantifier.Optional), new Operand(new EnumType<CooperativeMatrixOperands, CooperativeMatrixOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixConvertNV : Instruction
{
	public static OpCooperativeMatrixConvertNV Instance { get; } = new();

	private OpCooperativeMatrixConvertNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixConvertNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixConvertNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpEmitMeshTasksEXT : Instruction
{
	public static OpEmitMeshTasksEXT Instance { get; } = new();

	private OpEmitMeshTasksEXT()
	{
	}

	public override string Name => nameof(OpEmitMeshTasksEXT);
	public override OpCode Code => OpCode.OpEmitMeshTasksEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Group Count X", OperandQuantifier.Default), new Operand(new IdRef(), "Group Count Y", OperandQuantifier.Default), new Operand(new IdRef(), "Group Count Z", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Optional),];
}
public sealed class OpSetMeshOutputsEXT : Instruction
{
	public static OpSetMeshOutputsEXT Instance { get; } = new();

	private OpSetMeshOutputsEXT()
	{
	}

	public override string Name => nameof(OpSetMeshOutputsEXT);
	public override OpCode Code => OpCode.OpSetMeshOutputsEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Vertex Count", OperandQuantifier.Default), new Operand(new IdRef(), "Primitive Count", OperandQuantifier.Default),];
}
public sealed class OpGroupNonUniformPartitionEXT : Instruction
{
	public static OpGroupNonUniformPartitionEXT Instance { get; } = new();

	private OpGroupNonUniformPartitionEXT()
	{
	}

	public override string Name => nameof(OpGroupNonUniformPartitionEXT);
	public override OpCode Code => OpCode.OpGroupNonUniformPartitionEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpWritePackedPrimitiveIndices4x8NV : Instruction
{
	public static OpWritePackedPrimitiveIndices4x8NV Instance { get; } = new();

	private OpWritePackedPrimitiveIndices4x8NV()
	{
	}

	public override string Name => nameof(OpWritePackedPrimitiveIndices4x8NV);
	public override OpCode Code => OpCode.OpWritePackedPrimitiveIndices4x8NV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Index Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Indices", OperandQuantifier.Default),];
}
public sealed class OpFetchMicroTriangleVertexPositionNV : Instruction
{
	public static OpFetchMicroTriangleVertexPositionNV Instance { get; } = new();

	private OpFetchMicroTriangleVertexPositionNV()
	{
	}

	public override string Name => nameof(OpFetchMicroTriangleVertexPositionNV);
	public override OpCode Code => OpCode.OpFetchMicroTriangleVertexPositionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Instance Id", OperandQuantifier.Default), new Operand(new IdRef(), "Geometry Index", OperandQuantifier.Default), new Operand(new IdRef(), "Primitive Index", OperandQuantifier.Default), new Operand(new IdRef(), "Barycentric", OperandQuantifier.Default),];
}
public sealed class OpFetchMicroTriangleVertexBarycentricNV : Instruction
{
	public static OpFetchMicroTriangleVertexBarycentricNV Instance { get; } = new();

	private OpFetchMicroTriangleVertexBarycentricNV()
	{
	}

	public override string Name => nameof(OpFetchMicroTriangleVertexBarycentricNV);
	public override OpCode Code => OpCode.OpFetchMicroTriangleVertexBarycentricNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Instance Id", OperandQuantifier.Default), new Operand(new IdRef(), "Geometry Index", OperandQuantifier.Default), new Operand(new IdRef(), "Primitive Index", OperandQuantifier.Default), new Operand(new IdRef(), "Barycentric", OperandQuantifier.Default),];
}
public sealed class OpCooperativeVectorLoadNV : Instruction
{
	public static OpCooperativeVectorLoadNV Instance { get; } = new();

	private OpCooperativeVectorLoadNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorLoadNV);
	public override OpCode Code => OpCode.OpCooperativeVectorLoadNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCooperativeVectorStoreNV : Instruction
{
	public static OpCooperativeVectorStoreNV Instance { get; } = new();

	private OpCooperativeVectorStoreNV()
	{
	}

	public override string Name => nameof(OpCooperativeVectorStoreNV);
	public override OpCode Code => OpCode.OpCooperativeVectorStoreNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpHitObjectRecordFromQueryEXT : Instruction
{
	public static OpHitObjectRecordFromQueryEXT Instance { get; } = new();

	private OpHitObjectRecordFromQueryEXT()
	{
	}

	public override string Name => nameof(OpHitObjectRecordFromQueryEXT);
	public override OpCode Code => OpCode.OpHitObjectRecordFromQueryEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Query", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Index", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object Attributes", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordMissEXT : Instruction
{
	public static OpHitObjectRecordMissEXT Instance { get; } = new();

	private OpHitObjectRecordMissEXT()
	{
	}

	public override string Name => nameof(OpHitObjectRecordMissEXT);
	public override OpCode Code => OpCode.OpHitObjectRecordMissEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordMissMotionEXT : Instruction
{
	public static OpHitObjectRecordMissMotionEXT Instance { get; } = new();

	private OpHitObjectRecordMissMotionEXT()
	{
	}

	public override string Name => nameof(OpHitObjectRecordMissMotionEXT);
	public override OpCode Code => OpCode.OpHitObjectRecordMissMotionEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetIntersectionTriangleVertexPositionsEXT : Instruction
{
	public static OpHitObjectGetIntersectionTriangleVertexPositionsEXT Instance { get; } = new();

	private OpHitObjectGetIntersectionTriangleVertexPositionsEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetIntersectionTriangleVertexPositionsEXT);
	public override OpCode Code => OpCode.OpHitObjectGetIntersectionTriangleVertexPositionsEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetRayFlagsEXT : Instruction
{
	public static OpHitObjectGetRayFlagsEXT Instance { get; } = new();

	private OpHitObjectGetRayFlagsEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetRayFlagsEXT);
	public override OpCode Code => OpCode.OpHitObjectGetRayFlagsEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectSetShaderBindingTableRecordIndexEXT : Instruction
{
	public static OpHitObjectSetShaderBindingTableRecordIndexEXT Instance { get; } = new();

	private OpHitObjectSetShaderBindingTableRecordIndexEXT()
	{
	}

	public override string Name => nameof(OpHitObjectSetShaderBindingTableRecordIndexEXT);
	public override OpCode Code => OpCode.OpHitObjectSetShaderBindingTableRecordIndexEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Record Index", OperandQuantifier.Default),];
}
public sealed class OpHitObjectReorderExecuteShaderEXT : Instruction
{
	public static OpHitObjectReorderExecuteShaderEXT Instance { get; } = new();

	private OpHitObjectReorderExecuteShaderEXT()
	{
	}

	public override string Name => nameof(OpHitObjectReorderExecuteShaderEXT);
	public override OpCode Code => OpCode.OpHitObjectReorderExecuteShaderEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Hint", OperandQuantifier.Optional), new Operand(new IdRef(), "Bits", OperandQuantifier.Optional),];
}
public sealed class OpHitObjectTraceReorderExecuteEXT : Instruction
{
	public static OpHitObjectTraceReorderExecuteEXT Instance { get; } = new();

	private OpHitObjectTraceReorderExecuteEXT()
	{
	}

	public override string Name => nameof(OpHitObjectTraceReorderExecuteEXT);
	public override OpCode Code => OpCode.OpHitObjectTraceReorderExecuteEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Hint", OperandQuantifier.Optional), new Operand(new IdRef(), "Bits", OperandQuantifier.Optional),];
}
public sealed class OpHitObjectTraceMotionReorderExecuteEXT : Instruction
{
	public static OpHitObjectTraceMotionReorderExecuteEXT Instance { get; } = new();

	private OpHitObjectTraceMotionReorderExecuteEXT()
	{
	}

	public override string Name => nameof(OpHitObjectTraceMotionReorderExecuteEXT);
	public override OpCode Code => OpCode.OpHitObjectTraceMotionReorderExecuteEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Hint", OperandQuantifier.Optional), new Operand(new IdRef(), "Bits", OperandQuantifier.Optional),];
}
public sealed class OpTypeHitObjectEXT : Instruction
{
	public static OpTypeHitObjectEXT Instance { get; } = new();

	private OpTypeHitObjectEXT()
	{
	}

	public override string Name => nameof(OpTypeHitObjectEXT);
	public override OpCode Code => OpCode.OpTypeHitObjectEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpReorderThreadWithHintEXT : Instruction
{
	public static OpReorderThreadWithHintEXT Instance { get; } = new();

	private OpReorderThreadWithHintEXT()
	{
	}

	public override string Name => nameof(OpReorderThreadWithHintEXT);
	public override OpCode Code => OpCode.OpReorderThreadWithHintEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hint", OperandQuantifier.Default), new Operand(new IdRef(), "Bits", OperandQuantifier.Default),];
}
public sealed class OpReorderThreadWithHitObjectEXT : Instruction
{
	public static OpReorderThreadWithHitObjectEXT Instance { get; } = new();

	private OpReorderThreadWithHitObjectEXT()
	{
	}

	public override string Name => nameof(OpReorderThreadWithHitObjectEXT);
	public override OpCode Code => OpCode.OpReorderThreadWithHitObjectEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Hint", OperandQuantifier.Optional), new Operand(new IdRef(), "Bits", OperandQuantifier.Optional),];
}
public sealed class OpHitObjectTraceRayEXT : Instruction
{
	public static OpHitObjectTraceRayEXT Instance { get; } = new();

	private OpHitObjectTraceRayEXT()
	{
	}

	public override string Name => nameof(OpHitObjectTraceRayEXT);
	public override OpCode Code => OpCode.OpHitObjectTraceRayEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectTraceRayMotionEXT : Instruction
{
	public static OpHitObjectTraceRayMotionEXT Instance { get; } = new();

	private OpHitObjectTraceRayMotionEXT()
	{
	}

	public override string Name => nameof(OpHitObjectTraceRayMotionEXT);
	public override OpCode Code => OpCode.OpHitObjectTraceRayMotionEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Acceleration Structure", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Current Time", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectRecordEmptyEXT : Instruction
{
	public static OpHitObjectRecordEmptyEXT Instance { get; } = new();

	private OpHitObjectRecordEmptyEXT()
	{
	}

	public override string Name => nameof(OpHitObjectRecordEmptyEXT);
	public override OpCode Code => OpCode.OpHitObjectRecordEmptyEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectExecuteShaderEXT : Instruction
{
	public static OpHitObjectExecuteShaderEXT Instance { get; } = new();

	private OpHitObjectExecuteShaderEXT()
	{
	}

	public override string Name => nameof(OpHitObjectExecuteShaderEXT);
	public override OpCode Code => OpCode.OpHitObjectExecuteShaderEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetCurrentTimeEXT : Instruction
{
	public static OpHitObjectGetCurrentTimeEXT Instance { get; } = new();

	private OpHitObjectGetCurrentTimeEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetCurrentTimeEXT);
	public override OpCode Code => OpCode.OpHitObjectGetCurrentTimeEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetAttributesEXT : Instruction
{
	public static OpHitObjectGetAttributesEXT Instance { get; } = new();

	private OpHitObjectGetAttributesEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetAttributesEXT);
	public override OpCode Code => OpCode.OpHitObjectGetAttributesEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object Attribute", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetHitKindEXT : Instruction
{
	public static OpHitObjectGetHitKindEXT Instance { get; } = new();

	private OpHitObjectGetHitKindEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetHitKindEXT);
	public override OpCode Code => OpCode.OpHitObjectGetHitKindEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetPrimitiveIndexEXT : Instruction
{
	public static OpHitObjectGetPrimitiveIndexEXT Instance { get; } = new();

	private OpHitObjectGetPrimitiveIndexEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetPrimitiveIndexEXT);
	public override OpCode Code => OpCode.OpHitObjectGetPrimitiveIndexEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetGeometryIndexEXT : Instruction
{
	public static OpHitObjectGetGeometryIndexEXT Instance { get; } = new();

	private OpHitObjectGetGeometryIndexEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetGeometryIndexEXT);
	public override OpCode Code => OpCode.OpHitObjectGetGeometryIndexEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetInstanceIdEXT : Instruction
{
	public static OpHitObjectGetInstanceIdEXT Instance { get; } = new();

	private OpHitObjectGetInstanceIdEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetInstanceIdEXT);
	public override OpCode Code => OpCode.OpHitObjectGetInstanceIdEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetInstanceCustomIndexEXT : Instruction
{
	public static OpHitObjectGetInstanceCustomIndexEXT Instance { get; } = new();

	private OpHitObjectGetInstanceCustomIndexEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetInstanceCustomIndexEXT);
	public override OpCode Code => OpCode.OpHitObjectGetInstanceCustomIndexEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectRayOriginEXT : Instruction
{
	public static OpHitObjectGetObjectRayOriginEXT Instance { get; } = new();

	private OpHitObjectGetObjectRayOriginEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectRayOriginEXT);
	public override OpCode Code => OpCode.OpHitObjectGetObjectRayOriginEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectRayDirectionEXT : Instruction
{
	public static OpHitObjectGetObjectRayDirectionEXT Instance { get; } = new();

	private OpHitObjectGetObjectRayDirectionEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectRayDirectionEXT);
	public override OpCode Code => OpCode.OpHitObjectGetObjectRayDirectionEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldRayDirectionEXT : Instruction
{
	public static OpHitObjectGetWorldRayDirectionEXT Instance { get; } = new();

	private OpHitObjectGetWorldRayDirectionEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldRayDirectionEXT);
	public override OpCode Code => OpCode.OpHitObjectGetWorldRayDirectionEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldRayOriginEXT : Instruction
{
	public static OpHitObjectGetWorldRayOriginEXT Instance { get; } = new();

	private OpHitObjectGetWorldRayOriginEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldRayOriginEXT);
	public override OpCode Code => OpCode.OpHitObjectGetWorldRayOriginEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetObjectToWorldEXT : Instruction
{
	public static OpHitObjectGetObjectToWorldEXT Instance { get; } = new();

	private OpHitObjectGetObjectToWorldEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetObjectToWorldEXT);
	public override OpCode Code => OpCode.OpHitObjectGetObjectToWorldEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetWorldToObjectEXT : Instruction
{
	public static OpHitObjectGetWorldToObjectEXT Instance { get; } = new();

	private OpHitObjectGetWorldToObjectEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetWorldToObjectEXT);
	public override OpCode Code => OpCode.OpHitObjectGetWorldToObjectEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetRayTMaxEXT : Instruction
{
	public static OpHitObjectGetRayTMaxEXT Instance { get; } = new();

	private OpHitObjectGetRayTMaxEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetRayTMaxEXT);
	public override OpCode Code => OpCode.OpHitObjectGetRayTMaxEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpReportIntersectionKHR : Instruction
{
	public static OpReportIntersectionKHR Instance { get; } = new();

	private OpReportIntersectionKHR()
	{
	}

	public override string Name => nameof(OpReportIntersectionKHR);
	public override OpCode Code => OpCode.OpReportIntersectionKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit", OperandQuantifier.Default), new Operand(new IdRef(), "HitKind", OperandQuantifier.Default),];
}
public sealed class OpIgnoreIntersectionNV : Instruction
{
	public static OpIgnoreIntersectionNV Instance { get; } = new();

	private OpIgnoreIntersectionNV()
	{
	}

	public override string Name => nameof(OpIgnoreIntersectionNV);
	public override OpCode Code => OpCode.OpIgnoreIntersectionNV;
}
public sealed class OpTerminateRayNV : Instruction
{
	public static OpTerminateRayNV Instance { get; } = new();

	private OpTerminateRayNV()
	{
	}

	public override string Name => nameof(OpTerminateRayNV);
	public override OpCode Code => OpCode.OpTerminateRayNV;
}
public sealed class OpTraceNV : Instruction
{
	public static OpTraceNV Instance { get; } = new();

	private OpTraceNV()
	{
	}

	public override string Name => nameof(OpTraceNV);
	public override OpCode Code => OpCode.OpTraceNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "PayloadId", OperandQuantifier.Default),];
}
public sealed class OpTraceMotionNV : Instruction
{
	public static OpTraceMotionNV Instance { get; } = new();

	private OpTraceMotionNV()
	{
	}

	public override string Name => nameof(OpTraceMotionNV);
	public override OpCode Code => OpCode.OpTraceMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Time", OperandQuantifier.Default), new Operand(new IdRef(), "PayloadId", OperandQuantifier.Default),];
}
public sealed class OpTraceRayMotionNV : Instruction
{
	public static OpTraceRayMotionNV Instance { get; } = new();

	private OpTraceRayMotionNV()
	{
	}

	public override string Name => nameof(OpTraceRayMotionNV);
	public override OpCode Code => OpCode.OpTraceRayMotionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Accel", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Flags", OperandQuantifier.Default), new Operand(new IdRef(), "Cull Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Offset", OperandQuantifier.Default), new Operand(new IdRef(), "SBT Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Miss Index", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Origin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmin", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Ray Tmax", OperandQuantifier.Default), new Operand(new IdRef(), "Time", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionTriangleVertexPositionsKHR : Instruction
{
	public static OpRayQueryGetIntersectionTriangleVertexPositionsKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionTriangleVertexPositionsKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionTriangleVertexPositionsKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionTriangleVertexPositionsKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpTypeAccelerationStructureKHR : Instruction
{
	public static OpTypeAccelerationStructureKHR Instance { get; } = new();

	private OpTypeAccelerationStructureKHR()
	{
	}

	public override string Name => nameof(OpTypeAccelerationStructureKHR);
	public override OpCode Code => OpCode.OpTypeAccelerationStructureKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpExecuteCallableNV : Instruction
{
	public static OpExecuteCallableNV Instance { get; } = new();

	private OpExecuteCallableNV()
	{
	}

	public override string Name => nameof(OpExecuteCallableNV);
	public override OpCode Code => OpCode.OpExecuteCallableNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "SBT Index", OperandQuantifier.Default), new Operand(new IdRef(), "Callable DataId", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionClusterIdNV : Instruction
{
	public static OpRayQueryGetIntersectionClusterIdNV Instance { get; } = new();

	private OpRayQueryGetIntersectionClusterIdNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionClusterIdNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionClusterIdNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetClusterIdNV : Instruction
{
	public static OpHitObjectGetClusterIdNV Instance { get; } = new();

	private OpHitObjectGetClusterIdNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetClusterIdNV);
	public override OpCode Code => OpCode.OpHitObjectGetClusterIdNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetRayTMinEXT : Instruction
{
	public static OpHitObjectGetRayTMinEXT Instance { get; } = new();

	private OpHitObjectGetRayTMinEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetRayTMinEXT);
	public override OpCode Code => OpCode.OpHitObjectGetRayTMinEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetShaderBindingTableRecordIndexEXT : Instruction
{
	public static OpHitObjectGetShaderBindingTableRecordIndexEXT Instance { get; } = new();

	private OpHitObjectGetShaderBindingTableRecordIndexEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetShaderBindingTableRecordIndexEXT);
	public override OpCode Code => OpCode.OpHitObjectGetShaderBindingTableRecordIndexEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetShaderRecordBufferHandleEXT : Instruction
{
	public static OpHitObjectGetShaderRecordBufferHandleEXT Instance { get; } = new();

	private OpHitObjectGetShaderRecordBufferHandleEXT()
	{
	}

	public override string Name => nameof(OpHitObjectGetShaderRecordBufferHandleEXT);
	public override OpCode Code => OpCode.OpHitObjectGetShaderRecordBufferHandleEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsEmptyEXT : Instruction
{
	public static OpHitObjectIsEmptyEXT Instance { get; } = new();

	private OpHitObjectIsEmptyEXT()
	{
	}

	public override string Name => nameof(OpHitObjectIsEmptyEXT);
	public override OpCode Code => OpCode.OpHitObjectIsEmptyEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsHitEXT : Instruction
{
	public static OpHitObjectIsHitEXT Instance { get; } = new();

	private OpHitObjectIsHitEXT()
	{
	}

	public override string Name => nameof(OpHitObjectIsHitEXT);
	public override OpCode Code => OpCode.OpHitObjectIsHitEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsMissEXT : Instruction
{
	public static OpHitObjectIsMissEXT Instance { get; } = new();

	private OpHitObjectIsMissEXT()
	{
	}

	public override string Name => nameof(OpHitObjectIsMissEXT);
	public override OpCode Code => OpCode.OpHitObjectIsMissEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpTypeCooperativeMatrixNV : Instruction
{
	public static OpTypeCooperativeMatrixNV Instance { get; } = new();

	private OpTypeCooperativeMatrixNV()
	{
	}

	public override string Name => nameof(OpTypeCooperativeMatrixNV);
	public override OpCode Code => OpCode.OpTypeCooperativeMatrixNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Component Type", OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdRef(), "Rows", OperandQuantifier.Default), new Operand(new IdRef(), "Columns", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixLoadNV : Instruction
{
	public static OpCooperativeMatrixLoadNV Instance { get; } = new();

	private OpCooperativeMatrixLoadNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixLoadNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixLoadNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Column Major", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixStoreNV : Instruction
{
	public static OpCooperativeMatrixStoreNV Instance { get; } = new();

	private OpCooperativeMatrixStoreNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixStoreNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixStoreNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Default), new Operand(new IdRef(), "Column Major", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpCooperativeMatrixMulAddNV : Instruction
{
	public static OpCooperativeMatrixMulAddNV Instance { get; } = new();

	private OpCooperativeMatrixMulAddNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixMulAddNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixMulAddNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new IdRef(), "C", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixLengthNV : Instruction
{
	public static OpCooperativeMatrixLengthNV Instance { get; } = new();

	private OpCooperativeMatrixLengthNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixLengthNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixLengthNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Type", OperandQuantifier.Default),];
}
public sealed class OpBeginInvocationInterlockEXT : Instruction
{
	public static OpBeginInvocationInterlockEXT Instance { get; } = new();

	private OpBeginInvocationInterlockEXT()
	{
	}

	public override string Name => nameof(OpBeginInvocationInterlockEXT);
	public override OpCode Code => OpCode.OpBeginInvocationInterlockEXT;
}
public sealed class OpEndInvocationInterlockEXT : Instruction
{
	public static OpEndInvocationInterlockEXT Instance { get; } = new();

	private OpEndInvocationInterlockEXT()
	{
	}

	public override string Name => nameof(OpEndInvocationInterlockEXT);
	public override OpCode Code => OpCode.OpEndInvocationInterlockEXT;
}
public sealed class OpCooperativeMatrixReduceNV : Instruction
{
	public static OpCooperativeMatrixReduceNV Instance { get; } = new();

	private OpCooperativeMatrixReduceNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixReduceNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixReduceNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new EnumType<CooperativeMatrixReduce, CooperativeMatrixReduceParameterFactory>(), "Reduce", OperandQuantifier.Default), new Operand(new IdRef(), "CombineFunc", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixLoadTensorNV : Instruction
{
	public static OpCooperativeMatrixLoadTensorNV Instance { get; } = new();

	private OpCooperativeMatrixLoadTensorNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixLoadTensorNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixLoadTensorNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Memory Operand", OperandQuantifier.Default), new Operand(new EnumType<TensorAddressingOperands, TensorAddressingOperandsParameterFactory>(), "Tensor Addressing Operands", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixStoreTensorNV : Instruction
{
	public static OpCooperativeMatrixStoreTensorNV Instance { get; } = new();

	private OpCooperativeMatrixStoreTensorNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixStoreTensorNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixStoreTensorNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Object", OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), "Memory Operand", OperandQuantifier.Default), new Operand(new EnumType<TensorAddressingOperands, TensorAddressingOperandsParameterFactory>(), "Tensor Addressing Operands", OperandQuantifier.Default),];
}
public sealed class OpCooperativeMatrixPerElementOpNV : Instruction
{
	public static OpCooperativeMatrixPerElementOpNV Instance { get; } = new();

	private OpCooperativeMatrixPerElementOpNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixPerElementOpNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixPerElementOpNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default), new Operand(new IdRef(), "Func", OperandQuantifier.Default), new Operand(new IdRef(), "Operands", OperandQuantifier.Varying),];
}
public sealed class OpTypeTensorLayoutNV : Instruction
{
	public static OpTypeTensorLayoutNV Instance { get; } = new();

	private OpTypeTensorLayoutNV()
	{
	}

	public override string Name => nameof(OpTypeTensorLayoutNV);
	public override OpCode Code => OpCode.OpTypeTensorLayoutNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Dim", OperandQuantifier.Default), new Operand(new IdRef(), "ClampMode", OperandQuantifier.Default),];
}
public sealed class OpTypeTensorViewNV : Instruction
{
	public static OpTypeTensorViewNV Instance { get; } = new();

	private OpTypeTensorViewNV()
	{
	}

	public override string Name => nameof(OpTypeTensorViewNV);
	public override OpCode Code => OpCode.OpTypeTensorViewNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Dim", OperandQuantifier.Default), new Operand(new IdRef(), "HasDimensions", OperandQuantifier.Default), new Operand(new IdRef(), "p", OperandQuantifier.Varying),];
}
public sealed class OpCreateTensorLayoutNV : Instruction
{
	public static OpCreateTensorLayoutNV Instance { get; } = new();

	private OpCreateTensorLayoutNV()
	{
	}

	public override string Name => nameof(OpCreateTensorLayoutNV);
	public override OpCode Code => OpCode.OpCreateTensorLayoutNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTensorLayoutSetDimensionNV : Instruction
{
	public static OpTensorLayoutSetDimensionNV Instance { get; } = new();

	private OpTensorLayoutSetDimensionNV()
	{
	}

	public override string Name => nameof(OpTensorLayoutSetDimensionNV);
	public override OpCode Code => OpCode.OpTensorLayoutSetDimensionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Dim", OperandQuantifier.Varying),];
}
public sealed class OpTensorLayoutSetStrideNV : Instruction
{
	public static OpTensorLayoutSetStrideNV Instance { get; } = new();

	private OpTensorLayoutSetStrideNV()
	{
	}

	public override string Name => nameof(OpTensorLayoutSetStrideNV);
	public override OpCode Code => OpCode.OpTensorLayoutSetStrideNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Varying),];
}
public sealed class OpTensorLayoutSliceNV : Instruction
{
	public static OpTensorLayoutSliceNV Instance { get; } = new();

	private OpTensorLayoutSliceNV()
	{
	}

	public override string Name => nameof(OpTensorLayoutSliceNV);
	public override OpCode Code => OpCode.OpTensorLayoutSliceNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Operands", OperandQuantifier.Varying),];
}
public sealed class OpTensorLayoutSetClampValueNV : Instruction
{
	public static OpTensorLayoutSetClampValueNV Instance { get; } = new();

	private OpTensorLayoutSetClampValueNV()
	{
	}

	public override string Name => nameof(OpTensorLayoutSetClampValueNV);
	public override OpCode Code => OpCode.OpTensorLayoutSetClampValueNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpCreateTensorViewNV : Instruction
{
	public static OpCreateTensorViewNV Instance { get; } = new();

	private OpCreateTensorViewNV()
	{
	}

	public override string Name => nameof(OpCreateTensorViewNV);
	public override OpCode Code => OpCode.OpCreateTensorViewNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTensorViewSetDimensionNV : Instruction
{
	public static OpTensorViewSetDimensionNV Instance { get; } = new();

	private OpTensorViewSetDimensionNV()
	{
	}

	public override string Name => nameof(OpTensorViewSetDimensionNV);
	public override OpCode Code => OpCode.OpTensorViewSetDimensionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorView", OperandQuantifier.Default), new Operand(new IdRef(), "Dim", OperandQuantifier.Varying),];
}
public sealed class OpTensorViewSetStrideNV : Instruction
{
	public static OpTensorViewSetStrideNV Instance { get; } = new();

	private OpTensorViewSetStrideNV()
	{
	}

	public override string Name => nameof(OpTensorViewSetStrideNV);
	public override OpCode Code => OpCode.OpTensorViewSetStrideNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorView", OperandQuantifier.Default), new Operand(new IdRef(), "Stride", OperandQuantifier.Varying),];
}
public sealed class OpDemoteToHelperInvocation : Instruction
{
	public static OpDemoteToHelperInvocation Instance { get; } = new();

	private OpDemoteToHelperInvocation()
	{
	}

	public override string Name => nameof(OpDemoteToHelperInvocation);
	public override OpCode Code => OpCode.OpDemoteToHelperInvocation;
}
public sealed class OpIsHelperInvocationEXT : Instruction
{
	public static OpIsHelperInvocationEXT Instance { get; } = new();

	private OpIsHelperInvocationEXT()
	{
	}

	public override string Name => nameof(OpIsHelperInvocationEXT);
	public override OpCode Code => OpCode.OpIsHelperInvocationEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTensorViewSetClipNV : Instruction
{
	public static OpTensorViewSetClipNV Instance { get; } = new();

	private OpTensorViewSetClipNV()
	{
	}

	public override string Name => nameof(OpTensorViewSetClipNV);
	public override OpCode Code => OpCode.OpTensorViewSetClipNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorView", OperandQuantifier.Default), new Operand(new IdRef(), "ClipRowOffset", OperandQuantifier.Default), new Operand(new IdRef(), "ClipRowSpan", OperandQuantifier.Default), new Operand(new IdRef(), "ClipColOffset", OperandQuantifier.Default), new Operand(new IdRef(), "ClipColSpan", OperandQuantifier.Default),];
}
public sealed class OpTensorLayoutSetBlockSizeNV : Instruction
{
	public static OpTensorLayoutSetBlockSizeNV Instance { get; } = new();

	private OpTensorLayoutSetBlockSizeNV()
	{
	}

	public override string Name => nameof(OpTensorLayoutSetBlockSizeNV);
	public override OpCode Code => OpCode.OpTensorLayoutSetBlockSizeNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "TensorLayout", OperandQuantifier.Default), new Operand(new IdRef(), "BlockSize", OperandQuantifier.Varying),];
}
public sealed class OpCooperativeMatrixTransposeNV : Instruction
{
	public static OpCooperativeMatrixTransposeNV Instance { get; } = new();

	private OpCooperativeMatrixTransposeNV()
	{
	}

	public override string Name => nameof(OpCooperativeMatrixTransposeNV);
	public override OpCode Code => OpCode.OpCooperativeMatrixTransposeNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Matrix", OperandQuantifier.Default),];
}
public sealed class OpConvertUToImageNV : Instruction
{
	public static OpConvertUToImageNV Instance { get; } = new();

	private OpConvertUToImageNV()
	{
	}

	public override string Name => nameof(OpConvertUToImageNV);
	public override OpCode Code => OpCode.OpConvertUToImageNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertUToSamplerNV : Instruction
{
	public static OpConvertUToSamplerNV Instance { get; } = new();

	private OpConvertUToSamplerNV()
	{
	}

	public override string Name => nameof(OpConvertUToSamplerNV);
	public override OpCode Code => OpCode.OpConvertUToSamplerNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertImageToUNV : Instruction
{
	public static OpConvertImageToUNV Instance { get; } = new();

	private OpConvertImageToUNV()
	{
	}

	public override string Name => nameof(OpConvertImageToUNV);
	public override OpCode Code => OpCode.OpConvertImageToUNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertSamplerToUNV : Instruction
{
	public static OpConvertSamplerToUNV Instance { get; } = new();

	private OpConvertSamplerToUNV()
	{
	}

	public override string Name => nameof(OpConvertSamplerToUNV);
	public override OpCode Code => OpCode.OpConvertSamplerToUNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertUToSampledImageNV : Instruction
{
	public static OpConvertUToSampledImageNV Instance { get; } = new();

	private OpConvertUToSampledImageNV()
	{
	}

	public override string Name => nameof(OpConvertUToSampledImageNV);
	public override OpCode Code => OpCode.OpConvertUToSampledImageNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertSampledImageToUNV : Instruction
{
	public static OpConvertSampledImageToUNV Instance { get; } = new();

	private OpConvertSampledImageToUNV()
	{
	}

	public override string Name => nameof(OpConvertSampledImageToUNV);
	public override OpCode Code => OpCode.OpConvertSampledImageToUNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpSamplerImageAddressingModeNV : Instruction
{
	public static OpSamplerImageAddressingModeNV Instance { get; } = new();

	private OpSamplerImageAddressingModeNV()
	{
	}

	public override string Name => nameof(OpSamplerImageAddressingModeNV);
	public override OpCode Code => OpCode.OpSamplerImageAddressingModeNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralInteger(), "Bit Width", OperandQuantifier.Default),];
}
public sealed class OpRawAccessChainNV : Instruction
{
	public static OpRawAccessChainNV Instance { get; } = new();

	private OpRawAccessChainNV()
	{
	}

	public override string Name => nameof(OpRawAccessChainNV);
	public override OpCode Code => OpCode.OpRawAccessChainNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Base", OperandQuantifier.Default), new Operand(new IdRef(), "Byte stride", OperandQuantifier.Default), new Operand(new IdRef(), "Element index", OperandQuantifier.Default), new Operand(new IdRef(), "Byte offset", OperandQuantifier.Default), new Operand(new EnumType<RawAccessChainOperands, RawAccessChainOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpRayQueryGetIntersectionSpherePositionNV : Instruction
{
	public static OpRayQueryGetIntersectionSpherePositionNV Instance { get; } = new();

	private OpRayQueryGetIntersectionSpherePositionNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionSpherePositionNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionSpherePositionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionSphereRadiusNV : Instruction
{
	public static OpRayQueryGetIntersectionSphereRadiusNV Instance { get; } = new();

	private OpRayQueryGetIntersectionSphereRadiusNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionSphereRadiusNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionSphereRadiusNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionLSSPositionsNV : Instruction
{
	public static OpRayQueryGetIntersectionLSSPositionsNV Instance { get; } = new();

	private OpRayQueryGetIntersectionLSSPositionsNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionLSSPositionsNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionLSSPositionsNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionLSSRadiiNV : Instruction
{
	public static OpRayQueryGetIntersectionLSSRadiiNV Instance { get; } = new();

	private OpRayQueryGetIntersectionLSSRadiiNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionLSSRadiiNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionLSSRadiiNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionLSSHitValueNV : Instruction
{
	public static OpRayQueryGetIntersectionLSSHitValueNV Instance { get; } = new();

	private OpRayQueryGetIntersectionLSSHitValueNV()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionLSSHitValueNV);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionLSSHitValueNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetSpherePositionNV : Instruction
{
	public static OpHitObjectGetSpherePositionNV Instance { get; } = new();

	private OpHitObjectGetSpherePositionNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetSpherePositionNV);
	public override OpCode Code => OpCode.OpHitObjectGetSpherePositionNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetSphereRadiusNV : Instruction
{
	public static OpHitObjectGetSphereRadiusNV Instance { get; } = new();

	private OpHitObjectGetSphereRadiusNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetSphereRadiusNV);
	public override OpCode Code => OpCode.OpHitObjectGetSphereRadiusNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetLSSPositionsNV : Instruction
{
	public static OpHitObjectGetLSSPositionsNV Instance { get; } = new();

	private OpHitObjectGetLSSPositionsNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetLSSPositionsNV);
	public override OpCode Code => OpCode.OpHitObjectGetLSSPositionsNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectGetLSSRadiiNV : Instruction
{
	public static OpHitObjectGetLSSRadiiNV Instance { get; } = new();

	private OpHitObjectGetLSSRadiiNV()
	{
	}

	public override string Name => nameof(OpHitObjectGetLSSRadiiNV);
	public override OpCode Code => OpCode.OpHitObjectGetLSSRadiiNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsSphereHitNV : Instruction
{
	public static OpHitObjectIsSphereHitNV Instance { get; } = new();

	private OpHitObjectIsSphereHitNV()
	{
	}

	public override string Name => nameof(OpHitObjectIsSphereHitNV);
	public override OpCode Code => OpCode.OpHitObjectIsSphereHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpHitObjectIsLSSHitNV : Instruction
{
	public static OpHitObjectIsLSSHitNV Instance { get; } = new();

	private OpHitObjectIsLSSHitNV()
	{
	}

	public override string Name => nameof(OpHitObjectIsLSSHitNV);
	public override OpCode Code => OpCode.OpHitObjectIsLSSHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Hit Object", OperandQuantifier.Default),];
}
public sealed class OpRayQueryIsSphereHitNV : Instruction
{
	public static OpRayQueryIsSphereHitNV Instance { get; } = new();

	private OpRayQueryIsSphereHitNV()
	{
	}

	public override string Name => nameof(OpRayQueryIsSphereHitNV);
	public override OpCode Code => OpCode.OpRayQueryIsSphereHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryIsLSSHitNV : Instruction
{
	public static OpRayQueryIsLSSHitNV Instance { get; } = new();

	private OpRayQueryIsLSSHitNV()
	{
	}

	public override string Name => nameof(OpRayQueryIsLSSHitNV);
	public override OpCode Code => OpCode.OpRayQueryIsLSSHitNV;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
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
public sealed class OpSubgroupImageMediaBlockReadINTEL : Instruction
{
	public static OpSubgroupImageMediaBlockReadINTEL Instance { get; } = new();

	private OpSubgroupImageMediaBlockReadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageMediaBlockReadINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageMediaBlockReadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Width", OperandQuantifier.Default), new Operand(new IdRef(), "Height", OperandQuantifier.Default),];
}
public sealed class OpSubgroupImageMediaBlockWriteINTEL : Instruction
{
	public static OpSubgroupImageMediaBlockWriteINTEL Instance { get; } = new();

	private OpSubgroupImageMediaBlockWriteINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupImageMediaBlockWriteINTEL);
	public override OpCode Code => OpCode.OpSubgroupImageMediaBlockWriteINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Image", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Width", OperandQuantifier.Default), new Operand(new IdRef(), "Height", OperandQuantifier.Default), new Operand(new IdRef(), "Data", OperandQuantifier.Default),];
}
public sealed class OpUCountLeadingZerosINTEL : Instruction
{
	public static OpUCountLeadingZerosINTEL Instance { get; } = new();

	private OpUCountLeadingZerosINTEL()
	{
	}

	public override string Name => nameof(OpUCountLeadingZerosINTEL);
	public override OpCode Code => OpCode.OpUCountLeadingZerosINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpUCountTrailingZerosINTEL : Instruction
{
	public static OpUCountTrailingZerosINTEL Instance { get; } = new();

	private OpUCountTrailingZerosINTEL()
	{
	}

	public override string Name => nameof(OpUCountTrailingZerosINTEL);
	public override OpCode Code => OpCode.OpUCountTrailingZerosINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpAbsISubINTEL : Instruction
{
	public static OpAbsISubINTEL Instance { get; } = new();

	private OpAbsISubINTEL()
	{
	}

	public override string Name => nameof(OpAbsISubINTEL);
	public override OpCode Code => OpCode.OpAbsISubINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpAbsUSubINTEL : Instruction
{
	public static OpAbsUSubINTEL Instance { get; } = new();

	private OpAbsUSubINTEL()
	{
	}

	public override string Name => nameof(OpAbsUSubINTEL);
	public override OpCode Code => OpCode.OpAbsUSubINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIAddSatINTEL : Instruction
{
	public static OpIAddSatINTEL Instance { get; } = new();

	private OpIAddSatINTEL()
	{
	}

	public override string Name => nameof(OpIAddSatINTEL);
	public override OpCode Code => OpCode.OpIAddSatINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUAddSatINTEL : Instruction
{
	public static OpUAddSatINTEL Instance { get; } = new();

	private OpUAddSatINTEL()
	{
	}

	public override string Name => nameof(OpUAddSatINTEL);
	public override OpCode Code => OpCode.OpUAddSatINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIAverageINTEL : Instruction
{
	public static OpIAverageINTEL Instance { get; } = new();

	private OpIAverageINTEL()
	{
	}

	public override string Name => nameof(OpIAverageINTEL);
	public override OpCode Code => OpCode.OpIAverageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUAverageINTEL : Instruction
{
	public static OpUAverageINTEL Instance { get; } = new();

	private OpUAverageINTEL()
	{
	}

	public override string Name => nameof(OpUAverageINTEL);
	public override OpCode Code => OpCode.OpUAverageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIAverageRoundedINTEL : Instruction
{
	public static OpIAverageRoundedINTEL Instance { get; } = new();

	private OpIAverageRoundedINTEL()
	{
	}

	public override string Name => nameof(OpIAverageRoundedINTEL);
	public override OpCode Code => OpCode.OpIAverageRoundedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUAverageRoundedINTEL : Instruction
{
	public static OpUAverageRoundedINTEL Instance { get; } = new();

	private OpUAverageRoundedINTEL()
	{
	}

	public override string Name => nameof(OpUAverageRoundedINTEL);
	public override OpCode Code => OpCode.OpUAverageRoundedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpISubSatINTEL : Instruction
{
	public static OpISubSatINTEL Instance { get; } = new();

	private OpISubSatINTEL()
	{
	}

	public override string Name => nameof(OpISubSatINTEL);
	public override OpCode Code => OpCode.OpISubSatINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUSubSatINTEL : Instruction
{
	public static OpUSubSatINTEL Instance { get; } = new();

	private OpUSubSatINTEL()
	{
	}

	public override string Name => nameof(OpUSubSatINTEL);
	public override OpCode Code => OpCode.OpUSubSatINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpIMul32x16INTEL : Instruction
{
	public static OpIMul32x16INTEL Instance { get; } = new();

	private OpIMul32x16INTEL()
	{
	}

	public override string Name => nameof(OpIMul32x16INTEL);
	public override OpCode Code => OpCode.OpIMul32x16INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpUMul32x16INTEL : Instruction
{
	public static OpUMul32x16INTEL Instance { get; } = new();

	private OpUMul32x16INTEL()
	{
	}

	public override string Name => nameof(OpUMul32x16INTEL);
	public override OpCode Code => OpCode.OpUMul32x16INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Default), new Operand(new IdRef(), "Operand 2", OperandQuantifier.Default),];
}
public sealed class OpConstantFunctionPointerINTEL : Instruction
{
	public static OpConstantFunctionPointerINTEL Instance { get; } = new();

	private OpConstantFunctionPointerINTEL()
	{
	}

	public override string Name => nameof(OpConstantFunctionPointerINTEL);
	public override OpCode Code => OpCode.OpConstantFunctionPointerINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default),];
}
public sealed class OpFunctionPointerCallINTEL : Instruction
{
	public static OpFunctionPointerCallINTEL Instance { get; } = new();

	private OpFunctionPointerCallINTEL()
	{
	}

	public override string Name => nameof(OpFunctionPointerCallINTEL);
	public override OpCode Code => OpCode.OpFunctionPointerCallINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand 1", OperandQuantifier.Varying),];
}
public sealed class OpAsmTargetINTEL : Instruction
{
	public static OpAsmTargetINTEL Instance { get; } = new();

	private OpAsmTargetINTEL()
	{
	}

	public override string Name => nameof(OpAsmTargetINTEL);
	public override OpCode Code => OpCode.OpAsmTargetINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralString(), "Asm target", OperandQuantifier.Default),];
}
public sealed class OpAsmINTEL : Instruction
{
	public static OpAsmINTEL Instance { get; } = new();

	private OpAsmINTEL()
	{
	}

	public override string Name => nameof(OpAsmINTEL);
	public override OpCode Code => OpCode.OpAsmINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Asm type", OperandQuantifier.Default), new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new LiteralString(), "Asm instructions", OperandQuantifier.Default), new Operand(new LiteralString(), "Constraints", OperandQuantifier.Default),];
}
public sealed class OpAsmCallINTEL : Instruction
{
	public static OpAsmCallINTEL Instance { get; } = new();

	private OpAsmCallINTEL()
	{
	}

	public override string Name => nameof(OpAsmCallINTEL);
	public override OpCode Code => OpCode.OpAsmCallINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Asm", OperandQuantifier.Default), new Operand(new IdRef(), "Argument", OperandQuantifier.Varying),];
}
public sealed class OpAtomicFMinEXT : Instruction
{
	public static OpAtomicFMinEXT Instance { get; } = new();

	private OpAtomicFMinEXT()
	{
	}

	public override string Name => nameof(OpAtomicFMinEXT);
	public override OpCode Code => OpCode.OpAtomicFMinEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAtomicFMaxEXT : Instruction
{
	public static OpAtomicFMaxEXT Instance { get; } = new();

	private OpAtomicFMaxEXT()
	{
	}

	public override string Name => nameof(OpAtomicFMaxEXT);
	public override OpCode Code => OpCode.OpAtomicFMaxEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpAssumeTrueKHR : Instruction
{
	public static OpAssumeTrueKHR Instance { get; } = new();

	private OpAssumeTrueKHR()
	{
	}

	public override string Name => nameof(OpAssumeTrueKHR);
	public override OpCode Code => OpCode.OpAssumeTrueKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default),];
}
public sealed class OpExpectKHR : Instruction
{
	public static OpExpectKHR Instance { get; } = new();

	private OpExpectKHR()
	{
	}

	public override string Name => nameof(OpExpectKHR);
	public override OpCode Code => OpCode.OpExpectKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default), new Operand(new IdRef(), "ExpectedValue", OperandQuantifier.Default),];
}
public sealed class OpDecorateString : Instruction
{
	public static OpDecorateString Instance { get; } = new();

	private OpDecorateString()
	{
	}

	public override string Name => nameof(OpDecorateString);
	public override OpCode Code => OpCode.OpDecorateString;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Target", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpMemberDecorateString : Instruction
{
	public static OpMemberDecorateString Instance { get; } = new();

	private OpMemberDecorateString()
	{
	}

	public override string Name => nameof(OpMemberDecorateString);
	public override OpCode Code => OpCode.OpMemberDecorateString;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Struct Type", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Member", OperandQuantifier.Default), new Operand(new EnumType<Decoration, DecorationParameterFactory>(), null, OperandQuantifier.Default),];
}
public sealed class OpVmeImageINTEL : Instruction
{
	public static OpVmeImageINTEL Instance { get; } = new();

	private OpVmeImageINTEL()
	{
	}

	public override string Name => nameof(OpVmeImageINTEL);
	public override OpCode Code => OpCode.OpVmeImageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Type", OperandQuantifier.Default), new Operand(new IdRef(), "Sampler", OperandQuantifier.Default),];
}
public sealed class OpTypeVmeImageINTEL : Instruction
{
	public static OpTypeVmeImageINTEL Instance { get; } = new();

	private OpTypeVmeImageINTEL()
	{
	}

	public override string Name => nameof(OpTypeVmeImageINTEL);
	public override OpCode Code => OpCode.OpTypeVmeImageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Type", OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImePayloadINTEL : Instruction
{
	public static OpTypeAvcImePayloadINTEL Instance { get; } = new();

	private OpTypeAvcImePayloadINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImePayloadINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcRefPayloadINTEL : Instruction
{
	public static OpTypeAvcRefPayloadINTEL Instance { get; } = new();

	private OpTypeAvcRefPayloadINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcRefPayloadINTEL);
	public override OpCode Code => OpCode.OpTypeAvcRefPayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcSicPayloadINTEL : Instruction
{
	public static OpTypeAvcSicPayloadINTEL Instance { get; } = new();

	private OpTypeAvcSicPayloadINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcSicPayloadINTEL);
	public override OpCode Code => OpCode.OpTypeAvcSicPayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcMcePayloadINTEL : Instruction
{
	public static OpTypeAvcMcePayloadINTEL Instance { get; } = new();

	private OpTypeAvcMcePayloadINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcMcePayloadINTEL);
	public override OpCode Code => OpCode.OpTypeAvcMcePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcMceResultINTEL : Instruction
{
	public static OpTypeAvcMceResultINTEL Instance { get; } = new();

	private OpTypeAvcMceResultINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcMceResultINTEL);
	public override OpCode Code => OpCode.OpTypeAvcMceResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImeResultINTEL : Instruction
{
	public static OpTypeAvcImeResultINTEL Instance { get; } = new();

	private OpTypeAvcImeResultINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImeResultINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImeResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImeResultSingleReferenceStreamoutINTEL : Instruction
{
	public static OpTypeAvcImeResultSingleReferenceStreamoutINTEL Instance { get; } = new();

	private OpTypeAvcImeResultSingleReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImeResultSingleReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImeResultSingleReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImeResultDualReferenceStreamoutINTEL : Instruction
{
	public static OpTypeAvcImeResultDualReferenceStreamoutINTEL Instance { get; } = new();

	private OpTypeAvcImeResultDualReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImeResultDualReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImeResultDualReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImeSingleReferenceStreaminINTEL : Instruction
{
	public static OpTypeAvcImeSingleReferenceStreaminINTEL Instance { get; } = new();

	private OpTypeAvcImeSingleReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImeSingleReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImeSingleReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcImeDualReferenceStreaminINTEL : Instruction
{
	public static OpTypeAvcImeDualReferenceStreaminINTEL Instance { get; } = new();

	private OpTypeAvcImeDualReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcImeDualReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpTypeAvcImeDualReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcRefResultINTEL : Instruction
{
	public static OpTypeAvcRefResultINTEL Instance { get; } = new();

	private OpTypeAvcRefResultINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcRefResultINTEL);
	public override OpCode Code => OpCode.OpTypeAvcRefResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpTypeAvcSicResultINTEL : Instruction
{
	public static OpTypeAvcSicResultINTEL Instance { get; } = new();

	private OpTypeAvcSicResultINTEL()
	{
	}

	public override string Name => nameof(OpTypeAvcSicResultINTEL);
	public override OpCode Code => OpCode.OpTypeAvcSicResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Reference Base Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetInterShapePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceSetInterShapePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetInterShapePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetInterShapePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetInterShapePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Shape Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetInterDirectionPenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceSetInterDirectionPenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetInterDirectionPenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetInterDirectionPenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Direction Cost", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL : Instruction
{
	public static OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Cost Center Delta", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Cost Table", OperandQuantifier.Default), new Operand(new IdRef(), "Cost Precision", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Slice Type", OperandQuantifier.Default), new Operand(new IdRef(), "Qp", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetAcOnlyHaarINTEL : Instruction
{
	public static OpSubgroupAvcMceSetAcOnlyHaarINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetAcOnlyHaarINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetAcOnlyHaarINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetAcOnlyHaarINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL : Instruction
{
	public static OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Source Field Polarity", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL : Instruction
{
	public static OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Reference Field Polarity", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL : Instruction
{
	public static OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL Instance { get; } = new();

	private OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Forward Reference Field Polarity", OperandQuantifier.Default), new Operand(new IdRef(), "Backward Reference Field Polarity", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToImePayloadINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToImePayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToImePayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToImePayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToImePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToImeResultINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToImeResultINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToImeResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToImeResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToImeResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToRefPayloadINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToRefPayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToRefPayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToRefPayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToRefPayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToRefResultINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToRefResultINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToRefResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToRefResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToRefResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToSicPayloadINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToSicPayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToSicPayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToSicPayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToSicPayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceConvertToSicResultINTEL : Instruction
{
	public static OpSubgroupAvcMceConvertToSicResultINTEL Instance { get; } = new();

	private OpSubgroupAvcMceConvertToSicResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceConvertToSicResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceConvertToSicResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetMotionVectorsINTEL : Instruction
{
	public static OpSubgroupAvcMceGetMotionVectorsINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetMotionVectorsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetMotionVectorsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetMotionVectorsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterDistortionsINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterDistortionsINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterDistortionsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterDistortionsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterDistortionsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetBestInterDistortionsINTEL : Instruction
{
	public static OpSubgroupAvcMceGetBestInterDistortionsINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetBestInterDistortionsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetBestInterDistortionsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetBestInterDistortionsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterMajorShapeINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterMajorShapeINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterMajorShapeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterMajorShapeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterMajorShapeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterMinorShapeINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterMinorShapeINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterMinorShapeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterMinorShapeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterMinorShapeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterDirectionsINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterDirectionsINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterDirectionsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterDirectionsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterDirectionsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterMotionVectorCountINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterMotionVectorCountINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterMotionVectorCountINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterMotionVectorCountINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterMotionVectorCountINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterReferenceIdsINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterReferenceIdsINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterReferenceIdsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterReferenceIdsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterReferenceIdsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL : Instruction
{
	public static OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL Instance { get; } = new();

	private OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Ids", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Parameter Field Polarities", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeInitializeINTEL : Instruction
{
	public static OpSubgroupAvcImeInitializeINTEL Instance { get; } = new();

	private OpSubgroupAvcImeInitializeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeInitializeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeInitializeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Coord", OperandQuantifier.Default), new Operand(new IdRef(), "Partition Mask", OperandQuantifier.Default), new Operand(new IdRef(), "SAD Adjustment", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetSingleReferenceINTEL : Instruction
{
	public static OpSubgroupAvcImeSetSingleReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetSingleReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetSingleReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetSingleReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Ref Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Search Window Config", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetDualReferenceINTEL : Instruction
{
	public static OpSubgroupAvcImeSetDualReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetDualReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetDualReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetDualReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Search Window Config", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeRefWindowSizeINTEL : Instruction
{
	public static OpSubgroupAvcImeRefWindowSizeINTEL Instance { get; } = new();

	private OpSubgroupAvcImeRefWindowSizeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeRefWindowSizeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeRefWindowSizeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Search Window Config", OperandQuantifier.Default), new Operand(new IdRef(), "Dual Ref", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeAdjustRefOffsetINTEL : Instruction
{
	public static OpSubgroupAvcImeAdjustRefOffsetINTEL Instance { get; } = new();

	private OpSubgroupAvcImeAdjustRefOffsetINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeAdjustRefOffsetINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeAdjustRefOffsetINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Ref Offset", OperandQuantifier.Default), new Operand(new IdRef(), "Src Coord", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Window Size", OperandQuantifier.Default), new Operand(new IdRef(), "Image Size", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeConvertToMcePayloadINTEL : Instruction
{
	public static OpSubgroupAvcImeConvertToMcePayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcImeConvertToMcePayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeConvertToMcePayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeConvertToMcePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetMaxMotionVectorCountINTEL : Instruction
{
	public static OpSubgroupAvcImeSetMaxMotionVectorCountINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetMaxMotionVectorCountINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetMaxMotionVectorCountINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Max Motion Vector Count", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL : Instruction
{
	public static OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL : Instruction
{
	public static OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Threshold", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeSetWeightedSadINTEL : Instruction
{
	public static OpSubgroupAvcImeSetWeightedSadINTEL Instance { get; } = new();

	private OpSubgroupAvcImeSetWeightedSadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeSetWeightedSadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeSetWeightedSadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Sad Weights", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithDualReferenceINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithDualReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithDualReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithDualReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Streamin Components", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Streamin Components", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Streamin Components", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL : Instruction
{
	public static OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Streamin Components", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeConvertToMceResultINTEL : Instruction
{
	public static OpSubgroupAvcImeConvertToMceResultINTEL Instance { get; } = new();

	private OpSubgroupAvcImeConvertToMceResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeConvertToMceResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeConvertToMceResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetSingleReferenceStreaminINTEL : Instruction
{
	public static OpSubgroupAvcImeGetSingleReferenceStreaminINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetSingleReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetSingleReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetDualReferenceStreaminINTEL : Instruction
{
	public static OpSubgroupAvcImeGetDualReferenceStreaminINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetDualReferenceStreaminINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetDualReferenceStreaminINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetDualReferenceStreaminINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL : Instruction
{
	public static OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeStripDualReferenceStreamoutINTEL : Instruction
{
	public static OpSubgroupAvcImeStripDualReferenceStreamoutINTEL Instance { get; } = new();

	private OpSubgroupAvcImeStripDualReferenceStreamoutINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeStripDualReferenceStreamoutINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL : Instruction
{
	public static OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shape", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetBorderReachedINTEL : Instruction
{
	public static OpSubgroupAvcImeGetBorderReachedINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetBorderReachedINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetBorderReachedINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetBorderReachedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Image Select", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL : Instruction
{
	public static OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL : Instruction
{
	public static OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL : Instruction
{
	public static OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL : Instruction
{
	public static OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL Instance { get; } = new();

	private OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcFmeInitializeINTEL : Instruction
{
	public static OpSubgroupAvcFmeInitializeINTEL Instance { get; } = new();

	private OpSubgroupAvcFmeInitializeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcFmeInitializeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcFmeInitializeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Coord", OperandQuantifier.Default), new Operand(new IdRef(), "Motion Vectors", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shapes", OperandQuantifier.Default), new Operand(new IdRef(), "Minor Shapes", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Pixel Resolution", OperandQuantifier.Default), new Operand(new IdRef(), "Sad Adjustment", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcBmeInitializeINTEL : Instruction
{
	public static OpSubgroupAvcBmeInitializeINTEL Instance { get; } = new();

	private OpSubgroupAvcBmeInitializeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcBmeInitializeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcBmeInitializeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Coord", OperandQuantifier.Default), new Operand(new IdRef(), "Motion Vectors", OperandQuantifier.Default), new Operand(new IdRef(), "Major Shapes", OperandQuantifier.Default), new Operand(new IdRef(), "Minor Shapes", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default), new Operand(new IdRef(), "Pixel Resolution", OperandQuantifier.Default), new Operand(new IdRef(), "Bidirectional Weight", OperandQuantifier.Default), new Operand(new IdRef(), "Sad Adjustment", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefConvertToMcePayloadINTEL : Instruction
{
	public static OpSubgroupAvcRefConvertToMcePayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcRefConvertToMcePayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefConvertToMcePayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefConvertToMcePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefSetBidirectionalMixDisableINTEL : Instruction
{
	public static OpSubgroupAvcRefSetBidirectionalMixDisableINTEL Instance { get; } = new();

	private OpSubgroupAvcRefSetBidirectionalMixDisableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefSetBidirectionalMixDisableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefSetBilinearFilterEnableINTEL : Instruction
{
	public static OpSubgroupAvcRefSetBilinearFilterEnableINTEL Instance { get; } = new();

	private OpSubgroupAvcRefSetBilinearFilterEnableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefSetBilinearFilterEnableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefSetBilinearFilterEnableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL : Instruction
{
	public static OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefEvaluateWithDualReferenceINTEL : Instruction
{
	public static OpSubgroupAvcRefEvaluateWithDualReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcRefEvaluateWithDualReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefEvaluateWithDualReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL : Instruction
{
	public static OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Ids", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL : Instruction
{
	public static OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL Instance { get; } = new();

	private OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Ids", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Field Polarities", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcRefConvertToMceResultINTEL : Instruction
{
	public static OpSubgroupAvcRefConvertToMceResultINTEL Instance { get; } = new();

	private OpSubgroupAvcRefConvertToMceResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcRefConvertToMceResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcRefConvertToMceResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicInitializeINTEL : Instruction
{
	public static OpSubgroupAvcSicInitializeINTEL Instance { get; } = new();

	private OpSubgroupAvcSicInitializeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicInitializeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicInitializeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Coord", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicConfigureSkcINTEL : Instruction
{
	public static OpSubgroupAvcSicConfigureSkcINTEL Instance { get; } = new();

	private OpSubgroupAvcSicConfigureSkcINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicConfigureSkcINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicConfigureSkcINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Skip Block Partition Type", OperandQuantifier.Default), new Operand(new IdRef(), "Skip Motion Vector Mask", OperandQuantifier.Default), new Operand(new IdRef(), "Motion Vectors", OperandQuantifier.Default), new Operand(new IdRef(), "Bidirectional Weight", OperandQuantifier.Default), new Operand(new IdRef(), "Sad Adjustment", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicConfigureIpeLumaINTEL : Instruction
{
	public static OpSubgroupAvcSicConfigureIpeLumaINTEL Instance { get; } = new();

	private OpSubgroupAvcSicConfigureIpeLumaINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicConfigureIpeLumaINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicConfigureIpeLumaINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Luma Intra Partition Mask", OperandQuantifier.Default), new Operand(new IdRef(), "Intra Neighbour Availabilty", OperandQuantifier.Default), new Operand(new IdRef(), "Left Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Left Corner Luma Pixel", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Right Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Sad Adjustment", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicConfigureIpeLumaChromaINTEL : Instruction
{
	public static OpSubgroupAvcSicConfigureIpeLumaChromaINTEL Instance { get; } = new();

	private OpSubgroupAvcSicConfigureIpeLumaChromaINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicConfigureIpeLumaChromaINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Luma Intra Partition Mask", OperandQuantifier.Default), new Operand(new IdRef(), "Intra Neighbour Availabilty", OperandQuantifier.Default), new Operand(new IdRef(), "Left Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Left Corner Luma Pixel", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Right Edge Luma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Left Edge Chroma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Left Corner Chroma Pixel", OperandQuantifier.Default), new Operand(new IdRef(), "Upper Edge Chroma Pixels", OperandQuantifier.Default), new Operand(new IdRef(), "Sad Adjustment", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetMotionVectorMaskINTEL : Instruction
{
	public static OpSubgroupAvcSicGetMotionVectorMaskINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetMotionVectorMaskINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetMotionVectorMaskINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetMotionVectorMaskINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Skip Block Partition Type", OperandQuantifier.Default), new Operand(new IdRef(), "Direction", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicConvertToMcePayloadINTEL : Instruction
{
	public static OpSubgroupAvcSicConvertToMcePayloadINTEL Instance { get; } = new();

	private OpSubgroupAvcSicConvertToMcePayloadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicConvertToMcePayloadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicConvertToMcePayloadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL : Instruction
{
	public static OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Shape Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL : Instruction
{
	public static OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Luma Mode Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Luma Packed Neighbor Modes", OperandQuantifier.Default), new Operand(new IdRef(), "Luma Packed Non Dc Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL : Instruction
{
	public static OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Chroma Mode Base Penalty", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetBilinearFilterEnableINTEL : Instruction
{
	public static OpSubgroupAvcSicSetBilinearFilterEnableINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetBilinearFilterEnableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetBilinearFilterEnableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetBilinearFilterEnableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL : Instruction
{
	public static OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packed Sad Coefficients", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL : Instruction
{
	public static OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL Instance { get; } = new();

	private OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Block Based Skip Type", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicEvaluateIpeINTEL : Instruction
{
	public static OpSubgroupAvcSicEvaluateIpeINTEL Instance { get; } = new();

	private OpSubgroupAvcSicEvaluateIpeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicEvaluateIpeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicEvaluateIpeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL : Instruction
{
	public static OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicEvaluateWithDualReferenceINTEL : Instruction
{
	public static OpSubgroupAvcSicEvaluateWithDualReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcSicEvaluateWithDualReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicEvaluateWithDualReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Fwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Bwd Ref Image", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL : Instruction
{
	public static OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL Instance { get; } = new();

	private OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Ids", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL : Instruction
{
	public static OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL Instance { get; } = new();

	private OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Src Image", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Ids", OperandQuantifier.Default), new Operand(new IdRef(), "Packed Reference Field Polarities", OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicConvertToMceResultINTEL : Instruction
{
	public static OpSubgroupAvcSicConvertToMceResultINTEL Instance { get; } = new();

	private OpSubgroupAvcSicConvertToMceResultINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicConvertToMceResultINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicConvertToMceResultINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetIpeLumaShapeINTEL : Instruction
{
	public static OpSubgroupAvcSicGetIpeLumaShapeINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetIpeLumaShapeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetIpeLumaShapeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetIpeLumaShapeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL : Instruction
{
	public static OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL : Instruction
{
	public static OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetPackedIpeLumaModesINTEL : Instruction
{
	public static OpSubgroupAvcSicGetPackedIpeLumaModesINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetPackedIpeLumaModesINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetPackedIpeLumaModesINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetIpeChromaModeINTEL : Instruction
{
	public static OpSubgroupAvcSicGetIpeChromaModeINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetIpeChromaModeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetIpeChromaModeINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetIpeChromaModeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL : Instruction
{
	public static OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL : Instruction
{
	public static OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpSubgroupAvcSicGetInterRawSadsINTEL : Instruction
{
	public static OpSubgroupAvcSicGetInterRawSadsINTEL Instance { get; } = new();

	private OpSubgroupAvcSicGetInterRawSadsINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupAvcSicGetInterRawSadsINTEL);
	public override OpCode Code => OpCode.OpSubgroupAvcSicGetInterRawSadsINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Payload", OperandQuantifier.Default),];
}
public sealed class OpVariableLengthArrayINTEL : Instruction
{
	public static OpVariableLengthArrayINTEL Instance { get; } = new();

	private OpVariableLengthArrayINTEL()
	{
	}

	public override string Name => nameof(OpVariableLengthArrayINTEL);
	public override OpCode Code => OpCode.OpVariableLengthArrayINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Length", OperandQuantifier.Default),];
}
public sealed class OpSaveMemoryINTEL : Instruction
{
	public static OpSaveMemoryINTEL Instance { get; } = new();

	private OpSaveMemoryINTEL()
	{
	}

	public override string Name => nameof(OpSaveMemoryINTEL);
	public override OpCode Code => OpCode.OpSaveMemoryINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpRestoreMemoryINTEL : Instruction
{
	public static OpRestoreMemoryINTEL Instance { get; } = new();

	private OpRestoreMemoryINTEL()
	{
	}

	public override string Name => nameof(OpRestoreMemoryINTEL);
	public override OpCode Code => OpCode.OpRestoreMemoryINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Ptr", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSinCosPiALTERA : Instruction
{
	public static OpArbitraryFloatSinCosPiALTERA Instance { get; } = new();

	private OpArbitraryFloatSinCosPiALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSinCosPiALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatSinCosPiALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "MResult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "RoundingAccuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCastALTERA : Instruction
{
	public static OpArbitraryFloatCastALTERA Instance { get; } = new();

	private OpArbitraryFloatCastALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCastALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatCastALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCastFromIntALTERA : Instruction
{
	public static OpArbitraryFloatCastFromIntALTERA Instance { get; } = new();

	private OpArbitraryFloatCastFromIntALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCastFromIntALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatCastFromIntALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "FromSign", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCastToIntALTERA : Instruction
{
	public static OpArbitraryFloatCastToIntALTERA Instance { get; } = new();

	private OpArbitraryFloatCastToIntALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCastToIntALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatCastToIntALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "ToSign", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatAddALTERA : Instruction
{
	public static OpArbitraryFloatAddALTERA Instance { get; } = new();

	private OpArbitraryFloatAddALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatAddALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatAddALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "MResult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSubALTERA : Instruction
{
	public static OpArbitraryFloatSubALTERA Instance { get; } = new();

	private OpArbitraryFloatSubALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSubALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatSubALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatMulALTERA : Instruction
{
	public static OpArbitraryFloatMulALTERA Instance { get; } = new();

	private OpArbitraryFloatMulALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatMulALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatMulALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatDivALTERA : Instruction
{
	public static OpArbitraryFloatDivALTERA Instance { get; } = new();

	private OpArbitraryFloatDivALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatDivALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatDivALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatGTALTERA : Instruction
{
	public static OpArbitraryFloatGTALTERA Instance { get; } = new();

	private OpArbitraryFloatGTALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatGTALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatGTALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatGEALTERA : Instruction
{
	public static OpArbitraryFloatGEALTERA Instance { get; } = new();

	private OpArbitraryFloatGEALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatGEALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatGEALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLTALTERA : Instruction
{
	public static OpArbitraryFloatLTALTERA Instance { get; } = new();

	private OpArbitraryFloatLTALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLTALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatLTALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLEALTERA : Instruction
{
	public static OpArbitraryFloatLEALTERA Instance { get; } = new();

	private OpArbitraryFloatLEALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLEALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatLEALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatEQALTERA : Instruction
{
	public static OpArbitraryFloatEQALTERA Instance { get; } = new();

	private OpArbitraryFloatEQALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatEQALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatEQALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatRecipALTERA : Instruction
{
	public static OpArbitraryFloatRecipALTERA Instance { get; } = new();

	private OpArbitraryFloatRecipALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatRecipALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatRecipALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatRSqrtALTERA : Instruction
{
	public static OpArbitraryFloatRSqrtALTERA Instance { get; } = new();

	private OpArbitraryFloatRSqrtALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatRSqrtALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatRSqrtALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCbrtALTERA : Instruction
{
	public static OpArbitraryFloatCbrtALTERA Instance { get; } = new();

	private OpArbitraryFloatCbrtALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCbrtALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatCbrtALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatHypotALTERA : Instruction
{
	public static OpArbitraryFloatHypotALTERA Instance { get; } = new();

	private OpArbitraryFloatHypotALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatHypotALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatHypotALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSqrtALTERA : Instruction
{
	public static OpArbitraryFloatSqrtALTERA Instance { get; } = new();

	private OpArbitraryFloatSqrtALTERA()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSqrtALTERA);
	public override OpCode Code => OpCode.OpArbitraryFloatSqrtALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLogINTEL : Instruction
{
	public static OpArbitraryFloatLogINTEL Instance { get; } = new();

	private OpArbitraryFloatLogINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLogINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatLogINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLog2INTEL : Instruction
{
	public static OpArbitraryFloatLog2INTEL Instance { get; } = new();

	private OpArbitraryFloatLog2INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLog2INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatLog2INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLog10INTEL : Instruction
{
	public static OpArbitraryFloatLog10INTEL Instance { get; } = new();

	private OpArbitraryFloatLog10INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLog10INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatLog10INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatLog1pINTEL : Instruction
{
	public static OpArbitraryFloatLog1pINTEL Instance { get; } = new();

	private OpArbitraryFloatLog1pINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatLog1pINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatLog1pINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatExpINTEL : Instruction
{
	public static OpArbitraryFloatExpINTEL Instance { get; } = new();

	private OpArbitraryFloatExpINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatExpINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatExpINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatExp2INTEL : Instruction
{
	public static OpArbitraryFloatExp2INTEL Instance { get; } = new();

	private OpArbitraryFloatExp2INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatExp2INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatExp2INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatExp10INTEL : Instruction
{
	public static OpArbitraryFloatExp10INTEL Instance { get; } = new();

	private OpArbitraryFloatExp10INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatExp10INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatExp10INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatExpm1INTEL : Instruction
{
	public static OpArbitraryFloatExpm1INTEL Instance { get; } = new();

	private OpArbitraryFloatExpm1INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatExpm1INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatExpm1INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSinINTEL : Instruction
{
	public static OpArbitraryFloatSinINTEL Instance { get; } = new();

	private OpArbitraryFloatSinINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSinINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatSinINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCosINTEL : Instruction
{
	public static OpArbitraryFloatCosINTEL Instance { get; } = new();

	private OpArbitraryFloatCosINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCosINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatCosINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSinCosINTEL : Instruction
{
	public static OpArbitraryFloatSinCosINTEL Instance { get; } = new();

	private OpArbitraryFloatSinCosINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSinCosINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatSinCosINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatSinPiINTEL : Instruction
{
	public static OpArbitraryFloatSinPiINTEL Instance { get; } = new();

	private OpArbitraryFloatSinPiINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatSinPiINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatSinPiINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatCosPiINTEL : Instruction
{
	public static OpArbitraryFloatCosPiINTEL Instance { get; } = new();

	private OpArbitraryFloatCosPiINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatCosPiINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatCosPiINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatASinINTEL : Instruction
{
	public static OpArbitraryFloatASinINTEL Instance { get; } = new();

	private OpArbitraryFloatASinINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatASinINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatASinINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatASinPiINTEL : Instruction
{
	public static OpArbitraryFloatASinPiINTEL Instance { get; } = new();

	private OpArbitraryFloatASinPiINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatASinPiINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatASinPiINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatACosINTEL : Instruction
{
	public static OpArbitraryFloatACosINTEL Instance { get; } = new();

	private OpArbitraryFloatACosINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatACosINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatACosINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "M1", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mout", OperandQuantifier.Default), new Operand(new LiteralInteger(), "EnableSubnormals", OperandQuantifier.Default), new Operand(new LiteralInteger(), "RoundingMode", OperandQuantifier.Default), new Operand(new LiteralInteger(), "RoundingAccuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatACosPiINTEL : Instruction
{
	public static OpArbitraryFloatACosPiINTEL Instance { get; } = new();

	private OpArbitraryFloatACosPiINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatACosPiINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatACosPiINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatATanINTEL : Instruction
{
	public static OpArbitraryFloatATanINTEL Instance { get; } = new();

	private OpArbitraryFloatATanINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatATanINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatATanINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatATanPiINTEL : Instruction
{
	public static OpArbitraryFloatATanPiINTEL Instance { get; } = new();

	private OpArbitraryFloatATanPiINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatATanPiINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatATanPiINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatATan2INTEL : Instruction
{
	public static OpArbitraryFloatATan2INTEL Instance { get; } = new();

	private OpArbitraryFloatATan2INTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatATan2INTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatATan2INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatPowINTEL : Instruction
{
	public static OpArbitraryFloatPowINTEL Instance { get; } = new();

	private OpArbitraryFloatPowINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatPowINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatPowINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatPowRINTEL : Instruction
{
	public static OpArbitraryFloatPowRINTEL Instance { get; } = new();

	private OpArbitraryFloatPowRINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatPowRINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatPowRINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mb", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpArbitraryFloatPowNINTEL : Instruction
{
	public static OpArbitraryFloatPowNINTEL Instance { get; } = new();

	private OpArbitraryFloatPowNINTEL()
	{
	}

	public override string Name => nameof(OpArbitraryFloatPowNINTEL);
	public override OpCode Code => OpCode.OpArbitraryFloatPowNINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Ma", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new LiteralInteger(), "SignOfB", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Mresult", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Subnormal", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Rounding", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Accuracy", OperandQuantifier.Default),];
}
public sealed class OpLoopControlINTEL : Instruction
{
	public static OpLoopControlINTEL Instance { get; } = new();

	private OpLoopControlINTEL()
	{
	}

	public override string Name => nameof(OpLoopControlINTEL);
	public override OpCode Code => OpCode.OpLoopControlINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new LiteralInteger(), "Loop Control Parameters", OperandQuantifier.Varying),];
}
public sealed class OpAliasDomainDeclINTEL : Instruction
{
	public static OpAliasDomainDeclINTEL Instance { get; } = new();

	private OpAliasDomainDeclINTEL()
	{
	}

	public override string Name => nameof(OpAliasDomainDeclINTEL);
	public override OpCode Code => OpCode.OpAliasDomainDeclINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Name", OperandQuantifier.Optional),];
}
public sealed class OpAliasScopeDeclINTEL : Instruction
{
	public static OpAliasScopeDeclINTEL Instance { get; } = new();

	private OpAliasScopeDeclINTEL()
	{
	}

	public override string Name => nameof(OpAliasScopeDeclINTEL);
	public override OpCode Code => OpCode.OpAliasScopeDeclINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Alias Domain", OperandQuantifier.Default), new Operand(new IdRef(), "Name", OperandQuantifier.Optional),];
}
public sealed class OpAliasScopeListDeclINTEL : Instruction
{
	public static OpAliasScopeListDeclINTEL Instance { get; } = new();

	private OpAliasScopeListDeclINTEL()
	{
	}

	public override string Name => nameof(OpAliasScopeListDeclINTEL);
	public override OpCode Code => OpCode.OpAliasScopeListDeclINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "AliasScope 1, AliasScope 2, ...", OperandQuantifier.Varying),];
}
public sealed class OpFixedSqrtALTERA : Instruction
{
	public static OpFixedSqrtALTERA Instance { get; } = new();

	private OpFixedSqrtALTERA()
	{
	}

	public override string Name => nameof(OpFixedSqrtALTERA);
	public override OpCode Code => OpCode.OpFixedSqrtALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedRecipALTERA : Instruction
{
	public static OpFixedRecipALTERA Instance { get; } = new();

	private OpFixedRecipALTERA()
	{
	}

	public override string Name => nameof(OpFixedRecipALTERA);
	public override OpCode Code => OpCode.OpFixedRecipALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedRsqrtALTERA : Instruction
{
	public static OpFixedRsqrtALTERA Instance { get; } = new();

	private OpFixedRsqrtALTERA()
	{
	}

	public override string Name => nameof(OpFixedRsqrtALTERA);
	public override OpCode Code => OpCode.OpFixedRsqrtALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedSinALTERA : Instruction
{
	public static OpFixedSinALTERA Instance { get; } = new();

	private OpFixedSinALTERA()
	{
	}

	public override string Name => nameof(OpFixedSinALTERA);
	public override OpCode Code => OpCode.OpFixedSinALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedCosALTERA : Instruction
{
	public static OpFixedCosALTERA Instance { get; } = new();

	private OpFixedCosALTERA()
	{
	}

	public override string Name => nameof(OpFixedCosALTERA);
	public override OpCode Code => OpCode.OpFixedCosALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedSinCosALTERA : Instruction
{
	public static OpFixedSinCosALTERA Instance { get; } = new();

	private OpFixedSinCosALTERA()
	{
	}

	public override string Name => nameof(OpFixedSinCosALTERA);
	public override OpCode Code => OpCode.OpFixedSinCosALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedSinPiALTERA : Instruction
{
	public static OpFixedSinPiALTERA Instance { get; } = new();

	private OpFixedSinPiALTERA()
	{
	}

	public override string Name => nameof(OpFixedSinPiALTERA);
	public override OpCode Code => OpCode.OpFixedSinPiALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedCosPiALTERA : Instruction
{
	public static OpFixedCosPiALTERA Instance { get; } = new();

	private OpFixedCosPiALTERA()
	{
	}

	public override string Name => nameof(OpFixedCosPiALTERA);
	public override OpCode Code => OpCode.OpFixedCosPiALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedSinCosPiALTERA : Instruction
{
	public static OpFixedSinCosPiALTERA Instance { get; } = new();

	private OpFixedSinCosPiALTERA()
	{
	}

	public override string Name => nameof(OpFixedSinCosPiALTERA);
	public override OpCode Code => OpCode.OpFixedSinCosPiALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedLogALTERA : Instruction
{
	public static OpFixedLogALTERA Instance { get; } = new();

	private OpFixedLogALTERA()
	{
	}

	public override string Name => nameof(OpFixedLogALTERA);
	public override OpCode Code => OpCode.OpFixedLogALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpFixedExpALTERA : Instruction
{
	public static OpFixedExpALTERA Instance { get; } = new();

	private OpFixedExpALTERA()
	{
	}

	public override string Name => nameof(OpFixedExpALTERA);
	public override OpCode Code => OpCode.OpFixedExpALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default), new Operand(new LiteralInteger(), "S", OperandQuantifier.Default), new Operand(new LiteralInteger(), "I", OperandQuantifier.Default), new Operand(new LiteralInteger(), "rI", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Q", OperandQuantifier.Default), new Operand(new LiteralInteger(), "O", OperandQuantifier.Default),];
}
public sealed class OpPtrCastToCrossWorkgroupALTERA : Instruction
{
	public static OpPtrCastToCrossWorkgroupALTERA Instance { get; } = new();

	private OpPtrCastToCrossWorkgroupALTERA()
	{
	}

	public override string Name => nameof(OpPtrCastToCrossWorkgroupALTERA);
	public override OpCode Code => OpCode.OpPtrCastToCrossWorkgroupALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpCrossWorkgroupCastToPtrALTERA : Instruction
{
	public static OpCrossWorkgroupCastToPtrALTERA Instance { get; } = new();

	private OpCrossWorkgroupCastToPtrALTERA()
	{
	}

	public override string Name => nameof(OpCrossWorkgroupCastToPtrALTERA);
	public override OpCode Code => OpCode.OpCrossWorkgroupCastToPtrALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default),];
}
public sealed class OpReadPipeBlockingALTERA : Instruction
{
	public static OpReadPipeBlockingALTERA Instance { get; } = new();

	private OpReadPipeBlockingALTERA()
	{
	}

	public override string Name => nameof(OpReadPipeBlockingALTERA);
	public override OpCode Code => OpCode.OpReadPipeBlockingALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpWritePipeBlockingALTERA : Instruction
{
	public static OpWritePipeBlockingALTERA Instance { get; } = new();

	private OpWritePipeBlockingALTERA()
	{
	}

	public override string Name => nameof(OpWritePipeBlockingALTERA);
	public override OpCode Code => OpCode.OpWritePipeBlockingALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Packet Size", OperandQuantifier.Default), new Operand(new IdRef(), "Packet Alignment", OperandQuantifier.Default),];
}
public sealed class OpFPGARegALTERA : Instruction
{
	public static OpFPGARegALTERA Instance { get; } = new();

	private OpFPGARegALTERA()
	{
	}

	public override string Name => nameof(OpFPGARegALTERA);
	public override OpCode Code => OpCode.OpFPGARegALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Input", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetRayTMinKHR : Instruction
{
	public static OpRayQueryGetRayTMinKHR Instance { get; } = new();

	private OpRayQueryGetRayTMinKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetRayTMinKHR);
	public override OpCode Code => OpCode.OpRayQueryGetRayTMinKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetRayFlagsKHR : Instruction
{
	public static OpRayQueryGetRayFlagsKHR Instance { get; } = new();

	private OpRayQueryGetRayFlagsKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetRayFlagsKHR);
	public override OpCode Code => OpCode.OpRayQueryGetRayFlagsKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionTKHR : Instruction
{
	public static OpRayQueryGetIntersectionTKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionTKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionTKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionTKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionInstanceCustomIndexKHR : Instruction
{
	public static OpRayQueryGetIntersectionInstanceCustomIndexKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionInstanceCustomIndexKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionInstanceCustomIndexKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionInstanceCustomIndexKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionInstanceIdKHR : Instruction
{
	public static OpRayQueryGetIntersectionInstanceIdKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionInstanceIdKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionInstanceIdKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionInstanceIdKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR : Instruction
{
	public static OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionGeometryIndexKHR : Instruction
{
	public static OpRayQueryGetIntersectionGeometryIndexKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionGeometryIndexKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionGeometryIndexKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionGeometryIndexKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionPrimitiveIndexKHR : Instruction
{
	public static OpRayQueryGetIntersectionPrimitiveIndexKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionPrimitiveIndexKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionPrimitiveIndexKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionPrimitiveIndexKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionBarycentricsKHR : Instruction
{
	public static OpRayQueryGetIntersectionBarycentricsKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionBarycentricsKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionBarycentricsKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionBarycentricsKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionFrontFaceKHR : Instruction
{
	public static OpRayQueryGetIntersectionFrontFaceKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionFrontFaceKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionFrontFaceKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionFrontFaceKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionCandidateAABBOpaqueKHR : Instruction
{
	public static OpRayQueryGetIntersectionCandidateAABBOpaqueKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionCandidateAABBOpaqueKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionCandidateAABBOpaqueKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionObjectRayDirectionKHR : Instruction
{
	public static OpRayQueryGetIntersectionObjectRayDirectionKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionObjectRayDirectionKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionObjectRayDirectionKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionObjectRayDirectionKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionObjectRayOriginKHR : Instruction
{
	public static OpRayQueryGetIntersectionObjectRayOriginKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionObjectRayOriginKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionObjectRayOriginKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionObjectRayOriginKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetWorldRayDirectionKHR : Instruction
{
	public static OpRayQueryGetWorldRayDirectionKHR Instance { get; } = new();

	private OpRayQueryGetWorldRayDirectionKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetWorldRayDirectionKHR);
	public override OpCode Code => OpCode.OpRayQueryGetWorldRayDirectionKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetWorldRayOriginKHR : Instruction
{
	public static OpRayQueryGetWorldRayOriginKHR Instance { get; } = new();

	private OpRayQueryGetWorldRayOriginKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetWorldRayOriginKHR);
	public override OpCode Code => OpCode.OpRayQueryGetWorldRayOriginKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionObjectToWorldKHR : Instruction
{
	public static OpRayQueryGetIntersectionObjectToWorldKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionObjectToWorldKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionObjectToWorldKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionObjectToWorldKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpRayQueryGetIntersectionWorldToObjectKHR : Instruction
{
	public static OpRayQueryGetIntersectionWorldToObjectKHR Instance { get; } = new();

	private OpRayQueryGetIntersectionWorldToObjectKHR()
	{
	}

	public override string Name => nameof(OpRayQueryGetIntersectionWorldToObjectKHR);
	public override OpCode Code => OpCode.OpRayQueryGetIntersectionWorldToObjectKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "RayQuery", OperandQuantifier.Default), new Operand(new IdRef(), "Intersection", OperandQuantifier.Default),];
}
public sealed class OpAtomicFAddEXT : Instruction
{
	public static OpAtomicFAddEXT Instance { get; } = new();

	private OpAtomicFAddEXT()
	{
	}

	public override string Name => nameof(OpAtomicFAddEXT);
	public override OpCode Code => OpCode.OpAtomicFAddEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Pointer", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default), new Operand(new IdRef(), "Value", OperandQuantifier.Default),];
}
public sealed class OpTypeBufferSurfaceINTEL : Instruction
{
	public static OpTypeBufferSurfaceINTEL Instance { get; } = new();

	private OpTypeBufferSurfaceINTEL()
	{
	}

	public override string Name => nameof(OpTypeBufferSurfaceINTEL);
	public override OpCode Code => OpCode.OpTypeBufferSurfaceINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<AccessQualifier, AccessQualifierParameterFactory>(), "AccessQualifier", OperandQuantifier.Default),];
}
public sealed class OpTypeStructContinuedINTEL : Instruction
{
	public static OpTypeStructContinuedINTEL Instance { get; } = new();

	private OpTypeStructContinuedINTEL()
	{
	}

	public override string Name => nameof(OpTypeStructContinuedINTEL);
	public override OpCode Code => OpCode.OpTypeStructContinuedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Member 0 type, member 1 type, ...", OperandQuantifier.Varying),];
}
public sealed class OpConstantCompositeContinuedINTEL : Instruction
{
	public static OpConstantCompositeContinuedINTEL Instance { get; } = new();

	private OpConstantCompositeContinuedINTEL()
	{
	}

	public override string Name => nameof(OpConstantCompositeContinuedINTEL);
	public override OpCode Code => OpCode.OpConstantCompositeContinuedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpSpecConstantCompositeContinuedINTEL : Instruction
{
	public static OpSpecConstantCompositeContinuedINTEL Instance { get; } = new();

	private OpSpecConstantCompositeContinuedINTEL()
	{
	}

	public override string Name => nameof(OpSpecConstantCompositeContinuedINTEL);
	public override OpCode Code => OpCode.OpSpecConstantCompositeContinuedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpCompositeConstructContinuedINTEL : Instruction
{
	public static OpCompositeConstructContinuedINTEL Instance { get; } = new();

	private OpCompositeConstructContinuedINTEL()
	{
	}

	public override string Name => nameof(OpCompositeConstructContinuedINTEL);
	public override OpCode Code => OpCode.OpCompositeConstructContinuedINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Constituents", OperandQuantifier.Varying),];
}
public sealed class OpConvertFToBF16INTEL : Instruction
{
	public static OpConvertFToBF16INTEL Instance { get; } = new();

	private OpConvertFToBF16INTEL()
	{
	}

	public override string Name => nameof(OpConvertFToBF16INTEL);
	public override OpCode Code => OpCode.OpConvertFToBF16INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpConvertBF16ToFINTEL : Instruction
{
	public static OpConvertBF16ToFINTEL Instance { get; } = new();

	private OpConvertBF16ToFINTEL()
	{
	}

	public override string Name => nameof(OpConvertBF16ToFINTEL);
	public override OpCode Code => OpCode.OpConvertBF16ToFINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "BFloat16 Value", OperandQuantifier.Default),];
}
public sealed class OpControlBarrierArriveINTEL : Instruction
{
	public static OpControlBarrierArriveINTEL Instance { get; } = new();

	private OpControlBarrierArriveINTEL()
	{
	}

	public override string Name => nameof(OpControlBarrierArriveINTEL);
	public override OpCode Code => OpCode.OpControlBarrierArriveINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpControlBarrierWaitINTEL : Instruction
{
	public static OpControlBarrierWaitINTEL Instance { get; } = new();

	private OpControlBarrierWaitINTEL()
	{
	}

	public override string Name => nameof(OpControlBarrierWaitINTEL);
	public override OpCode Code => OpCode.OpControlBarrierWaitINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new IdScope(), "Memory", OperandQuantifier.Default), new Operand(new IdMemorySemantics(), "Semantics", OperandQuantifier.Default),];
}
public sealed class OpArithmeticFenceEXT : Instruction
{
	public static OpArithmeticFenceEXT Instance { get; } = new();

	private OpArithmeticFenceEXT()
	{
	}

	public override string Name => nameof(OpArithmeticFenceEXT);
	public override OpCode Code => OpCode.OpArithmeticFenceEXT;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Target", OperandQuantifier.Default),];
}
public sealed class OpTaskSequenceCreateALTERA : Instruction
{
	public static OpTaskSequenceCreateALTERA Instance { get; } = new();

	private OpTaskSequenceCreateALTERA()
	{
	}

	public override string Name => nameof(OpTaskSequenceCreateALTERA);
	public override OpCode Code => OpCode.OpTaskSequenceCreateALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Function", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Pipelined", OperandQuantifier.Default), new Operand(new LiteralInteger(), "UseStallEnableClusters", OperandQuantifier.Default), new Operand(new LiteralInteger(), "GetCapacity", OperandQuantifier.Default), new Operand(new LiteralInteger(), "AsyncCapacity", OperandQuantifier.Default),];
}
public sealed class OpTaskSequenceAsyncALTERA : Instruction
{
	public static OpTaskSequenceAsyncALTERA Instance { get; } = new();

	private OpTaskSequenceAsyncALTERA()
	{
	}

	public override string Name => nameof(OpTaskSequenceAsyncALTERA);
	public override OpCode Code => OpCode.OpTaskSequenceAsyncALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Sequence", OperandQuantifier.Default), new Operand(new IdRef(), "Arguments", OperandQuantifier.Varying),];
}
public sealed class OpTaskSequenceGetALTERA : Instruction
{
	public static OpTaskSequenceGetALTERA Instance { get; } = new();

	private OpTaskSequenceGetALTERA()
	{
	}

	public override string Name => nameof(OpTaskSequenceGetALTERA);
	public override OpCode Code => OpCode.OpTaskSequenceGetALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Sequence", OperandQuantifier.Default),];
}
public sealed class OpTaskSequenceReleaseALTERA : Instruction
{
	public static OpTaskSequenceReleaseALTERA Instance { get; } = new();

	private OpTaskSequenceReleaseALTERA()
	{
	}

	public override string Name => nameof(OpTaskSequenceReleaseALTERA);
	public override OpCode Code => OpCode.OpTaskSequenceReleaseALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Sequence", OperandQuantifier.Default),];
}
public sealed class OpTypeTaskSequenceALTERA : Instruction
{
	public static OpTypeTaskSequenceALTERA Instance { get; } = new();

	private OpTypeTaskSequenceALTERA()
	{
	}

	public override string Name => nameof(OpTypeTaskSequenceALTERA);
	public override OpCode Code => OpCode.OpTypeTaskSequenceALTERA;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResult(), null, OperandQuantifier.Default),];
}
public sealed class OpSubgroupBlockPrefetchINTEL : Instruction
{
	public static OpSubgroupBlockPrefetchINTEL Instance { get; } = new();

	private OpSubgroupBlockPrefetchINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupBlockPrefetchINTEL);
	public override OpCode Code => OpCode.OpSubgroupBlockPrefetchINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Ptr", OperandQuantifier.Default), new Operand(new IdRef(), "NumBytes", OperandQuantifier.Default), new Operand(new EnumType<MemoryAccess, MemoryAccessParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpSubgroup2DBlockLoadINTEL : Instruction
{
	public static OpSubgroup2DBlockLoadINTEL Instance { get; } = new();

	private OpSubgroup2DBlockLoadINTEL()
	{
	}

	public override string Name => nameof(OpSubgroup2DBlockLoadINTEL);
	public override OpCode Code => OpCode.OpSubgroup2DBlockLoadINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Element Size", OperandQuantifier.Default), new Operand(new IdRef(), "Block Width", OperandQuantifier.Default), new Operand(new IdRef(), "Block Height", OperandQuantifier.Default), new Operand(new IdRef(), "Block Count", OperandQuantifier.Default), new Operand(new IdRef(), "Src Base Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Width", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Height", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Pitch", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Dst Pointer", OperandQuantifier.Default),];
}
public sealed class OpSubgroup2DBlockLoadTransformINTEL : Instruction
{
	public static OpSubgroup2DBlockLoadTransformINTEL Instance { get; } = new();

	private OpSubgroup2DBlockLoadTransformINTEL()
	{
	}

	public override string Name => nameof(OpSubgroup2DBlockLoadTransformINTEL);
	public override OpCode Code => OpCode.OpSubgroup2DBlockLoadTransformINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Element Size", OperandQuantifier.Default), new Operand(new IdRef(), "Block Width", OperandQuantifier.Default), new Operand(new IdRef(), "Block Height", OperandQuantifier.Default), new Operand(new IdRef(), "Block Count", OperandQuantifier.Default), new Operand(new IdRef(), "Src Base Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Width", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Height", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Pitch", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Dst Pointer", OperandQuantifier.Default),];
}
public sealed class OpSubgroup2DBlockLoadTransposeINTEL : Instruction
{
	public static OpSubgroup2DBlockLoadTransposeINTEL Instance { get; } = new();

	private OpSubgroup2DBlockLoadTransposeINTEL()
	{
	}

	public override string Name => nameof(OpSubgroup2DBlockLoadTransposeINTEL);
	public override OpCode Code => OpCode.OpSubgroup2DBlockLoadTransposeINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Element Size", OperandQuantifier.Default), new Operand(new IdRef(), "Block Width", OperandQuantifier.Default), new Operand(new IdRef(), "Block Height", OperandQuantifier.Default), new Operand(new IdRef(), "Block Count", OperandQuantifier.Default), new Operand(new IdRef(), "Src Base Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Width", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Height", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Pitch", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default), new Operand(new IdRef(), "Dst Pointer", OperandQuantifier.Default),];
}
public sealed class OpSubgroup2DBlockPrefetchINTEL : Instruction
{
	public static OpSubgroup2DBlockPrefetchINTEL Instance { get; } = new();

	private OpSubgroup2DBlockPrefetchINTEL()
	{
	}

	public override string Name => nameof(OpSubgroup2DBlockPrefetchINTEL);
	public override OpCode Code => OpCode.OpSubgroup2DBlockPrefetchINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Element Size", OperandQuantifier.Default), new Operand(new IdRef(), "Block Width", OperandQuantifier.Default), new Operand(new IdRef(), "Block Height", OperandQuantifier.Default), new Operand(new IdRef(), "Block Count", OperandQuantifier.Default), new Operand(new IdRef(), "Src Base Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Width", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Height", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Pitch", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpSubgroup2DBlockStoreINTEL : Instruction
{
	public static OpSubgroup2DBlockStoreINTEL Instance { get; } = new();

	private OpSubgroup2DBlockStoreINTEL()
	{
	}

	public override string Name => nameof(OpSubgroup2DBlockStoreINTEL);
	public override OpCode Code => OpCode.OpSubgroup2DBlockStoreINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Element Size", OperandQuantifier.Default), new Operand(new IdRef(), "Block Width", OperandQuantifier.Default), new Operand(new IdRef(), "Block Height", OperandQuantifier.Default), new Operand(new IdRef(), "Block Count", OperandQuantifier.Default), new Operand(new IdRef(), "Src Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Dst Base Pointer", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Width", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Height", OperandQuantifier.Default), new Operand(new IdRef(), "Memory Pitch", OperandQuantifier.Default), new Operand(new IdRef(), "Coordinate", OperandQuantifier.Default),];
}
public sealed class OpSubgroupMatrixMultiplyAccumulateINTEL : Instruction
{
	public static OpSubgroupMatrixMultiplyAccumulateINTEL Instance { get; } = new();

	private OpSubgroupMatrixMultiplyAccumulateINTEL()
	{
	}

	public override string Name => nameof(OpSubgroupMatrixMultiplyAccumulateINTEL);
	public override OpCode Code => OpCode.OpSubgroupMatrixMultiplyAccumulateINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "K Dim", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix A", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix B", OperandQuantifier.Default), new Operand(new IdRef(), "Matrix C", OperandQuantifier.Default), new Operand(new EnumType<MatrixMultiplyAccumulateOperands, MatrixMultiplyAccumulateOperandsParameterFactory>(), null, OperandQuantifier.Optional),];
}
public sealed class OpBitwiseFunctionINTEL : Instruction
{
	public static OpBitwiseFunctionINTEL Instance { get; } = new();

	private OpBitwiseFunctionINTEL()
	{
	}

	public override string Name => nameof(OpBitwiseFunctionINTEL);
	public override OpCode Code => OpCode.OpBitwiseFunctionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "A", OperandQuantifier.Default), new Operand(new IdRef(), "B", OperandQuantifier.Default), new Operand(new IdRef(), "C", OperandQuantifier.Default), new Operand(new IdRef(), "LUTIndex", OperandQuantifier.Default),];
}
public sealed class OpUntypedVariableLengthArrayINTEL : Instruction
{
	public static OpUntypedVariableLengthArrayINTEL Instance { get; } = new();

	private OpUntypedVariableLengthArrayINTEL()
	{
	}

	public override string Name => nameof(OpUntypedVariableLengthArrayINTEL);
	public override OpCode Code => OpCode.OpUntypedVariableLengthArrayINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Element Type", OperandQuantifier.Default), new Operand(new IdRef(), "Length", OperandQuantifier.Default),];
}
public sealed class OpConditionalExtensionINTEL : Instruction
{
	public static OpConditionalExtensionINTEL Instance { get; } = new();

	private OpConditionalExtensionINTEL()
	{
	}

	public override string Name => nameof(OpConditionalExtensionINTEL);
	public override OpCode Code => OpCode.OpConditionalExtensionINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default),];
}
public sealed class OpConditionalEntryPointINTEL : Instruction
{
	public static OpConditionalEntryPointINTEL Instance { get; } = new();

	private OpConditionalEntryPointINTEL()
	{
	}

	public override string Name => nameof(OpConditionalEntryPointINTEL);
	public override OpCode Code => OpCode.OpConditionalEntryPointINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new EnumType<ExecutionModel, ExecutionModelParameterFactory>(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Entry Point", OperandQuantifier.Default), new Operand(new LiteralString(), "Name", OperandQuantifier.Default), new Operand(new IdRef(), "Interface", OperandQuantifier.Varying),];
}
public sealed class OpConditionalCapabilityINTEL : Instruction
{
	public static OpConditionalCapabilityINTEL Instance { get; } = new();

	private OpConditionalCapabilityINTEL()
	{
	}

	public override string Name => nameof(OpConditionalCapabilityINTEL);
	public override OpCode Code => OpCode.OpConditionalCapabilityINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "Condition", OperandQuantifier.Default), new Operand(new EnumType<Capability, CapabilityParameterFactory>(), "Capability", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantTargetINTEL : Instruction
{
	public static OpSpecConstantTargetINTEL Instance { get; } = new();

	private OpSpecConstantTargetINTEL()
	{
	}

	public override string Name => nameof(OpSpecConstantTargetINTEL);
	public override OpCode Code => OpCode.OpSpecConstantTargetINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Target", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Features", OperandQuantifier.Varying),];
}
public sealed class OpSpecConstantArchitectureINTEL : Instruction
{
	public static OpSpecConstantArchitectureINTEL Instance { get; } = new();

	private OpSpecConstantArchitectureINTEL()
	{
	}

	public override string Name => nameof(OpSpecConstantArchitectureINTEL);
	public override OpCode Code => OpCode.OpSpecConstantArchitectureINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new LiteralInteger(), "Category", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Family", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Opcode", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Architecture", OperandQuantifier.Default),];
}
public sealed class OpSpecConstantCapabilitiesINTEL : Instruction
{
	public static OpSpecConstantCapabilitiesINTEL Instance { get; } = new();

	private OpSpecConstantCapabilitiesINTEL()
	{
	}

	public override string Name => nameof(OpSpecConstantCapabilitiesINTEL);
	public override OpCode Code => OpCode.OpSpecConstantCapabilitiesINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new EnumType<Capability, CapabilityParameterFactory>(), "Capabilities", OperandQuantifier.Varying),];
}
public sealed class OpConditionalCopyObjectINTEL : Instruction
{
	public static OpConditionalCopyObjectINTEL Instance { get; } = new();

	private OpConditionalCopyObjectINTEL()
	{
	}

	public override string Name => nameof(OpConditionalCopyObjectINTEL);
	public override OpCode Code => OpCode.OpConditionalCopyObjectINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Condition 0, Operand 0, +Condition 1, Operand 1, +...", OperandQuantifier.Varying),];
}
public sealed class OpGroupIMulKHR : Instruction
{
	public static OpGroupIMulKHR Instance { get; } = new();

	private OpGroupIMulKHR()
	{
	}

	public override string Name => nameof(OpGroupIMulKHR);
	public override OpCode Code => OpCode.OpGroupIMulKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupFMulKHR : Instruction
{
	public static OpGroupFMulKHR Instance { get; } = new();

	private OpGroupFMulKHR()
	{
	}

	public override string Name => nameof(OpGroupFMulKHR);
	public override OpCode Code => OpCode.OpGroupFMulKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupBitwiseAndKHR : Instruction
{
	public static OpGroupBitwiseAndKHR Instance { get; } = new();

	private OpGroupBitwiseAndKHR()
	{
	}

	public override string Name => nameof(OpGroupBitwiseAndKHR);
	public override OpCode Code => OpCode.OpGroupBitwiseAndKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupBitwiseOrKHR : Instruction
{
	public static OpGroupBitwiseOrKHR Instance { get; } = new();

	private OpGroupBitwiseOrKHR()
	{
	}

	public override string Name => nameof(OpGroupBitwiseOrKHR);
	public override OpCode Code => OpCode.OpGroupBitwiseOrKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupBitwiseXorKHR : Instruction
{
	public static OpGroupBitwiseXorKHR Instance { get; } = new();

	private OpGroupBitwiseXorKHR()
	{
	}

	public override string Name => nameof(OpGroupBitwiseXorKHR);
	public override OpCode Code => OpCode.OpGroupBitwiseXorKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupLogicalAndKHR : Instruction
{
	public static OpGroupLogicalAndKHR Instance { get; } = new();

	private OpGroupLogicalAndKHR()
	{
	}

	public override string Name => nameof(OpGroupLogicalAndKHR);
	public override OpCode Code => OpCode.OpGroupLogicalAndKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupLogicalOrKHR : Instruction
{
	public static OpGroupLogicalOrKHR Instance { get; } = new();

	private OpGroupLogicalOrKHR()
	{
	}

	public override string Name => nameof(OpGroupLogicalOrKHR);
	public override OpCode Code => OpCode.OpGroupLogicalOrKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpGroupLogicalXorKHR : Instruction
{
	public static OpGroupLogicalXorKHR Instance { get; } = new();

	private OpGroupLogicalXorKHR()
	{
	}

	public override string Name => nameof(OpGroupLogicalXorKHR);
	public override OpCode Code => OpCode.OpGroupLogicalXorKHR;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdScope(), "Execution", OperandQuantifier.Default), new Operand(new EnumType<GroupOperation, GroupOperationParameterFactory>(), "Operation", OperandQuantifier.Default), new Operand(new IdRef(), "X", OperandQuantifier.Default),];
}
public sealed class OpRoundFToTF32INTEL : Instruction
{
	public static OpRoundFToTF32INTEL Instance { get; } = new();

	private OpRoundFToTF32INTEL()
	{
	}

	public override string Name => nameof(OpRoundFToTF32INTEL);
	public override OpCode Code => OpCode.OpRoundFToTF32INTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Float Value", OperandQuantifier.Default),];
}
public sealed class OpMaskedGatherINTEL : Instruction
{
	public static OpMaskedGatherINTEL Instance { get; } = new();

	private OpMaskedGatherINTEL()
	{
	}

	public override string Name => nameof(OpMaskedGatherINTEL);
	public override OpCode Code => OpCode.OpMaskedGatherINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "PtrVector", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Alignment", OperandQuantifier.Default), new Operand(new IdRef(), "Mask", OperandQuantifier.Default), new Operand(new IdRef(), "FillEmpty", OperandQuantifier.Default),];
}
public sealed class OpMaskedScatterINTEL : Instruction
{
	public static OpMaskedScatterINTEL Instance { get; } = new();

	private OpMaskedScatterINTEL()
	{
	}

	public override string Name => nameof(OpMaskedScatterINTEL);
	public override OpCode Code => OpCode.OpMaskedScatterINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdRef(), "InputVector", OperandQuantifier.Default), new Operand(new IdRef(), "PtrVector", OperandQuantifier.Default), new Operand(new LiteralInteger(), "Alignment", OperandQuantifier.Default), new Operand(new IdRef(), "Mask", OperandQuantifier.Default),];
}
public sealed class OpConvertHandleToImageINTEL : Instruction
{
	public static OpConvertHandleToImageINTEL Instance { get; } = new();

	private OpConvertHandleToImageINTEL()
	{
	}

	public override string Name => nameof(OpConvertHandleToImageINTEL);
	public override OpCode Code => OpCode.OpConvertHandleToImageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertHandleToSamplerINTEL : Instruction
{
	public static OpConvertHandleToSamplerINTEL Instance { get; } = new();

	private OpConvertHandleToSamplerINTEL()
	{
	}

	public override string Name => nameof(OpConvertHandleToSamplerINTEL);
	public override OpCode Code => OpCode.OpConvertHandleToSamplerINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpConvertHandleToSampledImageINTEL : Instruction
{
	public static OpConvertHandleToSampledImageINTEL Instance { get; } = new();

	private OpConvertHandleToSampledImageINTEL()
	{
	}

	public override string Name => nameof(OpConvertHandleToSampledImageINTEL);
	public override OpCode Code => OpCode.OpConvertHandleToSampledImageINTEL;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Operand", OperandQuantifier.Default),];
}
public sealed class OpFDot2MixAcc32VALVE : Instruction
{
	public static OpFDot2MixAcc32VALVE Instance { get; } = new();

	private OpFDot2MixAcc32VALVE()
	{
	}

	public override string Name => nameof(OpFDot2MixAcc32VALVE);
	public override OpCode Code => OpCode.OpFDot2MixAcc32VALVE;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default),];
}
public sealed class OpFDot2MixAcc16VALVE : Instruction
{
	public static OpFDot2MixAcc16VALVE Instance { get; } = new();

	private OpFDot2MixAcc16VALVE()
	{
	}

	public override string Name => nameof(OpFDot2MixAcc16VALVE);
	public override OpCode Code => OpCode.OpFDot2MixAcc16VALVE;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default),];
}
public sealed class OpFDot4MixAcc32VALVE : Instruction
{
	public static OpFDot4MixAcc32VALVE Instance { get; } = new();

	private OpFDot4MixAcc32VALVE()
	{
	}

	public override string Name => nameof(OpFDot4MixAcc32VALVE);
	public override OpCode Code => OpCode.OpFDot4MixAcc32VALVE;
	public override IReadOnlyList<Operand> Operands => _operands;

	private static readonly Operand[] _operands = [new Operand(new IdResultType(), null, OperandQuantifier.Default), new Operand(new IdResult(), null, OperandQuantifier.Default), new Operand(new IdRef(), "Vector 1", OperandQuantifier.Default), new Operand(new IdRef(), "Vector 2", OperandQuantifier.Default), new Operand(new IdRef(), "Accumulator", OperandQuantifier.Default),];
}