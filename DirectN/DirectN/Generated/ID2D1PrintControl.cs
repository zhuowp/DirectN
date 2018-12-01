﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(873,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    /// <summary>
    /// Converts Direct2D primitives stored in an ID2D1CommandList into a fixed page representation. The print sub-system then consumes the primitives.
    /// </summary>
    [Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1PrintControl
    {
        [PreserveSig]
        HRESULT AddPage(/* _In_ */ ID2D1CommandList commandList, D2D_SIZE_F pageSize, /* _In_opt_ */ ref IStream pagePrintTicketStream, /* _Out_opt_ */ out ulong tag1, /* _Out_opt_ */ out ulong tag2);
        
        [PreserveSig]
        HRESULT Close();
    }
}