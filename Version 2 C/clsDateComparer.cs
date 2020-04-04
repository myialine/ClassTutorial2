using System;
using System.Collections.Generic;

namespace Version_2_C
{
    public sealed partial class ClsDateComparer : IComparer<clsWork>
    {
        private ClsDateComparer()
        {
        }

        public static readonly ClsDateComparer Instance = new ClsDateComparer();

        public int Compare(clsWork x, clsWork y)
        {
            // long version:
            //DateTime lcDateX = x.Date;
            //DateTime lcDateY = y.Date;
            //return lcDateX.CompareTo(lcDateY);

            // short version:
            return x.Date.CompareTo(y.Date);
        }
    }

    public sealed partial class ClsDDateComparer : IComparer<clsWork>
    // descending date comparer, i.e. reverse sorting order!
    {
        private ClsDDateComparer()
        {
        }

        public static readonly ClsDDateComparer Instance = new ClsDDateComparer();

        public int Compare(clsWork x, clsWork y)
        {
            return y.Date.CompareTo(x.Date);
        }
    }
}
