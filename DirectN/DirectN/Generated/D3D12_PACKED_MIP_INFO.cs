﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2552,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_PACKED_MIP_INFO
    {
        public byte NumStandardMips;
        public byte NumPackedMips;
        public uint NumTilesForPackedMips;
        public uint StartTileIndexInOverallResource;
    }
}
