﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(10455,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a1533d18-0ac1-4084-85b9-89a96116806b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ProtectedSession : ID3D12DeviceChild
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12ProtectedSession
        [PreserveSig]
        HRESULT GetStatusFence([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        D3D12_PROTECTED_SESSION_STATUS GetSessionStatus();
    }
}
