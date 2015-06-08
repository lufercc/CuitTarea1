using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryCuit
{
    class store
    {
        public List<ItemSale> itemsales = new List<ItemSale>();

        // this metod agree te itemsale on the list
        public void addItem(ItemSale Isales)
        {
            itemsales.Add(Isales);
        }

        public void showall()
        {
            foreach (var item in itemsales)
            {
                Console.WriteLine(item);
            }
        }
    }
}
