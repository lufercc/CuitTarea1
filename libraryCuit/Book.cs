using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryCuit
{
    class Book : ItemSale
    {
        public int pagenumber { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }

        

        public override string ToString()
        {
            return base.title +" " + this.author +" "+base.price ;
        }

    }
}
