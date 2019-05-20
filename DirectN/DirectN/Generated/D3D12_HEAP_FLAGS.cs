﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2396,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_HEAP_FLAGS
    {
        D3D12_HEAP_FLAG_NONE = 0x00000000,
        D3D12_HEAP_FLAG_SHARED = 0x00000001,
        D3D12_HEAP_FLAG_DENY_BUFFERS = 0x00000004,
        D3D12_HEAP_FLAG_ALLOW_DISPLAY = 0x00000008,
        D3D12_HEAP_FLAG_SHARED_CROSS_ADAPTER = 0x00000020,
        D3D12_HEAP_FLAG_DENY_RT_DS_TEXTURES = 0x00000040,
        D3D12_HEAP_FLAG_DENY_NON_RT_DS_TEXTURES = 0x00000080,
        D3D12_HEAP_FLAG_HARDWARE_PROTECTED = 0x00000100,
        D3D12_HEAP_FLAG_ALLOW_WRITE_WATCH = 0x00000200,
        D3D12_HEAP_FLAG_ALLOW_SHADER_ATOMICS = 0x00000400,
        D3D12_HEAP_FLAG_ALLOW_ALL_BUFFERS_AND_TEXTURES = 0x00000000,
        D3D12_HEAP_FLAG_ALLOW_ONLY_BUFFERS = 0x000000C0,
        D3D12_HEAP_FLAG_ALLOW_ONLY_NON_RT_DS_TEXTURES = 0x00000044,
        D3D12_HEAP_FLAG_ALLOW_ONLY_RT_DS_TEXTURES = 0x00000084,
    }
}
