using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    class StackQueue
    {
        static void Main()
        {
            Queue que = new Queue();
            que.Enqueue("Add");
            que.Enqueue("Moni");
            que.Enqueue("Add2");
            que.Enqueue("Dustu");
            foreach(var i in que)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Elements : " + que.Count);
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
            Console.WriteLine("Elements : " + que.Count);
            //Console.WriteLine(que.Peek());

            Console.WriteLine("Elements : "+ que.Count);
            Console.WriteLine("Elements of Stack");
            Stack stc = new Stack();
            stc.Push("Stack Add");
            stc.Push("Stack Moni");
            stc.Push("Stack Add2");
            stc.Push("Stack Dustu");
            foreach (var i in stc)
            {
                Console.WriteLine(i);
            }
            IEnumerator en = stc.GetEnumerator();
            Console.WriteLine("Using GetEnu........");
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
            Console.WriteLine("Elements : " + stc.Count);
            while (stc.Count > 0)
            {
                Console.WriteLine(stc.Pop());
            }
            Console.WriteLine("Elements : " + stc.Count);
            //Console.WriteLine(stc.Peek());

        }
    }
}
