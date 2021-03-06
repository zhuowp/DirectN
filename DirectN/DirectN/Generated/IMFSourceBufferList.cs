﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(3742,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("249981f8-8325-41f3-b80c-3b9e3aad0cbe"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBufferList
    {
        [PreserveSig]
        uint GetLength();
        
        [PreserveSig]
        IMFSourceBuffer GetSourceBuffer(/* [annotation][in] _In_ */ uint index);
    }
}
