﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2806,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXCUBE_SRV
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public float ResourceMinLODClamp;
    }
}
