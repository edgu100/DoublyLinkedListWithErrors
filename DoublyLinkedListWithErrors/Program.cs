using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace DoublyLinkedListWithErrors
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Display the DDList:");
            DLList p = initialArr("C:/Users/edgu1/Desktop/222525.txt");
            Console.WriteLine("///////////////////////////////////");

            Console.WriteLine("Enter the search number:");
            string sn = Console.ReadLine();
            DLLNode node=search(p,sn);
            Console.WriteLine((node == null) ? "This number is not exist!" : ("The position of the  " + node.str + " " + "is  " + node.number));      
            Console.WriteLine("///////////////////////////////////");

            Console.WriteLine("Removed number:");
            DLLNode nodehead=removeHead(p);
            Console.WriteLine(nodehead.str);
            Console.WriteLine("Display the current DDList:");
            printsAppearNumbers(p);
            Console.WriteLine("///////////////////////////////////");

            /*DLLNode nodetail = removeTail(p);
            Console.WriteLine(nodetail);*/
            Console.WriteLine("Enter the node the you want to remove,please:");
            string r = Console.ReadLine();
            DLLNode delnode = new DLLNode(r);
            removeNode(p, delnode);
            Console.WriteLine("Display the current DDList:");
            printsAppearNumbers(p);
            Console.WriteLine("///////////////////////////////////");
        }

        public static DLList initialArr(String filePath)
        {
            FileStream f = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
     
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines              
                while ((line= m_streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // process every line
                    DLLNode p = new DLLNode(line);
                    pDLL.addToTail(p);
                }
               // Console.WriteLine("===============");
                m_streamReader.Close();
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors"+e.ToString ());
            }
            return pDLL;
        }

        public static void printsAppearNumbers(DLList dll1)
        {
            DLLNode head = dll1.head;
          //  ArrayList  list1 = new ArrayList ();
            while (head.next != null)
            {
                Console.WriteLine(head.str);
                head = head.next;
            }
            Console.WriteLine(head.str);
        }

        public static DLLNode search(DLList dllList, String str)
        {
            return dllList.search(str);
        }

        private static DLLNode removeHead(DLList dlll)
        {
            return dlll.removeHead();
        }

        private static DLLNode removeTail(DLList dlll)
        {
            return dlll.removeTail();
        }

        public static void removeNode(DLList dlll,DLLNode p)
        {
            dlll.removeNode(p);
        }


    }
}
