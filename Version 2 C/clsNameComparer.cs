using System;
using System.Collections.Generic;

namespace Version_2_C
{
    public sealed partial class ClsNameComparer : IComparer<clsWork>
    {
        private ClsNameComparer()
        {
        }

        public static readonly ClsNameComparer Instance = new ClsNameComparer();

        public int Compare(clsWork x, clsWork y)
        {
            string lcNameX = x.Name;
            string lcNameY = y.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
