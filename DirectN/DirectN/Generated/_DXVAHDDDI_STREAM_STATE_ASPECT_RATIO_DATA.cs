﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1786,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHDDDI_STREAM_STATE_ASPECT_RATIO_DATA
    {
        public bool Enable;
        public _DXVAHDDDI_RATIONAL SourceAspectRatio;
        public _DXVAHDDDI_RATIONAL DestinationAspectRatio;
    }
}
