using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** 
 * this class is comparer of  two object based on the metod ToString
 * 
 * I create this class on UnitTestProyect 
 * because this class no is important for the proyect 
 * but is importat for the test
 * */
namespace UnitTestProject1
{
    class ItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }
}
