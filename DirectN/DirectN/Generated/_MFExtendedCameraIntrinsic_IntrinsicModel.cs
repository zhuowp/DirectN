﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(20365,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFExtendedCameraIntrinsic_IntrinsicModel
    {
        public uint Width;
        public uint Height;
        public uint SplitFrameId;
        public _MFCameraIntrinsic_CameraModel CameraModel;
    }
}
