﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(11783,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_META_COMMAND_DESC
    {
        public Guid Id;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public string Name;
        public D3D12_GRAPHICS_STATES InitializationDirtyState;
        public D3D12_GRAPHICS_STATES ExecutionDirtyState;
    }
}
