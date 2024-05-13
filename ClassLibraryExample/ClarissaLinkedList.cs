using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExample
{
    public class Node
    {
        public string Data { get; set; }
    }
    public class ClarissaLinkedList
    {
        public Node Head { get; set; }

        public ClarissaLinkedList() { 
            Head = new Node();
        }
       
        public string Get(int  index)
        {
            return "";
        }
    }
}
