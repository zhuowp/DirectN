﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(641,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_TEX1D_DEPTHSTENCILVIEW
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
