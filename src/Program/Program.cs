using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(80, "p1");
            Node n1 = new Node(p1);
            Person p2 = new Person(70, "p2");
            Node n2 = new Node(p2);
            Person p3 = new Person(60, "p3");
            Node n3 = new Node(p3);
            Person p4 = new Person(50, "p4");
            Node n4 = new Node(p4);
            Person p5 = new Person(40, "p5");
            Node n5 = new Node(p5);
            Person p6 = new Person(30, "p6");
            Node n6 = new Node(p6);
            Person p7 = new Person(20, "p7");
            Node n7 = new Node(p7);
            Person p8 = new Person(10, "p8");
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            p1.AddFamilyMember(p1);
            p2.AddFamilyMember(p1);
            p3.AddFamilyMember(p1);
            p4.AddFamilyMember(p1);
            p5.AddFamilyMember(p1);
            p6.AddFamilyMember(p1);
            p7.AddFamilyMember(p1);
            p8.AddFamilyMember(p1);
        }
    }
}
