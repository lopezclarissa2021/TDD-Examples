using ClassLibraryExample;

namespace LibraryTests
{
    [TestClass]
    public class ClarissaLinkedListTests
    {

        // Creating a singly linked list that accepts strings
        /*
        shopping list

        bread
        milk 
        cheese
        */

        [TestMethod]
        
        public void LinkedListAcceptsStrigns_returnsStringData()
        {
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();

            // act
            string result = list.Get(1);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast", typeof(Node)]
        public void LinkedListAcceptsAnItem_HeadReturnsTheItem(string input)
        {
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();

            // act
            // add the input item to the list
            list.Add(input);
            Node result = list.Head;

            // assert
            Assert.AreEqual(result, new Node() { Data = "Toast"});
        }
    }
}