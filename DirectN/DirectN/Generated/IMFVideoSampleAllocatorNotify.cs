﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(2773,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a792cdbe-c374-4e89-8335-278e7b9956a4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorNotify
    {
        [PreserveSig]
        HRESULT NotifyRelease();
    }
}
