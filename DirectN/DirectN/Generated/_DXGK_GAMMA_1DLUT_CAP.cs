﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2543,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_GAMMA_1DLUT_CAP
    {
        public uint NumberOfLUTEntries;
        public _DKGK_GAMMA_DATA_CAP GammaDataCap;
    }
}
