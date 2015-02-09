using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Performance.Helpers.Util
{
    public class Node
    {
        public string Data { get; set; }

        public Node Parent { get; set; }

        public Node(string _data, Node _parent)
        {
            this.Data = _data;
            this.Parent = _parent;
        }

        public static Boolean isRoot(Node _node)
        {
            Boolean ret = false;
            if(_node.Data == "root" && _node.Parent == null)
            {
                ret = true;    
            }
            return ret;
        }
    }
}