﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(20162,9)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRVIDEOSTREAMINFO
    {
        public IntPtr pddsVideoSurface;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwStrmID;
        public float fAlpha;
        public _DDCOLORKEY ddClrKey;
        public _NORMALIZEDRECT rNormal;
    }
}
