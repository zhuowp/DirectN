﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(9791,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_VIDEO_MOTION_ESTIMATOR_0053
    {
        public uint NodeMask;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE_0053 BlockSize;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_0053 Precision;
        public D3D12DDI_VIDEO_MOTION_ESTIMATOR_DIFFERENCES_METRIC_0053 DifferencesMetric;
        public D3D12DDI_VIDEO_SIZE_RANGE_0032 SizeRange;
        public D3D12DDI_HPROTECTEDRESOURCESESSION_0030 hDrvProtectedResourceSession;
    }
}