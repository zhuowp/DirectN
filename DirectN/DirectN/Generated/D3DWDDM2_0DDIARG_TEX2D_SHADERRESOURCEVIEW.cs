﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(5268,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDIARG_TEX2D_SHADERRESOURCEVIEW
    {
        public uint MostDetailedMip;
        public uint FirstArraySlice;
        public uint MipLevels;
        public uint ArraySize;
        public uint PlaneSlice;
    }
}
