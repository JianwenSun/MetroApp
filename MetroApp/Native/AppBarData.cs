using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MetroApp.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _AppBarData
    {
        public int cbSize;
        public IntPtr hWnd;
        public int uCallbackMessage;
        public int uEdge;
        public _Rect rc;
        public bool lParam;
    }
}
