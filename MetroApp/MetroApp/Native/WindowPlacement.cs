using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MetroApp.Native
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _WindowPlacement
    {
        public int length;
        public int flags;
        public int showCmd;
        public _Point minPosition;
        public _Point maxPosition;
        public _Rect normalPosition;
    }
}
