﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(137,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_MEMORY_ARCHITECTURE_CAPS
    {
        public bool UMA;
        public bool IOCoherent;
        public bool CacheCoherent;
    }
}
