﻿// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(776,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 240)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0 DmaCompleted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0>(__bits, 0, 96); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_0>(value, __bits, 0, 96); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1 DmaPreempted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1>(__bits, 0, 128); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_1>(value, __bits, 0, 128); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2 DmaFaulted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2>(__bits, 0, 128); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_2>(value, __bits, 0, 128); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3 CrtcVsync { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3>(__bits, 0, 160); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_3>(value, __bits, 0, 160); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4 DisplayOnlyVsync { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4>(__bits, 0, 32); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_4>(value, __bits, 0, 32); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5 CrtcVsyncWithMultiPlaneOverlay { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5>(__bits, 0, 1920); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_5>(value, __bits, 0, 1920); }
        public _DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS DisplayOnlyPresentProgress { get => InteropRuntime.Get<_DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS>(__bits, 0, 64); set => InteropRuntime.Set<_DXGKARGCB_PRESENT_DISPLAYONLY_PROGRESS>(value, __bits, 0, 64); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6 MiracastEncodeChunkCompleted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6>(__bits, 0, 512); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6>(value, __bits, 0, 512); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7 DmaPageFaulted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7>(__bits, 0, 512); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_7>(value, __bits, 0, 512); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8 CrtcVsyncWithMultiPlaneOverlay2 { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8>(__bits, 0, 512); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8>(value, __bits, 0, 512); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9 MonitoredFenceSignaled { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9>(__bits, 0, 64); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_9>(value, __bits, 0, 64); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10 HwContextListSwitchCompleted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10>(__bits, 0, 128); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_10>(value, __bits, 0, 128); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11 HwQueuePageFaulted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11>(__bits, 0, 480); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_11>(value, __bits, 0, 480); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12 PeriodicMonitoredFenceSignaled { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12>(__bits, 0, 64); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_12>(value, __bits, 0, 64); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13 SchedulingLogInterrupt { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13>(__bits, 0, 64); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_13>(value, __bits, 0, 64); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14 GpuEngineTimeout { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14>(__bits, 0, 64); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_14>(value, __bits, 0, 64); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15 SuspendContextCompleted { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15>(__bits, 0, 128); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_15>(value, __bits, 0, 128); }
        public _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16 Reserved { get => InteropRuntime.Get<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16>(__bits, 0, 512); set => InteropRuntime.Set<_DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_16>(value, __bits, 0, 512); }
    }
}
