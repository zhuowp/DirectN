﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(1948,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_MOTIONCOMP_LOCAL = DirectN._DD_MOTIONCOMP_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DESTROYMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public HRESULT ddRVal;
    }
}
