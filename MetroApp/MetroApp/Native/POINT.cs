using System;
using System.Runtime.InteropServices;

namespace MetroApp.Native
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct _Point
    {
        private int _x;
        private int _y;

        public _Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is _Point)
            {
                var point = (_Point)obj;

                return point._x == _x && point._y == _y;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return _x.GetHashCode() ^ _y.GetHashCode();
        }

        public static bool operator ==(_Point a, _Point b)
        {
            return a._x == b._x && a._y == b._y;
        }

        public static bool operator !=(_Point a, _Point b)
        {
            return !(a == b);
        }
    }
}