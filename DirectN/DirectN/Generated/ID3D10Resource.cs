﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10.h(1505,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b7e4c01-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Resource : ID3D10DeviceChild
    {
        // ID3D10DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Out_ */ out ID3D10Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D10Resource
        [PreserveSig]
        void GetType(/* [annotation] _Out_ */ out D3D10_RESOURCE_DIMENSION rType);
        
        [PreserveSig]
        void SetEvictionPriority(/* [annotation] _In_ */ uint EvictionPriority);
        
        [PreserveSig]
        uint GetEvictionPriority();
    }
}
