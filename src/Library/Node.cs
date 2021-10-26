using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node : Visitor
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

        public override int VisitAgeSum(Node person)
        {
            int result = 0;
            foreach (Person familiar in family)
            {
                result =+ familiar.Age;
            }
            return result;
        }
        
        public override int VisitOldest(Node person)
        {
            int result = 0;
            foreach (Person familiar in family)
            {
                if (familiar.Age > result)
                {
                    result = familiar.Age;
                }
            }
            return result;
        }

        public override string VisitLargestName(Node person)
        {
            string result = "";
            foreach (Person familiar in family)
            {
                if (familiar.Name.Length > result.Length)
                {
                    result = familiar.Name;
                }
            }
            return result;
        }
        
    }
}
