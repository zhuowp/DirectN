﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4121,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GETROOTPAGETABLESIZE
    {
        public uint NumberOfPte;
        public uint PhysicalAdapterIndex;
    }
}
