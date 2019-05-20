﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(12393,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_RAY_FLAGS
    {
        D3D12_RAY_FLAG_NONE = 0x00000000,
        D3D12_RAY_FLAG_FORCE_OPAQUE = 0x00000001,
        D3D12_RAY_FLAG_FORCE_NON_OPAQUE = 0x00000002,
        D3D12_RAY_FLAG_ACCEPT_FIRST_HIT_AND_END_SEARCH = 0x00000004,
        D3D12_RAY_FLAG_SKIP_CLOSEST_HIT_SHADER = 0x00000008,
        D3D12_RAY_FLAG_CULL_BACK_FACING_TRIANGLES = 0x00000010,
        D3D12_RAY_FLAG_CULL_FRONT_FACING_TRIANGLES = 0x00000020,
        D3D12_RAY_FLAG_CULL_OPAQUE = 0x00000040,
        D3D12_RAY_FLAG_CULL_NON_OPAQUE = 0x00000080,
    }
}
