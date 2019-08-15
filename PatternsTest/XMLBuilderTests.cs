using System;
using Xunit;
using Patterns;

namespace PatternsTest
{
    public class XMLBuilderTests
    {
        [Fact]
        public void TestOneNodeTree()
        {
            string expectedResult = "<orders></orders>";
            XmlBuilder builder = new XmlBuilder("orders");
            Assert.Equal(builder.ToString(), expectedResult);
        }


        [Fact]
        public void TestAddBelowTree()
        {
            string expectedResult = "<orders><order><item></item></order></orders>";
            XmlBuilder builder = new XmlBuilder("orders");
            builder.AddBelow("order");
            builder.AddBelow("item");

            Assert.Equal(builder.ToString(), expectedResult);
        }

        [Fact]
         public void TestAddBesideTree()
        {
            string expectedResult = "<orders><order><item></item><item></item></order></orders>";
            XmlBuilder builder = new XmlBuilder("orders");
            builder.AddBelow("order");
            builder.AddBelow("item");
            builder.AddBeside("item");
            
            Assert.Equal(builder.ToString(), expectedResult);
        }

        [Fact]
        public void TestAddBelowWithAttributeToTree()
        {
            string expectedResult = "<orders><order number='1234' quantity='20'></order></orders>";
            XmlBuilder builder = new XmlBuilder("orders");
            builder.AddBelow("order");
            builder.AddAttribute("number" ,"1234");
            builder.AddAttribute("quantity" ,"20");

            Assert.Equal(builder.ToString(), expectedResult);
        }

        [Fact]
        public void TestAddBelowWithAttributeAndValueToTree()
        {
            string expectedResult = "<orders><order number='1234' quantity='20'>" +
            "<item number='x1786'>Car Door</item></order></orders>";

           
            XmlBuilder builder = new XmlBuilder("orders");
            builder.AddBelow("order");
            builder.AddAttribute("number" ,"1234");
            builder.AddAttribute("quantity" ,"20");
            builder.AddBelow("item");
            builder.AddAttribute("number" ,"x1786");
            builder.AddValue("Car Door");

            Assert.Equal(builder.ToString(), expectedResult);
        }
    }
}