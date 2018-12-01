﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(981,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6c14db80-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDraw
    {
        [PreserveSig]
        HRESULT Compact();
        
        [PreserveSig]
        HRESULT CreateClipper(uint __unnamed_0, ref IntPtr __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT CreatePalette(uint __unnamed_0, IntPtr __unnamed_1, ref IntPtr __unnamed_2, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_3);
        
        [PreserveSig]
        HRESULT CreateSurface(IntPtr __unnamed_0, ref IntPtr __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT DuplicateSurface(IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumDisplayModes(uint __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT EnumSurfaces(uint __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT FlipToGDISurface();
        
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDisplayMode(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFourCCCodes(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetGDISurface(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMonitorFrequency(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetScanLine(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVerticalBlankStatus(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0);
        
        [PreserveSig]
        HRESULT RestoreDisplayMode();
        
        [PreserveSig]
        HRESULT SetCooperativeLevel(IntPtr __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetDisplayMode(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT WaitForVerticalBlank(uint __unnamed_0, IntPtr __unnamed_1);
    }
}