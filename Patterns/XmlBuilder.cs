
using System;
using System.Collections.Generic;
namespace Patterns
{
    public  class XmlBuilder
    {
        private TagNode _root;
        private TagNode _current;
        private TagNode _parent;
        public XmlBuilder(string nodeName)
        {
            _root = new TagNode(nodeName);
            _current = _root;
            _parent = _root;
        }

        public override string ToString(){
            return _root.ToString();
        }

        public void AddBelow(string nodeName)
        {
            var childNode = new TagNode(nodeName);
            _current.Add(childNode);
            _parent = _current;
            _current = childNode;
        }

        public void AddBeside(string nodeName)
        {
           var siblingNode = new TagNode(nodeName);
           _parent.Add(siblingNode);
           _current = siblingNode;
        }

        public void AddAttribute(string name, string value)
        {
            _current.AddAttributes(name,value);
        }

        public void AddValue(string value)
        {
            _current.SetValue(value);
        }
    }
}