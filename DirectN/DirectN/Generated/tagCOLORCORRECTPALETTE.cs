﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(6124,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOLORCORRECTPALETTE
    {
        public tagEMR emr;
        public uint ihPalette;
        public uint nFirstEntry;
        public uint nPalEntries;
        public uint nReserved;
    }
}
