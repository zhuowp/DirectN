﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4100,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITCOMMANDTOHWQUEUEFLAGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDICB_SUBMITCOMMANDTOHWQUEUEFLAGS__union_0__struct_0 __field_0 { get => InteropRuntime.Get<_D3DDDICB_SUBMITCOMMANDTOHWQUEUEFLAGS__union_0__struct_0>(__bits, 0, 32); set => InteropRuntime.Set<_D3DDDICB_SUBMITCOMMANDTOHWQUEUEFLAGS__union_0__struct_0>(value, __bits, 0, 32); }
        public uint Value { get => InteropRuntime.GetUInt32(__bits, 0, 32); set => InteropRuntime.SetUInt32(value, __bits, 0, 32); }
    }
}
