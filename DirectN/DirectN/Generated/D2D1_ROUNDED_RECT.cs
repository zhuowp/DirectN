﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1.h(665,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_ROUNDED_RECT
    {
        public D2D_RECT_F rect;
        public float radiusX;
        public float radiusY;
    }
}
