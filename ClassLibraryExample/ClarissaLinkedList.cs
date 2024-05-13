using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{ // node class for a linked list
    public class Node
    {
        public string Data { get; set; }
    }

    // the linked list class itself
    public class ClarissaLinkedList
    {
        public Node Head { get; set; }

        public ClarissaLinkedList() { 
            Head = new Node();
        }
       
        public string Get(int  index)
        {
            return Head.Data;
        }

        public void Add(string item)
        {
            Head = new Node { Data = item };
        }
    }
}
