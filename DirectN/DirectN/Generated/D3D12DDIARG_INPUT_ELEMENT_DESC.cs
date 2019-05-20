﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(2763,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_INPUT_ELEMENT_DESC
    {
        public uint InputSlot;
        public uint AlignedByteOffset;
        public int Format;
        public D3D12DDI_INPUT_CLASSIFICATION InputSlotClass;
        public uint InstanceDataStepRate;
        public uint InputRegister;
    }
}
