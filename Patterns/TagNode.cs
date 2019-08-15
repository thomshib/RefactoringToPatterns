
using System;
using System.Collections.Generic;

namespace Patterns{
public class TagNode{

    private string _tagName;
    private List<TagNode> _children = new List<TagNode>();
    public TagNode(string name)
    {
        _tagName = name;
    }

    public  override string ToString(){
        string result = string.Empty;
        result += "<" + _tagName + ">";
        foreach(var item in _children){
            result += item.ToString();
        }
        result += "</" + _tagName + ">";
        return result; 
        
    }

        public void Add(TagNode item)
        {
            _children.Add(item);
        }
    }
}