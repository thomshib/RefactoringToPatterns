
using System;
using System.Collections.Generic;

namespace Patterns{
public class TagNode{

    private string _tagName;
    private string _tagAttribute = String.Empty;
    private string _tagValue = String.Empty;
    private List<TagNode> _children = new List<TagNode>();
    public TagNode(string name)
    {
        _tagName = name;
    }

    public  override string ToString(){
        string result = string.Empty;
        result += "<" + _tagName;
        if(_tagAttribute != String.Empty){
            result += _tagAttribute;
        }
        result += ">";

        foreach(var item in _children){
            result += item.ToString();
        }
        if(_tagValue != String.Empty){
            result += _tagValue;
        }
        result += "</" + _tagName + ">";
        return result; 
        
    }

        public void Add(TagNode item)
        {
            _children.Add(item);
        }

        public void AddAttributes(string name, string value)
        {
            _tagAttribute += " " + name + "='" + value + "'";
        }

        public void SetValue(string value)
        {
            _tagValue = value;
        }
    }
}