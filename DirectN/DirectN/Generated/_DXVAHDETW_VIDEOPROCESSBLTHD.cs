﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxvahd.h(1071,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDETW_VIDEOPROCESSBLTHD
    {
        public ulong pObject;
        public ulong pOutputSurface;
        public tagRECT TargetRect;
        public int OutputFormat;
        public uint ColorSpace;
        public uint OutputFrame;
        public uint StreamCount;
        public bool Enter;
    }
}
