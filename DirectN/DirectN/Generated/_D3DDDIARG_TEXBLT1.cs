﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2052,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_TEXBLT1
    {
        public IntPtr hDstResource;
        public IntPtr hSrcResource;
        public uint CubeMapFace;
        public tagPOINT DstPoint;
        public tagRECT SrcRect;
        public uint CopyFlags;
    }
}
