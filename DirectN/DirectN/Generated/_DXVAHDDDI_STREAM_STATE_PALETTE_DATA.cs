﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1773,9)
using System;
using System.Runtime.InteropServices;
using D3DCOLOR = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_STATE_PALETTE_DATA
    {
        public uint Count;
        public IntPtr pEntries;
    }
}
