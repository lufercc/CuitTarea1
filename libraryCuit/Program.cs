﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryCuit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Book book1 = new Book();
            book1.title = "el libro";
            CD cd1 = new CD();
            cd1.title = "new cd";

            store.addItem(book1);
            store.addItem(cd1);

            store.showall();



            Console.ReadKey();


        }
    }
}
