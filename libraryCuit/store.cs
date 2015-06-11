using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryCuit
{
    public class Store
    {
        public List<ItemSale> itemsales = new List<ItemSale>();

        // this metod agree te itemsale on the list
        public void addItem(ItemSale Isales)
        {
            itemsales.Add(Isales);
        }

        public List<ItemSale> showall()
        {
            foreach (var item in itemsales)
            {
                Console.WriteLine(item);
            }
            return itemsales;
        }

        public ItemSale returnItem(string title)
        {
            ItemSale res = null; 
            foreach (var item in itemsales)
            {
                if (item.title == title)
                {
                    res = item;
                }
            }

            return res;
        }

    }
}
