﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ks.h(2090,3)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct __struct_ks_261__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public ushort Counter { get => InteropRuntime.GetUInt16(__bits, 0, 11); set => InteropRuntime.SetUInt16(value, __bits, 0, 11); }
        public ushort Reserved { get => InteropRuntime.GetUInt16(__bits, 11, 5); set => InteropRuntime.SetUInt16(value, __bits, 11, 5); }
    }
}
