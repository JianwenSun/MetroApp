using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace MetroApp.Native
{
    [StructLayout(LayoutKind.Sequential, Pack = 0)]
    public struct _Rect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public static readonly _Rect Empty = new _Rect();

        public int Width
        {
            get { return Math.Abs(right - left); }  // Abs needed for BIDI OS
        }

        public int Height
        {
            get { return bottom - top; }
        }

        public _Rect(int left, int top, int right, int bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public _Rect(_Rect rcSrc)
        {
            left = rcSrc.left;
            top = rcSrc.top;
            right = rcSrc.right;
            bottom = rcSrc.bottom;
        }

        public bool IsEmpty
        {
            get
            {
                // BUGBUG : On Bidi OS (hebrew arabic) left > right
                return left >= right || top >= bottom;
            }
        }

        public override string ToString()
        {
            if (this == Empty) 
                return "RECT {Empty}";
            return "RECT { left : " + left + " / top : " + top + " / right : " + right + " / bottom : " + bottom + " }";
        }

        /// <summary> Determine if 2 RECT are equal (deep compare) </summary>
        public override bool Equals(object obj)
        {
            if (!(obj is _Rect)) { return false; }
            return (this == (_Rect)obj);
        }

        /// <summary>Return the HashCode for this struct (not garanteed to be unique)</summary>
        public override int GetHashCode()
        {
            return left.GetHashCode() + top.GetHashCode() + right.GetHashCode() + bottom.GetHashCode();
        }

        public static bool operator ==(_Rect rect1, _Rect rect2)
        {
            return (rect1.left == rect2.left && rect1.top == rect2.top && rect1.right == rect2.right && rect1.bottom == rect2.bottom);
        }

        public static bool operator !=(_Rect rect1, _Rect rect2)
        {
            return !(rect1 == rect2);
        }


    }
}