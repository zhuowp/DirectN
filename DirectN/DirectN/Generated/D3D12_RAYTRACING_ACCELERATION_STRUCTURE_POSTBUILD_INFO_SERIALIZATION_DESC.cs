﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12429,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_SERIALIZATION_DESC
    {
        public ulong SerializedSizeInBytes;
        public ulong NumBottomLevelAccelerationStructurePointers;
    }
}
