using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Person 
    {
        public int Age;
        public string Name;
        
        public Person (int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public List<Person> family = new List<Person>();
        public void AddFamilyMember(Person familiar)
        {
            this.family.Add(familiar);
        }
    }
}
