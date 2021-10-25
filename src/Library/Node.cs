using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        Person person;

        private List<Person> children = new List<Person>();

        public ReadOnlyCollection<Person> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Person n)
        {
            this.children.Add(n);
        }
        
    }
}
