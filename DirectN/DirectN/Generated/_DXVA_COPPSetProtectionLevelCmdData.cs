﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(763,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_COPPSetProtectionLevelCmdData
    {
        public uint ProtType;
        public uint ProtLevel;
        public uint ExtendedInfoChangeMask;
        public uint ExtendedInfoData;
    }
}
