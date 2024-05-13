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
        public void LinkedListHasHead_HeadIsNotNull()
        {
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();

            // act
            Node result = list.Head;

            // assert
            Assert.IsNotNull(result);
        }
    }
}