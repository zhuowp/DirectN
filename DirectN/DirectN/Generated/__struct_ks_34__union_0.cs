﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ks.h(1758,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_34__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint FileAlignment { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
        public int FramePitch { get => InteropRuntime.GetInt32(__bits, 0, 32); set => InteropRuntime.SetInt32(value, __bits, 0, 32); }
    }
}
