namespace Netflix
{
    class LinkedList
    {
        public class Node
        {
            public string data;
            public Node next;
            public Node(string d) { data = d; next = null; }
        }
        public Node head;
        public void Push(string new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }
        public bool Search(string item)
        {
            Node tnode = head;
            while (tnode != null)
            {
                if (item == tnode.data)
                    return true;
                tnode = tnode.next;
            }
            return false;
        }
    }
}
