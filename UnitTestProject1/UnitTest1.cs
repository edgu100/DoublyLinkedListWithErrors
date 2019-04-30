using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;
using System.IO;
using System.Collections;




namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void Testaddtotail()
        {
            //Program ss = new Program();
             /// Read the txt and insert into dllist   
             string[] str = new string[30];
             int i = 0;
             FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
             DLList pDLL = new DLList();
             string line;
             try
             {
                 StreamReader m_streamReader = new StreamReader(f);
                 //StreamReader read txt
                 m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                 //read from head to tail by lines        
                 while ((line = m_streamReader.ReadLine()) != null)
                 {

                     DLLNode d = new DLLNode(line);
                     pDLL.addToTail(d);
                     str[i] = line;
                     i++;
                 }
                 m_streamReader.Close();
             }
             catch (FileNotFoundException e)
             {
                 Console.WriteLine("errors" + e.ToString());
             }
            
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;
         
            while (head.next != null)
            {
               
                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;

            
            /// /////////////////////////////////////
            bool match=false;
            for (int k = 0; k < i; k++) {
                if (str[k] == str2[k]) { match = true; }
                else { match = false; break; }           
            }
            Assert.AreEqual(true, match);
        }

        [TestMethod]
        public void Testaddtotail2()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode tail = pDLL.tail;

            while (tail.previous != null)
            {

                str2[j] = tail.str;
                j++;
                tail = tail.previous;
            }
            str2[j] = tail.str;
            /// /////////////////////////////////////
            bool match1 = false;
            for (int k = 0; k < i; k++)
            {
                if (str[k] == str2[j]) { match1 = true; j--; }
                else { match1 = false; break; }
            }
            Assert.AreEqual(true, match1);
        }

        [TestMethod]
        public void Testaddtohead()
            {
                string[] str = new string[30];
                int i = 0;
                FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
                DLList pDLL = new DLList();
                string line;
                try
                {
                    StreamReader m_streamReader = new StreamReader(f);
                    //StreamReader read txt
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    //read from head to tail by lines        
                    while ((line = m_streamReader.ReadLine()) != null)
                    {

                        DLLNode d = new DLLNode(line);
                        pDLL.addToHead(d);
                        str[i] = line;
                        i++;
                    }
                    m_streamReader.Close();
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("errors" + e.ToString());
                }

                ////////////////////////
                string[] str2 = new string[20];
                int j = 0;
                DLLNode head = pDLL.head;

                while (head.next != null)
                {

                    str2[j] = head.str;
                    j++;
                    head = head.next;
                }
                Console.WriteLine(head.str);
                str2[j] = head.str;


                /// /////////////////////////////////////
                bool match1 = false;
                for (int k =0; k <i; k++)
                {
                    if (str[k] == str2[j]) { match1 = true; j--; }
                    else { match1 = false; break; }
                }
                Assert.AreEqual(true, match1);
            }

        [TestMethod]
        public void Testaddtohead2()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToHead(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode tail = pDLL.tail;

            while (tail.previous != null)
            {

                str2[j] = tail.str;
                j++;
                tail = tail.previous;
            }
            Console.WriteLine(tail.str);
            str2[j] = tail.str;


            /// /////////////////////////////////////
            bool match = false;
            for (int k = 0; k < i; k++)
            {
                if (str[k] == str2[k]) { match = true; }
                else { match = false; break; }
            }
            Assert.AreEqual(true, match);
        }

        [TestMethod]
        public void Testremovehead()
            {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL.removeHead();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;


            /// /////////////////////////////////////
            bool match1 = false;
            for (int k = 0; k < j; k++)
            {
                if (str[k+1] == str2[k]) { match1 = true;  }
                else { match1 = false; break; }
            }
            Assert.AreEqual(true, match1);
        }

        [TestMethod]
        public void Testremovehead2()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL.removeHead();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;


            /// /////////////////////////////////////
            
            string dd =null;
            if (str2[0] =="20") { dd = str[0]; }
            Assert.AreEqual("10", dd);
           
        }

        [TestMethod]
        public void Testremovehead3()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL = Program.initialArr("C:/Users/edgu1/Desktop/222525.txt");
            pDLL.removeHead();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next!= null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
           
            str2[j] = head.str;


            /// /////////////////////////////////////
            string dd=null;
            if (i != j)
            {
                if (str[0] != str2[0])
                {
                    dd = str2[0];
                }
            }
            Assert.AreEqual("20", dd);
        }

        [TestMethod]
        public void Testremovetail()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToHead(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL.removeTail();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;


            /// /////////////////////////////////////
            bool match1 = false;
            for (int k = 1; k < i; k++)
            {
                if (str[k ] == str2[j]) { match1 = true; j--; }
                else { match1 = false; break; }
            }
            Assert.AreEqual(true, match1);
        }

        [TestMethod]
        public void Testremovetail2()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL.removeTail();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode tail = pDLL.tail;

            while (tail.previous != null)
            {

                str2[j] = tail.str;
                j++;
                tail = tail.previous;
            }
            str2[j] = tail.str;
            /// /////////////////////////////////////
            string dd = null;
            if (str2[0]=="6") { dd = str[j+1]; }
            Assert.AreEqual("54", dd);
        }

        [TestMethod]
        public void Testremovetail3()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }
            pDLL = Program.initialArr("C:/Users/edgu1/Desktop/222525.txt");
            pDLL.removeTail();
            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode tail = pDLL.tail;

            while (tail.previous != null)
            {

                str2[j] = tail.str;
                j++;
                tail = tail.previous;
            }
            str2[j] = tail.str;
            /// /////////////////////////////////////
                   
            string dd = null;
            if (i != j)
            {
                if (str[i] != str2[0])
                {
                    dd = str2[0];
                }
            }
            Assert.AreEqual("6", dd);
        }

        [TestMethod]
        public void Testresearch() {

            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode node =Program.search(pDLL, sn);
            Assert.AreEqual(16, node.number);
        }

        [TestMethod]
        public void Testresearch2()
        {

            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode node = Program.search(pDLL, sn);
            Assert.AreEqual(sn, node.str);
        }


        [TestMethod]
        public void TestremoveNode()
        {
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode delnode = new DLLNode(sn);
            DLLNode a= pDLL.removeNode( delnode);
            Assert.AreEqual(sn,a.str );
        }

        [TestMethod]
        public void TestremoveNode2()
        {

            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode delnode = new DLLNode(sn);
            DLLNode a = pDLL.removeNode(delnode);
            Assert.AreEqual(16, a.number);
        }

        [TestMethod]
        public void TestremoveNode3()
        {

            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode delnode = new DLLNode(sn);
            DLLNode a = pDLL.removeNode(delnode);

            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;
            /// /////////////////////////////////////
            bool match = true;
            if (str[15] != str2[15]) { match = false; }
            Assert.AreEqual(false, match);
        }

        [TestMethod]
        public void TestremoveNode4()
        {

            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {

                    DLLNode d = new DLLNode(line);
                    pDLL.addToTail(d);
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            string sn = "3";
            DLLNode delnode = new DLLNode(sn);
            DLLNode a = pDLL.removeNode(delnode);

            ////////////////////////
            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;
            /// /////////////////////////////////////
            string dd = null;
            for(int k = 0; k < i; k++)
            {
                if (str[k] != str2[k])
                {
                    dd = str2[k];break;
                }
            }
            Assert.AreEqual("33", dd);
        }

        [TestMethod]
        public void TestinitialArr() {
            //Program ss = new Program();
            /// Read the txt and insert into dllist   
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            pDLL =Program.initialArr("C:/Users/edgu1/Desktop/222525.txt");

            string[] str2 = new string[20];
            int j = 0;
            DLLNode head = pDLL.head;

            while (head.next != null)
            {

                str2[j] = head.str;
                j++;
                head = head.next;
            }
            Console.WriteLine(head.str);
            str2[j] = head.str;

            bool match = false;
            for (int k = 0; k < j; k++)
            {
                if (str[k] == str2[k]) { match = true; }
                else { match = false; break; }
            }
            Assert.AreEqual(true, match);
        }

        [TestMethod]
        public void TestinitialArr2()
        {
            //Program ss = new Program();
            /// Read the txt and insert into dllist   
            string[] str = new string[30];
            int i = 0;
            FileStream f = new FileStream("C:/Users/edgu1/Desktop/222525.txt", FileMode.Open, FileAccess.Read);
            DLList pDLL = new DLList();
            string line;
            try
            {
                StreamReader m_streamReader = new StreamReader(f);
                //StreamReader read txt
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                //read from head to tail by lines        
                while ((line = m_streamReader.ReadLine()) != null)
                {
                    str[i] = line;
                    i++;
                }
                m_streamReader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("errors" + e.ToString());
            }

            DLList pDLL1 = Program.initialArr("C:/Users/edgu1/Desktop/222525.txt");

            string[] str2 = new string[20];
            int j = 0;
            DLLNode tail = pDLL1.tail;

            while (tail.previous != null)
            {

                str2[j] = tail.str;
                j++;
                tail = tail.previous;
            }
            str2[j] = tail.str;

            bool match = false;
            for (int k = 0; k < i; k++)
            {
                if (str[k] == str2[j]) { match = true; j--; }
                else { match = false; break; }
            }
            Assert.AreEqual(true, match);
        }
    }
}
