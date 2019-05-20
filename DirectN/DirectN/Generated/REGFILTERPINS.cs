﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(5027,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct REGFILTERPINS
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string strName;
        public bool bRendered;
        public bool bOutput;
        public bool bZero;
        public bool bMany;
        public IntPtr clsConnectsToFilter;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char strConnectsToPin;
        public uint nMediaTypes;
        public IntPtr lpMediaType;
    }
}
