using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLLNode
    {
        public String str;   // field of the node
        public int number;   
        public DLLNode next; // pointer to the next node
        public DLLNode previous; // pointer to the previous node
        public DLLNode (String str)
        {
            this.str = str;
            next = null;
            previous = null;
        } // end of constructor
    } // end of class DLLNode
}
