﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfplay.h(1086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MFP_POSITION_SET_EVENT
    {
        public MFP_EVENT_HEADER header;
        public IntPtr pMediaItem;
    }
}
