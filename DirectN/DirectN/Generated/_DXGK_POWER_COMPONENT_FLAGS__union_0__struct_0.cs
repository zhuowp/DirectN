﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(2826,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_POWER_COMPONENT_FLAGS__union_0__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public uint Reserved0 { get => InteropRuntime.GetUInt32(__bits, 0, 1); set => InteropRuntime.SetUInt32(value, __bits, 0, 1); }
        public uint DriverCompletesFStateTransition { get => InteropRuntime.GetUInt32(__bits, 1, 1); set => InteropRuntime.SetUInt32(value, __bits, 1, 1); }
        public uint TransitionTo_F0_OnDx { get => InteropRuntime.GetUInt32(__bits, 2, 1); set => InteropRuntime.SetUInt32(value, __bits, 2, 1); }
        public uint NoDebounce { get => InteropRuntime.GetUInt32(__bits, 3, 1); set => InteropRuntime.SetUInt32(value, __bits, 3, 1); }
        public uint ActiveInD3 { get => InteropRuntime.GetUInt32(__bits, 4, 1); set => InteropRuntime.SetUInt32(value, __bits, 4, 1); }
        public uint Reserved { get => InteropRuntime.GetUInt32(__bits, 5, 27); set => InteropRuntime.SetUInt32(value, __bits, 5, 27); }
    }
}
