namespace Netflix
{
    class DoublyLinkedList
    {

        public string[] str_name;
        // Structure of a Node 
        public class Node
        {
            public string name;
            public Node next;
            public Node prev;
        };
        Node start;
        //Node temp;

        // Function to insert at the end 
        public void insertEnd(string Name)
        {
            Node new_node;

            // If the list is empty, create a single node 
            // circular and doubly list 
            if (start == null)
            {
                new_node = new Node();
                new_node.name = Name;
                new_node.next = new_node.prev = new_node;
                start = new_node;
                return;
            }

            // If list is not empty 

            /* Find last node */
            Node last = (start).prev;

            // Create Node dynamically 
            new_node = new Node();
            new_node.name = Name;
            // Start is going to be next of new_node 
            new_node.next = start;

            // Make new node previous of start 
            (start).prev = new_node;

            // Make last preivous of new node 
            new_node.prev = last;

            // Make new node next of old last 
            last.next = new_node;
        }

        public void storeData(int n)
        {
            int i = 0;
            str_name = new string[n];

            Node temp = start;
            do
            {
                str_name[i] = temp.name;
                i++;
                temp = temp.next;

            } while (temp.next != start);
            str_name[i] = temp.name;
        }
    }
}
