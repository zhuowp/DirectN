﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1208,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_TEX2D_DEPTH_STENCIL_VIEW
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
