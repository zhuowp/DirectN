﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(8076,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_SET_TIMING_PATH_INFO__union_2__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint RecheckMPO { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 1, 31); set => InteropRuntime.SetUInt32(value, __bits, 1, 31); }
    }
}