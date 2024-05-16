using ClassLibraryExample;

namespace LibraryTests
{
    [TestClass]
    public class ClarissaLinkedListTests
    {


        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsStrigns_returnsStringData(string input)
        {
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();

            // act
            list.AddToBack(input);
            string result = list.Get(0);

            // assert
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_HeadReturnsTheData(string input)
        {
            
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();
            Node expected = new Node(input);

            // act
            list.AddToBack(input);

            Node result = list.Head;

            // assert
            Assert.AreEqual(result.Data, expected.Data);
        }

        [TestMethod]
        [DataRow("Toast")]
        public void LinkedListAcceptsAnItem_CreatesANodeInTheHead(string input)
        {

            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();


            // act
            list.AddToBack(input);

            // assert
            Assert.IsInstanceOfType(list.Head, typeof(Node));
        }

        [TestMethod]
        public void WhenLinkedListIsCreated_HeadISNull()
        {

            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();


            // act
            Node? result = list.Head;

            // assert
            Assert.IsNull(result);
        }

        [TestMethod]
        [DataRow("Foo", "Bar", "Baz")]
        [DataRow("lake", "picnic", "sun")]
        public void WhenLinkedListGetsMultipleItems_ItemsAreInCorrectOrder(string one, string two, string three)
        {

            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();


            // act
            list.Add(one);
            list.Add(two); 
            list.Add(three);

            string? resultOne = list.Get(0);
            string? resultTwo = list.Get(1);
            string? resultThree = list.Get(2);

            // assert
            Assert.AreEqual(resultOne, one);
            Assert.AreEqual(resultTwo, two);
            Assert.AreEqual(resultThree, three);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(10, 20, 3)]
        [DataRow(-1, 20, -3)]
        public void WhenLinkedListGetsIntegers_IntegersAreReturned(int one, int two, int three)
        {
            // arrange
            ClarissaLinkedList list = new ClarissaLinkedList();

            // act
            list.AddToBack(one);
            list.AddToBack(two);
            list.AddToBack(three);

            int result = list.Get(0);

            // assert
            Assert.AreEqual(result, one);
        }
    }
}