﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(1561,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMT_WEBSTREAM_FORMAT
    {
        public ushort cbSize;
        public ushort cbSampleHeaderFixedData;
        public ushort wVersion;
        public ushort wReserved;
    }
}