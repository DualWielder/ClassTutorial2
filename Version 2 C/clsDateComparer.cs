using System;
using System.Collections.Generic;

namespace Version_2_C
{
    public sealed class clsDateComparer : IComparer<clsWork>
    {
        private clsDateComparer()
        {

        }

        public static readonly clsDateComparer Instance = new clsDateComparer();
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

    class clsDDateComparer : IComparer<clsWork>
    // descending date comparer, i.e. reverse sorting order!
    {
        public int Compare(clsWork x, clsWork y)
        {
            return y.Date.CompareTo(x.Date);
        }
    }
}
