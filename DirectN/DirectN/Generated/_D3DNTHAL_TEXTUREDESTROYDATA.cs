﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dnthal.h(327,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_TEXTUREDESTROYDATA
    {
        public IntPtr dwhContext;
        public IntPtr dwHandle;
        public HRESULT ddrval;
    }
}
