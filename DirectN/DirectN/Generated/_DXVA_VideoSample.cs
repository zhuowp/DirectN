﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1815,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA_VideoSample
    {
        public long rtStart;
        public long rtEnd;
        public _DXVA_SampleFormat SampleFormat;
        public IntPtr lpDDSSrcSurface;
    }
}
