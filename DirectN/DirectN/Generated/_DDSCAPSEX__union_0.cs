﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddraw.h(356,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDSCAPSEX__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint dwCaps4 { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public uint dwVolumeDepth { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
