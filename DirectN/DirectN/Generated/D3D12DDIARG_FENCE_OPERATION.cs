﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2595,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_FENCE_OPERATION
    {
        public D3D12DDI_HFENCE Fence;
        public ulong Value;
        public uint PhysicalAdapterMask;
    }
}
