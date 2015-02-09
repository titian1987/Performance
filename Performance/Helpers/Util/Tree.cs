using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Performance.Helpers.Util
{
    public class Tree
    {
        List<Node> TreeNodes;

        public Tree()
        {
            this.TreeNodes = new List<Node>();
            this.addRoot();
        }

        // private methods
        private void addRoot()
        {
            Node root = new Node("root", null);
            this.TreeNodes.Add(root);
        }

        private Node getRoot()
        {
            return this.TreeNodes.First();
        }

        // public methods
        public void AddNode(string _data, Node _parent)
        {
            Node newNodeToAdd;
            if(_data.ToLower() == "root")
            {
                throw new Exception("There is already a root for the current tree");
            }
            else
            {
                if (_parent == null)
                {
                    newNodeToAdd = new Node(_data, this.getRoot());
                }
                else
                {
                    if (this.TreeNodes.IndexOf(_parent) > 0)
                    {
                        newNodeToAdd = new Node(_data, _parent);
                        if (this.TreeNodes.IndexOf(newNodeToAdd) < 0)
                        {
                            this.TreeNodes.Add(newNodeToAdd);
                        }
                        else
                        {
                            throw new Exception("New node already exists");
                        }
                    }
                    else
                    {
                        throw new Exception("Parent does not exist");
                    }
                }
            }
        }
    }
}
