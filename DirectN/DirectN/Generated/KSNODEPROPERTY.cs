﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(2884,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY
    {
        public KSIDENTIFIER Property;
        public uint NodeId;
        public uint Reserved;
    }
}
