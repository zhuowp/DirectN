﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfobjects.h(4293,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a27003d0-2354-4f2a-8d6a-ab7cff15437e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRemoteAsyncCallback
    {
        [PreserveSig]
        HRESULT Invoke(/* [in] */ HRESULT hr, /* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pRemoteResult);
    }
}
