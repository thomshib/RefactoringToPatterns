using System;
using Xunit;
using Patterns;

namespace PatternsTest
{
    public class TagNodeTests
    {
        [Fact]
        public void TestOneNodeTree()
        {
            string expectedResult = "<orders></orders>";
            TagNode orders = new TagNode("orders");
            Assert.Equal(orders.ToString(), expectedResult);
        }


        [Fact]
        public void TestAddChildrenToTree()
        {
            string expectedResult = "<orders><order><item></item></order></orders>";
            TagNode orders = new TagNode("orders");
            TagNode order = new TagNode("order");
            TagNode item = new TagNode("item");

            order.Add(item);
            orders.Add(order);
            Assert.Equal(orders.ToString(), expectedResult);
        }


    }
}
