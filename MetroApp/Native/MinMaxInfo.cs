using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetroApp.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _MinMaxInfo
    {
        public _Point ptReserved;
        public _Point ptMaxSize;
        public _Point ptMaxPosition;
        public _Point ptMinTrackSize;
        public _Point ptMaxTrackSize;
    };
}
