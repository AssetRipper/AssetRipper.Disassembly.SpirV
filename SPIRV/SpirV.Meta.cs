using System;
using System.Collections.Generic;

namespace SpirV
{
    class Meta
    {
        public static uint MagicNumber
        {
            get
            {
                return 119734787U;
            }
        }

        public static uint Version
        {
            get
            {
                return 66048U;
            }
        }

        public static uint Revision
        {
            get
            {
                return 2U;
            }
        }

        public static uint OpCodeMask
        {
            get
            {
                return 65535U;
            }
        }

        public static uint WordCountShift
        {
            get
            {
                return 16U;
            }
        }

        public class ToolInfo
        {
            public ToolInfo(string vendor)
            {
                Vendor = vendor;
            }

            public ToolInfo(string vendor, string name)
            {
                Vendor = vendor;
                Name = name;
            }

            public String Name { get; }
            public String Vendor { get; }
    }private readonly static Dictionary<int, ToolInfo> toolInfos_ = new Dictionary<int, ToolInfo>
    {
        {
            0,
            new ToolInfo("Khronos")
        },
        {
            1,
            new ToolInfo("LunarG")
        },
        {
            2,
            new ToolInfo("Valve")
        },
        {
            3,
            new ToolInfo("Codeplay")
        },
        {
            4,
            new ToolInfo("NVIDIA")
        },
        {
            5,
            new ToolInfo("ARM")
        },
        {
            6,
            new ToolInfo("Khronos", "LLVM/SPIR-V Translator")
        },
        {
            7,
            new ToolInfo("Khronos", "SPIR-V Tools Assembler")
        },
        {
            8,
            new ToolInfo("Khronos", "Glslang Reference Front End")
        },
        {
            9,
            new ToolInfo("Qualcomm")
        },
        {
            10,
            new ToolInfo("AMD")
        },
        {
            11,
            new ToolInfo("Intel")
        },
        {
            12,
            new ToolInfo("Imagination")
        },
        {
            13,
            new ToolInfo("Google", "Shaderc over Glslang")
        },
        {
            14,
            new ToolInfo("Google", "spiregg")
        },
        {
            15,
            new ToolInfo("Google", "rspirv")
        },
        {
            16,
            new ToolInfo("X-LEGEND", "Mesa-IR/SPIR-V Translator")
        },
        {
            17,
            new ToolInfo("Khronos", "SPIR-V Tools Linker")
        },
        {
            18,
            new ToolInfo("Wine", "VKD3D Shader Compiler")
        },
        {
            19,
            new ToolInfo("Tellusim", "Clay Shader Compiler")
        },
        {
            20,
            new ToolInfo("W3C WebGPU Group", "WHLSL Shader Translator")
        },
        {
            21,
            new ToolInfo("Google", "Clspv")
        },
        {
            22,
            new ToolInfo("LLVM", "MLIR SPIR-V Serializer")
        },
        {
            23,
            new ToolInfo("Google", "Tint Compiler")
        },
        {
            24,
            new ToolInfo("Google", "ANGLE Shader Compiler")
        },
        {
            25,
            new ToolInfo("Netease Games", "Messiah Shader Compiler")
        },
        {
            26,
            new ToolInfo("Xenia", "Xenia Emulator Microcode Translator")
        },
        {
            27,
            new ToolInfo("Embark Studios", "Rust GPU Compiler Backend")
        },
        {
            28,
            new ToolInfo("gfx-rs community", "Naga")
        },
        {
            29,
            new ToolInfo("Mikkosoft Productions", "MSP Shader Compiler")
        },
        {
            30,
            new ToolInfo("SpvGenTwo community", "SpvGenTwo SPIR-V IR Tools")
        },
        {
            31,
            new ToolInfo("Google", "Skia SkSL")
        },
        {
            32,
            new ToolInfo("TornadoVM", "Beehive SPIRV Toolkit")
        },
        {
            33,
            new ToolInfo("DragonJoker", "ShaderWriter")
        },
        {
            34,
            new ToolInfo("Rayan Hatout", "SPIRVSmith")
        },
        {
            35,
            new ToolInfo("Saarland University", "Shady")
        },
        {
            36,
            new ToolInfo("Taichi Graphics", "Taichi")
        },
        {
            37,
            new ToolInfo("heroseh", "Hero C Compiler")
        },
        {
            38,
            new ToolInfo("Meta", "SparkSL")
        },
        {
            39,
            new ToolInfo("SirLynix", "Nazara ShaderLang Compiler")
        },
        {
            40,
            new ToolInfo("NVIDIA", "Slang Compiler")
        },
        {
            41,
            new ToolInfo("Zig Software Foundation", "Zig Compiler")
        },
        {
            42,
            new ToolInfo("Rendong Liang", "spq")
        },
        {
            43,
            new ToolInfo("LLVM", "LLVM SPIR-V Backend")
        },
        {
            44,
            new ToolInfo("Robert Konrad", "Kongruent")
        },
        {
            45,
            new ToolInfo("Kitsunebi Games", "Nuvk SPIR-V Emitter and DLSL compiler")
        },
        {
            46,
            new ToolInfo("Nintendo")
        },
    };
            public static IReadOnlyDictionary<int, ToolInfo> Tools { get => toolInfos_; }}
}