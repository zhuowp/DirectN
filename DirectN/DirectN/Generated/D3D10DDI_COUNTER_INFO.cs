﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(1107,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDI_COUNTER_INFO
    {
        public D3D10DDI_QUERY LastDeviceDependentCounter;
        public uint NumSimultaneousCounters;
        public byte NumDetectableParallelUnits;
    }
}
