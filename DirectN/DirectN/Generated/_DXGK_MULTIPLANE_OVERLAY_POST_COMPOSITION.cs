﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5500,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_POST_COMPOSITION
    {
        public _DXGK_MULTIPLANE_OVERLAY_POST_COMPOSITION_FLAGS Flags;
        public tagRECT SrcRect;
        public tagRECT DstRect;
        public _D3DDDI_ROTATION Rotation;
    }
}
