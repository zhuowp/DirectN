﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1500,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_PHYSICAL_SUBRESOURCE_PITCHED_LAYOUT
    {
        public int Format;
        public uint PhysicalWidth;
        public uint PhysicalHeight;
        public uint PhysicalDepth;
        public uint Pitch;
        public uint SlicePitch;
    }
}
