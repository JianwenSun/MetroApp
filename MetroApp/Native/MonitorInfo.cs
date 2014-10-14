using MetroApp.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MetroApp.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class _MonitorInfo
    {
        public int cbSize = Marshal.SizeOf(typeof(_MonitorInfo));
        public _Rect rcMonitor = new _Rect();
        public _Rect rcWork = new _Rect();
        public int dwFlags = 0;

        public enum MonitorOptions : uint
        {
            MONITOR_DEFAULTTONULL = 0x00000000,
            MONITOR_DEFAULTTOPRIMARY = 0x00000001,
            MONITOR_DEFAULTTONEAREST = 0x00000002
        }
    }
}
