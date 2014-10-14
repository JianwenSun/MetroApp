using System.Runtime.InteropServices;

namespace MetroApp.Native
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _WindowState
    {
        public _Point ptReserved;
        public _Point ptMaxSize;
        public _Point ptMaxPosition;
        public _Point ptMinTrackSize;
        public _Point ptMaxTrackSize;
    };
}