﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(1785,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS
    {
        public uint ulNewTVProtectionStandard;
        public uint ulAspectRatioChangeMask1;
        public uint ulAspectRatioData1;
        public uint ulAspectRatioChangeMask2;
        public uint ulAspectRatioData2;
        public uint ulAspectRatioChangeMask3;
        public uint ulAspectRatioData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ulReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] ulReserved2;
        public uint ulReserved3;
    }
}
