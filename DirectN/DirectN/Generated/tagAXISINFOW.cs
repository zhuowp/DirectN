﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(4390,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagAXISINFOW
    {
        public int axMinValue;
        public int axMaxValue;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)] 
        public string axAxisName;
    }
}
