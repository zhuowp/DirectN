﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12shader.h(177,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3D12_LIBRARY_DESC
    {
        [MarshalAs(UnmanagedType.LPStr)] 
        public string Creator;
        public uint Flags;
        public uint FunctionCount;
    }
}
