using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_try2_1401._05._22
{
    public class Node
    {
        public int value;
        public Node next;
    }
    public class NodeProcess
    {
        Node head = new Node();
        Node current;
        public NodeProcess()
        {
            head.value = 1;
            head.next = null;
            current = head;
        }
        public void PushFirstNode(int val)
        {
            Node Fadd = new Node();
            Fadd.value = val;
            head.next = head;
            head = Fadd;    
        }

        public void PushLastNode(int val)
        {
            Node lastadd = new Node();
            lastadd.value = val;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = lastadd;
        }
        public void PrintNode()
        {
            var crnt = head;
            while (crnt != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }

        }


    }
    
}
