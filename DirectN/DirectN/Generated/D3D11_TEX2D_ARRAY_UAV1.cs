﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_3.h(1611,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEX2D_ARRAY_UAV1
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
        public uint PlaneSlice;
    }
}
