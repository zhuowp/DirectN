﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3084,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_DECODER_DESC
    {
        public Guid Guid;
        public uint SampleWidth;
        public uint SampleHeight;
        public int OutputFormat;
    }
}
