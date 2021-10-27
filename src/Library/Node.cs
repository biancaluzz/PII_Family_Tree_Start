using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node 
    {
        Person person;
        public List<Person> family;

        private List<Node> children = new List<Node>();

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.VisitAgeSum(this);
            visitor.VisitOldest(this);
            visitor.VisitLargestName(this);
        }
    }
}
