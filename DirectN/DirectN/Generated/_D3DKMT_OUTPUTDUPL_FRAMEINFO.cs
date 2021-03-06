﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3629,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OUTPUTDUPL_FRAMEINFO
    {
        public long LastPresentTime;
        public long LastMouseUpdateTime;
        public uint AccumulatedFrames;
        public bool RectsCoalesced;
        public bool ProtectedContentMaskedOut;
        public _D3DKMT_OUTPUTDUPL_POINTER_POSITION PointerPosition;
        public uint TotalMetadataBufferSize;
        public uint PointerShapeBufferSize;
    }
}
