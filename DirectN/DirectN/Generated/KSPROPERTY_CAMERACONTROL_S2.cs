﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(5721,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_S2
    {
        public KSIDENTIFIER Property;
        public int Value1;
        public uint Flags;
        public uint Capabilities;
        public int Value2;
    }
}
