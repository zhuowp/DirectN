﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(3148,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_SHADER_0010
    {
        public D3D12DDI_HROOTSIGNATURE hRootSignature;
        public IntPtr pShaderCode;
        public D3D12DDIARG_CREATE_SHADER_0010__union_0 IOSignatures;
        public D3D12DDI_CREATE_SHADER_FLAGS Flags;
        public D3D12DDI_LIBRARY_REFERENCE_0010 LibraryReference;
    }
}
