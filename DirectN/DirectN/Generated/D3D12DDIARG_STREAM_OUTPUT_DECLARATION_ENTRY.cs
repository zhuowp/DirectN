﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2004,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_STREAM_OUTPUT_DECLARATION_ENTRY
    {
        public uint Stream;
        public uint OutputSlot;
        public uint RegisterIndex;
        public byte RegisterMask;
    }
}
