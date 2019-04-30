using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {

            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.previous = tail;
                tail.next = p;
                tail = p;
               
            }
            return;
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
            }
            return;
        } // end of addToHead

        public DLLNode removeHead()
        {
            if (head == null) return (null);
            DLLNode p = head;
            head = head.next;
            head.previous = null;
            p.next = null;
            ordered();
            return (p);
                                        
        } // removeHead

        public DLLNode removeTail()
        {
            if (this.tail == null) return (null);
            DLLNode p = tail;
            tail = tail.previous;
            p.previous = null;
            tail.next = null;
            ordered();
            return (p);
            
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
         public void ordered()
        {
            int count = 0;
            DLLNode p = head;
            while (p != null)
            {
                count++;
                p.number = count;
                p = p.next;
            }
        }

        public DLLNode search(String str)
        {
            int count = 0;
            DLLNode p = head;
            while (p != null)
            {
                count++;
                p.number = count;
                if (p.str == str) break;
                p = p.next;
                
            }
            return (p);
        } // end of search (return pionter to the node);

        public DLLNode removeNode(DLLNode p)
        { // removing the node p.
            DLLNode rnode = null;
            if (p!=null)
            {
                p = search(p.str);
                if (p!=null)
                {
                    rnode = p;
                    if (p.next == null)
                    {
                        p = this.tail;
                        this.tail = this.tail.previous;
                        this.tail.next = null;
                        p.previous = null;
                        return rnode;
                    }
                    if (p.previous == null)
                    {
                        p = this.head;
                        this.head = this.head.next;
                        p.next = null;
                        this.head.previous = null;
                        return rnode;
                    }
                    p.next.previous = p.previous;
                    p.previous.next = p.next;
                    p.next = null;
                    p.previous = null;
                }
            }
            ordered();
             return rnode;
        } // end of remove a node

    } // end of DLList class
}
