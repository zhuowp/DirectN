﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3541,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_RENDERFLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint ResizeCommandBuffer { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint ResizeAllocationList { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint ResizePatchLocationList { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint NullRendering { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 4, 28); set => InteropRuntime.SetUInt32(value, __bits, 4, 28); }
    }
}
