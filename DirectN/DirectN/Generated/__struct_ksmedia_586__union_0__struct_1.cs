﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(6824,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ksmedia_586__union_0__struct_1
    {
        public uint PayloadSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)] 
        public byte[] Payload;
    }
}
