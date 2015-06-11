using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using libraryCuit;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {

        // book1 and cd 1
        Book book1 = new Book();
        CD cd1 = new CD();

        string spectetTiteb = "titulo1";
        int spectetpriceb = 100;

        string spectedtitlecd = "titlecd1";
        int spectedpricecd = 200;

        public UnitTest2()
        {

            // asignation of book1 and cd1
            book1.title = spectetTiteb;
            book1.price = spectetpriceb;

            cd1.title = spectedtitlecd;
            cd1.price = spectedpricecd;
        }
        [TestMethod]
        public void testItem()
        {

            // comparer that the book 1 is a same title 
            Assert.AreEqual(spectetTiteb, book1.title);
            // comparer that the book 1 is a same price 
            Assert.AreEqual(spectetpriceb, book1.price);
            // comparer that the cd 1 is a same title 
            Assert.AreEqual(spectedtitlecd, cd1.title);
            // comparer that the cd 1 is a same price 
            Assert.AreEqual(spectedpricecd, cd1.price);
        }
        [TestMethod]
        public void testlist()
        {

            // new object for comparer
            // object for actual 
            Book b1 = new Book { title = "hello1", price = 100 };
            Book b2 = new Book { title = "hello2", price = 101 };
            Book b3 = new Book { title = "hello3", price = 102 };
            // object for espected
            Book b4 = new Book { title = "hello1", price = 100 };
            Book b5 = new Book { title = "hello2", price = 101 };
            Book b6 = new Book { title = "hello3", price = 102 };


            // input object on store
            Store store = new Store();
            store.addItem(b2);
            store.addItem(b1);
            store.addItem(b3);

            // input object on list espcted
            List<ItemSale> espectetlist = new List<ItemSale>();
            espectetlist.Add(b5);
            espectetlist.Add(b4);
            espectetlist.Add(b6);
            //create the object for comparer
            ItemComparer com = new ItemComparer();

            CollectionAssert.AreEqual(espectetlist, store.showall(), com);
        }
        [TestMethod]
        public void testforreturobj()
        {
            Book b1 = new Book { title = "hello1", price = 100 };
            Book b2 = new Book { title = "hello2", price = 101 };
            Book b3 = new Book { title = "hello3", price = 102 };

            Store store = new Store();
            store.addItem(b2);
            store.addItem(b1);
            store.addItem(b3);

            var actual = store.returnItem("hello1");
            var espected = b1;

            Assert.AreEqual(b1, actual);

        }

    }
}
