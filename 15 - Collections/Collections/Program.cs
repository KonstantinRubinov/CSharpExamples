using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList items = new ArrayList();
            //items.Add(100);
            //items.Add("Hello");
            //items.Add(12.34);
            //Console.WriteLine(items[0]);

            //List<int> items = new List<int>();
            //items.Add(100);
            //items.Add(200);
            //items.Add(300);
            //Console.WriteLine(items[0]);


            //Hashtable items = new Hashtable();
            //items.Add(10, "Hi");
            //items.Add(20, "Bye");
            //Console.WriteLine(items[20]);

            //Dictionary<int, string> items = new Dictionary<int, string>();
            //items.Add(10, "Hi");
            //items.Add(20, "Bye");
            //Console.WriteLine(items[20]);

            //Stack items = new Stack(); // Last In First Out (LIFO)
            //items.Push(100);
            //items.Push("Hi");
            //items.Push(12.34);
            //Console.WriteLine(items.Peek());
            //Console.WriteLine(items.Pop());
            //Console.WriteLine(items.Pop());

            //Stack<int> items = new Stack<int>(); // Last In First Out (LIFO)
            //items.Push(100);
            //items.Push(200);
            //items.Push(300);
            //Console.WriteLine(items.Peek());
            //Console.WriteLine(items.Pop());
            //Console.WriteLine(items.Pop());

            //Queue items = new Queue(); // First In First Out (FIFO)
            //items.Enqueue(100);
            //items.Enqueue("Hi");
            //items.Enqueue(12.34);
            //Console.WriteLine(items.Peek());
            //Console.WriteLine(items.Dequeue());
            //Console.WriteLine(items.Dequeue());

            //Console.WriteLine(items[0]);

            //Queue<int> items = new Queue<int>(); // First In First Out (FIFO)
            //items.Enqueue(100);
            //items.Enqueue(200);
            //items.Enqueue(300);
            //Console.WriteLine(items.Peek());
            //Console.WriteLine(items.Dequeue());
            //Console.WriteLine(items.Dequeue());

            //Dictionary<int, string> items = new Dictionary<int, string>();
            //items.Add(100, "aaa");
            //items.Add(200, "bbb");
            //items.Add(300, "ccc");
            //if (!items.ContainsKey(200))
            //    items.Add(200, "bbb");
            //else
            //    Console.WriteLine("Exists...");

            //KeyValuePair<int, string> pair1 = new KeyValuePair<int, string>(200, "bbb");
            //Console.WriteLine(items.Contains(pair1));

            //KeyValuePair<int, string> pair2 = new KeyValuePair<int, string>(200, "ddd");
            //Console.WriteLine(items.Contains(pair2));

            //KeyValuePair<int, string> pair3 = new KeyValuePair<int, string>(400, "bbb");
            //Console.WriteLine(items.Contains(pair3));

            //KeyValuePair<int, string> pair4 = new KeyValuePair<int, string>(400, "ddd");
            //Console.WriteLine(items.Contains(pair4));

            //Names names = new Names();
            //names.AddName("Moishe");
            //names.AddName("Haim");
            //names.AddName("Dana");
            //names.AddName("Kipi");
            //Console.WriteLine(names[0]);



            SortedList<int, string> items = new SortedList<int, string>();
            items.Add(200, "aaa");
            items.Add(300, "bbb");
            items.Add(100, "ccc");

            foreach (KeyValuePair<int, string> item in items)
            {
                Console.WriteLine(item.Key + " --> " + item.Value);
            }

        }
    }
}
