﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\mmreg.h(2944,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct digirealwaveformat_tag
    {
        public tWAVEFORMATEX wfx;
        public ushort wSamplesPerBlock;
    }
}
