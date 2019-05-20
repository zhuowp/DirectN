﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(1324,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDATARANGE_AUDIO
    {
        public KSDATAFORMAT DataRange;
        public uint MaximumChannels;
        public uint MinimumBitsPerSample;
        public uint MaximumBitsPerSample;
        public uint MinimumSampleFrequency;
        public uint MaximumSampleFrequency;
    }
}
