﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(20160,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("de5072ee-dbe3-46dc-8a87-b6f631194751"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivitiesReportCallback
    {
        [PreserveSig]
        HRESULT OnActivitiesReport(/* [annotation][in] _In_ */ IMFSensorActivitiesReport sensorActivitiesReport);
    }
}
