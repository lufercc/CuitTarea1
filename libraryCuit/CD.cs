using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryCuit
{
    public class CD : ItemSale
    {
        public int durationminutes { get; set; }
        public string musicoBand { get; set; }


        public override string ToString()
        {
            return base.title + "title " + this.musicoBand + " " + base.price;
        }
       
    }
}
