﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(9136,1)
using System;

namespace DirectN
{
    [Flags]
    public enum CompressionCaps
    {
        CompressionCaps_CanQuality = 0x00000001,
        CompressionCaps_CanCrunch = 0x00000002,
        CompressionCaps_CanKeyFrame = 0x00000004,
        CompressionCaps_CanBFrame = 0x00000008,
        CompressionCaps_CanWindow = 0x00000010,
    }
}
